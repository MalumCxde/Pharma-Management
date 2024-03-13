Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click

        Me.Hide()
        Dim log = New LoginForm
        log.Show()

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

        Me.Hide()
        Dim log = New MedicinePage
        log.Show()

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click

        Me.Hide()
        Dim Manufacturer = New ManufacturerPage
        Manufacturer.Show()

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

        Me.Hide()
        Dim Agent = New Agent
        Agent.Show()

    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click

        Me.Hide()
        Dim Bill = New Billing
        Bill.Show()

    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click

        Me.Hide()
        Dim analytics = New Analytics
        analytics.Show()

    End Sub
End Class