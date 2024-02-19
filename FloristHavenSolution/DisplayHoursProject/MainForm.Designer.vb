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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pbHours = New System.Windows.Forms.PictureBox()
        Me.pbFlowers = New System.Windows.Forms.PictureBox()
        Me.pbFlorist = New System.Windows.Forms.PictureBox()
        CType(Me.pbHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlowers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlorist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(227, 206)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "&Show hours"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.Location = New System.Drawing.Point(308, 206)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 1
        Me.btnHide.Text = "&Hide hours"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(389, 206)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pbHours
        '
        Me.pbHours.Image = Global.DisplayHoursProject.My.Resources.Resources.Hours
        Me.pbHours.Location = New System.Drawing.Point(225, 88)
        Me.pbHours.Name = "pbHours"
        Me.pbHours.Size = New System.Drawing.Size(223, 79)
        Me.pbHours.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHours.TabIndex = 5
        Me.pbHours.TabStop = False
        Me.pbHours.Visible = False
        '
        'pbFlowers
        '
        Me.pbFlowers.Image = Global.DisplayHoursProject.My.Resources.Resources.Message
        Me.pbFlowers.Location = New System.Drawing.Point(208, 27)
        Me.pbFlowers.Name = "pbFlowers"
        Me.pbFlowers.Size = New System.Drawing.Size(252, 55)
        Me.pbFlowers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFlowers.TabIndex = 4
        Me.pbFlowers.TabStop = False
        '
        'pbFlorist
        '
        Me.pbFlorist.Image = Global.DisplayHoursProject.My.Resources.Resources.Florist
        Me.pbFlorist.Location = New System.Drawing.Point(12, 12)
        Me.pbFlorist.Name = "pbFlorist"
        Me.pbFlorist.Size = New System.Drawing.Size(190, 234)
        Me.pbFlorist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFlorist.TabIndex = 3
        Me.pbFlorist.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 241)
        Me.Controls.Add(Me.pbHours)
        Me.Controls.Add(Me.pbFlowers)
        Me.Controls.Add(Me.pbFlorist)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "frmMain"
        Me.Text = "Florist Haven"
        CType(Me.pbHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlowers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlorist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pbFlorist As PictureBox
    Friend WithEvents pbFlowers As PictureBox
    Friend WithEvents pbHours As PictureBox
End Class
