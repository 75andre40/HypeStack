Public Class UC_GetCategorias

    Public Shared Property Cod_Categoria As String
    Dim Categoria As New ClsCategorias
    Dim SubCategoria As New ClsSub_Categorias

    Private Sub UC_GetCategorias_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ListaArtigos_Mode = "Categorias" Then
            Get_Categoria()
        ElseIf ListaArtigos_Mode = "SubCategorias" Then
            Get_SubCategoria()
        End If
    End Sub

    Private Sub Get_Categoria()

        Categoria = ClsCategorias.GetCategoriasByCod(Cod_Categoria)

        Pic_Categoria.Image = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesCategoriasPath + Categoria.Imagem)
        Lbl_Nome.Text = Categoria.Designacao
        Panel_Categoria.Tag = Categoria.Cod_Categoria

    End Sub

    Private Sub Get_SubCategoria()

        SubCategoria = ClsSub_Categorias.GetSub_CategoriasByCod(Cod_Categoria)

        Pic_Categoria.Image = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesSubCategoriasPath + SubCategoria.Imagem)
        Lbl_Nome.Text = SubCategoria.Designacao
        Panel_Categoria.Tag = SubCategoria.Cod_Sub_Categoria


    End Sub

    Private Sub Categoria_Click(sender As Object, e As EventArgs) Handles Lbl_Nome.Click, Pic_Categoria.Click, Panel_Categoria.Click
        frmUI.Txt_Search.Clear()
        frmUI.Timer_Delay.Stop()

        FrmDialog.Visible = False
        FrmDialog.Close()
        FrmTransparente.Visible = False
        frmUI.Btn_SubCategorias.Enabled = True

        If ListaArtigos_Mode = "Categorias" Then
            UC_ViewCat.Categoria_Selct = Panel_Categoria.Tag

            frmUI.Lbl_Categoria.Visible = True
            frmUI.Lbl_SubCat.Visible = False
            frmUI.Lbl_Categoria.Text = "Categoria: " & Categoria.Designacao

        ElseIf ListaArtigos_Mode = "SubCategorias" Then
            UC_ViewCat.SubCategoria_Selct = Panel_Categoria.Tag

            frmUI.Lbl_SubCat.Visible = True
            frmUI.Lbl_SubCat.Text = "Sub categoria: " & SubCategoria.Designacao

        End If

        frmUI.Panel_ViewArt.BackgroundImage = Nothing

        frmUI.TopMost = True
        Load_Artigos()
        frmUI.TopMost = False

    End Sub

    Private Sub Load_Artigos()

        frmUI.Panel_ViewArt.Controls.Clear()

        Dim ViewArt As New UC_ViewArt
        frmUI.Panel_ViewArt.Controls.Add(ViewArt)
        ViewArt.Dock = DockStyle.Fill

    End Sub
End Class
