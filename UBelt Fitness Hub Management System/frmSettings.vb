Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmSettings
    Public con As MySqlConnection = mysqldb()
    Dim Path As String
    Dim BackupPath As String
    Dim DatabaseName As String = "gymdb" + Date.Now.ToString("dd-MM-yyyy-HH-mm-ss")
    Public user_id As String
    Dim rdoad As String = ""
    Dim index As Integer = 0
    Private Sub tpAccountDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_UserRecords()

        dgvUserRecords.RowTemplate.Height = 30
        dgvUserRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvUserRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUserRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_UserRecords()
        query = "SELECT `UserId` AS 'User ID',`FullName` as 'Full Name' FROM `users`"
        reloadDgv(query, dgvUserRecords)
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
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
#Region "BackUp and Restore"
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
#End Region
#Region "Create Account"

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = False Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
        End If
    End Sub
    Private Sub chkSecretAnswer_CheckedChanged(sender As Object, e As EventArgs) Handles chkSecretAnswer.CheckedChanged
        If chkSecretAnswer.Checked = False Then
            txtSecretAnswer.PasswordChar = "*"
        Else
            txtSecretAnswer.PasswordChar = ""
        End If
    End Sub
#End Region
    Private Sub lblUserId_TextChanged(sender As Object, e As EventArgs) Handles lblUserId.TextChanged
        Try
            query = "SELECT * FROM `users` WHERE `UserId`='" & lblUserId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                txtFullName.Text = dt.Rows(0).Item("FullName")
                txtUsername.Text = dt.Rows(0).Item("Username")
                txtPassword.Text = dt.Rows(0).Item("Password")
                cmbSecretQuestion.Text = dt.Rows(0).Item("SecretQuestion")
                txtSecretAnswer.Text = dt.Rows(0).Item("SecretAnswer")
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
    Private Sub CheckingUsername()
        Try
            con.Open()
            Dim query As String
            query = "SELECT Username FROM users WHERE Username = '" & txtUsername.Text & "'"
            cmd = New MySqlCommand(query, con)
            dr = cmd.ExecuteReader()
            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            Select Case count
                Case 1
                    MsgBox("Username is already exist. Please try another username!", MsgBoxStyle.Critical, "ATTENTION")
                Case Else
                    con.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtFullName.Text = "" And txtUsername.Text = "" And txtPassword.Text = "" And rdoad = "" And cmbSecretQuestion.Text = "" And txtSecretAnswer.Text = "" Then
            MsgBox("Fill up your account details", MsgBoxStyle.Critical, "ATTENTION!")
            txtFullName.Focus()
        ElseIf txtFullName.Text = "" Then
            MsgBox("No Full Name Found!", MsgBoxStyle.Critical, "Error")
            txtFullName.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("No Password Found!", MsgBoxStyle.Critical, "Error")
            txtPassword.Focus()
        ElseIf rdoadmin.Text = "" Or rdouser.Text = "" Then
            MsgBox("Please Select User Type", MsgBoxStyle.Critical, "Error")
            rdoadmin.Focus()
        ElseIf cmbSecretQuestion.Text = "" Then
            MsgBox("No Secret Question Found!", MsgBoxStyle.Critical, "Error")
            cmbSecretQuestion.Focus()
        ElseIf txtSecretAnswer.Text = "" Then
            MsgBox("No Secret Answer Found!", MsgBoxStyle.Critical, "Error")
            txtSecretAnswer.Focus()
        Else
            CreatingAccount()
        End If
    End Sub
    Private Sub CreatingAccount()
        Try
            query = "SELECT * FROM `users` WHERE `UserId`='" & lblUserId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                If rdoadmin.Checked = True Then
                    rdoad = "1"
                Else
                    rdoad = "2"
                End If
                query = "UPDATE `users` SET  `FullName`='" & txtFullName.Text _
                   & "', `Username`='" & txtUsername.Text & "', `Password`='" & txtPassword.Text _
                   & "', `SecretQuestion`='" & cmbSecretQuestion.Text & "', `SecretAnswer`='" & txtSecretAnswer.Text _
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

                If rdoadmin.Checked = True Then
                    rdoad = "1"
                Else
                    rdoad = "2"
                End If

                query = "INSERT INTO users (`UserId`, `FullName`, `Username`, `Password`, `SecretQuestion`" _
                & ", `SecretAnswer`, `UserTypeId`) VALUES ('" & user_id & "', '" & txtFullName.Text _
                & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & cmbSecretQuestion.Text _
                & "', '" & txtSecretAnswer.Text & "', '" & rdoad & "')"
                create(query, txtFullName.Text)
                CheckingUsername()
            End If
            load_UserRecords()
            cleartext(gbUser)
            setup(gbUser)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class