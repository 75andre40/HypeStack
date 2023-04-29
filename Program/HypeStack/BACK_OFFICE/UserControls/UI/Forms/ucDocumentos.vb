Imports Infragistics.Win.UltraWinGrid

Public Class ucDocumentos

    Private ProgramLoaded = False



    Private Sub AnoAnterior(sender As Object, e As EventArgs) Handles picAnoAnterior.Click
        If Not Up_Down_Ano_Trabalho.Value = Up_Down_Ano_Trabalho.Minimum Then
            Up_Down_Ano_Trabalho.Value -= 1
            lblTextFiltro.Text = Up_Down_Ano_Trabalho.Value
            Load_Docs(Up_Down_Ano_Trabalho.Value & "-" & cbTipoDoc.cbContent.ActiveRow.Cells("FLG_Tipo_Doc").Text)
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
            Load_Docs(Up_Down_Ano_Trabalho.Value & "-" & cbTipoDoc.cbContent.ActiveRow.Cells("FLG_Tipo_Doc").Text)
        End If

        If Up_Down_Ano_Trabalho.Value = Up_Down_Ano_Trabalho.Maximum Then
            picAnoSeguinte.Visible = False
        End If

        picAnoAnterior.Visible = True
    End Sub

    Private Sub UC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Config_UP_DOWN()
        Up_Down_Ano_Trabalho.Value = ClsEmpresas.GetAnoAtual

        Load_Docs(Up_Down_Ano_Trabalho.Value & "-" & cbTipoDoc.cbContent.ActiveRow.Cells("FLG_Tipo_Doc").Text)

    End Sub

    Private Sub Load_Docs(Serie_Cod As String)
        Dim mSerie As String = Serie_Cod
        Dim mDocs As List(Of ClsDoc) = ClsDoc.GetDocBySerie(mSerie)
        Dim mView As List(Of ViewDoc) = ViewDoc.GetList(mDocs)

        ugDoc.DataSource = mView
        ugDoc.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        ugDoc.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
        ugDoc.DisplayLayout.GroupByBox.Hidden = True
        ugDoc.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        ugDoc.DisplayLayout.Override.HeaderClickAction = HeaderClickAction.Select
        For Each row In ugDoc.DisplayLayout.Rows
            row.Height = 30
        Next
        With ugDoc.DisplayLayout.Bands(0)
            With .Columns("Num_Doc")
                .Width = 50
                .CellActivation = Activation.NoEdit
                .Header.Caption = "Nº de Documento"
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .CellAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
            End With

            With .Columns("Entidade")
                .CellActivation = Activation.NoEdit
                .Header.Caption = "Destinatário"
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .CellAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
            End With

            Try
                .Columns.Add("btn")
            Catch ex As Exception

            End Try


            With .Columns("btn")
                .Width = 50
                .Hidden = False
                .Header.Caption = " "
                .Style = ColumnStyle.Button
                .ButtonDisplayStyle = ButtonDisplayStyle.Always
                .NullText = "Ver Documento"
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .CellAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
            End With

        End With

        Refresh_Counter()

    End Sub

    Private Sub Refresh_Counter()
        lblCounter.Text = "Total de " & ugDoc.Rows.Count & " documentos"
    End Sub

    Private Sub Config_UP_DOWN()
        Up_Down_Ano_Trabalho.Minimum = 0
        Up_Down_Ano_Trabalho.Maximum = ClsEmpresas.GetAnoAtual
    End Sub

    Private Sub IrAnoAtual() Handles btnIrAnoAtual.Click
        Config_UP_DOWN()
        Up_Down_Ano_Trabalho.Value = ClsEmpresas.GetAnoAtual
        lblTextFiltro.Text = Up_Down_Ano_Trabalho.Value

        Load_Docs(Up_Down_Ano_Trabalho.Value & "-" & cbTipoDoc.cbContent.ActiveRow.Cells("FLG_Tipo_Doc").Text)

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

    Private Sub TipoAlterado(sender As Object, e As TextChangedEventArgs) Handles cbTipoDoc.TextChangedCustom
        If ProgramLoaded Then
            Load_Docs(Up_Down_Ano_Trabalho.Value & "-" & cbTipoDoc.cbContent.ActiveRow.Cells("FLG_Tipo_Doc").Text)
        Else
            ProgramLoaded = True
        End If
    End Sub

    Private Sub UG_Button_Action(sender As Object, e As CellEventArgs) Handles ugDoc.ClickCellButton


        TempNumDoc = e.Cell.Row.Cells(0).Text

        Dim mxrFAT As New xrFat
        Dim mxrQI As New xrQI

        With mxrQI
            .ObjectDataSource1.Parameters(0).Value = TempNumDoc
        End With

        With mxrFAT
            .ObjectDataSource1.Parameters(0).Value = TempNumDoc
        End With

        DocumentViewer1.DocumentSource = mxrFAT
        DocumentViewer1.Update()
        DocumentViewer1.Refresh()
        DocumentViewer1.InitiateDocumentCreation()
    End Sub

    Private Sub IrAnoAtual(sender As Object, e As EventArgs) Handles btnIrAnoAtual.Click

    End Sub
End Class


Public Class ViewDoc

    Public Property Num_Doc As String

    Private _Cod_Entidade As String
    Public ReadOnly Property Entidade As String
        Get
            Return ClsEntidades.GetEntidadesByCod(_Cod_Entidade).Nome
        End Get
    End Property



    Sub New(base As ClsDoc)
        With base
            _Cod_Entidade = .Cod_Entidade
            Num_Doc = .Num_Doc

        End With
    End Sub

    Friend Shared Function GetList(base As List(Of ClsDoc)) As List(Of ViewDoc)
        Dim mLista As New List(Of ViewDoc)

        For Each doc In base
            mLista.Add(New ViewDoc(doc))
        Next

        Return mLista
    End Function

End Class