﻿Public Class formMain
    Public Shared mysql As MySQLDatabaseConnector
    Dim user As Patron

    ' Form load
    ''' <summary>
    ''' Form load event, sets the tab control properties, creates the mySQL object and fills any default values/dropdowns
    ''' </summary>
    Private Sub formMain_Load() Handles Me.Load
        ' This code hides the tabs at runtime
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        ' Make sure the menu is locked down until login
        PatronToolStripMenuItem.Enabled = False
        CirculationToolStripMenuItem.Enabled = False
        AdministrationToolStripMenuItem.Enabled = False
        AcceptButton = Nothing

        ' Load the Database Connection
        Try
            mysql = New MySQLDatabaseConnector()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' Load the account level enumeration into the combo boxes as needed
        cmboxAccountTypeAddAccount.DataSource = [Enum].GetValues(GetType(Patron.AccountLevel))


    End Sub

    ' Login Page
    ''' <summary>
    ''' This method will log the user out
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Brian Combs</author>
    ''' <date>June 25, 2017</date>
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        ' Set the account to null
        user = Nothing
        ' Change the button text to Login
        LoginToolStripMenuItem.Text = "&Log In"
        ' Move to the login page
        TabControl1.SelectedIndex = 1
        AcceptButton = btnLogin
        ' Disable the permissions
        PatronToolStripMenuItem.Enabled = False
        CirculationToolStripMenuItem.Enabled = False
        AdministrationToolStripMenuItem.Enabled = False
    End Sub
    ''' <summary>
    ''' This method is used for the Login click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Brian Combs</author>
    ''' <date>June 25, 2017</date>
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        errProvider.Clear()
        ' Validate the username is not blank or whitespace
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            errProvider.SetError(txtUsername, "Please enter the username")
            Return
        End If

        ' Validate the password is not blank or whitespace
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            errProvider.SetError(txtPassword, "Please enter the password")
            Return
        End If

        Try
            ' Login the account
            user = New Patron(mysql, txtUsername.Text, txtPassword.Text)
            ' No exception was thrown, continue to set the text and permissions
            LoginToolStripMenuItem.Text = "&Log Out"
            PatronToolStripMenuItem.Enabled = True
            CirculationToolStripMenuItem.Enabled = user.Level >= 0
            AdministrationToolStripMenuItem.Enabled = user.Level >= 1
            ' Move to welcome page
            TabControl1.SelectedIndex = 0
            ' Clear the form for future use
            txtUsername.Text = ""
            txtPassword.Text = ""
        Catch ex As InternalExceptions.LoginException
            errProvider.SetError(btnLogin, ex.Message)
            txtPassword.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unknown error")
        End Try
    End Sub

    ' New Accounts Page
    ''' <summary>
    ''' This method will be used to move the screen to the new account page
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Brian Combs</author>
    ''' <date>June 25, 2017</date>
    Private Sub AddNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewAccountToolStripMenuItem.Click
        TabControl1.SelectedIndex = 2
        AcceptButton = btnAddAccount
    End Sub
    ''' <summary>
    ''' This method will be used to add the account on the new account page
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Brian Combs</author>
    ''' <date>June 25, 2017</date>
    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        errProvider.Clear()
        ' Validate the username is not blank or whitespace
        If String.IsNullOrWhiteSpace(txtUsernameAddAccount.Text) Then
            errProvider.SetError(txtUsernameAddAccount, "Please enter the username")
            Return
        End If

        ' Validate the password is not blank or whitespace
        If String.IsNullOrWhiteSpace(txtPasswordAddAccount.Text) Then
            errProvider.SetError(txtPasswordAddAccount, "Please enter the password")
            Return
        End If

        ' Make sure the USER LEVEL is sufficient
        If user.Level = Patron.AccountLevel.Administation Then
            ' Admin account can add any type of account
        ElseIf user.Level = Patron.AccountLevel.Circulation Then
            ' Circulation account can only add patron account
            If cmboxAccountTypeAddAccount.SelectedItem <> Patron.AccountLevel.Patron Then
                errProvider.SetError(cmboxAccountTypeAddAccount, "You can only add patron accounts")
                Return
            End If
        Else
            errProvider.SetError(cmboxAccountTypeAddAccount, "You are unable to add new accounts")
            Return
        End If

        Try
            ' Add the account the account
            user = New Patron(mysql, txtUsernameAddAccount.Text, txtPasswordAddAccount.Text)

            ' No exception was thrown, continue to set the text and permissions
            LoginToolStripMenuItem.Text = "&Log Out"
            PatronToolStripMenuItem.Enabled = True
            CirculationToolStripMenuItem.Enabled = user.Level >= 0
            AdministrationToolStripMenuItem.Enabled = user.Level >= 1
            ' Move to welcome page
            TabControl1.SelectedIndex = 0
            ' Clear the form for future use
            txtUsernameAddAccount.Text = ""
            txtPasswordAddAccount.Text = ""
            cmboxAccountTypeAddAccount.SelectedItem = Patron.AccountLevel.Patron
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' New methods will be added below here, please create group and move into that group as needed. 
    ''' <summary>
    ''' This method will be used to present the Search tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Jon Seigle</author>
    ''' <date>June 26, 2017</date>
    Private Sub SearchToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        TabControl1.SelectedIndex = 3
    End Sub

    ''' <summary>
    ''' This method will be used present the Reservation tab at the Patron Level
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Jon Seigle</author>
    ''' <date> June 26, 2017</date>
    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        TabControl1.SelectedIndex = 4
    End Sub

    ''' <summary>
    ''' This method will be used to present the Request tab at the Patron level
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Jon Seigle</author>
    ''' <date> June 26, 2017</date>
    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedIndex = 5
    End Sub

    ''' <summary>
    ''' This method will present the Account tab for the Patron
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Jon Seigle</author>
    ''' <date> June 26, 2017</date>
    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        TabControl1.SelectedIndex = 9
    End Sub

    ''' <summary>
    ''' This method will present the Reservations tab for Circulation level
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Jon Seigle</author>
    ''' <date> June 26, 2017</date>
    Private Sub ReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationsToolStripMenuItem.Click
        TabControl1.SelectedIndex = 6
    End Sub

    ''' <summary>
    ''' This method will present the Requests tab at for Circulation level
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RequestsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedIndex = 7
    End Sub

    ''' <summary>
    ''' This method will present the Check In/Out tab for the Circulation level
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Jon Seigle</author>
    ''' <date>June 26, 2017</date>
    Private Sub CheckInOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInOutToolStripMenuItem.Click
        TabControl1.SelectedIndex = 8
    End Sub

End Class
