Imports System.IO
Public Class addFormula

    Public chosenFormulaColors() As FormulaColor
    Public multiCarFormulaColors()() As FormulaColor = Nothing
    Public multiCarNameCode() As MultiCarNameCode = Nothing
    Public ratioFormulaColor As Decimal
    Public fromMinimize As Boolean = False
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

    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSave.Click
        Dim multiMode As Boolean = False
        If Not multiCarFormulaColors Is Nothing Then
            If Not multiCarFormulaColors.Length = 0 Then
                multiMode = True
            End If
        End If
        If multiMode Then
            Dim success As Boolean = True
            For i = 0 To multiCarFormulaColors.Length - 1
                Dim carId As Integer = multiCarFormulaColors(i)(0).id_car
                If Not affectFormulaColor(multiCarFormulaColors(i), carId, multiCarNameCode(i).formulaName, multiCarNameCode(i).formulaCode) Then
                    Dim carsSelected As Car = getCarById(carId)
                    MsgBox("formula for car " & carsSelected.carName & " was not saved", MsgBoxStyle.Exclamation)
                End If
            Next
            HeadQHome.txtFormulaName.Text = ""
            HeadQHome.cmbCarNameSearch.Text = ""
            Me.Dispose()

        Else
            If affectFormulaColor(chosenFormulaColors, lbCarId.Text, txtFormulaName.Text, txtColorCode.Text) Then
                HeadQHome.txtFormulaName.Text = ""
                HeadQHome.cmbCarNameSearch.Text = ""
                Me.Dispose()
            End If
        End If


    End Sub

    Private Function affectFormulaColor(ByVal formulaColorTab() As FormulaColor, ByVal carId As Integer, ByVal formulaName As String, ByVal formulaCode As String) As Boolean
        'Dim formulaName As String = txtFormulaName.Text

        If formulaName = "" Then
            MsgBox("Formula must have a name '" & formulaCode & "'", MsgBoxStyle.Information)
            Return False
        End If
        Dim formulaVariant As String = getChosenVariant()
        Dim version As String = cmbVersion.Text
        If chkStar.Checked Then
            version = version & "*"
        End If
        'MsgBox(pctFormulaColor.BackColor.ToArgb)
        'Dim testColor As System.Drawing.Color = System.Drawing.Color.FromArgb(pctFormulaColor.BackColor.ToArgb)
        'Exit Sub
        Dim c_year As String = txtYearMin.Text & " - " & txtYearMax.Text

        Dim isApplyEquation15perc4201 As Integer = 0
        Dim isApplyEquationMajdiPerc As Integer = 0
        Dim formulaColorsEq3() As FormulaColor = Nothing
        Dim allowSave As Boolean = True
        Dim formulaColorRGB As String = Nothing
        If Not pctFormulaColor.BackColor = Nothing Then
            formulaColorRGB = pctFormulaColor.BackColor.ToArgb
        End If

        If chkEquation15perc4201.Checked Then
            Dim msg As String = "You have chosen to apply the 15%-4201 equation on this formula, continue?"
            If cmbType.Text = "LS" Then
                msg = "You have chosen to apply the 15%-4201 equation on this ""LS"" formula, are you sure you want to continue?"
            End If
            If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                formulaColorTab = eq15perc4201(formulaColorTab)
                isApplyEquation15perc4201 = 1
            Else
                Exit Function
            End If
        End If

       


        If cmbType.Text.Trim.ToUpper = "BC/2K" Then
            formulaColorsEq3 = applyEquation3(formulaColorTab)
            If formulaColorsEq3 Is Nothing Then
                allowSave = False
            End If
        End If


        If allowSave Then
            Dim type As String = cmbType.Text
            If type = "LS" Then
                formulaColorTab = applyEquationLS(formulaColorTab, "01")
                formulaColorTab = applyEquationLS(formulaColorTab, "10")
            Else


                If type = "BC/2K" Then
                    type = "BC"
                Else
                    If type = "2K" Then
                        If chkApplyEquation.Checked Then
                            formulaColorTab = renderEquation(applyEquation(formulaColorTab))

                        End If
                    End If
                End If
            End If

            If chkMajdi.Checked Then
                Dim msg As String = "You have chosen to apply the Majdi % equation on this formula, continue?"
                If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    formulaColorTab = majdiPerc(formulaColorTab)
                    isApplyEquationMajdiPerc = 1
                Else
                    Exit Function
                End If
            End If

            If chkClearLs.Checked Then
                Dim msg As String = "You have chosen to apply the Clear LS equation on this formula, continue?"
                If MsgBox(msg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    formulaColorTab = clearLsEquation(formulaColorTab)
                Else
                    Exit Function
                End If
            End If
            formulaColorTab = applyEquation4503(formulaColorTab)
            formulaColorTab = applyEquation4761(formulaColorTab)
            formulaColorTab = applyEquation4001(formulaColorTab)

            'formulaColorTab = applyEquation4010(formulaColorTab, formulaName)

            If insertIntoFormula(isApplyEquationMajdiPerc, isApplyEquation15perc4201, formulaName, carId, type, version, formulaVariant, formulaCode, "", formulaColorRGB, c_year, txtCardNumber.Text, True) Then
                If Not formulaColorTab Is Nothing Then
                    Dim idFormula As Integer = getLastInsertedFormulaId()
                    Dim i As Integer
                    For i = 0 To formulaColorTab.Length - 1
                        If Not insertIntoFormulaColor(idFormula, formulaColorTab(i).id_color, formulaColorTab(i).quantite, formulaColorTab(i).id_Unit) Then
                            MsgBox("Color already exist for this formula '" & formulaCode & "'", MessageBoxIcon.Information)
                            Return False
                        End If
                    Next
                    Dim formulaColorRGBPercentage As String = getColorPercentage(formulaColorTab)
                    updateFormulaRGBPercentage(idFormula, formulaColorRGBPercentage)
                End If

            End If

            If Not formulaColorsEq3 Is Nothing Then
                If chkApplyEquation.Checked Then
                    formulaColorsEq3 = renderEquation(applyEquation(formulaColorsEq3))
                End If
                If insertIntoFormula(isApplyEquationMajdiPerc, isApplyEquation15perc4201, formulaName, carId, "2K", version, formulaVariant, formulaCode, "", formulaColorRGB, c_year, txtCardNumber.Text, True) Then
                    If Not formulaColorsEq3 Is Nothing Then
                        Dim idFormula As Integer = getLastInsertedFormulaId()
                        Dim i As Integer
                        For i = 0 To formulaColorsEq3.Length - 1
                            If Not insertIntoFormulaColor(idFormula, formulaColorsEq3(i).id_color, formulaColorsEq3(i).quantite, formulaColorsEq3(i).id_Unit) Then
                                MsgBox("Color already exist for this formula '" & formulaCode & "' (Form the equation of BC/2K)", MessageBoxIcon.Information)
                                Return False
                            End If
                        Next
                        Dim formulaColorRGBPercentage As String = getColorPercentage(formulaColorsEq3)
                        updateFormulaRGBPercentage(idFormula, formulaColorRGBPercentage)
                    End If

                End If
            End If
        End If
        Return True
    End Function

    Private Sub butFindCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        carsForm.ShowDialog()
    End Sub

    Private Sub butclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butclose.Click
        Me.Dispose()
    End Sub

    Private Sub addFormula_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not fromMinimize Then
            fromMinimize = False
            Me.Dispose()
            Me.disposeHiddenTextBoxes()
            HeadQHome.Visible = True
            HeadQHome.Show()
           
        End If
    End Sub


    Private Sub addFormula_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Try
            If (e.KeyCode = Keys.Add Or e.KeyCode = 187) And e.Control = True Then
                fromAddFormula = True
                assignColorByCode.MdiParent = Me

                assignColorByCode.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub keepOriginalBackColorWhenIsMdi()

        ' TO keep the default backcolor, even when isMdiContainer = true
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub addFormula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        keepOriginalBackColorWhenIsMdi()

        loadCars()
        generatesDetails(chosenFormulaColors)
        setChkBackColor()
        loadBaseCoat()
        setVariantsMouseHover()
        colors = getColors()
        If cmbType.Text = "BC/2K" Then
            chkApplyEquation.Checked = False
            chkApplyEquation.Enabled = True
        End If
        If cmbType.Text = "BC" Then
            chkApplyEquation.Checked = False
            chkApplyEquation.Enabled = False
        End If
        If cmbType.Text = "2K" Then
            chkApplyEquation.Checked = False
            chkApplyEquation.Enabled = True
        End If

        Me.Location = New Point(0, 0)
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
    Private Sub chkVariant_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chkbox As CheckBox = CType(sender, CheckBox)
        chkbox.Text = "   "
    End Sub
    Private Sub chkVariant_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        Dim chkbox As CheckBox = CType(sender, CheckBox)
        If e.Button = MouseButtons.Right Then
            chkbox.Checked = False
            chkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lbVariants.Text = lbVariants.Text.Replace("+" & chkbox.AccessibleDescription & "+" & chkbox.AccessibleDescription & "+", "+")
        Else
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
        End If

        If Not lbVariants.Text.StartsWith("+") Then
            lbVariants.Text = "+" & lbVariants.Text
        End If
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
    Private Sub loadBaseCoat()
        Dim lastChosenBaseCoat As String = getLastChosenBaseCoat()
        If Not lastChosenBaseCoat Is Nothing Then
            cmbType.Text = lastChosenBaseCoat
        End If

    End Sub
    Private Sub loadCars()
        Dim carsTab() As Car = getCars("")
        Dim lastChosenCar As Car = getLastChosenCar()

        Dim i As Integer
        For i = 0 To carsTab.Length - 1
            cmbCars.Items.Add(carsTab(i).carName)
        Next

        If Not lastChosenCar Is Nothing Then
            lbCarId.Text = lastChosenCar.id_car
            cmbCars.Text = lastChosenCar.carName
            Try
                Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & lastChosenCar.carImgPath
                imageToPreview = Image.FromFile(imgPath)
                pctCarImg.Image = imageToPreview
                'pctCarImg.ImageLocation = imgPath
            Catch ex As IOException
                'MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub pctCarImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctCarImg.Click
        If Not imageToPreview Is Nothing Then
            imagePreview.ShowDialog()
        End If
    End Sub

    Private Sub pctCarImg_mouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctCarImg.MouseHover
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub
    Private Sub pctCarImg_mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctCarImg.MouseLeave
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    Private Sub cmbChosenCars_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChosenCars.SelectedIndexChanged

        Dim carName As String = sender.text
        Dim carsSelected() As Car = getCars(" WHERE carName ='" & carName & "'")
        If carsSelected Is Nothing Then
            MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If carsSelected.Length = 0 Then
            MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim chosenCar As Car = carsSelected(0)

        If Not chosenCar Is Nothing Then

            Try
                Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & chosenCar.carImgPath
                imageToPreview = Image.FromFile(imgPath)
                pctCarImg.Image = imageToPreview
                'pctCarImg.ImageLocation = imgPath
            Catch ex As IOException
                imageToPreview = Nothing
                pctCarImg.Image = imageToPreview
                'MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
            End Try
        End If
        'generate the code and formula name

        If Not multiCarNameCode Is Nothing Then
            For i = 0 To multiCarNameCode.Length - 1
                If multiCarNameCode(i).id_car = chosenCar.id_car Then
                    txtFormulaName.Text = multiCarNameCode(i).formulaName
                    txtColorCode.Text = multiCarNameCode(i).formulaCode
                    Exit For
                End If
            Next
        End If

        If Not multiCarFormulaColors Is Nothing Then
            'get formulaColorTab of this car
            Dim ind As Integer = -1
            For i = 0 To multiCarFormulaColors.Length - 1
                Dim formColTab() As FormulaColor
                formColTab = multiCarFormulaColors(i)
                If Not formColTab Is Nothing Then
                    If Not formColTab.Length = 0 Then
                        Dim idCar As Integer = formColTab(0).id_car
                        If idCar = chosenCar.id_car Then
                            ind = i
                            Exit For
                        End If
                    End If
                End If
            Next
            If ind <> -1 Then

                chosenFormulaColors = multiCarFormulaColors(ind)
                generatesDetails(multiCarFormulaColors(ind))
            Else
                generatesDetails(Nothing)
            End If
        End If


    End Sub


    Private Sub cmbCars_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCars.SelectedIndexChanged
        Dim chosenCar As Car
        chosenCar = getCars("")(cmbCars.SelectedIndex)

        If Not chosenCar Is Nothing Then
            lbCarId.Text = chosenCar.id_car
            cmbCars.Text = chosenCar.carName
            Try
                Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & chosenCar.carImgPath
                imageToPreview = Image.FromFile(imgPath)
                pctCarImg.Image = imageToPreview
                'pctCarImg.ImageLocation = imgPath
            Catch ex As IOException
                imageToPreview = Nothing
                pctCarImg.Image = imageToPreview
                'MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
            End Try
        End If
        setLastChosenCar(chosenCar)
    End Sub
    Private Sub txtColorsCode_keyStroke(ByVal sender As System.Object, ByVal e As KeyEventArgs)
        If e.KeyCode = 107 Then
            fromAddFormula = True
            assignColorByCode.ShowDialog()
        End If
    End Sub
    Public Sub generatesDetails(ByVal formulaColors As FormulaColor())
        disposeHiddenTextBoxes()
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

        Dim i As Integer
        If Not formulaColors Is Nothing Then
            For i = 0 To formulaColors.Length - 1

                Dim color As Color = getColorById(formulaColors(i).id_color)
                Dim colorUnitPrice = color.defaultPrice
                'colorUnitPrice = convertToChosenUnit(colorUnitPrice, getUnit(color.id_defaultUnit).rateToLitre)
                colorUnitPrice = convertToChosenCurrency(colorUnitPrice, getCurrency(color.id_defaultCurreny).rateToDollar)
                colorUnitPrice = colorUnitPrice * ratioFormulaColor

                Dim quantity As Decimal = formulaColors(i).quantite
                'quantity = convertToChosenUnit(quantity, getUnit(chosenFormulaColors(i).id_Unit).rateToLitre)
                quantity = quantity * ratioFormulaColor

                totalQty = totalQty + quantity

                Dim curColorPrice As Decimal = colorUnitPrice * quantity
                totalPrice = totalPrice + curColorPrice

                'color name 
                Dim txtColorsDetail As New TextBox
                txtColorsDetail.Name = "txtColorsDetail" & i
                txtColorsDetail.ReadOnly = True
                txtColorsDetail.Visible = True
                txtColorsDetail.Top = txtColorsDetailHidden.Top + i * 25
                txtColorsDetail.Left = txtColorsDetailHidden.Left
                txtColorsDetail.Text = color.name_color
                txtColorsDetail.Size = txtColorsDetailHidden.Size
                txtColorsDetail.Anchor = txtColorsDetailHidden.Anchor
                'txtColorsDetail.BackColor = Drawing.Color.Gray
                AddHandler txtColorsDetail.KeyUp, AddressOf txtColorsCode_keyStroke
                Me.Controls.Add(txtColorsDetail)
                left = txtColorsDetail.Left
                top = txtColorsDetail.Top

                'quantity 
                Dim txtQuantityDetail As New TextBox
                txtQuantityDetail.Name = "txtQuantityDetail" & i
                txtQuantityDetail.ReadOnly = True
                txtQuantityDetail.Visible = True
                txtQuantityDetail.Top = txtQuantityDetailHidden.Top + i * 25
                txtQuantityDetail.Left = txtQuantityDetailHidden.Left
                txtQuantityDetail.Size = txtQuantityDetailHidden.Size
                txtQuantityDetail.Text = Math.Round(quantity, 2)
                txtQuantityDetail.Anchor = txtQuantityDetailHidden.Anchor
                'txtQuantityDetail.BackColor = Drawing.Color.Gray
                AddHandler txtQuantityDetail.KeyUp, AddressOf txtColorsCode_keyStroke
                Me.Controls.Add(txtQuantityDetail)

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

                Me.Controls.Add(pctColorDetail)


                Dim butEditolor As New System.Windows.Forms.Button()
                butEditolor.AccessibleDescription = i
                butEditolor.Name = "butEditColor" & i
                butEditolor.Visible = True
                butEditolor.Enabled = True
                butEditolor.Top = txtQuantityDetail.Top
                butEditolor.Left = txtQuantityDetail.Left + txtQuantityDetail.Width + 10
                butEditolor.Text = "Edit"
                butEditolor.Width = butEditHidden.Width
                butEditolor.Height = butEditHidden.Height
                butEditolor.Anchor = butEditHidden.Anchor
                butEditolor.BringToFront()
                AddHandler butEditolor.Click, AddressOf editColorToFormula
                Me.Controls.Add(butEditolor)

                Dim butDeleteColor As New System.Windows.Forms.Button()
                butDeleteColor.AccessibleDescription = formulaColors(i).id_color
                butDeleteColor.Name = "butDeleteColor" & i
                butDeleteColor.Visible = True
                butDeleteColor.Enabled = True
                butDeleteColor.Top = txtQuantityDetail.Top
                butDeleteColor.Left = butEditolor.Left + butEditolor.Width + 10
                butDeleteColor.Text = "-"
                butDeleteColor.Width = butDeleteHidden.Width
                butDeleteColor.Height = butDeleteHidden.Height
                butDeleteColor.Anchor = butDeleteHidden.Anchor
                butDeleteColor.BringToFront()
                AddHandler butDeleteColor.Click, AddressOf deleteColorToFormula
                Me.Controls.Add(butDeleteColor)


               

                'id
                Dim lbIdFormulaColor As New Windows.Forms.Label
                lbIdFormulaColor.Name = "lbIdFormulaColor" & i
                lbIdFormulaColor.Visible = False
                lbIdFormulaColor.Top = txtQuantityDetail.Top
                lbIdFormulaColor.Left = txtQuantityDetail.Left + 100
                lbIdFormulaColor.Text = formulaColors(i).id_formulaColor
                lbIdFormulaColor.Anchor = txtQuantityDetail.Anchor
                Me.Controls.Add(lbIdFormulaColor)

            Next
            reAssign()
        End If


        reAssignChosenFormulaColor()
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

        Me.Controls.Add(butAddColor)

        lbQuantity.Text = "Quantity"

        totalQty = Math.Round(totalQty, 2)
        If totalQty > 0 Then
        lbQuantity.Text = "Quantity (" & totalQty & ")"
        End If


        ' If chosenFormulaColors.Length > 0 Then

        ' Dim butValidate As New System.Windows.Forms.Button()

        ' butValidate.Name = "butValidate"
        ' butValidate.Visible = True
        ' butValidate.Enabled = True
        ' butValidate.Top = butValidateHidden.Top
        ' butValidate.Left = butValidateHidden.Left
        ' butValidate.Text = butValidateHidden.Text
        ' butValidate.Font = butValidateHidden.Font
        ' butValidate.Width = butValidateHidden.Width
        ' butValidate.Height = butValidateHidden.Height
        'butValidate.Anchor = butValidateHidden.Anchor
        ' butValidate.BringToFront()

        'AddHandler butValidate.Click, AddressOf updateFormula
        'grpEdit.Controls.Add(butValidate)
        'End If
    End Sub
    Public Sub disposeHiddenTextBoxes()
        Try

            Dim controls As GroupBox.ControlCollection = Me.Controls

            Dim j As Integer

            For j = 0 To controls.Count

                If (controls(j).Name.IndexOf("pctColorDetail") <> -1 And controls(j).Name.IndexOf("hidden") = -1) Or (controls(j).Name.IndexOf("txt") <> -1 And controls(j).Name.IndexOf("hidden") = -1) Or controls(j).Name = "butValidate" Or (controls(j).Name.IndexOf("butEditColor") <> -1 Or controls(j).Name.IndexOf("butDeleteColor") <> -1 Or controls(j).Name.IndexOf("butAddColor") <> -1) Then
                    controls(j).Dispose()
                    j = 0
                End If

            Next

        Catch ex As Exception

        End Try

    End Sub
    Private Sub deleteColorToFormula(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Are you sure of this action", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim but As Button = CType(sender, Button)
            Dim idColor As Integer = but.AccessibleDescription

            Dim MyArray As New ArrayList
            Dim i As Integer
            For i = 0 To chosenFormulaColors.Length - 1
                If (chosenFormulaColors(i).id_color <> idColor) Then
                    MyArray.Add(chosenFormulaColors(i))

                End If
            Next

            chosenFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
            Dim type As String = cmbType.Text
            generatesDetails(chosenFormulaColors)

        End If

    End Sub

    Private Sub addColorToFormula(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fromAddFormula = True
        assignColor.ShowDialog()
    End Sub

    Private Sub editColorToFormula(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fromAddFormula = True
        fromEditFormula = True
        assignColorByCode.AccessibleDescription = sender.AccessibleDescription
        assignColorByCode.ShowDialog()
    End Sub


    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        setLastChosenBaseCoat(cmbType.Text)
        If cmbType.Text = "BC/2K" Then
            chkApplyEquation.Checked = False
            chkApplyEquation.Enabled = True
        End If
        If cmbType.Text = "BC" Then
            chkApplyEquation.Checked = False
            chkApplyEquation.Enabled = False
        End If
        If cmbType.Text = "2K" Then
            chkApplyEquation.Checked = False
            chkApplyEquation.Enabled = True
        End If
    End Sub

    Private Sub pctFormulaColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctFormulaColor.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            pctFormulaColor.BackColor = dlgColor.Color
        End If
    End Sub

   
    Private Sub butClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClear.Click
        'cmbCars.SelectedIndex = 0
        lbCarId.Text = "-1"
        pctCarImg.Image = Nothing
        lbFormulaId.Text = "-1"
        txtFormulaName.Text = ""
        txtColorCode.Text = ""
        txtCardNumber.Text = ""
        pctFormulaColor.Image = Nothing
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
        'cmbType.SelectedIndex = 0
        cmbVersion.Text = ""
        multiCarFormulaColors = Nothing

        cmbChosenCars.Items.Clear()
        Dim MyArray As New ArrayList
        chosenFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
        Dim type As String = cmbType.Text
        generatesDetails(chosenFormulaColors)

        addMoreCars.clear()
        cmbCars.Enabled = True
        cmbChosenCars.Items.Clear()
        cmbChosenCars.Visible = False

    End Sub

    Private Sub butAddCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddCar.Click
        addMoreCars.AccessibleDescription = "fromAdd"
        addMoreCars.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If multiCarFormulaColors Is Nothing Then
            Exit Sub
        End If
        MsgBox(multiCarFormulaColors.Length)
    End Sub
    Private Sub reAssignChosenFormulaColor()
        If Not multiCarFormulaColors Is Nothing Then
            'If MsgBox("Are you sure you want to assign the chosen colors to this car?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            'Exit Sub
            ' End If

            Dim carName As String = cmbChosenCars.Text
            Dim carsSelected() As Car = getCars(" WHERE carName ='" & carName & "'")
            If carsSelected Is Nothing Then
                'MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If carsSelected.Length = 0 Then
                'MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim chosenCar As Car = carsSelected(0)

            If Not chosenCar Is Nothing Then


                'get formulaColorTab of this car
                Dim ind As Integer = -1
                For i = 0 To multiCarFormulaColors.Length - 1
                    Dim formColTab() As FormulaColor
                    formColTab = multiCarFormulaColors(i)
                    Dim regetFromCmb As Boolean = True
                    If Not formColTab Is Nothing Then
                        If Not formColTab.Length = 0 Then
                            regetFromCmb = False
                        End If
                    End If
                    If Not regetFromCmb Then
                        Dim idCar As Integer = formColTab(0).id_car
                        If idCar = chosenCar.id_car Then
                            ind = i
                            Exit For
                        End If

                    Else 're get the id of this car depending of its name from the combobox

                        Dim carnameCmb As String = cmbChosenCars.GetItemText(cmbChosenCars.Items(i))
                        Dim carsSelectedcmb() As Car = getCars(" WHERE carName ='" & carnameCmb & "'")
                        If carsSelectedcmb Is Nothing Then
                            Exit Sub
                        End If
                        If carsSelectedcmb.Length = 0 Then
                            Exit Sub
                        End If

                        Dim idCar As Integer = carsSelectedcmb(0).id_car
                        If idCar = chosenCar.id_car Then
                            ind = i
                            Exit For
                        End If

                    End If
                Next
                If ind <> -1 Then
                    If multiCarFormulaColors(ind) Is Nothing Then
                        chosenFormulaColors = Nothing
                    Else
                        ReDim chosenFormulaColors(multiCarFormulaColors(ind).Length - 1)

                        For k = 0 To multiCarFormulaColors(ind).Length - 1
                            chosenFormulaColors(k) = New FormulaColor
                            chosenFormulaColors(k).id_car = chosenCar.id_car
                            chosenFormulaColors(k).id_color = multiCarFormulaColors(ind)(k).id_color
                            chosenFormulaColors(k).id_formula = multiCarFormulaColors(ind)(k).id_formula
                            chosenFormulaColors(k).id_formulaColor = multiCarFormulaColors(ind)(k).id_formulaColor
                            chosenFormulaColors(k).id_Unit = multiCarFormulaColors(ind)(k).id_Unit
                            chosenFormulaColors(k).quantite = multiCarFormulaColors(ind)(k).quantite
                        Next
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub reAssign()
        If Not multiCarFormulaColors Is Nothing Then
            'If MsgBox("Are you sure you want to assign the chosen colors to this car?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            'Exit Sub
            ' End If

            Dim carName As String = cmbChosenCars.Text
            Dim carsSelected() As Car = getCars(" WHERE carName ='" & carName & "'")
            If carsSelected Is Nothing Then
                'MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If carsSelected.Length = 0 Then
                'MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim chosenCar As Car = carsSelected(0)

            If Not chosenCar Is Nothing Then


                'get formulaColorTab of this car
                Dim ind As Integer = -1
                For i = 0 To multiCarFormulaColors.Length - 1
                    Dim formColTab() As FormulaColor
                    formColTab = multiCarFormulaColors(i)
                    Dim regetFromCmb As Boolean = True
                    If Not formColTab Is Nothing Then
                        If Not formColTab.Length = 0 Then
                            regetFromCmb = False
                        End If
                    End If
                    If Not regetFromCmb Then
                        Dim idCar As Integer = formColTab(0).id_car
                        If idCar = chosenCar.id_car Then
                            ind = i
                            Exit For
                        End If

                    Else 're get the id of this car depending of its name from the combobox

                        Dim carnameCmb As String = cmbChosenCars.GetItemText(cmbChosenCars.Items(i))
                        Dim carsSelectedcmb() As Car = getCars(" WHERE carName ='" & carnameCmb & "'")
                        If carsSelectedcmb Is Nothing Then
                            Exit Sub
                        End If
                        If carsSelectedcmb.Length = 0 Then
                            Exit Sub
                        End If

                        Dim idCar As Integer = carsSelectedcmb(0).id_car
                        If idCar = chosenCar.id_car Then
                            ind = i
                            Exit For
                        End If

                    End If
                Next
                If ind <> -1 Then
                    multiCarNameCode(ind).formulaCode = txtColorCode.Text
                    multiCarNameCode(ind).formulaName = txtFormulaName.Text
                    multiCarNameCode(ind).id_car = chosenCar.id_car
                    If Not chosenFormulaColors Is Nothing Then
                        If chosenFormulaColors.Length > 0 Then
                            ReDim multiCarFormulaColors(ind)(chosenFormulaColors.Length - 1)

                            For k = 0 To chosenFormulaColors.Length - 1
                                multiCarFormulaColors(ind)(k) = New FormulaColor
                                multiCarFormulaColors(ind)(k).id_car = chosenCar.id_car
                                multiCarFormulaColors(ind)(k).id_color = chosenFormulaColors(k).id_color
                                multiCarFormulaColors(ind)(k).id_formula = chosenFormulaColors(k).id_formula
                                multiCarFormulaColors(ind)(k).id_formulaColor = chosenFormulaColors(k).id_formulaColor
                                multiCarFormulaColors(ind)(k).id_Unit = chosenFormulaColors(k).id_Unit
                                multiCarFormulaColors(ind)(k).quantite = chosenFormulaColors(k).quantite
                            Next
                        End If
                    End If
                  
                End If
            End If
        End If
    End Sub

    Private Sub butAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAssign.Click
        If Not multiCarFormulaColors Is Nothing Then
            If multiCarFormulaColors.Length > 0 Then
                reAssign()
            End If
        End If

    End Sub

    Private Sub addFormula_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            fromMinimize = True
        Else
            fromMinimize = False
        End If
    End Sub
End Class

