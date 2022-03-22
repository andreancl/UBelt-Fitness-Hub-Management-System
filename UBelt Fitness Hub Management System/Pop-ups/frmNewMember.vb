﻿Public Class frmNewMember
    Public member_id As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim rdo As String = ""
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
                   & "', `ContactNumber`='" & txtContactNo.Text & "', `Address`='" & txtAddress.Text _
                   & "', `MembershipType`=" & cmbMembership.Text & "' WHERE `VisitorId`='" & lblMemId.Text & "'"
                updates(query, txtFullName.Text)
            Else
                Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
                Dim member_id = "MEM" + datetime_now

                If rdoMale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                query = "INSERT INTO `members` (`MemberId`, `FullName`, `Sex`, `Birthdate`" _
                    & ", `ContactNumber`, `Address`, `MembershipType`) VALUES ('" & member_id & "'" _
                    & ", '" & txtFullName.Text & "', '" & rdo & "', '" & dtpBirthdate.Text & "'" _
                    & ", '" & txtContactNo.Text & "', '" & txtAddress.Text & "', '" & cmbMembership.Text & "')"
                create(query, txtFullName.Text)
            End If
            frmMembers.load_MembersInfo()
            cleartext(gbMembers)
            setup(gbMembers)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmNewMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup(gbMembers)
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