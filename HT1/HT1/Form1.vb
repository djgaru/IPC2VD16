﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = (Val(TextBox1.Text) + Val(TextBox2.Text)) * Val(TextBox3.Text)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = (Val(TextBox1.Text) * Val(TextBox2.Text)) - Val(TextBox3.Text)
    End Sub

  

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Text = (Val(TextBox1.Text) + Val(TextBox2.Text)) - Val(TextBox3.Text) & "_" & "201021195"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox4.Text = (Val(TextBox1.Text) - Val(TextBox2.Text)) * Val(TextBox3.Text)
    End Sub
End Class
