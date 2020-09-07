Public Class About_Developer_Form
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
                'Shows the Course Details Form
                Case sender Is CourseDetailToolStripMenuItem
                    Course_Details_Form.Show()
                    Me.Hide()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class