Public Class UC_DetalhesArtigo

    Public Shared Property Cod_Artigo As String

    Private Sub UC_DetalhesArtigo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_Info()
    End Sub

    Private Sub Get_Info()
        Dim Artigo As List(Of ClsArtigos)


        Artigo = mListaArtigos.FindAll(Function(x) _
        x.Cod_Artigo.Contains(Cod_Artigo)
        )


        Try
            Pic_1.Image = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesArtigosPath + Artigo(0).Imagem1)
        Catch ex As Exception
            Pic_1.Image = My.Resources.NoImage
        End Try

        Try
            Pic_2.Image = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesArtigosPath + Artigo(0).Imagem2)
        Catch ex As Exception
            Pic_2.Image = My.Resources.NoImage
        End Try

        Try
            Pic_3.Image = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesArtigosPath + Artigo(0).Imagem3)
        Catch ex As Exception
            Pic_3.Image = My.Resources.NoImage
        End Try


        With Artigo(0)
            Lbl_Nome.Text = .Designacao
            Lbl_Descricao.Text = .Descricao
            Lbl_Stock.Text = .Stock
            Lbl_Preco.Text = .P_Final & "€"

            If .Stock <= 5 And .Stock <> 0 Then
                Lbl_Stock.Text = "Poucas Unidades"
                Lbl_Stock.ForeColor = Color.FromArgb(255, 123, 3)
            ElseIf .Stock > 5 Then
                Lbl_Stock.Text = "Em Stock"
                Lbl_Stock.ForeColor = Color.Green
            ElseIf .Stock = 0 Then
                Lbl_Stock.Text = "Sem Stock"
                Lbl_Stock.ForeColor = Color.DarkRed
            End If

            If .Desconto = 0 Then
                Lbl_PrecoDesconto.Visible = False
            Else
                Lbl_PrecoDesconto.Text = Math.Round(Artigo(0).Preco_Venda * (1 + Artigo(0).Taxa_IVA), 2) & "€"
                Lbl_PrecoDesconto.Font = New Font("Cascadia Code", 9, FontStyle.Strikeout)
            End If

        End With

        If Panel_Descricao.HorizontalScroll.Enabled = True Then
            Lbl_Descricao.MaximumSize = New Size(245, Nothing)
        Else
            Lbl_Descricao.MaximumSize = New Size(260, Nothing)
        End If

        Lbl_PrecoDesconto.ForeColor = Color.FromArgb(205, 110, 0)

        Lbl_Preco.ForeColor = Color.FromArgb(255, 123, 3)



    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        FrmTransparente.Visible = False
        FrmDialog.Close()
    End Sub
End Class
