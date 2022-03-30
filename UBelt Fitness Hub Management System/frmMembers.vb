Imports MySql.Data.MySqlClient
Public Class frmMembers
    Dim index As Integer = 0
    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_MembersInfo()

        dgvMembersRecord.RowTemplate.Height = 40
        dgvMembersRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvMembersRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembersRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White

    End Sub
    Public Sub load_MembersInfo()
        query = "SELECT `MemberId` AS 'Member ID', `FullName` AS 'Full Name', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age'" _
        & ", `ContactNumber` AS 'Contact Number', `Address` AS 'Address'" _
        & ", `MembershipType` AS 'Membership Type', `DateRegistered` AS `Date Registered` FROM `members`"
        reloadDgv(query, dgvMembersRecord)
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewMember.Click
        frmNewMember.Show()
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        query = "SELECT `MemberId` AS 'Member ID',`FullName` AS 'Full Name', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `ContactNumber` AS 'Contact Number'" _
        & ", `Address` AS 'Address', `MembershipType` AS 'Membership Type', `DateRegistered` AS 'Date Registered' FROM `members` WHERE FullName LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvMembersRecord)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            frmNewMember.lblMemTitle.Text = "UPDATE MEMBER INFORMATION"
            frmNewMember.lblMemId.Text = dgvMembersRecord.CurrentRow.Cells(0).Value()
            frmNewMember.btnSave.Text = "Update Member"
            showForm(frmNewMember)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        query = "DELETE FROM members WHERE MemberId = '" & dgvMembersRecord.CurrentRow.Cells(0).Value & "'"
        deletes(query, dgvMembersRecord.CurrentRow.Cells(1).Value)
        reloadDgv(query, dgvMembersRecord)
    End Sub
    Private Sub dgvMembersRecords_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvMembersRecord.CellToolTipTextNeeded
        Dim dgv = DirectCast(sender, DataGridView)

        If e.RowIndex = -1 AndAlso e.ColumnIndex <> -1 Then
            e.ToolTipText = dgv.Columns(e.ColumnIndex).HeaderText & vbCrLf
        Else
            e.ToolTipText = "right click to see available options"
        End If
    End Sub
    Private Sub dgvMembersRecord_CellMouseUp(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvMembersRecord.CellMouseUp
        Try
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                dgvMembersRecord.Rows(e.RowIndex).Selected = True
                index = e.RowIndex
                dgvMembersRecord.CurrentCell = dgvMembersRecord.Rows(e.RowIndex).Cells(1)
                ContextMenuStrip1.Show(dgvMembersRecord, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class