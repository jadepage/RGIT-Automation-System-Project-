Public Class Database

    'Connection to the database
    Public Property Connection() As New OleDb.OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\djfun\vb\RGIT_DB.mdb")

    'Database command
    Public Property Cmd() As New OleDb.OleDbCommand

    'Sql statement
    Public Property Sql As String

    'Datatable used to display data from the database
    Public Property DataTable() As New DataTable

    'The adapter used to make changes to the data
    Public Property DataAdapter() As New OleDb.OleDbDataAdapter

    'Test and connect to the databasae
    Public Sub OpenConnection()
        Try
            Connection.Open()

            If Connection.State = ConnectionState.Open Then
                MsgBox("Connected to DB is successfull")

            Else
                MsgBox("Connection failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ' Check if the data was successfully submitted
    Public Sub CheckDataSuccess()
        Dim i As Integer

        i = Cmd.ExecuteNonQuery()

        If i > 0 Then
            MsgBox("Your Data was submitted successfully")
        Else
            MsgBox("Your Data was not submitted")
        End If
    End Sub

    ' Check if the record was updated
    Public Sub CheckUpdateSuccess()
        Dim i As Integer

        i = Cmd.ExecuteNonQuery()

        If i > 0 Then
            MsgBox("Record updated successfully")
        Else
            MsgBox("Your record was not updated")
        End If
    End Sub

    'Handles the database connection and SQL 
    Public Sub HandleSQL_And_Connection()
        Cmd.Connection = Connection
        Cmd.CommandText = Sql
    End Sub

    'Select DataAdapter command, fill and fill the table
    Public Sub DisplayData()
        DataAdapter.SelectCommand = Cmd
        DataAdapter.Fill(DataTable)

    End Sub


End Class
