Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Analytics
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malum\Documents\SizwePharmacy.mdf;Integrated Security=True;Connect Timeout=30"


    Private Sub Analytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClearChart()

    End Sub


    Private Sub btnMedicineData_Click(sender As Object, e As EventArgs) Handles btnMedicineData.Click

        DisplayMedicineQuantity()

    End Sub
    Private Sub ClearChart()
        ' Clear any existing data bound to the chart
        chtData.DataSource = Nothing
        chtData.Series.Clear()
        chtData.Visible = False
    End Sub
    Private Sub DisplayMedicineQuantity()
        ' Retrieve medicine data from the database
        Dim medicineData As DataTable = GetMedicineDataFromDatabase()

        ' Clear any existing series and points from the chart
        chtData.Series.Clear()

        ' Create a new series for the chart
        Dim series As New Series("MedicineQuantity")
        series.ChartType = SeriesChartType.Column

        ' Add data points to the series
        For Each row As DataRow In medicineData.Rows
            Dim xValue As String = row("MedName").ToString()

            ' Check if the MedQty value is not DBNull and can be cast to integer
            If Not IsDBNull(row("MedQty")) Then
                Dim yValue As Integer
                If Integer.TryParse(row("MedQty").ToString(), yValue) Then
                    series.Points.AddXY(xValue, yValue)
                End If
            End If
        Next

        ' Add the series to the chart
        chtData.Series.Add(series)

        ' Set axis titles
        chtData.ChartAreas(0).AxisX.Title = "Medicine Name"
        chtData.ChartAreas(0).AxisY.Title = "Quantity"

        ' Show the chart
        chtData.Visible = True
    End Sub




    Private Function GetMedicineDataFromDatabase() As DataTable
        Dim dataTable As New DataTable()

        ' Connection string to connect to the database

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT MedName, MedQty FROM MedicineTbl" ' Include the MedQty column in the query
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    dataTable.Load(reader)
                End Using
            End Using
        End Using

        Return dataTable
    End Function
    Private Sub DisplayEmployeeData()
        ' Retrieve employee data from the database
        Dim employeeData As DataTable = GetEmployeeDataFromDatabase()

        ' Clear any existing series and points from the chart
        chtData.Series.Clear()

        ' Create a new series for the chart
        Dim series As New Series("EmployeeData")
        series.ChartType = SeriesChartType.Point ' Set the chart type to scatter plot

        ' Add data points to the series
        For Each row As DataRow In employeeData.Rows
            ' Check if EmpSalary and EmpAge values are not DBNull and can be cast to double
            If Not IsDBNull(row("EmpSalary")) AndAlso Not IsDBNull(row("EmpAge")) Then
                Dim xValue As Double
                Dim yValue As Double
                If Double.TryParse(row("EmpSalary").ToString(), xValue) AndAlso Double.TryParse(row("EmpAge").ToString(), yValue) Then
                    series.Points.AddXY(xValue, yValue)
                End If
            End If
        Next

        ' Add the series to the chart
        chtData.Series.Add(series)

        ' Set axis titles
        chtData.ChartAreas(0).AxisX.Title = "Employee Salary"
        chtData.ChartAreas(0).AxisY.Title = "Employee Age"

        ' Show the chart
        chtData.Visible = True
    End Sub
    Private Function GetEmployeeDataFromDatabase() As DataTable

        ' Create a DataTable to store the retrieved data
        Dim employeeData As New DataTable()

        ' Define the SQL query to retrieve EmpSalary and EmpAge from the EmployeeTbl table
        Dim query As String = "SELECT EmpSalary, EmpAge FROM EmployeeTbl"

        ' Create a SqlConnection and SqlCommand objects
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Open the database connection
                connection.Open()

                ' Execute the SQL query and fill the DataTable with the retrieved data
                Using reader As SqlDataReader = command.ExecuteReader()
                    employeeData.Load(reader)
                End Using
            End Using
        End Using

        ' Return the populated DataTable
        Return employeeData
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnEmployeeData.Click

        DisplayEmployeeData()

    End Sub
    Private Sub DisplayMedicinePrices()
        ' Retrieve medicine data from the database
        Dim medicineData As DataTable = GetMedicinePriceDataFromDatabase()

        ' Clear any existing series and points from the chart
        chtData.Series.Clear()

        ' Create a new series for the chart
        Dim series As New Series("MedicinePrices")
        series.ChartType = SeriesChartType.Point ' Set the chart type to scatter plot

        ' Add data points to the series
        For Each row As DataRow In medicineData.Rows
            ' Check if BuyingPrice and SellingPrice values are not DBNull and can be cast to double
            If Not IsDBNull(row("BuyingPrice")) AndAlso Not IsDBNull(row("SellingPrice")) Then
                Dim xValue As Double
                Dim yValue As Double
                If Double.TryParse(row("BuyingPrice").ToString(), xValue) AndAlso Double.TryParse(row("SellingPrice").ToString(), yValue) Then
                    series.Points.AddXY(xValue, yValue)
                End If
            End If
        Next

        ' Add the series to the chart
        chtData.Series.Add(series)

        ' Set axis titles
        chtData.ChartAreas(0).AxisX.Title = "Buying Price"
        chtData.ChartAreas(0).AxisY.Title = "Selling Price"

        ' Show the chart
        chtData.Visible = True
    End Sub
    Private Function GetMedicinePriceDataFromDatabase() As DataTable
        ' Create a DataTable to store the retrieved data
        Dim medicineData As New DataTable()

        ' Define the SQL query to retrieve BuyingPrice and SellingPrice from the MedicineTbl table
        Dim query As String = "SELECT BuyingPrice, SellingPrice FROM MedicineTbl"

        ' Create a SqlConnection and SqlCommand objects
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Open the database connection
                connection.Open()

                ' Execute the SQL query and fill the DataTable with the retrieved data
                Using reader As SqlDataReader = command.ExecuteReader()
                    medicineData.Load(reader)
                End Using
            End Using
        End Using

        ' Return the populated DataTable
        Return medicineData
    End Function

    Private Sub btnPriceData_Click(sender As Object, e As EventArgs) Handles btnPriceData.Click

        DisplayMedicinePrices()

    End Sub
End Class