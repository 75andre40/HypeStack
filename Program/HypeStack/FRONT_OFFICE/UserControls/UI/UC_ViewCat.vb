Public Class UC_ViewCat

    Public Shared Property Categoria_Selct As String
    Public Shared Property SubCategoria_Selct As String
    Private Sub UC_ViewCat_Load(sender As Object, e As EventArgs) Handles Me.Load

        If ListaArtigos_Mode = "Categorias" Then
            Get_Categorias()
        ElseIf ListaArtigos_Mode = "SubCategorias" Then
            Get_SubCategorias()
        End If

    End Sub

    Private Sub Get_Categorias()

        Dim mListaCategorias As List(Of ClsCategorias) = ClsCategorias.GetCategorias

        For i As Integer = 0 To mListaCategorias.Count - 1

            Dim Categoria As New UC_GetCategorias
            UC_GetCategorias.Cod_Categoria = mListaCategorias(i).Cod_Categoria

            Categoria.Name = "Artigo" & i
            Me.Panel_Cat.Controls.Add(Categoria)

        Next
    End Sub

    Private Sub Get_SubCategorias()

        Dim mListaSubCategorias As List(Of ClsSub_Categorias) = ClsSub_Categorias.GetSub_CategoriasByTipo(Categoria_Selct)

        For i As Integer = 0 To mListaSubCategorias.Count - 1

            Dim Categoria As New UC_GetCategorias
            UC_GetCategorias.Cod_Categoria = mListaSubCategorias(i).Cod_Sub_Categoria

            Categoria.Name = "Artigo" & i
            Me.Panel_Cat.Controls.Add(Categoria)

        Next

        If mListaSubCategorias.Count > 5 Then
            FrmDialog.Size = New Size(815, 227)
            Me.Size = New Size(815, 225)
            Corners(FrmDialog)
        End If
    End Sub

    Private Sub Pic_Close_Click(sender As Object, e As EventArgs) Handles Pic_Close.Click
        FrmDialog.Close()
        FrmTransparente.Visible = False
    End Sub
End Class
