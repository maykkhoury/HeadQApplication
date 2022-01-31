
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.AccessControl
Imports System.Net
Imports System.Text

Public Class HeadQHome
    Private id_formulaXSeleced As Integer = -1
    Private id_formulaXPSeleced As Integer = -1
    Private id_formulaX2PSeleced As Integer = -1

    Private id_formulaYSeleced As Integer = -1
    Private id_formulaYPSeleced As Integer = -1
    Private id_formulaY2PSeleced As Integer = -1

    Private id_formulaZSeleced As Integer = -1
    Private id_formulaZPSeleced As Integer = -1
    Private id_formulaZ2PSeleced As Integer = -1

    Private id_formulaXYZSeleced As Integer = -1

    Private tabXlstyleColor As Microsoft.Office.Interop.Excel.Style()
    'formula car
    Private Sub loadCars()
        Dim carsTab() As Car = getCars("")
        Dim lastChosenCar As Car = getLastChosenCar()

        Dim i As Integer
        cmbCarNameSearch.Items.Add("")
        For i = 0 To carsTab.Length - 1
            'edit.cmbCarNameModelEdit.Items.Add(carsTab(i).carName)
            cmbCarNameSearch.Items.Add(carsTab(i).carName)
        Next

    End Sub

    Private Sub loadCarsEditForm()
        Dim carsTab() As Car = getCars("")
        Dim lastChosenCar As Car = getLastChosenCar()
        Dim i As Integer
        edit.cmbCarNameModelEdit.Items.Add("")
        For i = 0 To carsTab.Length - 1
            edit.cmbCarNameModelEdit.Items.Add(carsTab(i).carName)

        Next
    End Sub

    Public Sub loadGarageHome()
        'lbUnitMesureValue.Text = chosenUnit.getUnitName(chosenLanguage.id_language)
        lbCurrencyDetailsValue.Text = chosenCurrency.code_currency

        'lbUnitMesureValue2.Text = chosenUnit.getUnitName(chosenLanguage.id_language)
        lbCurrencyDetailsValue2.Text = chosenCurrency.code_currency

        'fill garaget
        Dim GarageFiltered() As Garage = getGarages("")
        addResultsToListviewGarages(GarageFiltered)

        'fill b coloret
        Dim BColorFiltered() As Color = getColors("")
        addResultsToListviewBColors(BColorFiltered)
        'fill languaget

        Dim LanguageFiltered() As Language = getLanguages("")
        addResultsToListviewLanguages(LanguageFiltered)

        'fill cars

        Dim carFiltered() As Car = getCars("")
        addResultsToListviewCars(carFiltered)


    End Sub
    Private Sub garageHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        lbCountFormulas.Text = ""
        loadGarageHome()
        'setChkBackColor()
        loadCars()
        txtColorCode.Focus()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub butAddNewFormula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddNewFormula.Click
        addDuplicate = False
        Me.Visible = False
        addMoreCars.Dispose()
        addFormula.Dispose()
        addFormula.ShowDialog()
    End Sub
    Private Function getXlstyleColor(ByVal lvi As System.Windows.Forms.ListViewItem, ByVal i As Integer, ByVal ix As Integer, ByVal xlWorkBook As Microsoft.Office.Interop.Excel.Workbook, ByVal backColorX As Integer) As Microsoft.Office.Interop.Excel.Style
        Dim xlstyleColor As Microsoft.Office.Interop.Excel.Style
        Dim found As Boolean = False
        Dim MyArray As New ArrayList

        For Each ws As Microsoft.Office.Interop.Excel.Style In tabXlstyleColor
            'If ws.Name.StartsWith("StyleColor") And ws.Interior.Color = backColorX Then
            MyArray.Add(ws)
            If ws.Interior.Color = backColorX Then
                xlstyleColor = ws
                found = True
            End If
        Next
        If Not found Then
            xlstyleColor = xlWorkBook.Styles.Add("StyleColor" & i & ix)
            If ix > 7 And ix < lvi.SubItems.Count - 1 And Not lsvFamily.Items(i).SubItems(ix).BackColor = Drawing.Color.White Then
                xlstyleColor.Interior.Color = System.Drawing.ColorTranslator.ToOle(lsvFamily.Items(i).SubItems(ix).BackColor)
            End If
            xlstyleColor.NumberFormat = "@"
            MyArray.Add(xlstyleColor)
        End If
        tabXlstyleColor = DirectCast(MyArray.ToArray(GetType(Microsoft.Office.Interop.Excel.Style)), Microsoft.Office.Interop.Excel.Style())

        Return xlstyleColor

    End Function


    Public Function filterTabNameDistinct(ByVal formulaTab() As Formula) As Formula()
        If formulaTab Is Nothing Or formulaTab.Length = 0 Then
            Return formulaTab
        End If
        Dim MyArray As New ArrayList
        Dim i As Integer
        For i = 0 To formulaTab.Length - 1
            If MyArray.Count = 0 Then
                MyArray.Add(formulaTab(i))
            Else
                Dim formulaTempTab() As Formula
                formulaTempTab = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())

                Dim j As Integer
                Dim orredyExists As Boolean = False
                For j = 0 To formulaTempTab.Length - 1
                    If formulaTempTab(j).colorCode = formulaTab(i).colorCode Then
                        orredyExists = True
                        Exit For
                    End If
                Next

                If orredyExists = False Then
                    MyArray.Add(formulaTab(i))
                End If

            End If
        Next
        Return DirectCast(MyArray.ToArray(GetType(Formula)), Formula())

    End Function

    Private Function isCouche(ByVal fname As String) As Boolean
        isCouche = False
        If fname.ToLower.Contains("(couche)") Then
            isCouche = True
        End If
        If fname.ToLower.Contains("(couche 1)") Then
            isCouche = True
        End If
        If fname.ToLower.Contains("(couche 2)") Then
            isCouche = True
        End If
        If fname.ToLower.Contains("(sous-couche)") Then
            isCouche = True
        End If
    End Function

    Function getCoucheIndex(ByVal formulaTab() As Formula, ByVal fname As String, ByVal coucheSubstring As String) As Integer
        Dim lacquer As String = ""
        If fname.ToLower.EndsWith("(+ lacquer)") Then
            coucheSubstring = coucheSubstring & "(+ lacquer)"
        Else
            If fname.ToLower.EndsWith("(+lqr)") Then
                coucheSubstring = coucheSubstring & "(+lqr)"
            Else
                If fname.ToLower.EndsWith("(+lacquer)") Then
                    coucheSubstring = coucheSubstring & "(+lacquer)"
                Else
                    If fname.ToLower.EndsWith("(+ lqr)") Then
                        coucheSubstring = coucheSubstring & "(+ lqr)"
                    End If
                End If
            End If
        End If


        getCoucheIndex = -1
        fname = fname.ToLower
        If fname.Contains("(couche)") Then
            fname = fname.Substring(0, fname.IndexOf("(couche)"))
        End If
        If fname.Contains("(couche 1)") Then
            fname = fname.Substring(0, fname.IndexOf("(couche 1)"))
        End If
        If fname.Contains("(couche 2)") Then
            fname = fname.Substring(0, fname.IndexOf("(couche 2)"))
        End If
        If fname.Contains("(sous-couche)") Then
            fname = fname.Substring(0, fname.IndexOf("(sous-couche)"))
        End If
        For k = 0 To formulaTab.Length - 1
            If Not formulaTab(k).isMoved Then
                If formulaTab(k).name_formula.ToLower.Trim.StartsWith(fname & coucheSubstring) Then
                    getCoucheIndex = k
                    Exit For
                Else
                    If formulaTab(k).name_formula.ToLower.Trim.StartsWith(fname & " " & coucheSubstring) Then
                        getCoucheIndex = k
                        Exit For
                    End If
                End If
            End If
        Next
    End Function
    Public Sub addResultsToListviewFamily(ByVal formulaTab() As Formula, ByVal resetCurFamily As Boolean, Optional ByVal typeFilter As String = "")
        Try
            Dim i As Integer = 0
            '------------------------
            If resetCurFamily Then
                curFamily = formulaTab
                'curSubFamily = formulaTab
            End If
            If typeFilter.Trim <> "" Then
                Dim MyArray As New ArrayList
                For i = 0 To formulaTab.Length - 1
                    If formulaTab(i).type.ToLower.Trim = typeFilter.ToLower.Trim Then
                        MyArray.Add(formulaTab(i))
                    End If
                Next
                formulaTab = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())
            End If

            lsvFamily.Items.Clear()
            lsvFamily.BeginUpdate()
            lsvFamily.Sorting = SortOrder.None
            lsvFamily.ListViewItemSorter = Nothing
            For Each column As ColumnHeader In lsvFamily.Columns
                column.Text = column.Text.Replace("< ", "")
                column.Text = column.Text.Replace("> ", "")
            Next
            'prgabr
            prgBar.Visible = True
            prgBar.Step = 1
            prgBar.Maximum = 1
            If Not formulaTab Is Nothing Then
                If formulaTab.Length > 0 Then
                    prgBar.Maximum = formulaTab.Length - 1
                End If
            End If

            prgBar.Value = 0
            '''''''''''''''
            lbCountFormulas.Text = formulaTab.Length & " Color"


            Dim MyArrayCouche As New ArrayList

            For i = 0 To formulaTab.Length - 1
                If isCouche(formulaTab(i).name_formula) And Not formulaTab(i).isMoved Then
                    Dim coucheIndex As Integer = getCoucheIndex(formulaTab, formulaTab(i).name_formula, "(couche)")
                    Dim couche1Index As Integer = getCoucheIndex(formulaTab, formulaTab(i).name_formula, "(couche 1)")
                    Dim couche2Index As Integer = getCoucheIndex(formulaTab, formulaTab(i).name_formula, "(couche 2)")
                    Dim sousCoucheIndex As Integer = getCoucheIndex(formulaTab, formulaTab(i).name_formula, "(sous-couche)")

                    If sousCoucheIndex <> -1 Then
                        formulaTab(sousCoucheIndex).isMoved = True
                        MyArrayCouche.Add(formulaTab(sousCoucheIndex))
                    End If
                    If coucheIndex <> -1 Then
                        formulaTab(coucheIndex).isMoved = True
                        MyArrayCouche.Add(formulaTab(coucheIndex))
                    End If
                    If couche1Index <> -1 Then
                        formulaTab(couche1Index).isMoved = True
                        MyArrayCouche.Add(formulaTab(couche1Index))
                    End If
                    If couche2Index <> -1 Then
                        formulaTab(couche2Index).isMoved = True
                        MyArrayCouche.Add(formulaTab(couche2Index))
                    End If

                Else
                    If Not formulaTab(i).isMoved Then
                        MyArrayCouche.Add(formulaTab(i))
                    End If
                End If
            Next
            formulaTab = DirectCast(MyArrayCouche.ToArray(GetType(Formula)), Formula())

            Dim searchByColorCode As Boolean = False
            Dim colorCodeSearched As String = txtColorCode.Text.Trim
            If Not colorCodeSearched = "" Then
                searchByColorCode = True
            End If
            If searchByColorCode Then
                'start with the color searched, then the others
                'move [color searched] to first

                Dim MyArrayColorSearched As New ArrayList
                For i = 0 To formulaTab.Length - 1
                    If formulaTab(i).colorCode.ToLower = colorCodeSearched.ToLower Then
                        If Not MyArrayColorSearched.Contains(formulaTab(i)) Then
                            MyArrayColorSearched.Add(formulaTab(i))
                        End If
                    End If
                Next

                'move [color searched][space][kharadjej] to second
                For i = 0 To formulaTab.Length - 1
                    If formulaTab(i).colorCode.ToLower.StartsWith(colorCodeSearched.ToLower & " ") Then
                        If Not MyArrayColorSearched.Contains(formulaTab(i)) Then
                            MyArrayColorSearched.Add(formulaTab(i))
                        End If
                    End If
                Next

                'move [color searched][kharadjej] to third
                For i = 0 To formulaTab.Length - 1
                    If formulaTab(i).colorCode.ToLower.StartsWith(colorCodeSearched.ToLower) And Not formulaTab(i).colorCode.ToLower.StartsWith(colorCodeSearched.ToLower & " ") And Not formulaTab(i).colorCode.ToLower = colorCodeSearched.ToLower Then
                        If Not MyArrayColorSearched.Contains(formulaTab(i)) Then
                            MyArrayColorSearched.Add(formulaTab(i))
                        End If
                    End If
                Next

                'move [...][color searched][...] to fourth
                For i = 0 To formulaTab.Length - 1
                    If formulaTab(i).colorCode.ToLower.Contains(colorCodeSearched.ToLower) And Not formulaTab(i).colorCode.StartsWith(colorCodeSearched.ToLower) And Not formulaTab(i).colorCode.ToLower = colorCodeSearched.ToLower Then
                        If Not MyArrayColorSearched.Contains(formulaTab(i)) Then
                            MyArrayColorSearched.Add(formulaTab(i))
                        End If
                    End If
                Next

                formulaTab = DirectCast(MyArrayColorSearched.ToArray(GetType(Formula)), Formula())
            End If


            For i = 0 To formulaTab.Length - 1

                prgBar.PerformStep()
                lsvFamily.Items.Add(formulaTab(i).id_formula)
                lsvFamily.Items(i).SubItems.Add(formulaTab(i).type)
                lsvFamily.Items(i).SubItems.Add(formulaTab(i).name_car)
                lsvFamily.Items(i).SubItems.Add(formulaTab(i).colorCode)
                lsvFamily.Items(i).SubItems.Add(formulaTab(i).name_formula)
                If formulaTab(i).Date_cre_mod.Trim = "" Or formulaTab(i).Date_cre_mod.Trim = "1:1:1:0:0:0" Then
                    lsvFamily.Items(i).SubItems.Add("")
                Else
                    lsvFamily.Items(i).SubItems.Add(formulaTab(i).dateCreMod)
                End If

                lsvFamily.Items(i).SubItems.Add(formulaTab(i).c_year)
                lsvFamily.Items(i).SubItems.Add(formulaTab(i).version)
                lsvFamily.Items(i).SubItems.Add(formulaTab(i).cardNumber)
                lsvFamily.Items(i).UseItemStyleForSubItems = False
                Dim formulaVariant As String = formulaTab(i).variant

                If Not formulaVariant Is Nothing Then
                    If formulaVariant.Trim <> "" Then
                        'lsvFamily.Items(i).SubItems.Add(formulaVariant)
                        Dim formulaVariants() As String = formulaVariant.Split("+")
                        Dim j As Integer

                        For j = 0 To formulaVariants.Length - 1
                            If 9 + j > lsvFamily.Columns.Count Then
                                lsvFamily.Columns.Add("", 25, Windows.Forms.HorizontalAlignment.Left)

                            End If

                            lsvFamily.Items(i).SubItems.Add("")
                            Dim varianttemp As FormulaVariants = getVariant(formulaVariants(j))
                            If Not varianttemp Is Nothing Then
                                lsvFamily.Items(i).SubItems(8 + j).BackColor = varianttemp.variantColor
                            End If
                        Next
                        If 9 + j > lsvFamily.Columns.Count Then
                            lsvFamily.Columns.Add("", 25, Windows.Forms.HorizontalAlignment.Left)
                        End If

                    End If
                End If
            Next
            'set the variant
            Dim lastColumnIndex = 0
            For Each column As ColumnHeader In lsvFamily.Columns
                lastColumnIndex += 1
            Next
            lsvFamily.Columns(lastColumnIndex - 1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)

            For i = 0 To formulaTab.Length - 1
                Dim formulaVariant As String = formulaTab(i).variant
                If Not formulaVariant Is Nothing Then
                    If formulaVariant.Trim <> "" Then
                        Dim formulaVariants() As String = formulaVariant.Split("+")
                        Dim j As Integer
                        Dim str As String = ""
                        For j = 0 To formulaVariants.Length - 1
                            Dim variantTmp As FormulaVariants = getVariant(formulaVariants(j))
                            If variantTmp Is Nothing Then
                                str = str & formulaVariants(j) & " "
                            Else
                                str = str & variantTmp.variantDescription & " "
                            End If

                        Next

                        Dim success As Boolean = False
                        While Not success
                            Try
                                lsvFamily.Items(i).SubItems(lastColumnIndex - 1).Text = str
                                success = True
                            Catch ex As Exception
                                lsvFamily.Items(i).SubItems.Add("")
                                success = False
                            End Try
                        End While
                    End If
                End If

            Next
            lastColumnIndex = 0
            For Each column As ColumnHeader In lsvFamily.Columns
                lastColumnIndex += 1
            Next
            lsvFamily.Columns(lastColumnIndex - 1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)


            'autoresize listview
            'lsvFamily.Columns.Add("")
            For Each column As ColumnHeader In lsvFamily.Columns
                If column.Tag = "cctype" Or column.Tag = "ccarname" Or column.Tag = "ccode" Or column.Tag = "ccname" Or column.Tag = "cyear" Or column.Tag = "cversion" Or column.Tag = "ccardNbr" Then
                    column.Width = -2
                End If
            Next
            '------------------
            lsvFamily.EndUpdate()

            prgBar.Value = prgBar.Maximum
            prgBar.Visible = False
        Catch ex As Exception
            prgBar.Visible = False
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        Me.Close()

    End Sub
    Private Sub getNegativeQtys()
        Dim formulasFiltered() As Formula = getNegativeQtyFormulas()
      
        'formulasFiltered = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())
        Dim filter As String = ""
        If rdBC.Checked Then
            filter = "BC"
        ElseIf rd2k.Checked Then
            filter = "2K"
        ElseIf rdLS.Checked Then
            filter = "LS"
        End If


        addResultsToListviewFamily(formulasFiltered, True, filter)


        'lsvFamily.Items.Clear()
        'curFamily = Nothing
        'rdBC.Select()
        'filterFamilyByType("BC")
        edit.disposeHiddenTextBoxes()
    End Sub

    Private Sub go()
        If (txtYearMax.Text <> "" And Not IsNumeric(txtYearMax.Text)) Or (txtYearMin.Text <> "" And Not IsNumeric(txtYearMin.Text)) Or (txtYearSpec.Text <> "" And Not IsNumeric(txtYearSpec.Text)) Then
            MsgBox("Year must be numeric")
            Exit Sub
        End If

        Dim formulaNameChk As Boolean = chkFormulaName.Checked
        Dim formulaName As String = txtFormulaName.Text

        Dim carName As String = getCarById(lbCarIdSearch.Text).carName
        If carName Is Nothing Then
            carName = ""
        End If
        Dim colorCodeChk As Boolean = chkColorCode.Checked
        Dim colorCode As String = txtColorCode.Text

        Dim cardNumberChk As Boolean = chkCardNumber.Checked
        Dim cardNumber As String = txtCardNumber.Text

        Dim yearMin As String = "" 'txtYearMin.Text
        Dim yearMax As String = "" 'txtYearMax.Text

        Dim basicColor As String = txtBasicColor.Text

        Dim yearspec As String = txtYearSpec.Text
        If Not IsNumeric(yearspec) And yearspec.Trim <> "" Then
            MsgBox("Year must be numeric in the search mode", MsgBoxStyle.Exclamation)
            Exit Sub

        End If
        If (colorCode = "" Or colorCodeChk) And carName = "" And basicColor.Trim = "" Then
            MsgBox("For a better performance, the search must be at least filtered by car ,color code or basic color, and if the filter is the color code, 'Contains' must be unchecked.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim str1 As String = ""
        If formulaName.Trim <> "" Then
            If formulaNameChk Then
                str1 = str1 & " name_formula like '%" & formulaName & "%'"
            Else
                str1 = str1 & " name_formula = '" & formulaName & "'"
            End If
        End If

        Dim str2 As String = ""
        If carName.Trim <> "" Then
            str2 = str2 & " carName = '" & carName & "'"
        End If

        Dim str3 As String = ""
        If colorCode.Trim <> "" Then
            If colorCodeChk Then
                str3 = str3 & " LCASE(colorCode) like '%" & colorCode.ToLower & "%'"
            Else
                str3 = str3 & " LCASE(colorCode) like '" & colorCode.ToLower & "%'"
            End If
        End If

        Dim str4 As String = ""
        If cardNumber.Trim <> "" Then
            If cardNumberChk Then
                str4 = str4 & " cardNumber like '%" & cardNumber & "%'"
            Else
                str4 = str4 & " cardNumber = '" & cardNumber & "'"
            End If
        End If

        Dim str5 As String = ""
        If basicColor.Trim <> "" Then
            str5 = str5 & " id_formula in (select id_formula from formulaColor fc, color c where "
            str5 = str5 & " fc.id_color=c.id_color and colorCode='" & basicColor.Trim & "')"
        End If

        Dim whereStr As String = ""
        If str1 <> "" Then
            whereStr = str1
        End If
        If str2 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str2
            Else
                whereStr = str2
            End If
        End If

        If str3 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str3
            Else
                whereStr = str3
            End If
        End If

        If str4 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str4
            Else
                whereStr = str4
            End If
        End If

        If str5 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str5
            Else
                whereStr = str5
            End If
        End If

        If whereStr <> "" Then
            whereStr = " AND " & whereStr
        End If

        Dim formulasFiltered() As Formula = getFormulas(whereStr)
        'filterByYear
        If yearspec <> "" Then
            Dim MyArray As New ArrayList

            For i = 0 To formulasFiltered.Length - 1
                Dim yearStr As String = formulasFiltered(i).c_year
                If yearStr Is Nothing Then
                    Continue For
                End If
                If yearStr.IndexOf("-") > -1 And yearStr.Trim <> "-" Then
                    Dim iYearMin As Long = yearStr.Substring(0, yearStr.IndexOf("-")).Trim
                    Dim iYearMax As Long = 0
                    If yearStr.Substring(yearStr.IndexOf("-") + 1).Trim() <> "" Then
                        iYearMax = yearStr.Substring(yearStr.IndexOf("-") + 1).Trim()
                    End If
                    If yearspec >= iYearMin And yearspec <= iYearMax Then
                        MyArray.Add(formulasFiltered(i))
                    End If
                End If

            Next
            formulasFiltered = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())

        Else

            If yearMax.Trim <> "" Or yearMin.Trim <> "" Then
                If yearMax.Trim = "" Then
                    yearMax = "9999999999"
                End If
                If yearMin.Trim = "" Then
                    yearMin = "0"
                End If

                Dim MyArray As New ArrayList

                For i = 0 To formulasFiltered.Length - 1
                    Dim yearStr As String = formulasFiltered(i).c_year
                    If yearStr Is Nothing Then
                        Continue For
                    End If
                    If yearStr.IndexOf("-") > -1 And yearStr.Trim <> "-" Then
                        Dim iYearMin As Long = yearStr.Substring(0, yearStr.IndexOf("-")).Trim
                        Dim iYearMax As Long = yearStr.Substring(yearStr.IndexOf("-") + 2).Trim
                        If iYearMin >= CType(yearMin.Trim, Long) And iYearMax <= CType(yearMax.Trim, Long) Then
                            MyArray.Add(formulasFiltered(i))
                        End If
                    End If

                Next
                formulasFiltered = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())
            End If
        End If
        'formulasFiltered = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())
        Dim filter As String = ""
        If rdBC.Checked Then
            filter = "BC"
        ElseIf rd2k.Checked Then
            filter = "2K"
        ElseIf rdLS.Checked Then
            filter = "LS"
        End If

        If Not colorCode Is Nothing And Not "" = colorCode Then
            'Sort by year
            formulasFiltered = sortByYear(formulasFiltered)
            'order by MET and MAT
            formulasFiltered = placeMetAndMat(formulasFiltered)
        End If

        addResultsToListviewFamily(formulasFiltered, True, filter)


        'lsvFamily.Items.Clear()
        'curFamily = Nothing
        'rdBC.Select()
        'filterFamilyByType("BC")
        edit.disposeHiddenTextBoxes()
    End Sub


    Private Sub butGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butGo.Click
        go()
    End Sub

    Private Sub cmbCarNameSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCarNameSearch.SelectedIndexChanged
        If cmbCarNameSearch.Text = "" Then
            lbCarIdSearch.Text = "-1"
            Exit Sub
        End If
        Dim chosenCar As Car
        chosenCar = getCars("")(cmbCarNameSearch.SelectedIndex - 1)

        If Not chosenCar Is Nothing Then
            lbCarIdSearch.Text = chosenCar.id_car
            cmbCarNameSearch.Text = chosenCar.carName
            'Try
            'Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & chosenCar.carImgPath
            'imageToPreview = Image.FromFile(imgPath)
            'pctCarImgDetails.Image = imageToPreview
            ''pctCarImg.ImageLocation = imgPath
            'Catch ex As IOException
            'imageToPreview = Nothing
            'pctCarImgDetails.Image = Nothing
            ''MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
            'End Try
        End If
        setLastChosenCar(chosenCar)
    End Sub

    ' Private Sub lsvFormula_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvFormula.MouseClick, lsvFormula.KeyDown, lsvFormula.KeyUp
    '     disposeHiddenTextBoxes()
    '     curFamily = Nothing
    '     curSubFamily = Nothing
    '     Dim formulaCodeChosen As String = lsvFormula.SelectedItems(0).SubItems(0).Text
    '
    '    lbSelectedFormulavalue.Text = formulaCodeChosen
    '
    '    Dim whereStr As String = " AND colorCode='" & formulaCodeChosen.Trim & "'"
    '
    '    Dim formulasFiltered() As Formula = getFormulas(whereStr)
    '    'formulasFiltered = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())

    '   addResultsToListviewFamily(formulasFiltered, True)
    '   rdBC.Select()
    '   filterFamilyByType("BC")

    'End Sub

    Private Sub filterFamilyByType(ByVal type)
        If Not curFamily Is Nothing Then
            If curFamily.Length > 0 Then
                Dim MyArray As New ArrayList
                Dim i As Integer
                For i = 0 To curFamily.Length - 1
                    If curFamily(i).type.ToLower.Trim = type.ToLower.Trim Or type.Trim = "" Then
                        curFamily(i).isMoved = False
                        MyArray.Add(curFamily(i))
                    End If
                Next

                Dim formulasFiltered() As Formula
                formulasFiltered = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())
                'curSubFamily = formulasFiltered
                addResultsToListviewFamily(formulasFiltered, False)
            End If
        End If
    End Sub

    Private Sub radioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd2k.CheckedChanged, rdBC.CheckedChanged, rdAny.CheckedChanged, rdLS.CheckedChanged
        Dim type As String = ""
        If rd2k.Checked Then
            type = "2K"
        ElseIf rdBC.Checked Then
            type = "BC"
        ElseIf rdLS.Checked Then
            type = "LS"
        End If
        filterFamilyByType(type)

    End Sub


    Public Shared Function IsNumeric(ByVal str As String)
        Return Microsoft.VisualBasic.IsNumeric(str)
        'Return New Regex("\b\d+(\.\d+)?\b").Match(str).Success
    End Function


    Private Sub lsvFamily_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsvFamily.MouseDoubleClick
        'test if formula is composed
        Dim idFormula = lsvFamily.SelectedItems(0).SubItems(0).Text
        Dim selectedFormula As Formula
        selectedFormula = getFormulaById(idFormula)
        Dim fname As String = selectedFormula.name_formula
        Dim fcode As String = selectedFormula.colorCode
        Dim isComposed As Boolean = False
        Dim isBumper As Boolean = False
        'Dim codeF1 As String = ""
        'Dim codeF2 As String = ""
        'Dim codeF3 As String = ""
        'Dim allowZ As Boolean = False
        If fname.IndexOf(" + ") > 0 Or fcode.ToLower.EndsWith("bumper") Then
            'codeF1 = fname.Substring(0, fname.IndexOf("+")).Trim
            'codeF2 = fname.Substring(fname.IndexOf("+") + 1).Trim
            'If IsNumeric(codeF1) And IsNumeric(codeF2) Then
            isComposed = True
            If fcode.ToLower.EndsWith("bumper") Then
                isBumper = True
            End If
            'End If
            'If codeF2.IndexOf(" + ") > 0 Then
            'codeF3 = codeF2.Substring(codeF2.IndexOf("+") + 1).Trim
            'allowZ = True
            'End If
        End If
        If isComposed Then
            'getting formula X ,Y and Z

            Dim idX As Integer = selectedFormula.id_formulaX
            Dim idXp As Integer = selectedFormula.id_formulaXp
            Dim idX2p As Integer = selectedFormula.id_formulaX2p

            Dim idY As Integer = selectedFormula.id_formulaY
            Dim idYp As Integer = selectedFormula.id_formulaYp
            Dim idY2p As Integer = selectedFormula.id_formulaY2p

            Dim idZ As Integer = selectedFormula.id_formulaZ
            Dim idZp As Integer = selectedFormula.id_formulaZp
            Dim idZ2p As Integer = selectedFormula.id_formulaZ2p


            Dim xAssigned As Boolean = False
            Dim yAssigned As Boolean = False
            Dim zAssigned As Boolean = False

            If idX <> -1 And idX <> 0 Then
                xAssigned = True
            Else
                If idXp <> -1 And idXp <> 0 And idX2p <> -1 And idX2p <> 0 Then
                    xAssigned = True
                End If
            End If

            If idY <> -1 And idY <> 0 Then
                yAssigned = True
            Else
                If idYp <> -1 And idYp <> 0 And idY2p <> -1 And idY2p <> 0 Then
                    yAssigned = True
                End If
            End If

            If idZ <> -1 And idZ <> 0 Then
                zAssigned = True
            Else
                If idZp <> -1 And idZp <> 0 And idZ2p <> -1 And idZ2p <> 0 Then
                    zAssigned = True
                End If
            End If
            Dim assignCondition As Boolean = False
            If isBumper Then
                assignCondition = Not xAssigned
            Else
                assignCondition = Not xAssigned Or Not yAssigned Or Not zAssigned
            End If
            If assignCondition Then
                id_formulaXSeleced = idX
                If idX <> 0 And idX <> -1 Then
                    Dim formula As Formula = getFormulaById(idX)
                    Dim clrName As String = formula.colorCode & " - " & formula.version
                    Me.ToolTipVariant.SetToolTip(butAssignX, clrName)
                    butAssignX.Text = clrName
                End If

                id_formulaXPSeleced = idXp
                If idXp <> 0 And idXp <> -1 Then
                    Dim formula As Formula = getFormulaById(idXp)
                    Dim clrName As String = formula.colorCode & " - " & formula.version
                    Me.ToolTipVariant.SetToolTip(butAssignXp, clrName)
                    butAssignXp.Text = clrName
                End If

                id_formulaX2PSeleced = idX2p
                If idX2p <> 0 And idX2p <> -1 Then
                    Dim formula As Formula = getFormulaById(idX2p)
                    Dim clrName As String = formula.colorCode & " - " & formula.version
                    Me.ToolTipVariant.SetToolTip(butAssignX2p, clrName)
                    butAssignX2p.Text = clrName
                End If

                id_formulaYSeleced = idY
                If idY <> 0 And idY <> -1 Then
                    Dim formula As Formula = getFormulaById(idY)
                    Dim clrName As String = formula.colorCode & " - " & formula.version
                    Me.ToolTipVariant.SetToolTip(butAssignY, clrName)
                    butAssignY.Text = clrName
                End If

                id_formulaYPSeleced = idYp
                If idYp <> 0 And idYp <> -1 Then
                    Dim formula As Formula = getFormulaById(idYp)
                    Dim clrName As String = formula.colorCode & " - " & formula.version
                    Me.ToolTipVariant.SetToolTip(butAssignYp, clrName)
                    butAssignYp.Text = clrName
                End If

                id_formulaY2PSeleced = idY2p
                If idY2p <> 0 And idY2p <> -1 Then
                    Dim formula As Formula = getFormulaById(idY2p)
                    Dim clrName As String = formula.colorCode & " - " & formula.version
                    Me.ToolTipVariant.SetToolTip(butAssignY2p, clrName)
                    butAssignY2p.Text = clrName
                End If

                id_formulaZSeleced = idZ
                If idZ <> 0 And idZ <> -1 And idZ <> -2 Then
                    Dim formula As Formula = getFormulaById(idZ)
                    Dim clrName As String = formula.colorCode & " - " & formula.version
                    Me.ToolTipVariant.SetToolTip(butAssignZ, clrName)
                    butAssignZ.Text = clrName
                End If

                id_formulaZPSeleced = idZp
                If idZp <> 0 And idZp <> -1 And idZp <> -2 Then
                    Dim formula As Formula = getFormulaById(idZp)
                    Dim clrName As String = formula.colorCode & " - " & formula.version
                    Me.ToolTipVariant.SetToolTip(butAssignZp, clrName)
                    butAssignZp.Text = clrName
                End If

                id_formulaZ2PSeleced = idZ2p
                If idZ2p <> 0 And idZ2p <> -1 And idZ2p <> -2 Then
                    Dim formula As Formula = getFormulaById(idZ2p)
                    Dim clrName As String = formula.colorCode & " - " & formula.version
                    Me.ToolTipVariant.SetToolTip(butAssignZ2p, clrName)
                    butAssignZ2p.Text = clrName
                End If

                id_formulaXYZSeleced = idFormula

                If (idX = -1 Or idX = 0) And (idXp = -1 Or idXp = 0) And (idX2p = -1 Or idX2p = 0) Then
                    butCancelX.Enabled = False

                    If (idX = -1 Or idX = 0) Then
                        butAssignX.Enabled = True
                    End If
                    If (idXp = -1 Or idXp = 0) Then
                        butAssignXp.Enabled = True
                    End If
                    If (idX2p = -1 Or idX2p = 0) Then
                        butAssignX2p.Enabled = True
                    End If

                Else
                    butCancelX.Enabled = True
                    butAssignX.Enabled = False
                    butAssignXp.Enabled = False
                    butAssignX2p.Enabled = False
                End If

                If (idY = -1 Or idY = 0) And (idYp = -1 Or idYp = 0) And (idY2p = -1 Or idY2p = 0) Then
                    butCancelY.Enabled = False

                    If (idY = -1 Or idY = 0) Then
                        butAssignY.Enabled = True
                    End If
                    If (idYp = -1 Or idYp = 0) Then
                        butAssignYp.Enabled = True
                    End If
                    If (idY2p = -1 Or idY2p = 0) Then
                        butAssignY2p.Enabled = True
                    End If
                Else
                    butCancelY.Enabled = True
                    butAssignY.Enabled = False
                    butAssignYp.Enabled = False
                    butAssignY2p.Enabled = False
                End If

                If (idZ = -1 Or idZ = 0 Or idZ = -2) And (idZp = -1 Or idZp = 0 Or idZp = -2) And (idZ2p = -1 Or idZ2p = 0 Or idZ2p = -2) Then
                    butCancelZ.Enabled = False

                    If (idZ = -1 Or idZ = 0 Or idZ = -2) Then
                        butAssignZ.Enabled = True
                    End If
                    If (idZp = -1 Or idZp = 0 Or idZp = -2) Then
                        butAssignZp.Enabled = True
                    End If
                    If (idZ2p = -1 Or idZ2p = 0 Or idZ2p = -2) Then
                        butAssignZ2p.Enabled = True
                    End If
                Else
                    butCancelZ.Enabled = True
                    butAssignZ.Enabled = False
                    butAssignZp.Enabled = False
                    butAssignZ2p.Enabled = False
                End If

                lbSelectedXYZ.Text = fname
                grpXY.Visible = True

                If isBumper Then 'just allow assign X
                    butCancelX.AccessibleDescription = "bumper"
                    butSaveAssign.AccessibleDescription = "bumper"
                    butAssignXp.Enabled = False
                    butAssignX2p.Enabled = False
                    butAssignY.Enabled = False
                    butAssignYp.Enabled = False
                    butAssignY2p.Enabled = False
                    butAssignZ.Enabled = False
                    butAssignZp.Enabled = False
                    butAssignZ2p.Enabled = False
                Else
                    butCancelX.AccessibleDescription = ""
                    butSaveAssign.AccessibleDescription = ""
                End If


                Exit Sub
            End If

            If Not isBumper Then 'else continue to open the assigned formula


                If idX <> -1 And idX <> 0 Then
                    formComposed.Button1B.Visible = False
                    formComposed.Button1A.Visible = True

                    formComposed.Button1A.AccessibleDescription = idX
                    Dim formula As Formula = getFormulaById(idX)
                    Dim clrNameX As String = formula.colorCode & " - " & formula.version
                    formComposed.Button1A.Text = clrNameX
                Else
                    formComposed.Button1B.Visible = True
                    formComposed.Button1A.Visible = True

                    formComposed.Button1A.AccessibleDescription = idXp
                    Dim formulap As Formula = getFormulaById(idXp)
                    Dim clrNameXp As String = formulap.colorCode & " - " & formulap.version
                    formComposed.Button1A.Text = clrNameXp

                    formComposed.Button1B.AccessibleDescription = idX2p
                    Dim formula2p As Formula = getFormulaById(idX2p)
                    Dim clrNameX2p As String = formula2p.colorCode & " - " & formula2p.version
                    formComposed.Button1B.Text = clrNameX2p

                End If


                If idY <> -1 And idY <> 0 Then
                    formComposed.Button2B.Visible = False
                    formComposed.Button2A.Visible = True

                    formComposed.Button2A.AccessibleDescription = idY
                    Dim formula As Formula = getFormulaById(idY)
                    Dim clrNameY As String = formula.colorCode & " - " & formula.version
                    formComposed.Button2A.Text = clrNameY
                Else
                    formComposed.Button2B.Visible = True
                    formComposed.Button2A.Visible = True

                    formComposed.Button2A.AccessibleDescription = idYp
                    Dim formulap As Formula = getFormulaById(idYp)
                    Dim clrNameYp As String = formulap.colorCode & " - " & formulap.version
                    formComposed.Button2A.Text = clrNameYp

                    formComposed.Button2B.AccessibleDescription = idY2p
                    Dim formula2p As Formula = getFormulaById(idY2p)
                    Dim clrNameY2p As String = formula2p.colorCode & " - " & formula2p.version
                    formComposed.Button2B.Text = clrNameY2p

                End If

                If idZ = -2 And idZp = -2 And idZ2p = -2 Then
                    formComposed.Button3A.Visible = False
                    formComposed.Button3B.Visible = False
                    formComposed.grp3.Visible = False
                Else
                    formComposed.grp3.Visible = True
                    If idZ <> -1 And idZ <> 0 And idZ <> -2 Then
                        formComposed.Button3B.Visible = False
                        formComposed.Button3A.Visible = True

                        formComposed.Button3A.AccessibleDescription = idZ
                        Dim formula As Formula = getFormulaById(idZ)
                        Dim clrNameZ As String = formula.colorCode & " - " & formula.version
                        formComposed.Button3A.Text = clrNameZ
                    Else
                        formComposed.Button3B.Visible = True
                        formComposed.Button3A.Visible = True
                        formComposed.Button3A.AccessibleDescription = idZp
                        Dim formulap As Formula = getFormulaById(idZp)
                        Dim clrNameZp As String = formulap.colorCode & " - " & formulap.version
                        formComposed.Button3A.Text = clrNameZp

                        formComposed.Button3B.AccessibleDescription = idZ2p
                        Dim formulap2p As Formula = getFormulaById(idZ2p)
                        Dim clrNameZ2p As String = formulap2p.colorCode & " - " & formulap2p.version
                        formComposed.Button3B.Text = clrNameZ2p

                    End If
                End If

                formComposed.ShowDialog()
                Exit Sub
            End If
        End If
        selectedFormulaColors = Nothing
        ratio = 1

        Dim carsTab() As Car = getCars("")

        Dim i As Integer
        edit.cmbCarNameModelEdit.Items.Add("")
        For i = 0 To carsTab.Length - 1
            edit.cmbCarNameModelEdit.Items.Add(carsTab(i).carName)
        Next

        'clear composed info since we are sure this is not a composed case
        edit.id_formulaComposedGlobal = -1
        '--------------------------

        If isBumper Then
            edit.generatesDetails(Nothing, selectedFormula.id_formulaX, True)
        Else
            edit.generatesDetails(Nothing)
        End If


        If edit.formulaCorrupted = True Then
            edit.Dispose()
            Exit Sub
        End If

        Me.Visible = False
        edit.grpEdit.Visible = True
        edit.formulaDup = Nothing
        edit.ShowDialog()

    End Sub

    Private Sub lsvFamily_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvFamily.MouseClick, lsvFamily.KeyDown, lsvFamily.KeyUp
        If lsvFamily.SelectedItems.Count > 0 Then
            Console.WriteLine("before getting chosen formula:" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss fff"))
            Dim chosenFormula As Formula = getFormulaById(lsvFamily.SelectedItems(0).SubItems(0).Text)
            Console.WriteLine("after getting chosen formula:" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss fff"))

            lbCarIdSearch.Text = chosenFormula.id_car

            Console.WriteLine("before getting chosen car:" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss fff"))
            Dim car As Car = getCarById(chosenFormula.id_car)
            Console.WriteLine("after getting chosen car:" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss fff"))

            cmbCarNameSearch.Text = car.carName
            txtColorCode.Text = chosenFormula.colorCode
            txtFormulaName.Text = chosenFormula.name_formula
            txtCardNumber.Text = chosenFormula.cardNumber

            Dim yearStr As String = chosenFormula.c_year
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

            ''''check if linked to composed formula
            Console.WriteLine("before checking if linked:" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss fff"))
            Dim linkedMultiC As String() = getLinkedMulticolor(chosenFormula.id_formula)
            Console.WriteLine("after checking if linked:" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss fff"))


            Dim visibleLb As Boolean = False
            If Not linkedMultiC Is Nothing Then
                If linkedMultiC.Length > 0 Then
                    visibleLb = True
                End If
            End If
            lbAttention.Visible = visibleLb

        End If
    End Sub
    Private Sub butEditColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEditColor.Click
        If lsvFamily.SelectedItems.Count > 0 Then
            Dim newColorCode As String = txtColorCode.Text
            Dim newFormulaName As String = txtFormulaName.Text
            Dim c_year As String = txtYearMin.Text & " - " & txtYearMax.Text
            If Not txtYearSpec.Text.Trim = "" Then
                c_year = txtYearSpec.Text.Trim
                Dim errorYear As Boolean = False
                If Not c_year.Length = 11 Then
                    errorYear = True
                ElseIf Not IsNumeric(c_year.Substring(0, 4)) Then
                    errorYear = True
                ElseIf Not IsNumeric(c_year.Substring(7, 4)) Then
                    errorYear = True
                ElseIf Not c_year.Substring(4, 3) = " - " Then
                    errorYear = True
                End If

                If errorYear Then
                    MsgBox("Year must be in the format of #### - ####", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If

            Dim carId As String = lbCarIdSearch.Text
            Dim cardNumber As String = txtCardNumber.Text
            For s = 0 To lsvFamily.SelectedItems.Count - 1
                Dim idFormula As Long = lsvFamily.SelectedItems(s).SubItems(0).Text
                If s = 0 Then 'only modify everythinh for the first selected, for the rest just modify the year
                    If editFormula(idFormula, newColorCode, newFormulaName, c_year, carId, cardNumber, False) Then
                        lsvFamily.SelectedItems(s).SubItems(3).Text = newColorCode
                        lsvFamily.SelectedItems(s).SubItems(4).Text = newFormulaName
                        lsvFamily.SelectedItems(s).SubItems(5).Text = c_year
                        lsvFamily.SelectedItems(s).SubItems(2).Text = getCarById(carId).carName
                        'update curFamily
                        Dim i As Integer
                        For i = 0 To curFamily.Length - 1
                            If curFamily(i).id_formula = idFormula Then
                                curFamily(i).colorCode = newColorCode
                                curFamily(i).name_formula = newFormulaName
                                curFamily(i).c_year = c_year
                                curFamily(i).id_car = carId
                            End If
                        Next
                    End If
                Else
                    If editFormulaYear(idFormula, c_year) Then
                        lsvFamily.SelectedItems(s).SubItems(5).Text = c_year
                        'update curFamily
                        Dim i As Integer
                        For i = 0 To curFamily.Length - 1
                            If curFamily(i).id_formula = idFormula Then
                                curFamily(i).c_year = c_year
                            End If
                        Next
                    End If
                End If

            Next
            MsgBox("Success")

            lbCarIdSearch.Text = "-1"
            cmbCarNameSearch.Text = ""
            txtColorCode.Text = ""
            txtCardNumber.Text = ""
            txtFormulaName.Text = ""
            txtYearMin.Text = ""
            txtYearMax.Text = ""



        Else
            MsgBox("Select a formula first")
        End If
    End Sub


    'cars tab

    Private Sub butFindCarImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFindCarImg.Click
        If fileDialogCar.ShowDialog() = DialogResult.OK Then
            Try
                txtCarImgPath.Text = fileDialogCar.FileName

                Dim fInfo As FileInfo
                fInfo = New FileInfo(fileDialogCar.FileName)

                txtfnamehideen.Text = fInfo.Name
                Dim imgpath As String = fileDialogCar.FileName
                imageToPreview = Image.FromFile(imgpath)

                'pctCarImg.Image = imageToPreview
                pctCarImg.ImageLocation = imgpath
            Catch ex As IOException
                MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
            End Try

        Else
            Exit Sub
        End If
    End Sub

    Private Sub butAddCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddCar.Click

        Dim carname As String = txtCarNameForm.Text
        Dim carImg As String = txtCarImgPath.Text
        Dim carImgFile As String = txtfnamehideen.Text
        If carname = "" Then
            MsgBox("Car must have a name", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim destFileName As String = My.Application.Info.DirectoryPath & "//images//" & txtfnamehideen.Text
        Try 'copy image to folder
            If Not txtfnamehideen.Text.Trim = "" Then
                If File.Exists(destFileName) Then 'destination file exists
                    'add "2" to newFile name
                    Dim destFileNameChanged As String
                    Dim i As Integer = 0
                    destFileNameChanged = My.Application.Info.DirectoryPath & "//images//0" & txtfnamehideen.Text
                    While File.Exists(destFileNameChanged)
                        destFileNameChanged = My.Application.Info.DirectoryPath & "//images//" & i & txtfnamehideen.Text
                        carImgFile = i & txtfnamehideen.Text
                        i = i + 1
                    End While

                    File.Copy(carImg, destFileNameChanged, True)
                Else
                    File.Copy(carImg, destFileName, True)
                End If
            End If
            Dim tableName As String = carname
            tableName = tableName.Replace(" ", "_")
            If insertIntoCars(carname, carImgFile, tableName) Then
                MsgBox("Succes", MsgBoxStyle.Information, "Information")
            End If

        Catch ex As Exception
            MsgBox("could not copy image." & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)

        End Try

        txtCarNameForm.Text = ""
        txtCarImgPath.Text = ""
        pctCarImg.Image = Nothing
        'lsvCars.Items.Clear()
    End Sub

    Private Sub butSearchCarForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSearchCarForm.Click
        Dim carNameChk As Boolean = chkCarFormName.Checked
        Dim carName As String = txtCarNameForm.Text



        Dim str1 As String = ""
        If carName.Trim <> "" Then
            If carNameChk Then
                str1 = str1 & " carName like '%" & carName & "%'"
            Else
                str1 = str1 & " carName = '" & carName & "'"
            End If
        End If



        Dim whereStr As String = ""
        If str1 <> "" Then
            whereStr = str1
        End If


        If whereStr <> "" Then
            whereStr = " Where " & whereStr
        End If

        Dim carFiltered() As Car = getCars(whereStr)

        addResultsToListviewCars(carFiltered)
    End Sub

    Public Sub addResultsToListviewCars(ByVal carFiltered() As Car)
        Try
            lsvCars.Items.Clear()
            lsvCars.BeginUpdate()
            lsvCars.Sorting = SortOrder.None
            lsvCars.ListViewItemSorter = Nothing
            Dim i As Integer = 0
            For i = 0 To carFiltered.Length - 1
                lsvCars.Items.Add(carFiltered(i).id_car)
                lsvCars.Items(i).SubItems.Add(carFiltered(i).carName)

            Next
            lsvCars.EndUpdate()

            'autoresize listview
            For Each column As ColumnHeader In lsvCars.Columns
                If column.Tag <> "cidcar" Then
                    column.Width = -2
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub butEditCarForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEditCarForm.Click

        Dim carname As String = txtCarNameForm.Text
        Dim carImg As String = txtCarImgPath.Text
        Dim carImgFile As String = txtfnamehideen.Text

        If carname = "" Then
            MsgBox("Car must have a name", MsgBoxStyle.Information)
            Exit Sub
        End If

        If lbIdCarForm.Text < 0 Then
            MsgBox("A car must be selected first", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim destFileName As String = My.Application.Info.DirectoryPath & "//images//" & txtfnamehideen.Text
        Try 'copy image to folder
            If Not txtfnamehideen.Text.Trim = "" Then
                If File.Exists(destFileName) Then 'destination file exists
                    'add "2" to newFile name
                    Dim destFileNameChanged As String
                    Dim i As Integer = 0
                    destFileNameChanged = My.Application.Info.DirectoryPath & "//images//0" & txtfnamehideen.Text
                    While File.Exists(destFileNameChanged)
                        destFileNameChanged = My.Application.Info.DirectoryPath & "//images//" & i & txtfnamehideen.Text
                        carImgFile = i & txtfnamehideen.Text
                        i = i + 1
                    End While

                    File.Copy(carImg, destFileNameChanged, True)
                Else
                    File.Copy(carImg, destFileName, True)
                End If
            End If
            If updateCar(lbIdCarForm.Text, carname, carImgFile) Then
                MsgBox("Succes", MsgBoxStyle.Information, "Information")
            End If

        Catch ex As Exception
            MsgBox("could not copy image." & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)

        End Try


        txtCarNameForm.Text = ""
        txtCarImgPath.Text = ""
        pctCarImg.Image = Nothing
        ' lsvCars.Items.Clear()

    End Sub

    Private Sub lsvCars_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvCars.MouseClick, lsvCars.KeyDown, lsvCars.KeyUp
        If lsvCars.SelectedItems.Count > 0 Then
            lbIdCarForm.Text = lsvCars.SelectedItems(0).SubItems(0).Text
            txtCarNameForm.Text = lsvCars.SelectedItems(0).SubItems(1).Text
            Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & getCarById(lbIdCarForm.Text).carImgPath
            txtCarImgPath.Text = imgPath
            txtfnamehideen.Text = getCarById(lbIdCarForm.Text).carImgPath
            Try
                imageToPreview = Image.FromFile(imgPath)
                'pctCarImg.Image = imageToPreview
                pctCarImg.ImageLocation = imgPath
            Catch ex As IOException

                pctCarImg.ImageLocation = Nothing
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

    Private Sub butDeleteCarForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteCarForm.Click
        Dim carname As String = txtCarNameForm.Text

        If lbIdCarForm.Text < 0 Then
            MsgBox("A car must be selected first", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim car As Car = getCarById(lbIdCarForm.Text)
        If car Is Nothing Then
            MsgBox("car is already deleted", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this car? Yes or No", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If deleteCar(lbIdCarForm.Text, car.carName, car.tableName) Then
                MsgBox("Succes", MsgBoxStyle.Information, "Information")
                txtCarNameForm.Text = ""
                lsvCars.Items.Clear()
            End If

        End If


    End Sub
    ''end of cars tab


    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Settings.ShowDialog()
    End Sub

    Private Sub butAddLanguage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddLang.Click


        Dim Languagename As String = txtLanguageCodeForm.Text

        If Languagename = "" Then
            MsgBox("Language must have a name", MsgBoxStyle.Information)
            Exit Sub
        End If

        If insertIntoLanguages(Languagename, txtLanguageLabelForm.Text) Then
            MsgBox("Succes", MsgBoxStyle.Information, "Information")
        End If

        txtLanguageCodeForm.Text = ""
        txtLanguageLabelForm.Text = ""
        'lsvLanguage.Items.Clear()
    End Sub

    Private Sub butSearchLanguageForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSearchLangForm.Click
        Dim LanguageNameChk As Boolean = chkLanguageFormCode.Checked
        Dim LanguageName As String = txtLanguageCodeForm.Text

        Dim LabelChk As Boolean = chkLanguageLabelForm.Checked
        Dim Label As String = txtLanguageLabelForm.Text

        Dim str1 As String = ""
        If LanguageName.Trim <> "" Then
            If LanguageNameChk Then
                str1 = str1 & " code_language like '%" & LanguageName & "%'"
            Else
                str1 = str1 & " code_language = '" & LanguageName & "'"
            End If
        End If

        Dim str2 As String = ""
        If Label.Trim <> "" Then
            If LabelChk Then
                str2 = str2 & " label_language like '%" & Label & "%'"
            Else
                str2 = str2 & " label_language = '" & Label & "'"
            End If
        End If


        Dim whereStr As String = ""
        If str1 <> "" Then
            whereStr = str1
        End If
        If str2 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str2
            Else
                whereStr = str2
            End If
        End If

        If whereStr <> "" Then
            whereStr = " Where " & whereStr
        End If

        Dim LanguageFiltered() As Language = getLanguages(whereStr)

        addResultsToListviewLanguages(LanguageFiltered)
    End Sub

    Public Sub addResultsToListviewLanguages(ByVal LanguageFiltered() As Language)
        Try
            lsvLanguage.Items.Clear()
            lsvLanguage.BeginUpdate()
            lsvLanguage.Sorting = SortOrder.None
            lsvLanguage.ListViewItemSorter = Nothing
            Dim i As Integer = 0
            For i = 0 To LanguageFiltered.Length - 1
                lsvLanguage.Items.Add(LanguageFiltered(i).id_language)
                lsvLanguage.Items(i).SubItems.Add(LanguageFiltered(i).code_language)
                lsvLanguage.Items(i).SubItems.Add(LanguageFiltered(i).label_language)
            Next
            lsvLanguage.EndUpdate()

            'autoresize listview
            For Each column As ColumnHeader In lsvLanguage.Columns
                If column.Tag <> "cidLang" Then
                    column.Width = -2
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub butEditLanguageForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEditLangForm.Click
        Dim Languagename As String = txtLanguageCodeForm.Text
        If Languagename = "" Then
            MsgBox("Language must have a name", MsgBoxStyle.Information)
            Exit Sub
        End If

        If lbIdLanguageForm.Text < 0 Then
            MsgBox("A Language must be selected first", MsgBoxStyle.Information)
            Exit Sub
        End If

        If updateLanguage(lbIdLanguageForm.Text, Languagename, txtLanguageLabelForm.Text) Then
            MsgBox("Succes", MsgBoxStyle.Information, "Information")
        End If

        txtLanguageCodeForm.Text = ""
        txtLanguageLabelForm.Text = ""
        'lsvLanguage.Items.Clear()

    End Sub

    Private Sub lsvLanguages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvLanguage.MouseClick, lsvLanguage.KeyDown, lsvLanguage.KeyUp
        If lsvLanguage.SelectedItems.Count > 0 Then
            lbIdLanguageForm.Text = lsvLanguage.SelectedItems(0).SubItems(0).Text
            txtLanguageCodeForm.Text = lsvLanguage.SelectedItems(0).SubItems(1).Text
            txtLanguageLabelForm.Text = lsvLanguage.SelectedItems(0).SubItems(2).Text
        End If

    End Sub

    Private Sub lsvLanguages_doubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvLanguage.DoubleClick
        idLangTranslate = lsvLanguage.SelectedItems(0).SubItems(0).Text
        TranslateForm.ShowDialog()

    End Sub
    Private Sub butDeleteLanguageForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteLangForm.Click
        Dim Languagename As String = txtLanguageCodeForm.Text

        If lbIdLanguageForm.Text < 0 Then
            MsgBox("A Language must be selected first", MsgBoxStyle.Information)
            Exit Sub
        End If

        If deleteLanguage(lbIdLanguageForm.Text) Then
            MsgBox("Succes", MsgBoxStyle.Information, "Information")
        End If

        txtLanguageCodeForm.Text = ""
        txtLanguageLabelForm.Text = ""
        lsvLanguage.Items.Clear()

    End Sub

    'garage
#Region "garage"


    Private Sub butFindGarageImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFindGarageImg.Click
        If fileDialogGarage.ShowDialog() = DialogResult.OK Then
            Try
                txtGarageImgPath.Text = fileDialogGarage.FileName

                Dim fInfo As FileInfo
                fInfo = New FileInfo(fileDialogGarage.FileName)

                txtfnamegaragehidden.Text = fInfo.Name
                Dim imgpath As String = fileDialogGarage.FileName
                imageToPreview = Image.FromFile(imgpath)

                'pctCarImg.Image = imageToPreview
                pctGarageImg.ImageLocation = imgpath
            Catch ex As IOException
                MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
            End Try

        Else
            Exit Sub
        End If
    End Sub

    Private Sub butAddGarage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddGarage.Click
        Dim garageImg As String = txtGarageImgPath.Text
        Dim garageImgFile As String = txtfnamegaragehidden.Text

        If garageImg = "" Then
            MsgBox("Garage must have an image", MsgBoxStyle.Information)
            Exit Sub
        End If
        If lbIdLanguage.Text = "" Or lbIdLanguage.Text = "-1" Then
            MsgBox("Garage must have a language", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim garageThemeColorRGB As String = pctThemeColor.BackColor.ToArgb

        Dim Garagename As String = txtGarageNameForm.Text

        If Garagename = "" Then
            MsgBox("Garage must have a name", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim destFileName As String = My.Application.Info.DirectoryPath & "//images//" & txtfnamegaragehidden.Text
        Try 'copy image to folder

            If File.Exists(destFileName) Then 'destination file exists
                'add "2" to newFile name
                ' Dim destFileNameChanged As String
                'Dim i As Integer = 0
                ' destFileNameChanged = My.Application.Info.DirectoryPath & "//images//0" & txtfnamegaragehidden.Text
                ' While File.Exists(destFileNameChanged)
                'destFileNameChanged = My.Application.Info.DirectoryPath & "//images//" & i & txtfnamegaragehidden.Text
                'garageImgFile = i & txtfnamegaragehidden.Text
                'i = i + 1
                'End While

                'File.Copy(garageImg, destFileNameChanged, True)
            Else
                File.Copy(garageImg, destFileName, True)
            End If
            Dim applyEq As String = "0"
            If rdApply1.Checked Then
                applyEq = "1"
            End If
            Dim coat As String = "2K"
            If rdGarageLS.Checked Then
                coat = "LS"
            End If
            Dim showAlternative As String = "0"
            If rdShowAlternative.Checked Then
                showAlternative = "1"
            End If
            If rdShowAlternative2.Checked Then
                showAlternative = "2"
            End If
            'validate key uniquness
            Dim keyExist As Boolean = False
            Dim foundGarages() As Garage = getGarageByKey(txtkey.Text)
            If Not foundGarages Is Nothing Then
                If foundGarages.Length > 0 Then
                    Dim foundGarage As Garage = foundGarages(0)
                    Dim foundGarageName As String = foundGarage.garage_name
                    Dim foundGarageLocation As String = foundGarage.location
                    MsgBox("Key alread exists for garage '" & foundGarageName & " - " & foundGarageLocation & "'", MsgBoxStyle.Exclamation, "Error")
                    Return
                End If

            End If
            '

            If insertIntoGarages(Garagename, txtGarageLocationForm.Text, txtGarageRespform.Text, lbIdLanguage.Text, garageImgFile, applyEq, txtversion.Text, txttel.Text, txtkey.Text, coat, showAlternative, garageThemeColorRGB, txtusername.Text) Then
                MsgBox("Succes", MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception

        End Try


        txtGarageNameForm.Text = ""
        txtGarageLocationForm.Text = ""
        txtGarageRespform.Text = ""
        txtLanguage.Text = ""
        lbIdLanguage.Text = ""
        rdApply0.Checked = True
        txtGarageImgPath.Text = ""
        pctGarageImg.Image = Nothing
        txtversion.Text = ""
        txttel.Text = ""
        txtkey.Text = ""
        txtusername.Text = ""
        pctThemeColor.Image = Nothing
        'lsvGarage.Items.Clear()
        Dim GarageFiltered() As Garage = getGarages("")

        addResultsToListviewGarages(GarageFiltered)
    End Sub

    Private Sub butSearchGarageForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSearchGarageForm.Click
        Dim GarageNameChk As Boolean = chkGarageFormCode.Checked
        Dim GarageName As String = txtGarageNameForm.Text

        Dim LocationChk As Boolean = chkGarageLocationForm.Checked
        Dim Location As String = txtGarageLocationForm.Text

        Dim responsibleChk As Boolean = chkGarageRespForm.Checked
        Dim responsible As String = txtGarageRespform.Text

        Dim versionChk As Boolean = chkversion.Checked
        Dim version As String = txtversion.Text

        Dim telChk As Boolean = chktel.Checked
        Dim tel As String = txttel.Text

        Dim keyChk As Boolean = chkkey.Checked
        Dim key As String = txtkey.Text

        Dim usernameChk As Boolean = chkUsername.Checked
        Dim username As String = txtusername.Text

        Dim str1 As String = ""
        If GarageName.Trim <> "" Then
            If GarageNameChk Then
                str1 = str1 & " garage_name like '%" & GarageName & "%'"
            Else
                str1 = str1 & " garage_name = '" & GarageName & "'"
            End If
        End If

        Dim str2 As String = ""
        If Location.Trim <> "" Then
            If LocationChk Then
                str2 = str2 & " Location like '%" & Location & "%'"
            Else
                str2 = str2 & " Location = '" & Location & "'"
            End If
        End If

        Dim str3 As String = ""
        If responsible.Trim <> "" Then
            If responsibleChk Then
                str3 = str3 & " name_responsible like '%" & responsible & "%'"
            Else
                str3 = str3 & " name_responsible = '" & responsible & "'"
            End If
        End If

        Dim str4 As String = ""
        If version.Trim <> "" Then
            If versionChk Then
                str4 = str4 & " version like '%" & version & "%'"
            Else
                str4 = str4 & " version = '" & version & "'"
            End If
        End If

        Dim str5 As String = ""
        If tel.Trim <> "" Then
            If telChk Then
                str5 = str5 & " tel like '%" & tel & "%'"
            Else
                str5 = str5 & " tel = '" & tel & "'"
            End If
        End If

        Dim str6 As String = ""
        If key.Trim <> "" Then
            If keyChk Then
                str6 = str6 & " key like '%" & key & "%'"
            Else
                str6 = str6 & " key = '" & key & "'"
            End If
        End If

        Dim str7 As String = ""
        If username.Trim <> "" Then
            If usernameChk Then
                str7 = str7 & " [username] like '%" & username & "%'"
            Else
                str7 = str7 & " [username] = '" & username & "'"
            End If
        End If

        Dim whereStr As String = ""
        If str1 <> "" Then
            whereStr = str1
        End If
        If str2 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str2
            Else
                whereStr = str2
            End If
        End If

        If str3 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str3
            Else
                whereStr = str3
            End If
        End If

        If str4 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str4
            Else
                whereStr = str4
            End If
        End If

        If str5 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str5
            Else
                whereStr = str5
            End If
        End If

        If str6 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str6
            Else
                whereStr = str6
            End If
        End If

        If str7 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str7
            Else
                whereStr = str7
            End If
        End If


        If whereStr <> "" Then
            whereStr = " Where " & whereStr
        End If

        Dim GarageFiltered() As Garage = getGarages(whereStr)

        addResultsToListviewGarages(GarageFiltered)
    End Sub

    Public Sub addResultsToListviewGarages(ByVal GarageFiltered() As Garage)
        Try
            lsvGarage.Items.Clear()
            lsvGarage.BeginUpdate()
            lsvGarage.Sorting = SortOrder.None
            lsvGarage.ListViewItemSorter = Nothing
            Dim i As Integer = 0
            For i = 0 To GarageFiltered.Length - 1
                lsvGarage.Items.Add(GarageFiltered(i).id_garage)
                lsvGarage.Items(i).SubItems.Add(GarageFiltered(i).garage_name)
                lsvGarage.Items(i).SubItems.Add(GarageFiltered(i).location)
                lsvGarage.Items(i).SubItems.Add(GarageFiltered(i).name_responsible)
                lsvGarage.Items(i).SubItems.Add(getLanguage(GarageFiltered(i).id_language).label_language.Trim)
                lsvGarage.Items(i).SubItems.Add(GarageFiltered(i).id_language)
                If GarageFiltered(i).apply_equation Then
                    lsvGarage.Items(i).SubItems.Add("Eq. applied")
                Else
                    If GarageFiltered(i).apply_equation2 Then
                        lsvGarage.Items(i).SubItems.Add("Extended Eq. applied")
                    Else

                        If GarageFiltered(i).apply_equation4 Then
                            lsvGarage.Items(i).SubItems.Add("Extended +")
                        Else
                            If GarageFiltered(i).apply_equation3 Then
                                lsvGarage.Items(i).SubItems.Add("no 4581-91 Eq. applied")
                            Else
                                lsvGarage.Items(i).SubItems.Add("None")
                            End If
                        End If
                    End If
                End If
                lsvGarage.Items(i).SubItems.Add(GarageFiltered(i).version)
                lsvGarage.Items(i).SubItems.Add(GarageFiltered(i).coat)
            Next
            lsvGarage.EndUpdate()

            'autoresize listview
            For Each column As ColumnHeader In lsvGarage.Columns
                If column.Tag <> "cidGarage" And column.Tag <> "cidlanggarage" Then
                    column.Width = -2
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub butEditGarageForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEditGarageForm.Click
        Dim Garagename As String = txtGarageNameForm.Text
        Dim garageImg As String = txtGarageImgPath.Text
        Dim garageImgFile As String = txtfnamegaragehidden.Text

        Dim garageThemeColorRGB As String = pctThemeColor.BackColor.ToArgb

        If Garagename = "" Then
            MsgBox("Garage must have a name", MsgBoxStyle.Information)
            Exit Sub
        End If

        If lbIdGarageForm.Text < 0 Then
            MsgBox("A Garage must be selected first", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim destFileName As String = My.Application.Info.DirectoryPath & "//images//" & txtfnamegaragehidden.Text
        Try 'copy image to folder
            If File.Exists(destFileName) Then 'destination file exists
                'add "2" to newFile name
                ' Dim destFileNameChanged As String
                ' Dim i As Integer = 0
                ' destFileNameChanged = My.Application.Info.DirectoryPath & "//images//0" & txtfnamegaragehidden.Text
                'While File.Exists(destFileNameChanged)
                'destFileNameChanged = My.Application.Info.DirectoryPath & "//images//" & i & txtfnamegaragehidden.Text
                'garageImgFile = i & txtfnamegaragehidden.Text
                'i = i + 1
                'End While

                'File.Copy(garageImg, destFileNameChanged, True)
            Else
                File.Copy(garageImg, destFileName, True)
            End If

            Dim applyEq As String = "0"
            If rdApply1.Checked Then
                applyEq = "1"
           
            End If
            Dim coat As String = "2K"
            If rdGarageLS.Checked Then
                coat = "LS"
            End If

            Dim showAlternative As String = "0"
            If rdShowAlternative.Checked Then
                showAlternative = "1"
            End If
            If rdShowAlternative2.Checked Then
                showAlternative = "2"
            End If
           

            'validate key uniquness
            Dim keyExist As Boolean = False
            Dim foundGarages() As Garage = getGarageByKey(txtkey.Text)
            If Not foundGarages Is Nothing Then
                For i = 0 To foundGarages.Length - 1
                    Dim foundGarage As Garage = foundGarages(i)
                    If Not foundGarage.id_garage = lbIdGarageForm.Text Then
                        Dim foundGarageName As String = foundGarage.garage_name
                        Dim foundGarageLocation As String = foundGarage.location
                        MsgBox("Key already exists for garage '" & foundGarageName & " - " & foundGarageLocation & "'", MsgBoxStyle.Exclamation, "Error")
                        Return
                    End If

                Next

            End If
            '

            If updateGarage(lbIdGarageForm.Text, Garagename, txtGarageRespform.Text, txtGarageLocationForm.Text, lbIdLanguage.Text, garageImgFile, applyEq, txtversion.Text, txttel.Text, txtkey.Text, coat, showAlternative, garageThemeColorRGB, txtusername.Text) Then
                MsgBox("Succes", MsgBoxStyle.Information, "Information")
            End If

        Catch ex As Exception
            MsgBox("could not copy image." & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)

        End Try


        lbIdGarageForm.Text = "-1"
        txtGarageNameForm.Text = ""
        txtGarageLocationForm.Text = ""
        txtGarageRespform.Text = ""
        txtLanguage.Text = ""
        lbIdLanguage.Text = "-1"
        rdApply0.Checked = True
        txtGarageImgPath.Text = ""
        txtversion.Text = ""
        txttel.Text = ""
        txtkey.Text = ""
        txtusername.Text = ""
        pctGarageImg.Image = Nothing
        pctThemeColor.Image = Nothing

        'lsvGarage.Items.Clear()
        Dim GarageFiltered() As Garage = getGarages("")

        addResultsToListviewGarages(GarageFiltered)
    End Sub

    Private Sub lsvGarages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvGarage.MouseClick, lsvGarage.KeyDown, lsvGarage.KeyUp
        lbIdGarageForm.Text = lsvGarage.SelectedItems(0).SubItems(0).Text
        txtGarageNameForm.Text = lsvGarage.SelectedItems(0).SubItems(1).Text
        txtGarageLocationForm.Text = lsvGarage.SelectedItems(0).SubItems(2).Text
        txtGarageRespform.Text = lsvGarage.SelectedItems(0).SubItems(3).Text
        Try
            txtLanguage.Text = lsvGarage.SelectedItems(0).SubItems(4).Text
            lbIdLanguage.Text = lsvGarage.SelectedItems(0).SubItems(5).Text
        
            If lsvGarage.SelectedItems(0).SubItems(6).Text = "Eq. applied" Then
                rdApply1.Checked = True
           
            End If

            txtversion.Text = lsvGarage.SelectedItems(0).SubItems(7).Text
       
            If lsvGarage.SelectedItems(0).SubItems(8).Text = "LS" Then
                rdGarageLS.Checked = True
                rdGarage2k.Checked = False
            Else
                rdGarageLS.Checked = False
                rdGarage2k.Checked = True
            End If
        Catch ex As Exception

        End Try
        Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & getGarageById(lbIdGarageForm.Text).logo
        txtGarageImgPath.Text = imgPath
        Dim theGarage As Garage = getGarageById(lbIdGarageForm.Text)

        txttel.Text = theGarage.tel
        txtkey.Text = theGarage.key
        txtusername.Text = theGarage.username
        txtfnamegaragehidden.Text = theGarage.logo
        If theGarage.showAlternativeName Then
            rdShowAlternative.Checked = True
        Else
            If theGarage.showAlternativeName2 Then
                rdShowAlternative2.Checked = True
            Else
                rdShowAltNone.Checked = True

            End If

        End If

        If theGarage.apply_equation Then
            rdApply0.Checked = False
            rdApply1.Checked = True
        Else
            rdApply0.Checked = True
            rdApply1.Checked = False
        End If
        Try
            imageToPreview = Image.FromFile(imgPath)
            'pctCarImg.Image = imageToPreview
            pctGarageImg.ImageLocation = imgPath
        Catch ex As IOException
            pctGarageImg.ImageLocation = Nothing
            MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
        End Try

        Try
            pctThemeColor.BackColor = Drawing.Color.FromArgb(theGarage.themeColor)
        Catch ex As Exception
        End Try



    End Sub

    Private Sub butDeleteGarageForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteGarageForm.Click
        Dim Garagename As String = txtGarageNameForm.Text

        If lbIdGarageForm.Text < 0 Then
            MsgBox("A Garage must be selected first", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim garageToDelete As Garage = getGarageById(lbIdGarageForm.Text)
        If deleteGarage(lbIdGarageForm.Text, garageToDelete) Then
            MsgBox("Succes", MsgBoxStyle.Information, "Information")
            txtGarageNameForm.Text = ""
            txtGarageLocationForm.Text = ""
            txtversion.Text = ""
            txtkey.Text = ""
            txtusername.Text = ""
            txttel.Text = ""
            lsvGarage.Items.Clear()
        End If

    End Sub

    Private Sub butFindLang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFindLang.Click
        langForm.ShowDialog()
    End Sub

    'end garage
    'install garage
    Private Sub butBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butBrowse.Click
        If FBrowserGarage.ShowDialog() = DialogResult.OK Then
            txtGarageDirectory.Text = FBrowserGarage.SelectedPath
        Else
            Exit Sub
        End If
    End Sub

    Private Sub butBrowseDb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butBrowseDb.Click
        If FBrowserGarage.ShowDialog() = DialogResult.OK Then
            txtDBDirectory.Text = FBrowserGarage.SelectedPath
        Else
            Exit Sub
        End If

    End Sub
    Public Function CopyDirectory(ByVal Src As String, ByVal Dest As String, Optional ByVal bQuiet As Boolean = False) As Boolean
        If Not Directory.Exists(Src) Then
            Throw New DirectoryNotFoundException("The directory " & Src & " does not exists")
        End If
        If Directory.Exists(Dest) AndAlso Not bQuiet Then
            If MessageBox.Show("directory " & Dest & " already exists." & vbCrLf & _
            "If you continue, any files with the same name will be overwritten", _
            "Continue?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button2) = DialogResult.Cancel Then Exit Function
        End If

        'add Directory Seperator Character (\) for the string concatenation shown later
        If Dest.Substring(Dest.Length - 1, 1) <> Path.DirectorySeparatorChar Then
            Dest += Path.DirectorySeparatorChar
        End If
        If Not Directory.Exists(Dest) Then Directory.CreateDirectory(Dest)
        Dim Files As String()
        Files = Directory.GetFileSystemEntries(Src)
        Dim element As String
        For Each element In Files
            If Directory.Exists(element) Then
                'if the current FileSystemEntry is a directory,
                'call this function recursively
                CopyDirectory(element, Dest & Path.GetFileName(element), True)
            Else
                'the current FileSystemEntry is a file so just copy it
                File.Copy(element, Dest & Path.GetFileName(element), True)
            End If
        Next
        Return True
    End Function


    Private Sub butInstallMobile_Click_test(sender As Object, e As EventArgs) 'Handles butInstallMobile.Click
        decryptQuantitiesSaipa("C:\Users\User\Desktop\amazona\dbPaintShop.mdb")
    End Sub
    Private Sub butInstallMobile_Click(sender As Object, e As EventArgs) Handles butInstallMobile.Click
        Dim applyGarageTables As Boolean = True

        Dim mobileNumber As String = InputBox("PLease enter the mobile app public number", "tel", "")
        If mobileNumber = "" Then
            Exit Sub
        End If
        setMobileAppPubNum(mobileNumber)

        Try
            'copy all garages logo

            Dim garageFiltered() As Garage = getGarages("")
            Directory.CreateDirectory(txtDBDirectory.Text & "\logos")
            For i = 0 To garageFiltered.Length - 1
                Try
                    If File.Exists(My.Application.Info.DirectoryPath & "\\images\\" & garageFiltered(i).logo) Then
                        File.Copy(My.Application.Info.DirectoryPath & "\\images\\" & garageFiltered(i).logo, txtDBDirectory.Text & "\logos\" & garageFiltered(i).logo, True)
                    End If
                Catch ex As Exception

                End Try

            Next


            File.Copy(My.Application.Info.DirectoryPath & "//dbPaintShop.mdb", txtDBDirectory.Text & "\dbPaintShop.mdb", True)


            File.Copy(My.Application.Info.DirectoryPath & "//darkgreen-dot.png", txtDBDirectory.Text & "\darkgreen-dot.png", True)
            File.Copy(My.Application.Info.DirectoryPath & "//codelocator.gif", txtDBDirectory.Text & "\codelocator.gif", True)

            If CopyDirectory(My.Application.Info.DirectoryPath & "\\images", txtDBDirectory.Text & "\\images") Then
            Else
                MessageBox.Show("Error copying images folder")
            End If
            If CopyDirectory(My.Application.Info.DirectoryPath & "\\variants", txtDBDirectory.Text & "\\variants") Then
            Else
                MessageBox.Show("Error copying variants folder")
            End If

            decryptQuantities(txtDBDirectory.Text & "\dbPaintShop.mdb")

            'execute optimization procedure on the garage db
            If applyGarageTables Then
                startOptimizationProcedure(txtDBDirectory.Text & "\dbPaintShop.mdb", True)
            End If




            MsgBox("Install file successfully generated at:" & vbNewLine & txtDBDirectory.Text, MsgBoxStyle.Information)
        Catch ex As IOException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub butInstall_temp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim dbFileNameToUpload As String = "dbPaintShopMK123456.mdb"
        Dim dbFile As Byte() = File.ReadAllBytes("C:\Users\User\Desktop\garage01122020\garageLaserPaints\dbPaintShop.mdb")

        FtpUploadFileForDesktop(dbFile, dbFileNameToUpload)

    End Sub

    Private Sub butBrowseHqDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butBrowseHqDirectory.Click
        If FBrowserGarage.ShowDialog() = DialogResult.OK Then
            txtHqDirectory.Text = FBrowserGarage.SelectedPath
        Else
            Exit Sub
        End If
    End Sub

    Private Sub butConvertToHQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butConvertToHQ.Click
        If lbIdGarageForm.Text < 0 Then
            MsgBox("You must select a garage first", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtHqDirectory.Text = "" Then
            MsgBox("Please choose a directory first", MsgBoxStyle.Information)
            Exit Sub
        End If

        setChosenGarage(lbIdGarageForm.Text)
        Dim leGarage As Garage = getGarageById(lbIdGarageForm.Text)
        Dim garageFolderName As String = leGarage.garage_name & leGarage.location
        garageFolderName = garageFolderName.Replace(" ", "")
        txtHqDirectory.Text = txtHqDirectory.Text & "\hq" & garageFolderName
        'create the folder'
        If (Not System.IO.Directory.Exists(txtHqDirectory.Text)) Then
            System.IO.Directory.CreateDirectory(txtHqDirectory.Text)
        End If
        '''''''''''''''''''
        Dim logo As String = leGarage.logo
        If leGarage.coat Is Nothing Then
            MsgBox("You can't generate a garage before setting its coat (LS or 2K)!", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            If leGarage.coat <> "LS" And leGarage.coat <> "2K" Then
                MsgBox("You can't generate a garage before setting its coat (LS or 2K)!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        'copy all inside the hq folder
        My.Computer.FileSystem.CopyDirectory(My.Application.Info.DirectoryPath, txtHqDirectory.Text, True)

        startHqConversionProcess(txtHqDirectory.Text & "\dbPaintShop.mdb")

    End Sub

#Region "startHqConversionProcess"

    Dim convertToHqThread As System.Threading.Thread



    Public Sub startHqConversionProcessThread(ByVal dbFileLocation As String)
        Me.Enabled = False

        Dim specificConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
            dbFileLocation & ";Jet OLEDB:Database Password=A!mA@HaP#pYZ$o;"
        Dim allFormulas As Formula() = getFormulas("", specificConString)
        colorsFromSpecificDB = getColors("", specificConString)

        Dim chosenGarage As Garage = getChosenGarage(specificConString)

        Dim newId_formulaColor As Integer = getLastInsertedFormulaColorId(specificConString) + 1

        Dim formulaIdToDeleteArray As New ArrayList
        Dim lastOldIdFormulaColor As Integer = -1
        Dim indexFormula As Integer = 0
        Dim keepContinue As Boolean = True
        Dim limitIdFormula As Integer = 51552
        For Each formula In allFormulas
            indexFormula += 1

            If limitIdFormula = formula.id_formula Then
                keepContinue = False

            End If

            If keepContinue Then
               ' Continue For
            End If
            lbHqConversionProgress.Text = indexFormula & " of " & allFormulas.Length

            Console.WriteLine(indexFormula & " of " & allFormulas.Length)
            Dim formulaColorTab As FormulaColor() = getFormulaColorsByIdFormulaForHqConversion(formula.id_formula, specificConString)
            Dim couche As Boolean = isCouche(formula.name_formula)
            Dim typeFormula As String = formula.type
            Dim timePassed As TimeSpan
            Dim Starttime As DateTime
            Dim EndTime As DateTime

            Dim timePassedAll As TimeSpan
            Dim StarttimeAll As DateTime = DateTime.Now
            Dim EndTimeAll As DateTime

            If typeFormula = "LS" Then
                'sort descending

                Starttime = DateTime.Now
                formulaColorTab = sortDescending(formulaColorTab)
                EndTime = DateTime.Now

                timePassed = EndTime - Starttime
                Console.WriteLine("SortDescending time:" & timePassed.ToString)
            Else
                If typeFormula = "BC" Then

                    Starttime = DateTime.Now
                    formulaColorTab = applyEquationBC(formulaColorTab, "4002", "4110", specificConString)
                    EndTime = DateTime.Now

                    timePassed = EndTime - Starttime
                    Console.WriteLine("applyEquationBC time:" & timePassed.ToString)
                End If

                If chosenGarage.apply_equation Then

                    Starttime = DateTime.Now
                    formulaColorTab = eqDoubleCBXB_50per4010(formulaColorTab, specificConString)
                    EndTime = DateTime.Now

                    timePassed = EndTime - Starttime
                    Console.WriteLine("eqDoubleCBXB_50per4010 time:" & timePassed.ToString)

                Else
                    If chosenGarage.apply_equation2 Or chosenGarage.apply_equation4 Then
                        Starttime = DateTime.Now
                        formulaColorTab = eqDoubleCBXB_50per4010Extended(formulaColorTab, specificConString)
                        EndTime = DateTime.Now

                        timePassed = EndTime - Starttime
                        Console.WriteLine("eqDoubleCBXB_50per4010Extended time:" & timePassed.ToString)

                        If chosenGarage.apply_equation4 Then
                            Starttime = DateTime.Now
                            formulaColorTab = extendedOptimization(formulaColorTab, couche, specificConString)
                            EndTime = DateTime.Now

                            timePassed = EndTime - Starttime
                            Console.WriteLine("extendedOptimization time:" & timePassed.ToString)
                        End If
                    Else
                        If chosenGarage.apply_equation3 Then
                            Dim Starttime0 As DateTime = DateTime.Now
                            formulaColorTab = eqDoubleCBXB_50per4010_no4581_no4091(formulaColorTab, specificConString)
                            Dim EndTime0 As DateTime = DateTime.Now

                            timePassed = EndTime0 - Starttime0
                            Console.WriteLine("eqDoubleCBXB_50per4010_no4581_no4091 time:" & timePassed.ToString)
                        End If
                    End If
                End If
            End If
            Starttime = DateTime.Now
            Dim qty4201 As Double = findQuantityOfColorInformula(formulaColorTab, "4201", specificConString)
            EndTime = DateTime.Now

            timePassed = EndTime - Starttime
            Console.WriteLine("findQuantityOfColorInformula time:" & timePassed.ToString)

            If chosenGarage.apply_equation5 And qty4201 >= 180 And formula.isEquation4201_180 Then
                Starttime = DateTime.Now
                formulaColorTab = eqDivedBy2If4201BigThenOrEq180(formulaColorTab, specificConString)
                EndTime = DateTime.Now

                timePassed = EndTime - Starttime
                Console.WriteLine("eqDivedBy2If4201BigThenOrEq180 time:" & timePassed.ToString)
            End If

            If chosenGarage.apply_equation6 Then
                Starttime = DateTime.Now
                formulaColorTab = eq4080_4082_4060(formulaColorTab, specificConString)
                EndTime = DateTime.Now

                timePassed = EndTime - Starttime
                Console.WriteLine("eq4080_4082_4060 time:" & timePassed.ToString)
            End If

            'reapply the sorting in case it was corrupted with the other eq

            If typeFormula = "BC" Then
                Starttime = DateTime.Now
                formulaColorTab = applyEquationBC(formulaColorTab, "4002", "4110", specificConString)
                EndTime = DateTime.Now

                timePassed = EndTime - Starttime
                Console.WriteLine("applyEquationBC 2 time:" & timePassed.ToString)
            End If

            If formulaColorTab.Length > 0 Then
                If formulaColorTab(formulaColorTab.Length - 1).id_formulaColor > lastOldIdFormulaColor Then
                    lastOldIdFormulaColor = formulaColorTab(formulaColorTab.Length - 1).id_formulaColor
                End If

                Starttime = DateTime.Now
                'deleteFromFormulaColorSpecificDB(formula.id_formula, specificConString)
                'deleteFromFormulaColorSpecificDBDAO(formula.id_formula, dbFileLocation)
                formulaIdToDeleteArray.Add(formula.id_formula)
                EndTime = DateTime.Now
                timePassed = EndTime - Starttime
                Console.WriteLine("deleteFromFormulaColorSpecificDB time:" & timePassed.ToString)
                Starttime = DateTime.Now
                For i = 0 To formulaColorTab.Length - 1
                    newId_formulaColor += 1
                    'If Not insertIntoFormulaColorSpecificDBDAO(newId_formulaColor, formulaColorTab(i).id_formula, formulaColorTab(i).id_color, formulaColorTab(i).quantite, formulaColorTab(i).id_Unit, dbFileLocation) Then
                    If Not insertIntoFormulaColorSpecificDB(newId_formulaColor, formulaColorTab(i).id_formula, formulaColorTab(i).id_color, formulaColorTab(i).quantite, formulaColorTab(i).id_Unit, specificConString) Then
                        MsgBox("problem setting color '" & formulaColorTab(i).id_color & "' to formula '" & formulaColorTab(i).id_formula & "'")
                        Me.Enabled = True
                        Exit Sub
                    End If

                Next
                EndTime = DateTime.Now

                timePassed = EndTime - Starttime
                Console.WriteLine("insertIntoFormulaColorSpecificDB all time:" & timePassed.ToString & " for formula id " & formula.id_formula)
            End If

            EndTimeAll = DateTime.Now

            timePassedAll = EndTimeAll - StarttimeAll
            Console.WriteLine("-------------All time:" & timePassedAll.ToString)
        Next

        Dim timePassedDelete As TimeSpan
        Dim StarttimeDelete As DateTime = DateTime.Now
        Dim EndTimeDelete As DateTime
        StarttimeDelete = DateTime.Now
        'delete formula colors
        Dim inSql As String = ""
        Dim inSqlIndex As Integer = 0
        For Each formulaId In formulaIdToDeleteArray
            'deleteFromFormulaColorSpecificDBDAO("(" & formulaId & ")", dbFileLocation)

            If inSqlIndex = 0 Then
                inSql = "("
            End If
            inSql = inSql & formulaId

            If inSqlIndex < formulaIdToDeleteArray.Count - 1 Then
                inSql = inSql & ","
            Else
                inSql = inSql & ")"
            End If

            inSqlIndex += 1
        Next
        Console.WriteLine("formulasColorMax old id to delete:" & lastOldIdFormulaColor)
        Console.WriteLine("formulas to delete sql:" & inSql)
        deleteFromFormulaColorSpecificDBWhere(" where id_formulaColor<=" & lastOldIdFormulaColor, specificConString)
        
        EndTimeDelete = DateTime.Now

        timePassedDelete = EndTimeDelete - StarttimeDelete
        Console.WriteLine("-------------delete time:" & timePassedDelete.ToString)
        MsgBox("HQ successfully generated at:" & vbNewLine & txtHqDirectory.Text, MsgBoxStyle.Information)
        Me.Enabled = True
    End Sub
    Public Function startHqConversionProcess(ByVal dbFileLocation As String) As Boolean

        convertToHqThread = New System.Threading.Thread(AddressOf startHqConversionProcessThread)
        convertToHqThread.Start(dbFileLocation)

    End Function
#End Region
    Private Sub butInstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butInstall.Click

        If lbIdGarageForm.Text < 0 Then
            MsgBox("You must select a garage first", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtGarageDirectory.Text = "" Then
            MsgBox("Please choose a directory first", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try

            setChosenGarage(lbIdGarageForm.Text)
            Dim leGarage As Garage = getGarageById(lbIdGarageForm.Text)
            Dim garageFolderName As String = leGarage.garage_name & leGarage.location
            garageFolderName = garageFolderName.Replace(" ", "")
            txtGarageDirectory.Text = txtGarageDirectory.Text & "\garage" & garageFolderName
            'create the folder'
            If (Not System.IO.Directory.Exists(txtGarageDirectory.Text)) Then
                System.IO.Directory.CreateDirectory(txtGarageDirectory.Text)
            End If
            '''''''''''''''''''
            Dim logo As String = leGarage.logo
            If leGarage.coat Is Nothing Then
                MsgBox("You can't generate a garage before setting its coat (LS or 2K)!", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                If leGarage.coat <> "LS" And leGarage.coat <> "2K" Then
                    MsgBox("You can't generate a garage before setting its coat (LS or 2K)!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
            'create version file
            Dim versionTxt As String = leGarage.version
            Using outfile As New StreamWriter(txtGarageDirectory.Text & "\vers.txt")
                outfile.Write(versionTxt)
            End Using

            'copy all inside the garage folder
            My.Computer.FileSystem.CopyDirectory(My.Application.Info.DirectoryPath & "\\Garage", txtGarageDirectory.Text, True)

            ''''''''''''''''''''''''''''''''''''''''
            Dim garageCode As String = ""
            Dim uploadDb As Boolean = False
            If MsgBox("Do you want to upload this garage's Data?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                uploadDb = True
                garageCode = InputBox("PleasgarageCodee enter a garage code (no special characters)", "Garage Code", "")
                While (containsSpecialCharacters(garageCode))
                    garageCode = InputBox("Please enter another garage code because this one contains a special character", "Garage Code", "")
                End While

            End If

            File.Copy(My.Application.Info.DirectoryPath & "\\images\\" & logo, txtGarageDirectory.Text & "\logo.jpg", True)
            File.Copy(My.Application.Info.DirectoryPath & "//dbPaintShop.mdb", txtGarageDirectory.Text & "\dbPaintShop.mdb", True)
            'File.Copy(My.Application.Info.DirectoryPath & "//dbPaintShopMain.mdb", txtGarageDirectory.Text & "\dbPaintShopMain.mdb", True)

            File.Copy(My.Application.Info.DirectoryPath & "//darkgreen-dot.png", txtGarageDirectory.Text & "\darkgreen-dot.png", True)
            File.Copy(My.Application.Info.DirectoryPath & "//codelocator.gif", txtGarageDirectory.Text & "\codelocator.gif", True)
            'File.Copy(My.Application.Info.DirectoryPath & "//garagePricing.xls", txtGarageDirectory.Text & "\garagePricing.xls", True)

            'File.Copy(My.Application.Info.DirectoryPath & "\\Garage\\PaintShopApplication.vshost.exe", txtGarageDirectory.Text & "\PaintShopApplication.vshost.exe", True)
            'If CopyDirectory(My.Application.Info.DirectoryPath & "\\Garage\\images", txtGarageDirectory.Text & "\\images") Then
            If CopyDirectory(My.Application.Info.DirectoryPath & "\\images", txtGarageDirectory.Text & "\\images") Then
                'MessageBox.Show("Success copying directory")
            Else
                MessageBox.Show("Error copying images folder")
            End If
            If CopyDirectory(My.Application.Info.DirectoryPath & "\\variants", txtGarageDirectory.Text & "\\variants") Then
                'MessageBox.Show("Success copying directory")
            Else
                MessageBox.Show("Error copying variants folder")
            End If

            'execute security procedures
            'AddDirectorySecurity(txtGarageDirectory.Text, Environment.UserDomainName & "\" & Environment.UserName, FileSystemRights.ReadData, AccessControlType.Allow)

            hashGarageKeys(txtGarageDirectory.Text & "\dbPaintShop.mdb")
            Dim generatedGarage As Garage = getGarageById(lbIdGarageForm.Text)
            ecnryptColors(txtGarageDirectory.Text & "\dbPaintShop.mdb", generatedGarage)

            'execute optimization procedure on the garage db
            startOptimizationProcedure(txtGarageDirectory.Text & "\dbPaintShop.mdb", False)

            ' MsgBox("Install file successfully generated at:" & vbNewLine & txtGarageDirectory.Text, MsgBoxStyle.Information)
            If uploadDb Then
                Dim dbFileNameToUpload As String = "dbPaintShop" & garageCode & ".mdb"
                Dim dbFile As Byte() = File.ReadAllBytes(txtGarageDirectory.Text & "\dbPaintShop.mdb")

                FtpUploadFileForDesktop(dbFile, dbFileNameToUpload)
                MsgBox("Data uploaded successfully", MsgBoxStyle.Information)
            Else
                MsgBox("Install file successfully generated at:" & vbNewLine & txtGarageDirectory.Text, MsgBoxStyle.Information)
            End If

        Catch ex As IOException
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub pctThemeColor_Click(sender As Object, e As EventArgs) Handles pctThemeColor.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            pctThemeColor.BackColor = dlgColor.Color
        End If
    End Sub

#End Region
    'Bcolor
#Region "BColor"

    Private Sub butAddBColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddBColor.Click
        Dim colorImg As String = txtBColorImgPath.Text
        Dim colorImgFile As String = txtfnamehideenColor.Text

        Dim BColorname As String = txtBColorNameForm.Text

        Dim BColornameAlt As String = txtBColorNameFormAlt.Text
        Dim BColornameAlt2 As String = txtBColorNameFormAlt2.Text

        Dim colorA As String = pctBColorRGB.BackColor.A
        Dim colorR As String = pctBColorRGB.BackColor.R
        Dim colorG As String = pctBColorRGB.BackColor.G
        Dim colorB As String = pctBColorRGB.BackColor.B

        Dim argb As String = colorA & "," & colorR & "," & colorG & "," & colorB

        If BColorname = "" Then
            MsgBox("BColor must have a name", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim colors() As Color = getColors("WHERE colorCode='" & SafeSqlLiteral(txtBColorCodeForm.Text) & "'")

        If Not colors Is Nothing Then
            If colors.Length > 0 Then
                MsgBox("This color code already exists, Color not saved", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If
        Dim sqlSyntax As String = " or (name_color_alternative <> '' and name_color_alternative='" & SafeSqlLiteral(BColornameAlt) & "')"
        sqlSyntax = sqlSyntax & " or (name_color_alternative2 <> '' and name_color_alternative2='" & SafeSqlLiteral(BColornameAlt2) & "')"

        colors = getColors("WHERE name_color='" & SafeSqlLiteral(BColorname) & "' " & sqlSyntax)
        If Not colors Is Nothing Then
            If colors.Length > 0 Then
                MsgBox("This color name already exists, Color not saved", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If Not IsNumeric(txtMasseVolumique.Text) Or Not IsNumeric(txtMasseVolumiqueExt.Text) Then
            MessageBox.Show("The MasseVolumique must be a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim destFileName As String = My.Application.Info.DirectoryPath & "//images//" & txtfnamehideenColor.Text
        Dim price As Decimal
        Dim rateToLitre As Decimal
        Dim id_unitLitre As Integer
        Dim id_unit_on_entry As Integer
        Try 'copy image to folder
            Try
                If txtfnamehideenColor.Text.Trim <> "" Then

                    If File.Exists(destFileName) Then 'destination file exists
                        'add "2" to newFile name
                        'Dim destFileNameChanged As String
                        'Dim i As Integer = 0
                        'destFileNameChanged = My.Application.Info.DirectoryPath & "//images//0" & txtfnamehideenColor.Text
                        ' While File.Exists(destFileNameChanged)
                        'destFileNameChanged = My.Application.Info.DirectoryPath & "//images//" & i & txtfnamehideenColor.Text
                        'colorImgFile = i & txtfnamehideenColor.Text
                        ' i = i + 1
                        'End While

                        'File.Copy(colorImg, destFileNameChanged, True)
                    Else
                        File.Copy(colorImg, destFileName, True)
                    End If
                Else
                    If MsgBox("No color image assigned to this color, continue anyway?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try

            Dim priceString As String = txtPriceBcolorForm.Text
            If priceString.Trim = "" Then
                priceString = "0"
            End If

            If Not IsNumeric(priceString) Then
                MsgBox("Price must be numeric", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            price = priceString
            If price = 0 Then
                If cmbUnit.Text.Trim = "" Then
                    cmbUnit.SelectedIndex = 0
                End If
            Else
                If cmbUnit.Text.Trim = "" Then
                    MsgBox("Price must correspond to a unit", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If

            Dim unitsTab() As Unit = getUnits()
            rateToLitre = 1

            For i = 0 To unitsTab.Length - 1
                If unitsTab(i).code_unit.Trim.ToUpper = cmbUnit.Text.Trim.ToUpper Then
                    rateToLitre = unitsTab(i).rateToLitre * 1000
                    id_unit_on_entry = unitsTab(i).id_unit
                End If

                If unitsTab(i).code_unit.Trim = "L" Then
                    id_unitLitre = unitsTab(i).id_unit
                End If
            Next

            'If price = 0 Then
            'price = 0.01 / rateToLitre
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        If insertIntoColors(colorImgFile, BColorname, price / rateToLitre, txtBColorCodeForm.Text, chosenCurrency.id_currency, id_unitLitre, id_unit_on_entry, txtMasseVolumique.Text, txtMasseVolumiqueExt.Text, BColornameAlt, BColornameAlt2, argb) Then
            MsgBox("Succes", MsgBoxStyle.Information, "Information")
        End If

        txtBColorNameForm.Text = ""
        txtBColorNameFormAlt.Text = ""
        txtBColorNameFormAlt2.Text = ""
        txtPriceBcolorForm.Text = ""
        txtMasseVolumique.Text = ""
        txtMasseVolumiqueExt.Text = ""
        txtBColorImgPath.Text = ""
        pctBColorImg.Image = Nothing
        pctBColorRGB.BackColor = Nothing

        'lsvBColors.Items.Clear()
    End Sub

    Private Sub butSearchBColorForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSearchBColorForm.Click
        Dim BColorNameChk As Boolean = chkBColorFormName.Checked
        Dim BColorName As String = txtBColorNameForm.Text

        Dim BColorNameAltChk As Boolean = chkBColorFormNameAlt.Checked
        Dim BColorNameAlt As String = txtBColorNameFormAlt.Text

        Dim BColorNameAlt2Chk As Boolean = chkBColorFormNameAlt2.Checked
        Dim BColorNameAlt2 As String = txtBColorNameFormAlt2.Text

        Dim BColorCodeChk As Boolean = chkBColorFormCode.Checked
        Dim BColorCode As String = txtBColorCodeForm.Text


        Dim str1 As String = ""
        If BColorName.Trim <> "" Then
            If BColorNameChk Then
                str1 = str1 & " name_color like '%" & BColorName & "%'"
            Else
                str1 = str1 & " name_color = '" & BColorName & "'"
            End If
        End If

        Dim str2 As String = ""
        If BColorCode.Trim <> "" Then
            If BColorCodeChk Then
                str2 = str2 & " colorCode like '%" & BColorCode & "%'"
            Else
                str2 = str2 & " colorCode = '" & BColorCode & "'"
            End If
        End If

        Dim str3 As String = ""
        If BColorNameAlt.Trim <> "" Then
            If BColorNameAltChk Then
                str3 = str3 & " name_color_alternative like '%" & BColorNameAlt & "%'"
            Else
                str3 = str3 & " name_color_alternative = '" & BColorNameAlt & "'"
            End If
        End If

        Dim str4 As String = ""
        If BColorNameAlt2.Trim <> "" Then
            If BColorNameAlt2Chk Then
                str4 = str4 & " name_color_alternative2 like '%" & BColorNameAlt2 & "%'"
            Else
                str4 = str4 & " name_color_alternative2 = '" & BColorNameAlt2 & "'"
            End If
        End If

        Dim whereStr As String = ""
        If str1 <> "" Then
            whereStr = str1
        End If
        If str2 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str2
            Else
                whereStr = str2
            End If
        End If

        If str3 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str3
            Else
                whereStr = str3
            End If

        End If

        If str4 <> "" Then
            If whereStr <> "" Then
                whereStr = whereStr & " AND " & str4
            Else
                whereStr = str4
            End If

        End If

        If whereStr <> "" Then
            whereStr = " Where " & whereStr
        End If

        Dim BColorFiltered() As Color = getColors(whereStr)

        addResultsToListviewBColors(BColorFiltered)
    End Sub

    Public Sub addResultsToListviewBColors(ByVal BColorFiltered() As Color)
        Try
            lsvBColors.Items.Clear()
            lsvBColors.BeginUpdate()
            lsvBColors.Sorting = SortOrder.None
            lsvBColors.ListViewItemSorter = Nothing
            Dim i As Integer = 0
            For i = 0 To BColorFiltered.Length - 1
                lsvBColors.Items.Add(BColorFiltered(i).id_color)
                lsvBColors.Items(i).SubItems.Add(BColorFiltered(i).colorCode)
                lsvBColors.Items(i).SubItems.Add(BColorFiltered(i).name_color)
                Dim price As Decimal = BColorFiltered(i).defaultPrice
                Dim unit As Unit = getUnit(BColorFiltered(i).id_unit_on_entry)
                Dim unitStr As String = unit.code_unit.Trim
                Dim currency As String = getCurrency(BColorFiltered(i).id_defaultCurreny).code_currency.Trim
                'price = convertToChosenCurrency(price, getCurrency(BColorFiltered(i).id_defaultCurreny).rateToDollar)
                'price = convertToChosenUnit(price, getUnit(BColorFiltered(i).id_defaultUnit).rateToLitre)

                'convert price
                'Dim rateToLitre As Decimal = unit.rateToLitre
                'price = price * rateToLitre
                lsvBColors.Items(i).SubItems.Add(Math.Round(price * unit.rateToLitre * 1000, 2))
                lsvBColors.Items(i).SubItems.Add(currency)
                lsvBColors.Items(i).SubItems.Add(unitStr)
                lsvBColors.Items(i).SubItems.Add(BColorFiltered(i).masse_volumique)
                lsvBColors.Items(i).SubItems.Add(BColorFiltered(i).masse_volumique_ext)
            Next
            lsvBColors.EndUpdate()
            'autoresize listview
            For Each column As ColumnHeader In lsvBColors.Columns
                If column.Tag <> "cidBColor" Then
                    column.Width = -2
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub butEditBColorForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEditBColorForm.Click
        Dim BColorname As String = txtBColorNameForm.Text
        Dim BColornameAlt As String = txtBColorNameFormAlt.Text
        Dim BColornameAlt2 As String = txtBColorNameFormAlt2.Text

        Dim bcolorImg As String = txtBColorImgPath.Text
        Dim masseVolumique As String = txtMasseVolumique.Text
        Dim masseVolumiqueExt As String = txtMasseVolumiqueExt.Text
        Dim bcolorImgFile As String = txtfnamehideenColor.Text

        Dim colorA As String = pctBColorRGB.BackColor.A
        Dim colorR As String = pctBColorRGB.BackColor.R
        Dim colorG As String = pctBColorRGB.BackColor.G
        Dim colorB As String = pctBColorRGB.BackColor.B

        Dim argb As String = colorA & "," & colorR & "," & colorG & "," & colorB
        If BColorname = "" Then
            MsgBox("BColor must have a name", MsgBoxStyle.Information)
            Exit Sub
        End If

        If lbIdBColorForm.Text < 0 Then
            MsgBox("A BColor must be selected first", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Not IsNumeric(masseVolumique) Or Not IsNumeric(masseVolumiqueExt) Then
            MessageBox.Show("The MasseVolumique must be a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim destFileName As String = My.Application.Info.DirectoryPath & "//images//" & txtfnamehideenColor.Text
        Try 'copy image to folder
            If File.Exists(destFileName) Then 'destination file exists
                'add "2" to newFile name
                ' Dim destFileNameChanged As String
                'Dim i As Integer = 0
                'destFileNameChanged = My.Application.Info.DirectoryPath & "//images//0" & txtfnamehideenColor.Text
                'While File.Exists(destFileNameChanged)
                'destFileNameChanged = My.Application.Info.DirectoryPath & "//images//" & i & txtfnamehideenColor.Text
                'bcolorImgFile = i & txtfnamehideenColor.Text
                'i = i + 1
                'End While

                'File.Copy(bcolorImg, destFileNameChanged, True)
            Else
                File.Copy(bcolorImg, destFileName, True)
            End If

            Dim price As String = txtPriceBcolorForm.Text

            Dim unitsTab() As Unit = getUnits()
            Dim rateToLitre As Decimal = 1
            Dim id_unitLitre As Integer
            Dim id_unit_on_entry As Integer

            For i = 0 To unitsTab.Length - 1
                If unitsTab(i).code_unit.Trim.ToUpper = cmbUnit.Text.Trim.ToUpper Then
                    rateToLitre = unitsTab(i).rateToLitre * 1000
                    id_unit_on_entry = unitsTab(i).id_unit
                End If

                If unitsTab(i).code_unit.Trim = "L" Then
                    id_unitLitre = unitsTab(i).id_unit
                End If
            Next



            If updateColor(bcolorImgFile.Trim, lbIdBColorForm.Text.Trim, BColorname.Trim, price / rateToLitre, txtBColorCodeForm.Text.Trim, chosenCurrency.id_currency, id_unitLitre, id_unit_on_entry, masseVolumique, masseVolumiqueExt, BColornameAlt, BColornameAlt2, argb) Then
                MsgBox("Succes", MsgBoxStyle.Information, "Information")
            End If

        Catch ex As Exception
            MsgBox("could not copy image." & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)

        End Try


        txtBColorNameForm.Text = ""
        txtBColorNameFormAlt.Text = ""
        txtBColorNameFormAlt2.Text = ""
        txtPriceBcolorForm.Text = ""
        txtBColorCodeForm.Text = ""
        txtBColorImgPath.Text = ""
        txtMasseVolumique.Text = ""
        txtMasseVolumiqueExt.Text = ""
        pctBColorImg.Image = Nothing
        pctBColorRGB.BackColor = Nothing

        'lsvBColors.Items.Clear()

    End Sub

    Private Sub lsvBColors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvBColors.MouseClick, lsvBColors.KeyDown, lsvBColors.KeyUp
        If lsvBColors.SelectedItems.Count > 0 Then
            lbIdBColorForm.Text = lsvBColors.SelectedItems(0).SubItems(0).Text
            txtBColorCodeForm.Text = lsvBColors.SelectedItems(0).SubItems(1).Text
            txtBColorNameForm.Text = lsvBColors.SelectedItems(0).SubItems(2).Text
            txtPriceBcolorForm.Text = lsvBColors.SelectedItems(0).SubItems(3).Text
            cmbUnit.Text = lsvBColors.SelectedItems(0).SubItems(5).Text
            txtMasseVolumique.Text = lsvBColors.SelectedItems(0).SubItems(6).Text
            txtMasseVolumiqueExt.Text = lsvBColors.SelectedItems(0).SubItems(7).Text

            Dim bcolor As Color = getColorById(lbIdBColorForm.Text)

            Dim imgPath As String = Nothing
            If Not bcolor.colorImgPath Is Nothing Then
                imgPath = My.Application.Info.DirectoryPath & "//images//" & bcolor.colorImgPath.Trim
                txtBColorImgPath.Text = imgPath
            End If
            pctBColorRGB.BackColor = Nothing
            Dim colorArgb As String = bcolor.argb
            If Not colorArgb Is Nothing Then
                Dim colorAgbTab() As String = colorArgb.Split(",")
                If colorAgbTab.Length = 4 Then
                    Dim colorA As String = colorAgbTab(0)
                    Dim colorR As String = colorAgbTab(1)
                    Dim colorG As String = colorAgbTab(2)
                    Dim colorB As String = colorAgbTab(3)

                    Try
                        pctBColorRGB.BackColor = System.Drawing.Color.FromArgb(colorA, colorR, colorG, colorB)
                    Catch ex As Exception
                        pctBColorRGB.BackColor = Nothing
                    End Try

                End If
            End If




            txtBColorNameFormAlt.Text = bcolor.name_color_alternative
            txtBColorNameFormAlt2.Text = bcolor.name_color_alternative2

            txtfnamehideenColor.Text = bcolor.colorImgPath
            Try
                imageToPreview = Image.FromFile(imgPath)
                'pctCarImg.Image = imageToPreview
                pctBColorImg.ImageLocation = imgPath
            Catch ex As IOException
                'MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
                pctBColorImg.ImageLocation = Nothing
            End Try




        End If
    End Sub

    Private Sub butDeleteBColorForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteBColorForm.Click
        Dim BColorname As String = txtBColorNameForm.Text

        If lbIdBColorForm.Text < 0 Then
            MsgBox("A BColor must be selected first", MsgBoxStyle.Information)
            Exit Sub
        End If

        'test if this basic color exist in a formula
        Dim bColorExistInFormula As Boolean = False
        Dim tempFormulaColor() As FormulaColor = getFormulaColorsByIdColor(lbIdBColorForm.Text)
        If Not tempFormulaColor Is Nothing Then
            bColorExistInFormula = True
        Else
            If tempFormulaColor.Length > 0 Then
                bColorExistInFormula = True
            End If
        End If
        Dim deleteAnyWays As Boolean = True

        If bColorExistInFormula Then
            Dim formulaStr As String = ""


            If tempFormulaColor.Length <= 10 Then
                For i = 0 To tempFormulaColor.Length - 1
                    Dim formulaTemp As Formula = getFormulaById(tempFormulaColor(i).id_formula)
                    Dim str As String = ""
                    If Not formulaTemp Is Nothing Then
                        str = formulaTemp.colorCode
                        formulaStr = formulaStr & str
                        If i < tempFormulaColor.Length Then
                            formulaStr = formulaStr & ", "
                        End If
                    End If
                Next
                If MsgBox("This color exists in the folowing formulas:" & vbNewLine & formulaStr & vbNewLine & "Delete anyways?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                    deleteAnyWays = False
                End If

            Else
                For i = 0 To 9
                    Dim formulaTemp As Formula = getFormulaById(tempFormulaColor(i).id_formula)
                    Dim str As String = ""
                    If Not formulaTemp Is Nothing Then
                        str = formulaTemp.colorCode
                        formulaStr = formulaStr & str
                        If i < tempFormulaColor.Length Then
                            formulaStr = formulaStr & ", "
                        End If
                    End If
                Next
                If MsgBox("This color exists in more then 10 formulas including the following:" & vbNewLine & formulaStr & vbNewLine & "Delete anyways?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                    deleteAnyWays = False
                End If
            End If



        End If

        If deleteAnyWays Then
            Dim bColor As Color = getColorById(lbIdBColorForm.Text)
            If deleteColor(lbIdBColorForm.Text, bColor.colorCode, bColor.name_color) Then
                MsgBox("Succes", MsgBoxStyle.Information, "Information")
                txtBColorNameFormAlt.Text = ""
                txtBColorNameFormAlt2.Text = ""
                txtBColorNameForm.Text = ""
                txtBColorCodeForm.Text = ""
                txtPriceBcolorForm.Text = ""
                txtMasseVolumique.Text = ""
                txtMasseVolumiqueExt.Text = ""
                lsvBColors.Items.Clear()
            End If

        End If

    End Sub

#End Region


    'end Bcolor


    ''update
    Private Sub butUpdateFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butUpdateFile.Click

        If txtUpdatePath.Text = "" Then
            MsgBox("Please choose a directory first", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            Dim updateFilePath As String = txtUpdatePath.Text
            Dim objStreamWriter As StreamWriter
            Dim newF As FileStream = File.Create(updateFilePath & "\\update" & Today.Day & "-" & Today.Month & "-" & Today.Year & ".txt", FileOptions.RandomAccess)
            newF.Close()
            'Pass the file path and the file name to the StreamWriter constructor.
            objStreamWriter = New StreamWriter(updateFilePath & "\\update" & Today.Day & "-" & Today.Month & "-" & Today.Year & ".txt")

            Dim updates() As UpdateTable = getUpdateTable()

            If updates.Length > 0 Then

                Dim i As Integer

                Dim tmp As Integer = -1
                For i = 0 To updates.Length - 1
                    Dim line As String = updates(i).text_lineType

                    Dim j As Integer
                    Dim conc As Integer = 0
                    For j = i + 1 To updates.Length - 1
                        If updates(i).id_action = updates(j).id_action Then
                            line &= updates(j).text_lineType
                            conc += 1
                        End If
                    Next

                    objStreamWriter.WriteLine(line)
                    i = i + conc
                Next



            End If


            'Close the file.
            objStreamWriter.Close()
        Catch ex As IOException
            MsgBox(ex.Message)
        End Try

        Try
            restoreDatabase()

            MsgBox("Update file successfully generated at:" & vbNewLine & txtUpdatePath.Text, MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub butBrowseUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butBrowseUpdate.Click
        If FBrowserUpdate.ShowDialog() = DialogResult.OK Then
            txtUpdatePath.Text = FBrowserUpdate.SelectedPath
        Else
            Exit Sub
        End If
    End Sub


    Private Sub butFindBColorImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFindBColorImg.Click
        If fileDialogBColor.ShowDialog() = DialogResult.OK Then
            Try
                txtBColorImgPath.Text = fileDialogBColor.FileName

                Dim fInfo As FileInfo
                fInfo = New FileInfo(fileDialogBColor.FileName)

                txtfnamehideenColor.Text = fInfo.Name
                Dim imgpath As String = fileDialogBColor.FileName
                imageToPreview = Image.FromFile(imgpath)

                'pctCarImg.Image = imageToPreview
                pctBColorImg.ImageLocation = imgpath
            Catch ex As IOException
                MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
            End Try

        Else
            Exit Sub
        End If
    End Sub


    Private Sub txtColorCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtColorCode.KeyUp, txtFormulaName.KeyUp, txtYearMin.KeyUp, txtYearMax.KeyUp
        If e.KeyCode = Keys.Enter Then
            go()
        End If
    End Sub

    Private Sub cclCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cclCar.Click
        'MsgBox(carname)


        If lsvCars.SelectedItems.Count > 0 Then

            colorCodeLocator.ShowDialog()

        Else
            MsgBox("Select a Car first")
        End If

    End Sub


#Region "Sorting"
    ' The column currently used for sorting.
    Private m_SortingColumn As ColumnHeader

    ' Sort using the clicked column.
    Private Sub lvwBooks_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lsvFamily.ColumnClick, lsvBColors.ColumnClick, lsvCars.ColumnClick, lsvGarage.ColumnClick, lsvLanguage.ColumnClick
        Dim listViewToSort As MyListView = CType(sender, MyListView)
        ' Get the new sorting column.
        Dim new_sorting_column As ColumnHeader = listViewToSort.Columns(e.Column)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text = m_SortingColumn.Text.Replace("< ", "")
            m_SortingColumn.Text = m_SortingColumn.Text.Replace("> ", "")

        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        ' Create a comparer.
        listViewToSort.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        ' Sort.
        listViewToSort.Sort()
    End Sub

#End Region


    Private Sub HeadQHome_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TopMost = False
    End Sub



    Private Sub butAssignX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAssignX.Click
        butCancelX.Enabled = True
        butAssignX.Enabled = False
        butAssignXp.Enabled = False
        butAssignX2p.Enabled = False

        If lsvFamily.SelectedItems.Count > 0 Then
            id_formulaXSeleced = lsvFamily.SelectedItems(0).SubItems(0).Text

            Dim formula As Formula = getFormulaById(id_formulaXSeleced)
            Dim clrName As String = formula.colorCode & " - " & formula.version
            Me.ToolTipVariant.SetToolTip(butAssignX, clrName)
            butAssignX.Text = clrName
        Else
            MsgBox("you must select a formula first")
        End If

    End Sub

    Private Sub butCancelX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelX.Click
        butCancelX.Enabled = False
        butAssignX.Enabled = True
        If butCancelX.AccessibleDescription = "bumper" Then
            butAssignXp.Enabled = False
            butAssignX2p.Enabled = False
        Else
            butAssignXp.Enabled = True
            butAssignX2p.Enabled = True
        End If


        butAssignX.Text = "X"
        butAssignXp.Text = "X'"
        butAssignX2p.Text = "X''"

        id_formulaXSeleced = -1


    End Sub

    Private Sub butAssignY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAssignY.Click
        butCancelY.Enabled = True
        butAssignY.Enabled = False
        butAssignYp.Enabled = False
        butAssignY2p.Enabled = False

        If lsvFamily.SelectedItems.Count > 0 Then
            id_formulaYSeleced = lsvFamily.SelectedItems(0).SubItems(0).Text

            Dim formula As Formula = getFormulaById(id_formulaYSeleced)
            Dim clrName As String = formula.colorCode & " - " & formula.version
            Me.ToolTipVariant.SetToolTip(butAssignY, clrName)
            butAssignY.Text = clrName
        Else
            MsgBox("you must select a formula first")
        End If

    End Sub
    Private Sub butAssignZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAssignZ.Click
        butCancelZ.Enabled = True
        butAssignZ.Enabled = False
        butAssignZp.Enabled = False
        butAssignZ2p.Enabled = False

        If lsvFamily.SelectedItems.Count > 0 Then
            id_formulaZSeleced = lsvFamily.SelectedItems(0).SubItems(0).Text

            Dim formula As Formula = getFormulaById(id_formulaZSeleced)
            Dim clrName As String = formula.colorCode & " - " & formula.version
            Me.ToolTipVariant.SetToolTip(butAssignZ, clrName)
            butAssignZ.Text = clrName
        Else
            MsgBox("you must select a formula first")
        End If

    End Sub
    Private Sub butCancelZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelZ.Click
        butCancelZ.Enabled = False
        butAssignZ.Enabled = True
        butAssignZp.Enabled = True
        butAssignZ2p.Enabled = True

        butAssignZ.Text = "Z"
        butAssignZp.Text = "Z'"
        butAssignZ2p.Text = "Z''"

        id_formulaZSeleced = -1
    End Sub
    Private Sub butCancelY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelY.Click
        butCancelY.Enabled = False
        butAssignY.Enabled = True
        butAssignYp.Enabled = True
        butAssignY2p.Enabled = True

        butAssignY.Text = "Y"
        butAssignYp.Text = "Y'"
        butAssignY2p.Text = "Y''"

        id_formulaYSeleced = -1
    End Sub

    Private Sub butSaveAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSaveAssign.Click
        Dim xAssigned As Boolean = False
        Dim yAssigned As Boolean = False

        If id_formulaXSeleced <> -1 And id_formulaXSeleced <> 0 Then
            xAssigned = True
        Else
            If id_formulaXPSeleced <> -1 And id_formulaXPSeleced <> 0 And id_formulaX2PSeleced <> -1 And id_formulaX2PSeleced <> 0 Then
                xAssigned = True
            End If
        End If

        If id_formulaYSeleced <> -1 And id_formulaYSeleced <> 0 Then
            yAssigned = True
        Else
            If id_formulaYPSeleced <> -1 And id_formulaYPSeleced <> 0 And id_formulaY2PSeleced <> -1 And id_formulaY2PSeleced <> 0 Then
                yAssigned = True
            End If
        End If

        If (Not xAssigned Or Not yAssigned) And Not butSaveAssign.AccessibleDescription = "bumper" Then
            MsgBox("you cant save until at least color X and Y are assigned")
            Exit Sub
        End If

        If id_formulaZSeleced = -1 Or id_formulaZSeleced = 0 Then
            id_formulaZSeleced = -2
        End If
        If id_formulaZPSeleced = -1 Or id_formulaZPSeleced = 0 Then
            id_formulaZPSeleced = -2
        End If
        If id_formulaZ2PSeleced = -1 Or id_formulaZ2PSeleced = 0 Then
            id_formulaZ2PSeleced = -2
        End If

        If assignFormulaXYZ(id_formulaXYZSeleced, id_formulaXSeleced, id_formulaYSeleced, id_formulaZSeleced, id_formulaXPSeleced, id_formulaX2PSeleced, id_formulaYPSeleced, id_formulaY2PSeleced, id_formulaZPSeleced, id_formulaZ2PSeleced) Then
            MsgBox("The composed Formula has successfully been referenced")
        End If
        id_formulaXSeleced = -1
        id_formulaXPSeleced = -1
        id_formulaX2PSeleced = -1

        id_formulaYSeleced = -1
        id_formulaYPSeleced = -1
        id_formulaY2PSeleced = -1

        id_formulaZSeleced = -1
        id_formulaZPSeleced = -1
        id_formulaZ2PSeleced = -1

        id_formulaXYZSeleced = -1
        grpXY.Visible = False
    End Sub


    Private Sub butCancelAss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelAss.Click
        If MsgBox("Cancel formula assignement?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            id_formulaXSeleced = -1
            id_formulaXPSeleced = -1
            id_formulaX2PSeleced = -1

            id_formulaYSeleced = -1
            id_formulaYPSeleced = -1
            id_formulaY2PSeleced = -1

            id_formulaZSeleced = -1
            id_formulaZPSeleced = -1
            id_formulaZ2PSeleced = -1

            id_formulaXYZSeleced = -1

            butAssignX.Text = "X"
            butAssignXp.Text = "X'"
            butAssignX2p.Text = "X''"

            butAssignY.Text = "Y"
            butAssignYp.Text = "Y'"
            butAssignY2p.Text = "Y''"

            butAssignZ.Text = "Z"
            butAssignZp.Text = "Z'"
            butAssignZ2p.Text = "Z''"

            grpXY.Visible = False
        End If

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim colorTab() As Color = getColors()
        Dim i As Integer = 0
        For i = 0 To colorTab.Length - 1
            Dim rate As Decimal = getUnit(colorTab(i).id_unit_on_entry).rateToLitre
            Dim price As Decimal = colorTab(i).defaultPrice
            price = price / rate
            price = price / (rate * 1000)
            If Not updateColor(colorTab(i).colorImgPath, colorTab(i).id_color, colorTab(i).name_color, price, colorTab(i).colorCode, colorTab(i).id_defaultCurreny, colorTab(i).id_defaultUnit, colorTab(i).id_unit_on_entry, colorTab(i).masse_volumique, colorTab(i).masse_volumique_ext, colorTab(i).name_color_alternative, colorTab(i).name_color_alternative2, pctBColorImg.BackColor.ToArgb) Then
                MsgBox(colorTab(i).id_color & " - - " & colorTab(i).name_color)
            End If


        Next

    End Sub


    Private Sub butDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDelete.Click
        Dim successDelete As Boolean = True
        If lsvFamily.SelectedItems.Count > 0 Then
            If MsgBox("Are you sure you want to delete these colors?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For i = 0 To lsvFamily.SelectedItems.Count - 1
                    Dim idFormulaDel As Integer = lsvFamily.SelectedItems(i).SubItems(0).Text
                    ''''check if linked to composed formula
                    Dim linkedMultiC As String() = getLinkedMulticolor(idFormulaDel)

                    If Not linkedMultiC Is Nothing Then
                        If linkedMultiC.Length > 0 Then
                            Dim str As String = "Attention!" & vbNewLine & "Formula '" & lsvFamily.SelectedItems(i).SubItems(5).Text & "' linked in the following multicolored formulas:" & vbNewLine
                            For j = 0 To linkedMultiC.Length - 1
                                str &= linkedMultiC(j) & vbNewLine
                            Next
                            str &= "Continue?"
                            If MsgBox(str, MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                ' Exit Sub
                                Continue For
                            End If
                        End If
                    End If

                    '''''''''''''''''''''''''''''''''''
                    Dim colorCode As String = lsvFamily.SelectedItems(i).SubItems(3).Text
                    Dim nameFormula As String = lsvFamily.SelectedItems(i).SubItems(4).Text
                    Dim type As String = lsvFamily.SelectedItems(i).SubItems(1).Text
                    Dim version As String = lsvFamily.SelectedItems(i).SubItems(6).Text
                    Dim theCar As Car = getCars(" where carname = '" & lsvFamily.SelectedItems(i).SubItems(2).Text & "' ")(0)
                    Dim id_car As String = theCar.id_car
                    Dim name_car As String = theCar.carName
                    If Not deleteFormula(idFormulaDel, colorCode, nameFormula, type, id_car, name_car, version) Then
                        MsgBox("The formula was not deleted", MsgBoxStyle.Exclamation)
                        successDelete = False
                    End If
                Next
                If successDelete Then
                    For i = 0 To lsvFamily.SelectedItems.Count - 1
                        lsvFamily.SelectedItems(0).Remove()
                    Next
                End If

            End If
        Else
            MsgBox("A color must be selected first", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub butClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClear.Click
        insertIntoUpdateTable("", "")

        cmbCarNameSearch.SelectedIndex = 0
        txtColorCode.Text = ""
        chkColorCode.Checked = True
        txtFormulaName.Text = ""
        chkFormulaName.Checked = True
        txtCardNumber.Text = ""
        chkCardNumber.Checked = True
        txtYearSpec.Text = ""
        'rdBC.Checked = True
        txtColorCode.Focus()
    End Sub

    Private Sub butClearCars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClearCars.Click
        txtCarNameForm.Text = ""
        chkCarFormName.Checked = True
        txtCarImgPath.Text = ""
        txtfnamehideen.Text = ""
        pctCarImg.Image = Nothing
    End Sub


    Private Sub butClearLang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClearLang.Click
        txtLanguageCodeForm.Text = ""
        chkLanguageFormCode.Checked = True
        txtLanguageLabelForm.Text = ""
        chkLanguageLabelForm.Checked = True
    End Sub

    Private Sub butClearGarage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClearGarage.Click
        txtGarageNameForm.Text = ""
        chkGarageFormCode.Checked = True
        txtGarageLocationForm.Text = ""
        chkGarageLocationForm.Checked = True
        txtGarageRespform.Text = ""
        chkGarageRespForm.Checked = True
        rdApply0.Checked = True
        lbIdLanguage.Text = "-1"
        txtLanguage.Text = ""
        txtGarageImgPath.Text = ""
        pctGarageImg.Image = Nothing
        txtfnamegaragehidden.Text = ""
        txtGarageDirectory.Text = ""
        txttel.Text = ""
        txtkey.Text = ""
        txtusername.Text = ""
    End Sub

    Private Sub butClearBColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClearBColor.Click
        txtBColorCodeForm.Text = ""
        chkBColorFormCode.Checked = True
        txtBColorNameForm.Text = ""
        chkBColorFormName.Checked = True
        lbIdBColorForm.Text = "-1"
        txtPriceBcolorForm.Text = ""
        cmbUnit.SelectedIndex = 0
        txtMasseVolumique.Text = ""
        txtMasseVolumiqueExt.Text = ""
        txtBColorImgPath.Text = ""
        pctBColorImg.Image = Nothing
        pctBColorImg.BackColor = Nothing
        txtfnamehideenColor.Text = ""

    End Sub

    Private Sub butClearUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClearUpdate.Click
        txtUpdatePath.Text = ""
    End Sub


    Private Sub butAssignXp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAssignXp.Click, butAssignX2p.Click
        butAssignX.Enabled = False
        If sender.name = "butAssignXp" Then
            butAssignXp.Enabled = False
        Else
            butAssignX2p.Enabled = False
        End If
        butCancelX.Enabled = True

        If lsvFamily.SelectedItems.Count > 0 Then
            If sender.name = "butAssignXp" Then
                id_formulaXPSeleced = lsvFamily.SelectedItems(0).SubItems(0).Text

                Dim formula As Formula = getFormulaById(id_formulaXPSeleced)
                Dim clrName As String = formula.colorCode & " - " & formula.version
                Me.ToolTipVariant.SetToolTip(butAssignXp, clrName)
                butAssignXp.Text = clrName
            Else
                id_formulaX2PSeleced = lsvFamily.SelectedItems(0).SubItems(0).Text

                Dim formula As Formula = getFormulaById(id_formulaX2PSeleced)
                Dim clrName As String = formula.colorCode & " - " & formula.version
                Me.ToolTipVariant.SetToolTip(butAssignX2p, clrName)
                butAssignX2p.Text = clrName
            End If
        Else
            MsgBox("you must select a formula first")
        End If

    End Sub
    Private Sub butAssignYp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAssignYp.Click, butAssignY2p.Click
        butAssignY.Enabled = False
        If sender.name = "butAssignYp" Then
            butAssignYp.Enabled = False
        Else
            butAssignY2p.Enabled = False
        End If
        butCancelY.Enabled = True

        If lsvFamily.SelectedItems.Count > 0 Then
            If sender.name = "butAssignYp" Then
                id_formulaYPSeleced = lsvFamily.SelectedItems(0).SubItems(0).Text

                Dim formula As Formula = getFormulaById(id_formulaYPSeleced)
                Dim clrName As String = formula.colorCode & " - " & formula.version
                Me.ToolTipVariant.SetToolTip(butAssignYp, clrName)
                butAssignYp.Text = clrName
            Else
                id_formulaY2PSeleced = lsvFamily.SelectedItems(0).SubItems(0).Text

                Dim formula As Formula = getFormulaById(id_formulaY2PSeleced)
                Dim clrName As String = formula.colorCode & " - " & formula.version
                Me.ToolTipVariant.SetToolTip(butAssignY2p, clrName)
                butAssignY2p.Text = clrName
            End If
        Else
            MsgBox("you must select a formula first")
        End If

    End Sub
    Private Sub butAssignZp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAssignZp.Click, butAssignZ2p.Click
        butAssignZ.Enabled = False
        If sender.name = "butAssignZp" Then
            butAssignZp.Enabled = False
        Else
            butAssignZ2p.Enabled = False
        End If
        butCancelZ.Enabled = True

        If lsvFamily.SelectedItems.Count > 0 Then
            If sender.name = "butAssignZp" Then
                id_formulaZPSeleced = lsvFamily.SelectedItems(0).SubItems(0).Text

                Dim formula As Formula = getFormulaById(id_formulaZPSeleced)
                Dim clrName As String = formula.colorCode & " - " & formula.version
                Me.ToolTipVariant.SetToolTip(butAssignZp, clrName)
                butAssignZp.Text = clrName
            Else
                id_formulaZ2PSeleced = lsvFamily.SelectedItems(0).SubItems(0).Text

                Dim formula As Formula = getFormulaById(id_formulaZ2PSeleced)
                Dim clrName As String = formula.colorCode & " - " & formula.version
                Me.ToolTipVariant.SetToolTip(butAssignZ2p, clrName)
                butAssignZ2p.Text = clrName
            End If
        Else
            MsgBox("you must select a formula first")
        End If

    End Sub


    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExcel.Click
        Dim fileExcelPath As String = Nothing
        If fldExcelDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try

                fileExcelPath = fldExcelDialog.SelectedPath.Trim
                If Not fileExcelPath Is Nothing And Not fileExcelPath = "" Then

                    Dim txttmp As String = fileExcelPath & "\temp" & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & Now.Second & Now.Millisecond & ".xls"

                    Dim xlApp As New Microsoft.Office.Interop.Excel.Application
                    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add()
                    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = CType(xlWorkBook.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                    Dim xlstyle As Microsoft.Office.Interop.Excel.Style
                    xlstyle = xlWorkBook.Styles.Add("Style1")


                    'xlsSheet = xlsWB.ActiveSheet()
                    Dim rng As Microsoft.Office.Interop.Excel.Range

                    rng = xlWorkSheet.Application.Range("A1", "H1")
                    'rng.Font.Bold = True

                    xlstyle.Font.Italic = True
                    xlstyle.Font.Bold = True


                    rng.Style = xlstyle

                    prgBar.Visible = True
                    prgBar.Step = 1

                    prgBar.Maximum = 1
                    If Not lsvFamily Is Nothing Then
                        If lsvFamily.Items.Count > 0 Then
                            prgBar.Maximum = lsvFamily.Items.Count
                        End If
                    End If
                    prgBar.Value = 0
                    Dim firstInstance As Boolean = True
                    Dim i As Integer = 0
                    ' xlWorkBook.Styles.Add("StyleColor")
                    For Each lvi In lsvFamily.Items

                        If firstInstance Then 'les titre
                            Dim colx As Integer = 0
                            For Each column As ColumnHeader In lsvFamily.Columns
                                If column.Index > 0 Then
                                    colx += 1
                                    xlWorkSheet.Cells(1, colx) = column.Text
                                End If
                            Next
                        End If
                        firstInstance = False

                        For ix As Integer = 1 To lvi.SubItems.Count - 1
                            Dim xlstyleColor As Microsoft.Office.Interop.Excel.Style
                            xlstyleColor = Nothing

                            If i = 0 And ix = 1 Then
                                xlstyleColor = xlWorkBook.Styles.Add("StyleColor" & i & ix)
                                If ix > 7 And ix < lvi.SubItems.Count - 1 And Not lsvFamily.Items(i).SubItems(ix).BackColor = Drawing.Color.White Then
                                    xlstyleColor.Interior.Color = System.Drawing.ColorTranslator.ToOle(lsvFamily.Items(i).SubItems(ix).BackColor)
                                End If
                                xlstyleColor.NumberFormat = "@"

                                Dim MyArray As New ArrayList
                                MyArray.Add(xlstyleColor)

                                tabXlstyleColor = DirectCast(MyArray.ToArray(GetType(Microsoft.Office.Interop.Excel.Style)), Microsoft.Office.Interop.Excel.Style())
                            Else
                                xlstyleColor = getXlstyleColor(lvi, i, ix, xlWorkBook, System.Drawing.ColorTranslator.ToOle(lsvFamily.Items(i).SubItems(ix).BackColor))
                            End If

                            ' xlWorkSheet.Cells(i + 2, ix).Style = "StyleColor" & i & ix
                            xlWorkSheet.Cells(i + 2, ix).Style = xlstyleColor.Name

                            xlWorkSheet.Cells(i + 2, ix) = lvi.SubItems(ix).Text

                            'If ix < lvi.SubItems.Count - 1 Then
                            'sb.Append(vbTab)
                            'Else
                            'sb.Append(vbCrLf)
                            'End If
                        Next
                        i += 1
                        prgBar.PerformStep()

                    Next
                    prgBar.Value = prgBar.Maximum



                    ' Dim dlg As New SaveFileDialog
                    'dlg.Filter = "Excel Files (*.xlsx)|*.xlsx"
                    'dlg.FilterIndex = 1
                    'dlg.InitialDirectory = My.Application.Info.DirectoryPath & "\EXCEL\\EICHER\BILLS\"
                    'dlg.FileName = "Bill No- "
                    Dim ExcelFile As String = ""
                    'If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ExcelFile = txttmp
                    xlWorkSheet.SaveAs(ExcelFile)
                    'End If
                    xlWorkBook.Close()

                    xlApp.Quit()

                    xlApp.Visible = True
                    xlWorkBook = xlApp.Workbooks.Open(txttmp)
                    xlWorkSheet = xlWorkBook.Worksheets(1)

                End If
            Catch ex As IOException
                prgBar.Visible = False
                MsgBox(ex.Message & vbNewLine & ex.StackTrace)
            End Try
        End If
        prgBar.Visible = False
    End Sub


    Private Sub butReportAll_Click(sender As Object, e As EventArgs) Handles butReportAll.Click
        Dim fileExcelPath As String = Nothing
        If fldExcelDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim allBasicColors() As Color = getColors("")
                If allBasicColors Is Nothing Then
                    Exit Sub
                End If
                fileExcelPath = fldExcelDialog.SelectedPath.Trim
                If Not fileExcelPath Is Nothing And Not fileExcelPath = "" Then

                    Dim txttmp As String = fileExcelPath & "\Report" & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & Now.Second & Now.Millisecond & ".xls"

                    Dim xlApp As New Microsoft.Office.Interop.Excel.Application
                    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add()
                    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = CType(xlWorkBook.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                    Dim xlstyle As Microsoft.Office.Interop.Excel.Style
                    xlstyle = xlWorkBook.Styles.Add("Style1")


                    'xlsSheet = xlsWB.ActiveSheet()
                    Dim rng As Microsoft.Office.Interop.Excel.Range

                    rng = xlWorkSheet.Application.Range("A1", "C1")
                    'rng.Font.Bold = True

                    xlstyle.Font.Italic = True
                    xlstyle.Font.Bold = True


                    rng.Style = xlstyle

                    prgBar.Visible = True
                    prgBar.Step = 1

                    prgBar.Maximum = 1
                    If Not allBasicColors Is Nothing Then
                        If allBasicColors.Length > 0 Then
                            prgBar.Maximum = allBasicColors.Length
                        End If
                    End If
                    prgBar.Value = 0
                    Dim i As Integer = 1
                    xlWorkSheet.Cells(1, 1) = "Basic Color Code"
                    xlWorkSheet.Cells(1, 2) = "Formula Count"
                    xlWorkSheet.Cells(1, 3) = "Total Liter"
                    For Each bColor In allBasicColors

                        xlWorkSheet.Cells(i + 1, 1) = bColor.colorCode
                        xlWorkSheet.Cells(i + 1, 2) = getNumberOfFormulas(bColor.id_color)
                        xlWorkSheet.Cells(i + 1, 3) = getColorTotalQty(bColor.id_color)


                        i += 1
                        prgBar.PerformStep()

                    Next
                    prgBar.Value = prgBar.Maximum



                    ' Dim dlg As New SaveFileDialog
                    'dlg.Filter = "Excel Files (*.xlsx)|*.xlsx"
                    'dlg.FilterIndex = 1
                    'dlg.InitialDirectory = My.Application.Info.DirectoryPath & "\EXCEL\\EICHER\BILLS\"
                    'dlg.FileName = "Bill No- "
                    Dim ExcelFile As String = ""
                    'If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ExcelFile = txttmp
                    xlWorkSheet.SaveAs(ExcelFile)
                    'End If
                    xlWorkBook.Close()

                    xlApp.Quit()

                    xlApp.Visible = True
                    xlWorkBook = xlApp.Workbooks.Open(txttmp)
                    xlWorkSheet = xlWorkBook.Worksheets(1)

                End If
            Catch ex As IOException
                prgBar.Visible = False
                MsgBox(ex.Message & vbNewLine & ex.StackTrace)
            End Try
        End If
        prgBar.Visible = False
    End Sub


    Private Sub pctBColorRGB_Click(sender As Object, e As EventArgs) Handles pctBColorRGB.Click
        If dlgBasicColorDialog.ShowDialog() = DialogResult.OK Then
            pctBColorRGB.BackColor = dlgBasicColorDialog.Color
        End If
    End Sub


    Private Sub MobileSyncToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobileSyncToolStripMenuItem.Click
        mobileSync.ShowDialog()
    End Sub
    Public Function UploadFTPFiles(ftpAddress As String, ftpUser As String, ftpPassword As String,
                               fileToUpload As String, targetFileName As String,
                               deleteAfterUpload As Boolean,
                               ExceptionInfo As Exception) As Boolean
        If Not isInternetAccessEnabled() Then
            Return Nothing
        End If
        Dim credential As NetworkCredential

        Try
            credential = New NetworkCredential(ftpUser, ftpPassword)

            If ftpAddress.EndsWith("/") = False Then ftpAddress = ftpAddress & "/"

            Dim sFtpFile As String = ftpAddress & fileToUpload

            Dim request As FtpWebRequest = DirectCast(WebRequest.Create(sFtpFile), FtpWebRequest)

            request.KeepAlive = False
            request.Method = WebRequestMethods.Ftp.UploadFile
            request.Credentials = credential
            request.UsePassive = False
            request.Timeout = (60 * 1000) * 3 '3 mins

            Using reader As New FileStream(fileToUpload, FileMode.Open)

                Dim buffer(Convert.ToInt32(reader.Length - 1)) As Byte
                reader.Read(buffer, 0, buffer.Length)
                reader.Close()

                request.ContentLength = buffer.Length
                Dim stream As Stream = request.GetRequestStream
                stream.Write(buffer, 0, buffer.Length)
                stream.Close()

                Using response As FtpWebResponse = DirectCast(request.GetResponse, FtpWebResponse)

                    If deleteAfterUpload Then
                        My.Computer.FileSystem.DeleteFile(fileToUpload)
                    End If

                    response.Close()
                End Using

            End Using

            Return True

        Catch ex As Exception
            ExceptionInfo = ex
            Dim webex As WebException = CType(ex, WebException)
            Dim ftpRes As FtpWebResponse = CType(webex.Response, FtpWebResponse)
            Dim status As String = ftpRes.StatusDescription
            ' String status = ((FtpWebResponse)e.Response).StatusDescription;
            Return False
        Finally

        End Try

    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim ExceptionInfo As Exception = Nothing
        ' Dim ftpAddress As String = "FTP://ftp.amazonapaints.com/home/amazona001/"
        Dim ftpUser As String = "amazona001_mk@amazonapaints.com"
        Dim ftpPassword As String = "k<Yd*C$.2"
        'Dim targetFileName As String = "thedbSync.txt"
        Dim fileToUpload As String = "C:\Users\User\Desktop\testsync\dbSync.txt"
        ' Dim deleteAfterUpload As Boolean = False
        Dim ftpuri As String = "FTP://ftp.amazonapaints.com/"

        'FtpUploadFile(fileToUpload, ftpuri, ftpUser, ftpPassword)

        'deleteFileFtp("test.txt")
        'downloadFileFTP("dbSync.txt")
        'Dim listOfFiles As List(Of String) = listFiles(ftpuri, ftpUser, ftpPassword, ExceptionInfo)
        'Dim listAsString As String = listOfFiles.ToString
        'MsgBox(listAsString)
    End Sub
   
    Public Function listFiles(ftpAddress As String, _
                ftpUser As String, _
                    ftpPassword As String, _
                    ByRef ExceptionInfo As Exception) As List(Of String)
        If Not isInternetAccessEnabled() Then
            Return Nothing
        End If
        Dim ListOfFilesOnFTPSite As New List(Of String)

        Dim ftpRequest As FtpWebRequest = Nothing
        Dim ftpResponse As FtpWebResponse = Nothing

        Dim strReader As StreamReader = Nothing
        Dim sline As String = ""

        Try
            ftpRequest = CType(WebRequest.Create(ftpAddress), FtpWebRequest)

            With ftpRequest
                .Credentials = New NetworkCredential(ftpUser, ftpPassword)
                .Method = WebRequestMethods.Ftp.ListDirectory
            End With

            ftpResponse = CType(ftpRequest.GetResponse, FtpWebResponse)

            strReader = New StreamReader(ftpResponse.GetResponseStream)

            If strReader IsNot Nothing Then sline = strReader.ReadLine

            While sline IsNot Nothing
                ListOfFilesOnFTPSite.Add(sline)
                sline = strReader.ReadLine
            End While

        Catch ex As Exception
            ExceptionInfo = ex

        Finally
            If ftpResponse IsNot Nothing Then
                ftpResponse.Close()
                ftpResponse = Nothing
            End If

            If strReader IsNot Nothing Then
                strReader.Close()
                strReader = Nothing
            End If
        End Try

        listFiles = ListOfFilesOnFTPSite

        ListOfFilesOnFTPSite = Nothing
    End Function

   
    Private Sub butNegativeQty_Click(sender As Object, e As EventArgs) Handles butNegativeQty.Click
        If MsgBox("The search for all negative quantity formulas might take up to 5 minutes, continue anyway?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            rdAny.Select()
            getNegativeQtys()
        End If

    End Sub


End Class