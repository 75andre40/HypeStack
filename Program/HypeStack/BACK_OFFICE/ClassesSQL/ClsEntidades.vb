
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsEntidades Classe da Tabela Entidades
'''      Gerado em 29/11/2022 16:04:41
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsEntidades


    ' -----------------------------------------
    ' Property's da tabela Entidades
    ' -----------------------------------------

    Public Property Cod_Entidade As Integer                                 ' SQL_Type: int
    Public Property FLG_Entidade As String                                  ' Len:  1 - SQL_Type: nvarchar
    Public Property Nome As String                                          ' Len: 80 - SQL_Type: nvarchar
    Public Property Cod_Pais As String                                      ' Len:  2 - SQL_Type: nvarchar
    Public Property Num_Telefone As String                                  ' Len:  9 - SQL_Type: nvarchar
    Public Property Num_Telemovel As String                                 ' Len:  9 - SQL_Type: nvarchar
    Public Property Email As String                                         ' Len: 80 - SQL_Type: nvarchar
    Public Property NIF As String                                           ' Len:  9 - SQL_Type: nvarchar
    Public Property Data_Registo As Date                                    ' SQL_Type: smalldatetime
    Public Property Utilizador As String                                    ' Len: 20 - SQL_Type: nvarchar
    Public Property Password As String                                      ' Len: 45 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "E" & ClsEmpresas.GetContador(enCont.Entidades).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function

    Public Shared Function ModificaEntidadesPassword(ByVal pClsEntidades As ClsEntidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsEntidades.Cod_Entidade)
        mCMD.Parameters.AddWithValue("@pUtilizador", pClsEntidades.Utilizador.Substring(0, IIf(Len(pClsEntidades.Utilizador) > 20, 20, Len(pClsEntidades.Utilizador))))
        mCMD.Parameters.AddWithValue("@pPassword", pClsEntidades.Password.Substring(0, IIf(Len(pClsEntidades.Password) > 45, 45, Len(pClsEntidades.Password))))


        mStrSQL = "UPDATE Entidades SET "
        mStrSQL += "Utilizador=@pCod_Entidade,"
        mStrSQL += "Password=@pPassword "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GetEntidades() Método para devolver a Lista de Entidades
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      mListaEntidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetEntidades() As List(Of ClsEntidades)
        Dim mListaEntidades As New List(Of ClsEntidades)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,0) As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEntidades As New ClsEntidades

            With mClsEntidades
                .Cod_Entidade = mRDR.GetValue(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEntidades.Add(mClsEntidades)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaEntidades
    End Function

    Public Shared Function GetEntidadesByNome(ByVal pNome As String) As List(Of ClsEntidades)
        Dim mListaEntidades As New List(Of ClsEntidades)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,0) As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE Nome LIKE '%" & pNome & "%' "
        mStrSQL += "AND FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEntidades As New ClsEntidades

            With mClsEntidades
                .Cod_Entidade = mRDR.GetValue(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEntidades.Add(mClsEntidades)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaEntidades
    End Function

    Public Shared Function GetEntidadesByTipo(ByVal pTipo_Entidade As String) As List(Of ClsEntidades)
        Dim mListaEntidades As New List(Of ClsEntidades)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pTipo_Entidade", pTipo_Entidade)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,0) As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND FLG_Entidade=@pTipo_Entidade"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEntidades As New ClsEntidades

            With mClsEntidades
                .Cod_Entidade = mRDR.GetValue(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEntidades.Add(mClsEntidades)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaEntidades
    End Function


    ''' <summary>
    '''      Function GetEntidadesByCod(ByVal pCod_Entidade As Integer) Método para decolver uma Classe de Entidades
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      mClsEntidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetEntidadesByCod(ByVal pCod_Entidade As Integer) As ClsEntidades
        Dim mClsEntidades As New ClsEntidades

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCod_Entidade)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,0) As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Entidade=@pCod_Entidade"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsEntidades
                .Cod_Entidade = mRDR.GetValue(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsEntidades
    End Function


    ''' <summary>
    '''      Function ModificaEntidades(ByVal pClsEntidades As ClsEntidades) Método para Modificar a TABELA Entidades
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaEntidades(ByVal pClsEntidades As ClsEntidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsEntidades.Cod_Entidade)
        mCMD.Parameters.AddWithValue("@pFLG_Entidade", pClsEntidades.FLG_Entidade.Substring(0, IIf(Len(pClsEntidades.FLG_Entidade) > 1, 1, Len(pClsEntidades.FLG_Entidade))))
        mCMD.Parameters.AddWithValue("@pNome", pClsEntidades.Nome.Substring(0, IIf(Len(pClsEntidades.Nome) > 80, 80, Len(pClsEntidades.Nome))))
        mCMD.Parameters.AddWithValue("@pCod_Pais", pClsEntidades.Cod_Pais.Substring(0, IIf(Len(pClsEntidades.Cod_Pais) > 2, 2, Len(pClsEntidades.Cod_Pais))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pClsEntidades.Num_Telefone.Substring(0, IIf(Len(pClsEntidades.Num_Telefone) > 9, 9, Len(pClsEntidades.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pClsEntidades.Num_Telemovel.Substring(0, IIf(Len(pClsEntidades.Num_Telemovel) > 9, 9, Len(pClsEntidades.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pEmail", pClsEntidades.Email.Substring(0, IIf(Len(pClsEntidades.Email) > 80, 80, Len(pClsEntidades.Email))))
        mCMD.Parameters.AddWithValue("@pNIF", pClsEntidades.NIF.Substring(0, IIf(Len(pClsEntidades.NIF) > 9, 9, Len(pClsEntidades.NIF))))
        mCMD.Parameters.AddWithValue("@pData_Registo", pClsEntidades.Data_Registo)
        mCMD.Parameters.AddWithValue("@pUtilizador", pClsEntidades.Utilizador.Substring(0, IIf(Len(pClsEntidades.Utilizador) > 20, 20, Len(pClsEntidades.Utilizador))))
        mCMD.Parameters.AddWithValue("@pPassword", pClsEntidades.Password.Substring(0, IIf(Len(pClsEntidades.Password) > 45, 45, Len(pClsEntidades.Password))))


        mStrSQL = "UPDATE Entidades SET "
        mStrSQL += "FLG_Entidade=@pFLG_Entidade,"
        mStrSQL += "Nome=@pNome,"
        mStrSQL += "Cod_Pais=@pCod_Pais,"
        mStrSQL += "Num_Telefone=@pNum_Telefone,"
        mStrSQL += "Num_Telemovel=@pNum_Telemovel,"
        mStrSQL += "Email=@pEmail,"
        mStrSQL += "NIF=@pNIF,"
        mStrSQL += "Data_Registo=@pData_Registo,"
        mStrSQL += "Utilizador=@pUtilizador,"
        mStrSQL += "Password=@pPassword "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        If pClsEntidades.FLG_Entidade <> OldType And Adding = False Then
            ClsEmpresas.DowngradeContadores(OldType)
            ClsEmpresas.UpgradeContadores(pClsEntidades.FLG_Entidade)
        End If

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaEntidades(ByVal pNovoEntidades As ClsEntidades) Método para Gravar a TABELA Entidades
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaEntidades(ByVal pNovoEntidades As ClsEntidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        'mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoEntidades.Cod_Entidade)
        mCMD.Parameters.AddWithValue("@pFLG_Entidade", pNovoEntidades.FLG_Entidade.Substring(0, IIf(Len(pNovoEntidades.FLG_Entidade) > 1, 1, Len(pNovoEntidades.FLG_Entidade))))
        mCMD.Parameters.AddWithValue("@pNome", pNovoEntidades.Nome.Substring(0, IIf(Len(pNovoEntidades.Nome) > 80, 80, Len(pNovoEntidades.Nome))))
        mCMD.Parameters.AddWithValue("@pCod_Pais", pNovoEntidades.Cod_Pais.Substring(0, IIf(Len(pNovoEntidades.Cod_Pais) > 2, 2, Len(pNovoEntidades.Cod_Pais))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pNovoEntidades.Num_Telefone.Substring(0, IIf(Len(pNovoEntidades.Num_Telefone) > 9, 9, Len(pNovoEntidades.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pNovoEntidades.Num_Telemovel.Substring(0, IIf(Len(pNovoEntidades.Num_Telemovel) > 9, 9, Len(pNovoEntidades.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pEmail", pNovoEntidades.Email.Substring(0, IIf(Len(pNovoEntidades.Email) > 80, 80, Len(pNovoEntidades.Email))))
        mCMD.Parameters.AddWithValue("@pNIF", pNovoEntidades.NIF.Substring(0, IIf(Len(pNovoEntidades.NIF) > 9, 9, Len(pNovoEntidades.NIF))))
        mCMD.Parameters.AddWithValue("@pData_Registo", pNovoEntidades.Data_Registo)
        mCMD.Parameters.AddWithValue("@pUtilizador", pNovoEntidades.Utilizador.Substring(0, IIf(Len(pNovoEntidades.Utilizador) > 20, 20, Len(pNovoEntidades.Utilizador))))
        mCMD.Parameters.AddWithValue("@pPassword", pNovoEntidades.Password.Substring(0, IIf(Len(pNovoEntidades.Password) > 45, 45, Len(pNovoEntidades.Password))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoEntidades.FLG_Ativo)


        mStrSQL = "INSERT INTO Entidades "
        mStrSQL += "("
        'mStrSQL += "Cod_Entidade,"
        mStrSQL += "FLG_Entidade,"
        mStrSQL += "Nome,"
        mStrSQL += "Cod_Pais,"
        mStrSQL += "Num_Telefone,"
        mStrSQL += "Num_Telemovel,"
        mStrSQL += "Email,"
        mStrSQL += "NIF,"
        mStrSQL += "Data_Registo,"
        mStrSQL += "Utilizador,"
        mStrSQL += "Password,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        'mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pFLG_Entidade,"
        mStrSQL += "@pNome,"
        mStrSQL += "@pCod_Pais,"
        mStrSQL += "@pNum_Telefone,"
        mStrSQL += "@pNum_Telemovel,"
        mStrSQL += "@pEmail,"
        mStrSQL += "@pNIF,"
        mStrSQL += "@pData_Registo,"
        mStrSQL += "@pUtilizador,"
        mStrSQL += "@pPassword,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.UpgradeContadores(pNovoEntidades.FLG_Entidade)
            'ClsEmpresas.GravaContador(enCont.Entidades) '<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()


        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaEntidades(ByVal pCod_Entidade As Integer) Método para Apagar um Registo da Tabela Entidades
    '''      Gerado em 29/11/2022 16:04:41
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaEntidades(ByVal pCod_Entidade As Integer, ByVal pTipo_Entidade As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCod_Entidade)


        mStrSQL = "UPDATE Entidades SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        ClsEmpresas.DowngradeContadores(pTipo_Entidade)

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe EntidadesComparer 
'''      Gerado em 29/11/2022 16:04:41
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class EntidadesComparer
    Implements IEqualityComparer(Of ClsEntidades)

    Public Function Equals1(ByVal x As ClsEntidades, ByVal y As ClsEntidades) As Boolean Implements IEqualityComparer(Of ClsEntidades).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Entidade = y.Cod_Entidade) ' AndAlso (x.FLG_Entidade = y.FLG_Entidade)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsEntidades) As Integer Implements IEqualityComparer(Of ClsEntidades).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsEntidades_FLG_Entidade = pCls.FLG_Entidade.GetHashCode()
        Dim Hash_ClsEntidades_Cod_Entidade = pCls.Cod_Entidade.GetHashCode()

        Return Hash_ClsEntidades_Cod_Entidade 'Xor Hash_ClsEntidades_FLG_Entidade
    End Function
End Class
