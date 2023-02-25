Imports System.Data
Imports System.Data.SqlClient

Public Class UserControl4
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If BunifuTextBox1.Text = "2002" Then
            Me.Hide()

            Customer.Show()
        Else
            MessageBox.Show("Incorrect Pin")
        End If
    End Sub
End Class
