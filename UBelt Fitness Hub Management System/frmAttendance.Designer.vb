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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendance))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblResRec = New System.Windows.Forms.Label()
        Me.tcMembership = New System.Windows.Forms.TabControl()
        Me.tpDaily = New System.Windows.Forms.TabPage()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.dgvDailyMembersRecord = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDailySearchBox = New System.Windows.Forms.TextBox()
        Me.tpMonthly = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvMonthlyMembersRecord = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonthlySearchBox = New System.Windows.Forms.TextBox()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tcMembership.SuspendLayout()
        Me.tpDaily.SuspendLayout()
        CType(Me.dgvDailyMembersRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMonthly.SuspendLayout()
        CType(Me.dgvMonthlyMembersRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResRec
        '
        Me.lblResRec.AutoSize = True
        Me.lblResRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResRec.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResRec.Location = New System.Drawing.Point(48, 19)
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
        Me.tcMembership.Location = New System.Drawing.Point(56, 88)
        Me.tcMembership.Name = "tcMembership"
        Me.tcMembership.SelectedIndex = 0
        Me.tcMembership.Size = New System.Drawing.Size(951, 526)
        Me.tcMembership.TabIndex = 17
        '
        'tpDaily
        '
        Me.tpDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.tpDaily.Controls.Add(Me.btnSelect)
        Me.tpDaily.Controls.Add(Me.dgvDailyMembersRecord)
        Me.tpDaily.Controls.Add(Me.Label1)
        Me.tpDaily.Controls.Add(Me.txtDailySearchBox)
        Me.tpDaily.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpDaily.Location = New System.Drawing.Point(4, 32)
        Me.tpDaily.Name = "tpDaily"
        Me.tpDaily.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDaily.Size = New System.Drawing.Size(943, 490)
        Me.tpDaily.TabIndex = 0
        Me.tpDaily.Text = "DAILY"
        '
        'btnSelect
        '
        Me.btnSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Location = New System.Drawing.Point(733, 24)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(186, 39)
        Me.btnSelect.TabIndex = 82
        Me.btnSelect.Text = "  Select Member"
        Me.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelect.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDailyMembersRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDailyMembersRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDailyMembersRecord.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDailyMembersRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDailyMembersRecord.Location = New System.Drawing.Point(21, 80)
        Me.dgvDailyMembersRecord.Name = "dgvDailyMembersRecord"
        Me.dgvDailyMembersRecord.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvDailyMembersRecord.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDailyMembersRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDailyMembersRecord.Size = New System.Drawing.Size(898, 383)
        Me.dgvDailyMembersRecord.StandardTab = True
        Me.dgvDailyMembersRecord.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Search"
        '
        'txtDailySearchBox
        '
        Me.txtDailySearchBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDailySearchBox.Location = New System.Drawing.Point(80, 31)
        Me.txtDailySearchBox.Name = "txtDailySearchBox"
        Me.txtDailySearchBox.Size = New System.Drawing.Size(272, 27)
        Me.txtDailySearchBox.TabIndex = 79
        '
        'tpMonthly
        '
        Me.tpMonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.tpMonthly.Controls.Add(Me.Button1)
        Me.tpMonthly.Controls.Add(Me.dgvMonthlyMembersRecord)
        Me.tpMonthly.Controls.Add(Me.Label2)
        Me.tpMonthly.Controls.Add(Me.txtMonthlySearchBox)
        Me.tpMonthly.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpMonthly.Location = New System.Drawing.Point(4, 32)
        Me.tpMonthly.Name = "tpMonthly"
        Me.tpMonthly.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMonthly.Size = New System.Drawing.Size(943, 490)
        Me.tpMonthly.TabIndex = 1
        Me.tpMonthly.Text = "MONTHLY"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(733, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 39)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "  Select Member"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonthlyMembersRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvMonthlyMembersRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonthlyMembersRecord.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvMonthlyMembersRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMonthlyMembersRecord.Location = New System.Drawing.Point(21, 80)
        Me.dgvMonthlyMembersRecord.Name = "dgvMonthlyMembersRecord"
        Me.dgvMonthlyMembersRecord.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvMonthlyMembersRecord.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvMonthlyMembersRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMonthlyMembersRecord.Size = New System.Drawing.Size(898, 383)
        Me.dgvMonthlyMembersRecord.StandardTab = True
        Me.dgvMonthlyMembersRecord.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Search"
        '
        'txtMonthlySearchBox
        '
        Me.txtMonthlySearchBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlySearchBox.Location = New System.Drawing.Point(80, 31)
        Me.txtMonthlySearchBox.Name = "txtMonthlySearchBox"
        Me.txtMonthlySearchBox.Size = New System.Drawing.Size(272, 27)
        Me.txtMonthlySearchBox.TabIndex = 83
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(484, 88)
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
        CType(Me.dgvDailyMembersRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMonthly.ResumeLayout(False)
        Me.tpMonthly.PerformLayout()
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
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvMonthlyMembersRecord As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonthlySearchBox As System.Windows.Forms.TextBox
End Class
