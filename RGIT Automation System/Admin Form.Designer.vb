<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.newPass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(378, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hi Welcome Admin"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentInformationToolStripMenuItem, Me.SalaryDetailsToolStripMenuItem, Me.EmployeeInformationToolStripMenuItem, Me.FeeStructuresToolStripMenuItem, Me.CourseDetailToolStripMenuItem, Me.ReportToolStripMenuItem, Me.OpenWindowToolStripMenuItem, Me.AboutDeveloperToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(969, 24)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip"
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
        'newPass
        '
        Me.newPass.Location = New System.Drawing.Point(121, 57)
        Me.newPass.Name = "newPass"
        Me.newPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPass.Size = New System.Drawing.Size(179, 20)
        Me.newPass.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Location = New System.Drawing.Point(105, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.newPass)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(331, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 164)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Admin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(969, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Admin_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Form"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents newPass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
