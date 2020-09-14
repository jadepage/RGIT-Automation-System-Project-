Public Class Admin_Form
    Dim adminNewPass As String

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

    'Change admin password
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            adminNewPass = newPass.Text
            mainForm.adminPass = adminNewPass
            MsgBox("Admin passord has been succesfully changed")
            Student_Information_Form.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub





End Class