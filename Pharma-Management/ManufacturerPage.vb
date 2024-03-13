Imports System.Data.SqlClient

Public Class ManufacturerPage

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malum\Documents\SizwePharmacy.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        BackMod.Back(Me)
    End Sub
    Public Sub Populate()
        Try
            Con.Open()
            Dim sqlString = "SELECT * FROM CompanyTbl"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(sqlString, Con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            dtgManufacturer.DataSource = ds.Tables(0)
            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click
        BackMod.LogOff(Me)
    End Sub

    Private Sub ManufacturerPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If txtConpanyID.Text = "" Then
                MsgBox("Please enter the Manufacturer ID.")
                Return
            End If

            Con.Open()
            Dim sqlQuery As String = "DELETE FROM CompanyTbl WHERE CompID = @CompID"
            Dim cmd As New SqlCommand(sqlQuery, Con)
            cmd.Parameters.AddWithValue("@CompID", txtConpanyID.Text)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Manufacturer deleted successfully")
            Else
                MsgBox("Manufactrer with ID " & txtConpanyID.Text & " not found.")
            End If

            Con.Close()
            Populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class