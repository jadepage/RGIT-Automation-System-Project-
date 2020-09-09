Public Class Salary_Information_Form

    'Instantiating the database class 
    Dim Database As New Database

    'Check if student is logged in
    Private Sub Salary_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mainForm.currentUser = "Student" Then
            'Hide save btn
            saveBtn.Hide()
            'Hide updateBtn
            updateBtn.Hide()
            'Hide deleteBtn
            deleteBtn.Hide()
        End If
    End Sub

    'Handles The Menu
    Public Sub ButtonClicks_Click(sender As System.Object, e As System.EventArgs) Handles StudentInformationToolStripMenuItem.Click,
            SalaryDetailsToolStripMenuItem.Click,
            EmployeeInformationToolStripMenuItem.Click,
            CourseDetailToolStripMenuItem.Click,
            FeeStructuresToolStripMenuItem.Click,
            AboutDeveloperToolStripMenuItem.Click

        Try
            'Check each case of what button was clicked
            Select Case True
                'Shows the Employee Info Form
                Case sender Is EmployeeInformationToolStripMenuItem
                    Employee_Information_Form.Show()
                    Me.Hide()
                'Shows the Student Info Form
                Case sender Is StudentInformationToolStripMenuItem
                    Student_Information_Form.Show()
                    Me.Hide()
                'Shows the Course Details Info Form
                Case sender Is CourseDetailToolStripMenuItem
                    Course_Details_Form.Show()
                    Me.Hide()
                'Shows the Fee Structure Form
                Case sender Is FeeStructuresToolStripMenuItem
                    Fees_Information_Form.Show()
                    Me.Hide()
                'Shows the About Developer Form
                Case sender Is AboutDeveloperToolStripMenuItem
                    About_Developer_Form.Show()
                    About_Developer_Form2.Show()
                    Me.Hide()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            ' " & salaryID.Text & "', 
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
            Database.Sql = "update Manage_Salary set 
            [employeeID] ='" & Val(employeeID.Text) & "', 
            [salaryID] ='" & salaryID.Text & "', 
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

