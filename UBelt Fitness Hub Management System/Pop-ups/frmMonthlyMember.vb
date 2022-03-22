Public Class frmMonthlyMember

    Private Sub frmMonthlyMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_MembersInfo()

        dgvMemberList.RowTemplate.Height = 40
        dgvMemberList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMemberList.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_MembersInfo()
        query = "SELECT `MemberId` AS 'Member ID', `FullName` AS 'Full Name', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age'" _
        & ", `ContactNumber` AS 'Contact Number', `Address` AS 'Address'" _
        & ", `DateRegistered` AS `Date Registered`, `MembershipType` AS 'Membership Type'" _
        & "  FROM `members` WHERE MembershipType = 'Monthly'"
        reloadDgv(query, dgvMemberList)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        query = "SELECT `MemberId` AS 'Member ID', `FullName` AS 'Full Name', `Sex` AS 'Sex'" _
      & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age'" _
      & ", `ContactNumber` AS 'Contact Number', `Address` AS 'Address'" _
      & ", `DateRegistered` AS `Date Registered`, `MembershipType` AS 'Membership Type'" _
      & "  FROM `members` WHERE MembershipType = 'Monthly' AND FullName LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvMemberList)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        frmAttendance.txtMonthlyMemberId.Text = dgvMemberList.CurrentRow.Cells(0).Value
        frmAttendance.txtMonthlyFullName.Text = dgvMemberList.CurrentRow.Cells(1).Value
    End Sub

    Private Sub dgvMemberList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvMemberList.DoubleClick
        frmAttendance.txtMonthlyMemberId.Text = dgvMemberList.CurrentRow.Cells(0).Value
        frmAttendance.txtMonthlyFullName.Text = dgvMemberList.CurrentRow.Cells(1).Value
    End Sub
End Class