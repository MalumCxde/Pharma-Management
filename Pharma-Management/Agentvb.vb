Imports System.Data.SqlClient

Public Class Agent
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malum\Documents\SizwePharmacy.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        BackMod.Back(Me)
    End Sub
    Public Sub Populate()
        Try
            Con.Open()
            Dim sqlString = "SELECT * FROM EmployeeTbl"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(sqlString, Con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            dtgAgent.DataSource = ds.Tables(0)
            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtEmployeeName.Text = "" OrElse txtEmployeeAge.Text = "" OrElse txtEmployeeID.Text = "" OrElse txtEmployeeSalary.Text = "" OrElse txtPhoneNumber.Text = "" OrElse txtPassword.Text = "" Then
            MsgBox("Please fill in all required fields.")
            Return
        End If

    End Sub

    Private Sub Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
End Class