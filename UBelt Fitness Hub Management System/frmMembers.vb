Imports MySql.Data.MySqlClient
Public Class frmMembers

    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_MembersInfo()

        dgvMembersRecord.RowTemplate.Height = 40
        dgvMembersRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvMembersRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembersRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White

    End Sub
    Public Sub load_MembersInfo()
        query = "SELECT `MemberId` AS 'Member ID', `FullName` AS 'Last Name', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age'" _
        & ", `ContactNumber` AS 'Contact Number', `Address` AS 'Address', `MembershipType` AS 'Membership Type' FROM `clients`"
        reloadDgv(query, dgvMembersRecord)
    End Sub

    Private Sub btnNewResident_Click(sender As Object, e As EventArgs) Handles btnNewResident.Click
        frmNewMember.Show()
    End Sub
End Class