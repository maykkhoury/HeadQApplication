Public Class Settings

    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setCurrenciesCombo()

    End Sub


  

    Private Sub setCurrenciesCombo()
        cmbCurrency.Items.Clear()
        Dim i As Integer
        For i = 0 To currencies.Length - 1
            'get currency name
            Dim value As String = ""
            Dim currencyLanguage As CurrencyLanguage() = currencies(i).currencyLanguage
            Dim j As Integer
            For j = 0 To currencyLanguage.Length - 1
                If currencyLanguage(j).id_language = chosenLanguage.id_language Then
                    value = currencyLanguage(j).label.Trim
                    value = currencies(i).symbol.Trim & " - " & currencies(i).code_currency.Trim & " - " & value
                    Exit For
                End If
            Next j
            '------------------------

            cmbCurrency.Items.Add(value)

            If Not chosenCurrency Is Nothing Then
                If currencies(i).id_currency = chosenCurrency.id_currency Then
                    cmbCurrency.SelectedIndex = i
                End If
            End If
        Next i
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDone.Click


        If cmbCurrency.SelectedIndex >= 0 Then
            setChosenCurrency(currencies(cmbCurrency.SelectedIndex).id_currency)
        End If
        MsgBox("Changes will be aplied after restarting the application", MsgBoxStyle.Information)

        ' setVariables()
        ' garageHome.lbUnitMesureValue.Text = chosenUnit.getUnitName(chosenLanguage.id_language)
        ' garageHome.lbCurrencyDetailsValue.Text = chosenCurrency.code_currency

        'garageHome.addResultsToListviewFormula(curFormulas)
        'If Not curSubFamily Is Nothing Then
        'garageHome.addResultsToListviewFamily(curSubFamily, False)
        'If Not selectedFormulaColors Is Nothing Then
        'garageHome.generatesDetails()
        ' End If

        ' End If

        Me.Close()

    End Sub
End Class