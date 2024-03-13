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

        Try
            If txtEmployeeName.Text = "" OrElse txtEmployeeAge.Text = "" OrElse txtEmployeeID.Text = "" OrElse txtEmployeeSalary.Text = "" OrElse txtPhoneNumber.Text = "" OrElse txtPassword.Text = "" Then
                MsgBox("Please fill in all required fields.")
                Return
            End If

            Con.Open()
            Dim sqlQuery As String = "INSERT INTO EmployeeTbl (EmpID, EmpName, EmpSalary, EmpAge, EmpPhone, EmpPassword) VALUES (@EmpID, @EmpName, @EmpSalary, @EmpAge, @EmpPhone, @EmpPassword)"
            Dim cmd As New SqlCommand(sqlQuery, Con)
            cmd.Parameters.AddWithValue("@EmpID", txtEmployeeID.Text)
            cmd.Parameters.AddWithValue("@EmpName", txtEmployeeName.Text)
            cmd.Parameters.AddWithValue("@EmpSalary", txtEmployeeSalary.Text)
            cmd.Parameters.AddWithValue("@EmpAge", txtEmployeeAge.Text)
            cmd.Parameters.AddWithValue("@EmpPhone", txtPhoneNumber.Text)
            cmd.Parameters.AddWithValue("@EmpPassword", txtPassword.Text)

            cmd.ExecuteNonQuery()
            MsgBox("Employee added successfully")
            Con.Close()
            Populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            If txtEmployeeName.Text = "" OrElse txtEmployeeAge.Text = "" OrElse txtEmployeeID.Text = "" OrElse txtEmployeeSalary.Text = "" OrElse txtPhoneNumber.Text = "" OrElse txtPassword.Text = "" Then
                MsgBox("Please fill in all required fields.")
                Return
            End If

            Con.Open()
            Dim sqlQuery As String = "UPDATE EmployeeTbl SET EmpID = @EmpID, EmpName = @EmpName, EmpSalary = @EmpSalary, EmpAge = @EmpAge, EmpPhone = @EmpPhone, EmpPassword = @EmpPassword"
            Dim cmd As New SqlCommand(sqlQuery, Con)
            cmd.Parameters.AddWithValue("@EmpID", txtEmployeeID.Text)
            cmd.Parameters.AddWithValue("@EmpName", txtEmployeeName.Text)
            cmd.Parameters.AddWithValue("@EmpSalary", txtEmployeeSalary.Text)
            cmd.Parameters.AddWithValue("@EmpAge", txtEmployeeAge.Text)
            cmd.Parameters.AddWithValue("@EmpPhone", txtPhoneNumber.Text)
            cmd.Parameters.AddWithValue("@EmpPassword", txtPassword.Text)

            cmd.ExecuteNonQuery()
            MsgBox("Employee added successfully")
            Con.Close()
            Populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click
        BackMod.LogOff(Me)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If txtEmployeeID.Text = "" Then
                MsgBox("Please enter the Employee ID.")
                Return
            End If

            Con.Open()
            Dim sqlQuery As String = "DELETE FROM EmployeeTbl WHERE EmpID = @EmpID"
            Dim cmd As New SqlCommand(sqlQuery, Con)
            cmd.Parameters.AddWithValue("@EmpID", txtEmployeeID.Text)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Employee deleted successfully")
            Else
                MsgBox("Employee with ID " & txtEmployeeID.Text & " not found.")
            End If

            Con.Close()
            Populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class