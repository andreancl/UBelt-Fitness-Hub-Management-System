<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbUBFH = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbUBFH)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(256, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(752, 64)
        Me.Panel3.TabIndex = 7
        '
        'lbUBFH
        '
        Me.lbUBFH.AutoSize = True
        Me.lbUBFH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbUBFH.Font = New System.Drawing.Font("Calibri", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUBFH.Location = New System.Drawing.Point(212, 0)
        Me.lbUBFH.Name = "lbUBFH"
        Me.lbUBFH.Size = New System.Drawing.Size(475, 64)
        Me.lbUBFH.TabIndex = 0
        Me.lbUBFH.Text = "U-BELT FITNESS HUB"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBackup)
        Me.Panel1.Controls.Add(Me.btnAttendance)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnMembers)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 749)
        Me.Panel1.TabIndex = 6
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnBackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.Location = New System.Drawing.Point(0, 457)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Padding = New System.Windows.Forms.Padding(6, 0, 40, 0)
        Me.btnBackup.Size = New System.Drawing.Size(256, 50)
        Me.btnBackup.TabIndex = 13
        Me.btnBackup.Text = "   Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.Color.Transparent
        Me.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAttendance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnAttendance.FlatAppearance.BorderSize = 0
        Me.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttendance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.White
        Me.btnAttendance.Image = CType(resources.GetObject("btnAttendance.Image"), System.Drawing.Image)
        Me.btnAttendance.Location = New System.Drawing.Point(0, 407)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.btnAttendance.Size = New System.Drawing.Size(256, 50)
        Me.btnAttendance.TabIndex = 12
        Me.btnAttendance.Text = "  Attendance"
        Me.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), System.Drawing.Image)
        Me.btnLogOut.Location = New System.Drawing.Point(0, 699)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(256, 50)
        Me.btnLogOut.TabIndex = 7
        Me.btnLogOut.Text = "   Log Out"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnMembers
        '
        Me.btnMembers.BackColor = System.Drawing.Color.Transparent
        Me.btnMembers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMembers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnMembers.FlatAppearance.BorderSize = 0
        Me.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMembers.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.ForeColor = System.Drawing.Color.White
        Me.btnMembers.Image = CType(resources.GetObject("btnMembers.Image"), System.Drawing.Image)
        Me.btnMembers.Location = New System.Drawing.Point(0, 357)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnMembers.Size = New System.Drawing.Size(256, 50)
        Me.btnMembers.TabIndex = 3
        Me.btnMembers.Text = "   Members"
        Me.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 307)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(256, 50)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.lblUserName)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(256, 243)
        Me.Panel4.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(89, 202)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 26)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 64)
        Me.Panel2.TabIndex = 0
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbUBFH As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnMembers As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAttendance As System.Windows.Forms.Button
End Class
