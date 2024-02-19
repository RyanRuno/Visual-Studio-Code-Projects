'Soluton Name:        Tax Solution
'Project Name:        Tax Calculator Project
'Programmer Name:     Ryan Rodriguez
'Date Created:        8/30/23
'Project Description: Display the hours or hide the hours available

Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'Show the hours
        pbHours.Visible = True
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        'Hide the hours
        pbHours.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close application
        Me.Close()
    End Sub
End Class
