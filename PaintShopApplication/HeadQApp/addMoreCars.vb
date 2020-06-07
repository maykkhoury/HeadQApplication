Imports System.IO

Public Class addMoreCars
    Public butOkPressed As Boolean = False
    Private checkedOnLoadTab() As checkedOnLoad
    Private fromEdit As Boolean = False
    Private Sub loadCars()
        Dim i As Integer
        Dim orredyLoaded As Boolean = False
        If Not chkBoxCars Is Nothing Then
            If chkBoxCars.Items.Count > 0 Then 'already loaded
                orredyLoaded = True
                'Dim checkedOnLoadTab() As checkedOnLoad
                ReDim checkedOnLoadTab(chkBoxCars.Items.Count - 1)

                For i = 0 To chkBoxCars.Items.Count - 1
                    checkedOnLoadTab(i) = New checkedOnLoad
                    checkedOnLoadTab(i).checked = chkBoxCars.GetItemChecked(i)
                    checkedOnLoadTab(i).carName = chkBoxCars.GetItemText(chkBoxCars.Items(i))
                Next

                Dim carsTab() As Car = getCars("")
                chkBoxCars.Items.Clear()
                For i = 0 To carsTab.Length - 1
                    'edit.cmbCarNameModelEdit.Items.Add(carsTab(i).carName)
                    chkBoxCars.Items.Add(carsTab(i).carName)
                    Dim j As Integer
                    For j = 0 To chkBoxCars.Items.Count - 1
                        If checkedOnLoadTab(j).carName = carsTab(i).carName Then
                            If checkedOnLoadTab(j).checked Then
                                chkBoxCars.SetItemChecked(i, True)
                                Exit For
                            End If
                        End If
                    Next
                Next


            End If
        End If

        If Not orredyLoaded Then

            Dim carsTab() As Car = getCars("")
            ReDim checkedOnLoadTab(carsTab.Length - 1)
            chkBoxCars.Items.Clear()
            For i = 0 To carsTab.Length - 1
                'edit.cmbCarNameModelEdit.Items.Add(carsTab(i).carName)
                chkBoxCars.Items.Add(carsTab(i).carName)

                checkedOnLoadTab(i) = New checkedOnLoad
                checkedOnLoadTab(i).checked = False
                checkedOnLoadTab(i).carName = chkBoxCars.GetItemText(chkBoxCars.Items(i))
            Next
        End If
       

    End Sub

    Private Sub addMoreCars_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not butOkPressed Then 'restore changes
            For i = 0 To chkBoxCars.Items.Count - 1
                chkBoxCars.SetItemChecked(i, checkedOnLoadTab(i).checked)
            Next
        Else
            butOkPressed = False
        End If

    End Sub

   

    Private Sub addMoreCars_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.AccessibleDescription = "fromEdit" Then
            fromEdit = True
        End If

        loadCars()
        lbNote.Text = "Note: The new checked cars will have the colors, 'Apply 4201-180' Equation, formula name and code"
        lbNote.Text &= vbNewLine & "that are currently chosen in the previous form, while the old checked ones will stay intact"
    End Sub


    Private Sub chkBoxCars_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chkBoxCars.ItemCheck
        'If cmbCarName.Text = "" Then
        'lbCarIdCombo.Text = "-1"
        ' Exit Sub
        'End If
        Dim carName As String = sender.text
        Dim carsSelected() As Car = getCars(" WHERE carName ='" & carName & "'")
        If carsSelected Is Nothing Then
            MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If carsSelected.Length = 0 Then
            MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim chosenCar As Car = carsSelected(0)
        'chosenCar = getCars("")(cmbCarName.SelectedIndex - 1)

        If Not chosenCar Is Nothing Then
            lbCarIdCombo.Text = chosenCar.id_car
            Try
                Dim imgPath As String = My.Application.Info.DirectoryPath & "//images//" & chosenCar.carImgPath
                imageToPreview = Image.FromFile(imgPath)
                pctCarImg.Image = imageToPreview
                'pctCarImg.ImageLocation = imgPath
            Catch ex As IOException
                imageToPreview = Nothing
                pctCarImg.Image = imageToPreview
                'MsgBox("Image not found:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace, MsgBoxStyle.Exclamation)
            End Try

        End If
    End Sub

    Private Sub butOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOk.Click
        If fromEdit Then
            butOkPressed = True
            Me.Close()
            Exit Sub
        End If
        leaveFormWithSaving()
        butOkPressed = True
        Me.Close()
    End Sub

    Private Sub butClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butUncheck.Click
        clear()
    End Sub

    Public Sub clear()
        Dim i As Integer
        For i = 0 To chkBoxCars.Items.Count - 1
            chkBoxCars.SetItemChecked(i, False)
        Next
    End Sub


    Private Sub leaveFormWithSaving()
        If chkBoxCars.CheckedItems.Count > 0 Then
            addFormula.cmbChosenCars.Visible = True
            addFormula.cmbCars.Enabled = False
            loadChosenCars()
        Else
            addFormula.cmbChosenCars.Visible = False
            addFormula.cmbCars.Enabled = True
            addFormula.multiCarFormulaColors = Nothing
        End If


    End Sub

    Private Sub loadChosenCars()

        Dim carsTab() As Car = getCars("")
        Dim chosenCar As String = ""
        If addFormula.cmbChosenCars.Text <> "" And Me.AccessibleDescription <> "fromEdit" Then
            chosenCar = addFormula.cmbChosenCars.Text
        End If



        Dim i As Integer

        Dim chosenCarExist As Boolean = False



        'Dim multFormulaNewArray As FormulaColor()()
        'ReDim multFormulaNewArray(chkBoxCars.CheckedItems.Count - 1)

        Dim MyArray As New ArrayList
        Dim carIndex As Integer = 0

        For i = 0 To chkBoxCars.CheckedItems.Count - 1
            Dim carName As String = chkBoxCars.GetItemText(chkBoxCars.CheckedItems(i))
            If carName = chosenCar Then
                chosenCarExist = True
            End If


            'get the car in question
            Dim carsSelected() As Car = getCars(" WHERE carName ='" & carName & "'")
            If carsSelected Is Nothing Then
                MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If carsSelected.Length = 0 Then
                MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim carId As Integer = carsSelected(0).id_car

            Dim multiCarsBeenAssigned As Boolean = False 'multiple cars already have been assigned colors
            If Not addFormula.multiCarFormulaColors Is Nothing Then
                If Not addFormula.multiCarFormulaColors.Length = 0 Then
                    multiCarsBeenAssigned = True
                End If
            End If

            If multiCarsBeenAssigned Then 'multiple cars already have been assigned colors

                Dim j As Integer
                Dim carHadColorsSssigned As Boolean = False
                For j = 0 To addFormula.multiCarFormulaColors.Length - 1
                    Dim tmp As FormulaColor() = addFormula.multiCarFormulaColors(j)
                    Dim tmoNull As Boolean = True
                    If Not tmp Is Nothing Then
                        If tmp.Length <> 0 Then
                            tmoNull = False
                        End If
                    End If
                    If Not tmoNull Then
                        Dim tmpcarId As Integer = tmp(0).id_car
                        If tmpcarId = carId Then 'car did have colors assigned
                            MyArray.Add(addFormula.multiCarFormulaColors(j))
                            carHadColorsSssigned = True
                            Exit For

                        End If
                    End If
                Next
                'we will test if this car had been assigned by nothing, we should keep it nothing
                If Not carHadColorsSssigned Then
                    For g = 0 To addFormula.cmbChosenCars.Items.Count - 1
                        If addFormula.cmbChosenCars.GetItemText(addFormula.cmbChosenCars.Items(g)) = carName Then
                            MyArray.Add(addFormula.multiCarFormulaColors(g))
                            carHadColorsSssigned = True
                            Exit For
                        End If
                    Next
                End If
                If Not carHadColorsSssigned Then
                    Dim k As Integer
                    Dim formulaColorTmp() As FormulaColor = Nothing
                    If Not addFormula.chosenFormulaColors Is Nothing Then
                        If Not addFormula.chosenFormulaColors.Length > 0 Then
                            ReDim formulaColorTmp(addFormula.chosenFormulaColors.Length - 1)
                            For k = 0 To addFormula.chosenFormulaColors.Length - 1
                                formulaColorTmp(k) = New FormulaColor
                                formulaColorTmp(k).id_car = carId
                                formulaColorTmp(k).id_color = addFormula.chosenFormulaColors(k).id_color
                                formulaColorTmp(k).id_formula = addFormula.chosenFormulaColors(k).id_formula
                                formulaColorTmp(k).id_formulaColor = addFormula.chosenFormulaColors(k).id_formulaColor
                                formulaColorTmp(k).id_Unit = addFormula.chosenFormulaColors(k).id_Unit
                                formulaColorTmp(k).quantite = addFormula.chosenFormulaColors(k).quantite
                            Next
                        End If
                    End If
                    MyArray.Add(formulaColorTmp)
                End If

            Else
                If Not addFormula.chosenFormulaColors Is Nothing Then

                    Dim k As Integer
                    Dim formulaColorTmp() As FormulaColor
                    ReDim formulaColorTmp(addFormula.chosenFormulaColors.Length - 1)
                    For k = 0 To addFormula.chosenFormulaColors.Length - 1
                        formulaColorTmp(k) = New FormulaColor
                        formulaColorTmp(k).id_car = carId
                        formulaColorTmp(k).id_color = addFormula.chosenFormulaColors(k).id_color
                        formulaColorTmp(k).id_formula = addFormula.chosenFormulaColors(k).id_formula
                        formulaColorTmp(k).id_formulaColor = addFormula.chosenFormulaColors(k).id_formulaColor
                        formulaColorTmp(k).id_Unit = addFormula.chosenFormulaColors(k).id_Unit
                        formulaColorTmp(k).quantite = addFormula.chosenFormulaColors(k).quantite
                    Next

                    MyArray.Add(formulaColorTmp)
                Else
                    Dim formulaColorTmp() As FormulaColor
                    MyArray.Add(formulaColorTmp)
                End If
            End If
        Next
        ReDim Preserve addFormula.multiCarFormulaColors(chkBoxCars.CheckedItems.Count - 1)

        addFormula.multiCarFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor())), FormulaColor()())

        'Check the color code and name

        Dim myArrayCodeName As New ArrayList

        For i = 0 To addFormula.multiCarFormulaColors.Length - 1
            Dim carName As String = chkBoxCars.GetItemText(chkBoxCars.CheckedItems(i))
            'get the car in question
            Dim carsSelected() As Car = getCars(" WHERE carName ='" & carName & "'")
            If carsSelected Is Nothing Then
                MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If carsSelected.Length = 0 Then
                MsgBox("Car doesn't exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim carId As Integer = carsSelected(0).id_car

            Dim alreadyInitialized As Boolean = False
            If Not addFormula.multiCarNameCode Is Nothing Then
                If addFormula.multiCarNameCode.Length > 0 Then
                    alreadyInitialized = True
                End If
            End If

            If alreadyInitialized Then
                Dim found As Boolean = False
                For k = 0 To addFormula.multiCarNameCode.Length - 1
                    If addFormula.multiCarNameCode(k).id_car = carId Then
                        found = True
                        Dim codeName As New MultiCarNameCode()

                        codeName.formulaCode = addFormula.multiCarNameCode(k).formulaCode
                        codeName.formulaName = addFormula.multiCarNameCode(k).formulaName
                        codeName.id_car = carId

                        myArrayCodeName.Add(codeName)
                        Exit For
                    End If
                Next
                If Not found Then
                    Dim codeName As New MultiCarNameCode()

                    codeName.formulaCode = addFormula.txtColorCode.Text
                    codeName.formulaName = addFormula.txtFormulaName.Text
                    codeName.id_car = carId

                    myArrayCodeName.Add(codeName)
                End If
            Else
                Dim codeName As New MultiCarNameCode()

                codeName.formulaCode = addFormula.txtColorCode.Text
                codeName.formulaName = addFormula.txtFormulaName.Text
                codeName.id_car = carId

                myArrayCodeName.Add(codeName)
            End If
        Next
        ReDim addFormula.multiCarNameCode(addFormula.multiCarFormulaColors.Length - 1)
        addFormula.multiCarNameCode = DirectCast(myArrayCodeName.ToArray(GetType(MultiCarNameCode)), MultiCarNameCode())


        ''''''''''''''''''''''''



        're set the cmbboxChosen
        addFormula.cmbChosenCars.Items.Clear()
        For i = 0 To chkBoxCars.CheckedItems.Count - 1
            Dim carName As String = chkBoxCars.GetItemText(chkBoxCars.CheckedItems(i))
            addFormula.cmbChosenCars.Items.Add(carName)

        Next

        If chosenCarExist Then
            addFormula.cmbChosenCars.Text = chosenCar
        Else
            addFormula.cmbChosenCars.Text = addFormula.cmbChosenCars.GetItemText(addFormula.cmbChosenCars.Items(0))
            ' addFormula.chosenFormulaColorsIndex= cmbChosenCars.SelectedIndex

        End If

    End Sub

    Private Sub butCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancel.Click
        Me.Close()
    End Sub
End Class

Class checkedOnLoad
    Public carName As String
    Public checked As Boolean
End Class