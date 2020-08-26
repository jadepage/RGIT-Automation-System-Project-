Public Class Student_Information_Form

    'Instantiating the database class 
    Dim Database As New Database

    'Handles The Menu
    Private Sub SalaryDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryDetailsToolStripMenuItem.Click
        Salary_Information_Form.Show()
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

    'Adds a new student
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click

        Try
            'Open database connection
            Database.OpenConnection()

            'Insert the user input into the db
            Database.Sql = "INSERT INTO Student_Management 

            (
            studentID, 
            firstName, 
            middleName, 
            lastName, 
            dateOfBirth, 
            mothersName,
            fathersName,
            bloodGroup,
            localAddress,
            permamanentAddress,
            gender,
            category,
            email,
            contactNumber 
            ) 
            values 
            (' " & Val(studentID.Text) & "', 
            ' " & firstName.Text & "', 
            '" & middleName.Text & "' , 
            '" & lastName.Text & "', 
            '" & dateOfBirth.Text & "', 
            '" & mothersName.Text & "',
            '" & fathersName.Text & "', 
            '" & bloodGroup.Text & "', 
            '" & localAddress.Text & "', 
            '" & permamanentAddress.Text & "', 
            '" & gender.Text & "', 
            '" & category.Text & "', 
            '" & email.Text & "',
            '" & Val(contactNumber.Text) & "'
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

    'Lists all the students
    Private Sub findBtn_Click(sender As Object, e As EventArgs) Handles findBtn.Click

        Try
            'Open database connection
            Database.OpenConnection()

            'Database table that's being accessed
            Database.Sql = "select * from Student_Management "

            'Handles the database connection and SQL 
            Database.HandleSQL_And_Connection()

            'Select DataAdapter command, fill and display the data to the data grid view
            DataGridView.DataSource = Database.DataTable
            Database.DisplayData()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Database.Connection.Close()
        End Try
    End Sub

    'Edit the existing students details
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click

        Try
            'Open database connection
            Database.OpenConnection()

            'Update the  data
            Database.Sql = "update Student_Management set 
            [studentID]='" & Val(studentID.Text) & "', 
            [firstName] ='" & firstName.Text & "', 
            [middleName] ='" & middleName.Text & "', 
            [lastName] ='" & lastName.Text & "',
            [dateOfBirth] ='" & dateOfBirth.Text & "', 
            [mothersName] ='" & mothersName.Text & "',
            [fathersName] ='" & fathersName.Text & "', 
            [bloodGroup] ='" & bloodGroup.Text & "', 
            [localAddress] ='" & localAddress.Text & "',
            [permamanentAddress] ='" & permamanentAddress.Text & "', 
            [gender] ='" & gender.Text & "',
            [category] ='" & category.Text & "',
            [email] ='" & email.Text & "',
            [contactNumber] ='" & Val(contactNumber.Text) & "' "


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