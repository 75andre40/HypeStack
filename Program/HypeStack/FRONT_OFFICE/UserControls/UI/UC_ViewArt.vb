
Public Class UC_ViewArt
    Public Shared mLista As New List(Of ClsArtigos)
    Private Sub ViewArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewArt_Config()
    End Sub
    ''' <summary>
    ''' quando fazemos get, mostramos so os primeiros 25 atigos
    ''' e quando trocamos de pagina, mostra do 26 ao 51 etc etc
    ''' </summary>
    Private Sub ViewArt_Config()

        If ListaArtigos_Mode = "Categorias" Then
            FiltraArtigosByCategoria(UC_ViewCat.Categoria_Selct)
        ElseIf ListaArtigos_Mode = "SubCategorias" Then
            FiltraArtigosByCategoria(UC_ViewCat.SubCategoria_Selct)
        ElseIf ListaArtigos_Mode = "Pesquisa" Then
            FiltraArtigosByPesquisa(frmUI.Txt_Search.Text)
        End If

        If mLista.Count = 0 Then
            Panel_Artigos.BackgroundImage = My.Resources.LogoWhite
            Panel_Artigos.BackgroundImageLayout = ImageLayout.Zoom
        Else
            For i As Integer = 0 To mLista.Count - 1

                Dim Artigo As New UC_GetArtigo
                UC_GetArtigo.Cod_Artigo = mLista(i).Cod_Artigo

                Artigo.Name = "Artigo" & i
                Me.Panel_Artigos.Controls.Add(Artigo)

            Next
        End If


    End Sub

    Public Shared Function FiltraArtigosByCategoria(ByVal Filtro As String) As List(Of ClsArtigos)

        If ListaArtigos_Mode = "Categorias" Then
            mLista = mListaArtigos.FindAll(Function(x) _
        x.Cod_Categoria.Contains(Filtro)
        )
        ElseIf ListaArtigos_Mode = "SubCategorias" Then
            mLista = mListaArtigos.FindAll(Function(x) _
        x.Cod_Sub_Categoria.Contains(Filtro)
        )
        End If

        Return mLista
    End Function

    Public Shared Function FiltraArtigosByPesquisa(ByVal Filtro As String) As List(Of ClsArtigos)

        If Filtro <> "" Then
            If UC_ViewCat.SubCategoria_Selct <> "" Then
                mLista = mListaArtigos.FindAll(Function(x) x.Designacao.ToLower.Contains(Filtro.ToLower) And x.Cod_Sub_Categoria = UC_ViewCat.SubCategoria_Selct)
            ElseIf UC_ViewCat.Categoria_Selct <> "" Then
                mLista = mListaArtigos.FindAll(Function(x) x.Designacao.ToLower.Contains(Filtro.ToLower) And x.Cod_Categoria = UC_ViewCat.Categoria_Selct)
            ElseIf UC_ViewCat.Categoria_Selct = "" And UC_ViewCat.SubCategoria_Selct = "" Then
                mLista = mListaArtigos.FindAll(Function(x) x.Designacao.ToLower.Contains(Filtro.ToLower))
            End If
        Else

            If UC_ViewCat.SubCategoria_Selct <> "" Then
                mLista = mListaArtigos.FindAll(Function(x) x.Cod_Sub_Categoria = UC_ViewCat.SubCategoria_Selct)
            ElseIf UC_ViewCat.Categoria_Selct <> "" Then
                mLista = mListaArtigos.FindAll(Function(x) x.Cod_Categoria = UC_ViewCat.Categoria_Selct)
            ElseIf UC_ViewCat.Categoria_Selct = "" And UC_ViewCat.SubCategoria_Selct = "" Then
                mLista.Clear()
            End If
        End If

        Return mLista
    End Function

End Class
