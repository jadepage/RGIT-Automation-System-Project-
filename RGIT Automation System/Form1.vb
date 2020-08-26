Public Class mainForm
    Dim username As String
    Dim pass As String
    Dim correctName As String
    Dim correctPass As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles okBtn.Click

        Try
            correctName = "Admin"
            correctPass = "12345"
            username = LoginUserName.Text
            pass = LoginPassword.Text
            If username = correctName And pass = correctPass Then

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

                'Check to see if the username or password is correct
            ElseIf username <> correctName And pass <> correctPass Then
                MsgBox("Sorry wrong username and password")
            ElseIf username <> correctName And pass = correctPass Then
                MsgBox("Sorry wrong username")
            ElseIf username = correctName And pass <> correctPass Then
                MsgBox("Sorry wrong password")

            End If
        Catch ex As Exception
            MsgBox("You have entered incorrect values")
        End Try

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Application.Exit()
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employee_Information_Form.Show()
    End Sub
End Class
