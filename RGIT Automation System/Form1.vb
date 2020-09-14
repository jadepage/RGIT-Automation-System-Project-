
Public Class mainForm
    Dim username, pass As String
    Dim adminName As String
    Dim studentName, studentPass As String

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Student_Information_Form.Show()
    End Sub




    'Public variable to cehck who is logged in
    Public Shared currentUser As String = ""
    Public Shared adminPass As String = ""


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles okBtn.Click

        Try
            'Admin login details
            adminName = "Admin"
            adminPass = "12345"

            'Student login details
            studentName = "160202"
            studentPass = "112233"

            username = LoginUserName.Text
            pass = LoginPassword.Text
            If username = adminName And pass = adminPass Then

                currentUser = "Admin"

                'Loads the loading page if succesfull
                Loading_Form.Show()
                Me.Hide()

            ElseIf username = studentName And pass = studentPass Then
                currentUser = "Student"

                'Loads the loading page if succesfull
                Loading_Form.Show()
                Me.Hide()

                'Check to see if user name or password is blank
            ElseIf username = "" And pass = "" Then
                MsgBox("Please enter username and password")
            ElseIf username = "" Then
                MsgBox("Please enter your username")
            ElseIf pass = "" Then
                MsgBox("Please enter your password")

                'Check to see if the admin username or password is correct
            ElseIf username <> adminName And pass <> adminPass Then
                MsgBox("Sorry wrong username and password")
            ElseIf username <> adminName And pass = adminPass Then
                MsgBox("Sorry wrong username")
            ElseIf username = adminName And pass <> adminPass Then
                MsgBox("Sorry wrong password")

                'Check to see if the student username or password is correct
            ElseIf username <> studentName And pass <> studentPass Then
                MsgBox("Sorry wrong username and password")
            ElseIf username <> studentName And pass = studentPass Then
                MsgBox("Sorry wrong username")
            ElseIf username = studentName And pass <> studentPass Then
                MsgBox("Sorry wrong password")

            End If
        Catch ex As Exception
            MsgBox("You have entered incorrect values")
        End Try

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Application.Exit()
    End Sub
End Class
