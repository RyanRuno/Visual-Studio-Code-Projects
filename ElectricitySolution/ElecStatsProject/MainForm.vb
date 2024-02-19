'Soluton Name:        ElectricitySolution
'Project Name:        ElecStatsProject
'Programmer Name:     Ryan Rodriguez
'Date Created:        11/30/23
'Project Description: Display the "Average", "Highest", and "Lowest" Monthly bill.

Option Explicit On
Option Strict On
Option Infer Off
Imports System.IO
Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare Variables
        Dim strFileName As String = "monthlyBills.txt"
        Dim decTotalBills As Decimal
        Dim intBillCount As Integer
        Dim decHighestBill As Decimal
        Dim decLowestBill As Decimal

        ' Check if the file exists
        If IO.File.Exists(strFileName) Then
            ' Open file and process bills
            Using reader As New StreamReader(strFileName)
                ' Initialize variables
                decTotalBills = 0
                intBillCount = 0
                decHighestBill = Decimal.MinValue
                decLowestBill = Decimal.MaxValue

                ' Loop until end of file
                Do Until reader.EndOfStream
                    ' Read monthly bill
                    Dim monthlyBill As Decimal
                    If Decimal.TryParse(reader.ReadLine(), monthlyBill) Then
                        ' Update total, count, highest, and lowest
                        decTotalBills += monthlyBill
                        intBillCount += 1
                        decHighestBill = Math.Max(decHighestBill, monthlyBill)
                        decLowestBill = Math.Min(decLowestBill, monthlyBill)
                    Else
                        ' Handle invalid input (non-numeric)
                    End If
                Loop
            End Using

            ' Average calculate
            Dim averageBill As Decimal = decTotalBills / intBillCount

            ' Display results
            lblAverage.Text = String.Format("{0:C2}", averageBill)
            lblHighest.Text = String.Format("{0:C2}", decHighestBill)
            lblLowest.Text = String.Format("{0:C2}", decLowestBill)
        Else
            ' Display error message
            MessageBox.Show("Monthly bills file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the application

        Me.Close()
    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Verify that the user wants to exit the application.

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "BuyMore Electricity", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
