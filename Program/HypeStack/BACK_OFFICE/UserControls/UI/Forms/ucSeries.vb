Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid

Public Class ucSeries

    Private ProgramLoaded = False



    Private Sub AnoAnterior(sender As Object, e As EventArgs) Handles picAnoAnterior.Click
        If Not Up_Down_Ano_Trabalho.Value = Up_Down_Ano_Trabalho.Minimum Then
            Up_Down_Ano_Trabalho.Value -= 1
            lblTextFiltro.Text = Up_Down_Ano_Trabalho.Value
            Load_Docs(Up_Down_Ano_Trabalho.Value)
        End If

        If Up_Down_Ano_Trabalho.Value = Up_Down_Ano_Trabalho.Minimum Then
            picAnoAnterior.Visible = False
        End If

        picAnoSeguinte.Visible = True
    End Sub

    Private Sub AnoSeguinte(sender As Object, e As EventArgs) Handles picAnoSeguinte.Click
        If Not Up_Down_Ano_Trabalho.Value = Up_Down_Ano_Trabalho.Maximum Then
            Up_Down_Ano_Trabalho.Value += 1
            lblTextFiltro.Text = Up_Down_Ano_Trabalho.Value
            Load_Docs(Up_Down_Ano_Trabalho.Value)
        End If

        If Up_Down_Ano_Trabalho.Value = Up_Down_Ano_Trabalho.Maximum Then
            picAnoSeguinte.Visible = False
        End If

        picAnoAnterior.Visible = True
    End Sub

    Private Sub UC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Config_UP_DOWN()
        Up_Down_Ano_Trabalho.Value = ClsEmpresas.GetAnoAtual

        Load_Docs(Up_Down_Ano_Trabalho.Value)

    End Sub



    Private Sub Load_Docs(Ano As String)
        Dim mAno As String = Ano
        Dim mSeries As List(Of Series2) = Series2.GetSeriesByAno(Ano)

        'usData.DataSource = mSeries
        'usData.ValueMemberPath = "Contador"
        'usData.LabelMemberPath = "Contador"
        '
        'upcData.DataSource = mSeries
        'upcData.ValueMemberPath = "Contador"
        'upcData.LabelMemberPath = "Contador"
        '
        'upcData.Legend = UltraItemLegend1


        ugDoc.DataSource = mSeries
        ugDoc.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        ugDoc.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
        ugDoc.DisplayLayout.GroupByBox.Hidden = True
        ugDoc.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        ugDoc.DisplayLayout.Override.HeaderClickAction = HeaderClickAction.Select
        For Each row In ugDoc.DisplayLayout.Rows
            row.Height = 30
        Next
        With ugDoc.DisplayLayout.Bands(0)

            With .Columns("Ano_Trabalho")
                .Width = 390
                .CellActivation = Activation.NoEdit
                .Header.Caption = "Ano de Trabalho"
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .CellAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
            End With

            With .Columns("Designacao")
                .Header.VisiblePosition = 1
                .Width = 390
                .CellActivation = Activation.NoEdit
                .Header.Caption = "Tipo de Documento"
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .CellAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
            End With

            With .Columns("Contador")
                .Width = 390
                .CellActivation = Activation.NoEdit
                .Header.Caption = "Qtd. Documentos"
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .CellAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
            End With

            .Columns("Cod_Serie").Hidden = True
            .Columns("FLG_Ativo").Hidden = True
            .Columns("FLG_Tipo_Doc").Hidden = True

        End With

    End Sub

    Private Sub Config_UP_DOWN()
        Up_Down_Ano_Trabalho.Minimum = 0
        Up_Down_Ano_Trabalho.Maximum = ClsEmpresas.GetAnoAtual
    End Sub

    Private Sub IrAnoAtual() Handles btnIrAnoAtual.Click
        Config_UP_DOWN()
        Up_Down_Ano_Trabalho.Value = ClsEmpresas.GetAnoAtual
        lblTextFiltro.Text = Up_Down_Ano_Trabalho.Value

        Load_Docs(Up_Down_Ano_Trabalho.Value)

        picAnoSeguinte.Visible = False
    End Sub

    Private Sub NovoAno(sender As Object, e As EventArgs) Handles btnAtualizarAno.Click
        Dim Message As MsgBoxStyle = MsgBox("Deseja alterar o ano de exercício?", MsgBoxStyle.OkCancel, "HypeStack")

        If Message = vbOK Then

            Dim mAnoAtual As String = Year(Date.Now).ToString
            Dim mAnoBD As String = ClsEmpresas.GetAnoAtual

            If mAnoAtual <> mAnoBD Then

                If Not ClsEmpresas.Grava_AnoAtual(mAnoAtual) Then
                    MsgBox("Erro...")
                    Exit Sub
                End If
                '------------------------------------------
                'Cria os Cod_Serie para todos os Tipos_Doc
                '------------------------------------------
                If Not ClsSeries.Cria_Serie(mAnoAtual) Then
                    MsgBox("Erro...")
                    Exit Sub
                End If
            Else
                Dim Message2 As MsgBoxStyle = MsgBox("O ano não pode ser alterado pois já se encontra no ano atual.", MsgBoxStyle.OkOnly, "HypeStack")
            End If

        End If
    End Sub
End Class