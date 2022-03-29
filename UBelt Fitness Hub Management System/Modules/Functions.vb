Module Functions
    Public Sub closeChildForm()
        For Each frm As Form In frmDashboard.MdiChildren()
            frm.Close()
        Next
    End Sub
    Public Sub showForm(frm As Form)
        With frm
            .MdiParent = frmDashboard
            .Show()
        End With
    End Sub
    Public Sub cleartext(ByVal obj As Object)
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(RadioButton) Then
                ctrl.Controls.Clear()
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                ctrl.Controls.Clear()
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(DateTimePicker) Then
                ctrl.Text = Now
            End If
        Next
    End Sub
    Public Sub setup(ByVal obj As Object)
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(DateTimePicker) Then
                ctrl.Text = Now
            End If
        Next
    End Sub
End Module
