Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (IsNumeric(TextBox1.Text) And IsNumeric(TextBox3.Text)) Then
            TextBox2.Text = TextBox1.Text * 0.25
            TextBox4.Text = TextBox3.Text * 0.35
            TextBox5.Text = "2000"
            Label22.Text = TextBox1.Text + +TextBox2.Text + +TextBox3.Text + +TextBox4.Text + +TextBox5.Text
            Label18.Text = TextBox1.Text * 0.12
            Label19.Text = TextBox1.Text * 0.0833
            Label20.Text = TextBox1.Text * 0.1
            Label21.Text = TextBox1.Text * 0.05
            If (IsNumeric(TextBox6.Text) And IsNumeric(TextBox7.Text)) Then
                Label23.Text = Label18.Text + +Label19.Text + +Label20.Text + +Label21.Text + +TextBox6.Text + +TextBox7.Text
            End If
            If (IsNumeric(Label22.Text) And IsNumeric(Label23.Text)) Then
                Label24.Text = Convert.ToInt32(Label22.Text - Label23.Text)
            End If
        Else
            MsgBox("Invalid Input")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        Label22.Text = ""
        Label23.Text = ""
        Label24.Text = ""
    End Sub
End Class
