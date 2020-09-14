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
            'Hide admin button
            adminLink.Hide()
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


    'Display the data from the database in the textbox
    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

        studentID.Text = DataGridView.CurrentRow.Cells(0).Value
        firstName.Text = DataGridView.CurrentRow.Cells(1).Value
        middleName.Text = DataGridView.CurrentRow.Cells(2).Value
        lastName.Text = DataGridView.CurrentRow.Cells(3).Value
        mothersName.Text = DataGridView.CurrentRow.Cells(4).Value
        dateOfBirth.Text = DataGridView.CurrentRow.Cells(5).Value
        fathersName.Text = DataGridView.CurrentRow.Cells(6).Value
        bloodGroup.Text = DataGridView.CurrentRow.Cells(7).Value
        localAddress.Text = DataGridView.CurrentRow.Cells(8).Value
        permamanentAddress.Text = DataGridView.CurrentRow.Cells(9).Value
        gender.Text = DataGridView.CurrentRow.Cells(10).Value
        category.Text = DataGridView.CurrentRow.Cells(11).Value
        email.Text &= DataGridView.CurrentRow.Cells(12).Value
        contactNumber.Text = DataGridView.CurrentRow.Cells(13).Value
    End Sub

    'Clear the textboxes after the data has been submitted/updated
    Public Sub clearText()
        studentID.Text = ""
        firstName.Text = ""
        middleName.Text = ""
        lastName.Text = ""
        mothersName.Text = ""
        dateOfBirth.Text = ""
        fathersName.Text = ""
        bloodGroup.Text = ""
        localAddress.Text = ""
        permamanentAddress.Text = ""
        gender.Text = ""
        category.Text = ""
        email.Text = ""
        contactNumber.Text = ""
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
            clearText()
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
            clearText()
        End Try
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click

        Try
            'Open DB Connection
            Database.OpenConnection()

            'Which record to be deleted
            If DataGridView.CurrentRow.Cells(0).Selected Then
                Database.Sql = "DELETE from Student_Management where [studentID] = " & Val(studentID.Text) & ""
            ElseIf DataGridView.CurrentRow.Cells(1).Selected Then
                Database.Sql = "DELETE from Student_Management where [firstName] = " & firstName.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(2).Selected Then
                Database.Sql = "DELETE from Student_Management where [middleName] = " & middleName.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(3).Selected Then
                Database.Sql = "DELETE from Student_Management where [middleName] = " & middleName.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(4).Selected Then
                Database.Sql = "DELETE from Student_Management where [lastName] = " & lastName.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(5).Selected Then
                Database.Sql = "DELETE from Student_Management where [dateOfBirth] = " & dateOfBirth.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(6).Selected Then
                Database.Sql = "DELETE from Student_Management where [mothersName] = " & mothersName.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(7).Selected Then
                Database.Sql = "DELETE from Student_Management where [fathersName] = " & fathersName.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(8).Selected Then
                Database.Sql = "DELETE from Student_Management where [bloodGroup] = " & bloodGroup.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(9).Selected Then
                Database.Sql = "DELETE from Student_Management where [localAddress] = " & localAddress.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(10).Selected Then
                Database.Sql = "DELETE from Student_Management where [permamanentAddress] = " & permamanentAddress.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(11).Selected Then
                Database.Sql = "DELETE from Student_Management where [gender] = " & gender.Text & ""
            ElseIf DataGridView.CurrentRow.Cells(12).Selected Then
                Database.Sql = "DELETE from Student_Management where [category] = " & Val(category.Text) & ""
            ElseIf DataGridView.CurrentRow.Cells(13).Selected Then
                Database.Sql = "DELETE from Student_Management where [contactNumber] = " & Val(contactNumber.Text) & ""
            End If

            'Handles the database connection and SQL 
            Database.HandleSQL_And_Connection()

            'Checks if the record was deleted
            Database.CheckDeleteSuccess()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'Close the connection
            Database.Connection.Close()
            'Clear text
            clearText()
        End Try

    End Sub

    'Clears the textboxes
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearText()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles adminLink.Click
        Admin_Form.Show()
        Me.Hide()
    End Sub
End Class