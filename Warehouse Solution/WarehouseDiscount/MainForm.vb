'Soluton Name:          Tax Solution
'Project Name:          Tax Calculator Project
'Programmer Name:       Ryan Rodriguez
'Date Created:          10/12/23
'Project Description:   Calculate and display the warehouse discounts.

Public Class frmMain
    Private Sub txtOriginalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtOriginalPrice.TextChanged
        ' Clear the output labels when the original price changes.
        lblDiscountAmount.Text = String.Empty
        lblDiscountPrice.Text = String.Empty
    End Sub
    Private Sub lstRates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRates.SelectedIndexChanged
        ' Clear the output labels when the discount rate changes.
        lblDiscountAmount.Text = String.Empty
        lblDiscountPrice.Text = String.Empty
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim originalPrice As Decimal
        Dim discountRate As Decimal

        If Decimal.TryParse(txtOriginalPrice.Text, originalPrice) AndAlso lstRates.SelectedIndex <> -1 Then
            discountRate = CDec(lstRates.SelectedItem.ToString.TrimEnd("%")) / 100

            ' Calculate the discount and discounted price
            Dim discountAmount As Decimal = originalPrice * discountRate
            Dim discountedPrice As Decimal = originalPrice - discountAmount

            ' Display the results with two decimal places
            lblDiscountAmount.Text = discountAmount.ToString("0.00")
            lblDiscountPrice.Text = discountedPrice.ToString("0.00")
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the application if clicked
        Me.Close()
    End Sub

End Class
