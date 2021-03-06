﻿Public Class formMain

    ''''''''' READ ME!!!
    ''''''''' HOLD CONTROL, press M then L to expand/collapse all
    ''''''''' DO IT TWICE TO collapse ALL
    ''''''''' Then expand as needed to see the organization

    Public Shared mysql As MySQLDatabaseConnector
    Dim user As Patron
    Dim books As DataTable
    Dim loading As Boolean = True
    Dim book As Book
    Dim action As MenuAction
    Dim selected_user As Patron

    ' Main Form 
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
            mysql = New MySQLDatabaseConnector()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Close()
            Return
        End Try

        ' Load the book list
        books = mysql.ListBooks()

        ' Load the account level enumeration into the combo boxes as needed
        cmboxAccountTypeAddAccount.DataSource = [Enum].GetValues(GetType(Patron.AccountLevel))
        cbAccountType.DataSource = [Enum].GetValues(GetType(Patron.AccountLevel))

        ' Load things for the Search Tab
        cmbxSearchGenre.ComboBox.DisplayMember = "Value"
        cmbxSearchGenre.ComboBox.DataSource = mysql.ListGenres()

        ' Load reservations tab
        cmbxCheckOutTo.DisplayMember = "Value"
        cmbxCheckOutTo.DataSource = mysql.ListUsers()
        cmbxPlaceHoldFor.DisplayMember = "Value"
        cmbxPlaceHoldFor.DataSource = mysql.ListUsers()

        ' Load the catalog tab
        cbCatalogAuthor.DisplayMember = "Value"
        cbCatalogAuthor.DataSource = mysql.ListAuthors()
        cbCatalogGenre.DisplayMember = "Value"
        cbCatalogGenre.DataSource = mysql.ListGenres()
        cbCatalogPublisher.DisplayMember = "Value"
        cbCatalogPublisher.DataSource = mysql.ListPublishers()

        loading = False
    End Sub

    ''' <summary>
    ''' This method will present about information to the user of the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <author>Juan Maldonado</author>
    ''' <date>July 3, 2017</date>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Library Circulation Desk" + vbCrLf + "Author : A Team" + vbCrLf + "Copyright : 2017" + vbCrLf + "CISK 503 Summer 2017", "About Library Circulation Desk",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub FAQToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FAQToolStripMenuItem1.Click
        TabControl1.SelectedIndex = 6 ' Use the index of the page
        AcceptButton = Nothing ' Select the button to press when you hit "Enter"
    End Sub

    Private Sub ContactsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContactsToolStripMenuItem1.Click
        TabControl1.SelectedIndex = 7 ' Use the index of the page
        AcceptButton = Nothing ' Select the button to press when you hit "Enter"
    End Sub

    Private Sub HelpLinkContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HelpLinkContact.LinkClicked
        TabControl1.SelectedIndex = 7 ' Use the index of the page
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
        txtSearchTitle.TextChanged, txtSearchISBN.TextChanged, cmbxSearchGenre.SelectedIndexChanged

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

        books.DefaultView.RowFilter = filter
        dgvSearch.DataSource = books
    End Sub

    Private Sub btnSearchClear_Click(sender As Object, e As EventArgs) Handles btnSearchClear.Click
        txtSearchISBN.Clear()
        txtSearchTitle.Clear()
        cmbxSearchGenre.SelectedIndex = -1
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
        book.RefreshInfo()

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
        cmbxPlaceHoldFor.Enabled = book.IsAvailable And TypeOf (user) Is Librarian ' enable check out button
    End Sub

    Private Sub btnPlaceHold_Click(sender As Object, e As EventArgs) Handles btnPlaceHold.Click
        If Not book.IsAvailable Then
            MessageBox.Show("The book you selected is not available", "Not available")
            LoadBook()
            Return
        End If

        Try
            Dim hld As New Hold(user, book)
            mysql.AddHold(hld)
            book.Hold = hld
            book.IsHeld = True
            MessageBox.Show("A hold has been placed for this book", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnRemoveHold.Enabled = True ' enable the remove hold button
            btnPlaceHold.Enabled = False ' disable hold button
            btnCheckOut.Enabled = False ' disable check out button
            btnCheckIn.Enabled = False ' disable check in button
            cmbxPlaceHoldFor.Enabled = False ' disable the place hold combobox
            cmbxCheckOutTo.Enabled = False ' disable the check out button
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If Not book.IsAvailable Then
            MessageBox.Show("The book you selected is not available", "Not available")
            LoadBook()
            Return
        End If

        Try
            Dim res As New Reservation(user, book)
            mysql.AddReservation(res)
            book.Reservation = res
            book.IsReservered = True
            MessageBox.Show("This book has been checked out", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnRemoveHold.Enabled = False ' enable the remove hold button
            btnPlaceHold.Enabled = False ' disable hold button
            btnCheckOut.Enabled = False ' disable check out button
            btnCheckIn.Enabled = True ' disable check in button
            cmbxPlaceHoldFor.Enabled = False ' disable the place hold combobox
            cmbxCheckOutTo.Enabled = False ' disable the check out button
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Try
            mysql.RemoveReservation(book.Reservation)
            book.Reservation = Nothing
            book.IsReservered = False
            MessageBox.Show("You have checked this book in", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnRemoveHold.Enabled = False ' enable the remove hold button
            btnPlaceHold.Enabled = True ' disable hold button
            btnCheckOut.Enabled = True ' disable check out button
            btnCheckIn.Enabled = False ' disable check in button
            cmbxPlaceHoldFor.Enabled = True ' disable the place hold combobox
            cmbxCheckOutTo.Enabled = True ' disable the check out button
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Check In", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemoveHold_Click(sender As Object, e As EventArgs) Handles btnRemoveHold.Click
        Try
            mysql.RemoveHold(book.Hold)
            book.Hold = Nothing
            book.IsHeld = False
            MessageBox.Show("You have removed the hold for this book", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnRemoveHold.Enabled = False ' enable the remove hold button
            btnPlaceHold.Enabled = True ' disable hold button
            btnCheckOut.Enabled = True ' disable check out button
            btnCheckIn.Enabled = False ' disable check in button
            cmbxPlaceHoldFor.Enabled = True ' disable the place hold combobox
            cmbxCheckOutTo.Enabled = True ' disable the check out button
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbxCheckOutTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCheckOutTo.SelectedIndexChanged
        If loading Then Return
        Dim selected As KeyValuePair(Of Integer, String)

        If Not book.IsAvailable Then
            MessageBox.Show("The book you selected is not available", "Not available")
            LoadBook()
            Return
        End If

        Try
            selected = DirectCast(cmbxCheckOutTo.SelectedItem, KeyValuePair(Of Integer, String))
        Catch ex As Exception
            cmbxCheckOutTo.SelectedIndex = -1
            Return
        End Try

        Try
            Dim res As New Reservation(New Patron(mysql, selected.Key), book)
            mysql.AddReservation(res)
            book.Reservation = res
            book.IsReservered = True
            MessageBox.Show("You have checked this book out to " + selected.Value, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnRemoveHold.Enabled = False ' enable the remove hold button
            btnPlaceHold.Enabled = False ' disable hold button
            btnCheckOut.Enabled = False ' disable check out button
            btnCheckIn.Enabled = True ' disable check in button
            cmbxPlaceHoldFor.Enabled = False ' disable the place hold combobox
            cmbxCheckOutTo.Enabled = False ' disable the check out button
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cmbxCheckOutTo.SelectedIndex = -1
    End Sub

    Private Sub cmbxPlaceHoldFor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxPlaceHoldFor.SelectedIndexChanged
        If loading Then Return
        Dim selected As KeyValuePair(Of Integer, String)

        If Not book.IsAvailable Then
            MessageBox.Show("The book you selected is not available", "Not available")
            LoadBook()
            Return
        End If

        Try
            selected = DirectCast(cmbxPlaceHoldFor.SelectedItem, KeyValuePair(Of Integer, String))
        Catch ex As Exception
            cmbxPlaceHoldFor.SelectedIndex = -1
            Return
        End Try

        Try
            Dim hld As New Hold(New Patron(mysql, selected.Key), book)
            mysql.AddHold(hld)
            book.Hold = hld
            book.IsHeld = True
            MessageBox.Show("You have placed a hold on this book for " + selected.Value, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnRemoveHold.Enabled = True ' enable the remove hold button
            btnPlaceHold.Enabled = False ' disable hold button
            btnCheckOut.Enabled = False ' disable check out button
            btnCheckIn.Enabled = False ' disable check in button
            cmbxPlaceHoldFor.Enabled = False ' disable the place hold combobox
            cmbxCheckOutTo.Enabled = False ' disable the check out button
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hold", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cmbxPlaceHoldFor.SelectedIndex = -1
    End Sub

    ' Books Page         TAB INDEX = 4
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
        listviewReservation.Items.AddRange(mysql.GetReservations(selected_user))
    End Sub

    Private Sub btnReservationRemoveHold_Click(sender As Object, e As EventArgs) Handles btnReservationRemoveHold.Click
        Try
            mysql.RemoveHold(book.Hold)
            book.IsHeld = False
            book.Hold = Nothing
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
            Dim res As New Reservation(book.Hold)
            mysql.AddReservation(res)
            book.Reservation = res
            book.IsReservered = True
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
            book.IsReservered = False
            book.Reservation = Nothing
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

    ' Accounts Page             TAB INDEX = 5
    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        TabControl1.SelectedIndex = 5 ' Use the index of the page (Reservations = 4, Account = 5)
        AcceptButton = Nothing ' Select the button to press when you hit "Enter"

        ' Load the user information
        selected_user = user
        GroupBox3.Visible = False
        LoadAccount()

        ' Load accounts into listview
        lvAccounts.Items.Clear()
        action = MenuAction.Account
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click, AccountManagerToolStripMenuItem.Click
        TabControl1.SelectedIndex = 5 ' Use the index of the page (Reservations = 4, Account = 5)
        AcceptButton = Nothing ' Select the button to press when you hit "Enter"

        ' Load the user information
        selected_user = user
        LoadAccount()

        GroupBox3.Visible = TypeOf (user) Is Administrator

        ' Load accounts into listview
        LoadAccounts()
        action = MenuAction.Accounts
    End Sub

    Private Sub LoadAccount()
        tbAccountAccountID.Text = selected_user.ID
        tbAccountDateCreated.Text = selected_user.DateCreated.ToShortDateString()
        tbAccountUsername.Text = selected_user.UserName
        cbAccountType.SelectedIndex = Convert.ToInt32(selected_user.Level)
        tbAccountBalance.Text = ""

        GroupBox3.Visible = (Not selected_user.ID = user.ID) And TypeOf (user) Is Administrator
    End Sub

    Private Sub LoadAccounts()
        lvAccounts.Items.Clear()
        Dim patrons As Patron() = mysql.ListUserAccounts()
        For Each patron As Patron In patrons
            Dim lvi As Patron.ListViewPatron = New Patron.ListViewPatron(patron)
            lvAccounts.Items.Add(lvi)
        Next
    End Sub

    Private Sub btnAccountBalanceLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnAccountBalanceLabel.LinkClicked
        ReservationToolStripMenuItem_Click(btnAccountBalanceLabel, Nothing)
    End Sub

    Private Sub btnAccountUpdate_Click(sender As Object, e As EventArgs) Handles btnAccountUpdate.Click
        If cbAccountType.SelectedIndex = -1 Then
            MessageBox.Show("Please choose the account type")
            Return
        End If

        If String.IsNullOrWhiteSpace(tbAccountUsername.Text) Then
            MessageBox.Show("Please enter the username")
            Return
        End If

        Try
            mysql.UpdateUsername(selected_user, tbAccountUsername.Text)
            selected_user.UserName = tbAccountUsername.Text

            If TypeOf (user) Is Administrator Then
                mysql.UpdateLevel(selected_user, Convert.ToInt32(cbAccountType.SelectedValue))
                selected_user.Level = cbAccountType.SelectedValue
            End If

            If action = MenuAction.Accounts Then
                LoadAccounts()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LoadAccount()
    End Sub

    Private Sub btnAccountChange_Click(sender As Object, e As EventArgs) Handles btnAccountChange.Click
        If String.IsNullOrWhiteSpace(tbAccountCurrentPassword.Text) Or
           String.IsNullOrWhiteSpace(tbAccountNewPassword.Text) Or
           String.IsNullOrWhiteSpace(tbAccountNewPasswordConfirm.Text) Then
            MessageBox.Show("Please enter all fields")
            Return
        End If

        If Not user.HashPassword(tbAccountCurrentPassword.Text) = selected_user.Password Then
            MessageBox.Show("Your old password did not validate")
            Return
        End If

        If Not tbAccountNewPassword.Text = tbAccountNewPasswordConfirm.Text Then
            MessageBox.Show("New password and confirm password must match")
            Return
        End If

        Try
            mysql.UpdatePassword(selected_user, tbAccountNewPassword.Text)

            tbAccountCurrentPassword.Clear()
            tbAccountNewPassword.Clear()
            tbAccountNewPasswordConfirm.Clear()

            If action = MenuAction.Accounts Then
                LoadAccounts()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LoadAccount()
    End Sub

    Private Sub lvAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvAccounts.SelectedIndexChanged
        Dim lvi As Patron.ListViewPatron

        Try
            lvi = DirectCast(lvAccounts.SelectedItems(0), Patron.ListViewPatron)
        Catch ex As Exception
            Return
        End Try

        selected_user = lvi.patron

        LoadAccount()
    End Sub

    Private Sub btnAccountsDelete_Click(sender As Object, e As EventArgs) Handles btnAccountsDelete.Click
        Try
            If TypeOf (user) Is Administrator Then
                mysql.DeleteAccount(selected_user)
            Else
                MessageBox.Show("You are not allowed to delete accounts")
                Return
            End If

            tbAccountCurrentPassword.Clear()
            tbAccountNewPassword.Clear()
            tbAccountNewPasswordConfirm.Clear()
            tbAccountAccountID.Clear()
            tbAccountDateCreated.Clear()
            tbAccountUsername.Clear()
            cbAccountType.SelectedIndex = -1
            tbAccountBalance.Clear()

            If action = MenuAction.Accounts Then
                LoadAccounts()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Catalog Manager Page      TAB INDEX = 8
    Private Sub CatalogeManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogeManagerToolStripMenuItem.Click
        TabControl1.SelectedIndex = 8 ' Use the index of the page
        AcceptButton = Nothing ' Select the button to press when you hit "Enter"

        lvCatalog.Items.Clear()

        For Each row As DataRow In books.Rows
            Dim lvi As New ListViewItem()
            lvi.Text = row("ISBN").ToString()
            lvi.SubItems.Add(row("Title").ToString())
            lvi.SubItems.Add(row("Genre").ToString())
            lvi.SubItems.Add(row("Author").ToString())
            lvi.SubItems.Add(row("Publisher").ToString())

            lvCatalog.Items.Add(lvi)
        Next

    End Sub

    Private Sub lvCatalog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCatalog.SelectedIndexChanged
        Try
            book = New Book(mysql, New Book.ISBN(lvCatalog.SelectedItems(0).Text))
        Catch ex As Exception
            Return
        End Try

        LoadCatalogBook()

        btnCatalogAdd.Text = "Add New"
    End Sub

    Private Sub LoadCatalogBook()
        txtCatalogBookTitle.Text = book.Title
        cbCatalogGenre.SelectedIndex = cbCatalogGenre.FindString(book.Genre)
        cbCatalogPublisher.SelectedIndex = cbCatalogPublisher.FindString(book.Publisher)
        cbCatalogAuthor.SelectedIndex = cbCatalogAuthor.FindString(book.Author)
    End Sub

    Private Sub btnCatalogAdd_Click(sender As Object, e As EventArgs) Handles btnCatalogAdd.Click
        If book Is Nothing And btnCatalogAdd.Text = "Save" Then
            If cbCatalogAuthor.SelectedIndex = -1 Or cbCatalogAuthor.SelectedIndex = -1 Or cbCatalogAuthor.SelectedIndex = -1 Then
                MessageBox.Show("Please be sure to choose a publisher, author and genre")
                Return
            End If

            book = New Book(mysql, txtCatalogBookTitle.Text,
                                DirectCast(cbCatalogGenre.SelectedValue, KeyValuePair(Of Integer, String)).Key,
                                DirectCast(cbCatalogPublisher.SelectedValue, KeyValuePair(Of Integer, String)).Key,
                                DirectCast(cbCatalogAuthor.SelectedValue, KeyValuePair(Of Integer, String)).Key, user)
            LoadCatalogBook()
            btnCatalogAdd.Text = "Add New"

            ' Load the book list
            books = mysql.ListBooks()
            CatalogeManagerToolStripMenuItem_Click(Nothing, Nothing)
        Else
            book = Nothing
            btnCatalogAdd.Text = "Save"
            txtCatalogBookTitle.Text = ""
            cbCatalogAuthor.SelectedIndex = -1
            cbCatalogGenre.SelectedIndex = -1
            cbCatalogPublisher.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnCatalogUpdate_Click(sender As Object, e As EventArgs) Handles btnCatalogUpdate.Click
        Try
            book.UpdateBook(txtCatalogBookTitle.Text,
                    DirectCast(cbCatalogGenre.SelectedValue, KeyValuePair(Of Integer, String)).Key,
                    DirectCast(cbCatalogPublisher.SelectedValue, KeyValuePair(Of Integer, String)).Key,
                    DirectCast(cbCatalogAuthor.SelectedValue, KeyValuePair(Of Integer, String)).Key)
            MessageBox.Show("Successfully updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LoadCatalogBook()
        btnCatalogAdd.Text = "Add New"

        ' Load the book list
        books = mysql.ListBooks()
        CatalogeManagerToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCatalogAddGenre_Click(sender As Object, e As EventArgs) Handles btnCatalogAddGenre.Click
        Try
            mysql.AddGenre(txtCatalogGenre.Text)
            txtCatalogGenre.Text = ""
            MessageBox.Show("Genre added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try


        cbCatalogGenre.DisplayMember = "Value"
        cbCatalogGenre.DataSource = mysql.ListGenres()
    End Sub

    Private Sub btnCatalogAddAuthor_Click(sender As Object, e As EventArgs) Handles btnCatalogAddAuthor.Click
        Try
            mysql.AddAuthor(txtCatalogAuthor.Text)
            txtCatalogAuthor.Text = ""
            MessageBox.Show("Author added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        cbCatalogAuthor.DisplayMember = "Value"
        cbCatalogAuthor.DataSource = mysql.ListAuthors()
    End Sub

    Private Sub btnCatalogAddPublisher_Click(sender As Object, e As EventArgs) Handles btnCatalogAddPublisher.Click
        Try
            mysql.AddPublisher(txtCatalogPublisher.Text)
            txtCatalogPublisher.Text = ""
            MessageBox.Show("Publisher added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        cbCatalogPublisher.DisplayMember = "Value"
        cbCatalogPublisher.DataSource = mysql.ListPublishers()
    End Sub







    Public Enum MenuAction
        MyReservations
        CheckIn
        CheckOut
        Balance
        Account
        Accounts
    End Enum

End Class