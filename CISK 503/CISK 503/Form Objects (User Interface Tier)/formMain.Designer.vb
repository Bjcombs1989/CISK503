<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CirculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckInOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogeManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FAQToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tpAbout = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tpContacts = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpHelp = New System.Windows.Forms.TabPage()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.tpAccount = New System.Windows.Forms.TabPage()
        Me.tpCheckOut = New System.Windows.Forms.TabPage()
        Me.btCirculationCheckoutCheckout = New System.Windows.Forms.Button()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripTextBox7 = New System.Windows.Forms.ToolStripTextBox()
        Me.tbCirculationCheckoutUsername = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox8 = New System.Windows.Forms.ToolStripTextBox()
        Me.tbCirculationCheckoutIsbn = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox9 = New System.Windows.Forms.ToolStripTextBox()
        Me.tbCirculationCheckoutDate = New System.Windows.Forms.ToolStripTextBox()
        Me.tpReservations = New System.Windows.Forms.TabPage()
        Me.tbCirculationReservationsLastnameCombo = New System.Windows.Forms.MenuStrip()
        Me.ReservationsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.cbCirculationReservationLastnameCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBox6 = New System.Windows.Forms.ToolStripTextBox()
        Me.cbCirculationReservationStatusCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.tpReservation = New System.Windows.Forms.TabPage()
        Me.listviewReservation = New System.Windows.Forms.ListView()
        Me.tpSearch = New System.Windows.Forms.TabPage()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearchISBN = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearchTitle = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbxSearchGenre = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbxSearchStatus = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearchClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btPatronSearchHold = New System.Windows.Forms.Button()
        Me.tpCreate = New System.Windows.Forms.TabPage()
        Me.cmboxAccountTypeAddAccount = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.txtPasswordAddAccount = New System.Windows.Forms.TextBox()
        Me.txtUsernameAddAccount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpBook = New System.Windows.Forms.TabPage()
        Me.tpCheckIn = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbCirculationCheckinResult = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCirculationCheckinIsbn = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAbout.SuspendLayout()
        Me.tpContacts.SuspendLayout()
        Me.tpHelp.SuspendLayout()
        Me.tpCheckOut.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.tpReservations.SuspendLayout()
        Me.tbCirculationReservationsLastnameCombo.SuspendLayout()
        Me.tpReservation.SuspendLayout()
        Me.tpSearch.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.tpCreate.SuspendLayout()
        Me.tpLogin.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpBook.SuspendLayout()
        Me.tpCheckIn.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatronToolStripMenuItem, Me.CirculationToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1088, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatronToolStripMenuItem
        '
        Me.PatronToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ReservationToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.PatronToolStripMenuItem.Name = "PatronToolStripMenuItem"
        Me.PatronToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.PatronToolStripMenuItem.Text = "&Patron"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ReservationToolStripMenuItem.Text = "My Reservations"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AccountToolStripMenuItem.Text = "My Account"
        '
        'CirculationToolStripMenuItem
        '
        Me.CirculationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckInOutToolStripMenuItem, Me.AddNewAccountToolStripMenuItem, Me.ReservationsToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.PaymentsToolStripMenuItem})
        Me.CirculationToolStripMenuItem.Name = "CirculationToolStripMenuItem"
        Me.CirculationToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.CirculationToolStripMenuItem.Text = "&Circulation"
        '
        'CheckInOutToolStripMenuItem
        '
        Me.CheckInOutToolStripMenuItem.Name = "CheckInOutToolStripMenuItem"
        Me.CheckInOutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckInOutToolStripMenuItem.Text = "&Check In / Out"
        '
        'AddNewAccountToolStripMenuItem
        '
        Me.AddNewAccountToolStripMenuItem.Name = "AddNewAccountToolStripMenuItem"
        Me.AddNewAccountToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddNewAccountToolStripMenuItem.Text = "&Add New Account"
        '
        'ReservationsToolStripMenuItem
        '
        Me.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem"
        Me.ReservationsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ReservationsToolStripMenuItem.Text = "&Reservations"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AccountsToolStripMenuItem.Text = "&Accounts"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PaymentsToolStripMenuItem.Text = "&Payments"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogeManagerToolStripMenuItem, Me.AccountManagerToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdministrationToolStripMenuItem.Text = "&Administration"
        '
        'CatalogeManagerToolStripMenuItem
        '
        Me.CatalogeManagerToolStripMenuItem.Name = "CatalogeManagerToolStripMenuItem"
        Me.CatalogeManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CatalogeManagerToolStripMenuItem.Text = "&Cataloge Manager"
        '
        'AccountManagerToolStripMenuItem
        '
        Me.AccountManagerToolStripMenuItem.Name = "AccountManagerToolStripMenuItem"
        Me.AccountManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AccountManagerToolStripMenuItem.Text = "&Account Manager"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.FAQToolStripMenuItem1, Me.ContactsToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'FAQToolStripMenuItem1
        '
        Me.FAQToolStripMenuItem1.Name = "FAQToolStripMenuItem1"
        Me.FAQToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.FAQToolStripMenuItem1.Text = "&FAQ"
        '
        'ContactsToolStripMenuItem1
        '
        Me.ContactsToolStripMenuItem1.Name = "ContactsToolStripMenuItem1"
        Me.ContactsToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ContactsToolStripMenuItem1.Text = "&Contacts"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'tpAbout
        '
        Me.tpAbout.Controls.Add(Me.Label8)
        Me.tpAbout.Location = New System.Drawing.Point(4, 22)
        Me.tpAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.tpAbout.Name = "tpAbout"
        Me.tpAbout.Size = New System.Drawing.Size(1080, 424)
        Me.tpAbout.TabIndex = 12
        Me.tpAbout.Text = "About"
        Me.tpAbout.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 59)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 39)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Software Version" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Builders" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date"
        '
        'tpContacts
        '
        Me.tpContacts.Controls.Add(Me.Label7)
        Me.tpContacts.Location = New System.Drawing.Point(4, 22)
        Me.tpContacts.Margin = New System.Windows.Forms.Padding(2)
        Me.tpContacts.Name = "tpContacts"
        Me.tpContacts.Size = New System.Drawing.Size(1080, 424)
        Me.tpContacts.TabIndex = 11
        Me.tpContacts.Text = "Contacts"
        Me.tpContacts.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 91)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Address of Library" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phone Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact Information for:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Circulation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Admini" &
    "stration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Software" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tpHelp
        '
        Me.tpHelp.Controls.Add(Me.LinkLabel3)
        Me.tpHelp.Controls.Add(Me.LinkLabel2)
        Me.tpHelp.Controls.Add(Me.LinkLabel1)
        Me.tpHelp.Location = New System.Drawing.Point(4, 22)
        Me.tpHelp.Margin = New System.Windows.Forms.Padding(2)
        Me.tpHelp.Name = "tpHelp"
        Me.tpHelp.Padding = New System.Windows.Forms.Padding(2)
        Me.tpHelp.Size = New System.Drawing.Size(1080, 424)
        Me.tpHelp.TabIndex = 10
        Me.tpHelp.Text = "Help"
        Me.tpHelp.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(138, 138)
        Me.LinkLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(75, 13)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Reserve Book"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(138, 81)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(75, 13)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Search Library"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(135, 30)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create Account"
        '
        'tpAccount
        '
        Me.tpAccount.Location = New System.Drawing.Point(4, 22)
        Me.tpAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.tpAccount.Name = "tpAccount"
        Me.tpAccount.Size = New System.Drawing.Size(1080, 424)
        Me.tpAccount.TabIndex = 9
        Me.tpAccount.Text = "Account"
        Me.tpAccount.UseVisualStyleBackColor = True
        '
        'tpCheckOut
        '
        Me.tpCheckOut.Controls.Add(Me.btCirculationCheckoutCheckout)
        Me.tpCheckOut.Controls.Add(Me.MenuStrip3)
        Me.tpCheckOut.Location = New System.Drawing.Point(4, 22)
        Me.tpCheckOut.Margin = New System.Windows.Forms.Padding(2)
        Me.tpCheckOut.Name = "tpCheckOut"
        Me.tpCheckOut.Padding = New System.Windows.Forms.Padding(2)
        Me.tpCheckOut.Size = New System.Drawing.Size(1080, 424)
        Me.tpCheckOut.TabIndex = 8
        Me.tpCheckOut.Text = "Check Out"
        Me.tpCheckOut.UseVisualStyleBackColor = True
        '
        'btCirculationCheckoutCheckout
        '
        Me.btCirculationCheckoutCheckout.Location = New System.Drawing.Point(580, 1)
        Me.btCirculationCheckoutCheckout.Margin = New System.Windows.Forms.Padding(2)
        Me.btCirculationCheckoutCheckout.Name = "btCirculationCheckoutCheckout"
        Me.btCirculationCheckoutCheckout.Size = New System.Drawing.Size(69, 23)
        Me.btCirculationCheckoutCheckout.TabIndex = 2
        Me.btCirculationCheckoutCheckout.Text = "Check Out"
        Me.btCirculationCheckoutCheckout.UseVisualStyleBackColor = True
        '
        'MenuStrip3
        '
        Me.MenuStrip3.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox7, Me.tbCirculationCheckoutUsername, Me.ToolStripTextBox8, Me.tbCirculationCheckoutIsbn, Me.ToolStripTextBox9, Me.tbCirculationCheckoutDate})
        Me.MenuStrip3.Location = New System.Drawing.Point(2, 2)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip3.Size = New System.Drawing.Size(1076, 25)
        Me.MenuStrip3.TabIndex = 1
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ToolStripTextBox7
        '
        Me.ToolStripTextBox7.Name = "ToolStripTextBox7"
        Me.ToolStripTextBox7.Size = New System.Drawing.Size(68, 23)
        Me.ToolStripTextBox7.Text = "Username"
        '
        'tbCirculationCheckoutUsername
        '
        Me.tbCirculationCheckoutUsername.Name = "tbCirculationCheckoutUsername"
        Me.tbCirculationCheckoutUsername.Size = New System.Drawing.Size(82, 23)
        '
        'ToolStripTextBox8
        '
        Me.ToolStripTextBox8.Name = "ToolStripTextBox8"
        Me.ToolStripTextBox8.Size = New System.Drawing.Size(68, 23)
        Me.ToolStripTextBox8.Text = "ISBN"
        '
        'tbCirculationCheckoutIsbn
        '
        Me.tbCirculationCheckoutIsbn.Name = "tbCirculationCheckoutIsbn"
        Me.tbCirculationCheckoutIsbn.Size = New System.Drawing.Size(68, 23)
        '
        'ToolStripTextBox9
        '
        Me.ToolStripTextBox9.Name = "ToolStripTextBox9"
        Me.ToolStripTextBox9.Size = New System.Drawing.Size(68, 23)
        Me.ToolStripTextBox9.Text = "Due Date"
        '
        'tbCirculationCheckoutDate
        '
        Me.tbCirculationCheckoutDate.Name = "tbCirculationCheckoutDate"
        Me.tbCirculationCheckoutDate.Size = New System.Drawing.Size(85, 23)
        Me.tbCirculationCheckoutDate.Text = "MM/DD/YYYY"
        '
        'tpReservations
        '
        Me.tpReservations.Controls.Add(Me.tbCirculationReservationsLastnameCombo)
        Me.tpReservations.Location = New System.Drawing.Point(4, 22)
        Me.tpReservations.Margin = New System.Windows.Forms.Padding(2)
        Me.tpReservations.Name = "tpReservations"
        Me.tpReservations.Padding = New System.Windows.Forms.Padding(2)
        Me.tpReservations.Size = New System.Drawing.Size(1080, 424)
        Me.tpReservations.TabIndex = 6
        Me.tpReservations.Text = "Reservations"
        Me.tpReservations.UseVisualStyleBackColor = True
        '
        'tbCirculationReservationsLastnameCombo
        '
        Me.tbCirculationReservationsLastnameCombo.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tbCirculationReservationsLastnameCombo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservationsToolStripMenuItem1, Me.ToolStripTextBox5, Me.cbCirculationReservationLastnameCombo, Me.ToolStripTextBox6, Me.cbCirculationReservationStatusCombo})
        Me.tbCirculationReservationsLastnameCombo.Location = New System.Drawing.Point(2, 2)
        Me.tbCirculationReservationsLastnameCombo.Name = "tbCirculationReservationsLastnameCombo"
        Me.tbCirculationReservationsLastnameCombo.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.tbCirculationReservationsLastnameCombo.Size = New System.Drawing.Size(1076, 25)
        Me.tbCirculationReservationsLastnameCombo.TabIndex = 0
        Me.tbCirculationReservationsLastnameCombo.Text = "MenuStrip3"
        '
        'ReservationsToolStripMenuItem1
        '
        Me.ReservationsToolStripMenuItem1.Name = "ReservationsToolStripMenuItem1"
        Me.ReservationsToolStripMenuItem1.Size = New System.Drawing.Size(85, 23)
        Me.ReservationsToolStripMenuItem1.Text = "Reservations"
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(68, 23)
        Me.ToolStripTextBox5.Text = "Customer Lastname"
        '
        'cbCirculationReservationLastnameCombo
        '
        Me.cbCirculationReservationLastnameCombo.Name = "cbCirculationReservationLastnameCombo"
        Me.cbCirculationReservationLastnameCombo.Size = New System.Drawing.Size(82, 23)
        '
        'ToolStripTextBox6
        '
        Me.ToolStripTextBox6.Name = "ToolStripTextBox6"
        Me.ToolStripTextBox6.Size = New System.Drawing.Size(68, 23)
        Me.ToolStripTextBox6.Text = "Status"
        '
        'cbCirculationReservationStatusCombo
        '
        Me.cbCirculationReservationStatusCombo.Name = "cbCirculationReservationStatusCombo"
        Me.cbCirculationReservationStatusCombo.Size = New System.Drawing.Size(82, 23)
        '
        'tpReservation
        '
        Me.tpReservation.Controls.Add(Me.listviewReservation)
        Me.tpReservation.Location = New System.Drawing.Point(4, 22)
        Me.tpReservation.Margin = New System.Windows.Forms.Padding(2)
        Me.tpReservation.Name = "tpReservation"
        Me.tpReservation.Padding = New System.Windows.Forms.Padding(2)
        Me.tpReservation.Size = New System.Drawing.Size(1080, 424)
        Me.tpReservation.TabIndex = 4
        Me.tpReservation.Text = "Reservation"
        Me.tpReservation.UseVisualStyleBackColor = True
        '
        'listviewReservation
        '
        Me.listviewReservation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.listviewReservation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.listviewReservation.FullRowSelect = True
        Me.listviewReservation.Location = New System.Drawing.Point(0, 0)
        Me.listviewReservation.MultiSelect = False
        Me.listviewReservation.Name = "listviewReservation"
        Me.listviewReservation.Size = New System.Drawing.Size(675, 424)
        Me.listviewReservation.TabIndex = 0
        Me.listviewReservation.TileSize = New System.Drawing.Size(505, 50)
        Me.listviewReservation.UseCompatibleStateImageBehavior = False
        Me.listviewReservation.View = System.Windows.Forms.View.Details
        '
        'tpSearch
        '
        Me.tpSearch.Controls.Add(Me.dgvSearch)
        Me.tpSearch.Controls.Add(Me.ToolStrip1)
        Me.tpSearch.Controls.Add(Me.btPatronSearchHold)
        Me.tpSearch.Location = New System.Drawing.Point(4, 22)
        Me.tpSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.tpSearch.Name = "tpSearch"
        Me.tpSearch.Padding = New System.Windows.Forms.Padding(2)
        Me.tpSearch.Size = New System.Drawing.Size(1080, 424)
        Me.tpSearch.TabIndex = 3
        Me.tpSearch.Text = "Search"
        Me.tpSearch.UseVisualStyleBackColor = True
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.AllowUserToDeleteRows = False
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSearch.Location = New System.Drawing.Point(2, 27)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearch.Size = New System.Drawing.Size(1076, 395)
        Me.dgvSearch.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtSearchISBN, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.txtSearchTitle, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.cmbxSearchGenre, Me.ToolStripSeparator3, Me.ToolStripLabel4, Me.cmbxSearchStatus, Me.ToolStripSeparator4, Me.btnSearchClear, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1076, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "ISBN:"
        '
        'txtSearchISBN
        '
        Me.txtSearchISBN.Name = "txtSearchISBN"
        Me.txtSearchISBN.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel2.Text = "Title:"
        '
        'txtSearchTitle
        '
        Me.txtSearchTitle.Name = "txtSearchTitle"
        Me.txtSearchTitle.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel3.Text = "Genre:"
        '
        'cmbxSearchGenre
        '
        Me.cmbxSearchGenre.Name = "cmbxSearchGenre"
        Me.cmbxSearchGenre.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel4.Text = "Status:"
        '
        'cmbxSearchStatus
        '
        Me.cmbxSearchStatus.Name = "cmbxSearchStatus"
        Me.cmbxSearchStatus.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnSearchClear
        '
        Me.btnSearchClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSearchClear.Image = CType(resources.GetObject("btnSearchClear.Image"), System.Drawing.Image)
        Me.btnSearchClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearchClear.Name = "btnSearchClear"
        Me.btnSearchClear.Size = New System.Drawing.Size(76, 22)
        Me.btnSearchClear.Text = "Clear Search"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btPatronSearchHold
        '
        Me.btPatronSearchHold.Location = New System.Drawing.Point(639, 4)
        Me.btPatronSearchHold.Margin = New System.Windows.Forms.Padding(2)
        Me.btPatronSearchHold.Name = "btPatronSearchHold"
        Me.btPatronSearchHold.Size = New System.Drawing.Size(61, 22)
        Me.btPatronSearchHold.TabIndex = 1
        Me.btPatronSearchHold.Text = "HOLD"
        Me.btPatronSearchHold.UseVisualStyleBackColor = True
        '
        'tpCreate
        '
        Me.tpCreate.Controls.Add(Me.cmboxAccountTypeAddAccount)
        Me.tpCreate.Controls.Add(Me.Label6)
        Me.tpCreate.Controls.Add(Me.btnAddAccount)
        Me.tpCreate.Controls.Add(Me.txtPasswordAddAccount)
        Me.tpCreate.Controls.Add(Me.txtUsernameAddAccount)
        Me.tpCreate.Controls.Add(Me.Label3)
        Me.tpCreate.Controls.Add(Me.Label4)
        Me.tpCreate.Location = New System.Drawing.Point(4, 22)
        Me.tpCreate.Name = "tpCreate"
        Me.tpCreate.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCreate.Size = New System.Drawing.Size(1080, 424)
        Me.tpCreate.TabIndex = 1
        Me.tpCreate.Text = "CreateAcct"
        Me.tpCreate.UseVisualStyleBackColor = True
        '
        'cmboxAccountTypeAddAccount
        '
        Me.cmboxAccountTypeAddAccount.FormattingEnabled = True
        Me.cmboxAccountTypeAddAccount.Location = New System.Drawing.Point(105, 89)
        Me.cmboxAccountTypeAddAccount.Name = "cmboxAccountTypeAddAccount"
        Me.cmboxAccountTypeAddAccount.Size = New System.Drawing.Size(232, 21)
        Me.cmboxAccountTypeAddAccount.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Account Type:"
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(105, 126)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(100, 23)
        Me.btnAddAccount.TabIndex = 9
        Me.btnAddAccount.Text = "Add Account"
        Me.btnAddAccount.UseVisualStyleBackColor = True
        '
        'txtPasswordAddAccount
        '
        Me.txtPasswordAddAccount.Location = New System.Drawing.Point(105, 55)
        Me.txtPasswordAddAccount.Name = "txtPasswordAddAccount"
        Me.txtPasswordAddAccount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordAddAccount.Size = New System.Drawing.Size(232, 20)
        Me.txtPasswordAddAccount.TabIndex = 8
        '
        'txtUsernameAddAccount
        '
        Me.txtUsernameAddAccount.Location = New System.Drawing.Point(105, 24)
        Me.txtUsernameAddAccount.Name = "txtUsernameAddAccount"
        Me.txtUsernameAddAccount.Size = New System.Drawing.Size(232, 20)
        Me.txtUsernameAddAccount.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Username"
        '
        'tpLogin
        '
        Me.tpLogin.Controls.Add(Me.btnLogin)
        Me.tpLogin.Controls.Add(Me.txtPassword)
        Me.tpLogin.Controls.Add(Me.txtUsername)
        Me.tpLogin.Controls.Add(Me.Label2)
        Me.tpLogin.Controls.Add(Me.Label1)
        Me.tpLogin.Location = New System.Drawing.Point(4, 22)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLogin.Size = New System.Drawing.Size(1080, 424)
        Me.tpLogin.TabIndex = 0
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(112, 91)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(112, 57)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(232, 20)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(112, 26)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(232, 20)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpLogin)
        Me.TabControl1.Controls.Add(Me.tpCreate)
        Me.TabControl1.Controls.Add(Me.tpSearch)
        Me.TabControl1.Controls.Add(Me.tpBook)
        Me.TabControl1.Controls.Add(Me.tpReservation)
        Me.TabControl1.Controls.Add(Me.tpAccount)
        Me.TabControl1.Controls.Add(Me.tpReservations)
        Me.TabControl1.Controls.Add(Me.tpCheckOut)
        Me.TabControl1.Controls.Add(Me.tpCheckIn)
        Me.TabControl1.Controls.Add(Me.tpHelp)
        Me.TabControl1.Controls.Add(Me.tpContacts)
        Me.TabControl1.Controls.Add(Me.tpAbout)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1088, 450)
        Me.TabControl1.TabIndex = 1
        '
        'tpBook
        '
        Me.tpBook.Controls.Add(Me.Button3)
        Me.tpBook.Controls.Add(Me.Button2)
        Me.tpBook.Controls.Add(Me.Label9)
        Me.tpBook.Location = New System.Drawing.Point(4, 22)
        Me.tpBook.Name = "tpBook"
        Me.tpBook.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBook.Size = New System.Drawing.Size(1080, 424)
        Me.tpBook.TabIndex = 14
        Me.tpBook.Text = "Book"
        Me.tpBook.UseVisualStyleBackColor = True
        '
        'tpCheckIn
        '
        Me.tpCheckIn.Controls.Add(Me.Button1)
        Me.tpCheckIn.Controls.Add(Me.tbCirculationCheckinResult)
        Me.tpCheckIn.Controls.Add(Me.Label5)
        Me.tpCheckIn.Controls.Add(Me.tbCirculationCheckinIsbn)
        Me.tpCheckIn.Location = New System.Drawing.Point(4, 22)
        Me.tpCheckIn.Margin = New System.Windows.Forms.Padding(2)
        Me.tpCheckIn.Name = "tpCheckIn"
        Me.tpCheckIn.Padding = New System.Windows.Forms.Padding(2)
        Me.tpCheckIn.Size = New System.Drawing.Size(1080, 424)
        Me.tpCheckIn.TabIndex = 13
        Me.tpCheckIn.Text = "Check In"
        Me.tpCheckIn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(265, 34)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 17)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Check In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbCirculationCheckinResult
        '
        Me.tbCirculationCheckinResult.Location = New System.Drawing.Point(171, 77)
        Me.tbCirculationCheckinResult.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCirculationCheckinResult.Name = "tbCirculationCheckinResult"
        Me.tbCirculationCheckinResult.Size = New System.Drawing.Size(68, 20)
        Me.tbCirculationCheckinResult.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ISBN"
        '
        'tbCirculationCheckinIsbn
        '
        Me.tbCirculationCheckinIsbn.Location = New System.Drawing.Point(171, 34)
        Me.tbCirculationCheckinIsbn.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCirculationCheckinIsbn.Name = "tbCirculationCheckinIsbn"
        Me.tbCirculationCheckinIsbn.Size = New System.Drawing.Size(68, 20)
        Me.tbCirculationCheckinIsbn.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(127, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Label9"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(91, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Place Hold"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 270)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Check Out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Book Title"
        Me.ColumnHeader1.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Author"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Checked Out To"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Due Date"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fees Due"
        Me.ColumnHeader5.Width = 80
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 474)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMain"
        Me.Text = "Library Circulation Desk"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAbout.ResumeLayout(False)
        Me.tpAbout.PerformLayout()
        Me.tpContacts.ResumeLayout(False)
        Me.tpContacts.PerformLayout()
        Me.tpHelp.ResumeLayout(False)
        Me.tpHelp.PerformLayout()
        Me.tpCheckOut.ResumeLayout(False)
        Me.tpCheckOut.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.tpReservations.ResumeLayout(False)
        Me.tpReservations.PerformLayout()
        Me.tbCirculationReservationsLastnameCombo.ResumeLayout(False)
        Me.tbCirculationReservationsLastnameCombo.PerformLayout()
        Me.tpReservation.ResumeLayout(False)
        Me.tpSearch.ResumeLayout(False)
        Me.tpSearch.PerformLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tpCreate.ResumeLayout(False)
        Me.tpCreate.PerformLayout()
        Me.tpLogin.ResumeLayout(False)
        Me.tpLogin.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpBook.ResumeLayout(False)
        Me.tpBook.PerformLayout()
        Me.tpCheckIn.ResumeLayout(False)
        Me.tpCheckIn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatronToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CirculationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckInOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogeManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpLogin As TabPage
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tpCreate As TabPage
    Friend WithEvents cmboxAccountTypeAddAccount As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddAccount As Button
    Friend WithEvents txtPasswordAddAccount As TextBox
    Friend WithEvents txtUsernameAddAccount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tpSearch As TabPage
    Friend WithEvents btPatronSearchHold As Button
    Friend WithEvents tpReservation As TabPage
    Friend WithEvents tpReservations As TabPage
    Friend WithEvents tbCirculationReservationsLastnameCombo As MenuStrip
    Friend WithEvents ReservationsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox5 As ToolStripTextBox
    Friend WithEvents cbCirculationReservationLastnameCombo As ToolStripComboBox
    Friend WithEvents ToolStripTextBox6 As ToolStripTextBox
    Friend WithEvents cbCirculationReservationStatusCombo As ToolStripComboBox
    Friend WithEvents tpCheckOut As TabPage
    Friend WithEvents btCirculationCheckoutCheckout As Button
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripTextBox7 As ToolStripTextBox
    Friend WithEvents tbCirculationCheckoutUsername As ToolStripTextBox
    Friend WithEvents ToolStripTextBox8 As ToolStripTextBox
    Friend WithEvents tbCirculationCheckoutIsbn As ToolStripTextBox
    Friend WithEvents ToolStripTextBox9 As ToolStripTextBox
    Friend WithEvents tbCirculationCheckoutDate As ToolStripTextBox
    Friend WithEvents tpCheckIn As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents tbCirculationCheckinResult As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCirculationCheckinIsbn As TextBox
    Friend WithEvents tpAccount As TabPage
    Friend WithEvents tpHelp As TabPage
    Friend WithEvents tpContacts As TabPage
    Friend WithEvents tpAbout As TabPage
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FAQToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents dgvSearch As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtSearchISBN As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtSearchTitle As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents cmbxSearchGenre As ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents cmbxSearchStatus As ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnSearchClear As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tpBook As TabPage
    Friend WithEvents listviewReservation As ListView
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
