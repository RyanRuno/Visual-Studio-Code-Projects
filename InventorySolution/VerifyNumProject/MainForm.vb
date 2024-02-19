
'Soluton Name:        InvertorySolution
'Project Name:        VerifyNumProject
'Programmer Name:     Ryan Rodriguez
'Date Created:        11/6/23
'Project Description: Display the color based on the item number
' 
'
Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the tab order.
        Me.AcceptButton = btnDisplay
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim itemNumber As String = txtItem.Text.Trim().ToLower()
        Dim validColors As String = "rgbw"
        Dim color As String = If(itemNumber(2) = "r", "Red", If(itemNumber(2) = "g", "Green", If(itemNumber(2) = "b", "Blue", If(itemNumber(2) = "w", "White", "Invalid"))))

        ' Check if the item number has exactly 5 characters.

        If itemNumber.Length <> 5 Then
            MessageBox.Show("Item number must have exactly 5 characters.", "Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItem.Focus()
            Return
        End If

        ' Check if the third character is a valid color character.

        If Not validColors.Contains(itemNumber(2)) Then
            MessageBox.Show("Invalid color code in the item number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtItem.Focus()
            Return
        End If

        'Determine the color and display it.

        lblColor.Text = color
        txtItem.Focus()
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        ' Clear output labels when the text changes.
        lblColor.Text = ""
    End Sub

    Private Sub txtItem_Enter(sender As Object, e As EventArgs) Handles txtItem.Enter
        ' Select all text on text enter event.
        txtItem.SelectAll()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Confirm exit when the form is closing.
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the application
        Me.Close()
    End Sub
End Class