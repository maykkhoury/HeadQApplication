Imports System.IO

Public Class edit
    Public formulaDup As Formula = Nothing
    Public fromMinimize As Boolean = False
    Public id_formulaComposedGlobal As Integer = -1
    Private isBumperEdit As Boolean = False
    Public formulaCorrupted = False
    Private Sub loadCars()
        'Dim carsTab() As Car = getCars("")

        ' Dim i As Integer
        'cmbCarNameModelEdit.Items.Add("")
        'For i = 0 To carsTab.Length - 1
        'cmbCarNameModelEdit.Items.Add(carsTab(i).carName)
        'Next

    End Sub

    Private Sub edit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If (e.KeyCode = Keys.Add Or e.KeyCode = 187) And e.Control = True Then
            Dim id_formula As Long
            id_formula = lbFormulaId.Text

            If Not selectedFormulaColors Is Nothing Then
                fromAddFormula = False
                assignColorByCode.ShowDialog()
            End If
        End If
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        addMoreCars.AccessibleDescription = ""
        Me.Icon = HeadQHome.Icon
        setVariantsMouseHover()
        setChkBackColor()
        loadCars()
    End Sub
 
    Private Sub edit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not fromMinimize Then
            fromMinimize = False
            Me.Dispose()
            Me.disposeHiddenTextBoxes()
            HeadQHome.Visible = True
            HeadQHome.Show()
            If Not isBumperEdit And id_formulaComposedGlobal <> -1 Then 'coming from formulaComposed form
                formComposed.Visible = True
                formComposed.Show()
            End If
        End If

    End Sub
    Private Sub edit_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            fromMinimize = True
        Else
            fromMinimize = False
        End If
    End Sub
    Private Sub setVariantsMouseHover()
        chkVariantB.AccessibleDescription = chkVariantB.Text
        chkVariantCL.AccessibleDescription = chkVariantCL.Text
        chkVariantCO.AccessibleDescription = chkVariantCO.Text
        chkVariantD.AccessibleDescription = chkVariantD.Text
        chkVariantDRT.AccessibleDescription = chkVariantDRT.Text
        chkVariantF.AccessibleDescription = chkVariantF.Text
        chkVariantG.AccessibleDescription = chkVariantG.Text
        chkVariantL.AccessibleDescription = chkVariantL.Text
        chkVariantR.AccessibleDescription = chkVariantR.Text
        chkVariantY.AccessibleDescription = chkVariantY.Text

        Me.ToolTipVariant.SetToolTip(chkVariantB, "Blue")
        Me.ToolTipVariant.SetToolTip(chkVariantCL, "Cleaner")
        Me.ToolTipVariant.SetToolTip(chkVariantCO, "Coarser")
        Me.ToolTipVariant.SetToolTip(chkVariantD, "Darker")
        Me.ToolTipVariant.SetToolTip(chkVariantDRT, "Dirtier")
        Me.ToolTipVariant.SetToolTip(chkVariantF, "Finer")
        Me.ToolTipVariant.SetToolTip(chkVariantG, "Green")
        Me.ToolTipVariant.SetToolTip(chkVariantL, "Lighter")
        Me.ToolTipVariant.SetToolTip(chkVariantR, "Red")
        Me.ToolTipVariant.SetToolTip(chkVariantY, "Yellow")

        AddHandler chkVariantB.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantB.MouseLeave, AddressOf chkVariant_MouseLeave

        AddHandler chkVariantCL.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantCL.MouseLeave, AddressOf chkVariant_MouseLeave

        AddHandler chkVariantCO.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantCO.MouseLeave, AddressOf chkVariant_MouseLeave

        AddHandler chkVariantD.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantD.MouseLeave, AddressOf chkVariant_MouseLeave

        AddHandler chkVariantDRT.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantDRT.MouseLeave, AddressOf chkVariant_MouseLeave

        AddHandler chkVariantF.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantF.MouseLeave, AddressOf chkVariant_MouseLeave

        AddHandler chkVariantG.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantG.MouseLeave, AddressOf chkVariant_MouseLeave

        AddHandler chkVariantL.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantL.MouseLeave, AddressOf chkVariant_MouseLeave

        AddHandler chkVariantR.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantR.MouseLeave, AddressOf chkVariant_MouseLeave

        AddHandler chkVariantY.MouseHover, AddressOf chkVariant_MouseHover
        AddHandler chkVariantY.MouseLeave, AddressOf chkVariant_MouseLeave



        'on click
        AddHandler chkVariantB.MouseClick, AddressOf chkVariant_MouseClick

        AddHandler chkVariantCL.MouseClick, AddressOf chkVariant_MouseClick

        AddHandler chkVariantCO.MouseClick, AddressOf chkVariant_MouseClick

        AddHandler chkVariantD.MouseClick, AddressOf chkVariant_MouseClick

        AddHandler chkVariantDRT.MouseClick, AddressOf chkVariant_MouseClick

        AddHandler chkVariantF.MouseClick, AddressOf chkVariant_MouseClick

        AddHandler chkVariantG.MouseClick, AddressOf chkVariant_MouseClick

        AddHandler chkVariantL.MouseClick, AddressOf chkVariant_MouseClick

        AddHandler chkVariantR.MouseClick, AddressOf chkVariant_MouseClick

        AddHandler chkVariantY.MouseClick, AddressOf chkVariant_MouseClick



    End Sub

    Private Sub chkVariant_MouseClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chkbox As CheckBox = CType(sender, CheckBox)
        If chkbox.Checked = False Then
            chkbox.Checked = True
            lbVariants.Text = lbVariants.Text & chkbox.AccessibleDescription & "+"

        Else
            If Not chkbox.Font.Underline Then
                chkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lbVariants.Text = lbVariants.Text.Replace("+" & chkbox.AccessibleDescription & "+", "+" & chkbox.AccessibleDescription & "+" & chkbox.AccessibleDescription & "+")
            Else
                chkbox.Checked = False
                chkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lbVariants.Text = lbVariants.Text.Replace("+" & chkbox.AccessibleDescription & "+" & chkbox.AccessibleDescription & "+", "+")
            End If
        End If
        If Not lbVariants.Text.StartsWith("+") Then
            lbVariants.Text = "+" & lbVariants.Text
        End If
    End Sub


    Private Sub chkVariant_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chkbox As CheckBox = CType(sender, CheckBox)
        chkbox.Text = "   "
    End Sub

    Private Sub chkVariant_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chkbox As CheckBox = CType(sender, CheckBox)
        chkbox.Text = chkbox.AccessibleDescription
    End Sub

    Private Sub setChkBackColor()
        chkVariantD.BackgroundImage = variants(0).variantImage
        chkVariantF.BackgroundImage = variants(1).variantImage
        chkVariantDRT.BackgroundImage = variants(2).variantImage
        chkVariantL.BackgroundImage = variants(3).variantImage
        chkVariantR.BackgroundImage = variants(4).variantImage
        chkVariantY.BackgroundImage = variants(5).variantImage
        chkVariantB.BackgroundImage = variants(6).variantImage
        chkVariantCO.BackgroundImage = variants(7).variantImage
        chkVariantG.BackgroundImage = variants(8).variantImage
        chkVariantCL.BackgroundImage = variants(9).variantImage
    End Sub

    Public Sub disposeHiddenTextBoxes()
        txtYearMin.Text = ""
        txtYearMax.Text = ""
        txtFormulaCode.Text = ""
        txtCardNumber.Text = ""
        grpEdit.Visible = False
        'lbDuplicateName.Text = ""
        Try
            Dim controls As GroupBox.ControlCollection = grpEdit.Controls
            For j = 0 To controls.Count
                If (controls(j).Name.IndexOf("pctColorDetail") <> -1 And controls(j).Name.IndexOf("hidden") = -1) Or (controls(j).Name.IndexOf("txt") <> -1 And controls(j).Name.IndexOf("hidden") = -1) Or controls(j).Name = "butValidate" Or (controls(j).Name.IndexOf("butDeleteColor") <> -1 Or controls(j).Name.IndexOf("butAddColor") <> -1) Then
                    controls(j).Dispose()
                    j = 0
                End If

            Next
        Catch ex As Exception
        End Try

        Try
            Dim controls As Panel.ControlCollection = spltColor.Panel1.Controls
            For j = 0 To controls.Count
                If (controls(j).Name.IndexOf("pctColorDetail") <> -1 And controls(j).Name.IndexOf("hidden") = -1) Or (controls(j).Name.IndexOf("txt") <> -1 And controls(j).Name.IndexOf("hidden") = -1) Or controls(j).Name = "butValidate" Or (controls(j).Name.IndexOf("butDeleteColor") <> -1 Or controls(j).Name.IndexOf("butAddColor") <> -1) Then
                    controls(j).Dispose()
                    j = 0
                End If

            Next
        Catch ex As Exception
        End Try

        Try
            Dim controls As Panel.ControlCollection = spltColor.Panel2.Controls
            For j = 0 To controls.Count
                If (controls(j).Name.IndexOf("pctColorDetail") <> -1 And controls(j).Name.IndexOf("hidden") = -1) Or (controls(j).Name.IndexOf("txt") <> -1 And controls(j).Name.IndexOf("hidden") = -1) Or controls(j).Name = "butValidate" Or (controls(j).Name.IndexOf("butDeleteColor") <> -1 Or controls(j).Name.IndexOf("butAddColor") <> -1) Then
                    controls(j).Dispose()
                    j = 0
                End If

            Next
        Catch ex As Exception
        End Try
    End Sub

   

    Private Function getChosenVariant() As String
        
        Dim str As String
        str = lbVariants.Text

        'remove first +
        str = str.Substring(1)
        'remove the last +
        If str <> "" Then
            If str.Substring(str.Length - 1) = "+" Then
                str = str.Substring(0, str.Length - 1)
            End If
        End If
        Return str
    End Function

    Private Sub updateFormula(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If multiply <> 1 Then
                MsgBox("Please cancel the multiplication before saving")
                Return
            End If
            If (txtYearMax.Text <> "" And Not IsNumeric(txtYearMax.Text)) Or (txtYearMin.Text <> "" And Not IsNumeric(txtYearMin.Text)) Then
                MsgBox("Year must be numeric")
                Exit Sub
            End If

            Dim formula As Formula = getFormulaById(lbFormulaId.Text)
            formula.id_car = lbCarId.Text
            formula.type = cmbType.Text
            Dim version = cmbVersionEdit.Text
            If chkStar.Checked Then
                version = version & "*"
            End If
            formula.version = version
            Dim formulaVariant As String = getChosenVariant()
            formula.variant = formulaVariant
            formula.colorRGB = pctFormulaColor.BackColor.ToArgb()
            formula.c_year = txtYearMin.Text & " - " & txtYearMax.Text
            formula.colorCode = txtFormulaCode.Text
            formula.cardNumber = txtCardNumber.Text

            Dim deductedColor As System.Drawing.Color = Nothing
            Dim colorsCollectionArray As New ArrayList
            'check if data is valid in basic colors array
            If Not selectedFormulaColors Is Nothing Then
                Dim existingColorError As String = ""
                Dim invalidQuatityError As String = ""
                Dim selectedFormulaColorsTemp As FormulaColor() = selectedFormulaColors

                For i = 0 To selectedFormulaColorsTemp.Length - 1

                    Dim txtColorsDetail As TextBox = Controls.Find("txtColorsDetail" & i, True)(0)
                    Dim txtQuantityDetail As TextBox = Controls.Find("txtQuantityDetail" & i, True)(0)


                    Dim inputQuantity As String = txtQuantityDetail.Text
                    Dim inputColorCode As String = txtColorsDetail.Text



                    'test if colorCode exist
                    Dim bColor() As Color = getColors(" WHERE UCase(name_color)='" + SafeSqlLiteral(inputColorCode).ToUpper + "' OR UCase(colorCode)='" + SafeSqlLiteral(inputColorCode).ToUpper + "' ")

                    If Not bColor Is Nothing Then
                        If bColor.Length = 0 Then
                            bColor = Nothing 'ntek
                        End If
                    End If

                    If bColor Is Nothing Then
                        If existingColorError = "" Then
                            existingColorError = existingColorError & "- " & inputColorCode
                        Else
                            existingColorError = existingColorError & vbNewLine & "- " & inputColorCode
                        End If
                    Else
                        selectedFormulaColorsTemp(i).id_color = bColor(0).id_color

                        'concering the mixing of the colors
                        Dim colorARGB As System.Drawing.Color = Nothing
                        If Not bColor(0).argb Is Nothing Then
                            Dim colorAgbTab() As String = bColor(0).argb.Split(",")
                            If colorAgbTab.Length = 4 Then
                                Dim colorA As String = colorAgbTab(0)
                                Dim colorR As String = colorAgbTab(1)
                                Dim colorG As String = colorAgbTab(2)
                                Dim colorB As String = colorAgbTab(3)
                                colorARGB = System.Drawing.Color.FromArgb(colorA, colorR, colorG, colorB)
                                colorsCollectionArray.Add(colorARGB)
                            End If
                           
                        End If


                    End If
                    'test if Qty is numeric
                    If Not Microsoft.VisualBasic.IsNumeric(inputQuantity) Then
                        If invalidQuatityError = "" Then
                            invalidQuatityError = invalidQuatityError & "- " & inputQuantity
                        Else
                            invalidQuatityError = invalidQuatityError & vbNewLine & "- " & inputQuantity
                        End If
                    Else
                        selectedFormulaColorsTemp(i).quantite = inputQuantity
                    End If

                Next
                If formula.colorRGB Is Nothing Or formula.colorRGB = "" Then
                    If Not colorsCollectionArray Is Nothing Then
                        Dim colorsCollection() As System.Drawing.Color = DirectCast(colorsCollectionArray.ToArray(GetType(System.Drawing.Color)), System.Drawing.Color())
                        deductedColor = deduceColorFromCollection(colorsCollection)

                        formula.colorRGB = deductedColor.ToArgb
                    End If
                End If
                If existingColorError <> "" Or invalidQuatityError <> "" Then
                    Dim errorStr As String = ""
                    If existingColorError <> "" Then
                        errorStr = "The folowing Basic Colors:" & vbNewLine & existingColorError & vbNewLine & "doesnt exit"
                    End If

                    If invalidQuatityError <> "" Then
                        Dim newline As String = ""
                        If errorStr <> "" Then
                            newline = vbNewLine & vbNewLine
                        End If
                        errorStr = errorStr & newline & "The folowing quantities:" & vbNewLine & invalidQuatityError & vbNewLine & "must be numeric"
                    End If
                    MsgBox(errorStr, MsgBoxStyle.Exclamation)
                    Exit Sub
                Else
                    selectedFormulaColors = selectedFormulaColorsTemp
                End If


            End If
            'LS conversion
            If Not txtLSConv.Text.Trim = "" Then
                Dim coef As Decimal = txtLSConv.Text.Trim
                If Not Microsoft.VisualBasic.IsNumeric(coef) Then
                    MsgBox("the LS conv must be numeric", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                'get total qty first
                Dim totalQty As Decimal = 0
                For i = 0 To selectedFormulaColors.Length - 1
                    Dim curQty As Decimal = selectedFormulaColors(i).quantite
                    totalQty = totalQty + curQty
                Next


                For i = 0 To selectedFormulaColors.Length - 1
                    Dim curQty As Decimal = selectedFormulaColors(i).quantite
                    selectedFormulaColors(i).quantite = coef * curQty / totalQty
                Next
            End If
            '''''''''''''''''''''''''


            If chkApplyEquation.Checked Then
                selectedFormulaColors = applyEquation(selectedFormulaColors)
            End If

            Dim isApplyEquation15perc4201 As Integer = 0
            If chkEquation15perc4201.Checked Then
                If MsgBox("You have chosen to apply the 15%-4201 equation on this formula, continue?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    selectedFormulaColors = eq15perc4201(selectedFormulaColors)
                    isApplyEquation15perc4201 = 1
                Else
                    Exit Sub
                End If
            End If

            Dim isApplyEquationMajdiPerc As Integer = 0
            If chkMajdi.Checked Then
                Dim msg As String = "You have chosen to apply the Majdi % equation on this formula, continue?"
                If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    selectedFormulaColors = majdiPerc(selectedFormulaColors)
                    isApplyEquationMajdiPerc = 1
                Else
                    Exit Sub
                End If
            End If

            If chkClearLs.Checked Then
                Dim msg As String = "You have chosen to apply the Clear LS equation on this formula, continue?"
                If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    selectedFormulaColors = clearLsEquation(selectedFormulaColors)
                Else
                    Exit Sub
                End If
            End If

            If chkMajdi4conv.Checked Then
                Dim msg As String = "You have chosen to apply the Majdi 4 conv. % equation on this formula, continue?"
                If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    selectedFormulaColors = BC_4_conversions(selectedFormulaColors)
                Else
                    Exit Sub
                End If
            End If


            Dim currentFormulaColor() As FormulaColor = getFormulaColorsByIdFormula(formula.id_formula, formula.type)
            Dim setModifDate As Boolean = checkIfDifferentTab(currentFormulaColor, selectedFormulaColors)

            'set the apply equation data
            formula.isEquation4201_180 = chkEquation4201_180.Checked

            'check if multiple cars were selected
            If addMoreCars.AccessibleDescription = "fromEdit" And addMoreCars.chkBoxCars.CheckedItems.Count > 0 Then

                'update the initial formula
                Dim errMsg As String = ""
                If Not updateFormulaTable(formula, selectedFormulaColors, setModifDate) Then
                    errMsg = "Error for updating car:" & cmbCarNameModelEdit.Text
                End If
                ''''''''''''''''''''''''''''''''''''''
                Dim initialCarid As Integer = formula.id_car

                'looping through the checked checkboxes
                For i = 0 To addMoreCars.chkBoxCars.CheckedItems.Count - 1
                    Dim carName As String = addMoreCars.chkBoxCars.GetItemText(addMoreCars.chkBoxCars.CheckedItems(i))

                    Dim carsSelected() As Car = getCars(" WHERE carName ='" & carName & "'")
                    If carsSelected Is Nothing Then
                        MsgBox("Car '" & carName & "' doesn't exist!", MsgBoxStyle.Exclamation)
                        errMsg = errMsg & "Error: Car '" & carName & "' not found!"
                        Continue For
                    End If
                    If carsSelected.Length = 0 Then
                        errMsg = errMsg & "Error: Car '" & carName & "' not found!"
                        Continue For
                    End If

                    Dim carId As Integer = carsSelected(0).id_car
                    If carId = initialCarid Then
                        If MsgBox("Are you sure you want to add the same formula twice for the initial car '" & carName & "'?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            Continue For
                        End If
                    End If

                    formula.id_car = carId



                    If insertIntoFormula(isApplyEquationMajdiPerc, isApplyEquation15perc4201, formula.name_formula, formula.id_car, formula.type, formula.version, formula.variant, formula.colorCode, "", formula.colorRGB, formula.c_year, formula.cardNumber, formula.isEquation4201_180, formula.dateCreMod, False) Then
                        If Not selectedFormulaColors Is Nothing Then
                            If formula.type = "LS" Then
                                selectedFormulaColors = applyEquationLS(selectedFormulaColors, "01")
                                selectedFormulaColors = applyEquationLS(selectedFormulaColors, "10")
                            End If

                            Dim idFormula As Integer = getLastInsertedFormulaId()
                            Dim j As Integer
                            For j = 0 To selectedFormulaColors.Length - 1
                                If Not insertIntoFormulaColor(idFormula, selectedFormulaColors(j).id_color, selectedFormulaColors(j).quantite, selectedFormulaColors(j).id_Unit) Then
                                    errMsg = errMsg & vbNewLine & "Error for adding color_id '" & selectedFormulaColors(j).id_color & "' for the car '" & carName & "'"
                                End If
                            Next
                            Dim formulaColorRGBPercentage As String = getColorPercentage(selectedFormulaColors)
                            updateFormulaRGBPercentage(idFormula, formulaColorRGBPercentage)
                        End If
                    Else
                        errMsg = errMsg & vbNewLine & "Error for adding the car '" & carName & "'"
                    End If
                Next


                If errMsg = "" Then
                    MsgBox("Your formula has been updated for the car '" & cmbCarNameModelEdit.Text & "', and added for all the cars selected", MsgBoxStyle.Information, "Information")
                    disposeHiddenTextBoxes()
                    'curFamily = Nothing
                    'curSubFamily = Nothing
                    'Dim formulaNameChosen As String = lsvFormula.SelectedItems(0).SubItems(0).Text

                    'lbSelectedFormulavalue.Text = ""
                    'HeadQHome.lsvFamily.Items.Clear()
                    'HeadQHome.loadGarageHome()
                    Me.Close()
                Else
                    MsgBox("the folowwing errors occured:" & vbNewLine & errMsg, MsgBoxStyle.Exclamation)
                End If

            Else
                If updateFormulaTable(formula, selectedFormulaColors, setModifDate) Then
                    MsgBox("Your formula has been updated", MsgBoxStyle.Information, "Information")
                    disposeHiddenTextBoxes()
                    'curFamily = Nothing
                    'curSubFamily = Nothing
                    'Dim formulaNameChosen As String = lsvFormula.SelectedItems(0).SubItems(0).Text

                    'lbSelectedFormulavalue.Text = ""
                    'HeadQHome.lsvFamily.Items.Clear()
                    'HeadQHome.loadGarageHome()
                    Me.Close()
                Else
                    MsgBox("Your formula not updated", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox("Please printscreen this error:" & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub generatesDetails(ByVal formulaDup As Formula, Optional ByVal id_formulaComposed As Integer = -1, Optional ByVal isBumper As Boolean = False)
        isBumperEdit = isBumper
        disposeHiddenTextBoxes()
        If HeadQHome.lsvFamily.SelectedItems.Count = 0 Then
            Exit Sub
        End If


        Dim idFormula As Integer
        If id_formulaComposed = -1 And id_formulaComposedGlobal = -1 Then
            idFormula = HeadQHome.lsvFamily.SelectedItems(0).SubItems(0).Text
        Else
            If id_formulaComposed <> -1 Then
                idFormula = id_formulaComposed
                id_formulaComposedGlobal = id_formulaComposed
            Else
                idFormula = id_formulaComposedGlobal
            End If
        End If



        Dim selectedFormula As Formula
        selectedFormula = getFormulaById(idFormula)

        If Not formulaDup Is Nothing Then
            idFormula = formulaDup.id_formula
            selectedFormula = formulaDup
        End If

        If selectedFormulaColors Is Nothing Then
            selectedFormulaColors = getFormulaColorsByIdFormula(idFormula, selectedFormula.type)
        End If

        If selectedFormulaColors Is Nothing Then
            formulaCorrupted = True
            Exit Sub
        End If


        Dim totalPrice As Decimal = 0
        Dim totalQty As Decimal = 0

        Dim left As Integer = 0
        Dim top As Integer = 0
        Dim formulaName As String = ""
        Dim carNameModel As String = ""
        Dim type As String = ""
        Dim version As String = ""
        Dim carId As Long = -1
        Dim formulaId As Long = -1

        Dim thisFormulas As Formula = getFormulaById(selectedFormula.id_formula)
        'equation info
        Dim isApplyEquation15perc4201 As Boolean = False
        If thisFormulas.isEquation15perc4201 Then
            lbEquation.Visible = True
            chkEquation15perc4201.Enabled = False
        Else
            lbEquation.Visible = False
        End If

        Dim isApplyEquation4201_180 As Boolean = True
        If thisFormulas.isEquation4201_180 Then
            chkEquation4201_180.Checked = True
        End If

        formulaName = thisFormulas.name_formula
        Dim car As Car
        car = getCarById(thisFormulas.id_car)
        carNameModel = car.carName
        type = thisFormulas.type
        version = thisFormulas.version
        carId = car.id_car
        formulaId = selectedFormula.id_formula

        lbAsteriks.Visible = Not thisFormulas.modified_once

        Dim i As Integer
        For i = 0 To selectedFormulaColors.Length - 1

            Dim color As Color = getColorById(selectedFormulaColors(i).id_color)
            Dim colorUnitPrice = color.defaultPrice
            'colorUnitPrice = convertToChosenUnit(colorUnitPrice, getUnit(color.id_defaultUnit).rateToLitre)
            colorUnitPrice = convertToChosenCurrency(colorUnitPrice, getCurrency(color.id_defaultCurreny).rateToDollar)
            colorUnitPrice = colorUnitPrice * ratio

            Dim quantity As Decimal = selectedFormulaColors(i).quantite
            'quantity = convertToChosenUnit(quantity, getUnit(selectedFormulaColors(i).id_Unit).rateToLitre)
            quantity = quantity * ratio

            totalQty = totalQty + quantity

            Dim curColorPrice As Decimal = colorUnitPrice * quantity
            totalPrice = totalPrice + curColorPrice

            'color name 
            Dim txtColorsDetail As New TextBox
            txtColorsDetail.Name = "txtColorsDetail" & i
            'txtColorsDetail.ReadOnly = True
            txtColorsDetail.Visible = True
            txtColorsDetail.Top = txtColorsDetailHidden.Top + i * 25
            txtColorsDetail.Left = txtColorsDetailHidden.Left
            txtColorsDetail.Text = color.name_color
            txtColorsDetail.Anchor = txtColorsDetailHidden.Anchor
            txtColorsDetail.Size = txtColorsDetailHidden.Size
            'AddHandler txtColorsDetail.KeyUp, AddressOf txtColorsCode_keyStroke

            spltColor.Panel1.Controls.Add(txtColorsDetail)

            left = txtColorsDetail.Left
            top = txtColorsDetail.Top

            'quantity 
            Dim txtQuantityDetail As New TextBox
            txtQuantityDetail.Name = "txtQuantityDetail" & i
            'txtQuantityDetail.ReadOnly = True
            txtQuantityDetail.Visible = True
            txtQuantityDetail.Top = txtQuantityDetailHidden.Top + i * 25
            txtQuantityDetail.Left = txtQuantityDetailHidden.Left
            txtQuantityDetail.Text = Math.Round(quantity, 1)
            txtQuantityDetail.Anchor = txtQuantityDetailHidden.Anchor
            txtQuantityDetail.Size = txtQuantityDetailHidden.Size
            'AddHandler txtQuantityDetail.KeyUp, AddressOf txtColorsCode_keyStroke

            spltColor.Panel2.Controls.Add(txtQuantityDetail)

            '
            Dim pctColorDetail As New PictureBox
            pctColorDetail.Name = "pctColorDetail" & i
            pctColorDetail.AccessibleDescription = i
            pctColorDetail.Visible = True
            pctColorDetail.Top = pctColorDetailHidden.Top + i * 25
            pctColorDetail.Left = pctColorDetailHidden.Left
            pctColorDetail.Width = pctColorDetailHidden.Width
            pctColorDetail.Height = pctColorDetailHidden.Height

            Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & color.colorImgPath
            Try

                pctColorDetail.BackgroundImage = Image.FromFile(imgPath)
                pctColorDetail.BackgroundImageLayout = pctColorDetailHidden.BackgroundImageLayout
            Catch ex As Exception

            End Try

            pctColorDetail.Anchor = pctColorDetailHidden.Anchor

            spltColor.Panel1.Controls.Add(pctColorDetail)


            Dim butDeleteColor As New System.Windows.Forms.Button()
            butDeleteColor.AccessibleDescription = selectedFormulaColors(i).id_formulaColor
            butDeleteColor.Name = "butDeleteColor" & i
            butDeleteColor.Visible = True
            butDeleteColor.Enabled = True
            butDeleteColor.Top = txtQuantityDetail.Top
            butDeleteColor.Left = txtQuantityDetail.Left + txtQuantityDetail.Width + 10
            butDeleteColor.Text = "-"
            butDeleteColor.Width = butDeleteHidden.Width
            butDeleteColor.Height = butDeleteHidden.Height
            butDeleteColor.Anchor = butDeleteHidden.Anchor
            butDeleteColor.BringToFront()
            AddHandler butDeleteColor.Click, AddressOf deleteColorToFormula
            spltColor.Panel2.Controls.Add(butDeleteColor)

            'id
            Dim lbIdFormulaColor As New Windows.Forms.Label
            lbIdFormulaColor.Name = "lbIdFormulaColor" & i
            lbIdFormulaColor.Visible = False
            lbIdFormulaColor.Top = txtQuantityDetail.Top
            lbIdFormulaColor.Left = txtQuantityDetail.Left + 100
            lbIdFormulaColor.Text = selectedFormulaColors(i).id_formulaColor
            lbIdFormulaColor.Anchor = txtQuantityDetail.Anchor
            spltColor.Panel1.Controls.Add(lbIdFormulaColor)

        Next

        Dim butAddColor As New System.Windows.Forms.Button()
        butAddColor.Name = "butAddColor"
        butAddColor.Visible = True
        butAddColor.Enabled = True
        If top = 0 Then
            butAddColor.Top = butAddHidden.Top
            butAddColor.Left = butAddHidden.Left
        Else
            butAddColor.Top = top + 25
            butAddColor.Left = left
        End If

        butAddColor.Text = "+"
        butAddColor.Width = butAddHidden.Width
        butAddColor.Height = butAddHidden.Height
        butAddColor.Anchor = butAddHidden.Anchor
        butAddColor.BringToFront()
        AddHandler butAddColor.Click, AddressOf addColorToFormula

        spltColor.Panel1.Controls.Add(butAddColor)

        pctFormulaColor.BackColor = System.Drawing.Color.FromArgb(getFormulaById(formulaId).colorRGB)

        cmbCarNameModelEdit.Text = carNameModel

        cmbType.Text = type
        If Not version Is Nothing Then
            If version.IndexOf("*") > -1 Then
                chkStar.Checked = True
                version = version.Replace("*", "")
            End If
        End If
        cmbVersionEdit.Text = version
        lbCarId.Text = carId

        If totalQty > 0 Then
            lbQuantity.Text = "Quantity (" & Math.Round(totalQty, 2) & ")"
        Else
            lbQuantity.Text = "Quantity"
        End If
        If Not selectedFormula.dateCreMod = Nothing Then
            txtModDate.Text = selectedFormula.dateCreMod.ToShortDateString & " " & selectedFormula.dateCreMod.ToShortTimeString
        End If

        lbFormulaId.Text = formulaId
        txtFormulaCode.Text = selectedFormula.colorCode
        txtCardNumber.Text = selectedFormula.cardNumber
        Dim yearStr As String = getFormulaById(formulaId).c_year
        Try
            Dim iYearMin As Long = yearStr.Substring(0, yearStr.IndexOf("-")).Trim
            txtYearMin.Text = iYearMin
        Catch
        End Try
        Try
            Dim iYearMax As Long = yearStr.Substring(yearStr.IndexOf("-") + 2).Trim
            txtYearMax.Text = iYearMax
        Catch
        End Try

        Dim formulaVariant As String = getFormulaById(formulaId).variant
        chkVariantD.Checked = False
        chkVariantF.Checked = False
        chkVariantDRT.Checked = False
        chkVariantL.Checked = False
        chkVariantR.Checked = False
        chkVariantY.Checked = False
        chkVariantB.Checked = False
        chkVariantCO.Checked = False
        chkVariantG.Checked = False
        chkVariantCL.Checked = False
        If Not formulaVariant Is Nothing Then
            If formulaVariant.Trim <> "" Then
                lbVariants.Text = lbVariants.Text & formulaVariant.Trim & "+"
                Dim formulaVariants() As String = formulaVariant.Split("+")
                Dim j As Integer

                For j = 0 To formulaVariants.Length - 1

                    If formulaVariants(j) = "D" And chkVariantD.Checked Then
                        chkVariantD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "D" Then
                            chkVariantD.Checked = True
                        End If
                    End If


                    If formulaVariants(j) = "F" And chkVariantF.Checked Then
                        chkVariantF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "F" Then
                            chkVariantF.Checked = True
                        End If
                    End If

                    If formulaVariants(j) = "DRT" And chkVariantDRT.Checked Then
                        chkVariantDRT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "DRT" Then
                            chkVariantDRT.Checked = True
                        End If
                    End If

                    If formulaVariants(j) = "L" And chkVariantL.Checked Then
                        chkVariantL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "L" Then
                            chkVariantL.Checked = True
                        End If
                    End If

                    If formulaVariants(j) = "R" And chkVariantR.Checked Then
                        chkVariantR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "R" Then
                            chkVariantR.Checked = True
                        End If
                    End If


                    If formulaVariants(j) = "Y" And chkVariantY.Checked Then
                        chkVariantY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "Y" Then
                            chkVariantY.Checked = True
                        End If
                    End If

                    If formulaVariants(j) = "B" And chkVariantB.Checked Then
                        chkVariantB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "B" Then
                            chkVariantB.Checked = True
                        End If
                    End If

                    If formulaVariants(j) = "CO" And chkVariantCO.Checked Then
                        chkVariantCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "CO" Then
                            chkVariantCO.Checked = True
                        End If
                    End If

                    If formulaVariants(j) = "G" And chkVariantG.Checked Then
                        chkVariantG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "G" Then
                            chkVariantG.Checked = True
                        End If
                    End If

                    If formulaVariants(j) = "CL" And chkVariantCL.Checked Then
                        chkVariantCL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    Else
                        If formulaVariants(j) = "CL" Then
                            chkVariantCL.Checked = True
                        End If
                    End If
                Next
            End If
        End If

        If selectedFormulaColors.Length > 0 Then

            Dim butValidate As New System.Windows.Forms.Button()

            butValidate.Name = "butValidate"
            butValidate.Visible = True
            butValidate.Enabled = True
            butValidate.Top = butValidateHidden.Top
            butValidate.Left = butValidateHidden.Left
            butValidate.Text = butValidateHidden.Text
            butValidate.Font = butValidateHidden.Font
            butValidate.Width = butValidateHidden.Width
            butValidate.Height = butValidateHidden.Height
            butValidate.Anchor = butValidateHidden.Anchor
            butValidate.BringToFront()

            AddHandler butValidate.Click, AddressOf updateFormula
            grpEdit.Controls.Add(butValidate)

            Dim textBox As TextBox = grpEdit.Controls.Find("txtColorsDetail0", True)(0)
            textBox.Focus()
        End If
        Me.Text = selectedFormula.name_formula
        'lbDuplicateName.Text = selectedFormula.duplicate
    End Sub

    Private Sub addColorToFormula(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim id_formula As Long
        id_formula = lbFormulaId.Text

        If Not selectedFormulaColors Is Nothing Then
            fromAddFormula = False
            assignColor.ShowDialog()
        End If
    End Sub
    Private Sub deleteColorToFormula(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If MsgBox("Are you sure of this action", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim but As Button = CType(sender, Button)
            Dim id_formulaColor As Integer = but.AccessibleDescription

            Dim MyArray As New ArrayList
            Dim i As Integer
            For i = 0 To selectedFormulaColors.Length - 1
                If (selectedFormulaColors(i).id_formulaColor <> id_formulaColor) Then
                    MyArray.Add(selectedFormulaColors(i))

                End If
            Next

            selectedFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
            Dim carid As String = lbCarId.Text
            Dim carNameModel As String = cmbCarNameModelEdit.Text
            Dim version As String = cmbVersionEdit.Text
            If chkStar.Checked Then
                version = version & "*"
            End If

            Dim type As String = cmbType.Text
            generatesDetails(formulaDup)
            lbCarId.Text = carid
            cmbCarNameModelEdit.Text = carNameModel
            cmbVersionEdit.Text = version
            cmbType.Text = type
            'txtYearEdit.Text = 
            grpEdit.Visible = True

        End If
    End Sub

    Private Sub pctCarImgDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctCarImgDetails.Click
        If Not imageToPreview Is Nothing Then
            imagePreview.ShowDialog()
        End If
    End Sub

    Private Sub cmbCarNameModelEdit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCarNameModelEdit.SelectedIndexChanged
        Dim chosenCar As Car = Nothing
        If cmbCarNameModelEdit.SelectedIndex > 0 Then
            chosenCar = getCars("")(cmbCarNameModelEdit.SelectedIndex - 1)
        End If

        If Not chosenCar Is Nothing Then
            lbCarId.Text = chosenCar.id_car
            'cmbCarNameModelEdit.Text = chosenCar.carName
            Try
                Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & chosenCar.carImgPath
                imageToPreview = Image.FromFile(imgPath)
                pctCarImgDetails.Image = imageToPreview
                'pctCarImg.ImageLocation = imgPath
            Catch ex As IOException
                imageToPreview = Nothing
                pctCarImgDetails.Image = Nothing
                'MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
            End Try
            setLastChosenCar(chosenCar)
        Else
            imageToPreview = Nothing
            pctCarImgDetails.Image = Nothing
        End If
    End Sub

    Private Sub pctFormulaColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctFormulaColor.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            pctFormulaColor.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub butNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        formulaDup = getNextDuplicate(getFormulaById(lbFormulaId.Text))
        selectedFormulaColors = Nothing
        ratio = 1
        generatesDetails(formulaDup)
        'lbDuplicateName.Text = formulaDup.duplicate
        grpEdit.Visible = True

    End Sub

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        Me.Close()
    End Sub

    

    Private Sub butClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClear.Click
        cmbCarNameModelEdit.SelectedIndex = 0
        cmbType.SelectedIndex = 0
        cmbVersionEdit.SelectedIndex = 0
        lbCarId.Text = "-1"
        lbFormulaId.Text = "-1"
        txtFormulaCode.Text = ""
        txtCardNumber.Text = ""
        txtYearMin.Text = ""
        txtYearMax.Text = ""
        chkStar.Checked = False
        chkVariantD.Checked = False
        chkVariantB.Checked = False
        chkVariantCL.Checked = False
        chkVariantCO.Checked = False
        chkVariantDRT.Checked = False
        chkVariantF.Checked = False
        chkVariantG.Checked = False
        chkVariantL.Checked = False
        chkVariantR.Checked = False
        chkVariantY.Checked = False

    End Sub

    Private Sub butAddCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddCar.Click
        addMoreCars.AccessibleDescription = "fromEdit"
        addMoreCars.ShowDialog()
    End Sub

    Private multiply As Decimal = 1
    Private Sub butMultiply_Click(sender As Object, e As EventArgs) Handles butMultiply.Click
        If multiply = 1 Then

            'do multiply
            Try
                multiply = Convert.ToDecimal(InputBox("Enter Number :-> ", "User Input", "1"))

            Catch ex As Exception
                MsgBox("Wrong number!", MsgBoxStyle.Exclamation)
                Return
            End Try
            butMultiply.Text = "Cancel multiplication"
            butMultiply.ForeColor = Drawing.Color.Red
            lbMultiplyBy.Text = "x" & multiply
            'multiply all qty by "multiply"
            For Each element In spltColor.Panel2.Controls
                If element.Name.StartsWith("txtQuantityDetail") Then
                    element.text = Math.Round(element.text * multiply, 1)

                End If
            Next
            '''''''''''''''''''''''''''''''''
        Else
            'cancel multiply

            butMultiply.Text = "Multiply quantities by"
            butMultiply.ForeColor = Drawing.Color.Green
            lbMultiplyBy.Text = "x1"
            'divide all qty by "multiply"
            For Each element In spltColor.Panel2.Controls
                If element.Name.StartsWith("txtQuantityDetail") Then
                    element.text = Math.Round(element.text / multiply, 1)
                End If
            Next
            '''''''''''''''''''''''''''''''''
            multiply = 1
            ''''''''''''''''''''''''''''''''''''''''''
        End If
       
    End Sub


End Class