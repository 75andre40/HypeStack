
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsArtigos Classe da Tabela Artigos
'''      Gerado em 29/11/2022 16:04:40
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsArtigos


    ' -----------------------------------------
    ' Property's da tabela Artigos
    ' -----------------------------------------

    Public Property Cod_Artigo As String                                    ' Len:  5 - SQL_Type: nvarchar
    Public Property Cod_Categoria As String                                 ' Len:  6 - SQL_Type: nvarchar
    Public Property Cod_Sub_Categoria As String                             ' Len:  9 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 60 - SQL_Type: nvarchar
    Public Property Descricao As String                                     ' Len:1000 - SQL_Type: nvarchar
    Public Property Stock As Integer                                        ' SQL_Type: int
    Public Property Tipo_IVA As String                                      ' Len:  4 - SQL_Type: nvarchar
    Public Property Preco_Compra As Decimal                                 ' SQL_Type: decimal
    Public Property Preco_Venda As Decimal                                  ' SQL_Type: decimal
    Public Property Desconto As Integer                                     ' SQL_Type: int
    Public Property Imagem1 As String                                       ' Len: 50 - SQL_Type: nvarchar
    Public Property Imagem2 As String                                       ' Len: 50 - SQL_Type: nvarchar
    Public Property Imagem3 As String                                       ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit
    Public ReadOnly Property Taxa_IVA As Decimal
        Get
            Dim mIva As New ClsIVA
            mIva = ClsIVA.GetIVATipo(Tipo_IVA)
            Taxa_IVA = mIva.Taxa_IVA / 100
        End Get
    End Property


    Sub New()
    End Sub


    Friend Shared Function GetNovoCodigo() As String

        Return "A" & ClsEmpresas.GetContador(enCont.Artigos).ToString("0000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function

    Public Shared Function GetArtigosByStock(ByVal pStock As String) As List(Of ClsArtigos)
        Dim mListaArtigos As New List(Of ClsArtigos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Cod_Sub_Categoria,'') As Cod_Sub_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Descricao,'') As Descricao,"
        mStrSQL += "ISNULL(Stock,0) As Stock,"
        mStrSQL += "ISNULL(Tipo_IVA,'') As Tipo_IVA,"
        mStrSQL += "ISNULL(Preco_Compra,0) As Preco_Compra,"
        mStrSQL += "ISNULL(Preco_Venda,0) As Preco_Venda,"
        mStrSQL += "ISNULL(Desconto,0) As Desconto,"
        mStrSQL += "ISNULL(Imagem1,'') As Imagem1,"
        mStrSQL += "ISNULL(Imagem2,'') As Imagem2,"
        mStrSQL += "ISNULL(Imagem3,'') As Imagem3,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE FLG_Ativo=1"
        mStrSQL += "AND Stock<=" & pStock


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsArtigos As New ClsArtigos

            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Cod_Sub_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Sub_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Descricao = mRDR.GetString(mRDR.GetOrdinal("Descricao"))
                .Stock = mRDR.GetValue(mRDR.GetOrdinal("Stock"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Preco_Compra = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Compra"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Desconto = mRDR.GetValue(mRDR.GetOrdinal("Desconto"))
                .Imagem1 = mRDR.GetString(mRDR.GetOrdinal("Imagem1"))
                .Imagem2 = mRDR.GetString(mRDR.GetOrdinal("Imagem2"))
                .Imagem3 = mRDR.GetString(mRDR.GetOrdinal("Imagem3"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaArtigos.Add(mClsArtigos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaArtigos
    End Function

    Public Shared Function GetArtigoByNome(ByVal pDesignacao As String) As List(Of ClsArtigos)
        Dim mListaArtigos As New List(Of ClsArtigos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Cod_Sub_Categoria,'') As Cod_Sub_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Descricao,'') As Descricao,"
        mStrSQL += "ISNULL(Stock,0) As Stock,"
        mStrSQL += "ISNULL(Tipo_IVA,'') As Tipo_IVA,"
        mStrSQL += "ISNULL(Preco_Compra,0) As Preco_Compra,"
        mStrSQL += "ISNULL(Preco_Venda,0) As Preco_Venda,"
        mStrSQL += "ISNULL(Desconto,0) As Desconto,"
        mStrSQL += "ISNULL(Imagem1,'') As Imagem1,"
        mStrSQL += "ISNULL(Imagem2,'') As Imagem2,"
        mStrSQL += "ISNULL(Imagem3,'') As Imagem3,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE Designacao LIKE '%" & pDesignacao & "%' "
        mStrSQL += "AND FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsArtigos As New ClsArtigos

            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Cod_Sub_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Sub_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Descricao = mRDR.GetString(mRDR.GetOrdinal("Descricao"))
                .Stock = mRDR.GetValue(mRDR.GetOrdinal("Stock"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Preco_Compra = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Compra"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Desconto = mRDR.GetValue(mRDR.GetOrdinal("Desconto"))
                .Imagem1 = mRDR.GetString(mRDR.GetOrdinal("Imagem1"))
                .Imagem2 = mRDR.GetString(mRDR.GetOrdinal("Imagem2"))
                .Imagem3 = mRDR.GetString(mRDR.GetOrdinal("Imagem3"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaArtigos.Add(mClsArtigos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaArtigos
    End Function

    ''' <summary>
    '''      Function GetArtigos() Método para devolver a Lista de Artigos
    '''      Gerado em 29/11/2022 16:04:40
    ''' </summary>
    ''' <returns>
    '''      mListaArtigos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>

    Public Shared Function GetArtigos() As List(Of ClsArtigos)
        Dim mListaArtigos As New List(Of ClsArtigos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Cod_Sub_Categoria,'') As Cod_Sub_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Descricao,'') As Descricao,"
        mStrSQL += "ISNULL(Stock,0) As Stock,"
        mStrSQL += "ISNULL(Tipo_IVA,'') As Tipo_IVA,"
        mStrSQL += "ISNULL(Preco_Compra,0) As Preco_Compra,"
        mStrSQL += "ISNULL(Preco_Venda,0) As Preco_Venda,"
        mStrSQL += "ISNULL(Desconto,0) As Desconto,"
        mStrSQL += "ISNULL(Imagem1,'') As Imagem1,"
        mStrSQL += "ISNULL(Imagem2,'') As Imagem2,"
        mStrSQL += "ISNULL(Imagem3,'') As Imagem3,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsArtigos As New ClsArtigos

            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Cod_Sub_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Sub_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Descricao = mRDR.GetString(mRDR.GetOrdinal("Descricao"))
                .Stock = mRDR.GetValue(mRDR.GetOrdinal("Stock"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Preco_Compra = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Compra"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Desconto = mRDR.GetValue(mRDR.GetOrdinal("Desconto"))
                .Imagem1 = mRDR.GetString(mRDR.GetOrdinal("Imagem1"))
                .Imagem2 = mRDR.GetString(mRDR.GetOrdinal("Imagem2"))
                .Imagem3 = mRDR.GetString(mRDR.GetOrdinal("Imagem3"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaArtigos.Add(mClsArtigos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaArtigos
    End Function

    ''' <summary>
    '''      Function FiltrarArtigos Método para Filtrar os campos da lista de Artigos
    '''      Gerado em 29/11/2022 16:04:40
    ''' </summary>
    ''' <returns>
    '''      mListaArtigos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarArtigos(ByVal pFiltro As ClsArtigos) As List(Of ClsArtigos)
        Dim mListaArtigos As New List(Of ClsArtigos)
        Dim mLista As New List(Of ClsArtigos)

        mListaArtigos = GetArtigos()

        mLista = mListaArtigos.FindAll(Function(x) _
        x.Cod_Artigo.Contains(pFiltro.Cod_Artigo)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Categoria.Contains(pFiltro.Cod_Categoria) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetArtigosByCod(ByVal pCod_Artigo As String) Método para decolver uma Classe de Artigos
    '''      Gerado em 29/11/2022 16:04:40
    ''' </summary>
    ''' <returns>
    '''      mClsArtigos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetArtigosByCod(ByVal pCod_Artigo As String) As ClsArtigos
        Dim mClsArtigos As New ClsArtigos

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pCod_Artigo)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Cod_Sub_Categoria,'') As Cod_Sub_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Descricao,'') As Descricao,"
        mStrSQL += "ISNULL(Stock,0) As Stock,"
        mStrSQL += "ISNULL(Tipo_IVA,'') As Tipo_IVA,"
        mStrSQL += "ISNULL(Preco_Compra,0) As Preco_Compra,"
        mStrSQL += "ISNULL(Preco_Venda,0) As Preco_Venda,"
        mStrSQL += "ISNULL(Desconto,0) As Desconto,"
        mStrSQL += "ISNULL(Imagem1,'') As Imagem1,"
        mStrSQL += "ISNULL(Imagem2,'') As Imagem2,"
        mStrSQL += "ISNULL(Imagem3,'') As Imagem3,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Artigo=@pCod_Artigo"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Cod_Sub_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Sub_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Descricao = mRDR.GetString(mRDR.GetOrdinal("Descricao"))
                .Stock = mRDR.GetValue(mRDR.GetOrdinal("Stock"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Preco_Compra = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Compra"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Desconto = mRDR.GetValue(mRDR.GetOrdinal("Desconto"))
                .Imagem1 = mRDR.GetString(mRDR.GetOrdinal("Imagem1"))
                .Imagem2 = mRDR.GetString(mRDR.GetOrdinal("Imagem2"))
                .Imagem3 = mRDR.GetString(mRDR.GetOrdinal("Imagem3"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsArtigos
    End Function


    ''' <summary>
    '''      Function ModificaArtigos(ByVal pClsArtigos As ClsArtigos) Método para Modificar a TABELA Artigos
    '''      Gerado em 29/11/2022 16:04:40
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaArtigos(ByVal pClsArtigos As ClsArtigos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pClsArtigos.Cod_Artigo.Substring(0, IIf(Len(pClsArtigos.Cod_Artigo) > 5, 5, Len(pClsArtigos.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pClsArtigos.Cod_Categoria.Substring(0, IIf(Len(pClsArtigos.Cod_Categoria) > 6, 6, Len(pClsArtigos.Cod_Categoria))))
        mCMD.Parameters.AddWithValue("@pCod_Sub_Categoria", pClsArtigos.Cod_Sub_Categoria.Substring(0, IIf(Len(pClsArtigos.Cod_Sub_Categoria) > 9, 9, Len(pClsArtigos.Cod_Sub_Categoria))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsArtigos.Designacao.Substring(0, IIf(Len(pClsArtigos.Designacao) > 60, 60, Len(pClsArtigos.Designacao))))
        mCMD.Parameters.AddWithValue("@pDescricao", pClsArtigos.Descricao.Substring(0, IIf(Len(pClsArtigos.Descricao) > 1000, 1000, Len(pClsArtigos.Descricao))))
        mCMD.Parameters.AddWithValue("@pStock", pClsArtigos.Stock)
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pClsArtigos.Tipo_IVA.Substring(0, IIf(Len(pClsArtigos.Tipo_IVA) > 4, 4, Len(pClsArtigos.Tipo_IVA))))
        mCMD.Parameters.AddWithValue("@pPreco_Compra", pClsArtigos.Preco_Compra)
        mCMD.Parameters.AddWithValue("@pPreco_Venda", pClsArtigos.Preco_Venda)
        mCMD.Parameters.AddWithValue("@pDesconto", pClsArtigos.Desconto)

        mStrSQL = "UPDATE Artigos SET "
        mStrSQL += "Cod_Categoria=@pCod_Categoria,"
        mStrSQL += "Cod_Sub_Categoria=@pCod_Sub_Categoria,"
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Descricao=@pDescricao,"
        mStrSQL += "Stock=@pStock,"
        mStrSQL += "Tipo_IVA=@pTipo_IVA,"
        mStrSQL += "Preco_Compra=@pPreco_Compra,"
        mStrSQL += "Preco_Venda=@pPreco_Venda,"
        mStrSQL += "Desconto=@pDesconto "
        mStrSQL += "WHERE Cod_Artigo=@pCod_Artigo"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaArtigos(ByVal pNovoArtigos As ClsArtigos) Método para Gravar a TABELA Artigos
    '''      Gerado em 29/11/2022 16:04:40
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaArtigos(ByVal pNovoArtigos As ClsArtigos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Artigo", pNovoArtigos.Cod_Artigo.Substring(0, IIf(Len(pNovoArtigos.Cod_Artigo) > 5, 5, Len(pNovoArtigos.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pNovoArtigos.Cod_Categoria.Substring(0, IIf(Len(pNovoArtigos.Cod_Categoria) > 6, 6, Len(pNovoArtigos.Cod_Categoria))))
        mCMD.Parameters.AddWithValue("@pCod_Sub_Categoria", pNovoArtigos.Cod_Sub_Categoria.Substring(0, IIf(Len(pNovoArtigos.Cod_Sub_Categoria) > 9, 9, Len(pNovoArtigos.Cod_Sub_Categoria))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoArtigos.Designacao.Substring(0, IIf(Len(pNovoArtigos.Designacao) > 60, 60, Len(pNovoArtigos.Designacao))))
        mCMD.Parameters.AddWithValue("@pDescricao", pNovoArtigos.Descricao.Substring(0, IIf(Len(pNovoArtigos.Descricao) > 1000, 1000, Len(pNovoArtigos.Descricao))))
        mCMD.Parameters.AddWithValue("@pStock", pNovoArtigos.Stock)
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pNovoArtigos.Tipo_IVA.Substring(0, IIf(Len(pNovoArtigos.Tipo_IVA) > 4, 4, Len(pNovoArtigos.Tipo_IVA))))
        mCMD.Parameters.AddWithValue("@pPreco_Compra", pNovoArtigos.Preco_Compra)
        mCMD.Parameters.AddWithValue("@pPreco_Venda", pNovoArtigos.Preco_Venda)
        mCMD.Parameters.AddWithValue("@pDesconto", pNovoArtigos.Desconto)
        mCMD.Parameters.AddWithValue("@pImagem1", pNovoArtigos.Imagem1.Substring(0, IIf(Len(pNovoArtigos.Imagem1) > 50, 50, Len(pNovoArtigos.Imagem1))))
        mCMD.Parameters.AddWithValue("@pImagem2", pNovoArtigos.Imagem2.Substring(0, IIf(Len(pNovoArtigos.Imagem2) > 50, 50, Len(pNovoArtigos.Imagem2))))
        mCMD.Parameters.AddWithValue("@pImagem3", pNovoArtigos.Imagem3.Substring(0, IIf(Len(pNovoArtigos.Imagem3) > 50, 50, Len(pNovoArtigos.Imagem3))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoArtigos.FLG_Ativo)


        mStrSQL = "INSERT INTO Artigos "
        mStrSQL += "("
        mStrSQL += "Cod_Artigo,"
        mStrSQL += "Cod_Categoria,"
        mStrSQL += "Cod_Sub_Categoria,"
        mStrSQL += "Designacao,"
        mStrSQL += "Descricao,"
        mStrSQL += "Stock,"
        mStrSQL += "Tipo_IVA,"
        mStrSQL += "Preco_Compra,"
        mStrSQL += "Preco_Venda,"
        mStrSQL += "Desconto,"
        mStrSQL += "Imagem1,"
        mStrSQL += "Imagem2,"
        mStrSQL += "Imagem3,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Artigo,"
        mStrSQL += "@pCod_Categoria,"
        mStrSQL += "@pCod_Sub_Categoria,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pDescricao,"
        mStrSQL += "@pStock,"
        mStrSQL += "@pTipo_IVA,"
        mStrSQL += "@pPreco_Compra,"
        mStrSQL += "@pPreco_Venda,"
        mStrSQL += "@pDesconto,"
        mStrSQL += "@pCod_Artigo + '_1.jpg',"
        mStrSQL += "@pCod_Artigo + '_2.jpg',"
        mStrSQL += "@pCod_Artigo + '_3.jpg',"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Artigos)
        Catch ex As Exception
            MsgBox("GravaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaArtigos(ByVal pCod_Artigo As String) Método para Apagar um Registo da Tabela Artigos
    '''      Gerado em 29/11/2022 16:04:40
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaArtigo(ByVal pCod_Artigo As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Artigo", pCod_Artigo)


        mStrSQL = "UPDATE Artigos SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Artigo=@pCod_Artigo"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe ArtigosComparer 
'''      Gerado em 29/11/2022 16:04:40
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ArtigosComparer
    Implements IEqualityComparer(Of ClsArtigos)

    Public Function Equals1(ByVal x As ClsArtigos, ByVal y As ClsArtigos) As Boolean Implements IEqualityComparer(Of ClsArtigos).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Artigo = y.Cod_Artigo) ' AndAlso (x.Cod_Categoria = y.Cod_Categoria)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsArtigos) As Integer Implements IEqualityComparer(Of ClsArtigos).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsArtigos_Cod_Categoria = pCls.Cod_Categoria.GetHashCode()
        Dim Hash_ClsArtigos_Cod_Artigo = pCls.Cod_Artigo.GetHashCode()

        Return Hash_ClsArtigos_Cod_Artigo 'Xor Hash_ClsArtigos_Cod_Categoria
    End Function
End Class
