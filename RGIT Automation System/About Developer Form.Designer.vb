<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class About_Developer_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About_Developer_Form))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeStructuresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentInformationToolStripMenuItem, Me.SalaryDetailsToolStripMenuItem, Me.EmployeeInformationToolStripMenuItem, Me.FeeStructuresToolStripMenuItem, Me.CourseDetailToolStripMenuItem, Me.ReportToolStripMenuItem, Me.OpenWindowToolStripMenuItem, Me.AboutDeveloperToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1025, 24)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.StudentInformationToolStripMenuItem.Text = "Student Information"
        '
        'SalaryDetailsToolStripMenuItem
        '
        Me.SalaryDetailsToolStripMenuItem.Name = "SalaryDetailsToolStripMenuItem"
        Me.SalaryDetailsToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.SalaryDetailsToolStripMenuItem.Text = "Salary Details"
        '
        'EmployeeInformationToolStripMenuItem
        '
        Me.EmployeeInformationToolStripMenuItem.Name = "EmployeeInformationToolStripMenuItem"
        Me.EmployeeInformationToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.EmployeeInformationToolStripMenuItem.Text = "Employee Information"
        '
        'FeeStructuresToolStripMenuItem
        '
        Me.FeeStructuresToolStripMenuItem.Name = "FeeStructuresToolStripMenuItem"
        Me.FeeStructuresToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.FeeStructuresToolStripMenuItem.Text = "Fee Structures"
        '
        'CourseDetailToolStripMenuItem
        '
        Me.CourseDetailToolStripMenuItem.Name = "CourseDetailToolStripMenuItem"
        Me.CourseDetailToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.CourseDetailToolStripMenuItem.Text = "Course Details"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'OpenWindowToolStripMenuItem
        '
        Me.OpenWindowToolStripMenuItem.Name = "OpenWindowToolStripMenuItem"
        Me.OpenWindowToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.OpenWindowToolStripMenuItem.Text = "Open Window"
        '
        'AboutDeveloperToolStripMenuItem
        '
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.AboutDeveloperToolStripMenuItem.Text = "About Developer"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'About_Developer_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1025, 714)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "About_Developer_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About_Developer_Form"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents StudentInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeeStructuresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseDetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutDeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
End Class
