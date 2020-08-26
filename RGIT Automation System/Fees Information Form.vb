Public Class Fees_Information_Form

    'Instantiating the database class 
    Dim Database As New Database


    'Handles The Menu
    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentInformationToolStripMenuItem.Click
        Student_Information_Form.Show()
        Me.Hide()
    End Sub

    Private Sub SalaryDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryDetailsToolStripMenuItem.Click
        Salary_Information_Form.Show()
        Me.Hide()
    End Sub
    Private Sub EmployeeInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeInformationToolStripMenuItem.Click
        Employee_Information_Form.Show()
        Me.Hide()
    End Sub

    Private Sub CourseDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseDetailToolStripMenuItem.Click
        Course_Details_Form.Show()
        Me.Hide()
    End Sub

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
End Class