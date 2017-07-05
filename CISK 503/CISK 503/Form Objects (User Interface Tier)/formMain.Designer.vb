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
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FAQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.cbPatronReservationFilterCombo = New System.Windows.Forms.MenuStrip()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.tpSearch = New System.Windows.Forms.TabPage()
        Me.btPatronSearchHold = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.tbPatronSearchSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.AuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbPatronSearchAuthorCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.GenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbPatronSearchGenreCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.cbPatronSearchAvailableCombo = New System.Windows.Forms.ToolStripComboBox()
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
        Me.tpCheckIn = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbCirculationCheckinResult = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCirculationCheckinIsbn = New System.Windows.Forms.TextBox()
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
        Me.cbPatronReservationFilterCombo.SuspendLayout()
        Me.tpSearch.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.tpCreate.SuspendLayout()
        Me.tpLogin.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpCheckIn.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatronToolStripMenuItem, Me.CirculationToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.LoginToolStripMenuItem, Me.FAQToolStripMenuItem, Me.ContactsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1065, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatronToolStripMenuItem
        '
        Me.PatronToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ReservationToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.PatronToolStripMenuItem.Name = "PatronToolStripMenuItem"
        Me.PatronToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
        Me.PatronToolStripMenuItem.Text = "&Patron"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(225, 30)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(225, 30)
        Me.ReservationToolStripMenuItem.Text = "My Reservations"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(225, 30)
        Me.AccountToolStripMenuItem.Text = "My Account"
        '
        'CirculationToolStripMenuItem
        '
        Me.CirculationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckInOutToolStripMenuItem, Me.AddNewAccountToolStripMenuItem, Me.ReservationsToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.PaymentsToolStripMenuItem})
        Me.CirculationToolStripMenuItem.Name = "CirculationToolStripMenuItem"
        Me.CirculationToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
        Me.CirculationToolStripMenuItem.Text = "&Circulation"
        '
        'CheckInOutToolStripMenuItem
        '
        Me.CheckInOutToolStripMenuItem.Name = "CheckInOutToolStripMenuItem"
        Me.CheckInOutToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
        Me.CheckInOutToolStripMenuItem.Text = "&Check In / Out"
        '
        'AddNewAccountToolStripMenuItem
        '
        Me.AddNewAccountToolStripMenuItem.Name = "AddNewAccountToolStripMenuItem"
        Me.AddNewAccountToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
        Me.AddNewAccountToolStripMenuItem.Text = "&Add New Account"
        '
        'ReservationsToolStripMenuItem
        '
        Me.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem"
        Me.ReservationsToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
        Me.ReservationsToolStripMenuItem.Text = "&Reservations"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
        Me.AccountsToolStripMenuItem.Text = "&Accounts"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
        Me.PaymentsToolStripMenuItem.Text = "&Payments"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogeManagerToolStripMenuItem, Me.AccountManagerToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(141, 29)
        Me.AdministrationToolStripMenuItem.Text = "&Administration"
        '
        'CatalogeManagerToolStripMenuItem
        '
        Me.CatalogeManagerToolStripMenuItem.Name = "CatalogeManagerToolStripMenuItem"
        Me.CatalogeManagerToolStripMenuItem.Size = New System.Drawing.Size(241, 30)
        Me.CatalogeManagerToolStripMenuItem.Text = "&Cataloge Manager"
        '
        'AccountManagerToolStripMenuItem
        '
        Me.AccountManagerToolStripMenuItem.Name = "AccountManagerToolStripMenuItem"
        Me.AccountManagerToolStripMenuItem.Size = New System.Drawing.Size(241, 30)
        Me.AccountManagerToolStripMenuItem.Text = "&Account Manager"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'FAQToolStripMenuItem
        '
        Me.FAQToolStripMenuItem.Name = "FAQToolStripMenuItem"
        Me.FAQToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.FAQToolStripMenuItem.Text = "&FAQ"
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(93, 29)
        Me.ContactsToolStripMenuItem.Text = "Contacts"
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'tpAbout
        '
        Me.tpAbout.Controls.Add(Me.Label8)
        Me.tpAbout.Location = New System.Drawing.Point(4, 29)
        Me.tpAbout.Name = "tpAbout"
        Me.tpAbout.Size = New System.Drawing.Size(1057, 421)
        Me.tpAbout.TabIndex = 12
        Me.tpAbout.Text = "About"
        Me.tpAbout.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(322, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 60)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Software Version" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Builders" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date"
        '
        'tpContacts
        '
        Me.tpContacts.Controls.Add(Me.Label7)
        Me.tpContacts.Location = New System.Drawing.Point(4, 29)
        Me.tpContacts.Name = "tpContacts"
        Me.tpContacts.Size = New System.Drawing.Size(1057, 421)
        Me.tpContacts.TabIndex = 11
        Me.tpContacts.Text = "Contacts"
        Me.tpContacts.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 140)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Address of Library" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phone Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact Information for:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Circulation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Admini" &
        "stration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Software" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tpHelp
        '
        Me.tpHelp.Controls.Add(Me.LinkLabel3)
        Me.tpHelp.Controls.Add(Me.LinkLabel2)
        Me.tpHelp.Controls.Add(Me.LinkLabel1)
        Me.tpHelp.Location = New System.Drawing.Point(4, 29)
        Me.tpHelp.Name = "tpHelp"
        Me.tpHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHelp.Size = New System.Drawing.Size(1057, 421)
        Me.tpHelp.TabIndex = 10
        Me.tpHelp.Text = "Help"
        Me.tpHelp.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(207, 212)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(109, 20)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Reserve Book"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(207, 125)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(111, 20)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Search Library"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(203, 46)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 20)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create Account"
        '
        'tpAccount
        '
        Me.tpAccount.Location = New System.Drawing.Point(4, 29)
        Me.tpAccount.Name = "tpAccount"
        Me.tpAccount.Size = New System.Drawing.Size(1057, 421)
        Me.tpAccount.TabIndex = 9
        Me.tpAccount.Text = "Account"
        Me.tpAccount.UseVisualStyleBackColor = True
        '
        'tpCheckOut
        '
        Me.tpCheckOut.Controls.Add(Me.btCirculationCheckoutCheckout)
        Me.tpCheckOut.Controls.Add(Me.MenuStrip3)
        Me.tpCheckOut.Location = New System.Drawing.Point(4, 29)
        Me.tpCheckOut.Name = "tpCheckOut"
        Me.tpCheckOut.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCheckOut.Size = New System.Drawing.Size(1057, 421)
        Me.tpCheckOut.TabIndex = 8
        Me.tpCheckOut.Text = "Check Out"
        Me.tpCheckOut.UseVisualStyleBackColor = True
        '
        'btCirculationCheckoutCheckout
        '
        Me.btCirculationCheckoutCheckout.Location = New System.Drawing.Point(870, 2)
        Me.btCirculationCheckoutCheckout.Name = "btCirculationCheckoutCheckout"
        Me.btCirculationCheckoutCheckout.Size = New System.Drawing.Size(104, 36)
        Me.btCirculationCheckoutCheckout.TabIndex = 2
        Me.btCirculationCheckoutCheckout.Text = "Check Out"
        Me.btCirculationCheckoutCheckout.UseVisualStyleBackColor = True
        '
        'MenuStrip3
        '
        Me.MenuStrip3.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox7, Me.tbCirculationCheckoutUsername, Me.ToolStripTextBox8, Me.tbCirculationCheckoutIsbn, Me.ToolStripTextBox9, Me.tbCirculationCheckoutDate})
        Me.MenuStrip3.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(1051, 35)
        Me.MenuStrip3.TabIndex = 1
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ToolStripTextBox7
        '
        Me.ToolStripTextBox7.Name = "ToolStripTextBox7"
        Me.ToolStripTextBox7.Size = New System.Drawing.Size(100, 31)
        Me.ToolStripTextBox7.Text = "Username"
        '
        'tbCirculationCheckoutUsername
        '
        Me.tbCirculationCheckoutUsername.Name = "tbCirculationCheckoutUsername"
        Me.tbCirculationCheckoutUsername.Size = New System.Drawing.Size(121, 31)
        '
        'ToolStripTextBox8
        '
        Me.ToolStripTextBox8.Name = "ToolStripTextBox8"
        Me.ToolStripTextBox8.Size = New System.Drawing.Size(100, 31)
        Me.ToolStripTextBox8.Text = "ISBN"
        '
        'tbCirculationCheckoutIsbn
        '
        Me.tbCirculationCheckoutIsbn.Name = "tbCirculationCheckoutIsbn"
        Me.tbCirculationCheckoutIsbn.Size = New System.Drawing.Size(100, 31)
        '
        'ToolStripTextBox9
        '
        Me.ToolStripTextBox9.Name = "ToolStripTextBox9"
        Me.ToolStripTextBox9.Size = New System.Drawing.Size(100, 31)
        Me.ToolStripTextBox9.Text = "Due Date"
        '
        'tbCirculationCheckoutDate
        '
        Me.tbCirculationCheckoutDate.Name = "tbCirculationCheckoutDate"
        Me.tbCirculationCheckoutDate.Size = New System.Drawing.Size(125, 31)
        Me.tbCirculationCheckoutDate.Text = "MM/DD/YYYY"
        '
        'tpReservations
        '
        Me.tpReservations.Controls.Add(Me.tbCirculationReservationsLastnameCombo)
        Me.tpReservations.Location = New System.Drawing.Point(4, 29)
        Me.tpReservations.Name = "tpReservations"
        Me.tpReservations.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReservations.Size = New System.Drawing.Size(1057, 421)
        Me.tpReservations.TabIndex = 6
        Me.tpReservations.Text = "Reservations"
        Me.tpReservations.UseVisualStyleBackColor = True
        '
        'tbCirculationReservationsLastnameCombo
        '
        Me.tbCirculationReservationsLastnameCombo.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tbCirculationReservationsLastnameCombo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservationsToolStripMenuItem1, Me.ToolStripTextBox5, Me.cbCirculationReservationLastnameCombo, Me.ToolStripTextBox6, Me.cbCirculationReservationStatusCombo})
        Me.tbCirculationReservationsLastnameCombo.Location = New System.Drawing.Point(3, 3)
        Me.tbCirculationReservationsLastnameCombo.Name = "tbCirculationReservationsLastnameCombo"
        Me.tbCirculationReservationsLastnameCombo.Size = New System.Drawing.Size(1051, 37)
        Me.tbCirculationReservationsLastnameCombo.TabIndex = 0
        Me.tbCirculationReservationsLastnameCombo.Text = "MenuStrip3"
        '
        'ReservationsToolStripMenuItem1
        '
        Me.ReservationsToolStripMenuItem1.Name = "ReservationsToolStripMenuItem1"
        Me.ReservationsToolStripMenuItem1.Size = New System.Drawing.Size(123, 33)
        Me.ReservationsToolStripMenuItem1.Text = "Reservations"
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(100, 33)
        Me.ToolStripTextBox5.Text = "Customer Lastname"
        '
        'cbCirculationReservationLastnameCombo
        '
        Me.cbCirculationReservationLastnameCombo.Name = "cbCirculationReservationLastnameCombo"
        Me.cbCirculationReservationLastnameCombo.Size = New System.Drawing.Size(121, 33)
        '
        'ToolStripTextBox6
        '
        Me.ToolStripTextBox6.Name = "ToolStripTextBox6"
        Me.ToolStripTextBox6.Size = New System.Drawing.Size(100, 33)
        Me.ToolStripTextBox6.Text = "Status"
        '
        'cbCirculationReservationStatusCombo
        '
        Me.cbCirculationReservationStatusCombo.Name = "cbCirculationReservationStatusCombo"
        Me.cbCirculationReservationStatusCombo.Size = New System.Drawing.Size(121, 33)
        '
        'tpReservation
        '
        Me.tpReservation.Controls.Add(Me.cbPatronReservationFilterCombo)
        Me.tpReservation.Location = New System.Drawing.Point(4, 29)
        Me.tpReservation.Name = "tpReservation"
        Me.tpReservation.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReservation.Size = New System.Drawing.Size(1057, 421)
        Me.tpReservation.TabIndex = 4
        Me.tpReservation.Text = "Reservation"
        Me.tpReservation.UseVisualStyleBackColor = True
        '
        'cbPatronReservationFilterCombo
        '
        Me.cbPatronReservationFilterCombo.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.cbPatronReservationFilterCombo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox4, Me.ToolStripComboBox1})
        Me.cbPatronReservationFilterCombo.Location = New System.Drawing.Point(3, 3)
        Me.cbPatronReservationFilterCombo.Name = "cbPatronReservationFilterCombo"
        Me.cbPatronReservationFilterCombo.Size = New System.Drawing.Size(1051, 37)
        Me.cbPatronReservationFilterCombo.TabIndex = 1
        Me.cbPatronReservationFilterCombo.Text = "MenuStrip4"
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(100, 33)
        Me.ToolStripTextBox4.Text = "Reservations"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Current", "Closed", "All"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 33)
        '
        'tpSearch
        '
        Me.tpSearch.Controls.Add(Me.btPatronSearchHold)
        Me.tpSearch.Controls.Add(Me.MenuStrip2)
        Me.tpSearch.Location = New System.Drawing.Point(4, 29)
        Me.tpSearch.Name = "tpSearch"
        Me.tpSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSearch.Size = New System.Drawing.Size(1057, 421)
        Me.tpSearch.TabIndex = 3
        Me.tpSearch.Text = "Search"
        Me.tpSearch.UseVisualStyleBackColor = True
        '
        'btPatronSearchHold
        '
        Me.btPatronSearchHold.Location = New System.Drawing.Point(959, 6)
        Me.btPatronSearchHold.Name = "btPatronSearchHold"
        Me.btPatronSearchHold.Size = New System.Drawing.Size(92, 34)
        Me.btPatronSearchHold.TabIndex = 1
        Me.btPatronSearchHold.Text = "HOLD"
        Me.btPatronSearchHold.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.tbPatronSearchSearch, Me.ToolStripTextBox2, Me.AuthorToolStripMenuItem, Me.cbPatronSearchAuthorCombo, Me.GenreToolStripMenuItem, Me.cbPatronSearchGenreCombo, Me.ToolStripTextBox3, Me.cbPatronSearchAvailableCombo})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1051, 37)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 33)
        Me.ToolStripTextBox1.Text = "Search"
        '
        'tbPatronSearchSearch
        '
        Me.tbPatronSearchSearch.Name = "tbPatronSearchSearch"
        Me.tbPatronSearchSearch.Size = New System.Drawing.Size(121, 33)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 33)
        Me.ToolStripTextBox2.Text = "Filter By:"
        '
        'AuthorToolStripMenuItem
        '
        Me.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        Me.AuthorToolStripMenuItem.Size = New System.Drawing.Size(79, 33)
        Me.AuthorToolStripMenuItem.Text = "Author"
        '
        'cbPatronSearchAuthorCombo
        '
        Me.cbPatronSearchAuthorCombo.Name = "cbPatronSearchAuthorCombo"
        Me.cbPatronSearchAuthorCombo.Size = New System.Drawing.Size(121, 33)
        '
        'GenreToolStripMenuItem
        '
        Me.GenreToolStripMenuItem.Name = "GenreToolStripMenuItem"
        Me.GenreToolStripMenuItem.Size = New System.Drawing.Size(70, 33)
        Me.GenreToolStripMenuItem.Text = "Genre"
        '
        'cbPatronSearchGenreCombo
        '
        Me.cbPatronSearchGenreCombo.Name = "cbPatronSearchGenreCombo"
        Me.cbPatronSearchGenreCombo.Size = New System.Drawing.Size(121, 33)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 33)
        Me.ToolStripTextBox3.Text = "Available"
        '
        'cbPatronSearchAvailableCombo
        '
        Me.cbPatronSearchAvailableCombo.Name = "cbPatronSearchAvailableCombo"
        Me.cbPatronSearchAvailableCombo.Size = New System.Drawing.Size(121, 33)
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
        Me.tpCreate.Location = New System.Drawing.Point(4, 29)
        Me.tpCreate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpCreate.Name = "tpCreate"
        Me.tpCreate.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpCreate.Size = New System.Drawing.Size(1057, 421)
        Me.tpCreate.TabIndex = 1
        Me.tpCreate.Text = "CreateAcct"
        Me.tpCreate.UseVisualStyleBackColor = True
        '
        'cmboxAccountTypeAddAccount
        '
        Me.cmboxAccountTypeAddAccount.FormattingEnabled = True
        Me.cmboxAccountTypeAddAccount.Location = New System.Drawing.Point(158, 137)
        Me.cmboxAccountTypeAddAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmboxAccountTypeAddAccount.Name = "cmboxAccountTypeAddAccount"
        Me.cmboxAccountTypeAddAccount.Size = New System.Drawing.Size(346, 28)
        Me.cmboxAccountTypeAddAccount.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Account Type:"
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(158, 194)
        Me.btnAddAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(150, 35)
        Me.btnAddAccount.TabIndex = 9
        Me.btnAddAccount.Text = "Add Account"
        Me.btnAddAccount.UseVisualStyleBackColor = True
        '
        'txtPasswordAddAccount
        '
        Me.txtPasswordAddAccount.Location = New System.Drawing.Point(158, 85)
        Me.txtPasswordAddAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPasswordAddAccount.Name = "txtPasswordAddAccount"
        Me.txtPasswordAddAccount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordAddAccount.Size = New System.Drawing.Size(346, 26)
        Me.txtPasswordAddAccount.TabIndex = 8
        '
        'txtUsernameAddAccount
        '
        Me.txtUsernameAddAccount.Location = New System.Drawing.Point(158, 37)
        Me.txtUsernameAddAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsernameAddAccount.Name = "txtUsernameAddAccount"
        Me.txtUsernameAddAccount.Size = New System.Drawing.Size(346, 26)
        Me.txtUsernameAddAccount.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
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
        Me.tpLogin.Location = New System.Drawing.Point(4, 29)
        Me.tpLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpLogin.Size = New System.Drawing.Size(1057, 421)
        Me.tpLogin.TabIndex = 0
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(142, 126)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 35)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(142, 74)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(346, 26)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(142, 26)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(346, 26)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpLogin)
        Me.TabControl1.Controls.Add(Me.tpCreate)
        Me.TabControl1.Controls.Add(Me.tpSearch)
        Me.TabControl1.Controls.Add(Me.tpReservation)
        Me.TabControl1.Controls.Add(Me.tpReservations)
        Me.TabControl1.Controls.Add(Me.tpCheckOut)
        Me.TabControl1.Controls.Add(Me.tpCheckIn)
        Me.TabControl1.Controls.Add(Me.tpAccount)
        Me.TabControl1.Controls.Add(Me.tpHelp)
        Me.TabControl1.Controls.Add(Me.tpContacts)
        Me.TabControl1.Controls.Add(Me.tpAbout)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabControl1.Location = New System.Drawing.Point(0, 35)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1065, 454)
        Me.TabControl1.TabIndex = 1
        '
        'tpCheckIn
        '
        Me.tpCheckIn.Controls.Add(Me.Button1)
        Me.tpCheckIn.Controls.Add(Me.tbCirculationCheckinResult)
        Me.tpCheckIn.Controls.Add(Me.Label5)
        Me.tpCheckIn.Controls.Add(Me.tbCirculationCheckinIsbn)
        Me.tpCheckIn.Location = New System.Drawing.Point(4, 29)
        Me.tpCheckIn.Name = "tpCheckIn"
        Me.tpCheckIn.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCheckIn.Size = New System.Drawing.Size(1057, 421)
        Me.tpCheckIn.TabIndex = 13
        Me.tpCheckIn.Text = "Check In"
        Me.tpCheckIn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(398, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Check In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbCirculationCheckinResult
        '
        Me.tbCirculationCheckinResult.Location = New System.Drawing.Point(257, 118)
        Me.tbCirculationCheckinResult.Name = "tbCirculationCheckinResult"
        Me.tbCirculationCheckinResult.Size = New System.Drawing.Size(100, 26)
        Me.tbCirculationCheckinResult.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ISBN"
        '
        'tbCirculationCheckinIsbn
        '
        Me.tbCirculationCheckinIsbn.Location = New System.Drawing.Point(257, 53)
        Me.tbCirculationCheckinIsbn.Name = "tbCirculationCheckinIsbn"
        Me.tbCirculationCheckinIsbn.Size = New System.Drawing.Size(100, 26)
        Me.tbCirculationCheckinIsbn.TabIndex = 0
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 489)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.tpReservation.PerformLayout()
        Me.cbPatronReservationFilterCombo.ResumeLayout(False)
        Me.cbPatronReservationFilterCombo.PerformLayout()
        Me.tpSearch.ResumeLayout(False)
        Me.tpSearch.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.tpCreate.ResumeLayout(False)
        Me.tpCreate.PerformLayout()
        Me.tpLogin.ResumeLayout(False)
        Me.tpLogin.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
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
    Friend WithEvents FAQToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents tbPatronSearchSearch As ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents AuthorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbPatronSearchAuthorCombo As ToolStripComboBox
    Friend WithEvents GenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbPatronSearchGenreCombo As ToolStripComboBox
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents cbPatronSearchAvailableCombo As ToolStripComboBox
    Friend WithEvents tpReservation As TabPage
    Friend WithEvents cbPatronReservationFilterCombo As MenuStrip
    Friend WithEvents ToolStripTextBox4 As ToolStripTextBox
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
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
End Class
