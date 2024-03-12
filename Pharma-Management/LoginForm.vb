Public Class LoginForm
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Closelbl.Click
        Application.Exit()
    End Sub

    Private Sub Clearlbl_Click(sender As Object, e As EventArgs) Handles Clearlbl.Click
        txtPassword.Clear()
        txtUserName.Clear()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub
End Class