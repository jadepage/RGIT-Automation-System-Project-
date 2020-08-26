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
            '" & dateOfBirth.Text & "', 
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

    Private Sub Employee_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class