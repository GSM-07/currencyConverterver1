Public Class Form1

    'list of supported currencies shown in both combo boxes'
    Dim supportedCurrencies = {"EUR", "USD", "JPY", "GBP"}

    ' dictionary storing fixed exchange rates'
    Dim currentRates As New Dictionary(Of String, Double) From {
     {"EUR", 1.15},
     {"USD", 1.26},
     {"JPY", 0.008},
     {"GBP", 1.0}
    }

    ' Form laod - initial setup '
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'fill both combo boxes with the same list of currencies'
        ddlFromCurrency.Items.AddRange(supportedCurrencies)
        ddlToCurrency.Items.AddRange(supportedCurrencies)

        ' default selections '
        ddlFromCurrency.SelectedItem = "GBP"       ' user enters amount in GBP'
        ddlToCurrency.SelectedItem = "EUR"         ' convert into EUR '

        'clear UI fields'
        txtAmount.Text = ""
        lblResult.Text = ""
        lblRateUsed.Text = ""
    End Sub

    'when user changes the "from" currency'
    Private Sub ddlFromCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlFromCurrency.SelectedIndexChanged

        'clear amount and result because conversion is no longer valid'
        txtAmount.Text = ""
        lblResult.Text = ""
    End Sub

    Private Sub ddlToCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlToCurrency.SelectedIndexChanged

        'clear result because conversion must be recalculated'
        lblResult.Text = ""
    End Sub

    'validate amount as user types'
    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

        'check if the amount is valid (numeric, >0, 2 decimals)'
        If Not ValidAmount(txtAmount.Text) Then
            ErrorProvider1.SetError(txtAmount, "Enter a positive number up to 2 decimals")
            btnConvert.Enabled = False
            Exit Sub
        End If

        ' Clear error and enable Convert button
        ErrorProvider1.Clear()
        btnConvert.Enabled = True
    End Sub

    'CONVERT BUTTON - MAIN LOGIC'
    Private Sub btnConvert_click(sender As Object, e As EventArgs) Handles btnConvert.Click

        'validate again before converting '
        If Not ValidAmount(txtAmount.Text) Then
            ErrorProvider1.SetError(txtAmount, "Enter a positive number up to 2 decimals")
            Exit Sub
        End If

        ' convert input text to a number 
        Dim amount As Double = Double.Parse(txtAmount.Text)

        'read selected currencies 
        Dim fromCurrency As String = ddlFromCurrency.SelectedItem.ToString()
        Dim toCurrency As String = ddlToCurrency.SelectedItem.ToString()

        'get their rates from the dictionary 
        Dim fromRate As Double = currentRates(fromCurrency)
        Dim toRate As Double = currentRates(toCurrency)

        'CONVERSION FORMULA (amount x (toRate / fromRate))
        Dim convertedAmount As Double = Math.Round(amount * (toRate / fromRate), 2)

        'display result formatted as currency 
        lblResult.Text = convertedAmount.ToString("C2")

        ' show exchange rate used in both directions 
        lblRateUsed.Text =
            $"1 {fromCurrency} = {(fromRate / toRate):F4} {toCurrency} | " &
            $"1 {toCurrency} = {(toRate / fromRate):F4} {fromCurrency}"

    End Sub

    'validate function for amount 
    Private Function ValidAmount(s As String) As Boolean

        'check numeric
        Dim v As Double
        If Not Double.TryParse(s, v) Then Return False

        'must be positive and not exceedingly large
        If v <= 0 Or v > 1000000 Then Return False

        'check decimal places (max 2 )
        Dim decimals = BitConverter.GetBytes(Decimal.GetBits(CDec(v))(3))(2)
        Return decimals <= 2
    End Function

End Class
