Imports System.IO

Public Class formulasDeleteSync

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
    Public Sub addResultsToListviewFamily(ByVal formulaTab() As Formula, ByVal resetcurFamilyInDeleteSync As Boolean, Optional ByVal typeFilter As String = "")
        Try
            Dim i As Integer = 0
            '------------------------
            If resetcurFamilyInDeleteSync Then
                curFamilyInDeleteSync = formulaTab
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
                lsvFormula.Items(i).SubItems.Add(formulaTab(i).version)

            Next


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
 
        Dim formulaNameChk As Boolean = chkFormulaName.Checked
        Dim formulaName As String = txtFormulaName.Text

        Dim carName As String = getCarById(lbCarIdSearch.Text).carName
        If carName Is Nothing Then
            carName = ""
        End If
        Dim colorCodeChk As Boolean = chkColorCode.Checked
        Dim colorCode As String = txtColorCode.Text


        Dim str1 As String = ""
        If formulaName.Trim <> "" Then
            If formulaNameChk Then
                str1 = str1 & " name_color like '%" & formulaName & "%'"
            Else
                str1 = str1 & " name_color = '" & formulaName & "'"
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

       

        If whereStr <> "" Then
            whereStr = " AND " & whereStr
        End If

        Dim formulasFiltered() As Formula = getDeletedFormulasBySyncVersion(currentLastSyncVersion, whereStr)

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
            'order by MET and MAT
            formulasFiltered = placeMetAndMat(formulasFiltered)
        End If

        addResultsToListviewFamily(formulasFiltered, True, filter)
        lsvFormula.BackColor = Drawing.Color.White

        'lsvFamily.Items.Clear()
        'curFamilyInDeleteSync = Nothing
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
    
        End If
        setLastChosenCar(chosenCar)
    End Sub
 
    Private Sub filterFamilyByType(ByVal type)
        If Not curFamilyInDeleteSync Is Nothing Then
            If curFamilyInDeleteSync.Length > 0 Then
                Dim MyArray As New ArrayList
                Dim i As Integer
                For i = 0 To curFamilyInDeleteSync.Length - 1
                    If curFamilyInDeleteSync(i).type.ToLower.Trim = type.ToLower.Trim Or type.Trim = "" Then
                        curFamilyInDeleteSync(i).isMoved = False
                        MyArray.Add(curFamilyInDeleteSync(i))
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


            Dim whereStr As String = " AND idTable='" & lsvFormula.SelectedItems(0).SubItems(0).Text & "'"

            Dim chosenFormula As Formula = getDeletedFormulasBySyncVersion(currentLastSyncVersion, whereStr)(0)

            Console.WriteLine("after getting chosen formula:" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss fff"))

            lbCarIdSearch.Text = chosenFormula.id_car
            cmbCarNameSearch.Text = chosenFormula.name_car
            txtColorCode.Text = chosenFormula.colorCode
            txtFormulaName.Text = chosenFormula.name_formula
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
            Dim newEntry As Boolean = Not syncFormulasToDelete.ContainsKey(idFormula)

            If newEntry Then
                Dim theFormula As Formula = getDeletedFormulasBySyncVersion(currentLastSyncVersion, " AND idTable =" & idFormula)(0)
                theFormula.actionType = "delete"
                'set missing field
                theFormula.tableName = getCarById(theFormula.id_car).tableName

                syncFormulasToDelete.Add(idFormula, theFormula)
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
            syncFormulasToDelete.Remove(idFormula)
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
        If syncFormulasToDelete.Count > 0 Then
            Dim formulasSelected As Formula()
            Dim MyArray As New ArrayList(syncFormulasToDelete.Values)
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
        txtColorCode.Focus()
    End Sub
End Class