
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsLinhas Classe da Tabela Linhas
'''      Gerado em 29/11/2022 16:04:41
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsLinhas


    ' -----------------------------------------
    ' Property's da tabela Linhas
    ' -----------------------------------------

    Public Property Num_Doc As String                                       ' Len: 11 - SQL_Type: nvarchar
    Public Property Num_Linha As Integer                                    ' SQL_Type: smallint
    Public Property Cod_Artigo As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Quantidade As Integer                                  ' SQL_Type: smallint
    Public Property strQuantidade As String
    Public Property strP_Final As String                                 ' SQL_Type: numeric
    Public Property P_Unitario As Decimal
    Public Property Str_PUnitario As String
    Public Property P_CDesconto As Decimal
    Public Property Taxa_Iva As Integer
    Public Property Str_TaxaIva As String
    Public Property P_Final As Decimal                                 ' SQL_Type: numeric
    Public Property Taxa_Desconto As String                                ' SQL_Type: smallint
    Public Property Designacao As String                                    'Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit
    Public Property Limpa As Boolean


    Sub New()
    End Sub

    Sub New(pNum_Doc As String, pLinha As Integer)
        Num_Doc = pNum_Doc
        Num_Linha = pLinha
        Cod_Artigo = ""
        strQuantidade = ""
        Quantidade = 0
        P_Final = 0
        strP_Final = ""
        Taxa_Desconto = ""
        Designacao = ""
        P_Unitario = 0
        Str_PUnitario = ""
        P_CDesconto = 0
        Taxa_Iva = 0
        Str_TaxaIva = ""

        Limpa = False
        FLG_Ativo = True
    End Sub

    Friend Shared Function Init_Linhas(pNum_Doc As String, Optional pLinha As Integer = 1) As List(Of ClsLinhas)
        Dim mLista As New List(Of ClsLinhas)

        For n As Integer = pLinha To My.Settings.MAX_Linhas
            Dim mClasse As New ClsLinhas(pNum_Doc, n)

            mLista.Add(mClasse)
        Next

        Return mLista
    End Function

    Sub New(pNum_Doc As String, pLinha As Integer, pCod_Artigo As String, pQTD As Integer, pArtigo As String, pPrecoUnitario As String, pP_CDesconto As Decimal, pPrecoFinal As String, pDesconto As Integer, pIVA As Decimal)
        Num_Doc = pNum_Doc
        Num_Linha = pLinha
        strQuantidade = CStr(pQTD)
        Quantidade = pQTD
        Cod_Artigo = pCod_Artigo
        Designacao = pArtigo
        P_Unitario = pPrecoUnitario
        P_Final = pPrecoFinal
        P_CDesconto = pP_CDesconto
        strP_Final = pPrecoFinal & "€"
        Taxa_Desconto = pDesconto & "%"
        Taxa_Iva = pIVA * 100

        Limpa = False
        FLG_Ativo = True

    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "L" & ClsEmpresas.GetContador(enCont.Linhas).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetLinhas() Método para devolver a Lista de Linhas
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      mListaLinhas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetLinhas(pNum_Doc As String) As List(Of ClsLinhas)
        Dim mListaLinhas As New List(Of ClsLinhas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(L.Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(L.Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(L.Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(L.Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(L.P_Final,0) As P_Final,"
        mStrSQL += "ISNULL(L.P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(L.Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(L.Taxa_Iva,0) As Taxa_Iva,"
        mStrSQL += "ISNULL(A.Designacao,0) As Designacao,"
        mStrSQL += "ISNULL(L.FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas AS L "
        mStrSQL += "INNER JOIN Artigos AS A "
        mStrSQL += "ON L.Cod_Artigo = A.Cod_Artigo "
        mStrSQL += "WHERE L.FLG_Ativo=1 "
        mStrSQL += "AND L.Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        Dim Num_Linha As Integer

        While mRDR.Read()

            Dim mClsLinhas As New ClsLinhas

            With mClsLinhas
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Final = mRDR.GetDecimal(mRDR.GetOrdinal("P_Final"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))

                Dim desc As String = .Taxa_Desconto.TrimEnd("%"c)

                .P_CDesconto = Math.Round(.P_Unitario - .P_Unitario * (desc / 100), 2)
                .Taxa_Iva = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Iva"))
                .Designacao = mRDR.GetValue(mRDR.GetOrdinal("Designacao"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

                .strP_Final = .P_Final & "€"
                .strQuantidade = .Quantidade
                .Str_PUnitario = .P_Unitario & "€"
                .Str_TaxaIva = .Taxa_Iva & "%"
                Num_Linha = .Num_Linha
            End With

            mListaLinhas.Add(mClsLinhas)

        End While

        'Cria linhas vazias para os restantes espaços no doc
        While Num_Linha <= 29
            Dim mClsLinhas As New ClsLinhas("", Num_Linha + 1)
            mListaLinhas.Add(mClsLinhas)
            Num_Linha += 1
        End While

        mRDR.Close()
        mDB.Close()

        Return mListaLinhas
    End Function


    ''' <summary>
    '''      Function GetLinhasByCod(ByVal pNum_Doc As String) Método para decolver uma Classe de Linhas
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      mClsLinhas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetLinhasByCod(ByVal pNum_Doc As String) As ClsLinhas
        Dim mClsLinhas As New ClsLinhas

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Final,0) As P_Final,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(Designacao,0) As Designacao,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsLinhas
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Final = mRDR.GetDecimal(mRDR.GetOrdinal("P_Final"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .Designacao = mRDR.GetValue(mRDR.GetOrdinal("Designacao"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsLinhas
    End Function


    ''' <summary>
    '''      Function ModificaLinhas(ByVal pClsLinhas As ClsLinhas) Método para Modificar a TABELA Linhas
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaLinhas(ByVal pClsLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pClsLinhas.Num_Doc.Substring(0, IIf(Len(pClsLinhas.Num_Doc) > 11, 11, Len(pClsLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pClsLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pClsLinhas.Cod_Artigo.Substring(0, IIf(Len(pClsLinhas.Cod_Artigo) > 8, 8, Len(pClsLinhas.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pQuantidade", pClsLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Final", pClsLinhas.P_Final)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pClsLinhas.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsLinhas.Designacao)


        mStrSQL = "UPDATE Linhas SET "
        mStrSQL += "Num_Linha=@pNum_Linha,"
        mStrSQL += "Cod_Artigo=@pCod_Artigo,"
        mStrSQL += "Quantidade=@pQuantidade,"
        mStrSQL += "P_Final=@pP_Final,"
        mStrSQL += "Taxa_Desconto=@pTaxa_Desconto"
        mStrSQL += "Designacao=@pDesignacao "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaLinhas(ByVal pNovoLinhas As ClsLinhas) Método para Gravar a TABELA Linhas
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaLinhas(ByVal pNovoLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoLinhas.Num_Doc.Substring(0, IIf(Len(pNovoLinhas.Num_Doc) > 11, 11, Len(pNovoLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pNovoLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pNovoLinhas.Cod_Artigo.Substring(0, IIf(Len(pNovoLinhas.Cod_Artigo) > 8, 8, Len(pNovoLinhas.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pQuantidade", pNovoLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Final", pNovoLinhas.P_Final)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoLinhas.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoLinhas.Designacao)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoLinhas.FLG_Ativo)


        mStrSQL = "INSERT INTO Linhas "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "Num_Linha,"
        mStrSQL += "Cod_Artigo,"
        mStrSQL += "Quantidade,"
        mStrSQL += "P_Final,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "Designacao,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pNum_Linha,"
        mStrSQL += "@pCod_Artigo,"
        mStrSQL += "@pQuantidade,"
        mStrSQL += "@pP_Final,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Linhas)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaLinhas(ByVal pNum_Doc As String) Método para Apagar um Registo da Tabela Linhas
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaLinhas(ByVal pNum_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "UPDATE Linhas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class
