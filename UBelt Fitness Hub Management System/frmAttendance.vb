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
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnDFind.Click
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
    Private Sub btnDTimeIn_Click(sender As Object, e As EventArgs) Handles btnDTimeIn.Click
        Try
        Dim logdate As String = String.Format("{0:dd-MM-yyyy}", DateTime.Now)
        Dim login = TimeOfDay
        query = "INSERT INTO `daily` (`MemberId`, `FullName`, `Date`, `TimeLogIn`)" _
        & " VALUES ('" & txtDailyMemberId.Text & "', '" & txtDailyFullName.Text & "'" _
        & ",'" & logdate & "', '" & login & "')"
        create(query, txtDailyFullName.Text)
        load_MembersInfoDaily()
            cleartext(gbDaily)
        Catch ex As Exception
            MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub btnDTimeOut_Click(sender As Object, e As EventArgs) Handles btnDTimeOut.Click
        Dim logout = TimeOfDay

        query = "UPDATE `daily` SET `TimeLogOut`= '" & logout & "' WHERE MemberId = '" _
        & dgvDailyMembersRecord.CurrentRow.Cells(0).Value & "'"
        updates(query, dgvDailyMembersRecord.CurrentRow.Cells(1).Value)
        load_MembersInfoDaily()
        cleartext(gbDaily)
    End Sub
    Private Sub dgvDailyMembersRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDailyMembersRecord.CellContentClick
        txtDailyMemberId.Text = dgvDailyMembersRecord.CurrentRow.Cells(0).Value
        txtDailyFullName.Text = dgvDailyMembersRecord.CurrentRow.Cells(1).Value
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
    Private Sub btnMFind_Click(sender As Object, e As EventArgs) Handles btnMFind.Click
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
    Private Sub btnMTimeIn_Click(sender As Object, e As EventArgs) Handles btnMTimeIn.Click
        Dim logdate As String = String.Format("{0:dd-MM-yyyy}", DateTime.Now)
        Dim login = TimeOfDay
        query = "INSERT INTO `monthly` (`MemberId`, `FullName`, `Date`, `TimeLogIn`)" _
        & " VALUES ('" & txtDailyMemberId.Text & "', '" & txtMonthlyFullName.Text & "'" _
        & ",'" & logdate & "', '" & login & "')"
        create(query, txtMonthlyFullName.Text)
        load_MembersInfoMonthly()
        cleartext(gbMonthly)
    End Sub
#End Region
    Private Sub btnMTimeOut_Click(sender As Object, e As EventArgs) Handles btnMTimeOut.Click
        Dim logout = TimeOfDay

        query = "UPDATE `monthly` SET `TimeLogOut`= '" & logout & "' WHERE MemberId = '" _
        & dgvMonthlyMembersRecord.CurrentRow.Cells(0).Value & "'"
        updates(query, dgvMonthlyMembersRecord.CurrentRow.Cells(1).Value)
        load_MembersInfoMonthly()
        cleartext(gbMonthly)
    End Sub
    Private Sub dgvMonthlyMembersRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMonthlyMembersRecord.CellContentClick
        txtMonthlyMemberId.Text = dgvMonthlyMembersRecord.CurrentRow.Cells(0).Value
        txtMonthlyFullName.Text = dgvMonthlyMembersRecord.CurrentRow.Cells(1).Value
    End Sub
End Class