Public Class assignColor

    Private Sub assignColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbUnitMesureValue.Text = chosenUnit.getUnitName(chosenLanguage.id_language)
        addResultsToListviewFormula()

    End Sub

    Public Sub addResultsToListviewFormula()
        Try
            Dim allColors() As Color = getColors()
            lsvColor.Items.Clear()
            Dim i As Integer = 0
            For i = 0 To colors.Length - 1
                lsvColor.Items.Add(colors(i).colorCode)
                lsvColor.Items(i).SubItems.Add(colors(i).name_color)
                lsvColor.Items(0).Selected = True
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub butChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butChoose.Click

        'control numeric
        If Not IsNumeric(txtQty.Text) Then
            MessageBox.Show("The quantity must be a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim index As Integer = lsvColor.SelectedIndices(0)
        Dim id_color As Integer = colors(index).id_color

        Dim id_unit As Integer = 2
        Dim quantite As Decimal = CType(txtQty.Text, Decimal)
        Dim id_formula As Integer = edit.lbFormulaId.Text
        Dim alreadyexist = False
        Dim formulaColor As New FormulaColor
        formulaColor.id_color = id_color
        formulaColor.id_Unit = id_unit
        formulaColor.quantite = quantite


        If fromAddFormula Then

            addFormula.ratioFormulaColor = 1

            If addFormula.chosenFormulaColors Is Nothing Then
                Dim MyArray As New ArrayList
                MyArray.Add(formulaColor)

                addFormula.chosenFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
            Else

                Dim MyArray As New ArrayList
                Dim i As Integer

                For i = 0 To addFormula.chosenFormulaColors.Length - 1
                    MyArray.Add(addFormula.chosenFormulaColors(i))
                    If addFormula.chosenFormulaColors(i).id_color = id_color Then
                        alreadyexist = True
                    End If
                Next
                If alreadyexist Then
                    MsgBox("Color already exist for this formula", MessageBoxIcon.Information)
                Else
                    MyArray.Add(formulaColor)
                End If

                addFormula.chosenFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If
            addFormula.generatesDetails(addFormula.chosenFormulaColors)
            If Not alreadyexist Then
                Me.Close()
            End If
        Else 'from HeadQhome
            formulaColor.id_formula = id_formula
            If selectedFormulaColors Is Nothing Then
                Dim MyArray As New ArrayList
                MyArray.Add(formulaColor)

                selectedFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
            Else

                Dim MyArray As New ArrayList
                Dim i As Integer

                For i = 0 To selectedFormulaColors.Length - 1
                    MyArray.Add(selectedFormulaColors(i))
                    If selectedFormulaColors(i).id_color = id_color Then
                        alreadyexist = True
                    End If
                Next
                If alreadyexist Then
                    MsgBox("Color already exist for this formula", MessageBoxIcon.Information)
                Else
                    MyArray.Add(formulaColor)
                End If

                selectedFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If

            Dim carid As String = edit.lbCarId.Text
            Dim carNameModel As String = edit.cmbCarNameModelEdit.Text
            Dim version As String = edit.cmbVersionEdit.Text
            Dim type As String = edit.cmbType.Text
            edit.generatesDetails(edit.formulaDup)

            edit.lbCarId.Text = carid
            edit.cmbCarNameModelEdit.Text = carNameModel
            edit.cmbVersionEdit.Text = version
            edit.cmbType.Text = type


            edit.grpEdit.Visible = True
            Me.Close()
        End If
    End Sub

    Public Function IsNumeric(ByVal str As String)
        Return Microsoft.VisualBasic.IsNumeric(str)
        'Return New Regex("\b\d+(\.\d+)?\b").Match(str).Success
    End Function

    Private Sub butCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancel.Click
        Me.Close()
    End Sub
End Class