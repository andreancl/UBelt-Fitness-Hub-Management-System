Imports MySql.Data.MySqlClient
Public Class frmMembers
    Dim rdo As String
    Public con As MySqlConnection = mysqldb()
    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_MembersInfo()

        dgvMembersRecord.RowTemplate.Height = 40
        dgvMembersRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvMembersRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembersRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        clearcontrol(gbMembers)
    End Sub
    Public Sub load_MembersInfo()
        query = "SELECT `MemberId` AS 'Member ID', `FullName` AS 'Full Name', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age'" _
        & ", `ContactNumber` AS 'Contact Number', `Address` AS 'Address'" _
        & ", `MembershipType` AS 'Membership Type', `DateRegistered` AS `Date Registered` FROM `members`"
        reloadDgv(query, dgvMembersRecord)
    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        query = "SELECT `MemberId` AS 'Member ID',`FullName` AS 'Full Name', `Sex` AS 'Sex'" _
        & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age', `ContactNumber` AS 'Contact Number'" _
        & ", `Address` AS 'Address', `MembershipType` AS 'Membership Type', `DateRegistered` AS 'Date Registered'" _
        & " FROM `members` WHERE FullName LIKE '%" & txtSearchBox.Text & "%'"
        reloadDgv(query, dgvMembersRecord)
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        query = "DELETE FROM members WHERE MemberId = '" & dgvMembersRecord.CurrentRow.Cells(0).Value & "'"
        deletes(query, dgvMembersRecord.CurrentRow.Cells(1).Value)
        load_MembersInfo()
        clearcontrol(gbMembers)
        lblMemId.Text = ""
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        query = "SELECT * FROM `members` WHERE `MemberId`='" & lblMemId.Text & "'"
        reloadtxt(query)

        If rdoMale.Checked = True Then
            rdo = "Male"
        Else
            rdo = "Female"
        End If

        query = "UPDATE `members` SET  `FullName`='" & txtFullName.Text _
           & "', `Sex`='" & rdo & "', `Birthdate`='" & Format(dtpBirthdate.Value, "yyyy-MM-dd") _
           & "', `ContactNumber`='" & txtContactNo.Text & "', `Address`='" & txtAddress.Text _
           & "', `MembershipType`='" & cmbMembership.Text & "' WHERE `MemberId`='" & lblMemId.Text & "'"
        updates(query, txtFullName.Text)
        load_MembersInfo()
        clearcontrol(gbMembers)
        lblMemId.Text = ""
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFullName.Text = "" And rdo = "" And dtpBirthdate.Text = "" And txtContactNo.Text = "" And txtAddress.Text = "" And cmbMembership.Text = "" Then
            MsgBox("Fill up your account details", MsgBoxStyle.Critical, "ATTENTION!")
            txtFullName.Focus()
        ElseIf txtFullName.Text = "" Then
            MsgBox("No Full Name Found!", MsgBoxStyle.Critical, "Error")
            txtFullName.Focus()
        ElseIf rdoMale.Text = "" Or rdoFemale.Text = "" Then
            MsgBox("Please Select Sex", MsgBoxStyle.Critical, "Error")
            rdoMale.Focus()
        ElseIf txtContactNo.Text = "" Then
            MsgBox("No Contact Number Found!", MsgBoxStyle.Critical, "Error")
            txtContactNo.Focus()
        ElseIf txtAddress.Text = "" Then
            MsgBox("No AddressPassword Found!", MsgBoxStyle.Critical, "Error")
            txtAddress.Focus()
        ElseIf cmbMembership.Text = "" Then
            MsgBox("Please Select Membership Type", MsgBoxStyle.Critical, "Error")
            cmbMembership.Focus()
        Else
            CheckingName()
        End If
    End Sub
    Private Sub CheckingName()
        Try
            con.Open()
            query = "SELECT FullName FROM members WHERE FullName = '" & txtFullName.Text & "'"
            cmd = New MySqlCommand(query, con)
            dr = cmd.ExecuteReader()
            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            Select Case count
                Case 1
                    MsgBox("Member has already registered!", MsgBoxStyle.Critical, "ATTENTION")
                Case Else
                    con.Close()
                    RegMember()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Private Sub RegMember()
        Try
            Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
            Dim member_id = "MEM" + datetime_now
            Dim datereg As String = String.Format("{0:ddMMyyyhh}", Date.Now)

            If rdoMale.Checked = True Then
                rdo = "Male"
            Else
                rdo = "Female"
            End If

            query = "INSERT INTO `members` (`MemberId`, `FullName`, `Sex`, `Birthdate`" _
                & ", `ContactNumber`, `Address`, `MembershipType`, `DateRegistered`) VALUES ('" & member_id & "'" _
                & ", '" & txtFullName.Text & "', '" & rdo & "', '" & dtpBirthdate.Text & "'" _
                & ", '" & txtContactNo.Text & "', '" & txtAddress.Text & "', '" & cmbMembership.Text & "'" _
                & ", '" & datereg & "')"
            create(query, txtFullName.Text)
            load_MembersInfo()
            clearcontrol(gbMembers)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearcontrol(gbMembers)
        lblMemId.Text = ""
    End Sub
    Private Sub dgvMembersRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembersRecord.CellContentClick
        lblMemId.Text = dgvMembersRecord.CurrentRow.Cells(0).Value
    End Sub
    Private Sub lblMemId_TextChanged(sender As Object, e As EventArgs) Handles lblMemId.TextChanged
        Try
            query = "SELECT * FROM `members` WHERE `MemberId`='" & lblMemId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                txtFullName.Text = dt.Rows(0).Item("FullName")
                dtpBirthdate.Value = dt.Rows(0).Item("Birthdate")
                txtContactNo.Text = dt.Rows(0).Item("ContactNumber")
                txtAddress.Text = dt.Rows(0).Item("Address")
                cmbMembership.Text = dt.Rows(0).Item("MembershipType")
                If dt.Rows(0).Item("Sex") = "Male" Then
                    rdoMale.Checked = True
                Else
                    rdoFemale.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "Validation"
    Private Sub txtFullName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 32 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNo.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        If (Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) And (Asc(e.KeyChar)) < 65 Or (Asc(e.KeyChar)) > 90 And (Asc(e.KeyChar)) < 97 Or (Asc(e.KeyChar)) > 122 Then
            e.Handled = True
        End If
        If (Asc(e.KeyChar) = 8) Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
        End If
    End Sub
#End Region
End Class