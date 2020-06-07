Imports System.IO

Public Class garagesEditSync

    Public actionType As String = ""
    Private Sub garagesSync_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadGarages()
    End Sub

    Public Sub loadGarages()

        listSelectedGarage()

    End Sub


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


        lsvGarage.BackColor = Drawing.Color.White

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


    Private Sub lsvGarages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvGarage.MouseClick, lsvGarage.KeyDown, lsvGarage.KeyUp
        lbIdGarageForm.Text = lsvGarage.SelectedItems(0).SubItems(0).Text
        txtGarageNameForm.Text = lsvGarage.SelectedItems(0).SubItems(1).Text
        txtGarageLocationForm.Text = lsvGarage.SelectedItems(0).SubItems(2).Text
        txtGarageRespform.Text = lsvGarage.SelectedItems(0).SubItems(3).Text
        txtLanguage.Text = lsvGarage.SelectedItems(0).SubItems(4).Text
        lbIdLanguage.Text = lsvGarage.SelectedItems(0).SubItems(5).Text
        If lsvGarage.SelectedItems(0).SubItems(6).Text = "Eq. applied" Then
            rdApply1.Checked = True
        Else
            If lsvGarage.SelectedItems(0).SubItems(6).Text = "Extended Eq. applied" Then
                rdApply2.Checked = True
            Else
                If lsvGarage.SelectedItems(0).SubItems(6).Text = "Extended +" Then
                    rdApply4.Checked = True
                Else
                    If lsvGarage.SelectedItems(0).SubItems(6).Text = "no 4581-91 Eq. applied" Then
                        rdApply3.Checked = True
                    Else
                        rdApply0.Checked = True
                    End If
                End If
            End If
        End If

        txtversion.Text = lsvGarage.SelectedItems(0).SubItems(7).Text
        If lsvGarage.SelectedItems(0).SubItems(8).Text = "LS" Then
            rdGarageLS.Checked = True
            rdGarage2k.Checked = False
        Else
            rdGarageLS.Checked = False
            rdGarage2k.Checked = True
        End If
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
        chkApply5.Checked = theGarage.apply_equation5
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


    Private Sub butFindLang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFindLang.Click
        mobileSync.ShowDialog()
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
        txttel.Text = ""
        txtkey.Text = ""
        txtusername.Text = ""
    End Sub

    Private Sub ButGoBack_Click(sender As Object, e As EventArgs) Handles ButGoBack.Click
        Me.Close()
    End Sub

    Private Sub butSelectAll_Click(sender As Object, e As EventArgs) Handles butSelectAll.Click
        Dim item As ListViewItem
        For Each item In lsvGarage.Items
            item.Selected = True
        Next
    End Sub

    Private Sub butAddToSync_Click(sender As Object, e As EventArgs) Handles butAddToSync.Click

        Dim item As ListViewItem
        For Each item In lsvGarage.SelectedItems
            Dim idGarage As Integer = item.SubItems(0).Text

            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncGaragesToEdit.ContainsKey(idGarage)

            If newEntry Then
                Dim theGarage As Garage = getGarageById(idGarage)
                theGarage.actionType = "edit"
                syncGaragesToEdit.Add(idGarage, theGarage)
            End If

        Next
        MsgBox(lsvGarage.SelectedItems.Count & " items added to sync. The total selections will be listed.", MsgBoxStyle.Information)
        listSelectedGarage()
        mobileSync.updateGaragesResultLabel(mobileSync.lbGaragesSyncResult)
    End Sub

    Private Sub butRemoveFromSync_Click(sender As Object, e As EventArgs) Handles butRemoveFromSync.Click
        Dim item As ListViewItem
        For Each item In lsvGarage.SelectedItems
            Dim idGarage As Integer = item.SubItems(0).Text
            syncGaragesToEdit.Remove(idGarage)
        Next
        MsgBox(lsvGarage.SelectedItems.Count & " items removed from sync. The remaining selections will be listed.", MsgBoxStyle.Information)
        listSelectedGarage()
        mobileSync.updateGaragesResultLabel(mobileSync.lbGaragesSyncResult)
    End Sub

    Private Sub butListSelected_Click(sender As Object, e As EventArgs) Handles butListSelected.Click
        listSelectedGarage()
    End Sub

    Private Sub listSelectedGarage()
        lsvGarage.BackColor = System.Drawing.Color.FromArgb(192, 255, 192)
        If syncGaragesToEdit.Count > 0 Then
            Dim garagesSelected As Garage()
            Dim MyArray As New ArrayList(syncGaragesToEdit.Values)
            garagesSelected = DirectCast(MyArray.ToArray(GetType(Garage)), Garage())

            addResultsToListviewGarages(garagesSelected)
        Else
            lsvGarage.Items.Clear()
        End If

    End Sub
#Region "Sorting"
    ' The column currently used for sorting.
    Private m_SortingColumn As ColumnHeader

    ' Sort using the clicked column.
    Private Sub lvwBooks_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lsvGarage.ColumnClick
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