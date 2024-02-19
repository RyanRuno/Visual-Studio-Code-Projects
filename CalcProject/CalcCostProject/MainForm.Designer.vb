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
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.rbDeluxe = New System.Windows.Forms.RadioButton()
        Me.rbPremium = New System.Windows.Forms.RadioButton()
        Me.rbStandard = New System.Windows.Forms.RadioButton()
        Me.grpColor = New System.Windows.Forms.GroupBox()
        Me.rbPink = New System.Windows.Forms.RadioButton()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.chkFoldable = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpType.SuspendLayout()
        Me.grpColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rbDeluxe)
        Me.grpType.Controls.Add(Me.rbPremium)
        Me.grpType.Controls.Add(Me.rbStandard)
        Me.grpType.Location = New System.Drawing.Point(47, 26)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(141, 125)
        Me.grpType.TabIndex = 3
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type"
        '
        'rbDeluxe
        '
        Me.rbDeluxe.AutoSize = True
        Me.rbDeluxe.Location = New System.Drawing.Point(6, 60)
        Me.rbDeluxe.Name = "rbDeluxe"
        Me.rbDeluxe.Size = New System.Drawing.Size(91, 17)
        Me.rbDeluxe.TabIndex = 1
        Me.rbDeluxe.TabStop = True
        Me.rbDeluxe.Text = "&Deluxe ($129)"
        Me.rbDeluxe.UseVisualStyleBackColor = True
        '
        'rbPremium
        '
        Me.rbPremium.AutoSize = True
        Me.rbPremium.Location = New System.Drawing.Point(6, 92)
        Me.rbPremium.Name = "rbPremium"
        Me.rbPremium.Size = New System.Drawing.Size(98, 17)
        Me.rbPremium.TabIndex = 2
        Me.rbPremium.TabStop = True
        Me.rbPremium.Text = "&Premium ($179)"
        Me.rbPremium.UseVisualStyleBackColor = True
        '
        'rbStandard
        '
        Me.rbStandard.AutoSize = True
        Me.rbStandard.Location = New System.Drawing.Point(6, 27)
        Me.rbStandard.Name = "rbStandard"
        Me.rbStandard.Size = New System.Drawing.Size(95, 17)
        Me.rbStandard.TabIndex = 0
        Me.rbStandard.TabStop = True
        Me.rbStandard.Text = "&Standard ($99)"
        Me.rbStandard.UseVisualStyleBackColor = True
        '
        'grpColor
        '
        Me.grpColor.Controls.Add(Me.rbPink)
        Me.grpColor.Controls.Add(Me.rbRed)
        Me.grpColor.Controls.Add(Me.rbBlue)
        Me.grpColor.Location = New System.Drawing.Point(209, 26)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(148, 125)
        Me.grpColor.TabIndex = 4
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Color"
        '
        'rbPink
        '
        Me.rbPink.AutoSize = True
        Me.rbPink.Location = New System.Drawing.Point(18, 92)
        Me.rbPink.Name = "rbPink"
        Me.rbPink.Size = New System.Drawing.Size(99, 17)
        Me.rbPink.TabIndex = 2
        Me.rbPink.TabStop = True
        Me.rbPink.Text = "Pin&k ($15 extra)"
        Me.rbPink.UseVisualStyleBackColor = True
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(19, 60)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(98, 17)
        Me.rbRed.TabIndex = 1
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "&Red ($10 extra)"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(19, 27)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(46, 17)
        Me.rbBlue.TabIndex = 0
        Me.rbBlue.TabStop = True
        Me.rbBlue.Text = "&Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'chkFoldable
        '
        Me.chkFoldable.AutoSize = True
        Me.chkFoldable.Location = New System.Drawing.Point(376, 47)
        Me.chkFoldable.Name = "chkFoldable"
        Me.chkFoldable.Size = New System.Drawing.Size(119, 17)
        Me.chkFoldable.TabIndex = 2
        Me.chkFoldable.Text = "&Foldable ($25 extra)"
        Me.chkFoldable.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(373, 93)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 0
        Me.lblPrice.Text = "Price:"
        '
        'lblText
        '
        Me.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblText.Location = New System.Drawing.Point(413, 86)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(110, 32)
        Me.lblText.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(376, 141)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 22)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(457, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 22)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 182)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.chkFoldable)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.grpType)
        Me.Name = "frmMain"
        Me.Text = "Mats-R-Us"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpType As GroupBox
    Friend WithEvents rbDeluxe As RadioButton
    Friend WithEvents rbPremium As RadioButton
    Friend WithEvents rbStandard As RadioButton
    Friend WithEvents grpColor As GroupBox
    Friend WithEvents rbPink As RadioButton
    Friend WithEvents rbRed As RadioButton
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents chkFoldable As CheckBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblText As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
