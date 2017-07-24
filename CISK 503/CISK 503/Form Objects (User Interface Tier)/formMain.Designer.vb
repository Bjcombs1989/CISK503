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
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CirculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogeManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FAQToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tpContacts = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpHelp = New System.Windows.Forms.TabPage()
        Me.HelpLinkContact = New System.Windows.Forms.LinkLabel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tpAccount = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAccountsDelete = New System.Windows.Forms.Button()
        Me.lvAccounts = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Created = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAccountType = New System.Windows.Forms.ComboBox()
        Me.tbAccountAccountID = New System.Windows.Forms.TextBox()
        Me.tbAccountDateCreated = New System.Windows.Forms.TextBox()
        Me.btnAccountUpdate = New System.Windows.Forms.Button()
        Me.btnAccountBalanceLabel = New System.Windows.Forms.LinkLabel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbAccountBalance = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbAccountUsername = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbAccountNewPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbAccountCurrentPassword = New System.Windows.Forms.TextBox()
        Me.btnAccountChange = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbAccountNewPassword = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tpBooks = New System.Windows.Forms.TabPage()
        Me.btnReservationCheckIn = New System.Windows.Forms.Button()
        Me.btnReservationCheckOut = New System.Windows.Forms.Button()
        Me.txtReservationName = New System.Windows.Forms.TextBox()
        Me.txtReservationPublisher = New System.Windows.Forms.TextBox()
        Me.txtReservationAuthor = New System.Windows.Forms.TextBox()
        Me.txtReservationGenre = New System.Windows.Forms.TextBox()
        Me.btnReservationRemoveHold = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.listviewReservation = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpBook = New System.Windows.Forms.TabPage()
        Me.cmbxPlaceHoldFor = New System.Windows.Forms.ComboBox()
        Me.cmbxCheckOutTo = New System.Windows.Forms.ComboBox()
        Me.btnRemoveHold = New System.Windows.Forms.Button()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtBookPublisher = New System.Windows.Forms.TextBox()
        Me.txtBookAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookGenre = New System.Windows.Forms.TextBox()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnPlaceHold = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tpCatalog = New System.Windows.Forms.TabPage()
        Me.lvCatalog = New System.Windows.Forms.ListView()
        Me.ISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Genre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Publisher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtCatalogBookTitle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cbCatalogGenre = New System.Windows.Forms.ComboBox()
        Me.cbCatalogAuthor = New System.Windows.Forms.ComboBox()
        Me.cbCatalogPublisher = New System.Windows.Forms.ComboBox()
        Me.btnCatalogAdd = New System.Windows.Forms.Button()
        Me.btnCatalogUpdate = New System.Windows.Forms.Button()
        Me.txtCatalogGenre = New System.Windows.Forms.TextBox()
        Me.txtCatalogAuthor = New System.Windows.Forms.TextBox()
        Me.txtCatalogPublisher = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnCatalogAddGenre = New System.Windows.Forms.Button()
        Me.btnCatalogAddPublisher = New System.Windows.Forms.Button()
        Me.btnCatalogAddAuthor = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpContacts.SuspendLayout()
        Me.tpHelp.SuspendLayout()
        Me.tpAccount.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpBooks.SuspendLayout()
        Me.tpSearch.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.tpCreate.SuspendLayout()
        Me.tpLogin.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpBook.SuspendLayout()
        Me.tpCatalog.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatronToolStripMenuItem, Me.CirculationToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1127, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatronToolStripMenuItem
        '
        Me.PatronToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.ReservationToolStripMenuItem, Me.AccountToolStripMenuItem})
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
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(157, 6)
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
        Me.CirculationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewAccountToolStripMenuItem, Me.ToolStripSeparator6, Me.CheckInToolStripMenuItem, Me.CheckOutToolStripMenuItem, Me.ToolStripSeparator7, Me.AccountsToolStripMenuItem})
        Me.CirculationToolStripMenuItem.Name = "CirculationToolStripMenuItem"
        Me.CirculationToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.CirculationToolStripMenuItem.Text = "&Circulation"
        '
        'AddNewAccountToolStripMenuItem
        '
        Me.AddNewAccountToolStripMenuItem.Name = "AddNewAccountToolStripMenuItem"
        Me.AddNewAccountToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddNewAccountToolStripMenuItem.Text = "&Add New Account"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(168, 6)
        '
        'CheckInToolStripMenuItem
        '
        Me.CheckInToolStripMenuItem.Name = "CheckInToolStripMenuItem"
        Me.CheckInToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckInToolStripMenuItem.Text = "Check &In"
        '
        'CheckOutToolStripMenuItem
        '
        Me.CheckOutToolStripMenuItem.Name = "CheckOutToolStripMenuItem"
        Me.CheckOutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckOutToolStripMenuItem.Text = "Check &Out"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(168, 6)
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AccountsToolStripMenuItem.Text = "&Accounts"
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
        Me.CatalogeManagerToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CatalogeManagerToolStripMenuItem.Text = "&Catalogue Manager"
        '
        'AccountManagerToolStripMenuItem
        '
        Me.AccountManagerToolStripMenuItem.Name = "AccountManagerToolStripMenuItem"
        Me.AccountManagerToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AccountManagerToolStripMenuItem.Text = "&Account Manager"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FAQToolStripMenuItem1, Me.ContactsToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'FAQToolStripMenuItem1
        '
        Me.FAQToolStripMenuItem1.Name = "FAQToolStripMenuItem1"
        Me.FAQToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FAQToolStripMenuItem1.Text = "&FAQ"
        '
        'ContactsToolStripMenuItem1
        '
        Me.ContactsToolStripMenuItem1.Name = "ContactsToolStripMenuItem1"
        Me.ContactsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ContactsToolStripMenuItem1.Text = "&Contacts"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
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
        'tpContacts
        '
        Me.tpContacts.BackgroundImage = CType(resources.GetObject("tpContacts.BackgroundImage"), System.Drawing.Image)
        Me.tpContacts.Controls.Add(Me.Label7)
        Me.tpContacts.Location = New System.Drawing.Point(4, 22)
        Me.tpContacts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpContacts.Name = "tpContacts"
        Me.tpContacts.Size = New System.Drawing.Size(1119, 498)
        Me.tpContacts.TabIndex = 11
        Me.tpContacts.Text = "Contacts"
        Me.tpContacts.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 153)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 200)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Warrior Hall University Library" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phone: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(254) 519-5798" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1001 Lea" &
    "dership Place" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Killeen, Texas 76549" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "library@tamuct.edu"
        '
        'tpHelp
        '
        Me.tpHelp.BackgroundImage = CType(resources.GetObject("tpHelp.BackgroundImage"), System.Drawing.Image)
        Me.tpHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tpHelp.Controls.Add(Me.HelpLinkContact)
        Me.tpHelp.Controls.Add(Me.Label31)
        Me.tpHelp.Controls.Add(Me.Label30)
        Me.tpHelp.Controls.Add(Me.Label29)
        Me.tpHelp.Location = New System.Drawing.Point(4, 22)
        Me.tpHelp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpHelp.Name = "tpHelp"
        Me.tpHelp.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpHelp.Size = New System.Drawing.Size(1119, 498)
        Me.tpHelp.TabIndex = 10
        Me.tpHelp.Text = "Help"
        Me.tpHelp.UseVisualStyleBackColor = True
        '
        'HelpLinkContact
        '
        Me.HelpLinkContact.ActiveLinkColor = System.Drawing.Color.Blue
        Me.HelpLinkContact.AutoSize = True
        Me.HelpLinkContact.BackColor = System.Drawing.Color.White
        Me.HelpLinkContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HelpLinkContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpLinkContact.Location = New System.Drawing.Point(25, 298)
        Me.HelpLinkContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HelpLinkContact.Name = "HelpLinkContact"
        Me.HelpLinkContact.Size = New System.Drawing.Size(486, 19)
        Me.HelpLinkContact.TabIndex = 6
        Me.HelpLinkContact.TabStop = True
        Me.HelpLinkContact.Text = "Click HERE for contact information to answer additional questions"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(25, 201)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(475, 70)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = resources.GetString("Label31.Text")
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(25, 121)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(424, 53)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Account information is located through your Account in the Patron" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "drop down menu" &
    ". There you may change your password and veiw" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your account balance."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(25, 40)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(494, 53)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "Request Account: Please contact the librarian on duty to request account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Once y" &
    "ou have received your login username and password you may access" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the library re" &
    "sources."
        '
        'tpAccount
        '
        Me.tpAccount.BackgroundImage = CType(resources.GetObject("tpAccount.BackgroundImage"), System.Drawing.Image)
        Me.tpAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tpAccount.Controls.Add(Me.GroupBox3)
        Me.tpAccount.Controls.Add(Me.lvAccounts)
        Me.tpAccount.Controls.Add(Me.GroupBox1)
        Me.tpAccount.Controls.Add(Me.GroupBox2)
        Me.tpAccount.Location = New System.Drawing.Point(4, 22)
        Me.tpAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpAccount.Name = "tpAccount"
        Me.tpAccount.Size = New System.Drawing.Size(1119, 498)
        Me.tpAccount.TabIndex = 9
        Me.tpAccount.Text = "Account"
        Me.tpAccount.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAccountsDelete)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox3.Location = New System.Drawing.Point(832, 298)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(266, 164)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Delete Account"
        Me.GroupBox3.Visible = False
        '
        'btnAccountsDelete
        '
        Me.btnAccountsDelete.AutoSize = True
        Me.btnAccountsDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountsDelete.Location = New System.Drawing.Point(108, 67)
        Me.btnAccountsDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAccountsDelete.Name = "btnAccountsDelete"
        Me.btnAccountsDelete.Size = New System.Drawing.Size(84, 35)
        Me.btnAccountsDelete.TabIndex = 0
        Me.btnAccountsDelete.Text = "Delete"
        Me.btnAccountsDelete.UseVisualStyleBackColor = True
        '
        'lvAccounts
        '
        Me.lvAccounts.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Username, Me.Created, Me.Type})
        Me.lvAccounts.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvAccounts.FullRowSelect = True
        Me.lvAccounts.Location = New System.Drawing.Point(0, 0)
        Me.lvAccounts.MultiSelect = False
        Me.lvAccounts.Name = "lvAccounts"
        Me.lvAccounts.Size = New System.Drawing.Size(495, 498)
        Me.lvAccounts.TabIndex = 22
        Me.lvAccounts.UseCompatibleStateImageBehavior = False
        Me.lvAccounts.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 30
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 150
        '
        'Created
        '
        Me.Created.Text = "Created"
        Me.Created.Width = 150
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbAccountType)
        Me.GroupBox1.Controls.Add(Me.tbAccountAccountID)
        Me.GroupBox1.Controls.Add(Me.tbAccountDateCreated)
        Me.GroupBox1.Controls.Add(Me.btnAccountUpdate)
        Me.GroupBox1.Controls.Add(Me.btnAccountBalanceLabel)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.tbAccountBalance)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.tbAccountUsername)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox1.Location = New System.Drawing.Point(528, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(373, 265)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Account Information"
        '
        'cbAccountType
        '
        Me.cbAccountType.FormattingEnabled = True
        Me.cbAccountType.Location = New System.Drawing.Point(138, 123)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.Size = New System.Drawing.Size(219, 24)
        Me.cbAccountType.TabIndex = 18
        '
        'tbAccountAccountID
        '
        Me.tbAccountAccountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountAccountID.Location = New System.Drawing.Point(138, 34)
        Me.tbAccountAccountID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbAccountAccountID.Name = "tbAccountAccountID"
        Me.tbAccountAccountID.ReadOnly = True
        Me.tbAccountAccountID.Size = New System.Drawing.Size(219, 23)
        Me.tbAccountAccountID.TabIndex = 10
        '
        'tbAccountDateCreated
        '
        Me.tbAccountDateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountDateCreated.Location = New System.Drawing.Point(138, 93)
        Me.tbAccountDateCreated.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbAccountDateCreated.Name = "tbAccountDateCreated"
        Me.tbAccountDateCreated.ReadOnly = True
        Me.tbAccountDateCreated.Size = New System.Drawing.Size(219, 23)
        Me.tbAccountDateCreated.TabIndex = 17
        '
        'btnAccountUpdate
        '
        Me.btnAccountUpdate.AutoSize = True
        Me.btnAccountUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountUpdate.Location = New System.Drawing.Point(160, 202)
        Me.btnAccountUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAccountUpdate.Name = "btnAccountUpdate"
        Me.btnAccountUpdate.Size = New System.Drawing.Size(91, 35)
        Me.btnAccountUpdate.TabIndex = 1
        Me.btnAccountUpdate.Text = "Update"
        Me.btnAccountUpdate.UseVisualStyleBackColor = True
        '
        'btnAccountBalanceLabel
        '
        Me.btnAccountBalanceLabel.AutoSize = True
        Me.btnAccountBalanceLabel.BackColor = System.Drawing.Color.White
        Me.btnAccountBalanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountBalanceLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.btnAccountBalanceLabel.Location = New System.Drawing.Point(22, 156)
        Me.btnAccountBalanceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnAccountBalanceLabel.Name = "btnAccountBalanceLabel"
        Me.btnAccountBalanceLabel.Size = New System.Drawing.Size(66, 17)
        Me.btnAccountBalanceLabel.TabIndex = 16
        Me.btnAccountBalanceLabel.TabStop = True
        Me.btnAccountBalanceLabel.Text = "Balance"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 37)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 17)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Account ID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(22, 67)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 17)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Username"
        '
        'tbAccountBalance
        '
        Me.tbAccountBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountBalance.Location = New System.Drawing.Point(138, 153)
        Me.tbAccountBalance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbAccountBalance.Name = "tbAccountBalance"
        Me.tbAccountBalance.ReadOnly = True
        Me.tbAccountBalance.Size = New System.Drawing.Size(219, 23)
        Me.tbAccountBalance.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(22, 96)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 17)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Date Created"
        '
        'tbAccountUsername
        '
        Me.tbAccountUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountUsername.Location = New System.Drawing.Point(138, 64)
        Me.tbAccountUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbAccountUsername.Name = "tbAccountUsername"
        Me.tbAccountUsername.Size = New System.Drawing.Size(219, 23)
        Me.tbAccountUsername.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(22, 123)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 17)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbAccountNewPasswordConfirm)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.tbAccountCurrentPassword)
        Me.GroupBox2.Controls.Add(Me.btnAccountChange)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.tbAccountNewPassword)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox2.Location = New System.Drawing.Point(528, 298)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(266, 164)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Change Password"
        '
        'tbAccountNewPasswordConfirm
        '
        Me.tbAccountNewPasswordConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountNewPasswordConfirm.Location = New System.Drawing.Point(127, 93)
        Me.tbAccountNewPasswordConfirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbAccountNewPasswordConfirm.Name = "tbAccountNewPasswordConfirm"
        Me.tbAccountNewPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbAccountNewPasswordConfirm.Size = New System.Drawing.Size(120, 23)
        Me.tbAccountNewPasswordConfirm.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(13, 96)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(103, 15)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Confirm"
        '
        'tbAccountCurrentPassword
        '
        Me.tbAccountCurrentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountCurrentPassword.Location = New System.Drawing.Point(127, 30)
        Me.tbAccountCurrentPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbAccountCurrentPassword.Name = "tbAccountCurrentPassword"
        Me.tbAccountCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbAccountCurrentPassword.Size = New System.Drawing.Size(120, 23)
        Me.tbAccountCurrentPassword.TabIndex = 14
        '
        'btnAccountChange
        '
        Me.btnAccountChange.AutoSize = True
        Me.btnAccountChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountChange.Location = New System.Drawing.Point(103, 120)
        Me.btnAccountChange.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAccountChange.Name = "btnAccountChange"
        Me.btnAccountChange.Size = New System.Drawing.Size(98, 35)
        Me.btnAccountChange.TabIndex = 0
        Me.btnAccountChange.Text = "Change"
        Me.btnAccountChange.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 33)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 16)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Old Password"
        '
        'tbAccountNewPassword
        '
        Me.tbAccountNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountNewPassword.Location = New System.Drawing.Point(127, 62)
        Me.tbAccountNewPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbAccountNewPassword.Name = "tbAccountNewPassword"
        Me.tbAccountNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbAccountNewPassword.Size = New System.Drawing.Size(120, 23)
        Me.tbAccountNewPassword.TabIndex = 15
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 67)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(103, 15)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "New Password"
        '
        'tpBooks
        '
        Me.tpBooks.BackgroundImage = CType(resources.GetObject("tpBooks.BackgroundImage"), System.Drawing.Image)
        Me.tpBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tpBooks.Controls.Add(Me.btnReservationCheckIn)
        Me.tpBooks.Controls.Add(Me.btnReservationCheckOut)
        Me.tpBooks.Controls.Add(Me.txtReservationName)
        Me.tpBooks.Controls.Add(Me.txtReservationPublisher)
        Me.tpBooks.Controls.Add(Me.txtReservationAuthor)
        Me.tpBooks.Controls.Add(Me.txtReservationGenre)
        Me.tpBooks.Controls.Add(Me.btnReservationRemoveHold)
        Me.tpBooks.Controls.Add(Me.Label13)
        Me.tpBooks.Controls.Add(Me.Label14)
        Me.tpBooks.Controls.Add(Me.Label15)
        Me.tpBooks.Controls.Add(Me.Label16)
        Me.tpBooks.Controls.Add(Me.listviewReservation)
        Me.tpBooks.Location = New System.Drawing.Point(4, 22)
        Me.tpBooks.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpBooks.Name = "tpBooks"
        Me.tpBooks.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpBooks.Size = New System.Drawing.Size(1119, 498)
        Me.tpBooks.TabIndex = 4
        Me.tpBooks.Text = "Books"
        Me.tpBooks.UseVisualStyleBackColor = True
        '
        'btnReservationCheckIn
        '
        Me.btnReservationCheckIn.Enabled = False
        Me.btnReservationCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservationCheckIn.Location = New System.Drawing.Point(855, 169)
        Me.btnReservationCheckIn.Name = "btnReservationCheckIn"
        Me.btnReservationCheckIn.Size = New System.Drawing.Size(90, 23)
        Me.btnReservationCheckIn.TabIndex = 15
        Me.btnReservationCheckIn.Text = "Check In"
        Me.btnReservationCheckIn.UseVisualStyleBackColor = True
        '
        'btnReservationCheckOut
        '
        Me.btnReservationCheckOut.Enabled = False
        Me.btnReservationCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservationCheckOut.Location = New System.Drawing.Point(855, 198)
        Me.btnReservationCheckOut.Name = "btnReservationCheckOut"
        Me.btnReservationCheckOut.Size = New System.Drawing.Size(90, 23)
        Me.btnReservationCheckOut.TabIndex = 14
        Me.btnReservationCheckOut.Text = "Check Out"
        Me.btnReservationCheckOut.UseVisualStyleBackColor = True
        '
        'txtReservationName
        '
        Me.txtReservationName.Enabled = False
        Me.txtReservationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReservationName.Location = New System.Drawing.Point(855, 21)
        Me.txtReservationName.Name = "txtReservationName"
        Me.txtReservationName.Size = New System.Drawing.Size(240, 23)
        Me.txtReservationName.TabIndex = 13
        '
        'txtReservationPublisher
        '
        Me.txtReservationPublisher.Enabled = False
        Me.txtReservationPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReservationPublisher.Location = New System.Drawing.Point(855, 99)
        Me.txtReservationPublisher.Name = "txtReservationPublisher"
        Me.txtReservationPublisher.Size = New System.Drawing.Size(240, 23)
        Me.txtReservationPublisher.TabIndex = 10
        '
        'txtReservationAuthor
        '
        Me.txtReservationAuthor.Enabled = False
        Me.txtReservationAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReservationAuthor.Location = New System.Drawing.Point(855, 72)
        Me.txtReservationAuthor.Name = "txtReservationAuthor"
        Me.txtReservationAuthor.Size = New System.Drawing.Size(240, 23)
        Me.txtReservationAuthor.TabIndex = 11
        '
        'txtReservationGenre
        '
        Me.txtReservationGenre.Enabled = False
        Me.txtReservationGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReservationGenre.Location = New System.Drawing.Point(855, 45)
        Me.txtReservationGenre.Name = "txtReservationGenre"
        Me.txtReservationGenre.Size = New System.Drawing.Size(240, 23)
        Me.txtReservationGenre.TabIndex = 12
        '
        'btnReservationRemoveHold
        '
        Me.btnReservationRemoveHold.Enabled = False
        Me.btnReservationRemoveHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservationRemoveHold.Location = New System.Drawing.Point(855, 140)
        Me.btnReservationRemoveHold.Name = "btnReservationRemoveHold"
        Me.btnReservationRemoveHold.Size = New System.Drawing.Size(90, 23)
        Me.btnReservationRemoveHold.TabIndex = 9
        Me.btnReservationRemoveHold.Text = "Remove Hold"
        Me.btnReservationRemoveHold.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(784, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 19)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Genre"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(784, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Publisher"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(784, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 19)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Author"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(784, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 19)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Name"
        '
        'listviewReservation
        '
        Me.listviewReservation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.listviewReservation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.listviewReservation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.listviewReservation.ForeColor = System.Drawing.SystemColors.InfoText
        Me.listviewReservation.FullRowSelect = True
        Me.listviewReservation.Location = New System.Drawing.Point(0, 0)
        Me.listviewReservation.MultiSelect = False
        Me.listviewReservation.Name = "listviewReservation"
        Me.listviewReservation.Size = New System.Drawing.Size(768, 503)
        Me.listviewReservation.TabIndex = 0
        Me.listviewReservation.TileSize = New System.Drawing.Size(505, 50)
        Me.listviewReservation.UseCompatibleStateImageBehavior = False
        Me.listviewReservation.View = System.Windows.Forms.View.Details
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
        Me.ColumnHeader3.Text = "Patron"
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
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Type"
        Me.ColumnHeader6.Width = 80
        '
        'tpSearch
        '
        Me.tpSearch.Controls.Add(Me.dgvSearch)
        Me.tpSearch.Controls.Add(Me.ToolStrip1)
        Me.tpSearch.Controls.Add(Me.btPatronSearchHold)
        Me.tpSearch.Location = New System.Drawing.Point(4, 22)
        Me.tpSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpSearch.Name = "tpSearch"
        Me.tpSearch.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpSearch.Size = New System.Drawing.Size(1119, 499)
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
        Me.dgvSearch.Size = New System.Drawing.Size(1115, 470)
        Me.dgvSearch.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtSearchISBN, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.txtSearchTitle, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.cmbxSearchGenre, Me.ToolStripSeparator3, Me.ToolStripLabel4, Me.cmbxSearchStatus, Me.ToolStripSeparator4, Me.btnSearchClear, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1115, 25)
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
        Me.btPatronSearchHold.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btPatronSearchHold.Name = "btPatronSearchHold"
        Me.btPatronSearchHold.Size = New System.Drawing.Size(61, 22)
        Me.btPatronSearchHold.TabIndex = 1
        Me.btPatronSearchHold.Text = "HOLD"
        Me.btPatronSearchHold.UseVisualStyleBackColor = True
        '
        'tpCreate
        '
        Me.tpCreate.BackgroundImage = CType(resources.GetObject("tpCreate.BackgroundImage"), System.Drawing.Image)
        Me.tpCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tpCreate.Controls.Add(Me.cmboxAccountTypeAddAccount)
        Me.tpCreate.Controls.Add(Me.Label6)
        Me.tpCreate.Controls.Add(Me.btnAddAccount)
        Me.tpCreate.Controls.Add(Me.txtPasswordAddAccount)
        Me.tpCreate.Controls.Add(Me.txtUsernameAddAccount)
        Me.tpCreate.Controls.Add(Me.Label3)
        Me.tpCreate.Controls.Add(Me.Label4)
        Me.tpCreate.Location = New System.Drawing.Point(4, 22)
        Me.tpCreate.Name = "tpCreate"
        Me.tpCreate.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpCreate.Size = New System.Drawing.Size(1119, 499)
        Me.tpCreate.TabIndex = 1
        Me.tpCreate.Text = "CreateAcct"
        Me.tpCreate.UseVisualStyleBackColor = True
        '
        'cmboxAccountTypeAddAccount
        '
        Me.cmboxAccountTypeAddAccount.FormattingEnabled = True
        Me.cmboxAccountTypeAddAccount.Location = New System.Drawing.Point(146, 97)
        Me.cmboxAccountTypeAddAccount.Name = "cmboxAccountTypeAddAccount"
        Me.cmboxAccountTypeAddAccount.Size = New System.Drawing.Size(232, 21)
        Me.cmboxAccountTypeAddAccount.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Account Type:"
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(146, 137)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(232, 23)
        Me.btnAddAccount.TabIndex = 9
        Me.btnAddAccount.Text = "Add Account"
        Me.btnAddAccount.UseVisualStyleBackColor = True
        '
        'txtPasswordAddAccount
        '
        Me.txtPasswordAddAccount.Location = New System.Drawing.Point(146, 57)
        Me.txtPasswordAddAccount.Name = "txtPasswordAddAccount"
        Me.txtPasswordAddAccount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordAddAccount.Size = New System.Drawing.Size(232, 20)
        Me.txtPasswordAddAccount.TabIndex = 8
        '
        'txtUsernameAddAccount
        '
        Me.txtUsernameAddAccount.Location = New System.Drawing.Point(146, 24)
        Me.txtUsernameAddAccount.Name = "txtUsernameAddAccount"
        Me.txtUsernameAddAccount.Size = New System.Drawing.Size(232, 20)
        Me.txtUsernameAddAccount.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Username:"
        '
        'tpLogin
        '
        Me.tpLogin.BackgroundImage = CType(resources.GetObject("tpLogin.BackgroundImage"), System.Drawing.Image)
        Me.tpLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tpLogin.Controls.Add(Me.btnLogin)
        Me.tpLogin.Controls.Add(Me.txtPassword)
        Me.tpLogin.Controls.Add(Me.txtUsername)
        Me.tpLogin.Controls.Add(Me.Label2)
        Me.tpLogin.Controls.Add(Me.Label21)
        Me.tpLogin.Controls.Add(Me.Label1)
        Me.tpLogin.Location = New System.Drawing.Point(4, 22)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpLogin.Size = New System.Drawing.Size(1119, 498)
        Me.tpLogin.TabIndex = 0
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(202, 140)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(115, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(202, 100)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(115, 20)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(202, 58)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(115, 20)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(362, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(278, 117)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Accounts for testing purposes:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Admin -  admin/admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Patron - pat/pat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Librari" &
    "an - lib/lib"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpLogin)
        Me.TabControl1.Controls.Add(Me.tpCreate)
        Me.TabControl1.Controls.Add(Me.tpSearch)
        Me.TabControl1.Controls.Add(Me.tpBook)
        Me.TabControl1.Controls.Add(Me.tpBooks)
        Me.TabControl1.Controls.Add(Me.tpAccount)
        Me.TabControl1.Controls.Add(Me.tpHelp)
        Me.TabControl1.Controls.Add(Me.tpContacts)
        Me.TabControl1.Controls.Add(Me.tpCatalog)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1127, 524)
        Me.TabControl1.TabIndex = 1
        '
        'tpBook
        '
        Me.tpBook.BackgroundImage = CType(resources.GetObject("tpBook.BackgroundImage"), System.Drawing.Image)
        Me.tpBook.Controls.Add(Me.cmbxPlaceHoldFor)
        Me.tpBook.Controls.Add(Me.cmbxCheckOutTo)
        Me.tpBook.Controls.Add(Me.btnRemoveHold)
        Me.tpBook.Controls.Add(Me.txtBookName)
        Me.tpBook.Controls.Add(Me.txtBookPublisher)
        Me.tpBook.Controls.Add(Me.txtBookAuthor)
        Me.tpBook.Controls.Add(Me.txtBookGenre)
        Me.tpBook.Controls.Add(Me.btnCheckIn)
        Me.tpBook.Controls.Add(Me.btnCheckOut)
        Me.tpBook.Controls.Add(Me.btnPlaceHold)
        Me.tpBook.Controls.Add(Me.Label10)
        Me.tpBook.Controls.Add(Me.Label20)
        Me.tpBook.Controls.Add(Me.Label5)
        Me.tpBook.Controls.Add(Me.Label12)
        Me.tpBook.Controls.Add(Me.Label11)
        Me.tpBook.Controls.Add(Me.Label9)
        Me.tpBook.Location = New System.Drawing.Point(4, 22)
        Me.tpBook.Name = "tpBook"
        Me.tpBook.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpBook.Size = New System.Drawing.Size(1119, 498)
        Me.tpBook.TabIndex = 14
        Me.tpBook.Text = "Book"
        Me.tpBook.UseVisualStyleBackColor = True
        '
        'cmbxPlaceHoldFor
        '
        Me.cmbxPlaceHoldFor.FormattingEnabled = True
        Me.cmbxPlaceHoldFor.Location = New System.Drawing.Point(153, 272)
        Me.cmbxPlaceHoldFor.Name = "cmbxPlaceHoldFor"
        Me.cmbxPlaceHoldFor.Size = New System.Drawing.Size(259, 21)
        Me.cmbxPlaceHoldFor.TabIndex = 15
        '
        'cmbxCheckOutTo
        '
        Me.cmbxCheckOutTo.FormattingEnabled = True
        Me.cmbxCheckOutTo.Location = New System.Drawing.Point(153, 240)
        Me.cmbxCheckOutTo.Name = "cmbxCheckOutTo"
        Me.cmbxCheckOutTo.Size = New System.Drawing.Size(259, 21)
        Me.cmbxCheckOutTo.TabIndex = 15
        '
        'btnRemoveHold
        '
        Me.btnRemoveHold.Location = New System.Drawing.Point(247, 179)
        Me.btnRemoveHold.Name = "btnRemoveHold"
        Me.btnRemoveHold.Size = New System.Drawing.Size(90, 23)
        Me.btnRemoveHold.TabIndex = 14
        Me.btnRemoveHold.Text = "Remove Hold"
        Me.btnRemoveHold.UseVisualStyleBackColor = True
        '
        'txtBookName
        '
        Me.txtBookName.Enabled = False
        Me.txtBookName.Location = New System.Drawing.Point(94, 24)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(318, 20)
        Me.txtBookName.TabIndex = 3
        '
        'txtBookPublisher
        '
        Me.txtBookPublisher.Enabled = False
        Me.txtBookPublisher.Location = New System.Drawing.Point(94, 102)
        Me.txtBookPublisher.Name = "txtBookPublisher"
        Me.txtBookPublisher.Size = New System.Drawing.Size(318, 20)
        Me.txtBookPublisher.TabIndex = 2
        '
        'txtBookAuthor
        '
        Me.txtBookAuthor.Enabled = False
        Me.txtBookAuthor.Location = New System.Drawing.Point(94, 75)
        Me.txtBookAuthor.Name = "txtBookAuthor"
        Me.txtBookAuthor.Size = New System.Drawing.Size(318, 20)
        Me.txtBookAuthor.TabIndex = 2
        '
        'txtBookGenre
        '
        Me.txtBookGenre.Enabled = False
        Me.txtBookGenre.Location = New System.Drawing.Point(94, 48)
        Me.txtBookGenre.Name = "txtBookGenre"
        Me.txtBookGenre.Size = New System.Drawing.Size(318, 20)
        Me.txtBookGenre.TabIndex = 2
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Location = New System.Drawing.Point(247, 150)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(90, 23)
        Me.btnCheckIn.TabIndex = 1
        Me.btnCheckIn.Text = "Check In"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(151, 179)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(90, 23)
        Me.btnCheckOut.TabIndex = 1
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'btnPlaceHold
        '
        Me.btnPlaceHold.Location = New System.Drawing.Point(151, 150)
        Me.btnPlaceHold.Name = "btnPlaceHold"
        Me.btnPlaceHold.Size = New System.Drawing.Size(90, 23)
        Me.btnPlaceHold.TabIndex = 1
        Me.btnPlaceHold.Text = "Place Hold"
        Me.btnPlaceHold.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Genre"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(19, 272)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 21)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Place hold for:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Check out to:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Publisher"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Author"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Name"
        '
        'tpCatalog
        '
        Me.tpCatalog.BackgroundImage = CType(resources.GetObject("tpCatalog.BackgroundImage"), System.Drawing.Image)
        Me.tpCatalog.Controls.Add(Me.txtCatalogPublisher)
        Me.tpCatalog.Controls.Add(Me.txtCatalogAuthor)
        Me.tpCatalog.Controls.Add(Me.txtCatalogGenre)
        Me.tpCatalog.Controls.Add(Me.btnCatalogUpdate)
        Me.tpCatalog.Controls.Add(Me.btnCatalogAddAuthor)
        Me.tpCatalog.Controls.Add(Me.btnCatalogAddPublisher)
        Me.tpCatalog.Controls.Add(Me.btnCatalogAddGenre)
        Me.tpCatalog.Controls.Add(Me.btnCatalogAdd)
        Me.tpCatalog.Controls.Add(Me.cbCatalogPublisher)
        Me.tpCatalog.Controls.Add(Me.cbCatalogAuthor)
        Me.tpCatalog.Controls.Add(Me.cbCatalogGenre)
        Me.tpCatalog.Controls.Add(Me.lvCatalog)
        Me.tpCatalog.Controls.Add(Me.txtCatalogBookTitle)
        Me.tpCatalog.Controls.Add(Me.Label34)
        Me.tpCatalog.Controls.Add(Me.Label8)
        Me.tpCatalog.Controls.Add(Me.Label32)
        Me.tpCatalog.Controls.Add(Me.Label22)
        Me.tpCatalog.Controls.Add(Me.Label33)
        Me.tpCatalog.Controls.Add(Me.Label27)
        Me.tpCatalog.Controls.Add(Me.Label28)
        Me.tpCatalog.Location = New System.Drawing.Point(4, 22)
        Me.tpCatalog.Name = "tpCatalog"
        Me.tpCatalog.Size = New System.Drawing.Size(1119, 498)
        Me.tpCatalog.TabIndex = 15
        Me.tpCatalog.Text = "Catalog"
        Me.tpCatalog.UseVisualStyleBackColor = True
        '
        'lvCatalog
        '
        Me.lvCatalog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvCatalog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ISBN, Me.Title, Me.Genre, Me.Author, Me.Publisher})
        Me.lvCatalog.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lvCatalog.FullRowSelect = True
        Me.lvCatalog.Location = New System.Drawing.Point(0, 1)
        Me.lvCatalog.MultiSelect = False
        Me.lvCatalog.Name = "lvCatalog"
        Me.lvCatalog.Size = New System.Drawing.Size(705, 504)
        Me.lvCatalog.TabIndex = 12
        Me.lvCatalog.TileSize = New System.Drawing.Size(505, 50)
        Me.lvCatalog.UseCompatibleStateImageBehavior = False
        Me.lvCatalog.View = System.Windows.Forms.View.Details
        '
        'ISBN
        '
        Me.ISBN.Text = "ISBN"
        Me.ISBN.Width = 51
        '
        'Title
        '
        Me.Title.Text = "Book Title"
        Me.Title.Width = 177
        '
        'Genre
        '
        Me.Genre.Text = "Genre"
        Me.Genre.Width = 143
        '
        'Author
        '
        Me.Author.Text = "Author"
        Me.Author.Width = 144
        '
        'Publisher
        '
        Me.Publisher.Text = "Publisher"
        Me.Publisher.Width = 175
        '
        'txtCatalogBookTitle
        '
        Me.txtCatalogBookTitle.Location = New System.Drawing.Point(816, 11)
        Me.txtCatalogBookTitle.Name = "txtCatalogBookTitle"
        Me.txtCatalogBookTitle.Size = New System.Drawing.Size(295, 20)
        Me.txtCatalogBookTitle.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(718, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Genre"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(718, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 18)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Publisher"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(718, 62)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(92, 18)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Author"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(718, 11)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(92, 18)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Name"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'cbCatalogGenre
        '
        Me.cbCatalogGenre.FormattingEnabled = True
        Me.cbCatalogGenre.Location = New System.Drawing.Point(816, 35)
        Me.cbCatalogGenre.Name = "cbCatalogGenre"
        Me.cbCatalogGenre.Size = New System.Drawing.Size(295, 21)
        Me.cbCatalogGenre.TabIndex = 13
        '
        'cbCatalogAuthor
        '
        Me.cbCatalogAuthor.FormattingEnabled = True
        Me.cbCatalogAuthor.Location = New System.Drawing.Point(816, 62)
        Me.cbCatalogAuthor.Name = "cbCatalogAuthor"
        Me.cbCatalogAuthor.Size = New System.Drawing.Size(295, 21)
        Me.cbCatalogAuthor.TabIndex = 13
        '
        'cbCatalogPublisher
        '
        Me.cbCatalogPublisher.FormattingEnabled = True
        Me.cbCatalogPublisher.Location = New System.Drawing.Point(816, 89)
        Me.cbCatalogPublisher.Name = "cbCatalogPublisher"
        Me.cbCatalogPublisher.Size = New System.Drawing.Size(295, 21)
        Me.cbCatalogPublisher.TabIndex = 13
        '
        'btnCatalogAdd
        '
        Me.btnCatalogAdd.Location = New System.Drawing.Point(718, 127)
        Me.btnCatalogAdd.Name = "btnCatalogAdd"
        Me.btnCatalogAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnCatalogAdd.TabIndex = 14
        Me.btnCatalogAdd.Text = "Add"
        Me.btnCatalogAdd.UseVisualStyleBackColor = True
        '
        'btnCatalogUpdate
        '
        Me.btnCatalogUpdate.Location = New System.Drawing.Point(816, 127)
        Me.btnCatalogUpdate.Name = "btnCatalogUpdate"
        Me.btnCatalogUpdate.Size = New System.Drawing.Size(92, 23)
        Me.btnCatalogUpdate.TabIndex = 14
        Me.btnCatalogUpdate.Text = "Update"
        Me.btnCatalogUpdate.UseVisualStyleBackColor = True
        '
        'txtCatalogGenre
        '
        Me.txtCatalogGenre.Location = New System.Drawing.Point(718, 223)
        Me.txtCatalogGenre.Name = "txtCatalogGenre"
        Me.txtCatalogGenre.Size = New System.Drawing.Size(262, 20)
        Me.txtCatalogGenre.TabIndex = 15
        '
        'txtCatalogAuthor
        '
        Me.txtCatalogAuthor.Location = New System.Drawing.Point(718, 272)
        Me.txtCatalogAuthor.Name = "txtCatalogAuthor"
        Me.txtCatalogAuthor.Size = New System.Drawing.Size(262, 20)
        Me.txtCatalogAuthor.TabIndex = 15
        '
        'txtCatalogPublisher
        '
        Me.txtCatalogPublisher.Location = New System.Drawing.Point(718, 319)
        Me.txtCatalogPublisher.Name = "txtCatalogPublisher"
        Me.txtCatalogPublisher.Size = New System.Drawing.Size(262, 20)
        Me.txtCatalogPublisher.TabIndex = 15
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(718, 298)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(92, 18)
        Me.Label32.TabIndex = 5
        Me.Label32.Text = "Publisher"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(718, 251)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(92, 18)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Author"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(718, 202)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(92, 18)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "Genre"
        '
        'btnCatalogAddGenre
        '
        Me.btnCatalogAddGenre.Location = New System.Drawing.Point(986, 221)
        Me.btnCatalogAddGenre.Name = "btnCatalogAddGenre"
        Me.btnCatalogAddGenre.Size = New System.Drawing.Size(92, 23)
        Me.btnCatalogAddGenre.TabIndex = 14
        Me.btnCatalogAddGenre.Text = "Add"
        Me.btnCatalogAddGenre.UseVisualStyleBackColor = True
        '
        'btnCatalogAddPublisher
        '
        Me.btnCatalogAddPublisher.Location = New System.Drawing.Point(986, 317)
        Me.btnCatalogAddPublisher.Name = "btnCatalogAddPublisher"
        Me.btnCatalogAddPublisher.Size = New System.Drawing.Size(92, 23)
        Me.btnCatalogAddPublisher.TabIndex = 14
        Me.btnCatalogAddPublisher.Text = "Add"
        Me.btnCatalogAddPublisher.UseVisualStyleBackColor = True
        '
        'btnCatalogAddAuthor
        '
        Me.btnCatalogAddAuthor.Location = New System.Drawing.Point(986, 270)
        Me.btnCatalogAddAuthor.Name = "btnCatalogAddAuthor"
        Me.btnCatalogAddAuthor.Size = New System.Drawing.Size(92, 23)
        Me.btnCatalogAddAuthor.TabIndex = 14
        Me.btnCatalogAddAuthor.Text = "Add"
        Me.btnCatalogAddAuthor.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 548)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "formMain"
        Me.Text = "Library Circulation Desk"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpContacts.ResumeLayout(False)
        Me.tpContacts.PerformLayout()
        Me.tpHelp.ResumeLayout(False)
        Me.tpHelp.PerformLayout()
        Me.tpAccount.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpBooks.ResumeLayout(False)
        Me.tpBooks.PerformLayout()
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
        Me.tpCatalog.ResumeLayout(False)
        Me.tpCatalog.PerformLayout()
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
	Friend WithEvents CheckOutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CheckInToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
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
	Friend WithEvents tpBooks As TabPage
	Friend WithEvents tpAccount As TabPage
	Friend WithEvents tpHelp As TabPage
	Friend WithEvents tpContacts As TabPage
	Friend WithEvents Label7 As Label
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
	Friend WithEvents btnCheckOut As Button
	Friend WithEvents btnPlaceHold As Button
	Friend WithEvents ColumnHeader1 As ColumnHeader
	Friend WithEvents ColumnHeader2 As ColumnHeader
	Friend WithEvents ColumnHeader3 As ColumnHeader
	Friend WithEvents ColumnHeader4 As ColumnHeader
	Friend WithEvents ColumnHeader5 As ColumnHeader
	Friend WithEvents txtBookName As TextBox
	Friend WithEvents txtBookPublisher As TextBox
	Friend WithEvents txtBookAuthor As TextBox
	Friend WithEvents txtBookGenre As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents ColumnHeader6 As ColumnHeader
	Friend WithEvents txtReservationName As TextBox
	Friend WithEvents txtReservationPublisher As TextBox
	Friend WithEvents txtReservationAuthor As TextBox
	Friend WithEvents txtReservationGenre As TextBox
	Friend WithEvents btnReservationRemoveHold As Button
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
	Friend WithEvents btnCheckIn As Button
	Friend WithEvents btnRemoveHold As Button
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
	Friend WithEvents btnAccountBalanceLabel As LinkLabel
	Friend WithEvents tbAccountNewPassword As TextBox
	Friend WithEvents tbAccountCurrentPassword As TextBox
	Friend WithEvents tbAccountBalance As TextBox
	Friend WithEvents tbAccountUsername As TextBox
	Friend WithEvents tbAccountAccountID As TextBox
	Friend WithEvents Label26 As Label
	Friend WithEvents Label25 As Label
	Friend WithEvents Label24 As Label
	Friend WithEvents Label19 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents btnAccountUpdate As Button
	Friend WithEvents btnAccountChange As Button
	Friend WithEvents tbAccountNewPasswordConfirm As TextBox
	Friend WithEvents tbAccountDateCreated As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label23 As Label
	Friend WithEvents btnReservationCheckIn As Button
	Friend WithEvents btnReservationCheckOut As Button
	Friend WithEvents cmbxPlaceHoldFor As ComboBox
	Friend WithEvents cmbxCheckOutTo As ComboBox
	Friend WithEvents Label20 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents cbAccountType As ComboBox
	Friend WithEvents lvAccounts As ListView
	Friend WithEvents ID As ColumnHeader
	Friend WithEvents Username As ColumnHeader
	Friend WithEvents Created As ColumnHeader
	Friend WithEvents Type As ColumnHeader
	Friend WithEvents Label21 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents btnAccountsDelete As Button
	Friend WithEvents tpCatalog As TabPage
	Friend WithEvents lvCatalog As ListView
	Friend WithEvents Title As ColumnHeader
	Friend WithEvents Author As ColumnHeader
	Friend WithEvents Genre As ColumnHeader
	Friend WithEvents Publisher As ColumnHeader
	Friend WithEvents ISBN As ColumnHeader
	Friend WithEvents txtCatalogBookTitle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents HelpLinkContact As LinkLabel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents cbCatalogPublisher As ComboBox
    Friend WithEvents cbCatalogAuthor As ComboBox
    Friend WithEvents cbCatalogGenre As ComboBox
    Friend WithEvents btnCatalogUpdate As Button
    Friend WithEvents btnCatalogAdd As Button
    Friend WithEvents txtCatalogPublisher As TextBox
    Friend WithEvents txtCatalogAuthor As TextBox
    Friend WithEvents txtCatalogGenre As TextBox
    Friend WithEvents btnCatalogAddAuthor As Button
    Friend WithEvents btnCatalogAddPublisher As Button
    Friend WithEvents btnCatalogAddGenre As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
End Class
