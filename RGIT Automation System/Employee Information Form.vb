Public Class Employee_Information_Form

    'Instantiating the database class 
    Dim Database As New Database


    'Handles The form
    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentInformationToolStripMenuItem.Click
        Student_Information_Form.Show()
        Me.Hide()
    End Sub

    Private Sub SalaryDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryDetailsToolStripMenuItem.Click
        Salary_Information_Form.Show()
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

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click

        Try
            'Open database
            Database.OpenConnection()

            'Insert the user input into the db
            Database.Sql = "INSERT INTO Employee_Faculty 

            (
            employeeID, 
            employeeTitle, 
            firstName,
            lastName,
            dateOfBirth, 
            mobileNumber, 
            phoneNumber,
            employeeEmail,
            permanentAddress,
            localAddress,
            employeeType,
            salary
            ) 
            values 
            (' " & Val(employeeID.Text) & "', 
            ' " & employeeTitle.Text & "', 
            '" & firstName.Text & "' , 
            '" & lastName.Text & "' , 
            '" & dateOfBirth.Value.ToShortDateString & "', 
            '" & Val(mobileNumber.Text) & "', 
            '" & Val(phoneNumber.Text) & "',
            '" & email.Text & "',
            '" & permanentAddress.Text & "',
            '" & localAddress.Text & "',
            '" & employeeType.Text & "',
            '" & Val(salary.Text) & "'
            )"

            Database.Cmd.Connection = Database.Connection
            Database.Cmd.CommandText = Database.Sql

            'Check if data was successfully submitted 
            Database.CheckDataSuccess()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Database.Connection.Close()
    End Sub

    'Lists all the employees
    Private Sub findBtn_Click(sender As Object, e As EventArgs) Handles findBtn.Click
        Try
            'Open database connection
            Database.OpenConnection()

            'Database table that's being accessed
            Database.Sql = "select * from Employee_Faculty"

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

    'Edit the existing employee
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try
            'Open database connection
            Database.OpenConnection()

            'Update the  data
            Database.Sql = "update Employee_Faculty set 
            [employeeID] ='" & Val(employeeID.Text) & "', 
            [employeeTitle] ='" & employeeTitle.Text & "', 
            [firstName] ='" & firstName.Text & "', 
            [lastName] ='" & lastName.Text & "', 
            [mobileNumber] ='" & Val(mobileNumber.Text) & "',
            [phoneNumber] ='" & Val(phoneNumber.Text) & "', 
            [employeeEmail] ='" & email.Text & "',
            [permanentAddress] ='" & permanentAddress.Text & "', 
            [localAddress] ='" & localAddress.Text & "', 
            [employeeType] ='" & employeeType.Text & "',
            [salary] ='" & Val(salary.Text) & "'"

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