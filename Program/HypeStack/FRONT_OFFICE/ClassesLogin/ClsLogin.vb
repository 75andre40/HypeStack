Imports System.Data.SqlClient
Public Class ClsLogin

    Public Shared Sub LogIn_Action()
        Dim SQLString As String
        Dim SQLConnect As New SqlConnection
        Dim SQLCommand As New SqlCommand
        Dim SQLResult As String

        SQLString = "SELECT "
        SQLString += "Utilizador, "
        SQLString += "Password "
        SQLString += "FROM Entidades "
        SQLString += "WHERE Utilizador = '" & frmLogin.txtUser.txtContent.Text & "'"
        SQLString += " AND Password = '" & frmLogin.txtPassword.txtContent.Text & "'"

        SQLConnect.ConnectionString = My.Settings.Connection
        SQLCommand.CommandText = SQLString

        Try
            SQLConnect.Open()
            SQLCommand.Connection = SQLConnect
            SQLResult = SQLCommand.ExecuteScalar()
            If SQLResult <> Nothing Then

                frmLogin.Hide()
                frmLoginProgressBar.ShowDialog()
                frmUI.Show()
            Else
                frmLogin.lblLoginFailed.Visible = True
                frmLogin.tmrLoginFailed.Start()
            End If
        Catch ex As Exception
            MsgBox("Erro!")
        Finally
            SQLConnect.Close()
        End Try
    End Sub

End Class