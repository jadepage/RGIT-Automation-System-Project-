Public Class Student_Information_Form

    'Instantiating the database class 
    Dim Database As New Database

    'Check if a student is logged in
    Private Sub Student_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mainForm.currentUser = "Student" Then
            'Hide the submit btn
            submitBtn.Hide()
            'Hide the delete btn
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
                'Shows the Salary Details Info Form
                Case sender Is SalaryDetailsToolStripMenuItem
                    Salary_Information_Form.Show()
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
            '" & dateOfBirth.Value.ToShortDateString & "', 
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
            [dateOfBirth] ='" & dateOfBirth.Value.ToShortDateString & "', 
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

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Try
            'Open database connection
            Database.OpenConnection()

            'Delete the  selected data
            Database.Sql = "DELETE * FROM Student_Management WHERE studentID = '" & DataGridView.CurrentRow.Cells(0).Value & "'"


            'Handles the database connection and SQL 
            Database.HandleSQL_And_Connection()

            'Check if the record was updated successfully
            Database.CheckDeleteSuccess()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Database.Connection.Close()
        End Try
    End Sub


End Class