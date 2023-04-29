
Imports System.Data.SqlClient


Public Class ClsGrava

    Shared mDB As New SqlConnection
    Shared mCMD As New SqlCommand
    Shared mTR As SqlTransaction

    Public Shared Function Grava_Documento(pDoc As ClsDoc, pTD As ClsTipos_Doc) As Boolean
        Dim mReturn As Boolean = True

        mDB.ConnectionString = My.Settings.Connection
        mDB.Open()
        mCMD.Connection = mDB
        mTR = mDB.BeginTransaction()
        mCMD.Transaction = mTR

        '------------------------------------------------
        'GravaDoc
        '------------------------------------------------

        If Not GravaDoc(pDoc) Then
            mTR.Rollback()
            mReturn = False
            GoTo ERRO
        End If

        For Each pLinha As ClsLinhas In pDoc.Linhas
            If pLinha.Cod_Artigo <> "" Then
                If Not GravaLinhas(pLinha) Then
                    mTR.Rollback()
                    mReturn = False
                    GoTo ERRO
                End If

                Dim mArtigo As New ClsArtigos
                mArtigo = ClsArtigos.GetArtigosByCod(pLinha.Cod_Artigo)

                If pTD.FLG_Stock Then
                    Select Case pTD.FLG_ESC
                        Case "E"
                            mArtigo.Stock += pLinha.Quantidade
                        Case "S"
                            mArtigo.Stock -= pLinha.Quantidade
                    End Select

                    If Not ModificaArtigos(mArtigo) Then
                        mTR.Rollback()
                        mReturn = False
                        GoTo ERRO
                    End If

                End If


            End If
        Next

        '------------------------------------------------
        'GravaContador
        '------------------------------------------------

        If Not GravaContador(pTD.Cod_Serie) Then
            mTR.Rollback()
            mReturn = False
            GoTo ERRO
        End If

        mTR.Commit()


ERRO:
        mDB.Close()
        Return mReturn
    End Function
    Shared Function GravaContador(pCod_Serie As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Serie", pCod_Serie)

        mStrSQL = "UPDATE Series SET "
        mStrSQL += "Contador=Contador+1 "
        mStrSQL += "WHERE Cod_Serie = @pCod_Serie"

        mCMD.CommandText = mStrSQL

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Grava Contador:" & vbCrLf & "Erro ao gravar o contador!" & vbCrLf & ex.ToString)
            mReturn = False
        End Try



        Return mReturn
    End Function


    Public Shared Function GravaDoc(ByVal pNovoDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        'mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoDoc.Num_Doc.Substring(0, IIf(Len(pNovoDoc.Num_Doc) > 11, 11, Len(pNovoDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pNovoDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pNovoDoc.FLG_Tipo_Doc) > 3, 3, Len(pNovoDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoDoc.Designacao.Substring(0, IIf(Len(pNovoDoc.Designacao) > 50, 50, Len(pNovoDoc.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pNovoDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoDoc.Cod_Entidade.Substring(0, IIf(Len(pNovoDoc.Cod_Entidade) > 5, 5, Len(pNovoDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pNovoDoc.Tipo_Pagamento.Substring(0, IIf(Len(pNovoDoc.Tipo_Pagamento) > 30, 30, Len(pNovoDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoDoc.FLG_Ativo)


        mStrSQL = "INSERT INTO Doc "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "FLG_Tipo_Doc,"
        mStrSQL += "Designacao,"
        mStrSQL += "Data_Doc,"
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Tipo_Pagamento,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pFLG_Tipo_Doc,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pData_Doc,"
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pTipo_Pagamento,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        'mDB.Open()
        'mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Doc)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        'mDB.Close()

        Return mReturn

    End Function


    Public Shared Function GravaLinhas(ByVal pNovoLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        'mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoLinhas.Num_Doc.Substring(0, IIf(Len(pNovoLinhas.Num_Doc) > 11, 11, Len(pNovoLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pNovoLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pNovoLinhas.Cod_Artigo.Substring(0, IIf(Len(pNovoLinhas.Cod_Artigo) > 8, 8, Len(pNovoLinhas.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pQuantidade", pNovoLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Unitario", pNovoLinhas.P_Unitario)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoLinhas.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pTaxa_Iva", pNovoLinhas.Taxa_Iva)
        mCMD.Parameters.AddWithValue("@pP_Final", pNovoLinhas.P_Final)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoLinhas.FLG_Ativo)


        mStrSQL = "INSERT INTO Linhas "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "Num_Linha,"
        mStrSQL += "Cod_Artigo,"
        mStrSQL += "Quantidade,"
        mStrSQL += "P_Unitario,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "Taxa_Iva,"
        mStrSQL += "P_Final,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pNum_Linha,"
        mStrSQL += "@pCod_Artigo,"
        mStrSQL += "@pQuantidade,"
        mStrSQL += "@pP_Unitario,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "@pTaxa_Iva,"
        mStrSQL += "@pP_Final,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL

        'mDB.Open()
        'mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Linhas)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        'mDB.Close()

        Return mReturn

    End Function


    Public Shared Function ModificaArtigos(ByVal pClsArtigos As ClsArtigos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pClsArtigos.Cod_Artigo.Substring(0, IIf(Len(pClsArtigos.Cod_Artigo) > 8, 8, Len(pClsArtigos.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pClsArtigos.Cod_Categoria.Substring(0, IIf(Len(pClsArtigos.Cod_Categoria) > 15, 15, Len(pClsArtigos.Cod_Categoria))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsArtigos.Designacao.Substring(0, IIf(Len(pClsArtigos.Designacao) > 100, 100, Len(pClsArtigos.Designacao))))
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pClsArtigos.Tipo_IVA.Substring(0, IIf(Len(pClsArtigos.Tipo_IVA) > 1, 1, Len(pClsArtigos.Tipo_IVA))))
        mCMD.Parameters.AddWithValue("@pStock", pClsArtigos.Stock)
        mCMD.Parameters.AddWithValue("@pPreco_Compra", pClsArtigos.Preco_Compra)
        mCMD.Parameters.AddWithValue("@pPreco_Venda", pClsArtigos.Preco_Venda)


        mStrSQL = "UPDATE Artigos SET "
        mStrSQL += "Cod_Categoria=@pCod_Categoria,"
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Tipo_IVA=@pTipo_IVA,"
        mStrSQL += "Stock=@pStock,"
        mStrSQL += "Preco_Compra=@pPreco_Compra,"
        mStrSQL += "Preco_Venda=@pPreco_Venda "
        mStrSQL += "WHERE Cod_Artigo=@pCod_Artigo"


        'mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        'mDB.Open()
        'mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        'mDB.Close()

        Return mReturn

    End Function





End Class


Public Class ClsQI 'QuadroIVA

    Public Property Num_Doc As String
    Public Property Tipo_Iva As String
    Public Property Taxa_Iva As Integer
    Public Property S_IVA As Decimal
    Public Property V_IVA As Decimal
    Public Property strS_IVA As String
    Public Property strV_IVA As String


    Sub New()
    End Sub

    Sub New(pTaxa_IVA As String, pLinhas As List(Of ClsLinhas), pTotais As ClsTotais)
        Num_Doc = pLinhas(0).Num_Doc
        Taxa_Iva = pTaxa_IVA

        If pLinhas.Count > 0 Then
            pLinhas = pLinhas.FindAll(Function(x) x.Taxa_Iva.Equals(Taxa_Iva))

            S_IVA = Math.Round(pLinhas.Sum(Function(x) x.P_CDesconto * x.Quantidade), 2)
            V_IVA = Math.Round(pLinhas.Sum(Function(x) (x.P_Final - x.P_CDesconto) * x.Quantidade), 2)
            strS_IVA = S_IVA & "€"
            strV_IVA = V_IVA & "€"
        End If

        Tipo_Iva = Taxa_Iva.ToString() & "%"

    End Sub

    Public Shared Function GetQIByCod(ByVal pNum_Doc As String) As List(Of ClsQI)
        Dim mReturn As New List(Of ClsQI)

        Dim mLinhas As New List(Of ClsLinhas)
        mLinhas = ClsLinhas.GetLinhas(pNum_Doc)


        mReturn = ClsQI.GetQI(mLinhas)

        Return mReturn

    End Function

    Friend Shared Function GetQI(pLinhas As List(Of ClsLinhas)) As List(Of ClsQI)
        Dim mListaQI As New List(Of ClsQI)
        Dim mLista_IVA As New List(Of ClsIVA)
        Dim mTotais As New ClsTotais(pLinhas)

        mLista_IVA = ClsIVA.GetIVA


        For Each pIVA As ClsIVA In mLista_IVA
            Dim mQI As New ClsQI(pIVA.Taxa_IVA, pLinhas, mTotais)

            mListaQI.Add(mQI)

        Next


        Return mListaQI
    End Function

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

''' <summary>
'''      Classe ClsDoc Classe da Tabela Doc
'''      Gerado em 29/11/2022 16:04:41
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>

Public Class ClsDoc


    ' -----------------------------------------
    ' Property's da tabela Doc
    ' -----------------------------------------

    Public Property Num_Doc As String                                       ' Len: 11 - SQL_Type: nvarchar
    Public Property FLG_Tipo_Doc As String                                  ' Len:  3 - SQL_Type: nvarchar
    Public Property Cod_Entidade As String                                  ' Len:  8 - SQL_Type: nvarchar
    Public Property Data_Doc As Date                                        ' SQL_Type: smalldatetime
    Public Property Tipo_Pagamento As String                                ' Len: 30 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit
    Public Property Designacao As String
    Public Property Linhas As New List(Of ClsLinhas)
    Public Property Totais As New ClsTotais()
    Public Property QI As New List(Of ClsQI)
    Public ReadOnly Property Entidade As ClsEntidades
        Get
            Return ClsEntidades.GetEntidadesByCod(Cod_Entidade)
        End Get
    End Property
    Public ReadOnly Property Empresa As ClsEmpresas
        Get
            Return ClsEmpresas.GetEmpresasByCod("1")
        End Get
    End Property

    Sub New()
        Data_Doc = Date.Now
        Linhas = ClsLinhas.Init_Linhas("", 1)
    End Sub

    Sub New(pTD As ClsTipos_Doc)

        Num_Doc = pTD.FLG_Tipo_Doc & (pTD.Contador + 1).ToString("0000") & "/" & pTD.Cod_Serie.Substring(0, 4)
        FLG_Tipo_Doc = pTD.FLG_Tipo_Doc
        Designacao = pTD.Descritivo_Impressao & "-" & Num_Doc
        Data_Doc = Date.Now
        Cod_Entidade = ""
        Tipo_Pagamento = "Pronto Pagamento"
        FLG_Ativo = True

        Linhas = ClsLinhas.Init_Linhas(Num_Doc, 1)
    End Sub

    Public Shared Function GetDocBySerie(pCod_Serie As String) As List(Of ClsDoc)
        Dim mListaDoc As New List(Of ClsDoc)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Doc "
        mStrSQL += "WHERE FLG_Ativo = 1 AND SUBSTRING(Num_Doc, 8, 4) = '" + pCod_Serie.Substring(0, 4) + "' AND FLG_Tipo_Doc = '" + pCod_Serie.Substring(5, 2) + "' "


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsDoc As New ClsDoc()

            With mClsDoc
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaDoc.Add(mClsDoc)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaDoc
    End Function

    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "D" & ClsEmpresas.GetContador(enCont.Doc).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetDoc() Método para devolver a Lista de Doc
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      mListaDoc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetDoc() As List(Of ClsDoc)
        Dim mListaDoc As New List(Of ClsDoc)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Doc "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsDoc As New ClsDoc

            With mClsDoc
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaDoc.Add(mClsDoc)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaDoc
    End Function


    ''' <summary>
    '''      Function GetDocByCod(ByVal pNum_Doc As String) Método para decolver uma Classe de Doc
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      mClsDoc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetDocByCod(ByVal pNum_Doc As String) As ClsDoc
        Dim mClsDoc As New ClsDoc

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Doc "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsDoc
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

                .Linhas = ClsLinhas.GetLinhas(.Num_Doc)
                .Totais = New ClsTotais(.Linhas)
                .QI = ClsQI.GetQI(.Linhas)


            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsDoc
    End Function


    ''' <summary>
    '''      Function ModificaDoc(ByVal pClsDoc As ClsDoc) Método para Modificar a TABELA Doc
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaDoc(ByVal pClsDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pClsDoc.Num_Doc.Substring(0, IIf(Len(pClsDoc.Num_Doc) > 11, 11, Len(pClsDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pClsDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pClsDoc.FLG_Tipo_Doc) > 3, 3, Len(pClsDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsDoc.Cod_Entidade.Substring(0, IIf(Len(pClsDoc.Cod_Entidade) > 8, 8, Len(pClsDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pClsDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pClsDoc.Tipo_Pagamento.Substring(0, IIf(Len(pClsDoc.Tipo_Pagamento) > 30, 30, Len(pClsDoc.Tipo_Pagamento))))


        mStrSQL = "UPDATE Doc SET "
        mStrSQL += "FLG_Tipo_Doc=@pFLG_Tipo_Doc,"
        mStrSQL += "Cod_Entidade=@pCod_Entidade,"
        mStrSQL += "Data_Doc=@pData_Doc,"
        mStrSQL += "Tipo_Pagamento=@pTipo_Pagamento,"
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaDoc(ByVal pNovoDoc As ClsDoc) Método para Gravar a TABELA Doc
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaDoc(ByVal pNovoDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoDoc.Num_Doc.Substring(0, IIf(Len(pNovoDoc.Num_Doc) > 11, 11, Len(pNovoDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pNovoDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pNovoDoc.FLG_Tipo_Doc) > 3, 3, Len(pNovoDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoDoc.Cod_Entidade.Substring(0, IIf(Len(pNovoDoc.Cod_Entidade) > 8, 8, Len(pNovoDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pNovoDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pNovoDoc.Tipo_Pagamento.Substring(0, IIf(Len(pNovoDoc.Tipo_Pagamento) > 30, 30, Len(pNovoDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoDoc.FLG_Ativo)


        mStrSQL = "INSERT INTO Doc "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "FLG_Tipo_Doc,"
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Data_Doc,"
        mStrSQL += "Tipo_Pagamento,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pFLG_Tipo_Doc,"
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pData_Doc,"
        mStrSQL += "@pTipo_Pagamento,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Doc)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaDoc(ByVal pNum_Doc As String) Método para Apagar um Registo da Tabela Doc
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaDoc(ByVal pNum_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "UPDATE Doc SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

