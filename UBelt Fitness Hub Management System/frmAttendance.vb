Public Class frmAttendance

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("dd MMM yyyy   hh:mm:ss")
    End Sub
#Region "Daily"
    Private Sub tpDaily_load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_MembersInfoDaily()

        dgvDailyMembersRecord.RowTemplate.Height = 40
        dgvDailyMembersRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvDailyMembersRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDailyMembersRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_MembersInfoDaily()
        query = "SELECT `MemberId` AS 'Member Id', `FullName` AS 'Full Name'" _
        & ", `Date` AS 'Date', `TimeLogIn` AS 'Log In', `TimeLogOut` as 'LogOut' FROM `daily`"
        reloadDgv(query, dgvDailyMembersRecord)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        With frmdailyMember
            .ShowDialog()
        End With
    End Sub
    Private Sub txtDailySearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtDailySearchBox.TextChanged
        query = "SELECT `MemberId` AS 'Member ID', `FullName` AS 'Full Name'" _
        & ", `Date` AS `Date`, `TimeLogIn` AS 'Time Log In', `TimeLogOut` AS 'Time Log Out'" _
        & "  FROM `daily` WHERE FullName LIKE '%" & txtDailySearchBox.Text & "%'"
        reloadDgv(query, dgvDailyMembersRecord)
    End Sub
#End Region
#Region "Monthly"
    Private Sub tpMonthly_load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_MembersInfoMonthly()

        dgvMonthlyMembersRecord.RowTemplate.Height = 40
        dgvMonthlyMembersRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvMonthlyMembersRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMonthlyMembersRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_MembersInfoMonthly()
        query = "SELECT `MemberId` AS 'Member Id', `FullName` AS 'Full Name'" _
        & ", `Date` AS 'Date', `TimeLogIn` AS 'Log In', `TimeLogOut` as 'LogOut' FROM `monthly`"
        reloadDgv(query, dgvMonthlyMembersRecord)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmMonthlyMember
            .ShowDialog()
        End With
    End Sub
    Private Sub txtMonthlySearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtMonthlySearchBox.TextChanged
        query = "SELECT `MemberId` AS 'Member ID', `FullName` AS 'Full Name'" _
        & ", `Date` AS `Date`, `TimeLogIn` AS 'Time Log In', `TimeLogOut` AS 'Time Log Out'" _
        & "  FROM `monthly` WHERE FullName LIKE '%" & txtMonthlySearchBox.Text & "%'"
        reloadDgv(query, dgvMonthlyMembersRecord)
    End Sub
#End Region

   
End Class