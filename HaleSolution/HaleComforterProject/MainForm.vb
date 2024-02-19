'Solution Name:       Hale Solution
'Project  Name:       HaleComforter Project
'Programmer Name:     Ryan Rodriguez
'Date Created:        9/27/23
'Project Description: Displays the amount for each and every single bed size not including/including shipping price.
'
'
Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain
    Dim price As Double ' Variable to store the comforter cost

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the application
        Me.Close()
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the price to 0
        price = 0
    End Sub

    Private Sub radTwin_CheckedChanged(sender As Object, e As EventArgs) Handles radTwin.CheckedChanged
        ' Add or remove Twin price
        If radTwin.Checked Then
            price += 39.99
        Else
            price -= 39.99
        End If

    End Sub

    Private Sub radFull_CheckedChanged(sender As Object, e As EventArgs) Handles radFull.CheckedChanged
        ' Add or remove Full price
        If radFull.Checked Then
            price += 49.99
        Else
            price -= 49.99
        End If

    End Sub

    Private Sub radQueen_CheckedChanged(sender As Object, e As EventArgs) Handles radQueen.CheckedChanged
        ' Add or remove Queen price
        If radQueen.Checked Then
            price += 49.99
        Else
            price -= 49.99
        End If

    End Sub

    Private Sub radKing_CheckedChanged(sender As Object, e As EventArgs) Handles radKing.CheckedChanged
        ' Add or remove King price
        If radKing.Checked Then
            price += 69.99
        Else
            price -= 69.99
        End If

    End Sub

    Private Sub chkPickUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkPickUp.CheckedChanged
        ' Toggle shipping cost based on store pickup choice
        If chkPickUp.Checked Then
            price -= 5 ' No shipping cost for store pickup
        Else
            price += 5 ' Add shipping cost if not picking up in store
        End If
        UpdateCostLabel()
    End Sub

    Private Sub btnCase_Click(sender As Object, e As EventArgs) Handles btnCase.Click
        ' Calculate cost using CASE statement
        Dim storePickup As Boolean = chkPickUp.Checked ' Check if store pickup is chosen

        ' Calculate the comforter cost based on the selected radio button and store pickup choice
        Select Case True
            Case radTwin.Checked
                price = If(storePickup, 39.99, 39.99 + 5)
            Case radFull.Checked
                price = If(storePickup, 49.99, 49.99 + 5)
            Case radQueen.Checked
                price = If(storePickup, 49.99, 49.99 + 5)
            Case radKing.Checked
                price = If(storePickup, 69.99, 69.99 + 5)
        End Select

        UpdateCostLabel()
    End Sub

    Private Sub btnIf_Click(sender As Object, e As EventArgs) Handles btnIf.Click
        ' Calculate cost using IF/ELSE logic
        Dim storePickup As Boolean = Not chkPickUp.Checked ' Check if store pickup is not chosen

        ' Determine the comforter cost based on the selected radio button
        If radTwin.Checked Then
            price = If(storePickup, 44.99, 44.99 - 5)
        ElseIf radFull.Checked Then
            price = If(storePickup, 54.99, 54.99 - 5)
        ElseIf radQueen.Checked Then
            price = If(storePickup, 54.99, 54.99 - 5)
        ElseIf radKing.Checked Then
            price = If(storePickup, 74.99, 74.99 - 5)
        End If

        UpdateCostLabel()
    End Sub

    Private Sub UpdateCostLabel()
        ' Update the cost label with the calculated price
        lblResult.Text = "$" & price.ToString("F2")
    End Sub
End Class
