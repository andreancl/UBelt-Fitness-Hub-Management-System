Imports System.IO
Public Class frmSettings
    Dim Path As String
    Dim BackupPath As String
    Dim DatabaseName As String = "gymdb" + Date.Now.ToString("dd-MM-yyyy-HH-mm-ss")
    Public user_id As String
    Dim rdo As String = ""
    Dim rdoad As String = ""
    Dim index As Integer = 0
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            query = "SELECT * FROM `users` WHERE `UserId`='" & lblUserId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                If rdoMale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                If rdoadmin.Checked = True Then
                    rdoad = "1"
                Else
                    rdoad = "2"
                End If
                query = "UPDATE `users` SET  `FullName`='" & txtFullName.Text _
                   & "', `Sex`='" & rdo & "', `Birthdate`='" & Format(dtpBirthdate.Value, "yyyy-MM-dd") _
                   & "',  `ContactNumber`='" & txtContactNum.Text & "', `Address`='" & txtAddress.Text _
                   & "', `Username`='" & txtUsername.Text & "', `Password`='" & txtPassword.Text _
                   & "' WHERE `UserId`='" & lblUserId.Text & "'"
                updates(query, txtFullName.Text)
                load_UserRecords()
                cleartext(gbUser)
                setup(gbUser)
                lblBIS.Text = "CREATE ACCOUNT FORM"
                lblUserId.Text = ""
                btnCreate.Text = "Create Account"
            Else
                Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
                Dim user_id = "USER" + datetime_now

                If rdoMale.Checked = True Then
                    rdo = "Male"
                Else
                    rdo = "Female"
                End If

                If rdoadmin.Checked = True Then
                    rdoad = "1"
                Else
                    rdoad = "2"
                End If

                query = "INSERT INTO users (`UserId`, `FullName`, `Sex`, `Birthdate`, `ContactNumber`" _
                & ", `Address`, `Username`, `Password`, `UserTypeId`) VALUES ('" & user_id _
                & "', '" & txtFullName.Text & "', '" & rdo & "', '" & dtpBirthdate.Text _
                & "', '" & txtContactNum.Text & "', '" & txtAddress.Text _
                & "', '" & txtUsername.Text & "', '" & txtPassword.Text _
                & "', '" & rdoad & "')"
                create(query, txtFullName.Text)
            End If
            load_UserRecords()
            cleartext(gbUser)
            setup(gbUser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tpAccountDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_UserRecords()

        dgvUserRecords.RowTemplate.Height = 30
        dgvUserRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvUserRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUserRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_UserRecords()
        query = "SELECT `UserId` AS 'UserID',`FullName` as 'Full Name', `Sex` as 'Sex'" _
       & ", round( ((DATEDIFF( NOW( ) ,  `Birthdate` ) /12) /31))  AS 'Age'" _
       & ", `ContactNumber` AS 'ContactNumber', `Address` AS 'Address' FROM `users`"
        reloadDgv(query, dgvUserRecords)
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        query = "DELETE FROM users WHERE UserId = '" & dgvUserRecords.CurrentRow.Cells(0).Value & "'"
        deletes(query, dgvUserRecords.CurrentRow.Cells(1).Value)
    End Sub
    Private Sub dgvUserRecords_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvUserRecords.CellToolTipTextNeeded
        Dim dgv = DirectCast(sender, DataGridView)

        If e.RowIndex = -1 AndAlso e.ColumnIndex <> -1 Then
            e.ToolTipText = dgv.Columns(e.ColumnIndex).HeaderText & vbCrLf
        Else
            e.ToolTipText = "right click to see available options"
        End If
    End Sub
    Private Sub dgvUserRecords_CellMouseUp(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvUserRecords.CellMouseUp
        Try
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                dgvUserRecords.Rows(e.RowIndex).Selected = True
                index = e.RowIndex
                dgvUserRecords.CurrentCell = dgvUserRecords.Rows(e.RowIndex).Cells(1)
                ContextMenuStrip1.Show(dgvUserRecords, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        Try
            lblBIS.Text = "UPDATE USER INFORMATION"
            lblUserId.Text = dgvUserRecords.CurrentRow.Cells(0).Value
            btnCreate.Text = "Update Account"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub lblUserId_TextChanged(sender As Object, e As EventArgs) Handles lblUserId.TextChanged
        Try
            query = "SELECT * FROM `users` WHERE `UserId`='" & lblUserId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                txtFullName.Text = dt.Rows(0).Item("FullName")
                dtpBirthdate.Value = dt.Rows(0).Item("Birthdate")
                txtAddress.Text = dt.Rows(0).Item("Address")
                txtContactNum.Text = dt.Rows(0).Item("ContactNumber")
                txtUsername.Text = dt.Rows(0).Item("Username")
                txtPassword.Text = dt.Rows(0).Item("Password")
                If dt.Rows(0).Item("Sex") = "Male" Then
                    rdoMale.Checked = True
                Else
                    rdoFemale.Checked = True
                End If

                If dt.Rows(0).Item("UserTypeId") = "1" Then
                    rdoadmin.Checked = True
                Else
                    rdouser.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Backup()
        Try
            If Not Directory.Exists(BackupPath) Then
                Directory.CreateDirectory(BackupPath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Process.Start("C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe", "--replace --column-statistics=0 -u root -proot --databases gymdb -r """ & BackupPath & "" & DatabaseName & ".sql""")
        MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")
    End Sub

    Sub Restore()
        Dim myProcess As New Process()

        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 8.0\bin"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.Start()
        Dim myStreamerWriter As StreamWriter = myProcess.StandardInput
        Dim myStreamerReader As StreamReader = myProcess.StandardOutput
        myStreamerWriter.WriteLine("mysql -u root -proot gymdb < " & Path & "")
        myStreamerWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        FolderBrowserDialog1.ShowDialog()
        BackupPath = FolderBrowserDialog1.SelectedPath.ToString() + "\"
        Backup()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Path = OpenFileDialog1.FileName.ToString()
        Restore()
        MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.ShowDialog()
    End Sub
End Class