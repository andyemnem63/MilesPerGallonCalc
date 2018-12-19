Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtGallons.TextChanged

    End Sub

    Private Sub btnCalculateMpg_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variable for the calculations
        Dim decMilesPerGallon As Decimal
        Try
            ' Calculate and display the miles per gallon
            decMilesPerGallon = CDec(txtMiles.Text) /
                CDec(txtGallons.Text)
            lblMilesPerGallon.Text = decMilesPerGallon.ToString("f")
        Catch
            ' Error message
            MessageBox.Show("All input must be valid numeric values")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear mile and gallon fields
        txtGallons.Clear()
        txtMiles.Clear()

        ' Clear the miles per gallon field
        lblMilesPerGallon.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close Application
        Me.Close()
    End Sub
End Class
