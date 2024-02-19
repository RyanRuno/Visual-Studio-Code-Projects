<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GradesListBox = New System.Windows.Forms.ListBox()
        Me.lblGrades = New System.Windows.Forms.Label()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.lblNumStudents = New System.Windows.Forms.Label()
        Me.lblStudentNum = New System.Windows.Forms.Label()
        Me.lblAverageLetter = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblClassStats = New System.Windows.Forms.Label()
        Me.lblAverages = New System.Windows.Forms.Label()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblGradeAverage = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClassStatistics = New System.Windows.Forms.Button()
        Me.StudentsListBox = New System.Windows.Forms.ListBox()
        Me.lblHighestGrade = New System.Windows.Forms.Label()
        Me.lblLowestGrade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GradesListBox
        '
        Me.GradesListBox.FormattingEnabled = True
        Me.GradesListBox.Location = New System.Drawing.Point(24, 38)
        Me.GradesListBox.Name = "GradesListBox"
        Me.GradesListBox.Size = New System.Drawing.Size(27, 69)
        Me.GradesListBox.TabIndex = 1
        '
        'lblGrades
        '
        Me.lblGrades.AutoSize = True
        Me.lblGrades.Location = New System.Drawing.Point(25, 21)
        Me.lblGrades.Name = "lblGrades"
        Me.lblGrades.Size = New System.Drawing.Size(39, 13)
        Me.lblGrades.TabIndex = 0
        Me.lblGrades.Text = "&Grade:"
        '
        'lblStudents
        '
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Location = New System.Drawing.Point(109, 21)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(52, 13)
        Me.lblStudents.TabIndex = 2
        Me.lblStudents.Text = "&Students:"
        '
        'lblNumStudents
        '
        Me.lblNumStudents.AutoSize = True
        Me.lblNumStudents.Location = New System.Drawing.Point(198, 29)
        Me.lblNumStudents.Name = "lblNumStudents"
        Me.lblNumStudents.Size = New System.Drawing.Size(102, 13)
        Me.lblNumStudents.TabIndex = 4
        Me.lblNumStudents.Text = "Number of students:"
        '
        'lblStudentNum
        '
        Me.lblStudentNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentNum.Location = New System.Drawing.Point(199, 49)
        Me.lblStudentNum.Name = "lblStudentNum"
        Me.lblStudentNum.Size = New System.Drawing.Size(57, 23)
        Me.lblStudentNum.TabIndex = 5
        '
        'lblAverageLetter
        '
        Me.lblAverageLetter.AutoSize = True
        Me.lblAverageLetter.Location = New System.Drawing.Point(198, 89)
        Me.lblAverageLetter.Name = "lblAverageLetter"
        Me.lblAverageLetter.Size = New System.Drawing.Size(47, 13)
        Me.lblAverageLetter.TabIndex = 6
        Me.lblAverageLetter.Text = "Average"
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverage.Location = New System.Drawing.Point(199, 114)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(57, 23)
        Me.lblAverage.TabIndex = 7
        '
        'lblClassStats
        '
        Me.lblClassStats.AutoSize = True
        Me.lblClassStats.Location = New System.Drawing.Point(12, 186)
        Me.lblClassStats.Name = "lblClassStats"
        Me.lblClassStats.Size = New System.Drawing.Size(94, 13)
        Me.lblClassStats.TabIndex = 8
        Me.lblClassStats.Text = "Statistics for class:"
        '
        'lblAverages
        '
        Me.lblAverages.AutoSize = True
        Me.lblAverages.Location = New System.Drawing.Point(122, 186)
        Me.lblAverages.Name = "lblAverages"
        Me.lblAverages.Size = New System.Drawing.Size(50, 13)
        Me.lblAverages.TabIndex = 10
        Me.lblAverages.Text = "Average:"
        '
        'lblHighest
        '
        Me.lblHighest.AutoSize = True
        Me.lblHighest.Location = New System.Drawing.Point(197, 186)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(46, 13)
        Me.lblHighest.TabIndex = 12
        Me.lblHighest.Text = "Highest:"
        '
        'lblLowest
        '
        Me.lblLowest.AutoSize = True
        Me.lblLowest.Location = New System.Drawing.Point(281, 186)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(44, 13)
        Me.lblLowest.TabIndex = 14
        Me.lblLowest.Text = "Lowest:"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(67, 216)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade.TabIndex = 9
        Me.lblGrade.Text = "Grade:"
        '
        'lblGradeAverage
        '
        Me.lblGradeAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGradeAverage.Location = New System.Drawing.Point(125, 206)
        Me.lblGradeAverage.Name = "lblGradeAverage"
        Me.lblGradeAverage.Size = New System.Drawing.Size(62, 23)
        Me.lblGradeAverage.TabIndex = 11
        Me.lblGradeAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(297, 45)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 27)
        Me.btnDisplay.TabIndex = 17
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(297, 110)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 27)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClassStatistics
        '
        Me.btnClassStatistics.Location = New System.Drawing.Point(369, 195)
        Me.btnClassStatistics.Name = "btnClassStatistics"
        Me.btnClassStatistics.Size = New System.Drawing.Size(75, 34)
        Me.btnClassStatistics.TabIndex = 16
        Me.btnClassStatistics.Text = "&Show Class Stats"
        Me.btnClassStatistics.UseVisualStyleBackColor = True
        '
        'StudentsListBox
        '
        Me.StudentsListBox.FormattingEnabled = True
        Me.StudentsListBox.Location = New System.Drawing.Point(105, 38)
        Me.StudentsListBox.Name = "StudentsListBox"
        Me.StudentsListBox.Size = New System.Drawing.Size(67, 95)
        Me.StudentsListBox.TabIndex = 3
        '
        'lblHighestGrade
        '
        Me.lblHighestGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighestGrade.Location = New System.Drawing.Point(200, 206)
        Me.lblHighestGrade.Name = "lblHighestGrade"
        Me.lblHighestGrade.Size = New System.Drawing.Size(68, 23)
        Me.lblHighestGrade.TabIndex = 13
        Me.lblHighestGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLowestGrade
        '
        Me.lblLowestGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLowestGrade.Location = New System.Drawing.Point(284, 206)
        Me.lblLowestGrade.Name = "lblLowestGrade"
        Me.lblLowestGrade.Size = New System.Drawing.Size(66, 23)
        Me.lblLowestGrade.TabIndex = 15
        Me.lblLowestGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 261)
        Me.Controls.Add(Me.lblLowestGrade)
        Me.Controls.Add(Me.lblHighestGrade)
        Me.Controls.Add(Me.StudentsListBox)
        Me.Controls.Add(Me.btnClassStatistics)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblGradeAverage)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblLowest)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lblAverages)
        Me.Controls.Add(Me.lblClassStats)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblAverageLetter)
        Me.Controls.Add(Me.lblStudentNum)
        Me.Controls.Add(Me.lblNumStudents)
        Me.Controls.Add(Me.lblStudents)
        Me.Controls.Add(Me.lblGrades)
        Me.Controls.Add(Me.GradesListBox)
        Me.Name = "frmMain"
        Me.Text = "Professor Juarez"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GradesListBox As ListBox
    Friend WithEvents lblGrades As Label
    Friend WithEvents lblStudents As Label
    Friend WithEvents lblNumStudents As Label
    Friend WithEvents lblStudentNum As Label
    Friend WithEvents lblAverageLetter As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblClassStats As Label
    Friend WithEvents lblAverages As Label
    Friend WithEvents lblHighest As Label
    Friend WithEvents lblLowest As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblGradeAverage As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClassStatistics As Button
    Friend WithEvents StudentsListBox As ListBox
    Friend WithEvents lblHighestGrade As Label
    Friend WithEvents lblLowestGrade As Label
End Class
