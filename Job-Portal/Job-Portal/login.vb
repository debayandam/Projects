Imports System.Data.SqlClient

Public Class login

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As SqlConnection
        Dim mydb, mystr As String
        Dim count As Integer
        mystr = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Online_Job_Portal.mdf;Integrated Security=True;Connect Timeout=30"
        connection = New SqlConnection(mystr)
        connection.Open()
        mydb = "Select Email,Password from Sign_Up where Email='" + TextBox2.Text + "' Password='" + TextBox3.Text + "'"
        Try
            If count = 0 Then
                jobs.Show()
                Me.Close()
            Else
                MsgBox("Login Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class