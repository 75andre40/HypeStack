
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsSub_Categorias Classe da Tabela Sub_Categorias
'''      Gerado em 29/11/2022 16:04:41
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsSub_Categorias


    ' -----------------------------------------
    ' Property's da tabela Sub_Categorias
    ' -----------------------------------------

    Public Property Cod_Sub_Categoria As String                             ' Len:  9 - SQL_Type: nvarchar
    Public Property Cod_Categoria As String                                 ' Len:  6 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property Imagem As String                                        ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    Friend Shared Function GetNovoCodigo() As String

        Return "SUBCATG" & ClsEmpresas.GetContador(enCont.Sub_Categorias).ToString("00") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function

    Public Shared Function GetSub_CategoriasByNome(ByVal pNome As String) As List(Of ClsSub_Categorias)
        Dim mListaSub_Categorias As New List(Of ClsSub_Categorias)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Sub_Categoria,'') As Cod_Sub_Categoria,"
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Imagem,'') As Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Sub_Categorias "
        mStrSQL += "WHERE Designacao LIKE '%" & pNome & "%' "
        mStrSQL += "AND FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsSub_Categorias As New ClsSub_Categorias

            With mClsSub_Categorias
                .Cod_Sub_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Sub_Categoria"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaSub_Categorias.Add(mClsSub_Categorias)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaSub_Categorias
    End Function


    ''' <summary>
    '''      Function GetSub_Categorias() Método para devolver a Lista de Sub_Categorias
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      mListaSub_Categorias
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetSub_Categorias() As List(Of ClsSub_Categorias)
        Dim mListaSub_Categorias As New List(Of ClsSub_Categorias)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Sub_Categoria,'') As Cod_Sub_Categoria,"
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Imagem,'') As Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Sub_Categorias "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsSub_Categorias As New ClsSub_Categorias

            With mClsSub_Categorias
                .Cod_Sub_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Sub_Categoria"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaSub_Categorias.add(mClsSub_Categorias)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaSub_Categorias
    End Function

    ''' <summary>
    '''      Function FiltrarSub_Categorias Método para Filtrar os campos da lista de Sub_Categorias
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      mListaSub_Categorias
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarSub_Categorias(ByVal pFiltro As ClsSub_Categorias) As List(Of ClsSub_Categorias)
        Dim mListaSub_Categorias As New List(Of ClsSub_Categorias)
        Dim mLista As New List(Of ClsSub_Categorias)

        mListaSub_Categorias = GetSub_Categorias()

        mLista = mListaSub_Categorias.FindAll(Function(x) _
        x.Cod_Sub_Categoria.Contains(pFiltro.Cod_Sub_Categoria)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Categoria.Contains(pFiltro.Cod_Categoria) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetSub_CategoriasByCod(ByVal pCod_Sub_Categoria As String) Método para decolver uma Classe de Sub_Categorias
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      mClsSub_Categorias
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetSub_CategoriasByCod(ByVal pCod_Sub_Categoria As String) As ClsSub_Categorias
        Dim mClsSub_Categorias As New ClsSub_Categorias

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Sub_Categoria", pCod_Sub_Categoria)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Sub_Categoria,'') As Cod_Sub_Categoria,"
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Imagem,'') As Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Sub_Categorias "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Sub_Categoria=@pCod_Sub_Categoria"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsSub_Categorias
                .Cod_Sub_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Sub_Categoria"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsSub_Categorias
    End Function

    Public Shared Function GetSub_CategoriasByCategoria(ByVal pCod_Categoria As String) As List(Of ClsSub_Categorias)
        Dim mListaSub_Categorias As New List(Of ClsSub_Categorias)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pCod_Categoria)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Sub_Categoria,'') As Cod_Sub_Categoria,"
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Imagem,'') As Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Sub_Categorias "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Categoria=@pCod_Categoria"



        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsSub_Categorias As New ClsSub_Categorias

            With mClsSub_Categorias
                .Cod_Sub_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Sub_Categoria"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaSub_Categorias.Add(mClsSub_Categorias)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaSub_Categorias
    End Function

    ''' <summary>
    '''      Function ModificaSub_Categorias(ByVal pClsSub_Categorias As ClsSub_Categorias) Método para Modificar a TABELA Sub_Categorias
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaSub_Categorias(ByVal pClsSub_Categorias As ClsSub_Categorias) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Sub_Categoria", pClsSub_Categorias.Cod_Sub_Categoria.Substring(0, IIf(Len(pClsSub_Categorias.Cod_Sub_Categoria) > 9, 9, Len(pClsSub_Categorias.Cod_Sub_Categoria))))
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pClsSub_Categorias.Cod_Categoria.Substring(0, IIf(Len(pClsSub_Categorias.Cod_Categoria) > 6, 6, Len(pClsSub_Categorias.Cod_Categoria))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsSub_Categorias.Designacao.Substring(0, IIf(Len(pClsSub_Categorias.Designacao) > 50, 50, Len(pClsSub_Categorias.Designacao))))
        mCMD.Parameters.AddWithValue("@pImagem", pClsSub_Categorias.Imagem.Substring(0, IIf(Len(pClsSub_Categorias.Imagem) > 50, 50, Len(pClsSub_Categorias.Imagem))))


        mStrSQL = "UPDATE Sub_Categorias SET "
        mStrSQL += "Cod_Categoria=@pCod_Categoria,"
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Imagem=@pImagem "
        mStrSQL += "WHERE Cod_Sub_Categoria=@pCod_Sub_Categoria"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            Msgbox("ModificaSub_Categorias:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaSub_Categorias(ByVal pNovoSub_Categorias As ClsSub_Categorias) Método para Gravar a TABELA Sub_Categorias
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaSub_Categorias(ByVal pNovoSub_Categorias As ClsSub_Categorias) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Sub_Categoria", pNovoSub_Categorias.Cod_Sub_Categoria.Substring(0, IIf(Len(pNovoSub_Categorias.Cod_Sub_Categoria) > 9, 9, Len(pNovoSub_Categorias.Cod_Sub_Categoria))))
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pNovoSub_Categorias.Cod_Categoria.Substring(0, IIf(Len(pNovoSub_Categorias.Cod_Categoria) > 6, 6, Len(pNovoSub_Categorias.Cod_Categoria))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoSub_Categorias.Designacao.Substring(0, IIf(Len(pNovoSub_Categorias.Designacao) > 50, 50, Len(pNovoSub_Categorias.Designacao))))
        mCMD.Parameters.AddWithValue("@pImagem", pNovoSub_Categorias.Imagem.Substring(0, IIf(Len(pNovoSub_Categorias.Imagem) > 50, 50, Len(pNovoSub_Categorias.Imagem))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoSub_Categorias.FLG_Ativo)


        mStrSQL = "INSERT INTO Sub_Categorias "
        mStrSQL += "("
        mStrSQL += "Cod_Sub_Categoria,"
        mStrSQL += "Cod_Categoria,"
        mStrSQL += "Designacao,"
        mStrSQL += "Imagem,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Sub_Categoria,"
        mStrSQL += "@pCod_Categoria,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pImagem,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Sub_Categorias)
        Catch ex As Exception
            Msgbox("GravaSub_Categorias:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaSub_Categorias(ByVal pCod_Sub_Categoria As String) Método para Apagar um Registo da Tabela Sub_Categorias
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaSub_Categorias(ByVal pCod_Sub_Categoria As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Sub_Categoria", pCod_Sub_Categoria)


        mStrSQL = "UPDATE Sub_Categorias SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Sub_Categoria=@pCod_Sub_Categoria"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            Msgbox("ApagaSub_Categorias:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        ClsEmpresas.DowngradeContadores(4)

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Sub_CategoriasComparer 
'''      Gerado em 29/11/2022 16:04:41
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class Sub_CategoriasComparer
    Implements IEqualityComparer(Of ClsSub_Categorias)

    Public Function Equals1(ByVal x As ClsSub_Categorias, ByVal y As ClsSub_Categorias) As Boolean Implements IEqualityComparer(Of ClsSub_Categorias).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Sub_Categoria = y.Cod_Sub_Categoria) ' AndAlso (x.Cod_Categoria = y.Cod_Categoria)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsSub_Categorias) As Integer Implements IEqualityComparer(Of ClsSub_Categorias).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsSub_Categorias_Cod_Categoria = pCls.Cod_Categoria.GetHashCode()
        Dim Hash_ClsSub_Categorias_Cod_Sub_Categoria = pCls.Cod_Sub_Categoria.GetHashCode()

        Return Hash_ClsSub_Categorias_Cod_Sub_Categoria 'Xor Hash_ClsSub_Categorias_Cod_Categoria
    End Function
End Class
