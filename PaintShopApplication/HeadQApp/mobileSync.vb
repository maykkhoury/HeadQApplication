Public Class mobileSync
    Public allFormulasHash As Hashtable ' = getFormulasMap("")

    Public allCarsHash As Hashtable ' = getCarsMap("")
    'Public allFormulaColorsHash As Hashtable = getFormulaColorsMap("")

    Private Sub mobileSync_Load(sender As Object, e As EventArgs) Handles Me.Load
        If currentLastSyncVersion = -1 Then
            MsgBox("Not allowed without internet connection, if the internet connection is available now please restart the program.", MsgBoxStyle.Exclamation)
            Me.Close()

        End If
        allFormulasHash = getFormulasMap("")

        allCarsHash = getCarsMap("")

        'setting the version for those who don't have any because where deleted without internet connexion
        setVersionMobileSyncDeleteTable()
        setVersionMobileSyncEditTable()
        lbProcessEnd.Text = ""
        initResultLabels()
    End Sub

  

    Private Sub butClear_Click(sender As Object, e As EventArgs) Handles butClear.Click

        If MessageBox.Show("Are you sure you want to clear all the selections?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
           MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If
        initSyncObject()
        initResultLabels()
    End Sub

    Private Sub initResultLabels()
        updateGaragesResultLabel(lbGaragesSyncResult)
        updateColorsResultLabel(lbColorsSyncResult)
        updateCarsResultLabel(lbCarsSyncResult)
        updateFormulasResultLabel(lbFormulasSyncResult)
    End Sub

    Private Sub initResultLabelsThread(ByVal lbGaragesSyncResultThread As Windows.Forms.Label, ByVal lbColorsSyncResultThread As Windows.Forms.Label, ByVal lbCarsSyncResultThread As Windows.Forms.Label, ByVal lbFormulasSyncResultThread As Windows.Forms.Label)
        updateGaragesResultLabel(lbGaragesSyncResultThread)
        updateColorsResultLabel(lbColorsSyncResultThread)
        updateCarsResultLabel(lbCarsSyncResultThread)
        updateFormulasResultLabel(lbFormulasSyncResultThread)
    End Sub

    Public Sub updateGaragesResultLabel(ByVal lbGaragesSyncResultThread As Windows.Forms.Label)
        Dim editNumber As Long = syncGaragesToEdit.Count
        Dim deletetNumber As Long = syncGaragesToDelete.Count
        lbGaragesSyncResultThread.Text = "Result: " & editNumber & " edit, " & deletetNumber & " delete"
    End Sub

    Public Sub updateColorsResultLabel(ByVal lbColorsSyncResultThread As Windows.Forms.Label)
        Dim editNumber As Long = syncColorsToEdit.Count
        Dim deletetNumber As Long = syncColorsToDelete.Count
        lbColorsSyncResultThread.Text = "Result: " & editNumber & " edit, " & deletetNumber & " delete"
    End Sub

    Public Sub updateCarsResultLabel(ByVal lbCarsSyncResultThread As Windows.Forms.Label)
        Dim editNumber As Long = syncCarsToEdit.Count
        Dim deletetNumber As Long = syncCarsToDelete.Count
        lbCarsSyncResultThread.Text = "Result: " & editNumber & " edit, " & deletetNumber & " delete"
    End Sub

    Public Sub updateFormulasResultLabel(ByVal lbFormulasSyncResultThread As Windows.Forms.Label)
        Dim editNumber As Long = syncFormulasToEdit.Count
        Dim deletetNumber As Long = syncFormulasToDelete.Count
        lbFormulasSyncResultThread.Text = "Result: " & editNumber & " edit, " & deletetNumber & " delete"
    End Sub


    Private Sub selectAllDeleteGarages(ByVal textCountThread As TextBox)

        Dim garages() As Garage = getDeletedGaragesBySyncVersion(currentLastSyncVersion, "")
        Dim total As String = garages.Length
        Dim inc As Integer = 0
        textCountThread.Text = "0"
        For Each theGarage In garages
            inc += 1
            textCountThread.Text = "Selecting " & inc & " of " & total & " car to delete"
            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncGaragesToDelete.ContainsKey(theGarage.id_garage)

            If newEntry Then
                theGarage.actionType = "delete"
                syncGaragesToDelete.Add(theGarage.id_garage, theGarage)
            End If
        Next
    End Sub
    Private Sub selectAllDeleteColors(ByVal textCountThread As TextBox)

        Dim colors() As Color = getDeletedColorsBySyncVersion(currentLastSyncVersion, "")
        Dim total As String = colors.Length
        Dim inc As Integer = 0
        textCountThread.Text = "0"
        For Each theColor In colors
            inc += 1
            textCountThread.Text = "Selecting " & inc & " of " & total & " car to delete"
            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncColorsToDelete.ContainsKey(theColor.id_color)

            If newEntry Then
                theColor.actionType = "delete"
                syncColorsToDelete.Add(theColor.id_color, theColor)
            End If
        Next
    End Sub

    Private Sub selectAllDeleteCars(ByVal textCountThread As TextBox)

        Dim cars() As Car = getDeletedCarsBySyncVersion(currentLastSyncVersion, "")
        Dim total As String = cars.Length
        Dim inc As Integer = 0
        textCountThread.Text = "0"
        For Each theCar In cars
            inc += 1
            textCountThread.Text = "Selecting " & inc & " of " & total & " car to delete"
            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncCarsToDelete.ContainsKey(theCar.id_car)

            If newEntry Then
                theCar.actionType = "delete"
                syncCarsToDelete.Add(theCar.id_car, theCar)
            End If
        Next
    End Sub

    Private Sub selectAllDeleteFormulas(ByVal textCountThread As TextBox)

        Dim formulas() As Formula = getDeletedFormulasBySyncVersion(currentLastSyncVersion, "")
        Dim total As String = formulas.Length
        Dim inc As Integer = 0
        textCountThread.Text = "0"
        For Each theformula In formulas
            inc += 1
            textCountThread.Text = "Selecting " & inc & " of " & total & " formula to delete"

            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncFormulasToDelete.ContainsKey(theformula.id_formula)

            If newEntry Then
                theformula.actionType = "delete"
                'set missing field
                theformula.tableName = getCarById(theformula.id_car).tableName

                syncFormulasToDelete.Add(theformula.id_formula, theformula)
            End If

        Next

    End Sub
    Private Sub selectAllEditGarages(ByVal textCountThread As TextBox)

        Dim garageIds() As Integer = getEditedMobileSync(currentLastSyncVersion, "garage")
        Dim total As String = garageIds.Length
        Dim inc As Integer = 0
        textCountThread.Text = "0"
        For Each idGarage In garageIds
            inc += 1
            textCountThread.Text = "Selecting " & inc & " of " & total & " garage to edit"
            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncGaragesToEdit.ContainsKey(idGarage)

            If newEntry Then
                Dim theGarage As Garage = getGarageById(idGarage)
                'this doesnt happen. just first sync because data were not consistant
                If theGarage Is Nothing Then
                    Continue For
                End If
                theGarage.actionType = "edit"
                syncGaragesToEdit.Add(idGarage, theGarage)
            End If
        Next
    End Sub

    Private Sub selectAllEditColors(ByVal textCountThread As TextBox)

        Dim colorIds() As Integer = getEditedMobileSync(currentLastSyncVersion, "color")
        Dim total As String = colorIds.Length
        Dim inc As Integer = 0
        textCountThread.Text = "0"
        For Each idColor In colorIds
            inc += 1
            textCountThread.Text = "Selecting " & inc & " of " & total & " color to edit"
            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncColorsToEdit.ContainsKey(idColor)

            If newEntry Then
                Dim theColor As Color = getColorById(idColor)
                'this doesnt happen. just first sync because data were not consistant
                If theColor Is Nothing Then
                    Continue For
                End If

                theColor.actionType = "edit"
                syncColorsToEdit.Add(idColor, theColor)
            End If
        Next
    End Sub

    Private Sub selectAllEditCars(ByVal textCountThread As TextBox)

        Dim carIds() As Integer = getEditedMobileSync(currentLastSyncVersion, "car")
        Dim total As String = carIds.Length
        Dim inc As Integer = 0
        textCountThread.Text = "0"
        For Each idCar In carIds
            inc += 1
            textCountThread.Text = "Selecting " & inc & " of " & total & " car to edit"
            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncCarsToEdit.ContainsKey(idCar)

            If newEntry Then
                Dim theCar As Car = getCarById(idCar)

                'this doesnt happen. just first sync because data were not consistant
                If theCar Is Nothing Then
                    Continue For
                End If


                theCar.actionType = "edit"
                syncCarsToEdit.Add(idCar, theCar)
            End If
        Next
    End Sub

    Private Sub selectAllEditFormulas(ByVal textCountThread As TextBox)
        Dim allFormulaColorsHash As New Hashtable
        getFormulaColorsMap(allFormulaColorsHash)

        Dim formulaIds() As Integer = getEditedMobileSync(currentLastSyncVersion, "formula")
        Dim total As String = formulaIds.Length
        Dim inc As Integer = 0
        textCountThread.Text = "0"
        For Each idFormula In formulaIds
            inc += 1
            textCountThread.Text = "Selecting " & inc & " of " & total & " formula to edit"
            'textCountThread.Text = textCountThread.Text + 1
            'check if already in the HashTable
            Dim newEntry As Boolean = Not syncFormulasToEdit.ContainsKey(idFormula)

            If newEntry Then
                Dim theFormula As Formula = allFormulasHash.Item(idFormula)

                'this doesnt happen. just first sync because data were not consistant
                If theFormula Is Nothing Then
                    Continue For
                End If
                'setting missing json fields

                'Dim formulaColor As FormulaColor() = getFormulaColorsByIdFormula(idFormula, theFormula.type, True)
                'enhancing performance, by reducing db calls
                Dim formulaColor As FormulaColor() = Nothing
                Dim nestedFormulaColorsList As ArrayList = allFormulaColorsHash.Item(idFormula)
                If Not nestedFormulaColorsList Is Nothing Then
                    formulaColor = DirectCast(nestedFormulaColorsList.ToArray(GetType(FormulaColor)), FormulaColor())
                End If
                'adding a formulaColor (ter2i3 to prevent changes from the mobile app side)
                If formulaColor Is Nothing Then
                    Dim aFormulaColor = New FormulaColor
                    aFormulaColor.id_formulaColor = -1
                    aFormulaColor.id_formulaColorStr = "-1"
                    aFormulaColor.id_formula = -1
                    aFormulaColor.id_formulaStr = "-1"
                    aFormulaColor.id_car = -1
                    aFormulaColor.id_carStr = "-1"
                    aFormulaColor.id_color = -1
                    aFormulaColor.id_colorStr = "-1"
                    aFormulaColor.encrypted = False
                    aFormulaColor.encryptedStr = "1"
                    aFormulaColor.quantite = "-1"
                    aFormulaColor.quantiteStr = "-1"
                    aFormulaColor.id_Unit = -1
                    aFormulaColor.id_UnitStr = "-1"

                    Dim anArray As New ArrayList
                    anArray.Add(aFormulaColor)
                    formulaColor = DirectCast(anArray.ToArray(GetType(FormulaColor)), FormulaColor())
                End If
                theFormula.formulaColor = formulaColor

                theFormula.tableName = (allCarsHash.Item(theFormula.id_car)).tableName

                theFormula.code_formulaX = getCodeFormulaX(theFormula.id_formulaX, allFormulasHash)
                theFormula.code_formulaXp = getCodeFormulaXp(theFormula.id_formulaXp, allFormulasHash)
                theFormula.code_formulaXpp = getCodeFormulaXpp(theFormula.id_formulaX2p, allFormulasHash)

                theFormula.code_formulaY = getCodeFormulaY(theFormula.id_formulaY, allFormulasHash)
                theFormula.code_formulaYp = getCodeFormulaYp(theFormula.id_formulaYp, allFormulasHash)
                theFormula.code_formulaYpp = getCodeFormulaYpp(theFormula.id_formulaY2p, allFormulasHash)

                theFormula.code_formulaZ = getCodeFormulaZ(theFormula.id_formulaZ, allFormulasHash)
                theFormula.code_formulaZp = getCodeFormulaZp(theFormula.id_formulaZp, allFormulasHash)
                theFormula.code_formulaZpp = getCodeFormulaZpp(theFormula.id_formulaZ2p, allFormulasHash)


                theFormula.actionType = "edit"
                syncFormulasToEdit.Add(idFormula, theFormula)
            End If
        Next

    End Sub

    Private Sub butSelectGarages_Click(sender As Object, e As EventArgs) Handles butSelectGaragesForEdit.Click
        garagesEditSync.ShowDialog()

    End Sub


    Private Sub butClose_Click(sender As Object, e As EventArgs) Handles butClose.Click
        Me.Close()
    End Sub

    Private Sub butSelectGaragesForDelete_Click(sender As Object, e As EventArgs) Handles butSelectGaragesForDelete.Click

        garagesDeleteSync.ShowDialog()
    End Sub

    Private Sub butGenerate_Click(sender As Object, e As EventArgs) Handles butGenerate.Click
        generateSyncFile()
    End Sub

    Private Sub generateSyncFile()
        'controls....
        'Dim directoryOfDest As String = txtSyncDirectory.Text
        ' If directoryOfDest = "" Then
        'MsgBox("Please choose the ""Folder Path"" of the sync file ""dbSync.txt""", MsgBoxStyle.Exclamation)
        ' Exit Sub
        'End If
        If syncGaragesToDelete.Count = 0 And syncGaragesToEdit.Count = 0 And syncFormulasToDelete.Count = 0 And syncFormulasToEdit.Count = 0 And
            syncColorsToDelete.Count = 0 And syncColorsToEdit.Count = 0 And syncCarsToDelete.Count = 0 And syncCarsToEdit.Count = 0 Then

            MsgBox("No new data selected, there will be no sync file created", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        '----------------------

        Dim updateContent As New UpdateContent()

        'Garages
        Dim garagesSelected As Garage()

        'treat delete garages, adding them to the array of delete garages
        Dim MyArrayOfDeleteGarages As New ArrayList()
        If syncGaragesToDelete.Count > 0 Then

            'JSON example for garages to delete: [{"actionType": "delete", "id_garage": "2", "garage_name": "S.C.paints"},{"actionType": "delete", "id_garage": "2", "garage_name": "S.C.paints"}]
            Dim syncGaragesToDeleteArray As New ArrayList(syncGaragesToDelete.Values)
            Dim syncGaragesToDeleteJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(syncGaragesToDeleteArray)
            'Console.WriteLine(syncGaragesToDeleteJSON)

            'convert the garage hashtable to array of garages

            MyArrayOfDeleteGarages = New ArrayList(syncGaragesToDelete.Values)
        End If

        'treat edit garages, adding them to the array of delete garages
        Dim MyArrayOfEditGarages As New ArrayList()
        If syncGaragesToEdit.Count > 0 Then

            'JSON example for garages to Edit:
            Dim syncGaragesToEditArray As New ArrayList(syncGaragesToEdit.Values)
            Dim syncGaragesToEditJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(syncGaragesToEditArray)
            ' Console.WriteLine(syncGaragesToEditJSON)

            'convert the garage hashtable to array of garages

            MyArrayOfEditGarages = New ArrayList(syncGaragesToEdit.Values)
        End If
        'merging garages arrayList
        Dim myGarageMergedArray As New ArrayList()
        myGarageMergedArray.AddRange(MyArrayOfEditGarages)
        myGarageMergedArray.AddRange(MyArrayOfDeleteGarages)
        garagesSelected = DirectCast(myGarageMergedArray.ToArray(GetType(Garage)), Garage())
        'set the array into the update object
        updateContent.garages = garagesSelected
        '-------------------------------------

        'Cars
        Dim carsSelected As Car()

        'treat delete cars, adding them to the array of delete cars
        Dim MyArrayOfDeleteCars As New ArrayList()
        If syncCarsToDelete.Count > 0 Then

            'JSON example for cars to delete: [{"actionType": "delete", "id_car": "2", "tableName": "Aston_Martin"} ]
            Dim syncCarsToDeleteArray As New ArrayList(syncCarsToDelete.Values)
            Dim syncCarsToDeleteJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(syncCarsToDeleteArray)
            'Console.WriteLine(syncCarsToDeleteJSON)

            'convert the car hashtable to array of cars

            MyArrayOfDeleteCars = New ArrayList(syncCarsToDelete.Values)
        End If

        'treat edit cars, adding them to the array of delete cars
        Dim MyArrayOfEditCars As New ArrayList()
        If syncCarsToEdit.Count > 0 Then

            'JSON example for cars to Edit:
            Dim syncCarsToEditArray As New ArrayList(syncCarsToEdit.Values)
            Dim syncCarsToEditJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(syncCarsToEditArray)
            'Console.WriteLine(syncCarsToEditJSON)

            'convert the car hashtable to array of cars

            MyArrayOfEditCars = New ArrayList(syncCarsToEdit.Values)
        End If

        'merging cars arrayList
        Dim myCarMergedArray As New ArrayList()
        myCarMergedArray.AddRange(MyArrayOfEditCars)
        myCarMergedArray.AddRange(MyArrayOfDeleteCars)
        carsSelected = DirectCast(myCarMergedArray.ToArray(GetType(Car)), Car())
        'set the array into the update object
        updateContent.cars = carsSelected
        '-------------------------------------

        'Colors
        Dim colorsSelected As Color()

        'treat delete colors, adding them to the array of delete colors
        Dim MyArrayOfDeleteColors As New ArrayList()
        If syncColorsToDelete.Count > 0 Then

            'JSON example for colors to delete: [{"actionType": "delete", "id_color": "2", "tableName": "Aston_Martin"} ]
            Dim syncColorsToDeleteArray As New ArrayList(syncColorsToDelete.Values)
            Dim syncColorsToDeleteJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(syncColorsToDeleteArray)
            'Console.WriteLine(syncColorsToDeleteJSON)

            'convert the color hashtable to array of colors

            MyArrayOfDeleteColors = New ArrayList(syncColorsToDelete.Values)
        End If

        'treat edit colors, adding them to the array of delete colors
        Dim MyArrayOfEditColors As New ArrayList()
        If syncColorsToEdit.Count > 0 Then

            'JSON example for colors to Edit:
            Dim syncColorsToEditArray As New ArrayList(syncColorsToEdit.Values)
            Dim syncColorsToEditJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(syncColorsToEditArray)
            'Console.WriteLine(syncColorsToEditJSON)

            'convert the color hashtable to array of colors

            MyArrayOfEditColors = New ArrayList(syncColorsToEdit.Values)
        End If

        'merging colors arrayList
        Dim myColorMergedArray As New ArrayList()
        myColorMergedArray.AddRange(MyArrayOfEditColors)
        myColorMergedArray.AddRange(MyArrayOfDeleteColors)
        colorsSelected = DirectCast(myColorMergedArray.ToArray(GetType(Color)), Color())
        'set the array into the update object
        updateContent.colors = colorsSelected
        '-------------------------------------

        'Formulas
        Dim formulasSelected As Formula()

        'treat delete formulas, adding them to the array of delete formulas
        Dim MyArrayOfDeleteFormulas As New ArrayList()
        If syncFormulasToDelete.Count > 0 Then

            'JSON example for formulas to delete: [{"actionType": "delete", "id_formula": "2", "tableName": "Aston_Martin"} ]
            Dim syncFormulasToDeleteArray As New ArrayList(syncFormulasToDelete.Values)
            Dim syncFormulasToDeleteJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(syncFormulasToDeleteArray)
            'Console.WriteLine(syncFormulasToDeleteJSON)

            'convert the formula hashtable to array of formulas

            MyArrayOfDeleteFormulas = New ArrayList(syncFormulasToDelete.Values)
        End If

        'treat edit formulas, adding them to the array of delete formulas
        Dim MyArrayOfEditFormulas As New ArrayList()
        If syncFormulasToEdit.Count > 0 Then

            'JSON example for formulas to Edit:
            Dim syncFormulasToEditArray As New ArrayList(syncFormulasToEdit.Values)
            Dim syncFormulasToEditJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(syncFormulasToEditArray)
            'Console.WriteLine(syncFormulasToEditJSON)

            'convert the formula hashtable to array of formulas

            MyArrayOfEditFormulas = New ArrayList(syncFormulasToEdit.Values)
        End If

        'merging formulas arrayList
        Dim myFormulaMergedArray As New ArrayList()
        myFormulaMergedArray.AddRange(MyArrayOfEditFormulas)
        myFormulaMergedArray.AddRange(MyArrayOfDeleteFormulas)
        formulasSelected = DirectCast(myFormulaMergedArray.ToArray(GetType(Formula)), Formula())
        'set the array into the update object
        updateContent.formulas = formulasSelected
        '-------------------------------------


        'write the json file
        Dim updates As New Updates()
        updates.updateContent = updateContent
        updates.version = currentLastSyncVersion

        'convert the object to json
        Dim updatesJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(updates)
        'Console.WriteLine(updatesJSON)
        '------------------------
        '''''''''''''complete file


        Dim newDbUpdateStr As String = appendVersionToUpdateFile(updatesJSON)


        deleteSyncFileFTP()
        putSyncFileFTP(newDbUpdateStr)
        setCurrentLastSyncedVersionFTP()
      

        ''''
        ' Try

        'Dim file As System.IO.StreamWriter
        'file = My.Computer.FileSystem.OpenTextFileWriter(directoryOfDest & "\dbSync.txt", False)
        'file.WriteLine(newDbUpdateStr)
        'file.Close()

        ' Catch ex As Exception
        'MsgBox("Error in writing to the update file: " & directoryOfDest & "\dbSync.txt" & vbNewLine & "Please make sure this user has admin rights to this folder", MsgBoxStyle.Critical)
        ' Exit Sub
        'End Try
        ' MsgBox("update file 'dbSync.txt' is generated under the folder '" & directoryOfDest & "'" & vbNewLine & vbNewLine & "To complete the sync procedure, this file must be uploaded to https://cloud.restlet.com", MsgBoxStyle.Information)
        MsgBox("The sync procedure is completed, and the file was uploaded to https://cloud.restlet.com", MsgBoxStyle.Information)

        'reinit
        initSyncObject()
        initResultLabels()

        Me.Close()

    End Sub

    Private Sub butSelectCarsForEdit_Click(sender As Object, e As EventArgs) Handles butSelectCarsForEdit.Click
        carsEditSync.ShowDialog()
    End Sub

    Private Sub butSelectCarsForDelete_Click(sender As Object, e As EventArgs) Handles butSelectCarsForDelete.Click
        carsDeleteSync.ShowDialog()
    End Sub

    Private Sub butSelectColorsForEdit_Click(sender As Object, e As EventArgs) Handles butSelectColorsForEdit.Click
        colorsEditSync.ShowDialog()
    End Sub

    Private Sub butSelectColorsForDelete_Click(sender As Object, e As EventArgs) Handles butSelectColorsForDelete.Click
        colorsDeleteSync.ShowDialog()
    End Sub

    Private Sub butSelectFormulasForEdit_Click(sender As Object, e As EventArgs) Handles butSelectFormulasForEdit.Click
        formulasEditSync.ShowDialog()
    End Sub

    Private Sub butSelectFormulasForDelete_Click(sender As Object, e As EventArgs) Handles butSelectFormulasForDelete.Click
        formulasDeleteSync.ShowDialog()
    End Sub

    Private Sub butAutoSelect_Click(sender As Object, e As EventArgs) Handles butAutoSelect.Click


        Windows.Forms.Label.CheckForIllegalCrossThreadCalls = False 
        Windows.Forms.TextBox.CheckForIllegalCrossThreadCalls = False
        Windows.Forms.GroupBox.CheckForIllegalCrossThreadCalls = False

        Dim args As ArgumentType = New ArgumentType()
         
        args.lbProcessEndThread = lbProcessEnd
        args.lbGaragesSyncResultThread = lbGaragesSyncResult
        args.lbColorsSyncResultThread = lbColorsSyncResult
        args.lbCarsSyncResultThread = lbCarsSyncResult
        args.lbFormulasSyncResultThread = lbFormulasSyncResult


        args.textCountThread = txtcount
        args.grpLanguageFormThread = grpLanguageForm
        bgWorkerSelectChanges.RunWorkerAsync(args)



    End Sub
    Private Sub butAutoSelect_Clickold(sender As Object, e As EventArgs)


        'selectAllDeleteCars()
        'selectAllDeleteColors()
        'selectAllDeleteFormulas()
        'selectAllDeleteGarages()

        'selectAllEditCars()
        'selectAllEditColors()
        'selectAllEditFormulas()
        'selectAllEditGarages()

        initResultLabels()
        MsgBox("All data selected and ready to be generated", MsgBoxStyle.Information)


    End Sub


    Public Class ArgumentType

        Public lbProcessEndThread As Windows.Forms.Label
        Public lbGaragesSyncResultThread As Windows.Forms.Label
        Public lbColorsSyncResultThread As Windows.Forms.Label
        Public lbCarsSyncResultThread As Windows.Forms.Label
        Public lbFormulasSyncResultThread As Windows.Forms.Label

        Public textCountThread As TextBox

        Public mobileSyncThread As Form

        Public grpLanguageFormThread As GroupBox
    End Class

    Private Sub bgWorkerSelectChanges_DoWork(ByVal sender As System.Object, _
                                        ByVal e As System.ComponentModel.DoWorkEventArgs) _
                                        Handles bgWorkerSelectChanges.DoWork
        ' Do some time-consuming work on this thread.
        Dim args As ArgumentType = e.Argument
        Dim mobileSyncThread As Form = args.mobileSyncThread
        Dim grpLanguageFormThread As GroupBox = args.grpLanguageFormThread

        Dim textCountThread As Windows.Forms.TextBox = args.textCountThread



        'textCountThread.Visible = True
 

        grpLanguageFormThread.Enabled = False


        selectAllDeleteCars(textCountThread)
        selectAllDeleteColors(textCountThread)
        selectAllDeleteFormulas(textCountThread)
        selectAllDeleteGarages(textCountThread)

        selectAllEditCars(textCountThread)
        selectAllEditColors(textCountThread)
        selectAllEditFormulas(textCountThread)
        selectAllEditGarages(textCountThread)





        e.Result = e.Argument
    End Sub

    Private Sub bgWorkerSelectChanges_RunWorkerCompleted(ByVal sender As System.Object, _
                                                     ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
                                                     Handles bgWorkerSelectChanges.RunWorkerCompleted
        ' Called when the BackgroundWorker is completed.
        Dim args As ArgumentType = e.Result

        Dim mobileSyncThread As Form = args.mobileSyncThread
        Dim grpLanguageFormThread As GroupBox = args.grpLanguageFormThread

        Dim lbProcessEndThread As Windows.Forms.Label = args.lbProcessEndThread

        Dim lbGaragesSyncResultThread As Windows.Forms.Label = args.lbGaragesSyncResultThread
        Dim lbColorsSyncResultThread As Windows.Forms.Label = args.lbColorsSyncResultThread
        Dim lbCarsSyncResultThread As Windows.Forms.Label = args.lbCarsSyncResultThread
        Dim lbFormulasSyncResultThread As Windows.Forms.Label = args.lbFormulasSyncResultThread

        initResultLabelsThread(lbGaragesSyncResultThread, lbColorsSyncResultThread, lbCarsSyncResultThread, lbFormulasSyncResultThread)
        grpLanguageFormThread.Enabled = True
        lbProcessEndThread.Text = "All data selected and ready to be generated"
    End Sub


 
    Private Sub butResetSynch_Click(sender As Object, e As EventArgs) Handles butResetSynch.Click
        If MsgBox("This action will reset all the synch data therefore you will loose synch data for the mobile app." & vbNewLine & "So this should not be ONLY done when a new release has been uploaded to the appstore/google play because it contains the newest data." & vbNewLine & "Are you sure you want to continue?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            backupFile(My.Application.Info.DirectoryPath & "\mobileSync", "mobileSyncApp.db")
            emptyMobileSync()
            initSyncObject()
            initResultLabels()
            MsgBox("Reset done", MsgBoxStyle.Information)
        End If
    End Sub
End Class