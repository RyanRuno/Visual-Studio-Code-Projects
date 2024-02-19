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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAveragemonthlybill = New System.Windows.Forms.Label()
        Me.lblHighestmonthlybill = New System.Windows.Forms.Label()
        Me.lblLowestmonthlybill = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.pbElectricity = New System.Windows.Forms.PictureBox()
        CType(Me.pbElectricity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(134, 244)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(72, 20)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(211, 244)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 20)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAveragemonthlybill
        '
        Me.lblAveragemonthlybill.AutoSize = True
        Me.lblAveragemonthlybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveragemonthlybill.Location = New System.Drawing.Point(21, 105)
        Me.lblAveragemonthlybill.Name = "lblAveragemonthlybill"
        Me.lblAveragemonthlybill.Size = New System.Drawing.Size(119, 15)
        Me.lblAveragemonthlybill.TabIndex = 0
        Me.lblAveragemonthlybill.Text = "Average monthly bill:"
        '
        'lblHighestmonthlybill
        '
        Me.lblHighestmonthlybill.AutoSize = True
        Me.lblHighestmonthlybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestmonthlybill.Location = New System.Drawing.Point(21, 154)
        Me.lblHighestmonthlybill.Name = "lblHighestmonthlybill"
        Me.lblHighestmonthlybill.Size = New System.Drawing.Size(117, 15)
        Me.lblHighestmonthlybill.TabIndex = 2
        Me.lblHighestmonthlybill.Text = "Highest monthly bill:"
        '
        'lblLowestmonthlybill
        '
        Me.lblLowestmonthlybill.AutoSize = True
        Me.lblLowestmonthlybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowestmonthlybill.Location = New System.Drawing.Point(21, 196)
        Me.lblLowestmonthlybill.Name = "lblLowestmonthlybill"
        Me.lblLowestmonthlybill.Size = New System.Drawing.Size(114, 15)
        Me.lblLowestmonthlybill.TabIndex = 4
        Me.lblLowestmonthlybill.Text = "Lowest monthly bill:"
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.Info
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverage.Location = New System.Drawing.Point(141, 98)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(145, 27)
        Me.lblAverage.TabIndex = 1
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHighest
        '
        Me.lblHighest.BackColor = System.Drawing.SystemColors.Info
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighest.Location = New System.Drawing.Point(141, 149)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(145, 26)
        Me.lblHighest.TabIndex = 3
        Me.lblHighest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLowest
        '
        Me.lblLowest.BackColor = System.Drawing.SystemColors.Info
        Me.lblLowest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLowest.Location = New System.Drawing.Point(141, 192)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(145, 26)
        Me.lblLowest.TabIndex = 5
        Me.lblLowest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbElectricity
        '
        Me.pbElectricity.Image = Global.ElecStatsProject.My.Resources.Resources.electricity
        Me.pbElectricity.Location = New System.Drawing.Point(-7, -1)
        Me.pbElectricity.Name = "pbElectricity"
        Me.pbElectricity.Size = New System.Drawing.Size(325, 77)
        Me.pbElectricity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbElectricity.TabIndex = 8
        Me.pbElectricity.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 286)
        Me.Controls.Add(Me.pbElectricity)
        Me.Controls.Add(Me.lblLowest)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblLowestmonthlybill)
        Me.Controls.Add(Me.lblHighestmonthlybill)
        Me.Controls.Add(Me.lblAveragemonthlybill)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmMain"
        Me.Text = "BuyMore Electricity"
        CType(Me.pbElectricity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAveragemonthlybill As Label
    Friend WithEvents lblHighestmonthlybill As Label
    Friend WithEvents lblLowestmonthlybill As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblHighest As Label
    Friend WithEvents lblLowest As Label
    Friend WithEvents pbElectricity As PictureBox
End Class
