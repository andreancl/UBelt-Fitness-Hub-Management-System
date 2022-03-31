Imports MySql.Data.MySqlClient
Public Class frmNewMember
    Public con As MySqlConnection = mysqldb()
    Public member_id As String
    Dim rdo As String = ""
    Private Sub frmNewMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup(gbMembers)
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
            UpRegMember()
            End If
    End Sub
    Private Sub UpRegMember()
        Try
            Dim ContactNo As Integer
            Int32.TryParse(txtContactNo.Text, ContactNo)
            query = "SELECT * FROM `members` WHERE `MemberId`='" & lblMemId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                If rdoMale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                query = "UPDATE `members` SET  `FullName`='" & txtFullName.Text _
                   & "', `Sex`='" & rdo & "', `Birthdate`='" & Format(dtpBirthdate.Value, "yyyy-MM-dd") _
                   & "', `ContactNumber`='" & ContactNo & "', `Address`='" & txtAddress.Text _
                   & "', `MembershipType`='" & cmbMembership.Text & "' WHERE `MemberId`='" & lblMemId.Text & "'"
                updates(query, txtFullName.Text)
                frmMembers.load_MembersInfo()
                cleartext(gbMembers)
                Me.Close()
            Else
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
                    & ", '" & ContactNo & "', '" & txtAddress.Text & "', '" & cmbMembership.Text & "'" _
                    & ", '" & datereg & "')"
                create(query, txtFullName.Text)
            End If
            frmMembers.load_MembersInfo()
            cleartext(gbMembers)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
  
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class