Public Class Course_Details_Form

    'Instantiating the database class 
    Dim Database As New Database

    'Handles the menu
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

    Public Sub FeeStructuresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeeStructuresToolStripMenuItem.Click
        Fees_Information_Form.Show()
        Me.Hide()
    End Sub

    Private Sub AboutDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDeveloperToolStripMenuItem.Click
        About_Developer_Form.Show()
        About_Developer_Form2.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click

        Try
            'Open database
            Database.OpenConnection()

            'Insert the user input into the db
            Database.Sql = "INSERT INTO Manage_Courses 

            (
            courseID, 
            courseTitle, 
            courseName, 
            courseCode, 
            courseFee, 
            courseDuration
            ) 
            values 
            (' " & Val(courseID.Text) & "', 
            ' " & courseTitle.Text & "', 
            '" & courseName.Text & "' , 
            '" & Val(courseCode.Text) & "', 
            '" & Val(courseFee.Text) & "', 
            '" & courseDuration.Text & "'
            )"

            'Handles the database connection and SQL 
            Database.HandleSQL_And_Connection()

            'Check if data was successfully submitted 
            Database.CheckDataSuccess()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Database.Connection.Close()


    End Sub

End Class