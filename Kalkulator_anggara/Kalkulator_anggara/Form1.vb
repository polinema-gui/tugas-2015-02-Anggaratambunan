﻿Public Class Form1
    Dim input_angka1 As Single
    Dim input_angka2 As Single
    Dim memanggil_angka As Single
    Dim rumus As String

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "0"
        Else
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text > "0" Then
            TextBox1.Text = TextBox1.Text & "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        input_angka1 = Val(TextBox1.Text)
        TextBox1.Text = "0"
        rumus = "-"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        input_angka1 = Val(TextBox1.Text)
        TextBox1.Text = "0"
        rumus = "+"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        input_angka1 = Val(TextBox1.Text)
        TextBox1.Text = "0"
        rumus = "*"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        input_angka1 = Val(TextBox1.Text)
        TextBox1.Text = "0"
        rumus = "/"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        input_angka2 = Val(TextBox1.Text)
        If rumus = "+" Then
            memanggil_angka = input_angka1 + input_angka2
        End If
        input_angka2 = Val(TextBox1.Text)
        If rumus = "-" Then
            memanggil_angka = input_angka1 - input_angka2
        End If
        input_angka2 = Val(TextBox1.Text)
        If rumus = "*" Then
            memanggil_angka = input_angka1 * input_angka2
        End If
        input_angka2 = Val(TextBox1.Text)
        If rumus = "/" Then
            memanggil_angka = input_angka1 / input_angka2
        End If
        TextBox1.Text = memanggil_angka
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = "0"
    End Sub
End Class
