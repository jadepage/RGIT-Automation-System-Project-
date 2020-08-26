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

    'Adds the student fees
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Try
            'Open database connection
            Database.OpenConnection()

            'Insert the user input into the db
            Database.Sql = "INSERT INTO Fees_Management 

            (
            feesID, 
            studentID, 
            paymentType, 
            feesDate, 
            feesMonth, 
            feesYear,
            feesAmount
            ) 
            values 
            (' " & Val(feesID.Text) & "', 
            ' " & Val(studentID.Text) & "', 
            '" & paymentType.Text & "' , 
            '" & feesDate.Text & "', 
            '" & feesMonth.Text & "', 
            '" & feesYear.Text & "',
            '" & Val(feesAmount.Text) & "'
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