<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMembers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblResRec = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.btnNewResident = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvMembersRecord = New System.Windows.Forms.DataGridView()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvMembersRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResRec
        '
        Me.lblResRec.AutoSize = True
        Me.lblResRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResRec.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResRec.Location = New System.Drawing.Point(19, 11)
        Me.lblResRec.Name = "lblResRec"
        Me.lblResRec.Size = New System.Drawing.Size(314, 45)
        Me.lblResRec.TabIndex = 13
        Me.lblResRec.Text = "MEMBERS RECORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Search"
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(72, 10)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(272, 27)
        Me.txtSearchBox.TabIndex = 77
        '
        'btnNewResident
        '
        Me.btnNewResident.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNewResident.FlatAppearance.BorderSize = 0
        Me.btnNewResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewResident.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewResident.ForeColor = System.Drawing.Color.White
        Me.btnNewResident.Image = CType(resources.GetObject("btnNewResident.Image"), System.Drawing.Image)
        Me.btnNewResident.Location = New System.Drawing.Point(617, 0)
        Me.btnNewResident.Name = "btnNewResident"
        Me.btnNewResident.Size = New System.Drawing.Size(182, 48)
        Me.btnNewResident.TabIndex = 0
        Me.btnNewResident.Text = "   New Member"
        Me.btnNewResident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewResident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewResident.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtSearchBox)
        Me.Panel5.Controls.Add(Me.btnNewResident)
        Me.Panel5.Location = New System.Drawing.Point(135, 93)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(799, 48)
        Me.Panel5.TabIndex = 12
        '
        'dgvMembersRecord
        '
        Me.dgvMembersRecord.AllowUserToAddRows = False
        Me.dgvMembersRecord.AllowUserToDeleteRows = False
        Me.dgvMembersRecord.AllowUserToResizeColumns = False
        Me.dgvMembersRecord.AllowUserToResizeRows = False
        Me.dgvMembersRecord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMembersRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMembersRecord.BackgroundColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembersRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMembersRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembersRecord.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMembersRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMembersRecord.Location = New System.Drawing.Point(135, 165)
        Me.dgvMembersRecord.Name = "dgvMembersRecord"
        Me.dgvMembersRecord.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvMembersRecord.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMembersRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembersRecord.Size = New System.Drawing.Size(799, 435)
        Me.dgvMembersRecord.StandardTab = True
        Me.dgvMembersRecord.TabIndex = 14
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 637)
        Me.Controls.Add(Me.dgvMembersRecord)
        Me.Controls.Add(Me.lblResRec)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvMembersRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResRec As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNewResident As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dgvMembersRecord As System.Windows.Forms.DataGridView
End Class
