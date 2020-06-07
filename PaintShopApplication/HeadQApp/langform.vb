Public Class langForm




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
        lsvLanguage.Items.Clear()
    End Sub

    Private Sub butSearchLanguageForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSearchLangForm.Click
        Dim LanguageNameChk As Boolean = chkLanguageFormCode.Checked
        Dim LanguageName As String = txtLanguageCodeForm.Text

        Dim LabelChk As Boolean = chLanguageLabelForm.Checked
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
            Dim i As Integer = 0
            For i = 0 To LanguageFiltered.Length - 1
                lsvLanguage.Items.Add(LanguageFiltered(i).id_language)
                lsvLanguage.Items(i).SubItems.Add(LanguageFiltered(i).code_language)
                lsvLanguage.Items(i).SubItems.Add(LanguageFiltered(i).label_language)
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
        lsvLanguage.Items.Clear()

    End Sub

    Private Sub lsvLanguages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvLanguage.MouseClick, lsvLanguage.KeyDown, lsvLanguage.KeyUp
        lbIdLanguageForm.Text = lsvLanguage.SelectedItems(0).SubItems(0).Text
        txtLanguageCodeForm.Text = lsvLanguage.SelectedItems(0).SubItems(1).Text
        txtLanguageLabelForm.Text = lsvLanguage.SelectedItems(0).SubItems(2).Text

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

    Private Sub butChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butChooseLang.Click
        If lbIdLanguageForm.Text > 0 Then

            HeadQHome.txtLanguage.Text = txtLanguageCodeForm.Text & " - " & txtLanguageLabelForm.Text
            HeadQHome.lbIdLanguage.Text = lbIdLanguageForm.Text
            Me.Close()
        Else
            MsgBox("You must select a Language first", MsgBoxStyle.Information)
        End If
    End Sub


End Class