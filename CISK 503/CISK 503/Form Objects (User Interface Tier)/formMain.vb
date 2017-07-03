Public Class formMain
    Public Shared mysql As MySQLDatabaseConnector
    Dim user As Patron
    Dim books As DataTable
    Dim loading As Boolean = True

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
        cmbxAccountTypeAddAccount.DataSource = [Enum].GetValues(GetType(Patron.AccountLevel))

        ' Load things for the Search Tab
        cmbxSearchGenre.ComboBox.DisplayMember = "Value"
        cmbxSearchGenre.ComboBox.DataSource = mysql.ListGenres()
        books = mysql.ListBooks()



        loading = False
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

            ' Cast into specfic type
            If (user.Level = 2) Then
                user = New Administrator(mysql, txtUsername.Text, txtPassword.Text)
                CirculationToolStripMenuItem.Enabled = True
                AdministrationToolStripMenuItem.Enabled = True
            ElseIf user.Level = 1 Then
                user = New Librarian(mysql, txtUsername.Text, txtPassword.Text)
                CirculationToolStripMenuItem.Enabled = True
            Else
                ' Keep as Patron
            End If

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

        Try
            If (TypeOf (user) Is Administrator) Then
                DirectCast(user, Administrator).CreateAccount(txtUsernameAddAccount.Text, user.HashPassword(txtPasswordAddAccount.Text), cmbxAccountTypeAddAccount.SelectedItem)
            ElseIf (TypeOf (user) Is Librarian) Then
                DirectCast(user, Librarian).CreateAccount(txtUsernameAddAccount.Text, user.HashPassword(txtPasswordAddAccount.Text))
            End If
        Catch ex As ConstraintException
            errProvider.SetError(cmbxAccountTypeAddAccount, "You are unable to add this type of accound")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        ' Clear the form for future use
        txtUsernameAddAccount.Text = ""
        txtPasswordAddAccount.Text = ""
        cmbxAccountTypeAddAccount.SelectedItem = Patron.AccountLevel.Patron
    End Sub

    ' Search page event handlers

    ''' <summary>
    ''' This method will be used to present the Search tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Jon Seigle</author>
    ''' <date>June 26, 2017</date>
    Private Sub SearchToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        TabControl1.SelectedIndex = 3
        LoadBooks()
    End Sub

    Private Sub LoadBooks() Handles _
        txtSearchTitle.TextChanged, txtSearchISBN.TextChanged, cmbxSearchStatus.SelectedIndexChanged, cmbxSearchGenre.SelectedIndexChanged

        If loading Then
            Return
        End If
        dgvSearch.DataSource = Nothing
        dgvSearch.Columns.Clear()
        dgvSearch.Rows.Clear()

        Dim filter As String = ""

        If Not String.IsNullOrWhiteSpace(txtSearchISBN.Text) Then
            filter += "`ISBN` LIKE '%" + txtSearchISBN.Text + "%'"
        End If

        If Not String.IsNullOrWhiteSpace(txtSearchTitle.Text) Then
            If (filter <> "") Then
                filter += " AND "
            End If

            filter += "`Title` LIKE '%" + txtSearchTitle.Text + "%'"
        End If

        If Not cmbxSearchGenre.SelectedIndex <= 0 Then
            If (filter <> "") Then
                filter += " AND "
            End If

            Dim kvp As KeyValuePair(Of Integer, String) = cmbxSearchGenre.SelectedItem

            filter += "`Genre` LIKE '" + kvp.Value + "'"
        End If

        If Not cmbxSearchStatus.SelectedIndex = -1 Then
            If (filter <> "") Then
                filter += " AND "
            End If

            filter += "`Status` LIKE '" + cmbxSearchStatus.SelectedItem + "'"
        End If

        books.DefaultView.RowFilter = filter
        dgvSearch.DataSource = books
    End Sub

    Private Sub btnSearchClear_Click(sender As Object, e As EventArgs) Handles btnSearchClear.Click
        txtSearchISBN.Clear()
        txtSearchTitle.Clear()
        cmbxSearchGenre.SelectedIndex = -1
        cmbxSearchStatus.SelectedIndex = -1
        LoadBooks()
    End Sub

    ' New methods will be added below here, please create group and move into that group as needed. 


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
    Private Sub RequestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestsToolStripMenuItem.Click
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

    ''' <summary>
    ''' This method will present about information to the user of the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Juan Maldonado</author>
    ''' <date>July 3, 2017</date>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Library Circulation Desk" + vbCrLf + " Author : A Team" + vbCr + " Copyright : 2017" + vbCr + "CISK 503 Summer 2017", "About Library Circulation Desk",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    ''' <summary>
    ''' This method will show FAQ information to the user of the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Juan Maldonado</author>
    ''' <date>July 3, 2017</date>
    Private Sub FAQToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FAQToolStripMenuItem1.Click


    End Sub
End Class
