Imports System.IO

Public Class formulasEditSync

    Public actionType As String = ""
    Private Sub colorEditSync_Load(sender As Object, e As EventArgs) Handles Me.Load

        lbCountFormulas.Text = ""

        'setChkBackColor()
        loadCars()
        txtColorCode.Focus()

        loadColors()
    End Sub
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
    Public Sub loadColors()

        listSelectedFormulas()

    End Sub


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
    Public Sub addResultsToListviewFamily(ByVal formulaTab() As Formula, ByVal resetcurFamilyInEditSync As Boolean, Optional ByVal typeFilter As String = "")
        Try
            Dim i As Integer = 0
            '------------------------
            If resetcurFamilyInEditSync Then
                curFamilyInEditSync = formulaTab
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

            lsvFormula.Items.Clear()
            lsvFormula.BeginUpdate()
            lsvFormula.Sorting = SortOrder.None
            lsvFormula.ListViewItemSorter = Nothing
            For Each column As ColumnHeader In lsvFormula.Columns
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
                lsvFormula.Items.Add(formulaTab(i).id_formula)
                lsvFormula.Items(i).SubItems.Add(formulaTab(i).type)
                lsvFormula.Items(i).SubItems.Add(formulaTab(i).name_car)
                lsvFormula.Items(i).SubItems.Add(formulaTab(i).colorCode)
                lsvFormula.Items(i).SubItems.Add(formulaTab(i).name_formula)
                lsvFormula.Items(i).SubItems.Add(formulaTab(i).c_year)
                lsvFormula.Items(i).SubItems.Add(formulaTab(i).version)
                lsvFormula.Items(i).SubItems.Add(formulaTab(i).cardNumber)
                lsvFormula.Items(i).UseItemStyleForSubItems = False
                Dim formulaVariant As String = formulaTab(i).variant

                If Not formulaVariant Is Nothing Then
                    If formulaVariant.Trim <> "" Then
                        'lsvFamily.Items(i).SubItems.Add(formulaVariant)
                        Dim formulaVariants() As String = formulaVariant.Split("+")
                        Dim j As Integer

                        For j = 0 To formulaVariants.Length - 1
                            If 9 + j > lsvFormula.Columns.Count Then
                                lsvFormula.Columns.Add("", 25, Windows.Forms.HorizontalAlignment.Left)

                            End If

                            lsvFormula.Items(i).SubItems.Add("")
                            Dim varianttemp As FormulaVariants = getVariant(formulaVariants(j))
                            If Not varianttemp Is Nothing Then
                                lsvFormula.Items(i).SubItems(8 + j).BackColor = varianttemp.variantColor
                            End If
                        Next
                        If 9 + j > lsvFormula.Columns.Count Then
                            lsvFormula.Columns.Add("", 25, Windows.Forms.HorizontalAlignment.Left)
                        End If

                    End If
                End If
            Next
            'set the variant
            Dim lastColumnIndex = 0
            For Each column As ColumnHeader In lsvFormula.Columns
                lastColumnIndex += 1
            Next
            lsvFormula.Columns(lastColumnIndex - 1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)

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
                                lsvFormula.Items(i).SubItems(lastColumnIndex - 1).Text = str
                                success = True
                            Catch ex As Exception
                                lsvFormula.Items(i).SubItems.Add("")
                                success = False
                            End Try
                        End While
                    End If
                End If

            Next
            lastColumnIndex = 0
            For Each column As ColumnHeader In lsvFormula.Columns
                lastColumnIndex += 1
            Next
            lsvFormula.Columns(lastColumnIndex - 1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)


            'autoresize listview
            'lsvFamily.Columns.Add("")
            For Each column As ColumnHeader In lsvFormula.Columns
                If column.Tag = "cctype" Or column.Tag = "ccarname" Or column.Tag = "ccode" Or column.Tag = "ccname" Or column.Tag = "cyear" Or column.Tag = "cversion" Or column.Tag = "ccardNbr" Then
                    column.Width = -2
                End If
            Next
            '------------------
            lsvFormula.EndUpdate()

            prgBar.Value = prgBar.Maximum
            prgBar.Visible = False
        Catch ex As Exception
            prgBar.Visible = False
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
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
        lsvFormula.BackColor  = Drawing.Color.White

        'lsvFamily.Items.Clear()
        'curFamilyInEditSync = Nothing
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
    '     curFamilyInEditSync = Nothing
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
        If Not curFamilyInEditSync Is Nothing Then
            If curFamilyInEditSync.Length > 0 Then
                Dim MyArray As New ArrayList
                Dim i As Integer
                For i = 0 To curFamilyInEditSync.Length - 1
                    If curFamilyInEditSync(i).type.ToLower.Trim = type.ToLower.Trim Or type.Trim = "" Then
                        curFamilyInEditSync(i).isMoved = False
                        MyArray.Add(curFamilyInEditSync(i))
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



    Private Sub lsvFamily_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvFormula.MouseClick, lsvFormula.KeyDown, lsvFormula.KeyUp
        If lsvFormula.SelectedItems.Count > 0 Then
            Console.WriteLine("before getting chosen formula:" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss fff"))
            Dim chosenFormula As Formula = getFormulaById(lsvFormula.SelectedItems(0).SubItems(0).Text)
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




    Private Sub ButGoBack_Click(sender As Object, e As EventArgs) Handles ButGoBack.Click
        Me.Close()
    End Sub

    Private Sub butSelectAll_Click(sender As Object, e As EventArgs) Handles butSelectAll.Click
        Dim item As ListViewItem
        For Each item In lsvFormula.Items
            item.Selected = True
        Next
    End Sub

    Private Sub butAddToSync_Click(sender As Object, e As EventArgs) Handles butAddToSync.Click

        Dim item As ListViewItem
        For Each item In lsvFormula.SelectedItems
            Dim idFormula As Integer = item.SubItems(0).Text

            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncFormulasToEdit.ContainsKey(idFormula)

            If newEntry Then
                Dim theFormula As Formula = mobileSync.allFormulasHash.Item(idFormula)
                'setting missing json fields

                Dim formulaColor As FormulaColor() = getFormulaColorsByIdFormula(idFormula, theFormula.type, True)
                'formulaColor = DirectCast(mobileSync.allFormulaColorsHash.Item(idFormula).ToArray(GetType(FormulaColor)), FormulaColor())

                'theFormula.formulaColor = formulaColor

                theFormula.tableName = (mobileSync.allCarsHash.Item(theFormula.id_car)).tableName

                theFormula.code_formulaX = getCodeFormulaX(theFormula.id_formulaX, mobileSync.allFormulasHash)
                theFormula.code_formulaXp = getCodeFormulaXp(theFormula.id_formulaXp, mobileSync.allFormulasHash)
                theFormula.code_formulaXpp = getCodeFormulaXpp(theFormula.id_formulaX2p, mobileSync.allFormulasHash)

                theFormula.code_formulaY = getCodeFormulaY(theFormula.id_formulaY, mobileSync.allFormulasHash)
                theFormula.code_formulaYp = getCodeFormulaYp(theFormula.id_formulaYp, mobileSync.allFormulasHash)
                theFormula.code_formulaYpp = getCodeFormulaYpp(theFormula.id_formulaY2p, mobileSync.allFormulasHash)

                theFormula.code_formulaZ = getCodeFormulaZ(theFormula.id_formulaZ, mobileSync.allFormulasHash)
                theFormula.code_formulaZp = getCodeFormulaZp(theFormula.id_formulaZp, mobileSync.allFormulasHash)
                theFormula.code_formulaZpp = getCodeFormulaZpp(theFormula.id_formulaZ2p, mobileSync.allFormulasHash)


                theFormula.actionType = "edit"
                syncFormulasToEdit.Add(idFormula, theFormula)
            End If

        Next
        MsgBox(lsvFormula.SelectedItems.Count & " items added to sync. The total selections will be listed.", MsgBoxStyle.Information)
        listSelectedFormulas()
        mobileSync.updateFormulasResultLabel(mobileSync.lbFormulasSyncResult)
    End Sub


    Private Sub butRemoveFromSync_Click(sender As Object, e As EventArgs) Handles butRemoveFromSync.Click
        Dim item As ListViewItem
        For Each item In lsvFormula.SelectedItems
            Dim idFormula As Integer = item.SubItems(0).Text
            syncFormulasToEdit.Remove(idFormula)
        Next
        MsgBox(lsvFormula.SelectedItems.Count & " items removed from sync. The remaining selections will be listed.", MsgBoxStyle.Information)
        listSelectedFormulas()
        mobileSync.updateFormulasResultLabel(mobileSync.lbFormulasSyncResult)
    End Sub

    Private Sub butListSelected_Click(sender As Object, e As EventArgs) Handles butListSelected.Click
        listSelectedFormulas()
    End Sub

    Private Sub listSelectedFormulas()
        lsvFormula.BackColor = System.Drawing.Color.FromArgb(192, 255, 192)
        If syncFormulasToEdit.Count > 0 Then
            Dim formulasSelected As Formula()
            Dim MyArray As New ArrayList(syncFormulasToEdit.Values)
            formulasSelected = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())

            Dim colorCode As String = txtColorCode.Text
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
                formulasSelected = sortByYear(formulasSelected)
                'order by MET and MAT
                formulasSelected = placeMetAndMat(formulasSelected)
            End If

            addResultsToListviewFamily(formulasSelected, True, filter)
        Else
            lsvFormula.Items.Clear()
        End If

    End Sub



#Region "Sorting"
    ' The column currently used for sorting.
    Private m_SortingColumn As ColumnHeader

    ' Sort using the clicked column.
    Private Sub lvwBooks_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lsvFormula.ColumnClick
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


    Private Sub butClearFormula_Click(sender As Object, e As EventArgs) Handles butClearFormula.Click
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
End Class