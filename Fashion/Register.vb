
Imports System.Data
Imports System.Data.SqlClient
Public Class Register
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim username As String = BunifuTextBox1.Text
        Dim password As String = BunifuTextBox2.Text
        Dim query As String = "INSERT INTO Table_3 values (@username,@password)"
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Fashion1;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        con.Open()
        If BunifuTextBox1.Text = "admin" And BunifuTextBox2.Text = "admin" Then
            BunifuTextBox2.BorderColorIdle = Color.Lime
            BunifuTextBox1.BorderColorIdle = Color.Lime
            Admin.Show()
            Me.Hide()
            Exit Sub
        End If
        If BunifuTextBox1.Text = Nothing Or BunifuTextBox2.Text = Nothing Then
            BunifuTextBox1.BorderColorIdle = Color.Red
            BunifuTextBox2.BorderColorIdle = Color.Red

            MessageBox.Show("Fill Details")
            cmd.Parameters.Clear()
            con.Close()
        Else cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Try
                cmd.ExecuteNonQuery()
                BunifuTextBox2.BorderColorIdle = Color.Lime
                BunifuTextBox1.BorderColorIdle = Color.Lime
                MessageBox.Show("Registration sucess")
                Me.Hide()
                Login.Show()

            Catch ex As Exception
                BunifuTextBox1.BorderColorIdle = Color.Red
                MessageBox.Show("Username Taken")
                con.Close()
            End Try
        End If
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class