Imports System.Data.SqlClient

Public Class MedicinePage

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malum\Documents\SizwePharmacy.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FillCombo()
        Try
            Con.Open()
            Dim sqlQuery As String = "SELECT CompName FROM CompanyTbl"
            Dim cmd As New SqlCommand(sqlQuery, Con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Clear existing items in the combo box
            CompCb.Items.Clear()

            ' Iterate through the result set and add company names to the combo box
            While reader.Read()
                CompCb.Items.Add(reader("CompName").ToString())
            End While

            ' Close the reader
            reader.Close()
        Catch ex As Exception
            MsgBox("Error while filling combo box: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub


    Public Sub Populate()

        Con.Open()
        Dim sqlString = "SELECT * FROM MedicineTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sqlString, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dtgMedicine.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click
        Me.Hide()
        Dim log = New LoginForm
        log.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        BackMod.Back(Me)
    End Sub

    Private Sub MedicinePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            If txtMedicine.Text = "" OrElse txtBuyingPrice.Text = "" OrElse txtSellingPrice.Text = "" OrElse txtQuantity.Text = "" OrElse CompCb.SelectedIndex = -1 Then
                MsgBox("Please fill in all required fields.")
                Return
            End If

            Con.Open()
            Dim sqlQuery As String = "INSERT INTO MedicineTbl (MedName, BuyingPrice, SellingPrice, MedQty, ExpDate, Company) VALUES (@Medicine, @BuyingPrice, @SellingPrice, @Quantity, @ExpDate, @Company)"
            Dim cmd As New SqlCommand(sqlQuery, Con)
            cmd.Parameters.AddWithValue("@Medicine", txtMedicine.Text)
            cmd.Parameters.AddWithValue("@BuyingPrice", txtBuyingPrice.Text)
            cmd.Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text)
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@ExpDate", dtpExpDate.Value)
            cmd.Parameters.AddWithValue("@Company", CompCb.SelectedItem.ToString())

            cmd.ExecuteNonQuery()
            MsgBox("Medicine added successfully")
            Con.Close()
            Populate()

            ' Clear textboxes after successful addition
            txtMedicine.Text = ""
            txtBuyingPrice.Text = ""
            txtSellingPrice.Text = ""
            txtQuantity.Text = ""
            CompCb.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Error adding medicine: " & ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If txtMedicine.Text = "" Then
                MsgBox("No Medicine Selected")
            Else
                Con.Open()
                Dim sqlQuery As String = "DELETE FROM MedicineTbl WHERE MedName = @Medicine"
                Dim cmd As New SqlCommand(sqlQuery, Con)
                cmd.Parameters.AddWithValue("@Medicine", txtMedicine.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Deleted successfully")
                Con.Close()
                Populate()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            If txtBuyingPrice.Text = "" Or txtMedicine.Text = "" Or txtQuantity.Text = "" Or txtSellingPrice.Text = "" Or txtQuantity.Text = "" Then
                MsgBox("Please insert information to update")
            Else
                Con.Open()
                Dim cmd As New SqlCommand("UPDATE MedicineTbl SET BuyingPrice = @BuyingPrice, SellingPrice = @SellingPrice, MedQty = @Quantity, ExpDate = @ExpDate, Company = @Company WHERE MedName = @Medicine", Con)
                cmd.Parameters.AddWithValue("@BuyingPrice", txtBuyingPrice.Text)
                cmd.Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text)
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
                cmd.Parameters.AddWithValue("@ExpDate", dtpExpDate.Value)
                cmd.Parameters.AddWithValue("@Company", CompCb.SelectedValue)
                cmd.Parameters.AddWithValue("@Medicine", txtMedicine.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Medicine updated successfully")
                Populate()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub CompCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CompCb.SelectedIndexChanged

    End Sub
End Class