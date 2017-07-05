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
		Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
		Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CirculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddNewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.ReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CheckInOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CatalogeManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AccountManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LibraryContactInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FAQToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.tpWelcome = New System.Windows.Forms.TabPage()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.tpLogin = New System.Windows.Forms.TabPage()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.tpCreate = New System.Windows.Forms.TabPage()
		Me.cmbxAccountTypeAddAccount = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnAddAccount = New System.Windows.Forms.Button()
		Me.txtPasswordAddAccount = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtUsernameAddAccount = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.tpSearch = New System.Windows.Forms.TabPage()
		Me.dgvSearch = New System.Windows.Forms.DataGridView()
		Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Publisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Check_Out = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.Place_Hold = New System.Windows.Forms.DataGridViewButtonColumn()
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
		Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
		Me.btnSearchSearch = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
		Me.btnSearchClear = New System.Windows.Forms.ToolStripButton()
		Me.tpReservation = New System.Windows.Forms.TabPage()
		Me.tpReservations = New System.Windows.Forms.TabPage()
		Me.tpCheckIn = New System.Windows.Forms.TabPage()
		Me.tpAccount = New System.Windows.Forms.TabPage()
		Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.CheckInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tpCheckOut = New System.Windows.Forms.TabPage()
		Me.MenuStrip1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.tpWelcome.SuspendLayout()
		Me.tpLogin.SuspendLayout()
		Me.tpCreate.SuspendLayout()
		Me.tpSearch.SuspendLayout()
		CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ToolStrip1.SuspendLayout()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatronToolStripMenuItem, Me.CirculationToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LoginToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
		Me.MenuStrip1.Size = New System.Drawing.Size(1314, 35)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'PatronToolStripMenuItem
		'
		Me.PatronToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ToolStripSeparator6, Me.ReservationToolStripMenuItem, Me.ToolStripSeparator7, Me.AccountToolStripMenuItem})
		Me.PatronToolStripMenuItem.Name = "PatronToolStripMenuItem"
		Me.PatronToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
		Me.PatronToolStripMenuItem.Text = "&Patron"
		'
		'SearchToolStripMenuItem
		'
		Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
		Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
		Me.SearchToolStripMenuItem.Text = "&Search"
		'
		'ToolStripSeparator6
		'
		Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
		Me.ToolStripSeparator6.Size = New System.Drawing.Size(207, 6)
		'
		'ReservationToolStripMenuItem
		'
		Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
		Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
		Me.ReservationToolStripMenuItem.Text = "My &Library"
		'
		'ToolStripSeparator7
		'
		Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
		Me.ToolStripSeparator7.Size = New System.Drawing.Size(207, 6)
		'
		'AccountToolStripMenuItem
		'
		Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
		Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
		Me.AccountToolStripMenuItem.Text = "My &Account"
		'
		'CirculationToolStripMenuItem
		'
		Me.CirculationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewAccountToolStripMenuItem, Me.ToolStripSeparator4, Me.CheckInOutToolStripMenuItem, Me.ReservationsToolStripMenuItem, Me.CheckInToolStripMenuItem, Me.ToolStripSeparator5, Me.AccountsToolStripMenuItem, Me.PaymentsToolStripMenuItem})
		Me.CirculationToolStripMenuItem.Name = "CirculationToolStripMenuItem"
		Me.CirculationToolStripMenuItem.Size = New System.Drawing.Size(91, 29)
		Me.CirculationToolStripMenuItem.Text = "&Librarian"
		'
		'AddNewAccountToolStripMenuItem
		'
		Me.AddNewAccountToolStripMenuItem.Name = "AddNewAccountToolStripMenuItem"
		Me.AddNewAccountToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
		Me.AddNewAccountToolStripMenuItem.Text = "&Add New Account"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(237, 6)
		'
		'ReservationsToolStripMenuItem
		'
		Me.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem"
		Me.ReservationsToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
		Me.ReservationsToolStripMenuItem.Text = "Reservations"
		'
		'CheckInOutToolStripMenuItem
		'
		Me.CheckInOutToolStripMenuItem.Name = "CheckInOutToolStripMenuItem"
		Me.CheckInOutToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
		Me.CheckInOutToolStripMenuItem.Text = "Check Out"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(237, 6)
		'
		'AccountsToolStripMenuItem
		'
		Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
		Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
		Me.AccountsToolStripMenuItem.Text = "Accounts"
		'
		'PaymentsToolStripMenuItem
		'
		Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
		Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
		Me.PaymentsToolStripMenuItem.Text = "Payments"
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
		Me.CatalogeManagerToolStripMenuItem.Size = New System.Drawing.Size(236, 30)
		Me.CatalogeManagerToolStripMenuItem.Text = "Catalog Manager"
		'
		'AccountManagerToolStripMenuItem
		'
		Me.AccountManagerToolStripMenuItem.Name = "AccountManagerToolStripMenuItem"
		Me.AccountManagerToolStripMenuItem.Size = New System.Drawing.Size(236, 30)
		Me.AccountManagerToolStripMenuItem.Text = "Account Manager"
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.LibraryContactInformationToolStripMenuItem, Me.FAQToolStripMenuItem1})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
		Me.HelpToolStripMenuItem.Text = "&Help"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
		Me.AboutToolStripMenuItem.Text = "&About"
		'
		'LibraryContactInformationToolStripMenuItem
		'
		Me.LibraryContactInformationToolStripMenuItem.Name = "LibraryContactInformationToolStripMenuItem"
		Me.LibraryContactInformationToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
		Me.LibraryContactInformationToolStripMenuItem.Text = "&Library Contact Information"
		'
		'FAQToolStripMenuItem1
		'
		Me.FAQToolStripMenuItem1.Name = "FAQToolStripMenuItem1"
		Me.FAQToolStripMenuItem1.Size = New System.Drawing.Size(314, 30)
		Me.FAQToolStripMenuItem1.Text = "&FAQ"
		'
		'LoginToolStripMenuItem
		'
		Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
		Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
		Me.LoginToolStripMenuItem.Text = "&Login"
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.tpWelcome)
		Me.TabControl1.Controls.Add(Me.tpLogin)
		Me.TabControl1.Controls.Add(Me.tpCreate)
		Me.TabControl1.Controls.Add(Me.tpSearch)
		Me.TabControl1.Controls.Add(Me.tpReservation)
		Me.TabControl1.Controls.Add(Me.tpReservations)
		Me.TabControl1.Controls.Add(Me.tpCheckIn)
		Me.TabControl1.Controls.Add(Me.tpCheckOut)
		Me.TabControl1.Controls.Add(Me.tpAccount)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(0, 35)
		Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(1314, 643)
		Me.TabControl1.TabIndex = 1
		'
		'tpWelcome
		'
		Me.tpWelcome.Controls.Add(Me.Label5)
		Me.tpWelcome.Location = New System.Drawing.Point(4, 29)
		Me.tpWelcome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.tpWelcome.Name = "tpWelcome"
		Me.tpWelcome.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.tpWelcome.Size = New System.Drawing.Size(1306, 610)
		Me.tpWelcome.TabIndex = 2
		Me.tpWelcome.Text = "Welcome"
		Me.tpWelcome.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label5.Font = New System.Drawing.Font("Papyrus", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(12, 26)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(1029, 97)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Welcome to Library Circulation Desk"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tpLogin
		'
		Me.tpLogin.Controls.Add(Me.Label7)
		Me.tpLogin.Controls.Add(Me.btnLogin)
		Me.tpLogin.Controls.Add(Me.txtPassword)
		Me.tpLogin.Controls.Add(Me.Label2)
		Me.tpLogin.Controls.Add(Me.txtUsername)
		Me.tpLogin.Controls.Add(Me.Label1)
		Me.tpLogin.Location = New System.Drawing.Point(4, 29)
		Me.tpLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.tpLogin.Name = "tpLogin"
		Me.tpLogin.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.tpLogin.Size = New System.Drawing.Size(1306, 610)
		Me.tpLogin.TabIndex = 0
		Me.tpLogin.Text = "Login"
		Me.tpLogin.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(546, 45)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(139, 80)
		Me.Label7.TabIndex = 5
		Me.Label7.Text = "Existing Accounts:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "admin, admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pat, pat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lib, lib"
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
		'txtUsername
		'
		Me.txtUsername.Location = New System.Drawing.Point(142, 26)
		Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(346, 26)
		Me.txtUsername.TabIndex = 1
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
		'tpCreate
		'
		Me.tpCreate.Controls.Add(Me.cmbxAccountTypeAddAccount)
		Me.tpCreate.Controls.Add(Me.Label6)
		Me.tpCreate.Controls.Add(Me.btnAddAccount)
		Me.tpCreate.Controls.Add(Me.txtPasswordAddAccount)
		Me.tpCreate.Controls.Add(Me.Label3)
		Me.tpCreate.Controls.Add(Me.txtUsernameAddAccount)
		Me.tpCreate.Controls.Add(Me.Label4)
		Me.tpCreate.Location = New System.Drawing.Point(4, 29)
		Me.tpCreate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.tpCreate.Name = "tpCreate"
		Me.tpCreate.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.tpCreate.Size = New System.Drawing.Size(1306, 610)
		Me.tpCreate.TabIndex = 1
		Me.tpCreate.Text = "CreateAcct"
		Me.tpCreate.UseVisualStyleBackColor = True
		'
		'cmbxAccountTypeAddAccount
		'
		Me.cmbxAccountTypeAddAccount.FormattingEnabled = True
		Me.cmbxAccountTypeAddAccount.Location = New System.Drawing.Point(158, 137)
		Me.cmbxAccountTypeAddAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.cmbxAccountTypeAddAccount.Name = "cmbxAccountTypeAddAccount"
		Me.cmbxAccountTypeAddAccount.Size = New System.Drawing.Size(346, 28)
		Me.cmbxAccountTypeAddAccount.TabIndex = 11
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
		'txtUsernameAddAccount
		'
		Me.txtUsernameAddAccount.Location = New System.Drawing.Point(158, 37)
		Me.txtUsernameAddAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.txtUsernameAddAccount.Name = "txtUsernameAddAccount"
		Me.txtUsernameAddAccount.Size = New System.Drawing.Size(346, 26)
		Me.txtUsernameAddAccount.TabIndex = 6
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
		'tpSearch
		'
		Me.tpSearch.Controls.Add(Me.dgvSearch)
		Me.tpSearch.Controls.Add(Me.ToolStrip1)
		Me.tpSearch.Location = New System.Drawing.Point(4, 29)
		Me.tpSearch.Name = "tpSearch"
		Me.tpSearch.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
		Me.tpSearch.Size = New System.Drawing.Size(1306, 610)
		Me.tpSearch.TabIndex = 3
		Me.tpSearch.Text = "Search"
		Me.tpSearch.UseVisualStyleBackColor = True
		'
		'dgvSearch
		'
		Me.dgvSearch.AllowUserToAddRows = False
		Me.dgvSearch.AllowUserToDeleteRows = False
		Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBN, Me.Title, Me.Genre, Me.Author, Me.Publisher, Me.Status, Me.Check_Out, Me.Place_Hold})
		Me.dgvSearch.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvSearch.Location = New System.Drawing.Point(3, 36)
		Me.dgvSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.dgvSearch.Name = "dgvSearch"
		Me.dgvSearch.ReadOnly = True
		Me.dgvSearch.Size = New System.Drawing.Size(1300, 571)
		Me.dgvSearch.TabIndex = 1
		'
		'ISBN
		'
		Me.ISBN.HeaderText = "ISBN"
		Me.ISBN.Name = "ISBN"
		Me.ISBN.ReadOnly = True
		'
		'Title
		'
		Me.Title.HeaderText = "Title"
		Me.Title.Name = "Title"
		Me.Title.ReadOnly = True
		'
		'Genre
		'
		Me.Genre.HeaderText = "Genre"
		Me.Genre.Name = "Genre"
		Me.Genre.ReadOnly = True
		'
		'Author
		'
		Me.Author.HeaderText = "Author"
		Me.Author.Name = "Author"
		Me.Author.ReadOnly = True
		'
		'Publisher
		'
		Me.Publisher.HeaderText = "Publisher"
		Me.Publisher.Name = "Publisher"
		Me.Publisher.ReadOnly = True
		'
		'Status
		'
		Me.Status.HeaderText = "Status"
		Me.Status.Name = "Status"
		Me.Status.ReadOnly = True
		'
		'Check_Out
		'
		Me.Check_Out.HeaderText = "Check Out"
		Me.Check_Out.Name = "Check_Out"
		Me.Check_Out.ReadOnly = True
		'
		'Place_Hold
		'
		Me.Place_Hold.HeaderText = "Place Hold"
		Me.Place_Hold.Name = "Place_Hold"
		Me.Place_Hold.ReadOnly = True
		'
		'ToolStrip1
		'
		Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtSearchISBN, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.txtSearchTitle, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.cmbxSearchGenre, Me.ToolStripSeparator3, Me.ToolStripLabel4, Me.cmbxSearchStatus, Me.ToolStripSeparator9, Me.btnSearchSearch, Me.ToolStripSeparator8, Me.btnSearchClear})
		Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
		Me.ToolStrip1.Size = New System.Drawing.Size(1300, 33)
		Me.ToolStrip1.TabIndex = 0
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(54, 30)
		Me.ToolStripLabel1.Text = "ISBN:"
		'
		'txtSearchISBN
		'
		Me.txtSearchISBN.Name = "txtSearchISBN"
		Me.txtSearchISBN.Size = New System.Drawing.Size(148, 33)
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
		'
		'ToolStripLabel2
		'
		Me.ToolStripLabel2.Name = "ToolStripLabel2"
		Me.ToolStripLabel2.Size = New System.Drawing.Size(48, 30)
		Me.ToolStripLabel2.Text = "Title:"
		'
		'txtSearchTitle
		'
		Me.txtSearchTitle.Name = "txtSearchTitle"
		Me.txtSearchTitle.Size = New System.Drawing.Size(148, 33)
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
		'
		'ToolStripLabel3
		'
		Me.ToolStripLabel3.Name = "ToolStripLabel3"
		Me.ToolStripLabel3.Size = New System.Drawing.Size(62, 30)
		Me.ToolStripLabel3.Text = "Genre:"
		'
		'cmbxSearchGenre
		'
		Me.cmbxSearchGenre.Name = "cmbxSearchGenre"
		Me.cmbxSearchGenre.Size = New System.Drawing.Size(180, 33)
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
		'
		'ToolStripLabel4
		'
		Me.ToolStripLabel4.Name = "ToolStripLabel4"
		Me.ToolStripLabel4.Size = New System.Drawing.Size(64, 30)
		Me.ToolStripLabel4.Text = "Status:"
		'
		'cmbxSearchStatus
		'
		Me.cmbxSearchStatus.Items.AddRange(New Object() {"Available", "Held", "Reserved"})
		Me.cmbxSearchStatus.Name = "cmbxSearchStatus"
		Me.cmbxSearchStatus.Size = New System.Drawing.Size(180, 33)
		'
		'ToolStripSeparator9
		'
		Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
		Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 33)
		'
		'btnSearchSearch
		'
		Me.btnSearchSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.btnSearchSearch.Image = CType(resources.GetObject("btnSearchSearch.Image"), System.Drawing.Image)
		Me.btnSearchSearch.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnSearchSearch.Name = "btnSearchSearch"
		Me.btnSearchSearch.Size = New System.Drawing.Size(68, 30)
		Me.btnSearchSearch.Text = "Search"
		'
		'ToolStripSeparator8
		'
		Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
		Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 33)
		'
		'btnSearchClear
		'
		Me.btnSearchClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.btnSearchClear.Image = CType(resources.GetObject("btnSearchClear.Image"), System.Drawing.Image)
		Me.btnSearchClear.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnSearchClear.Name = "btnSearchClear"
		Me.btnSearchClear.Size = New System.Drawing.Size(55, 30)
		Me.btnSearchClear.Text = "Clear"
		'
		'tpReservation
		'
		Me.tpReservation.Location = New System.Drawing.Point(4, 29)
		Me.tpReservation.Name = "tpReservation"
		Me.tpReservation.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
		Me.tpReservation.Size = New System.Drawing.Size(1306, 610)
		Me.tpReservation.TabIndex = 4
		Me.tpReservation.Text = "Reservation"
		Me.tpReservation.UseVisualStyleBackColor = True
		'
		'tpReservations
		'
		Me.tpReservations.Location = New System.Drawing.Point(4, 29)
		Me.tpReservations.Name = "tpReservations"
		Me.tpReservations.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
		Me.tpReservations.Size = New System.Drawing.Size(1306, 610)
		Me.tpReservations.TabIndex = 6
		Me.tpReservations.Text = "Reservations"
		Me.tpReservations.UseVisualStyleBackColor = True
		'
		'tpCheckIn
		'
		Me.tpCheckIn.Location = New System.Drawing.Point(4, 29)
		Me.tpCheckIn.Name = "tpCheckIn"
		Me.tpCheckIn.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
		Me.tpCheckIn.Size = New System.Drawing.Size(1306, 610)
		Me.tpCheckIn.TabIndex = 8
		Me.tpCheckIn.Text = "Check In"
		Me.tpCheckIn.UseVisualStyleBackColor = True
		'
		'tpAccount
		'
		Me.tpAccount.Location = New System.Drawing.Point(4, 29)
		Me.tpAccount.Name = "tpAccount"
		Me.tpAccount.Size = New System.Drawing.Size(1306, 610)
		Me.tpAccount.TabIndex = 9
		Me.tpAccount.Text = "Account"
		Me.tpAccount.UseVisualStyleBackColor = True
		'
		'errProvider
		'
		Me.errProvider.ContainerControl = Me
		'
		'CheckInToolStripMenuItem
		'
		Me.CheckInToolStripMenuItem.Name = "CheckInToolStripMenuItem"
		Me.CheckInToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
		Me.CheckInToolStripMenuItem.Text = "Check In"
		'
		'tpCheckOut
		'
		Me.tpCheckOut.Location = New System.Drawing.Point(4, 29)
		Me.tpCheckOut.Name = "tpCheckOut"
		Me.tpCheckOut.Size = New System.Drawing.Size(1306, 610)
		Me.tpCheckOut.TabIndex = 10
		Me.tpCheckOut.Text = "Check Out"
		Me.tpCheckOut.UseVisualStyleBackColor = True
		'
		'formMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1314, 678)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "formMain"
		Me.Text = "Library Circulation Desk"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.TabControl1.ResumeLayout(False)
		Me.tpWelcome.ResumeLayout(False)
		Me.tpLogin.ResumeLayout(False)
		Me.tpLogin.PerformLayout()
		Me.tpCreate.ResumeLayout(False)
		Me.tpCreate.PerformLayout()
		Me.tpSearch.ResumeLayout(False)
		Me.tpSearch.PerformLayout()
		CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpLogin As TabPage
    Friend WithEvents PatronToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CirculationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tpCreate As TabPage
    Friend WithEvents btnAddAccount As Button
    Friend WithEvents txtPasswordAddAccount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsernameAddAccount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AddNewAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tpWelcome As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbxAccountTypeAddAccount As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tpSearch As TabPage
    Friend WithEvents tpReservation As TabPage
	Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ReservationsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CheckInOutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PaymentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CatalogeManagerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AccountManagerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents tpReservations As TabPage
	Friend WithEvents tpCheckIn As TabPage
	Friend WithEvents tpAccount As TabPage
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
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LibraryContactInformationToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
	Friend WithEvents FAQToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents btnSearchClear As ToolStripButton
	Friend WithEvents ISBN As DataGridViewTextBoxColumn
	Friend WithEvents Title As DataGridViewTextBoxColumn
	Friend WithEvents Genre As DataGridViewTextBoxColumn
	Friend WithEvents Author As DataGridViewTextBoxColumn
	Friend WithEvents Publisher As DataGridViewTextBoxColumn
	Friend WithEvents Status As DataGridViewTextBoxColumn
	Friend WithEvents Check_Out As DataGridViewButtonColumn
	Friend WithEvents Place_Hold As DataGridViewButtonColumn
	Friend WithEvents Label7 As Label
	Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
	Friend WithEvents btnSearchSearch As ToolStripButton
	Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
	Friend WithEvents CheckInToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents tpCheckOut As TabPage
End Class
