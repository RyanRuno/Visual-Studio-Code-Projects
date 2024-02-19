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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radTwin = New System.Windows.Forms.RadioButton()
        Me.radFull = New System.Windows.Forms.RadioButton()
        Me.radQueen = New System.Windows.Forms.RadioButton()
        Me.radKing = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCase = New System.Windows.Forms.Button()
        Me.btnIf = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkPickUp = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radTwin)
        Me.GroupBox1.Controls.Add(Me.radFull)
        Me.GroupBox1.Controls.Add(Me.radQueen)
        Me.GroupBox1.Controls.Add(Me.radKing)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(81, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Size"
        '
        'radTwin
        '
        Me.radTwin.AutoSize = True
        Me.radTwin.Location = New System.Drawing.Point(6, 28)
        Me.radTwin.Name = "radTwin"
        Me.radTwin.Size = New System.Drawing.Size(48, 17)
        Me.radTwin.TabIndex = 1
        Me.radTwin.TabStop = True
        Me.radTwin.Text = "&Twin"
        Me.radTwin.UseVisualStyleBackColor = True
        '
        'radFull
        '
        Me.radFull.AutoSize = True
        Me.radFull.Location = New System.Drawing.Point(6, 51)
        Me.radFull.Name = "radFull"
        Me.radFull.Size = New System.Drawing.Size(41, 17)
        Me.radFull.TabIndex = 2
        Me.radFull.TabStop = True
        Me.radFull.Text = "&Full"
        Me.radFull.UseVisualStyleBackColor = True
        '
        'radQueen
        '
        Me.radQueen.AutoSize = True
        Me.radQueen.Location = New System.Drawing.Point(6, 74)
        Me.radQueen.Name = "radQueen"
        Me.radQueen.Size = New System.Drawing.Size(57, 17)
        Me.radQueen.TabIndex = 3
        Me.radQueen.TabStop = True
        Me.radQueen.Text = "&Queen"
        Me.radQueen.UseVisualStyleBackColor = True
        '
        'radKing
        '
        Me.radKing.AutoSize = True
        Me.radKing.Location = New System.Drawing.Point(6, 97)
        Me.radKing.Name = "radKing"
        Me.radKing.Size = New System.Drawing.Size(46, 17)
        Me.radKing.TabIndex = 4
        Me.radKing.TabStop = True
        Me.radKing.Text = "&King"
        Me.radKing.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(50, 172)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(28, 13)
        Me.lblCost.TabIndex = 1
        Me.lblCost.Text = "Cost"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Yellow
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(170, 171)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(108, 23)
        Me.lblResult.TabIndex = 2
        '
        'btnCase
        '
        Me.btnCase.Location = New System.Drawing.Point(170, 56)
        Me.btnCase.Name = "btnCase"
        Me.btnCase.Size = New System.Drawing.Size(108, 23)
        Me.btnCase.TabIndex = 3
        Me.btnCase.Text = "Display &cost (Case)"
        Me.btnCase.UseVisualStyleBackColor = True
        '
        'btnIf
        '
        Me.btnIf.Location = New System.Drawing.Point(170, 94)
        Me.btnIf.Name = "btnIf"
        Me.btnIf.Size = New System.Drawing.Size(108, 23)
        Me.btnIf.TabIndex = 4
        Me.btnIf.Text = "&Display cost (IF)"
        Me.btnIf.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(170, 131)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkPickUp
        '
        Me.chkPickUp.AutoSize = True
        Me.chkPickUp.Location = New System.Drawing.Point(170, 12)
        Me.chkPickUp.Name = "chkPickUp"
        Me.chkPickUp.Size = New System.Drawing.Size(99, 17)
        Me.chkPickUp.TabIndex = 6
        Me.chkPickUp.Text = "&Pick up in store"
        Me.chkPickUp.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 215)
        Me.Controls.Add(Me.chkPickUp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnIf)
        Me.Controls.Add(Me.btnCase)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Hales Department Store"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radTwin As RadioButton
    Friend WithEvents radFull As RadioButton
    Friend WithEvents radQueen As RadioButton
    Friend WithEvents radKing As RadioButton
    Friend WithEvents lblCost As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCase As Button
    Friend WithEvents btnIf As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkPickUp As CheckBox
End Class
