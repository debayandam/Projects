Imports System.Data.SqlClient

Public Class Register

    Dim name1, email, password, address, query, mobile As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connetionString As String
        Dim connection As SqlConnection
        Dim query As New SqlCommand

        name1 = TextBox1.Text
        email = TextBox2.Text
        password = TextBox3.Text
        mobile = TextBox4.Text
        address = TextBox5.Text
        Try
            connetionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Online_Job_Portal.mdf;Integrated Security=True;Connect Timeout=30"
            connection = New SqlConnection(connetionString)
            connection.Open()
            query = New SqlCommand("Insert into Sign_Up(Name,Mobile,Email,Address,Password) values ('" + TextBox1.Text + "','" + TextBox4.Text + "','" + TextBox2.Text + "','" + TextBox5.Text + "','" + TextBox3.Text + "')", connection)
            query.ExecuteNonQuery()
            MessageBox.Show("Registration Successful")
            connection.Close()
            jobs.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Fmain.Show()
    End Sub
End Class