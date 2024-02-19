'Solution Name:       Rodriguez Mats Solution
'Project Name:        Rodriguez Calc Cost Project
'Programmer Name:     Ryan Rodriguez
'Date Created:        10/17/23
'Project Description: Display the amount for the type and color.

Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain
    ' Declare constants
    Const TYPE_STANDARD As Double = 99.0
    Const TYPE_DELUXE As Double = 129.0
    Const TYPE_PREMIUM As Double = 179.0

    Const COLOR_BLUE As Double = 0.0
    Const COLOR_RED As Double = 10.0
    Const COLOR_PINK As Double = 15.0

    Const FOLDABLE_COST As Double = 25.0

    Const SALES_TAX_RATE As Double = 0.0875

    ' Function to determine the base price based on material type
    Function CalculateBasePrice() As Double
        Select Case True
            Case rbStandard.Checked
                Return TYPE_STANDARD
            Case rbDeluxe.Checked
                Return TYPE_DELUXE
            Case rbPremium.Checked
                Return TYPE_PREMIUM
            Case Else
                Return 0.0
        End Select
    End Function

    ' Procedure to calculate additional cost for color and foldable option
    Sub CalculateAdditionalCost(ByRef additionalCost As Double)
        additionalCost = 0.0

        If chkFoldable.Checked Then
            additionalCost += FOLDABLE_COST
        End If

        If rbBlue.Checked Then
            additionalCost += COLOR_BLUE
        ElseIf rbRed.Checked Then
            additionalCost += COLOR_RED
        ElseIf rbPink.Checked Then
            additionalCost += COLOR_PINK
        End If
    End Sub

    ' Function to calculate the total cost
    Function CalculateTotalCost() As Double
        Dim basePrice As Double = CalculateBasePrice()
        Dim additionalCost As Double
        CalculateAdditionalCost(additionalCost)
        Dim subTotal As Double = basePrice + additionalCost
        Dim totalCost As Double = subTotal + (subTotal * SALES_TAX_RATE)
        Return totalCost
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim totalCost As Double = CalculateTotalCost()
        lblText.Text = totalCost.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Do you want to Exit?", "Mats-R-Us", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            e.Cancel = True ' Cancel the form closing event
        End If
    End Sub
End Class

