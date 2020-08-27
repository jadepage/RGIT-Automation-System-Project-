<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course_Details_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.courseDetailGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.findBtn = New System.Windows.Forms.Button()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.courseDuration = New System.Windows.Forms.TextBox()
        Me.courseFee = New System.Windows.Forms.TextBox()
        Me.courseCode = New System.Windows.Forms.TextBox()
        Me.courseName = New System.Windows.Forms.TextBox()
        Me.courseTitle = New System.Windows.Forms.TextBox()
        Me.courseID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip2.SuspendLayout()
        Me.courseDetailGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentInformationToolStripMenuItem, Me.SalaryDetailsToolStripMenuItem, Me.EmployeeInformationToolStripMenuItem, Me.FeeStructuresToolStripMenuItem, Me.CourseDetailToolStripMenuItem, Me.ReportToolStripMenuItem, Me.OpenWindowToolStripMenuItem, Me.AboutDeveloperToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(924, 24)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(50, 0, 50, 20)
        Me.Label1.Size = New System.Drawing.Size(364, 52)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "COURSE DETAILS"
        '
        'courseDetailGroupBox
        '
        Me.courseDetailGroupBox.Controls.Add(Me.GroupBox1)
        Me.courseDetailGroupBox.Controls.Add(Me.courseDuration)
        Me.courseDetailGroupBox.Controls.Add(Me.courseFee)
        Me.courseDetailGroupBox.Controls.Add(Me.courseCode)
        Me.courseDetailGroupBox.Controls.Add(Me.courseName)
        Me.courseDetailGroupBox.Controls.Add(Me.courseTitle)
        Me.courseDetailGroupBox.Controls.Add(Me.courseID)
        Me.courseDetailGroupBox.Controls.Add(Me.Label7)
        Me.courseDetailGroupBox.Controls.Add(Me.Label6)
        Me.courseDetailGroupBox.Controls.Add(Me.Label5)
        Me.courseDetailGroupBox.Controls.Add(Me.Label4)
        Me.courseDetailGroupBox.Controls.Add(Me.Label3)
        Me.courseDetailGroupBox.Controls.Add(Me.Label2)
        Me.courseDetailGroupBox.Location = New System.Drawing.Point(155, 163)
        Me.courseDetailGroupBox.Name = "courseDetailGroupBox"
        Me.courseDetailGroupBox.Size = New System.Drawing.Size(551, 342)
        Me.courseDetailGroupBox.TabIndex = 5
        Me.courseDetailGroupBox.TabStop = False
        Me.courseDetailGroupBox.Text = "Course Detail"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.exitBtn)
        Me.GroupBox1.Controls.Add(Me.clearBtn)
        Me.GroupBox1.Controls.Add(Me.deleteBtn)
        Me.GroupBox1.Controls.Add(Me.updateBtn)
        Me.GroupBox1.Controls.Add(Me.findBtn)
        Me.GroupBox1.Controls.Add(Me.submitBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 59)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(360, 20)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 13
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(292, 19)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 4
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(230, 19)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.deleteBtn.TabIndex = 3
        Me.deleteBtn.Text = "Delete "
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(158, 19)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(75, 23)
        Me.updateBtn.TabIndex = 2
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'findBtn
        '
        Me.findBtn.Location = New System.Drawing.Point(88, 19)
        Me.findBtn.Name = "findBtn"
        Me.findBtn.Size = New System.Drawing.Size(75, 23)
        Me.findBtn.TabIndex = 1
        Me.findBtn.Text = "Find"
        Me.findBtn.UseVisualStyleBackColor = True
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(18, 20)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(75, 23)
        Me.submitBtn.TabIndex = 0
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'courseDuration
        '
        Me.courseDuration.Location = New System.Drawing.Point(229, 206)
        Me.courseDuration.Name = "courseDuration"
        Me.courseDuration.Size = New System.Drawing.Size(144, 20)
        Me.courseDuration.TabIndex = 11
        '
        'courseFee
        '
        Me.courseFee.Location = New System.Drawing.Point(229, 169)
        Me.courseFee.Name = "courseFee"
        Me.courseFee.Size = New System.Drawing.Size(144, 20)
        Me.courseFee.TabIndex = 10
        '
        'courseCode
        '
        Me.courseCode.Location = New System.Drawing.Point(229, 134)
        Me.courseCode.Name = "courseCode"
        Me.courseCode.Size = New System.Drawing.Size(144, 20)
        Me.courseCode.TabIndex = 9
        '
        'courseName
        '
        Me.courseName.Location = New System.Drawing.Point(229, 96)
        Me.courseName.Name = "courseName"
        Me.courseName.Size = New System.Drawing.Size(144, 20)
        Me.courseName.TabIndex = 8
        '
        'courseTitle
        '
        Me.courseTitle.Location = New System.Drawing.Point(229, 60)
        Me.courseTitle.Name = "courseTitle"
        Me.courseTitle.Size = New System.Drawing.Size(144, 20)
        Me.courseTitle.TabIndex = 7
        '
        'courseID
        '
        Me.courseID.Location = New System.Drawing.Point(229, 20)
        Me.courseID.Name = "courseID"
        Me.courseID.Size = New System.Drawing.Size(144, 20)
        Me.courseID.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Course Duration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Course Fee"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Course Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Course Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Course Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Course ID"
        '
        'dataGridView
        '
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Location = New System.Drawing.Point(155, 535)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(551, 150)
        Me.dataGridView.TabIndex = 6
        '
        'Course_Details_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 717)
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.courseDetailGroupBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Course_Details_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College Management System - [Course Details] "
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.courseDetailGroupBox.ResumeLayout(False)
        Me.courseDetailGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents courseDetailGroupBox As GroupBox
    Friend WithEvents courseDuration As TextBox
    Friend WithEvents courseFee As TextBox
    Friend WithEvents courseCode As TextBox
    Friend WithEvents courseName As TextBox
    Friend WithEvents courseTitle As TextBox
    Friend WithEvents courseID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents exitBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents findBtn As Button
    Friend WithEvents submitBtn As Button
    Friend WithEvents dataGridView As DataGridView
End Class
