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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.PatronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CirculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.tpCreate = New System.Windows.Forms.TabPage()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.txtPasswordAddAccount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsernameAddAccount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddNewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpWelcome = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmboxAccountTypeAddAccount = New System.Windows.Forms.ComboBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpLogin.SuspendLayout()
        Me.tpCreate.SuspendLayout()
        Me.tpWelcome.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatronToolStripMenuItem, Me.CirculationToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(710, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpWelcome)
        Me.TabControl1.Controls.Add(Me.tpLogin)
        Me.TabControl1.Controls.Add(Me.tpCreate)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(710, 294)
        Me.TabControl1.TabIndex = 1
        '
        'tpLogin
        '
        Me.tpLogin.Controls.Add(Me.btnLogin)
        Me.tpLogin.Controls.Add(Me.txtPassword)
        Me.tpLogin.Controls.Add(Me.Label2)
        Me.tpLogin.Controls.Add(Me.txtUsername)
        Me.tpLogin.Controls.Add(Me.Label1)
        Me.tpLogin.Location = New System.Drawing.Point(4, 22)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLogin.Size = New System.Drawing.Size(702, 268)
        Me.tpLogin.TabIndex = 0
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'PatronToolStripMenuItem
        '
        Me.PatronToolStripMenuItem.Name = "PatronToolStripMenuItem"
        Me.PatronToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.PatronToolStripMenuItem.Text = "&Patron"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdministrationToolStripMenuItem.Text = "&Administration"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'CirculationToolStripMenuItem
        '
        Me.CirculationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewAccountToolStripMenuItem})
        Me.CirculationToolStripMenuItem.Name = "CirculationToolStripMenuItem"
        Me.CirculationToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.CirculationToolStripMenuItem.Text = "&Circulation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(95, 17)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(232, 20)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(95, 48)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(232, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(95, 82)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
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
        Me.tpCreate.Location = New System.Drawing.Point(4, 22)
        Me.tpCreate.Name = "tpCreate"
        Me.tpCreate.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCreate.Size = New System.Drawing.Size(702, 268)
        Me.tpCreate.TabIndex = 1
        Me.tpCreate.Text = "CreateAcct"
        Me.tpCreate.UseVisualStyleBackColor = True
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'txtUsernameAddAccount
        '
        Me.txtUsernameAddAccount.Location = New System.Drawing.Point(105, 24)
        Me.txtUsernameAddAccount.Name = "txtUsernameAddAccount"
        Me.txtUsernameAddAccount.Size = New System.Drawing.Size(232, 20)
        Me.txtUsernameAddAccount.TabIndex = 6
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
        'AddNewAccountToolStripMenuItem
        '
        Me.AddNewAccountToolStripMenuItem.Name = "AddNewAccountToolStripMenuItem"
        Me.AddNewAccountToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddNewAccountToolStripMenuItem.Text = "&Add New Account"
        '
        'tpWelcome
        '
        Me.tpWelcome.Controls.Add(Me.Label5)
        Me.tpWelcome.Location = New System.Drawing.Point(4, 22)
        Me.tpWelcome.Name = "tpWelcome"
        Me.tpWelcome.Padding = New System.Windows.Forms.Padding(3)
        Me.tpWelcome.Size = New System.Drawing.Size(702, 268)
        Me.tpWelcome.TabIndex = 2
        Me.tpWelcome.Text = "Welcome"
        Me.tpWelcome.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Papyrus", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(686, 63)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Welcome to Library Circulation Desk"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'cmboxAccountTypeAddAccount
        '
        Me.cmboxAccountTypeAddAccount.FormattingEnabled = True
        Me.cmboxAccountTypeAddAccount.Location = New System.Drawing.Point(105, 89)
        Me.cmboxAccountTypeAddAccount.Name = "cmboxAccountTypeAddAccount"
        Me.cmboxAccountTypeAddAccount.Size = New System.Drawing.Size(232, 21)
        Me.cmboxAccountTypeAddAccount.TabIndex = 11
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 318)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMain"
        Me.Text = "Library Circulation Desk"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpLogin.ResumeLayout(False)
        Me.tpLogin.PerformLayout()
        Me.tpCreate.ResumeLayout(False)
        Me.tpCreate.PerformLayout()
        Me.tpWelcome.ResumeLayout(False)
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
End Class
