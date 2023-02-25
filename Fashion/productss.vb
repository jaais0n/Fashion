Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class test1

    Public Sub New(pic As Image, name As String)
        Dim price = BunifuLabel1
        InitializeComponent()
        PictureBox1.Image = pic
        BunifuLabel2.Text = name


        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-UEAJQU3\SQLEXPRESS;Initial Catalog=Fashion1;Integrated Security=True")
        Dim command As New SqlCommand("SELECT  [price] FROM [dbo].[men] WHERE name = @name", con)
        command.Parameters.AddWithValue("@name", name)
        Dim reader As SqlDataReader
        con.Open()
        reader = command.ExecuteReader
        If reader.Read() Then

            BunifuLabel1.Text = reader("price").ToString()
        Else
            MessageBox.Show("incorrect")
        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click

        If ComboBox1.Text = Nothing Or ComboBox2.Text = Nothing Then
            MessageBox.Show("Fill The Details")
        Else
            Men.Hide()
            Me.Hide()
            payment.Show()
        End If


    End Sub

    Private Sub test1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class