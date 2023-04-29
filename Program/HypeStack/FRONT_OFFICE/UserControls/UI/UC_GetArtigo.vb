Imports System.ComponentModel

Public Class UC_GetArtigo

    Private Artigo As New ClsArtigos
    Public Shared Property Cod_Artigo As String

    Private Sub UC_GetArtigo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackgroundImage = My.Resources.BackgroundArtigo
        Get_Artigo()
    End Sub

    Private Sub Get_Artigo()


        Artigo = ClsArtigos.GetArtigosByCod(Cod_Artigo)

        Try
            Pic_Artigo.Image = ClsUtils.ImageFromFileNotLocking(ClsUtils.ImagesArtigosPath + Artigo.Imagem1)
        Catch ex As Exception
            Pic_Artigo.Image = My.Resources.NoImage
        End Try


        With Artigo
            Lbl_Nome.Text = .Designacao
            Lbl_Descricao.Text = .Descricao
            Lbl_Preco.Text = .P_Final
            Panel_Artigo.Tag = Cod_Artigo
        End With

        If Artigo.Stock <= 5 And Artigo.Stock <> 0 Then
            Lbl_Stock.Text = "Poucas Unidades"
            Lbl_Stock.ForeColor = Color.FromArgb(255, 123, 3)
        ElseIf Artigo.Stock > 5 Then
            Lbl_Stock.Text = "Em Stock"
            Lbl_Stock.ForeColor = Color.Green
        ElseIf Artigo.Stock = 0 Then
            Lbl_Stock.Text = "Sem Stock"
            Lbl_Stock.ForeColor = Color.DarkRed
            Pic_Add.Visible = False
        End If

        If Artigo.Desconto = 0 Then
            Lbl_PrecoDesconto.Visible = False
            Lbl_Euro2.Visible = False
        Else
            Lbl_PrecoDesconto.Text = Math.Round(Artigo.Preco_Venda * (1 + Artigo.Taxa_IVA), 2)
            Lbl_PrecoDesconto.Font = New Font("Cascadia Code", 9, FontStyle.Strikeout)
            Lbl_Preco.Text = Artigo.P_Final
        End If

        Lbl_PrecoDesconto.ForeColor = Color.FromArgb(205, 110, 0)
        Lbl_Euro2.ForeColor = Color.FromArgb(255, 123, 3)

        Lbl_Preco.ForeColor = Color.FromArgb(255, 123, 3)
        Lbl_Euro.ForeColor = Color.FromArgb(255, 123, 3)

        Pic_Add.Image = My.Resources.PlusIcon

    End Sub

    Private Sub Artigo_Click(sender As Object, e As EventArgs) Handles Panel_Artigo.Click, Lbl_Descricao.Click, Lbl_Nome.Click, Lbl_Preco.Click, Lbl_PrecoDesconto.Click, Lbl_Stock.Click, Pic_Artigo.Click

        frmUI.LblDoc.Focus() 'pra não dar focus na txt_search e não disparar nenhum evento

        UC_DetalhesArtigo.Cod_Artigo = Panel_Artigo.Tag
        ListaArtigos_Mode = "Detalhes"
        FrmDialog.Size = New Size(753, 387)

        FrmTransparente.Size = frmUI.Size
        FrmTransparente.Location = frmUI.Location

        FrmTransparente.Visible = True

        FrmDialog.StartPosition = FormStartPosition.CenterParent
        FrmDialog.ShowDialog()

    End Sub

    Private Sub Pic_Add_Click(sender As Object, e As EventArgs) Handles Pic_Add.Click

        frmUI.LblDoc.Focus() 'pra não dar focus na txt_search e não disparar nenhum evento

        Add_Linha()
    End Sub

    Private Sub CMS_Add_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS_Add.Opening
        If Not frmUI.menuAberto Is Nothing Then
            frmUI.menuAberto.Close()
        End If
        frmUI.menuAberto = CMS_Add
        TxtMenu_Qtd.Text = "1"
    End Sub

    Private Sub CMS_Add_Closed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles CMS_Add.Closed
        frmUI.menuAberto = Nothing
    End Sub

    Private Sub Add_Linha(Optional Qtd As Integer = 1)
        Dim mIndex As Integer

        Cod_Artigo = Panel_Artigo.Tag

        Artigo = ClsArtigos.GetArtigosByCod(Cod_Artigo)

        frmUI.Valida_Linha()
        mIndex = frmUI.mRowVazia.Index

        If frmUI.Valida_Artigo() = True Then
            If frmUI.Valida_Qtd = True Then
                Dim mIndexRep As Integer = frmUI.mRowRepetida.Index - 1
                If Qtd + frmUI.mDoc.Linhas(mIndexRep).Quantidade < Artigo.Stock Then
                    frmUI.mDoc.Linhas(mIndexRep) = New ClsLinhas(frmUI.mDoc.Num_Doc, mIndexRep + 1, Artigo.Cod_Artigo, frmUI.mDoc.Linhas(mIndexRep).Quantidade + Qtd, Artigo.Designacao, Artigo.Preco_Venda, Artigo.P_CDesconto, Artigo.P_Final, Artigo.Desconto, Artigo.Taxa_IVA)
                Else
                    MsgBox("Stock máximo alcançado!")
                    Exit Sub
                End If
            Else
                    MsgBox("Stock máximo alcançado!")
                Exit Sub
            End If
        Else
            If Qtd > Artigo.Stock Then
                MsgBox("A quantidade desejada não está desponível!")
                Exit Sub
            End If
            frmUI.mDoc.Linhas(mIndex) = New ClsLinhas(frmUI.mDoc.Num_Doc, mIndex + 1, Cod_Artigo, Qtd, Artigo.Designacao, Artigo.Preco_Venda, Artigo.P_CDesconto, Artigo.P_Final, Artigo.Desconto, Artigo.Taxa_IVA)
            If mIndex <= 28 Then
                frmUI.UG_Linhas.ActiveRow = frmUI.UG_Linhas.Rows(mIndex + 1)
            End If
        End If

        frmUI.UG_Linhas.ActiveRow.Update()

        frmUI.UG_Linhas.DataSource = frmUI.mDoc.Linhas

        frmUI.UG_Linhas.Refresh()

        frmUI.mTotais = New ClsTotais(frmUI.mDoc.Linhas)

        frmUI.Txt_TotalIliquido.Text = frmUI.mTotais.Total_Iliquido & "€"
        frmUI.Txt_TotalDesc.Text = frmUI.mTotais.Total_Descontos & "€"
        frmUI.Txt_TotalIVA.Text = frmUI.mTotais.Total_IVA & "€"
        frmUI.Txt_TotalPagar.Text = frmUI.mTotais.Total_A_Pagar & "€"

        frmUI.mDoc.QI = ClsQI.GetQI(frmUI.mDoc.Linhas)
        frmUI.Display_UG_QI()
    End Sub

    Private Sub BtnMenu_Add_Click(sender As Object, e As EventArgs) Handles BtnMenu_Add.Click
        Dim Qtd As Integer
        Qtd = CInt(TxtMenu_Qtd.Text)

        TxtMenu_Qtd.Text = Qtd + 1
    End Sub

    Private Sub BtnMenu_Remover_Click(sender As Object, e As EventArgs) Handles BtnMenu_Remover.Click
        Dim Qtd As Integer
        Qtd = CInt(TxtMenu_Qtd.Text)

        If Qtd = 1 Then
            Exit Sub
        Else
            TxtMenu_Qtd.Text = Qtd - 1
        End If

    End Sub

    Private Sub BtnMenu_Adicionar_Click(sender As Object, e As EventArgs) Handles BtnMenu_Adicionar.Click
        Dim Qtd As Integer
        Qtd = CInt(TxtMenu_Qtd.Text)

        Add_Linha(Qtd)
        CMS_Add.Close()
    End Sub

    Private Sub BtnMenu_Cancelar_Click(sender As Object, e As EventArgs) Handles BtnMenu_Cancelar.Click
        CMS_Add.Close()
    End Sub
End Class
