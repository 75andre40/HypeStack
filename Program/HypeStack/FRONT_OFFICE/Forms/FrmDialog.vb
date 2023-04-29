Public Class FrmDialog
    Private Sub FrmDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        ShowIcon = False

        Corners(Me)

        If ListaArtigos_Mode = "Detalhes" Then
            Get_Detalhes()

        ElseIf ListaArtigos_Mode = "Categorias" Then
            Get_Categorias()

        ElseIf ListaArtigos_Mode = "SubCategorias" Then
            Get_SubCategorias()

        End If
    End Sub

    Private Sub Get_Detalhes()
        Me.Panel_Dialog.Controls.Clear()
        Dim Detalhes_Artigo As New UC_DetalhesArtigo
        Me.Panel_Dialog.Controls.Add(Detalhes_Artigo)


    End Sub

    Private Sub Get_Categorias()
        Me.Panel_Dialog.Controls.Clear()
        Dim Categorias As New UC_ViewCat
        Me.Panel_Dialog.Controls.Add(Categorias)
    End Sub

    Private Sub Get_SubCategorias()
        Me.Panel_Dialog.Controls.Clear()
        Dim Categorias As New UC_ViewCat
        Me.Panel_Dialog.Controls.Add(Categorias)
    End Sub
End Class