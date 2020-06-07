Imports System.IO

Public Class colorsEditSync

    Public actionType As String = ""
    Private Sub colorEditSync_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadColors()
    End Sub

    Public Sub loadColors()

        listSelectedColor()

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
        lsvBColors.BackColor = Drawing.Color.White
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







    Private Sub ButGoBack_Click(sender As Object, e As EventArgs) Handles ButGoBack.Click
        Me.Close()
    End Sub

    Private Sub butSelectAll_Click(sender As Object, e As EventArgs) Handles butSelectAll.Click
        Dim item As ListViewItem
        For Each item In lsvBColors.Items
            item.Selected = True
        Next
    End Sub

    Private Sub butAddToSync_Click(sender As Object, e As EventArgs) Handles butAddToSync.Click

        Dim item As ListViewItem
        For Each item In lsvBColors.SelectedItems
            Dim idColor As Integer = item.SubItems(0).Text

            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncColorsToEdit.ContainsKey(idColor)

            If newEntry Then
                Dim theColor As Color = getColorById(idColor)
                theColor.actionType = "edit"
                syncColorsToEdit.Add(idColor, theColor)
            End If

        Next
        MsgBox(lsvBColors.SelectedItems.Count & " items added to sync. The total selections will be listed.", MsgBoxStyle.Information)
        listSelectedColor()
        mobileSync.updateColorsResultLabel(mobileSync.lbColorsSyncResult)
    End Sub

    Private Sub butRemoveFromSync_Click(sender As Object, e As EventArgs) Handles butRemoveFromSync.Click
        Dim item As ListViewItem
        For Each item In lsvBColors.SelectedItems
            Dim idColor As Integer = item.SubItems(0).Text
            syncColorsToEdit.Remove(idColor)
        Next
        MsgBox(lsvBColors.SelectedItems.Count & " items removed from sync. The remaining selections will be listed.", MsgBoxStyle.Information)
        listSelectedColor()
        mobileSync.updateColorsResultLabel(mobileSync.lbColorsSyncResult)
    End Sub

    Private Sub butListSelected_Click(sender As Object, e As EventArgs) Handles butListSelected.Click
        listSelectedColor()
    End Sub

    Private Sub listSelectedColor()
        lsvBColors.BackColor = System.Drawing.Color.FromArgb(192, 255, 192)
        If syncColorsToEdit.Count > 0 Then
            Dim colorsSelected As Color()
            Dim MyArray As New ArrayList(syncColorsToEdit.Values)
            colorsSelected = DirectCast(MyArray.ToArray(GetType(Color)), Color())

            addResultsToListviewBColors(colorsSelected)
        Else
            lsvBColors.Items.Clear()
        End If

    End Sub

#Region "Sorting"
    ' The column currently used for sorting.
    Private m_SortingColumn As ColumnHeader

    ' Sort using the clicked column.
    Private Sub lvwBooks_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lsvBColors.ColumnClick
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

End Class