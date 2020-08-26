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
End Class

