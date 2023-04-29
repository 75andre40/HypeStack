Imports System.IO

Public Class ClsUtils
    Public Shared Property ProjPath As String = Application.StartupPath
    Public Shared Property GoBackInFolder As String = "..\..\..\..\..\"
    Public Shared Property ImagesArtigosPath As String = ProjPath + GoBackInFolder + "Resources\ImagensArtigos\"
    Public Shared Property ImagesCategoriasPath As String = ProjPath + GoBackInFolder + "Resources\ImagensCategorias\"
    Public Shared Property ImagesSubCategoriasPath As String = ProjPath + GoBackInFolder + "Resources\ImagensSubCategorias\"
    Public Shared Property ImagesMetodosPagamento As String = ProjPath + GoBackInFolder + "Resources\ImagensMetodosPagamento\"


    Public Shared Function ImageFromFileNotLocking(ByVal fileName As String) As Image

        Using fileStream As New FileStream(fileName, FileMode.Open, FileAccess.Read)
            Return Image.FromStream(fileStream, True, True)
        End Using

    End Function

End Class
Public Class ClsEntidadesFLG
    Public Property Descritivo As String
    Public Property Valor As String

    Public Sub New()

    End Sub

    Public Sub New(descritivo As String, valor As String)
        Me.Descritivo = descritivo
        Me.Valor = valor
    End Sub

End Class

Public Class ClsTotais
    Public Property Total_Iliquido As Decimal
    Public Property Total_Descontos As Decimal
    Public Property Total_IVA As Decimal
    Public Property Total_A_Pagar As Decimal
    Public Property Sum_P_Artigos As Decimal


    Sub New()
    End Sub

    Sub New(pLinhas As List(Of ClsLinhas))

        Dim T_Iliquido = pLinhas.Sum(Function(x) x.P_Unitario * (1 + (x.Taxa_Iva / 100)) * x.Quantidade)
        Dim T_A_Pagar = pLinhas.Sum(Function(x) x.P_Final * x.Quantidade)
        Dim T_IVA = pLinhas.Sum(Function(x) (x.P_Final - x.P_CDesconto) * x.Quantidade)
        Dim T_Descontos = pLinhas.Sum(Function(x) (Math.Round(x.P_Unitario * (1 + (x.Taxa_Iva / 100)), 2) - x.P_Final) * x.Quantidade)
        Dim S_P_Artigos = pLinhas.Sum(Function(x) x.P_Unitario * x.Quantidade)

        Total_Iliquido = Math.Round(T_Iliquido, 2)
        Total_A_Pagar = Math.Round(T_A_Pagar, 2)
        Total_IVA = Math.Round(T_IVA, 2)
        Total_Descontos = Math.Round(T_Descontos, 2)
        Sum_P_Artigos = Math.Round(S_P_Artigos, 2)

    End Sub

End Class

Friend Module Modulo1

    Public mListaClientes As List(Of ClsEntidades) = ClsEntidades.GetEntidades.FindAll(Function(x) _
    x.FLG_Entidade.Contains("C"))

    Public mListaArtigos As List(Of ClsArtigos) = ClsArtigos.GetArtigos

    Public ListaArtigos_Mode As String

    Public Sub Corners(obj As Form)

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
End Module
