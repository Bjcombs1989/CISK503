Public Class formMain
    ''''''''' HOLD CONTROL, press M then L to expand/collapse all. I like to collapse all and expand as 
    ''''''''' needed to see what I'm working on

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
        txtUsername.Select()

        ' Load the Database Connection
        Try
            MySql = New MySQLDatabaseConnector()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' Load the account level enumeration into the combo boxes as needed
        cmboxAccountTypeAddAccount.DataSource = [Enum].GetValues(GetType(Patron.AccountLevel))

        ' Load things for the Search Tab
        cmbxSearchGenre.ComboBox.DisplayMember = "Value"
        cmbxSearchGenre.ComboBox.DataSource = MySql.ListGenres()
        books = MySql.ListBooks()

        loading = False
    End Sub

    ' Login Page                TAB INDEX = 0
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
        TabControl1.SelectedIndex = 0
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
            user = New Patron(MySql, txtUsername.Text, txtPassword.Text)
            ' No exception was thrown, continue to set the text and permissions
            LoginToolStripMenuItem.Text = "&Log Out"
            PatronToolStripMenuItem.Enabled = True

            ' Cast into specfic type
            If (user.Level = 2) Then
                user = New Administrator(MySql, txtUsername.Text, txtPassword.Text)
                CirculationToolStripMenuItem.Enabled = True
                AdministrationToolStripMenuItem.Enabled = True
            ElseIf user.Level = 1 Then
                user = New Librarian(MySql, txtUsername.Text, txtPassword.Text)
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

    ' New Accounts Page         TAB INDEX = 1
    ''' <summary>
    ''' This method will be used to move the screen to the new account page
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Brian Combs</author>
    ''' <date>June 25, 2017</date>
    Private Sub AddNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewAccountToolStripMenuItem.Click
        TabControl1.SelectedIndex = 1
        txtUsernameAddAccount.Select()
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
                DirectCast(user, Administrator).CreateAccount(txtUsernameAddAccount.Text, user.HashPassword(txtPasswordAddAccount.Text), cmboxAccountTypeAddAccount.SelectedItem)
            ElseIf (TypeOf (user) Is Librarian) Then
                DirectCast(user, Librarian).CreateAccount(txtUsernameAddAccount.Text, user.HashPassword(txtPasswordAddAccount.Text))
            End If
        Catch ex As ConstraintException
            errProvider.SetError(cmboxAccountTypeAddAccount, "You are unable to add this type of accound")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        ' Clear the form for future use
        txtUsernameAddAccount.Text = ""
        txtPasswordAddAccount.Text = ""
        cmboxAccountTypeAddAccount.SelectedItem = Patron.AccountLevel.Patron
    End Sub

    ' Search Page               TAB INDEX = 2
    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        TabControl1.SelectedIndex = 2
        txtSearchISBN.Select()
        AcceptButton = Nothing
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
        txtSearchISBN.Select()
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        Dim selected As DataGridViewRow

        Try
            selected = dgvSearch.Rows(e.RowIndex)
        Catch ex As Exception
            Return
        End Try

        Dim isbn As Book.ISBN = New Book.ISBN(selected.Cells(0).Value.ToString())
        Dim book As Book = New Book(mysql, isbn)
        LoadBook(book)

        TabControl1.SelectedIndex = 3
        AcceptButton = Nothing
    End Sub

    ' Book Page                 TAB INDEX = 3
    Public Sub LoadBook(book As Book)
        ' Dispaly all the book stuff in their respective textboxes


        ' Enable/Disable buttons based on availability
        If (book.IsAvailable) Then
            ' enable hold button
            ' enable check out button
        Else
            ' disable hold button
            ' disable check out button
        End If

        ' Enable/Disable buttons based on account type
        If (TypeOf (user) Is Librarian) Then ' this check also includes admin because an Admin is-a Librian
            ' enable check out button
        Else
            ' disabled check out button
        End If


    End Sub

    ' Reservations Page         TAB INDEX = 4


    ' Accounts Page             TAB INDEX = 5




    '''''''''''''''''' NEW ITEMS will be added below here. Please move code into proper groups for organization purposes



End Class
