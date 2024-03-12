Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(3)
        If ProgressBar.Value = 100 Then
            Me.Hide()
            Dim log = New LoginForm
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ProgressBar_ValueChanged(sender As Object, e As EventArgs) Handles ProgressBar.ValueChanged

    End Sub
End Class
