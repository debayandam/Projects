Public Class admin

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text.CompareTo("administrator") = 0 And TextBox3.Text.CompareTo("123456") = 0 Then
            MsgBox("Access Granted", 0, "Authentication Successful")
            enter_jobs.Show()
        ElseIf TextBox2.Text.CompareTo("user") = 0 And TextBox3.Text.CompareTo("user") = 0 Then
            MsgBox("Access Granted", 0, "Authentication Successful")
            enter_jobs.Show()
        Else
            MsgBox("Please check Username and Password")
        End If

        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class