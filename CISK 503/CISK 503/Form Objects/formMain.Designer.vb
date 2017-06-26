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
		Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CirculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddNewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CheckInOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CatalogeManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AccountManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FAQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.tpWelcome = New System.Windows.Forms.TabPage()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.tpLogin = New System.Windows.Forms.TabPage()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.tpCreate = New System.Windows.Forms.TabPage()
		Me.cmboxAccountTypeAddAccount = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnAddAccount = New System.Windows.Forms.Button()
		Me.txtPasswordAddAccount = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtUsernameAddAccount = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.tpSearch = New System.Windows.Forms.TabPage()
		Me.tpReservation = New System.Windows.Forms.TabPage()
		Me.tpRequest = New System.Windows.Forms.TabPage()
		Me.tpReservations = New System.Windows.Forms.TabPage()
		Me.tpRequests = New System.Windows.Forms.TabPage()
		Me.tpCheckInOut = New System.Windows.Forms.TabPage()
		Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.tpAccount = New System.Windows.Forms.TabPage()
		Me.MenuStrip1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.tpWelcome.SuspendLayout()
		Me.tpLogin.SuspendLayout()
		Me.tpCreate.SuspendLayout()
		CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.PatronToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ReservationToolStripMenuItem, Me.RequestToolStripMenuItem, Me.AccountToolStripMenuItem})
		Me.PatronToolStripMenuItem.Name = "PatronToolStripMenuItem"
		Me.PatronToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
		Me.PatronToolStripMenuItem.Text = "&Patron"
		'
		'SearchToolStripMenuItem
		'
		Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
		Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
		Me.SearchToolStripMenuItem.Text = "Search"
		'
		'ReservationToolStripMenuItem
		'
		Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
		Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
		Me.ReservationToolStripMenuItem.Text = "Reservation"
		'
		'RequestToolStripMenuItem
		'
		Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
		Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
		Me.RequestToolStripMenuItem.Text = "Request"
		'
		'AccountToolStripMenuItem
		'
		Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
		Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
		Me.AccountToolStripMenuItem.Text = "Account"
		'
		'CirculationToolStripMenuItem
		'
		Me.CirculationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewAccountToolStripMenuItem, Me.ReservationsToolStripMenuItem, Me.RequestsToolStripMenuItem, Me.CheckInOutToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.PaymentsToolStripMenuItem})
		Me.CirculationToolStripMenuItem.Name = "CirculationToolStripMenuItem"
		Me.CirculationToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
		Me.CirculationToolStripMenuItem.Text = "&Circulation"
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
		Me.ReservationsToolStripMenuItem.Text = "Reservations"
		'
		'RequestsToolStripMenuItem
		'
		Me.RequestsToolStripMenuItem.Name = "RequestsToolStripMenuItem"
		Me.RequestsToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
		Me.RequestsToolStripMenuItem.Text = "Requests"
		'
		'CheckInOutToolStripMenuItem
		'
		Me.CheckInOutToolStripMenuItem.Name = "CheckInOutToolStripMenuItem"
		Me.CheckInOutToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
		Me.CheckInOutToolStripMenuItem.Text = "Check In / Out"
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
		Me.CatalogeManagerToolStripMenuItem.Size = New System.Drawing.Size(241, 30)
		Me.CatalogeManagerToolStripMenuItem.Text = "Cataloge Manager"
		'
		'AccountManagerToolStripMenuItem
		'
		Me.AccountManagerToolStripMenuItem.Name = "AccountManagerToolStripMenuItem"
		Me.AccountManagerToolStripMenuItem.Size = New System.Drawing.Size(241, 30)
		Me.AccountManagerToolStripMenuItem.Text = "Account Manager"
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
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.tpWelcome)
		Me.TabControl1.Controls.Add(Me.tpLogin)
		Me.TabControl1.Controls.Add(Me.tpCreate)
		Me.TabControl1.Controls.Add(Me.tpSearch)
		Me.TabControl1.Controls.Add(Me.tpReservation)
		Me.TabControl1.Controls.Add(Me.tpRequest)
		Me.TabControl1.Controls.Add(Me.tpReservations)
		Me.TabControl1.Controls.Add(Me.tpRequests)
		Me.TabControl1.Controls.Add(Me.tpCheckInOut)
		Me.TabControl1.Controls.Add(Me.tpAccount)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(0, 35)
		Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(1065, 454)
		Me.TabControl1.TabIndex = 1
		'
		'tpWelcome
		'
		Me.tpWelcome.Controls.Add(Me.Label5)
		Me.tpWelcome.Location = New System.Drawing.Point(4, 29)
		Me.tpWelcome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.tpWelcome.Name = "tpWelcome"
		Me.tpWelcome.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.tpWelcome.Size = New System.Drawing.Size(1057, 421)
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
		Me.tpLogin.Controls.Add(Me.btnLogin)
		Me.tpLogin.Controls.Add(Me.txtPassword)
		Me.tpLogin.Controls.Add(Me.Label2)
		Me.tpLogin.Controls.Add(Me.txtUsername)
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
		Me.tpCreate.Controls.Add(Me.cmboxAccountTypeAddAccount)
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
		Me.tpSearch.Location = New System.Drawing.Point(4, 29)
		Me.tpSearch.Name = "tpSearch"
		Me.tpSearch.Padding = New System.Windows.Forms.Padding(3)
		Me.tpSearch.Size = New System.Drawing.Size(1057, 421)
		Me.tpSearch.TabIndex = 3
		Me.tpSearch.Text = "Search"
		Me.tpSearch.UseVisualStyleBackColor = True
		'
		'tpReservation
		'
		Me.tpReservation.Location = New System.Drawing.Point(4, 29)
		Me.tpReservation.Name = "tpReservation"
		Me.tpReservation.Padding = New System.Windows.Forms.Padding(3)
		Me.tpReservation.Size = New System.Drawing.Size(1057, 421)
		Me.tpReservation.TabIndex = 4
		Me.tpReservation.Text = "Reservation"
		Me.tpReservation.UseVisualStyleBackColor = True
		'
		'tpRequest
		'
		Me.tpRequest.Location = New System.Drawing.Point(4, 29)
		Me.tpRequest.Name = "tpRequest"
		Me.tpRequest.Padding = New System.Windows.Forms.Padding(3)
		Me.tpRequest.Size = New System.Drawing.Size(1057, 421)
		Me.tpRequest.TabIndex = 5
		Me.tpRequest.Text = "Request"
		Me.tpRequest.UseVisualStyleBackColor = True
		'
		'tpReservations
		'
		Me.tpReservations.Location = New System.Drawing.Point(4, 29)
		Me.tpReservations.Name = "tpReservations"
		Me.tpReservations.Padding = New System.Windows.Forms.Padding(3)
		Me.tpReservations.Size = New System.Drawing.Size(1057, 421)
		Me.tpReservations.TabIndex = 6
		Me.tpReservations.Text = "Reservations"
		Me.tpReservations.UseVisualStyleBackColor = True
		'
		'tpRequests
		'
		Me.tpRequests.Location = New System.Drawing.Point(4, 29)
		Me.tpRequests.Name = "tpRequests"
		Me.tpRequests.Padding = New System.Windows.Forms.Padding(3)
		Me.tpRequests.Size = New System.Drawing.Size(1057, 421)
		Me.tpRequests.TabIndex = 7
		Me.tpRequests.Text = "Requests"
		Me.tpRequests.UseVisualStyleBackColor = True
		'
		'tpCheckInOut
		'
		Me.tpCheckInOut.Location = New System.Drawing.Point(4, 29)
		Me.tpCheckInOut.Name = "tpCheckInOut"
		Me.tpCheckInOut.Padding = New System.Windows.Forms.Padding(3)
		Me.tpCheckInOut.Size = New System.Drawing.Size(1057, 421)
		Me.tpCheckInOut.TabIndex = 8
		Me.tpCheckInOut.Text = "Check In/Out"
		Me.tpCheckInOut.UseVisualStyleBackColor = True
		'
		'errProvider
		'
		Me.errProvider.ContainerControl = Me
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
		Me.TabControl1.ResumeLayout(False)
		Me.tpWelcome.ResumeLayout(False)
		Me.tpLogin.ResumeLayout(False)
		Me.tpLogin.PerformLayout()
		Me.tpCreate.ResumeLayout(False)
		Me.tpCreate.PerformLayout()
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
    Friend WithEvents cmboxAccountTypeAddAccount As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents errProvider As ErrorProvider
	Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ReservationToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FAQToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents tpSearch As TabPage
	Friend WithEvents tpReservation As TabPage
	Friend WithEvents tpRequest As TabPage
	Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ReservationsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RequestsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CheckInOutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PaymentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CatalogeManagerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AccountManagerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents tpReservations As TabPage
	Friend WithEvents tpRequests As TabPage
	Friend WithEvents tpCheckInOut As TabPage
	Friend WithEvents tpAccount As TabPage
End Class
