Public Class Course_Details_Form

    'Instantiating the database class 
    Dim Database As New Database

    'Check if student is logged in
    Private Sub Course_Details_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mainForm.currentUser = "Student" Then
            'Hide Submit btn
            submitBtn.Hide()
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
                'Shows the Salary Info Form
                Case sender Is Salary_Information_Form
                    Salary_Information_Form.Show()
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

    'Outputs the data from the database to the data grid
    Private Sub findBtn_Click(sender As Object, e As EventArgs) Handles findBtn.Click

        Try
            'Open database connection
            Database.OpenConnection()

            'Database table that's being accessed
            Database.Sql = "select * from Manage_Courses "

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

    'Edit the existing course
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click

        Try
            'Open database connection
            Database.OpenConnection()

            'Update the  data
            Database.Sql = "update Manage_Courses set 
            [courseID] ='" & Val(courseID.Text) & "', 
            [courseTitle] ='" & courseTitle.Text & "', 
            [courseName] ='" & courseName.Text & "', 
            [courseCode] ='" & Val(courseCode.Text) & "', 
            [courseFee] ='" & Val(courseFee.Text) & "',
            [courseDuration] ='" & courseDuration.Text & "'"

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