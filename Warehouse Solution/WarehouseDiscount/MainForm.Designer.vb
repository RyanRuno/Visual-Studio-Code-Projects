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
        Me.components = New System.ComponentModel.Container()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pbRetailDiscount = New System.Windows.Forms.PictureBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblDiscountedPrice = New System.Windows.Forms.Label()
        Me.lblDiscountAmount = New System.Windows.Forms.Label()
        Me.lblDiscountPrice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtOriginalPrice = New System.Windows.Forms.TextBox()
        Me.lstDiscountRates = New System.Windows.Forms.Label()
        Me.lstRates = New System.Windows.Forms.ListBox()
        CType(Me.pbRetailDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'pbRetailDiscount
        '
        Me.pbRetailDiscount.Image = Global.WarehouseDiscount.My.Resources.Resources.Retail
        Me.pbRetailDiscount.Location = New System.Drawing.Point(12, 12)
        Me.pbRetailDiscount.Name = "pbRetailDiscount"
        Me.pbRetailDiscount.Size = New System.Drawing.Size(135, 103)
        Me.pbRetailDiscount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRetailDiscount.TabIndex = 0
        Me.pbRetailDiscount.TabStop = False
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(12, 135)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(52, 13)
        Me.lblDiscount.TabIndex = 0
        Me.lblDiscount.Text = "Discount:"
        '
        'lblDiscountedPrice
        '
        Me.lblDiscountedPrice.AutoSize = True
        Me.lblDiscountedPrice.Location = New System.Drawing.Point(107, 135)
        Me.lblDiscountedPrice.Name = "lblDiscountedPrice"
        Me.lblDiscountedPrice.Size = New System.Drawing.Size(90, 13)
        Me.lblDiscountedPrice.TabIndex = 1
        Me.lblDiscountedPrice.Text = "Discounted price:"
        '
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountAmount.Location = New System.Drawing.Point(15, 157)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(79, 23)
        Me.lblDiscountAmount.TabIndex = 4
        Me.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiscountPrice
        '
        Me.lblDiscountPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountPrice.Location = New System.Drawing.Point(110, 157)
        Me.lblDiscountPrice.Name = "lblDiscountPrice"
        Me.lblDiscountPrice.Size = New System.Drawing.Size(71, 23)
        Me.lblDiscountPrice.TabIndex = 5
        Me.lblDiscountPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "&Original price:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(206, 157)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(287, 157)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtOriginalPrice
        '
        Me.txtOriginalPrice.Location = New System.Drawing.Point(183, 82)
        Me.txtOriginalPrice.Name = "txtOriginalPrice"
        Me.txtOriginalPrice.Size = New System.Drawing.Size(68, 20)
        Me.txtOriginalPrice.TabIndex = 6
        '
        'lstDiscountRates
        '
        Me.lstDiscountRates.AutoSize = True
        Me.lstDiscountRates.Location = New System.Drawing.Point(269, 26)
        Me.lstDiscountRates.Name = "lstDiscountRates"
        Me.lstDiscountRates.Size = New System.Drawing.Size(95, 13)
        Me.lstDiscountRates.TabIndex = 3
        Me.lstDiscountRates.Text = "&Discount rates (%):"
        '
        'lstRates
        '
        Me.lstRates.FormattingEnabled = True
        Me.lstRates.Items.AddRange(New Object() {"10", "15", "20", "25", "30", "35", "40"})
        Me.lstRates.Location = New System.Drawing.Point(287, 42)
        Me.lstRates.Name = "lstRates"
        Me.lstRates.Size = New System.Drawing.Size(53, 82)
        Me.lstRates.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 198)
        Me.Controls.Add(Me.lstRates)
        Me.Controls.Add(Me.lstDiscountRates)
        Me.Controls.Add(Me.txtOriginalPrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDiscountPrice)
        Me.Controls.Add(Me.lblDiscountAmount)
        Me.Controls.Add(Me.lblDiscountedPrice)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.pbRetailDiscount)
        Me.Name = "frmMain"
        Me.Text = "Discount Warehouse"
        CType(Me.pbRetailDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents pbRetailDiscount As PictureBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblDiscountedPrice As Label
    Friend WithEvents lblDiscountAmount As Label
    Friend WithEvents lblDiscountPrice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtOriginalPrice As TextBox
    Friend WithEvents lstDiscountRates As Label
    Friend WithEvents lstRates As ListBox
End Class
