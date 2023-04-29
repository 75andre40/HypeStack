Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class ClsUtils

    Public Shared Property OnedrivePath As String = Application.StartupPath & "..\..\..\..\..\Resources\"
    Public Shared Property ImagesArtigosPath As String = OnedrivePath + "ImagensArtigos\"
    Public Shared Property ImagesUsersPath As String = OnedrivePath + "ImagensUtilizadores\"
    Public Shared Property ImagesCategoriasPath As String = OnedrivePath + "ImagensCategorias\"
    Public Shared Property ImagesSubCategoriasPath As String = OnedrivePath + "ImagensSubCategorias\"
    Public Shared Property ImagesPagamentoPath As String = OnedrivePath + "ImagensMetodosPagamento\"

    Public Shared Sub Corners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 30, 30), 180, 90)
        DGP.AddLine(30, 0, obj.Width - 30, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 30, 0, 30, 30), -90, 90)
        DGP.AddLine(obj.Width, 30, obj.Width, obj.Height - 30)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 30, obj.Height - 30, 30, 30), 0, 90)
        DGP.AddLine(obj.Width - 30, obj.Height, 30, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 30, 30, 30), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)

    End Sub

    Public Shared Function ImageFromFileNotLocking(ByVal fileName As String) As Image

        Using fileStream As New FileStream(fileName, FileMode.Open, FileAccess.Read)
            Dim TempImage = Image.FromStream(fileStream, True, True)
            Return TempImage
        End Using

    End Function

    Public Shared Function AreSameImage(ByVal I1 As Image, ByVal I2 As Image) As Boolean
        Dim BM1 As Bitmap = I1
        Dim BM2 As Bitmap = I2
        For X = 0 To BM1.Width - 1
            For y = 0 To BM2.Height - 1
                If BM1.GetPixel(X, y) <> BM2.GetPixel(X, y) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Public Shared Function OrientedImageFromFile(ByVal photoFileName As String) As Image
        Dim img As Image = ImageFromFileNotLocking(photoFileName) 'get the image

        Dim pi As Imaging.PropertyItem = Array.Find(img.PropertyItems, Function(T As Imaging.PropertyItem) T.Id = &H112) '&H112 = PropertyTagOrientation
        If Not pi Is Nothing Then
            Select Case pi.Value(0) 'value format is array of Int16
                Case 3 : img.RotateFlip(RotateFlipType.Rotate180FlipNone) 'upside-down
                Case 6 : img.RotateFlip(RotateFlipType.Rotate90FlipNone) 'rotated right
                Case 8 : img.RotateFlip(RotateFlipType.Rotate270FlipNone) 'rotated left
            End Select
        End If
        Return img
    End Function

    Public Shared Function ResizeImage(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(290, 290))
    End Function

    Public Shared Function CheckTelemovel(number As String)
        Dim mReturn As Boolean = False

        Dim CheckNumber As Match = Regex.Match(number, "^9[1236][0-9]{7}")
        If CheckNumber.Success Then
            mReturn = True
        End If

        Return mReturn
    End Function

    Public Shared Function CheckTelefone(number As String)
        Dim mReturn As Boolean = False

        Dim CheckNumber As Match = Regex.Match(number, "2([1-9]{1}[0-9]{7}|[1-9]{2}[0-9]{6})")
        If CheckNumber.Success Then
            mReturn = True
        End If

        Return mReturn
    End Function

    Public Shared Function CheckNIF(ByVal nifNumber As String) As Boolean
        Dim tamanhoNumero As Integer = 9
        Dim filteredNumber As String = Regex.Match(nifNumber, "[0-9]+").Value

        If filteredNumber.Length <> tamanhoNumero OrElse Integer.Parse(filteredNumber(0).ToString()) = 0 Then
            Return False
        End If

        Dim calculoCheckSum As Integer = 0

        For i As Integer = 0 To tamanhoNumero - 1 - 1
            calculoCheckSum += (Integer.Parse(filteredNumber(i).ToString())) * (tamanhoNumero - i)
        Next

        Dim digitoVerificacao As Integer = 11 - (calculoCheckSum Mod 11)

        If digitoVerificacao > 9 Then
            digitoVerificacao = 0
        End If

        Return digitoVerificacao = Integer.Parse(filteredNumber(tamanhoNumero - 1).ToString())
    End Function

    Public Shared Function CheckEmail(email As String)
        Dim mReturn As Boolean = False

        Dim CheckString As Match = Regex.Match(email, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        If CheckString.Success Then
            mReturn = True
        End If

        Return mReturn
    End Function

End Class

Public Class ClsEntidadeAtual

    Public Shared Cod_Entidade As String

    Public Shared Nome As String = "<unnamed_person>"

    Public Shared Sub GetNome(User As String)

        Dim SQLString As String
        Dim SQLConnect As New SqlConnection
        Dim SQLCommand As New SqlCommand

        SQLString = "SELECT "
        SQLString += "Nome "
        SQLString += "FROM Entidades "
        SQLString += "WHERE Utilizador = '" & User & "'"

        SQLConnect.ConnectionString = My.Settings.Connection
        SQLCommand.CommandText = SQLString

        Try

            SQLConnect.Open()
            SQLCommand.Connection = SQLConnect

            Nome = SQLCommand.ExecuteScalar
            Cod_Entidade = User

        Catch ex As Exception
            MsgBox("Erro!")
        Finally
            SQLConnect.Close()
        End Try

    End Sub
End Class

Public Class ClsTipoEntidade

    Public Property Cod As String
    Public Property Descritivo As String
    Public Property Valor As String

    Public Shared TipoEntidade As New List(Of ClsTipoEntidade)

    Public Shared Sub ApplyTipoEntidade()
        TipoEntidade.Clear()


        For x As Integer = 0 To 3

            Dim ListaLocal As New ClsTipoEntidade

            ListaLocal.Cod = x

            If x = 0 Then
                ListaLocal.Descritivo = "Clientes"
                ListaLocal.Valor = "C"
            ElseIf x = 1 Then
                ListaLocal.Descritivo = "Fornecedores"
                ListaLocal.Valor = "F"
            ElseIf x = 2 Then
                ListaLocal.Descritivo = "Operadores"
                ListaLocal.Valor = "O"
            ElseIf x = 3 Then
                ListaLocal.Descritivo = "Administradores"
                ListaLocal.Valor = "A"
            End If
            TipoEntidade.Add(ListaLocal)

        Next

        Up_Down_Entidade.Maximum = (TipoEntidade.Count - 1)
    End Sub

End Class

Public Class TextChangedEventArgs
    Inherits System.EventArgs

    Public Property Text As String

    Public Sub New(ByVal text As String)
        Me.Text = text
    End Sub

End Class



Friend Module Module1
    Public Editing As Boolean = False
    Public Adding As Boolean = False
    Public IsAdmin As Boolean = False
    Public WithEvents Up_Down_Entidade As New NumericUpDown
    Public ChangedPic As Boolean = False
    Public ChangedPic1 As Boolean = False
    Public ChangedPic2 As Boolean = False
    Public ChangedPic3 As Boolean = False
    Public OldType As String
    Public WithEvents Up_Down_Ano_Trabalho As New NumericUpDown
    Public MinStockFilter As Boolean = False
    Public FormChoosedIdentifier As Integer
    Public TempUCBefore As ucMenuButton
    Public TempNumDoc As String
End Module
