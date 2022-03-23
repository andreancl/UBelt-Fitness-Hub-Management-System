<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tpAccount = New System.Windows.Forms.TabPage()
        Me.tcAccountSettings = New System.Windows.Forms.TabControl()
        Me.tpAccountDetails = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBIS = New System.Windows.Forms.Label()
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.rdouser = New System.Windows.Forms.RadioButton()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.rdoadmin = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContactNum = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvUserRecords = New System.Windows.Forms.DataGridView()
        Me.tcSettings = New System.Windows.Forms.TabControl()
        Me.tpBaR = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbBr = New System.Windows.Forms.GroupBox()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.lblResRec = New System.Windows.Forms.Label()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.tpAccount.SuspendLayout()
        Me.tcAccountSettings.SuspendLayout()
        Me.tpAccountDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbUser.SuspendLayout()
        CType(Me.dgvUserRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcSettings.SuspendLayout()
        Me.tpBaR.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gbBr.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpAccount
        '
        Me.tpAccount.BackColor = System.Drawing.SystemColors.Control
        Me.tpAccount.Controls.Add(Me.tcAccountSettings)
        Me.tpAccount.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpAccount.Location = New System.Drawing.Point(4, 32)
        Me.tpAccount.Name = "tpAccount"
        Me.tpAccount.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAccount.Size = New System.Drawing.Size(943, 482)
        Me.tpAccount.TabIndex = 0
        Me.tpAccount.Text = "ACCOUNT"
        '
        'tcAccountSettings
        '
        Me.tcAccountSettings.Controls.Add(Me.tpAccountDetails)
        Me.tcAccountSettings.Location = New System.Drawing.Point(0, 1)
        Me.tcAccountSettings.Name = "tcAccountSettings"
        Me.tcAccountSettings.SelectedIndex = 0
        Me.tcAccountSettings.Size = New System.Drawing.Size(943, 481)
        Me.tcAccountSettings.TabIndex = 16
        '
        'tpAccountDetails
        '
        Me.tpAccountDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.tpAccountDetails.Controls.Add(Me.Panel2)
        Me.tpAccountDetails.Controls.Add(Me.Panel1)
        Me.tpAccountDetails.Controls.Add(Me.gbUser)
        Me.tpAccountDetails.Controls.Add(Me.dgvUserRecords)
        Me.tpAccountDetails.Location = New System.Drawing.Point(4, 32)
        Me.tpAccountDetails.Name = "tpAccountDetails"
        Me.tpAccountDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAccountDetails.Size = New System.Drawing.Size(935, 445)
        Me.tpAccountDetails.TabIndex = 0
        Me.tpAccountDetails.Text = "Account Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(483, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(456, 77)
        Me.Panel2.TabIndex = 89
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(287, 42)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "ACCOUNT DETAILS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblUserId)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblBIS)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 77)
        Me.Panel1.TabIndex = 88
        '
        'lblUserId
        '
        Me.lblUserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUserId.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.Location = New System.Drawing.Point(315, 50)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(100, 25)
        Me.lblUserId.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Please fill in this form to create an account."
        '
        'lblBIS
        '
        Me.lblBIS.AutoSize = True
        Me.lblBIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBIS.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBIS.Location = New System.Drawing.Point(0, 8)
        Me.lblBIS.Name = "lblBIS"
        Me.lblBIS.Size = New System.Drawing.Size(379, 42)
        Me.lblBIS.TabIndex = 1
        Me.lblBIS.Text = "CREATE ACCOUNT FORM"
        '
        'gbUser
        '
        Me.gbUser.Controls.Add(Me.rdoFemale)
        Me.gbUser.Controls.Add(Me.btnCreate)
        Me.gbUser.Controls.Add(Me.rdoMale)
        Me.gbUser.Controls.Add(Me.rdouser)
        Me.gbUser.Controls.Add(Me.dtpBirthdate)
        Me.gbUser.Controls.Add(Me.rdoadmin)
        Me.gbUser.Controls.Add(Me.Label4)
        Me.gbUser.Controls.Add(Me.Label11)
        Me.gbUser.Controls.Add(Me.txtContactNum)
        Me.gbUser.Controls.Add(Me.txtPassword)
        Me.gbUser.Controls.Add(Me.txtFullName)
        Me.gbUser.Controls.Add(Me.txtUsername)
        Me.gbUser.Controls.Add(Me.Label14)
        Me.gbUser.Controls.Add(Me.Label3)
        Me.gbUser.Controls.Add(Me.Label15)
        Me.gbUser.Controls.Add(Me.txtAddress)
        Me.gbUser.Controls.Add(Me.Label1)
        Me.gbUser.Controls.Add(Me.Label10)
        Me.gbUser.Controls.Add(Me.Label12)
        Me.gbUser.Location = New System.Drawing.Point(20, 83)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Size = New System.Drawing.Size(439, 355)
        Me.gbUser.TabIndex = 87
        Me.gbUser.TabStop = False
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFemale.ForeColor = System.Drawing.Color.White
        Me.rdoFemale.Location = New System.Drawing.Point(242, 60)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(74, 23)
        Me.rdoFemale.TabIndex = 111
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.Location = New System.Drawing.Point(130, 301)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(186, 39)
        Me.btnCreate.TabIndex = 55
        Me.btnCreate.Text = "  Create Account"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMale.ForeColor = System.Drawing.Color.White
        Me.rdoMale.Location = New System.Drawing.Point(176, 60)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(60, 23)
        Me.rdoMale.TabIndex = 110
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'rdouser
        '
        Me.rdouser.AutoSize = True
        Me.rdouser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdouser.ForeColor = System.Drawing.Color.White
        Me.rdouser.Location = New System.Drawing.Point(251, 263)
        Me.rdouser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdouser.Name = "rdouser"
        Me.rdouser.Size = New System.Drawing.Size(57, 23)
        Me.rdouser.TabIndex = 108
        Me.rdouser.TabStop = True
        Me.rdouser.Text = "User"
        Me.rdouser.UseVisualStyleBackColor = True
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.CustomFormat = "yyyy-MM-dd"
        Me.dtpBirthdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthdate.Location = New System.Drawing.Point(173, 92)
        Me.dtpBirthdate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(221, 27)
        Me.dtpBirthdate.TabIndex = 102
        Me.dtpBirthdate.Value = New Date(2021, 10, 16, 0, 0, 0, 0)
        '
        'rdoadmin
        '
        Me.rdoadmin.AutoSize = True
        Me.rdoadmin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoadmin.ForeColor = System.Drawing.Color.White
        Me.rdoadmin.Location = New System.Drawing.Point(176, 263)
        Me.rdoadmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoadmin.Name = "rdoadmin"
        Me.rdoadmin.Size = New System.Drawing.Size(68, 23)
        Me.rdoadmin.TabIndex = 109
        Me.rdoadmin.TabStop = True
        Me.rdoadmin.Text = "Admin"
        Me.rdoadmin.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(47, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Full Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(47, 161)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 25)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Address"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactNum
        '
        Me.txtContactNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNum.Location = New System.Drawing.Point(173, 127)
        Me.txtContactNum.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(221, 27)
        Me.txtContactNum.TabIndex = 103
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(173, 226)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(221, 27)
        Me.txtPassword.TabIndex = 106
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(173, 26)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(221, 27)
        Me.txtFullName.TabIndex = 31
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(173, 193)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(221, 27)
        Me.txtUsername.TabIndex = 105
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(47, 93)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 25)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Birthdate"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 227)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(47, 60)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 25)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Sex"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(173, 160)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(221, 27)
        Me.txtAddress.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 194)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(47, 128)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 25)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Contact No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(48, 261)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 25)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "User Type"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvUserRecords
        '
        Me.dgvUserRecords.AllowUserToAddRows = False
        Me.dgvUserRecords.AllowUserToDeleteRows = False
        Me.dgvUserRecords.AllowUserToResizeColumns = False
        Me.dgvUserRecords.AllowUserToResizeRows = False
        Me.dgvUserRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUserRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUserRecords.BackgroundColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvUserRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserRecords.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUserRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUserRecords.Location = New System.Drawing.Point(486, 95)
        Me.dgvUserRecords.Name = "dgvUserRecords"
        Me.dgvUserRecords.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvUserRecords.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvUserRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserRecords.Size = New System.Drawing.Size(439, 343)
        Me.dgvUserRecords.StandardTab = True
        Me.dgvUserRecords.TabIndex = 86
        '
        'tcSettings
        '
        Me.tcSettings.Controls.Add(Me.tpAccount)
        Me.tcSettings.Controls.Add(Me.tpBaR)
        Me.tcSettings.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcSettings.Location = New System.Drawing.Point(108, 101)
        Me.tcSettings.Name = "tcSettings"
        Me.tcSettings.SelectedIndex = 0
        Me.tcSettings.Size = New System.Drawing.Size(951, 518)
        Me.tcSettings.TabIndex = 109
        '
        'tpBaR
        '
        Me.tpBaR.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.tpBaR.Controls.Add(Me.Panel3)
        Me.tpBaR.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpBaR.Location = New System.Drawing.Point(4, 32)
        Me.tpBaR.Name = "tpBaR"
        Me.tpBaR.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBaR.Size = New System.Drawing.Size(943, 482)
        Me.tpBaR.TabIndex = 1
        Me.tpBaR.Text = "BACKUP AND RESTORE"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.gbBr)
        Me.Panel3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Panel3.Location = New System.Drawing.Point(234, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(475, 364)
        Me.Panel3.TabIndex = 84
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(475, 77)
        Me.Panel4.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(3, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BACKUP && RESTORE"
        '
        'gbBr
        '
        Me.gbBr.Controls.Add(Me.btnRestore)
        Me.gbBr.Controls.Add(Me.btnBackup)
        Me.gbBr.Location = New System.Drawing.Point(25, 97)
        Me.gbBr.Name = "gbBr"
        Me.gbBr.Size = New System.Drawing.Size(414, 215)
        Me.gbBr.TabIndex = 67
        Me.gbBr.TabStop = False
        '
        'btnRestore
        '
        Me.btnRestore.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.Location = New System.Drawing.Point(113, 121)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(189, 47)
        Me.btnRestore.TabIndex = 106
        Me.btnRestore.Text = "RESTORE"
        Me.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Location = New System.Drawing.Point(113, 44)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(189, 47)
        Me.btnBackup.TabIndex = 105
        Me.btnBackup.Text = "BACKUP"
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'lblResRec
        '
        Me.lblResRec.AutoSize = True
        Me.lblResRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResRec.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResRec.Location = New System.Drawing.Point(48, 17)
        Me.lblResRec.Name = "lblResRec"
        Me.lblResRec.Size = New System.Drawing.Size(166, 45)
        Me.lblResRec.TabIndex = 108
        Me.lblResRec.Text = "SETTINGS"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 54)
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(104, 6)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.tcSettings)
        Me.Controls.Add(Me.lblResRec)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tpAccount.ResumeLayout(False)
        Me.tcAccountSettings.ResumeLayout(False)
        Me.tpAccountDetails.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbUser.ResumeLayout(False)
        Me.gbUser.PerformLayout()
        CType(Me.dgvUserRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcSettings.ResumeLayout(False)
        Me.tpBaR.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.gbBr.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tpAccount As System.Windows.Forms.TabPage
    Friend WithEvents tcSettings As System.Windows.Forms.TabControl
    Friend WithEvents tpBaR As System.Windows.Forms.TabPage
    Friend WithEvents lblResRec As System.Windows.Forms.Label
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tcAccountSettings As System.Windows.Forms.TabControl
    Friend WithEvents tpAccountDetails As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblUserId As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBIS As System.Windows.Forms.Label
    Friend WithEvents gbUser As System.Windows.Forms.GroupBox
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdouser As System.Windows.Forms.RadioButton
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdoadmin As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtContactNum As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgvUserRecords As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbBr As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
