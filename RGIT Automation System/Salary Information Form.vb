Public Class Salary_Information_Form

    'Instantiating the database class 
    Dim Database As New Database

    Private Sub Salary_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Handles The Menu
    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentInformationToolStripMenuItem.Click
        Student_Information_Form.Show()
        Me.Hide()
    End Sub

    Private Sub EmployeeInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeInformationToolStripMenuItem.Click
        Employee_Information_Form.Show()
        Me.Hide()
    End Sub

    Public Sub FeeStructuresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeeStructuresToolStripMenuItem.Click
        Fees_Information_Form.Show()
        Me.Hide()
    End Sub

    Private Sub CourseDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseDetailToolStripMenuItem.Click
        Course_Details_Form.Show()
        Me.Hide()
    End Sub


    'Outputs the data from the database to the data grid
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Try
            'Open database connection
            Database.OpenConnection()

            'Database table that's being accessed
            Database.Sql = "select * from Manage_Salary  "

            'Handles the database connection and SQL 
            Database.HandleSQL_And_Connection()

            'Select DataAdapter command, fill and display the data to the data grid view
            dataGridView.DataSource = Database.DataTable
            Database.DisplayData()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Database.Connection.Close()
        End Try

    End Sub

    'Adds a salary of the employee
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Try
            'Open database connection
            Database.OpenConnection()

            'Insert the user input into the db
            Database.Sql = "INSERT INTO Manage_Salary 

            (
            employeeID,
            salaryID,
            salaryDate,
            employeeAmount, 
            employeeMonth, 
            employeeIsPaid,
            dueAmount
            ) 
            values 
            (' " & Val(employeeID.Text) & "', 
            ' " & Val(salaryID.Text) & "', 
            ' " & salaryDate.Value.ToShortDateString & "', 
            '" & Val(employeeAmount.Text) & "', 
            '" & employeeMonth.Text & "' , 
            '" & employeeIsPaid.Text & "', 
            '" & Val(dueAmount.Text) & "'
            )"

            'Handles the database connection and SQL 
            Database.HandleSQL_And_Connection()

            'Check if data was successfully submitted 
            Database.CheckDataSuccess()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Database.Connection.Close()
        End Try
    End Sub

    'Edit the existing employee salary
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try
            'Open database connection
            Database.OpenConnection()

            'Update the  data
            Database.Sql = "update Employee_Faculty set 
            [employeeID] ='" & Val(employeeID.Text) & "', 
            [salaryID] ='" & Val(salaryID.Text) & "', 
            [salaryDate] ='" & salaryDate.Value.ToShortDateString & "', 
            [employeeAmount] ='" & Val(employeeAmount.Text) & "', 
            [employeeMonth] ='" & employeeMonth.Text & "',
            [employeeIsPaid] ='" & employeeIsPaid.Text & "', 
            [dueAmount] ='" & dueAmount.Text & "'"

            'Handles the database connection and SQL 
            Database.HandleSQL_And_Connection()

            'Check if the record was updated successfully
            Database.CheckUpdateSuccess()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Database.Connection.Close()
        End Try
    End Sub
End Class

