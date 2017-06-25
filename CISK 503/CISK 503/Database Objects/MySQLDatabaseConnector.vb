﻿Imports MySql.Data.MySqlClient

Public Class MySQLDatabaseConnector
    Dim conn As New MySqlConnection
    Dim DatabaseName As String = "combsan1_tamuct"
    Dim server As String = "www.combsandcombs.com"
    Dim userName As String = "combsan1_tamuct"
    Dim password As String = "gii{M[Ag$=gb"

    ' Constructor
    Public Sub New()
        ' Start by making sure the conn is closed
        If Not conn Is Nothing Then conn.Close()

        ' Create the connection string
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)

        ' Try to open the connection
        Try
            conn.Open()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    ' Methods

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    ''' <param name="level"></param>
    ''' <exception cref="DatabaseException.AddAccountException"></exception>
    ''' <returns></returns>
    ''' <author>Brian Combs</author>
    ''' <date>June 25, 2017</date>
    Function AddNewUser(username As String, password As String, level As UserAccount.AccountLevel) As AccountInfo
        Dim cmd As New MySqlCommand("INSERT INTO `User` (`Password`, `Username`, `Account_Level`) VALUES (@password, @username, @level); SELECT LAST_INSERT_ID();", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@password", password)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@level", Convert.ToInt32(level))

        Try
            ' return a new account information if add is successful
            Return New AccountInfo(Convert.ToInt32(cmd.ExecuteScalar()), level)
        Catch ex As Exception
            ' otherwise throw exception
            Throw New DatabaseException.AddAccountException(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <exception cref="DatabaseException.LoginException">The Login Failed</exception>
    ''' <author>Brian Combs</author>
    ''' <date>June 25, 2017</date>
    Function LoginUser(username As String, password As String) As AccountInfo
        Dim cmd As New MySqlCommand("SELECT `ID`, `Account_Level` FROM `User` WHERE `Password` LIKE @password AND `Username` LIKE @username", conn)
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@password", password)
        cmd.Parameters.AddWithValue("@username", username)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim accountInfo As AccountInfo = Nothing

            While reader.Read()
                accountInfo = New AccountInfo()
                accountInfo.ID = reader.GetInt32("ID")
                accountInfo.Level = reader.GetInt32("Account_Level")
            End While

            reader.Close()

            Return accountInfo
        Catch ex As Exception
            ' otherwise throw exception
            Throw New DatabaseException(ex.Message)
        End Try
    End Function

    Sub ChangeAccountLevel(userID As Integer, newLevel As UserAccount.AccountLevel)

    End Sub

    ' Dispose
    Public Sub Dispose()
        conn.Close()
    End Sub


    Public Class AccountInfo
        Public Sub New() : End Sub
        Public Sub New(pID As Integer, pLevel As UserAccount.AccountLevel)
            ID = pID
            Level = pLevel
        End Sub

        Public ID As Integer
        Public Level As UserAccount.AccountLevel
    End Class

End Class
