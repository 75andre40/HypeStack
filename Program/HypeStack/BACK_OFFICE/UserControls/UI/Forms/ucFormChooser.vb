Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraBars.Objects
Imports DevExpress.XtraEditors

Partial Public Class ucFormChooser

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub tileBar_SelectedItemChanged(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles tileBar.SelectedItemChanged
        navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item)
    End Sub

    Private Sub TileClick(sender As Object, e As EventArgs)

        Dim Message As MsgBoxStyle = vbOK

        If Editing = True Then
            Message = MsgBox("Quaisquer mudanças efetuadas não guardadas irão ser perdidas." & vbCrLf & "Continuar?", MsgBoxStyle.OkCancel, "HypeStack")
        End If
        If Message = vbOK Then

            navigationFrame.Controls.Clear()
            Editing = False
            Adding = False
            MinStockFilter = False

            Dim ActiveControl As Control

            Select Case sender.tag
                Case "00" 'Passwords
                    ActiveControl = New ucPasswords
                    navigationFrame.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                Case 10 'Entidades
                    ActiveControl = New ucEntidades
                    navigationFrame.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                Case 11 'Documentos
                    ActiveControl = New ucDocumentos
                    navigationFrame.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                Case 20 'Artigos
                    ActiveControl = New ucArtigos
                    navigationFrame.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                Case 21 'Categorias
                    ActiveControl = New ucCategorias
                    navigationFrame.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                Case 22 'Sub-Categorias
                    ActiveControl = New ucSubCategorias
                    navigationFrame.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                Case 30 'Series
                    ActiveControl = New ucSeries
                    navigationFrame.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
                Case 31 'IVA
                    ActiveControl = New ucIVA
                    navigationFrame.Controls.Add(ActiveControl)
                    ActiveControl.Dock = DockStyle.Fill
            End Select

        End If
    End Sub
    Private Sub LoadContent(ByVal TopicIdentifier)

        Select Case TopicIdentifier
            Case 0
                Dim TilesNames() As String = {"Passwords"}
                For x As Integer = 0 To 0

                    Dim newItem As New TileBarItem()
                    newItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
                    newItem.Text = TilesNames(x)
                    newItem.Tag = 0 & x
                    newItem.TextAlignment = TileItemContentAlignment.MiddleCenter

                    AddHandler newItem.ItemClick, AddressOf Me.TileClick
                    tileBar.Groups(0).Items.Add(newItem)

                Next

            Case 1
                Dim TilesNames() As String = {"Entidades", "Documentos"}
                For x As Integer = 0 To 1

                    Dim newItem As New TileBarItem()
                    newItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
                    newItem.Text = TilesNames(x)
                    newItem.Tag = 1 & x
                    newItem.TextAlignment = TileItemContentAlignment.MiddleCenter

                    AddHandler newItem.ItemClick, AddressOf Me.TileClick
                    tileBar.Groups(0).Items.Add(newItem)

                Next

            Case 2
                Dim TilesNames() As String = {"Artigos", "Categorias", "Sub-Categorias"}
                For x As Integer = 0 To 2

                    Dim newItem As New TileBarItem()
                    newItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
                    newItem.Text = TilesNames(x)
                    newItem.Tag = 2 & x
                    newItem.TextAlignment = TileItemContentAlignment.MiddleCenter

                    AddHandler newItem.ItemClick, AddressOf Me.TileClick
                    tileBar.Groups(0).Items.Add(newItem)

                Next

            Case 3
                Dim TilesNames() As String = {"Series", "IVA"}
                For x As Integer = 0 To 1

                    Dim newItem As New TileBarItem()
                    newItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
                    newItem.Text = TilesNames(x)
                    newItem.Tag = 3 & x
                    newItem.TextAlignment = TileItemContentAlignment.MiddleCenter

                    AddHandler newItem.ItemClick, AddressOf Me.TileClick
                    tileBar.Groups(0).Items.Add(newItem)

                Next

        End Select

    End Sub

    Private Sub FormChooser_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim TempUC As New ucMenuButton
        TempUC = TempUCBefore

        LoadContent(TempUC.Purpose)

    End Sub
End Class
