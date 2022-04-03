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
End Class

