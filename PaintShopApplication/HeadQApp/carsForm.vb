Imports System.IO
Public Class carsForm

    'cars tab

    Private Sub butFindCarImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFindCarImg.Click
        If fileDialogCar.ShowDialog() = DialogResult.OK Then
            Try
                txtCarImgPath.Text = fileDialogCar.FileName
                txtfnamehideen.Text = fileDialogCar.SafeFileName
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
        cclCars.Items.Clear()
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
            cclCars.Items.Clear()
            Dim i As Integer = 0
            For i = 0 To carFiltered.Length - 1
                cclCars.Items.Add(carFiltered(i).id_car)
                cclCars.Items(i).SubItems.Add(carFiltered(i).carName)

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

            If updateCar(lbIdCarForm.Text, carname, carImgFile) Then
                MsgBox("Succes", MsgBoxStyle.Information, "Information")
            End If

        Catch ex As Exception
            MsgBox("could not copy image." & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)

        End Try


        txtCarNameForm.Text = ""
        txtCarImgPath.Text = ""
        pctCarImg.Image = Nothing
        cclCars.Items.Clear()

    End Sub

    Private Sub lsvCars_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cclCars.MouseClick, cclCars.KeyDown, cclCars.KeyUp
        lbIdCarForm.Text = cclCars.SelectedItems(0).SubItems(0).Text
        txtCarNameForm.Text = cclCars.SelectedItems(0).SubItems(1).Text
        Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & getCarById(lbIdCarForm.Text).carImgPath
        txtCarImgPath.Text = imgPath
        txtfnamehideen.Text = getCarById(lbIdCarForm.Text).carImgPath
        Try
            imageToPreview = Image.FromFile(imgPath)
            'pctCarImg.Image = imageToPreview
            pctCarImg.ImageLocation = imgPath
        Catch ex As IOException
            MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
        End Try

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

        If deleteCar(lbIdCarForm.Text, car.carName, car.tableName) Then
            MsgBox("Succes", MsgBoxStyle.Information, "Information")
        End If

        txtCarNameForm.Text = ""

        cclCars.Items.Clear()

    End Sub
 
    Private Sub butCarFormChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCarFormChoose.Click
        If lbIdCarForm.Text > 0 Then

            edit.cmbCarNameModelEdit.Text = txtCarNameForm.Text
            edit.lbCarId.Text = lbIdCarForm.Text

            Try
                'addFormula.txtCarNameModelEdit.Text = txtCarNameForm.Text
                addFormula.lbCarId.Text = lbIdCarForm.Text
            Catch ex As Exception

            End Try
            Me.Close()
        Else
            MsgBox("You must select a car first", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub grpCars_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCars.Enter

    End Sub

    Private Sub fileDialogCar_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fileDialogCar.FileOk

    End Sub

    Private Sub cclCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cclCar.Click
        MsgBox("EW")
    End Sub
End Class