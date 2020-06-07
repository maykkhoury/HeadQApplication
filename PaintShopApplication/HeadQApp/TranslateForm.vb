Public Class TranslateForm

    Private Sub TranslateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbTranslateToValue.Text = getLanguageById(idLangTranslate).label_language
        addResultsToListviewLabels()
    End Sub

    Public Sub addResultsToListviewLabels()
        Try
            lsvLabels.Items.Clear()
            Dim i As Integer = 0
            Dim labelsTab() As Label = getLabels()
            For i = 0 To labelsTab.Length - 1
                lsvLabels.Items.Add(labelsTab(i).id_label)

                Dim j As Integer
                For j = 0 To labelsTab(i).labelLanguage.Length - 1
                    If getLanguageById(labelsTab(i).labelLanguage(j).id_language).code_language = "en" Then
                        lsvLabels.Items(i).SubItems.Add(labelsTab(i).labelLanguage(j).description)
                        Exit For
                    End If
                Next
                lsvLabels.Items(i).SubItems.Add(labelsTab(i).name_label)
                For j = 0 To labelsTab(i).labelLanguage.Length - 1
                    If labelsTab(i).labelLanguage(j).id_language = idLangTranslate Then
                        lsvLabels.Items(i).SubItems.Add(labelsTab(i).labelLanguage(j).description)
                        Exit For
                    End If
                Next

            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub lsvLabels_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvLabels.MouseClick, lsvLabels.KeyDown, lsvLabels.KeyUp
        lbIdLabel.Text = lsvLabels.SelectedItems(0).SubItems(0).Text.Trim
        lbLabelName.Text = lsvLabels.SelectedItems(0).SubItems(2).Text.Trim
        Try
            If Not lsvLabels.SelectedItems(0).SubItems(3) Is Nothing Then
                txtLabelNew.Text = lsvLabels.SelectedItems(0).SubItems(3).Text.Trim
            End If
        Catch ex As Exception
            txtLabelNew.Text = ""
        End Try
       

    End Sub

    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSave.Click
        deleteLabelLang(lbIdLabel.Text, idLangTranslate)

        If addLabelLanguage(lbIdLabel.Text, txtLabelNew.Text, idLangTranslate) Then
            lsvLabels.SelectedItems(0).SubItems(3).Text = txtLabelNew.Text
            MsgBox("success", MsgBoxStyle.Information)
        Else
            MsgBox("Label not edited", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class