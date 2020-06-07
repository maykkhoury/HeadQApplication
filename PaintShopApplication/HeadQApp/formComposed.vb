Public Class formComposed

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        Me.Close()
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1A.Click, Button2A.Click, Button3A.Click, Button1B.Click, Button2B.Click, Button3B.Click
        Dim but As Button = CType(sender, Button)
        Dim formulaId As Integer = but.AccessibleDescription
        If formulaId = -1 Or formulaId = -2 Then
            MsgBox("Color " & but.Text & " does not exist", MsgBoxStyle.Critical)
            Exit Sub
        End If

        selectedFormulaColors = Nothing
        ratio = 1

        Dim carsTab() As Car = getCars("")

        Dim i As Integer
        edit.cmbCarNameModelEdit.Items.Add("")
        For i = 0 To carsTab.Length - 1
            edit.cmbCarNameModelEdit.Items.Add(carsTab(i).carName)
        Next


        edit.generatesDetails(Nothing, formulaId)

        Me.Visible = False
        edit.grpEdit.Visible = True
        edit.formulaDup = Nothing
        edit.ShowDialog()


    End Sub

    Private Sub butCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancel.Click
        If MsgBox("Are you sure you want to cancel the color assignement of this Formula?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            assignFormulaXYZ(HeadQHome.lsvFamily.SelectedItems(0).SubItems(0).Text, -1, -1, -1, -1, -1, -1, -1, -1, -1)
            Me.Close()
        End If
    End Sub


End Class