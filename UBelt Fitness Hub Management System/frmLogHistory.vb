Public Class frmLogHistory

    Private Sub frmLogHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_MembersInfo()

        dgvMembersRecord.RowTemplate.Height = 40
        dgvMembersRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvMembersRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembersRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_MembersInfo()
        query = "SELECT d.MemberId, d.FullName, d.MembershipType, d.Date, d.TimeLogIn, d.TimeLogOut" _
        & " FROM daily AS d" _
        & " UNION ALL SELECT m.MemberId, m.FullName, m.MembershipType, m.Date, m.TimeLogIn, m.TimeLogOut" _
        & " FROM monthly AS m"
        reloadDgv(query, dgvMembersRecord)
    End Sub
End Class

