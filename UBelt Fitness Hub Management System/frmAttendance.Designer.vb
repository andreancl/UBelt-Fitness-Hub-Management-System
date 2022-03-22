<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblResRec = New System.Windows.Forms.Label()
        Me.tcMembership = New System.Windows.Forms.TabControl()
        Me.tpDaily = New System.Windows.Forms.TabPage()
        Me.gbDaily = New System.Windows.Forms.GroupBox()
        Me.btnDFind = New System.Windows.Forms.Button()
        Me.btnDTimeOut = New System.Windows.Forms.Button()
        Me.btnDTimeIn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDailyMemberId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDailyFullName = New System.Windows.Forms.TextBox()
        Me.dgvDailyMembersRecord = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDailySearchBox = New System.Windows.Forms.TextBox()
        Me.tpMonthly = New System.Windows.Forms.TabPage()
        Me.gbMonthly = New System.Windows.Forms.GroupBox()
        Me.btnMFind = New System.Windows.Forms.Button()
        Me.btnMTimeOut = New System.Windows.Forms.Button()
        Me.btnMTimeIn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonthlyMemberId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMonthlyFullName = New System.Windows.Forms.TextBox()
        Me.dgvMonthlyMembersRecord = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonthlySearchBox = New System.Windows.Forms.TextBox()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tcMembership.SuspendLayout()
        Me.tpDaily.SuspendLayout()
        Me.gbDaily.SuspendLayout()
        CType(Me.dgvDailyMembersRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMonthly.SuspendLayout()
        Me.gbMonthly.SuspendLayout()
        CType(Me.dgvMonthlyMembersRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResRec
        '
        Me.lblResRec.AutoSize = True
        Me.lblResRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResRec.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResRec.Location = New System.Drawing.Point(19, 11)
        Me.lblResRec.Name = "lblResRec"
        Me.lblResRec.Size = New System.Drawing.Size(390, 45)
        Me.lblResRec.TabIndex = 16
        Me.lblResRec.Text = "MEMBERS ATTENDANCE"
        '
        'tcMembership
        '
        Me.tcMembership.Controls.Add(Me.tpDaily)
        Me.tcMembership.Controls.Add(Me.tpMonthly)
        Me.tcMembership.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcMembership.Location = New System.Drawing.Point(79, 95)
        Me.tcMembership.Name = "tcMembership"
        Me.tcMembership.SelectedIndex = 0
        Me.tcMembership.Size = New System.Drawing.Size(951, 518)
        Me.tcMembership.TabIndex = 17
        '
        'tpDaily
        '
        Me.tpDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.tpDaily.Controls.Add(Me.gbDaily)
        Me.tpDaily.Controls.Add(Me.dgvDailyMembersRecord)
        Me.tpDaily.Controls.Add(Me.Label1)
        Me.tpDaily.Controls.Add(Me.txtDailySearchBox)
        Me.tpDaily.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpDaily.Location = New System.Drawing.Point(4, 32)
        Me.tpDaily.Name = "tpDaily"
        Me.tpDaily.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDaily.Size = New System.Drawing.Size(943, 482)
        Me.tpDaily.TabIndex = 0
        Me.tpDaily.Text = "DAILY"
        '
        'gbDaily
        '
        Me.gbDaily.Controls.Add(Me.btnDFind)
        Me.gbDaily.Controls.Add(Me.btnDTimeOut)
        Me.gbDaily.Controls.Add(Me.btnDTimeIn)
        Me.gbDaily.Controls.Add(Me.Label3)
        Me.gbDaily.Controls.Add(Me.txtDailyMemberId)
        Me.gbDaily.Controls.Add(Me.Label4)
        Me.gbDaily.Controls.Add(Me.txtDailyFullName)
        Me.gbDaily.Location = New System.Drawing.Point(24, 68)
        Me.gbDaily.Name = "gbDaily"
        Me.gbDaily.Size = New System.Drawing.Size(355, 263)
        Me.gbDaily.TabIndex = 90
        Me.gbDaily.TabStop = False
        '
        'btnDFind
        '
        Me.btnDFind.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDFind.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnDFind.ForeColor = System.Drawing.Color.White
        Me.btnDFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDFind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDFind.Location = New System.Drawing.Point(248, 67)
        Me.btnDFind.Name = "btnDFind"
        Me.btnDFind.Size = New System.Drawing.Size(79, 27)
        Me.btnDFind.TabIndex = 89
        Me.btnDFind.Text = "FIND"
        Me.btnDFind.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDFind.UseVisualStyleBackColor = True
        '
        'btnDTimeOut
        '
        Me.btnDTimeOut.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDTimeOut.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDTimeOut.ForeColor = System.Drawing.Color.White
        Me.btnDTimeOut.Location = New System.Drawing.Point(172, 196)
        Me.btnDTimeOut.Name = "btnDTimeOut"
        Me.btnDTimeOut.Size = New System.Drawing.Size(104, 39)
        Me.btnDTimeOut.TabIndex = 88
        Me.btnDTimeOut.Text = "Time Out"
        Me.btnDTimeOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDTimeOut.UseVisualStyleBackColor = True
        '
        'btnDTimeIn
        '
        Me.btnDTimeIn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDTimeIn.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDTimeIn.ForeColor = System.Drawing.Color.White
        Me.btnDTimeIn.Location = New System.Drawing.Point(60, 196)
        Me.btnDTimeIn.Name = "btnDTimeIn"
        Me.btnDTimeIn.Size = New System.Drawing.Size(93, 39)
        Me.btnDTimeIn.TabIndex = 87
        Me.btnDTimeIn.Text = "Time In"
        Me.btnDTimeIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDTimeIn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(23, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 26)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Member Id"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDailyMemberId
        '
        Me.txtDailyMemberId.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtDailyMemberId.Location = New System.Drawing.Point(22, 67)
        Me.txtDailyMemberId.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtDailyMemberId.Name = "txtDailyMemberId"
        Me.txtDailyMemberId.Size = New System.Drawing.Size(218, 27)
        Me.txtDailyMemberId.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(23, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 26)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Full Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDailyFullName
        '
        Me.txtDailyFullName.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtDailyFullName.Location = New System.Drawing.Point(22, 142)
        Me.txtDailyFullName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtDailyFullName.Name = "txtDailyFullName"
        Me.txtDailyFullName.Size = New System.Drawing.Size(287, 27)
        Me.txtDailyFullName.TabIndex = 84
        '
        'dgvDailyMembersRecord
        '
        Me.dgvDailyMembersRecord.AllowUserToAddRows = False
        Me.dgvDailyMembersRecord.AllowUserToDeleteRows = False
        Me.dgvDailyMembersRecord.AllowUserToResizeColumns = False
        Me.dgvDailyMembersRecord.AllowUserToResizeRows = False
        Me.dgvDailyMembersRecord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDailyMembersRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDailyMembersRecord.BackgroundColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDailyMembersRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDailyMembersRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDailyMembersRecord.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDailyMembersRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDailyMembersRecord.Location = New System.Drawing.Point(407, 80)
        Me.dgvDailyMembersRecord.Name = "dgvDailyMembersRecord"
        Me.dgvDailyMembersRecord.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvDailyMembersRecord.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDailyMembersRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDailyMembersRecord.Size = New System.Drawing.Size(512, 375)
        Me.dgvDailyMembersRecord.StandardTab = True
        Me.dgvDailyMembersRecord.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(405, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 23)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Search"
        '
        'txtDailySearchBox
        '
        Me.txtDailySearchBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDailySearchBox.Location = New System.Drawing.Point(473, 34)
        Me.txtDailySearchBox.Name = "txtDailySearchBox"
        Me.txtDailySearchBox.Size = New System.Drawing.Size(272, 27)
        Me.txtDailySearchBox.TabIndex = 79
        '
        'tpMonthly
        '
        Me.tpMonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.tpMonthly.Controls.Add(Me.gbMonthly)
        Me.tpMonthly.Controls.Add(Me.dgvMonthlyMembersRecord)
        Me.tpMonthly.Controls.Add(Me.Label2)
        Me.tpMonthly.Controls.Add(Me.txtMonthlySearchBox)
        Me.tpMonthly.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpMonthly.Location = New System.Drawing.Point(4, 32)
        Me.tpMonthly.Name = "tpMonthly"
        Me.tpMonthly.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMonthly.Size = New System.Drawing.Size(943, 482)
        Me.tpMonthly.TabIndex = 1
        Me.tpMonthly.Text = "MONTHLY"
        '
        'gbMonthly
        '
        Me.gbMonthly.Controls.Add(Me.btnMFind)
        Me.gbMonthly.Controls.Add(Me.btnMTimeOut)
        Me.gbMonthly.Controls.Add(Me.btnMTimeIn)
        Me.gbMonthly.Controls.Add(Me.Label5)
        Me.gbMonthly.Controls.Add(Me.txtMonthlyMemberId)
        Me.gbMonthly.Controls.Add(Me.Label6)
        Me.gbMonthly.Controls.Add(Me.txtMonthlyFullName)
        Me.gbMonthly.Location = New System.Drawing.Point(24, 68)
        Me.gbMonthly.Name = "gbMonthly"
        Me.gbMonthly.Size = New System.Drawing.Size(355, 263)
        Me.gbMonthly.TabIndex = 97
        Me.gbMonthly.TabStop = False
        '
        'btnMFind
        '
        Me.btnMFind.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMFind.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnMFind.ForeColor = System.Drawing.Color.White
        Me.btnMFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMFind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMFind.Location = New System.Drawing.Point(248, 67)
        Me.btnMFind.Name = "btnMFind"
        Me.btnMFind.Size = New System.Drawing.Size(79, 27)
        Me.btnMFind.TabIndex = 96
        Me.btnMFind.Text = "FIND"
        Me.btnMFind.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMFind.UseVisualStyleBackColor = True
        '
        'btnMTimeOut
        '
        Me.btnMTimeOut.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMTimeOut.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMTimeOut.ForeColor = System.Drawing.Color.White
        Me.btnMTimeOut.Location = New System.Drawing.Point(172, 196)
        Me.btnMTimeOut.Name = "btnMTimeOut"
        Me.btnMTimeOut.Size = New System.Drawing.Size(104, 39)
        Me.btnMTimeOut.TabIndex = 95
        Me.btnMTimeOut.Text = "Time Out"
        Me.btnMTimeOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMTimeOut.UseVisualStyleBackColor = True
        '
        'btnMTimeIn
        '
        Me.btnMTimeIn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMTimeIn.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMTimeIn.ForeColor = System.Drawing.Color.White
        Me.btnMTimeIn.Location = New System.Drawing.Point(60, 196)
        Me.btnMTimeIn.Name = "btnMTimeIn"
        Me.btnMTimeIn.Size = New System.Drawing.Size(93, 39)
        Me.btnMTimeIn.TabIndex = 94
        Me.btnMTimeIn.Text = "Time In"
        Me.btnMTimeIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMTimeIn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(23, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 26)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Member Id"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMonthlyMemberId
        '
        Me.txtMonthlyMemberId.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtMonthlyMemberId.Location = New System.Drawing.Point(22, 67)
        Me.txtMonthlyMemberId.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMonthlyMemberId.Name = "txtMonthlyMemberId"
        Me.txtMonthlyMemberId.Size = New System.Drawing.Size(218, 27)
        Me.txtMonthlyMemberId.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(23, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 26)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Full Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMonthlyFullName
        '
        Me.txtMonthlyFullName.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtMonthlyFullName.Location = New System.Drawing.Point(22, 142)
        Me.txtMonthlyFullName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMonthlyFullName.Name = "txtMonthlyFullName"
        Me.txtMonthlyFullName.Size = New System.Drawing.Size(287, 27)
        Me.txtMonthlyFullName.TabIndex = 91
        '
        'dgvMonthlyMembersRecord
        '
        Me.dgvMonthlyMembersRecord.AllowUserToAddRows = False
        Me.dgvMonthlyMembersRecord.AllowUserToDeleteRows = False
        Me.dgvMonthlyMembersRecord.AllowUserToResizeColumns = False
        Me.dgvMonthlyMembersRecord.AllowUserToResizeRows = False
        Me.dgvMonthlyMembersRecord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMonthlyMembersRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMonthlyMembersRecord.BackgroundColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonthlyMembersRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMonthlyMembersRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonthlyMembersRecord.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMonthlyMembersRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMonthlyMembersRecord.Location = New System.Drawing.Point(407, 80)
        Me.dgvMonthlyMembersRecord.Name = "dgvMonthlyMembersRecord"
        Me.dgvMonthlyMembersRecord.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvMonthlyMembersRecord.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMonthlyMembersRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMonthlyMembersRecord.Size = New System.Drawing.Size(512, 375)
        Me.dgvMonthlyMembersRecord.StandardTab = True
        Me.dgvMonthlyMembersRecord.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(405, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Search"
        '
        'txtMonthlySearchBox
        '
        Me.txtMonthlySearchBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlySearchBox.Location = New System.Drawing.Point(473, 34)
        Me.txtMonthlySearchBox.Name = "txtMonthlySearchBox"
        Me.txtMonthlySearchBox.Size = New System.Drawing.Size(272, 27)
        Me.txtMonthlySearchBox.TabIndex = 83
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(499, 100)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(95, 23)
        Me.lblDateTime.TabIndex = 107
        Me.lblDateTime.Text = "DATE TIME"
        '
        'Timer1
        '
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.tcMembership)
        Me.Controls.Add(Me.lblResRec)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tcMembership.ResumeLayout(False)
        Me.tpDaily.ResumeLayout(False)
        Me.tpDaily.PerformLayout()
        Me.gbDaily.ResumeLayout(False)
        Me.gbDaily.PerformLayout()
        CType(Me.dgvDailyMembersRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMonthly.ResumeLayout(False)
        Me.tpMonthly.PerformLayout()
        Me.gbMonthly.ResumeLayout(False)
        Me.gbMonthly.PerformLayout()
        CType(Me.dgvMonthlyMembersRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResRec As System.Windows.Forms.Label
    Friend WithEvents tcMembership As System.Windows.Forms.TabControl
    Friend WithEvents tpDaily As System.Windows.Forms.TabPage
    Friend WithEvents tpMonthly As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDailySearchBox As System.Windows.Forms.TextBox
    Friend WithEvents dgvDailyMembersRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dgvMonthlyMembersRecord As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonthlySearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDailyMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDailyFullName As System.Windows.Forms.TextBox
    Friend WithEvents btnDTimeOut As System.Windows.Forms.Button
    Friend WithEvents btnDTimeIn As System.Windows.Forms.Button
    Friend WithEvents btnDFind As System.Windows.Forms.Button
    Friend WithEvents btnMFind As System.Windows.Forms.Button
    Friend WithEvents btnMTimeOut As System.Windows.Forms.Button
    Friend WithEvents btnMTimeIn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMonthlyMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMonthlyFullName As System.Windows.Forms.TextBox
    Friend WithEvents gbDaily As System.Windows.Forms.GroupBox
    Friend WithEvents gbMonthly As System.Windows.Forms.GroupBox
End Class
