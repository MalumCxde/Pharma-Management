Imports System.Data.SqlClient

Public Class LoginForm
   
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Closelbl.Click
        Application.Exit()
    End Sub

    Private Sub Clearlbl_Click(sender As Object, e As EventArgs) Handles Clearlbl.Click
        txtPassword.Clear()
        txtUserName.Clear()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim username As String = txtUserName.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim Con = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malum\Documents\SizwePharmacy.mdf;Integrated Security=True;Connect Timeout=30")

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        Try
            Using connection As New SqlConnection(Con)
                connection.Open()
                Dim query As String = "SELECT EmpPassword FROM EmployeeTbl WHERE EmpName = @EmpName"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmpName", username)
                    Dim dbPassword As String = command.ExecuteScalar()?.ToString()
                    If dbPassword IsNot Nothing AndAlso password = dbPassword Then
                        Me.Hide() ' Hide the login form
                        Dim home As New Home()
                        home.Show() ' Show the home form
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class