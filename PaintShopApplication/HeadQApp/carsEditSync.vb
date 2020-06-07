Imports System.IO

Public Class carsEditSync

    Public actionType As String = ""
    Private Sub carEditSync_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadCars()
    End Sub

    Public Sub loadCars()

        listSelectedCar()

    End Sub



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
        lsvCars.BackColor = Drawing.Color.White
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
















    Private Sub ButGoBack_Click(sender As Object, e As EventArgs) Handles ButGoBack.Click
        Me.Close()
    End Sub

    Private Sub butSelectAll_Click(sender As Object, e As EventArgs) Handles butSelectAll.Click
        Dim item As ListViewItem
        For Each item In lsvCars.Items
            item.Selected = True
        Next
    End Sub

    Private Sub butAddToSync_Click(sender As Object, e As EventArgs) Handles butAddToSync.Click

        Dim item As ListViewItem
        For Each item In lsvCars.SelectedItems
            Dim idCar As Integer = item.SubItems(0).Text

            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncCarsToEdit.ContainsKey(idCar)

            If newEntry Then
                Dim theCar As Car = getCarById(idCar)
                theCar.actionType = "edit"
                syncCarsToEdit.Add(idCar, theCar)
            End If

        Next
        MsgBox(lsvCars.SelectedItems.Count & " items added to sync. The total selections will be listed.", MsgBoxStyle.Information)
        listSelectedCar()
        mobileSync.updateCarsResultLabel(mobileSync.lbCarsSyncResult)
    End Sub

    Private Sub butRemoveFromSync_Click(sender As Object, e As EventArgs) Handles butRemoveFromSync.Click
        Dim item As ListViewItem
        For Each item In lsvCars.SelectedItems
            Dim idCar As Integer = item.SubItems(0).Text
            syncCarsToEdit.Remove(idCar)
        Next
        MsgBox(lsvCars.SelectedItems.Count & " items removed from sync. The remaining selections will be listed.", MsgBoxStyle.Information)
        listSelectedCar()
        mobileSync.updateCarsResultLabel(mobileSync.lbCarsSyncResult)
    End Sub

    Private Sub butListSelected_Click(sender As Object, e As EventArgs) Handles butListSelected.Click
        listSelectedCar()
    End Sub

    Private Sub listSelectedCar()
        lsvCars.BackColor = System.Drawing.Color.FromArgb(192, 255, 192)
        If syncCarsToEdit.Count > 0 Then
            Dim carsSelected As Car()
            Dim MyArray As New ArrayList(syncCarsToEdit.Values)
            carsSelected = DirectCast(MyArray.ToArray(GetType(Car)), Car())

            addResultsToListviewCars(carsSelected)
        Else
            lsvCars.Items.Clear()
        End If

    End Sub

#Region "Sorting"
    ' The column currently used for sorting.
    Private m_SortingColumn As ColumnHeader

    ' Sort using the clicked column.
    Private Sub lvwBooks_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lsvCars.ColumnClick
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