Public Class Employee_Information_Form

    'Instantiating the database class 
    Dim Database As New Database

    'Check to see if a student is logged in
    Private Sub Employee_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                'Shows the Salary Details Form
                Case sender Is SalaryDetailsToolStripMenuItem
                    Salary_Information_Form.Show()
                    Me.Hide()
                'Shows the Student Info Form
                Case sender Is StudentInformationToolStripMenuItem
                    Student_Information_Form.Show()
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

    'Adds a new employee
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
            designation,
            employeeType,
            salary
            ) 
            values 
            (' " & Val(employeeID.Text) & "', 
            ' " & employeeTitle.Text & "', 
            '" & firstName.Text & "' , 
            '" & lastName.Text & "' , 
            '" & dateOfBirth.Text & "', 
            '" & Val(mobileNumber.Text) & "', 
            '" & Val(phoneNumber.Text) & "',
            '" & email.Text & "',
            '" & permanentAddress.Text & "',
            '" & localAddress.Text & "',
            '" & employeeDesignation.Text & "',
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
        clearText()
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
            [dateOfBirth] = '" & dateOfBirth.Text & "',
            [mobileNumber] ='" & Val(mobileNumber.Text) & "',
            [phoneNumber] ='" & Val(phoneNumber.Text) & "', 
            [employeeEmail] ='" & email.Text & "',
            [permanentAddress] ='" & permanentAddress.Text & "', 
            [localAddress] ='" & localAddress.Text & "', 
            [designation] ='" & employeeDesignation.Text & "',
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

    'Fill the textboxes with the data from the db
    Private Sub dataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellContentClick
        employeeID.Text = dataGridView.CurrentRow.Cells(0).Value
        employeeTitle.Text = dataGridView.CurrentRow.Cells(1).Value
        firstName.Text = dataGridView.CurrentRow.Cells(2).Value
        lastName.Text = dataGridView.CurrentRow.Cells(3).Value
        dateOfBirth.Text = dataGridView.CurrentRow.Cells(4).Value
        mobileNumber.Text = dataGridView.CurrentRow.Cells(5).Value
        phoneNumber.Text = dataGridView.CurrentRow.Cells(6).Value
        email.Text = dataGridView.CurrentRow.Cells(7).Value
        permanentAddress.Text = dataGridView.CurrentRow.Cells(8).Value
        localAddress.Text = dataGridView.CurrentRow.Cells(9).Value
        employeeDesignation.Text = dataGridView.CurrentRow.Cells(10).Value
        employeeType.Text = dataGridView.CurrentRow.Cells(11).Value
        salary.Text &= dataGridView.CurrentRow.Cells(12).Value
    End Sub

    'Clear the textboxes after the data has been submitted
    Public Sub clearText()
        employeeID.Text = ""
        employeeTitle.Text = ""
        firstName.Text = ""
        lastName.Text = ""
        dateOfBirth.Text = ""
        mobileNumber.Text = ""
        phoneNumber.Text = ""
        email.Text = ""
        permanentAddress.Text = ""
        localAddress.Text = ""
        employeeDesignation.Text = ""
        employeeType.Text = ""
        salary.Text = ""
    End Sub

    'Clears the textboxes
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearText()
    End Sub

    'Deletes a record from the database
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Try
            'Open DB Connection
            Database.OpenConnection()

            'Which record to be deleted
            If dataGridView.CurrentRow.Cells(0).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [employeeID] = " & Val(employeeID.Text) & ""
            ElseIf dataGridView.CurrentRow.Cells(1).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [employeeTitle] = " & employeeTitle.Text & ""
            ElseIf dataGridView.CurrentRow.Cells(2).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [firstName] = " & firstName.Text & ""
            ElseIf dataGridView.CurrentRow.Cells(3).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [lastName] = " & lastName.Text & ""
            ElseIf dataGridView.CurrentRow.Cells(4).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [dateOfBirth] = " & dateOfBirth.Text & ""
            ElseIf dataGridView.CurrentRow.Cells(5).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [mobieNumber] = " & Val(mobileNumber.Text) & ""
            ElseIf dataGridView.CurrentRow.Cells(6).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [phoneNumber] = " & Val(phoneNumber.Text) & ""
            ElseIf dataGridView.CurrentRow.Cells(7).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [employeeEmail] = " & email.Text & ""
            ElseIf dataGridView.CurrentRow.Cells(8).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [permanentAddress] = " & permanentAddress.Text & ""
            ElseIf dataGridView.CurrentRow.Cells(9).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [localAddress] = " & localAddress.Text & ""
            ElseIf dataGridView.CurrentRow.Cells(10).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [designation] = " & employeeDesignation.Text & ""
            ElseIf dataGridView.CurrentRow.Cells(11).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [employeeType] = " & employeeType.Text & ""
            ElseIf dataGridView.CurrentRow.Cells(12).Selected Then
                Database.Sql = "DELETE from Employee_Faculty where [salary] = " & Val(salary.Text) & ""

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
End Class