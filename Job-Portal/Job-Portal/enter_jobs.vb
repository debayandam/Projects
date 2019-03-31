Imports System.Data.SqlClient

Public Class enter_jobs

    Dim description As String
    Dim connetionString As String
    Dim connection As SqlConnection
    Dim query As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        description = TextBox1.Text
        
        Try
            connetionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Online_Job_Portal.mdf;Integrated Security=True;Connect Timeout=30"
            connection = New SqlConnection(connetionString)
            connection.Open()
            query = New SqlCommand("Insert into Record1(Description) values ('" + description + "')", connection)
            query.ExecuteNonQuery()
            MessageBox.Show("Job Added Successfully")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connetionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Online_Job_Portal.mdf;Integrated Security=True;Connect Timeout=30"
        connection = New SqlConnection(connetionString)
        connection.Open()
        query = New SqlCommand("Select * from Record1", connection)
        dr = query.ExecuteReader()
        dt = New DataTable()
        dt.Load(dr)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        admin.Show()
    End Sub
End Class