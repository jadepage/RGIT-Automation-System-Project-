Public Class Loading_Form
    Private Sub Loading_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Timer for the progress bar
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()

            'Once the progress bar has loaded then Employee Info form is displayed
            Employee_Information_Form.Show()
        End If
    End Sub
End Class