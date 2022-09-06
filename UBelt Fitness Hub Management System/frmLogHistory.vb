Public Class frmLogHistory

    Private Sub frmLogHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_MembersInfo()
        dgvMembersRecord.RowTemplate.Height = 40
        dgvMembersRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvMembersRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembersRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        load_MemberList()
        dgvMemberList.RowTemplate.Height = 40
        dgvMemberList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMemberList.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_MembersInfo()
        query = "SELECT d.MemberId, d.FullName, d.MembershipType, d.Date, d.TimeLogIn, d.TimeLogOut" _
        & " FROM daily AS d" _
        & " UNION ALL SELECT m.MemberId, m.FullName, m.MembershipType, m.Date, m.TimeLogIn, m.TimeLogOut" _
        & " FROM monthly AS m"
        reloadDgv(query, dgvMembersRecord)
    End Sub
    Public Sub load_MemberList()
        query = "SELECT `MemberId` AS 'Member ID', `FullName` AS 'Full Name', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age'" _
        & ", `ContactNumber` AS 'Contact Number', `Address` AS 'Address'" _
        & ", `MembershipType` AS 'Membership Type', `DateRegistered` AS `Date Registered` FROM `members`"
        reloadDgv(query, dgvMemberList)
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub
    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.dgvMembersRecord.Width, Me.dgvMembersRecord.Height)
        dgvMembersRecord.DrawToBitmap(bm, New Rectangle(30, 30, Me.dgvMembersRecord.Width, Me.dgvMembersRecord.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cmbFilter.Text = "MEMBER'S NAME" Then
            query = "SELECT d.MemberId, d.FullName, d.MembershipType, d.Date, d.TimeLogIn, d.TimeLogOut" _
            & " FROM daily AS d WHERE d.FullName LIKE '%" & txtSearch.Text & "%'" _
            & " UNION ALL SELECT m.MemberId, m.FullName, m.MembershipType, m.Date, m.TimeLogIn, m.TimeLogOut" _
            & " FROM monthly AS m WHERE m.FullName LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvMembersRecord)
            query = "SELECT `MemberId` AS 'Member ID',`FullName` AS 'Full Name', `Sex` AS 'Sex'" _
           & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `ContactNumber` AS 'Contact Number'" _
           & ", `Address` AS 'Address', `MembershipType` AS 'Membership Type', `DateRegistered` AS 'Date Registered'" _
           & " FROM `members` WHERE FullName LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvMemberList)
        Else : cmbFilter.Text = "MEMBERSHIP TYPE"
            query = "SELECT d.MemberId, d.FullName, d.MembershipType, d.Date, d.TimeLogIn, d.TimeLogOut" _
            & " FROM daily AS d WHERE d.MembershipType LIKE '%" & txtSearch.Text & "%'" _
            & " UNION ALL SELECT m.MemberId, m.FullName, m.MembershipType, m.Date, m.TimeLogIn, m.TimeLogOut" _
            & " FROM monthly AS m WHERE m.MembershipType LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvMembersRecord)
            query = "SELECT `MemberId` AS 'Member ID',`FullName` AS 'Full Name', `Sex` AS 'Sex'" _
           & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `ContactNumber` AS 'Contact Number'" _
           & ", `Address` AS 'Address', `MembershipType` AS 'Membership Type', `DateRegistered` AS 'Date Registered'" _
           & " FROM `members` WHERE FullName LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvMemberList)
        End If
    End Sub
    Private Sub btnPrint2_Click(sender As Object, e As EventArgs) Handles btnPrint2.Click
        PrintDocument2.DefaultPageSettings.Landscape = True
        PrintPreviewDialog2.ShowDialog()
        PrintDocument2.Print()
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim bm As New Bitmap(Me.dgvMemberList.Width, Me.dgvMemberList.Height)
        dgvMemberList.DrawToBitmap(bm, New Rectangle(30, 30, Me.dgvMemberList.Width, Me.dgvMemberList.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class

