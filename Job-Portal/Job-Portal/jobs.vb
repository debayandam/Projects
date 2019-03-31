Imports System.Data.SqlClient

Public Class jobs
    Dim con As New SqlConnection
    Dim query, idd, file As String
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.DefaultExt = "jpg"
        OpenFileDialog1.Filter = "Image files(*.jpg)|*.jpg|All files(*.*)|*.*"
        If ((OpenFileDialog1.ShowDialog() = DialogResult.OK)) Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub jobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Online_Job_Portal.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        query = "Select Id, Description from Record1"
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader()
        dt = New DataTable()
        dt.Load(dr)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        idd = TextBox1.Text
        file = TextBox2.Text
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER\Documents\Online_Job_Portal.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        query = "Update Record1 set CV='" + file + "' where Id='" + idd + "'"
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Applied Successfully")
        Me.Hide()
        Fmain.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        login.Show()
    End Sub
End Class