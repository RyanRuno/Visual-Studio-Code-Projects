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
        Me.lblItemNumber = New System.Windows.Forms.Label()
        Me.lblItemColor = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblItemNumber
        '
        Me.lblItemNumber.AutoSize = True
        Me.lblItemNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemNumber.Location = New System.Drawing.Point(40, 29)
        Me.lblItemNumber.Name = "lblItemNumber"
        Me.lblItemNumber.Size = New System.Drawing.Size(80, 15)
        Me.lblItemNumber.TabIndex = 0
        Me.lblItemNumber.Text = "&Item number:"
        '
        'lblItemColor
        '
        Me.lblItemColor.AutoSize = True
        Me.lblItemColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemColor.Location = New System.Drawing.Point(141, 29)
        Me.lblItemColor.Name = "lblItemColor"
        Me.lblItemColor.Size = New System.Drawing.Size(66, 15)
        Me.lblItemColor.TabIndex = 2
        Me.lblItemColor.Text = "Item Color:"
        '
        'lblColor
        '
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor.Location = New System.Drawing.Point(144, 49)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(75, 20)
        Me.lblColor.TabIndex = 3
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(43, 49)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(87, 20)
        Me.txtItem.TabIndex = 1
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(43, 90)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(144, 90)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 135)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblItemColor)
        Me.Controls.Add(Me.lblItemNumber)
        Me.Name = "frmMain"
        Me.Text = "Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItemNumber As Label
    Friend WithEvents lblItemColor As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Public WithEvents txtItem As TextBox
End Class
