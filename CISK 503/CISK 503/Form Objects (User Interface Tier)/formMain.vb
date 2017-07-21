Public Class formMain
    ''''''''' HOLD CONTROL, press M then L to expand/collapse all. I like to collapse all and expand as 
    ''''''''' needed to see what I'm working on

    Public Shared mysql As MySQLDatabaseConnector
    Dim user As Patron
    Dim books As DataTable
    Dim loading As Boolean = True
    Dim book As Book
    Dim action As MenuAction

    ' Form 
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
        AcceptButton = btnLogin
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
        books = mysql.ListBooks()

        ' Load reservations tab
        cmbxCheckOutTo.DisplayMember = "Value"
        cmbxCheckOutTo.DataSource = mysql.ListUsers()
        cmbxPlaceHoldFor.DisplayMember = "Value"
        cmbxPlaceHoldFor.DataSource = mysql.ListUsers()

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
        book = New Book(mysql, isbn)
        LoadBook()

        TabControl1.SelectedIndex = 3
        AcceptButton = Nothing
    End Sub

    ' Book Page                 TAB INDEX = 3
    Public Sub LoadBook()
        ' Dispaly all the book stuff in their respective textboxes
        txtBookAuthor.Text = book.Author
        txtBookGenre.Text = book.Genre
        txtBookName.Text = book.Title
        txtBookPublisher.Text = book.Publisher

        ' Enable/Disable buttons based on availability
        btnPlaceHold.Enabled = book.IsAvailable ' enable hold button

        If Not book.IsHeld Then
            btnRemoveHold.Enabled = False
            cmbxPlaceHoldFor.Enabled = False
        Else
            btnRemoveHold.Enabled = (TypeOf (user) Is Librarian Or book.Hold.Patron.ID = user.ID)
            cmbxPlaceHoldFor.Enabled = (TypeOf (user) Is Librarian Or book.Hold.Patron.ID = user.ID)
        End If

        btnCheckOut.Enabled = book.IsAvailable And TypeOf (user) Is Librarian ' enable check out button
        cmbxCheckOutTo.Enabled = book.IsAvailable And TypeOf (user) Is Librarian ' enable check out button

        btnCheckIn.Enabled = book.IsReservered And TypeOf (user) Is Librarian ' enable the check in buttond
    End Sub

    Private Sub btnPlaceHold_Click(sender As Object, e As EventArgs) Handles btnPlaceHold.Click
        Try
            mysql.AddHold(New Hold(user, book))
            MessageBox.Show("A hold has been placed for this book", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnPlaceHold.Enabled = False ' disable hold button
            btnCheckOut.Enabled = False ' disable check out button
            btnCheckIn.Enabled = False ' disable check in button
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Try
            mysql.AddReservation(New Reservation(user, book))
            MessageBox.Show("This book has been checked out", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnPlaceHold.Enabled = False ' disable hold button
            btnCheckOut.Enabled = False ' disable check out button
            btnCheckIn.Enabled = True ' enable check in button
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click

    End Sub

    Private Sub btnRemoveHold_Click(sender As Object, e As EventArgs) Handles btnRemoveHold.Click

    End Sub

    ' Reservations Page         TAB INDEX = 4
    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        TabControl1.SelectedIndex = 4 ' Use the index of the page (Reservations = 4, Account = 5)
        AcceptButton = Nothing ' Select the button to press when you hit "Enter"
        action = MenuAction.MyReservations

        listviewReservation.Items.Clear()

        ' Load reservations and holds
        If (sender Is btnAccountBalanceLabel) Then
            listviewReservation.Items.AddRange(mysql.GetReservationsWithBalance(user))
        Else
            listviewReservation.Items.AddRange(mysql.GetReservations(user))
            listviewReservation.Items.AddRange(mysql.GetHolds(user))
        End If
    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutToolStripMenuItem.Click
        TabControl1.SelectedIndex = 4 ' Use the index of the page (Reservations = 4, Account = 5)
        AcceptButton = Nothing ' Select the button to press when you hit "Enter"
        action = MenuAction.CheckOut

        ' Load reservations
        listviewReservation.Items.Clear()
        listviewReservation.Items.AddRange(mysql.GetHolds())
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInToolStripMenuItem.Click
        TabControl1.SelectedIndex = 4 ' Use the index of the page (Reservations = 4, Account = 5)
        AcceptButton = Nothing ' Select the button to press when you hit "Enter"
        action = MenuAction.CheckIn

        ' Load reservations
        listviewReservation.Items.Clear()
        listviewReservation.Items.AddRange(mysql.GetReservations())
    End Sub

    Private Sub btnReservationRemoveHold_Click(sender As Object, e As EventArgs) Handles btnReservationRemoveHold.Click
        Try
            mysql.RemoveHold(book.Hold)
            MessageBox.Show("You have removed the hold for this book", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (action = MenuAction.MyReservations) Then ReservationToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckIn) Then CheckInToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckOut) Then CheckOutToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.Balance) Then ReservationToolStripMenuItem_Click(btnAccountBalanceLabel, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReservationCheckOut_Click(sender As Object, e As EventArgs) Handles btnReservationCheckOut.Click
        Try
            mysql.RemoveHold(book.Hold)
            mysql.AddReservation(New Reservation(book.Hold))
            MessageBox.Show("You have checked this book out", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (action = MenuAction.MyReservations) Then ReservationToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckIn) Then CheckInToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckOut) Then CheckOutToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.Balance) Then ReservationToolStripMenuItem_Click(btnAccountBalanceLabel, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReservationCheckIn_Click(sender As Object, e As EventArgs) Handles btnReservationCheckIn.Click
        Try
            mysql.RemoveReservation(book.Reservation)
            MessageBox.Show("You have checked this book in", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (action = MenuAction.MyReservations) Then ReservationToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckIn) Then CheckInToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckOut) Then CheckOutToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.Balance) Then ReservationToolStripMenuItem_Click(btnAccountBalanceLabel, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Check In", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub listviewReservation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listviewReservation.SelectedIndexChanged
        Dim item As ListViewItem

        Try
            item = listviewReservation.SelectedItems(0)
        Catch ex As Exception
            Return
        End Try

        Dim hold As Hold
        Dim res As Reservation

        hold = TryCast(item, Hold)
        res = TryCast(item, Reservation)

        If Not hold Is Nothing Then
            book = hold.Book
            book.Hold = hold
            txtReservationAuthor.Text = hold.Book.Author
            txtReservationGenre.Text = hold.Book.Genre
            txtReservationName.Text = hold.Book.Title
            txtReservationPublisher.Text = hold.Book.Publisher
            btnReservationRemoveHold.Enabled = True
            btnReservationCheckOut.Enabled = TypeOf (user) Is Librarian ' enable check out button
            btnReservationCheckIn.Enabled = False ' enable the check in button
        ElseIf Not res Is Nothing Then
            book = res.Book
            book.Reservation = res
            txtReservationAuthor.Text = res.Book.Author
            txtReservationGenre.Text = res.Book.Genre
            txtReservationName.Text = res.Book.Title
            txtReservationPublisher.Text = res.Book.Publisher
            btnReservationRemoveHold.Enabled = False
            btnReservationCheckOut.Enabled = False ' enable check out button
            btnReservationCheckIn.Enabled = TypeOf (user) Is Librarian ' enable the check in button
        End If


    End Sub

    Private Sub cmbxCheckOutTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCheckOutTo.SelectedIndexChanged
        If loading Then Return
        Dim selected As KeyValuePair(Of Integer, String)

        Try
            selected = DirectCast(cmbxCheckOutTo.SelectedItem, KeyValuePair(Of Integer, String))
        Catch ex As Exception
            cmbxCheckOutTo.SelectedIndex = -1
            Return
        End Try

        Try
            mysql.AddReservation(New Reservation(New Patron(mysql, selected.Key), book))
            MessageBox.Show("You have checked this book out to " + selected.Value, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (action = MenuAction.MyReservations) Then ReservationToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckIn) Then CheckInToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckOut) Then CheckOutToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.Balance) Then ReservationToolStripMenuItem_Click(btnAccountBalanceLabel, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbxPlaceHoldFor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxPlaceHoldFor.SelectedIndexChanged
        If loading Then Return
        Dim selected As KeyValuePair(Of Integer, String)

        Try
            selected = DirectCast(cmbxPlaceHoldFor.SelectedItem, KeyValuePair(Of Integer, String))
        Catch ex As Exception
            cmbxPlaceHoldFor.SelectedIndex = -1
            Return
        End Try

        Try
            mysql.AddHold(New Hold(New Patron(mysql, selected.Key), book))
            MessageBox.Show("You have placed a hold on this book for " + selected.Value, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (action = MenuAction.MyReservations) Then ReservationToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckIn) Then CheckInToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.CheckOut) Then CheckOutToolStripMenuItem_Click(Nothing, Nothing)
            If (action = MenuAction.Balance) Then ReservationToolStripMenuItem_Click(btnAccountBalanceLabel, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Accounts Page             TAB INDEX = 5
    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        TabControl1.SelectedIndex = 5 ' Use the index of the page (Reservations = 4, Account = 5)
        AcceptButton = Nothing ' Select the button to press when you hit "Enter"


    End Sub

    Private Sub btnAccountBalanceLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnAccountBalanceLabel.LinkClicked
        ReservationToolStripMenuItem_Click(btnAccountBalanceLabel, Nothing)
    End Sub

    'Event Update User information
    'Only item I see that could be updated is the username
    'All other information does not seem to be a user edit item
    Private Sub btnAccountUpdate_Click(sender As Object, e As EventArgs) Handles btnAccountUpdate.Click

    End Sub

    'Event to update password
    ' 
    Private Sub btnAccountChange_Click(sender As Object, e As EventArgs) Handles btnAccountChange.Click

    End Sub





    '''''''''''''''''' NEW ITEMS will be added below here. Please move code into proper groups for organization purposes

End Class

Public Enum MenuAction
    MyReservations
    CheckIn
    CheckOut
    Balance
End Enum
