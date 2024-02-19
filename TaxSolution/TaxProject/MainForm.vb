'Soluton Name: Tax Solution
'Project Name: Tax Calculator Project
'Programmer Name: Ryan Rodriguez
'Date Created: 9/11/23
'Project Description: Calculate and display the Tax from user amount.
'
'
Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain
    Const dblRate As Double = 0.0135

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculate the tax

        Dim dblCurrent As Double
        Dim dblincrease As Double


        Double.TryParse(txtAssessed.Text, dblCurrent)
        dblincrease = dblCurrent * dblRate


        lbltxt.Text = dblincrease.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Program

        Me.Close()
    End Sub
End Class
