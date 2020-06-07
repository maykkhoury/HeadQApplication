Imports System.IO

Public Class colorsDeleteSync

    Public actionType As String = ""
    Private Sub colorsSync_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadColors()
    End Sub

    Public Sub loadColors()

        listSelectedColor()

    End Sub




    Private Sub butSearchBColorForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSearchBColorForm.Click
        Dim BColorNameChk As Boolean = chkBColorFormName.Checked
        Dim BColorName As String = txtBColorNameForm.Text

        
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
            whereStr = " AND " & whereStr
        End If

        Dim BColorFiltered() As Color = getDeletedColorsBySyncVersion(currentLastSyncVersion, whereStr)
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
            Dim newEntry As Boolean = Not syncColorsToDelete.ContainsKey(idColor)

            If newEntry Then
                Dim theColor As Color = getDeletedColorsBySyncVersion(currentLastSyncVersion, " AND idTable =" & idColor)(0)
                theColor.actionType = "delete"
                syncColorsToDelete.Add(idColor, theColor)
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
            syncColorsToDelete.Remove(idColor)
        Next
        MsgBox(lsvBColors.SelectedItems.Count & " items removed from sync. The remaining selections will be listed.", MsgBoxStyle.Information)
        listSelectedColor()
        mobileSync.updateColorsResultLabel(mobileSync.lbColorsSyncResult)
    End Sub

    Private Sub butListSelected_Click(sender As Object, e As EventArgs) Handles butListSelected.Click
        listSelectedColor()
    End Sub

    Private Sub listSelectedColor()
        lsvBColors.BackColor = System.Drawing.Color.FromArgb(255, 128, 128)
        If syncColorsToDelete.Count > 0 Then
            Dim colorsSelected As Color()
            Dim MyArray As New ArrayList(syncColorsToDelete.Values)
            colorsSelected = DirectCast(MyArray.ToArray(GetType(Color)), Color())

            addResultsToListviewbColors(colorsSelected)
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