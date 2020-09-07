Public Class Fees_Information_Form

    'Instantiating the database class 
    Dim Database As New Database



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
                'Shows the Employee Info Form
                Case sender Is EmployeeInformationToolStripMenuItem
                    Employee_Information_Form.Show()
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

    'Displays the students fees
    Private Sub findBtn_Click(sender As Object, e As EventArgs) Handles findBtn.Click

        Try
            'Open database connection
            Database.OpenConnection()

            'Database table that's being accessed
            Database.Sql = "select * from Fees_Management "

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

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try
            'Open database connection
            Database.OpenConnection()

            'Update the  data
            Database.Sql = "update Fees_Management set 
            [feesID]='" & Val(feesID.Text) & "', 
            [studentID] ='" & Val(studentID.Text) & "', 
            [paymentType] ='" & paymentType.Text & "', 
            [feesDate] ='" & feesYear.Text & "',
            [feesMonth] ='" & Val(feesAmount.Text) & "'"

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