<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAssessed = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltxt = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 198)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(104, 35)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(190, 198)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Assessed Value:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(41, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Property Tax:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAssessed
        '
        Me.txtAssessed.Location = New System.Drawing.Point(147, 87)
        Me.txtAssessed.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAssessed.Name = "txtAssessed"
        Me.txtAssessed.Size = New System.Drawing.Size(113, 23)
        Me.txtAssessed.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TaxProject.My.Resources.Resources.tax
        Me.PictureBox1.Location = New System.Drawing.Point(76, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lbltxt
        '
        Me.lbltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltxt.Location = New System.Drawing.Point(131, 135)
        Me.lbltxt.Name = "lbltxt"
        Me.lbltxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbltxt.Size = New System.Drawing.Size(129, 23)
        Me.lbltxt.TabIndex = 3
        Me.lbltxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 249)
        Me.Controls.Add(Me.lbltxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtAssessed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Property Tax"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAssessed As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltxt As Label
End Class
