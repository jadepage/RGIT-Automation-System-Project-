Public Class Salary_Information_Form

    'Instantiating the database class 
    Dim Database As New Database

    Private Sub Salary_Information_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Handles The Menu
    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentInformationToolStripMenuItem.Click
        Student_Information_Form.Show()
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

    Private Sub CourseDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseDetailToolStripMenuItem.Click
        Course_Details_Form.Show()
        Me.Hide()
    End Sub


    'Outputs the data from the database to the data grid
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click


    End Sub


End Class

