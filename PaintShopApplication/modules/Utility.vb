Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO.Packaging

Module Utility
    Private TripleDes As New TripleDESCryptoServiceProvider
    Public colorsFromSpecificDB() As Color
    Public Function getCodeFormulaX(ByVal id_formula As Integer, ByVal allFormulasHash As Hashtable) As String
        Dim code As String = ""
        Dim formula As Formula = allFormulasHash.Item(id_formula)
        If Not formula Is Nothing Then
            code = formula.code_formulaX
        End If
        Return code
    End Function
    Public Function containsSpecialCharacters(ByVal value As String) As Boolean 
        Dim regexItem As Regex = New Regex("^[a-zA-Z0-9 ]*$")
        Dim xval_regex As Boolean

        xval_regex = regexItem.IsMatch(value)

        If xval_regex = "False" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function getCodeFormulaXp(ByVal id_formula As Integer, ByVal allFormulasHash As Hashtable) As String
        Dim code As String = ""
        Dim formula As Formula = allFormulasHash.Item(id_formula)
        If Not formula Is Nothing Then
            code = formula.code_formulaXp
        End If
        Return code
    End Function

    Public Function getCodeFormulaXpp(ByVal id_formula As Integer, ByVal allFormulasHash As Hashtable) As String
        Dim code As String = ""
        Dim formula As Formula = allFormulasHash.Item(id_formula)
        If Not formula Is Nothing Then
            code = formula.code_formulaXpp
        End If
        Return code
    End Function

    Public Function getCodeFormulaY(ByVal id_formula As Integer, ByVal allFormulasHash As Hashtable) As String
        Dim code As String = ""
        Dim formula As Formula = allFormulasHash.Item(id_formula)
        If Not formula Is Nothing Then
            code = formula.code_formulaY
        End If
        Return code
    End Function

    Public Function getCodeFormulaYp(ByVal id_formula As Integer, ByVal allFormulasHash As Hashtable) As String
        Dim code As String = ""
        Dim formula As Formula = allFormulasHash.Item(id_formula)
        If Not formula Is Nothing Then
            code = formula.code_formulaYp
        End If
        Return code
    End Function

    Public Function getCodeFormulaYpp(ByVal id_formula As Integer, ByVal allFormulasHash As Hashtable) As String
        Dim code As String = ""
        Dim formula As Formula = allFormulasHash.Item(id_formula)
        If Not formula Is Nothing Then
            code = formula.code_formulaYpp
        End If
        Return code
    End Function

    Public Function getCodeFormulaZ(ByVal id_formula As Integer, ByVal allFormulasHash As Hashtable) As String
        Dim code As String = ""
        Dim formula As Formula = allFormulasHash.Item(id_formula)
        If Not formula Is Nothing Then
            code = formula.code_formulaZ
        End If
        Return code
    End Function

    Public Function getCodeFormulaZp(ByVal id_formula As Integer, ByVal allFormulasHash As Hashtable) As String
        Dim code As String = ""
        Dim formula As Formula = allFormulasHash.Item(id_formula)
        If Not formula Is Nothing Then
            code = formula.code_formulaZp
        End If
        Return code
    End Function

    Public Function getCodeFormulaZpp(ByVal id_formula As Integer, ByVal allFormulasHash As Hashtable) As String
        Dim code As String = ""
        Dim formula As Formula = allFormulasHash.Item(id_formula)
        If Not formula Is Nothing Then
            code = formula.code_formulaZpp
        End If
        Return code
    End Function

    Public Function checkIfDifferentTab(ByVal currentFormulaColor() As FormulaColor, selectedFormulaColors() As FormulaColor) As Boolean
        Dim i As Integer
        Dim j As Integer
        For i = 0 To currentFormulaColor.Length - 1
            Dim found As Boolean = False
            For j = 0 To selectedFormulaColors.Length - 1
                If selectedFormulaColors(j).id_color = currentFormulaColor(i).id_color Then
                    If Math.Round(selectedFormulaColors(j).quantite, 1) = Math.Round(currentFormulaColor(i).quantite, 1) Then
                        found = True
                        Exit For
                    End If
                End If
            Next
            If Not found Then
                Return True
            End If
        Next

        For i = 0 To selectedFormulaColors.Length - 1
            Dim found As Boolean = False
            For j = 0 To currentFormulaColor.Length - 1
                If currentFormulaColor(j).id_color = selectedFormulaColors(i).id_color Then
                    If Math.Round(currentFormulaColor(j).quantite, 1) = Math.Round(selectedFormulaColors(i).quantite, 1) Then
                        found = True
                        Exit For
                    End If
                End If
            Next
            If Not found Then
                Return True
            End If
        Next

        Return False
    End Function
    Public Function getVariant(ByVal variantName As String) As FormulaVariants
        Try

            Dim i As Integer
            Dim var As FormulaVariants = Nothing
            For i = 0 To variants.Length - 1
                If variants(i) Is Nothing Then
                    Continue For
                End If
                If variants(i).variantName = variantName Then
                    var = variants(i)
                    Exit For
                End If
            Next
            getVariant = var
        Catch ex As Exception
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function


    Public Function convertToChosenCurrency(ByVal value, ByVal rateToDollar) As Decimal
        Dim valueInDollar As Decimal
        valueInDollar = value / rateToDollar

        Dim rateChosenCurrToDol As Decimal = chosenCurrency.rateToDollar

        Dim valueInChosenCurrency As Decimal = valueInDollar * rateChosenCurrToDol

        Return valueInChosenCurrency

    End Function
    Function SafeSqlLiteral(ByVal strValue, Optional ByVal quoteReplace = True) As String
        Dim intLevel As Integer = 1
        '*** Written by user CWA, CoolWebAwards.com Forums. 2 February 2010
        '*** http://forum.coolwebawards.com/threads/11-Preventing-SQL-injection-attacks-using-VB-NET

        ' intLevel represent how thorough the value will be checked for dangerous code
        ' intLevel (1) - Do just the basic. This level will already counter most of the SQL injection attacks
        ' intLevel (2) - &nbsp; (non breaking space) will be added to most words used in SQL queries to prevent unauthorized access to the database. Safe to be printed back into HTML code. Don't use for usernames or passwords

        If Not IsDBNull(strValue) Then
            If intLevel > 0 Then
                If quoteReplace Then
                    strValue = Replace(strValue, "'", "''") ' Most important one! This line alone can prevent most injection attacks
                End If
                strValue = Replace(strValue, "--", "")
                'strValue = Replace(strValue, "[", "[[]")
                strValue = Replace(strValue, "%", "[%]")
            End If

            If intLevel > 1 Then
                Dim myArray As Array
                myArray = Split("xp_ ;update ;insert ;select ;drop ;alter ;create ;rename ;delete ;replace ", ";")
                Dim i, i2, intLenghtLeft As Integer
                For i = LBound(myArray) To UBound(myArray)
                    Dim rx As New Regex(myArray(i), RegexOptions.Compiled Or RegexOptions.IgnoreCase)
                    Dim matches As MatchCollection = rx.Matches(strValue)
                    i2 = 0
                    For Each match As Match In matches
                        Dim groups As GroupCollection = match.Groups
                        intLenghtLeft = groups.Item(0).Index + Len(myArray(i)) + i2
                        strValue = Left(strValue, intLenghtLeft - 1) & "&nbsp;" & Right(strValue, Len(strValue) - intLenghtLeft)
                        i2 += 5
                    Next
                Next
            End If

            'strValue = replace(strValue, ";", ";&nbsp;")
            'strValue = replace(strValue, "_", "[_]")

            Return strValue
        Else
            Return strValue
        End If

    End Function

    ' This method accepts two strings that represent two files to 
    ' compare. A return value of 0 indicates that the contents of the files
    ' are the same. A return value of any other value indicates that the 
    ' files are not the same.

 
    Public Function backupFile(ByVal filepath As String, ByVal filename As String) As Boolean
        Dim myFileCompression As MyFileCompression = New MyFileCompression()
        myFileCompression.compressFile(filepath, filename)

    End Function
     
    Public Function FileCompare(ByVal file1 As String, ByVal file2 As String) As Boolean
        Dim file1byte As Integer
        Dim file2byte As Integer
        Dim fs1 As FileStream
        Dim fs2 As FileStream

        ' Determine if the same file was referenced two times.
        If (file1 = file2) Then
            ' Return 0 to indicate that the files are the same.
            Return True
        End If

        ' Open the two files.
        fs1 = New FileStream(file1, FileMode.Open)
        fs2 = New FileStream(file2, FileMode.Open)

        ' Check the file sizes. If they are not the same, the files
        ' are not equal.
        If (fs1.Length <> fs2.Length) Then
            ' Close the file
            fs1.Close()
            fs2.Close()

            ' Return a non-zero value to indicate that the files are different.
            Return False
        End If

        ' Read and compare a byte from each file until either a
        ' non-matching set of bytes is found or until the end of
        ' file1 is reached.
        Do
            ' Read one byte from each file.
            file1byte = fs1.ReadByte()
            file2byte = fs2.ReadByte()
        Loop While ((file1byte = file2byte) And (file1byte <> -1))

        ' Close the files.
        fs1.Close()
        fs2.Close()

        ' Return the success of the comparison. "file1byte" is
        ' equal to "file2byte" at this point only if the files are 
        ' the same.
        Return ((file1byte - file2byte) = 0)
    End Function
    Private Function colorExist(ByVal colorCode As String, ByVal formulaColorTab() As FormulaColor) As Boolean
        Dim i As Integer
        colorExist = False
        For i = 0 To formulaColorTab.Length - 1
            If getColorById(formulaColorTab(i).id_color).colorCode.Trim = colorCode.Trim Then
                colorExist = True
                Exit For
            End If
        Next

    End Function

    Private Function colorExistByIdColor(ByVal idColor As Integer, ByVal formulaColorTab() As FormulaColor) As Boolean
        Dim i As Integer
        colorExistByIdColor = False
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color = idColor Then
                colorExistByIdColor = True
                Exit For
            End If
        Next

    End Function

    Private Function getOtherColors(ByVal formulaColorTab() As FormulaColor) As ArrayList
        Dim i As Integer
        Dim array As New ArrayList

        For i = 0 To formulaColorTab.Length - 1
            If getColorById(formulaColorTab(i).id_color).colorCode.Trim <> "2019" Then
                If getColorById(formulaColorTab(i).id_color).colorCode.Trim <> "2960" Then
                    If getColorById(formulaColorTab(i).id_color).colorCode.Trim <> "2980" Then
                        If getColorById(formulaColorTab(i).id_color).colorCode.Trim <> "2920" Then
                            If getColorById(formulaColorTab(i).id_color).colorCode.Trim <> "2002" Then
                                array.Add(getColorById(formulaColorTab(i).id_color).colorCode.Trim)
                                MsgBox((getColorById(formulaColorTab(i).id_color).colorCode.Trim))
                            End If
                        End If
                    End If
                End If
            End If
        Next
        Return array
    End Function
    Private Function removeColor(ByVal colorCode As String, ByVal formulaColorTab() As FormulaColor) As FormulaColor()
        Dim i As Integer
        Dim MyArray As New ArrayList
        For i = 0 To formulaColorTab.Length - 1
            If getColorById(formulaColorTab(i).id_color).colorCode.Trim <> colorCode.Trim Then
                MyArray.Add(formulaColorTab(i))
            End If
        Next
        Return DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
    End Function
    Public Function replaceInColor(ByVal formulaColorTab As FormulaColor(), ByVal oldColor As String, ByVal newColor As String, ByVal rate As Decimal) As FormulaColor()
        Dim qtyOfWhite As Decimal = 0
        Dim qtyTotal As Decimal = 0
        For i = 0 To formulaColorTab.Length - 1
            If getColorById(formulaColorTab(i).id_color).colorCode.Trim = "2019" Then
                qtyOfWhite = qtyOfWhite + formulaColorTab(i).quantite
            End If

            qtyTotal = qtyTotal + formulaColorTab(i).quantite
        Next

        For i = 0 To formulaColorTab.Length - 1
            If getColorById(formulaColorTab(i).id_color).colorCode.Trim = oldColor.Trim Then
                Dim idNewColor As Long = getColors("Where colorCode='" & newColor & "'")(0).id_color
                formulaColorTab(i).id_color = idNewColor
                formulaColorTab(i).quantite = formulaColorTab(i).quantite * 1100 * rate / qtyOfWhite
                Exit For
            End If
        Next
        Return formulaColorTab
    End Function

    Public Function renderEquation(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        Dim qtyOfWhite As Decimal = 0
        Dim qtyTotal As Decimal = 0
        Dim qtyElse As Decimal = 0
        Dim newWhite As Decimal = 0
        For i = 0 To formulaColorTab.Length - 1
            If getColorById(formulaColorTab(i).id_color).colorCode.Trim = "2019" Then
                qtyOfWhite = qtyOfWhite + formulaColorTab(i).quantite
            End If
            qtyTotal = qtyTotal + formulaColorTab(i).quantite
        Next
        qtyElse = qtyTotal - qtyOfWhite
        For i = 0 To formulaColorTab.Length - 1
            newWhite = 1100 - qtyTotal + qtyOfWhite
        Next



        For i = 0 To formulaColorTab.Length - 1
            If getColorById(formulaColorTab(i).id_color).colorCode.Trim = "2019" Then
                Dim idNewColor As Long = getColors("Where colorCode='2019'")(0).id_color
                formulaColorTab(i).quantite = newWhite
                Exit For
            End If
        Next
        Return formulaColorTab

    End Function
    Public Function applyEquation(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        If formulaColorTab Is Nothing Then
            Return formulaColorTab
        Else
            If formulaColorTab.Length = 0 Then
                Return formulaColorTab
            End If
        End If
        Dim otherColors As ArrayList
        Dim i As Integer
        otherColors = getOtherColors(formulaColorTab)
        For i = 0 To otherColors.Count - 1
            formulaColorTab = replaceInColor(formulaColorTab, otherColors(i), otherColors(i), 1)

        Next
        If colorExist("2002", formulaColorTab) And colorExist("2019", formulaColorTab) Then
            Dim exist As Boolean = False
            If colorExist("2960", formulaColorTab) Then
                formulaColorTab = replaceInColor(formulaColorTab, "2960", "2060", 0.08)
                exist = True
            End If
            If colorExist("2980", formulaColorTab) Then
                formulaColorTab = replaceInColor(formulaColorTab, "2980", "2580", 0.06)
                exist = True
            End If
            If colorExist("2920", formulaColorTab) Then
                formulaColorTab = replaceInColor(formulaColorTab, "2920", "2025", 0.1)
                exist = True
            End If
            If exist Then
                formulaColorTab = removeColor("2002", formulaColorTab)
            End If




        End If

        Return formulaColorTab
    End Function

    Public Function applyEquation3(ByVal formulaColorTabReturn As FormulaColor()) As FormulaColor()
        If formulaColorTabReturn Is Nothing Then
            Return formulaColorTabReturn
        End If
        If formulaColorTabReturn.Length = 0 Then
            Return formulaColorTabReturn
        End If
        Dim formulaColorTab() As FormulaColor
        ReDim formulaColorTab(formulaColorTabReturn.Length - 1)
        Dim j As Integer
        For j = 0 To formulaColorTab.Length - 1
            formulaColorTab(j) = New FormulaColor
            formulaColorTab(j).id_color = formulaColorTabReturn(j).id_color
            formulaColorTab(j).quantite = formulaColorTabReturn(j).quantite
        Next


        'Dim colornotfound As Boolean = False
        Dim colorsnotfound As String = ""
        Dim listOfColorCodeToUse As String()
        ReDim listOfColorCodeToUse(0)
        listOfColorCodeToUse(0) = "4002"
        'find number to multiply by in order to empty the "4010"
        Dim i As Integer
        Dim totalQty As Decimal = 0
        Dim qty4002 As Decimal = 0
        Dim numberToMultiplyBy As Decimal = 0
        For i = 0 To formulaColorTab.Length - 1
            totalQty = totalQty + formulaColorTab(i).quantite
            Dim curColor As Color = getColorById(formulaColorTab(i).id_color)

            If curColor.colorCode = "4002" Then
                qty4002 = qty4002 + formulaColorTab(i).quantite
            End If

        Next
        If qty4002 = 0 Then
            MsgBox("Formula could not be saved because color 4002 has Zero quantity or does not exist in this formula", MsgBoxStyle.Critical)
            Return Nothing
        End If
        If totalQty = qty4002 Then
            Return formulaColorTabReturn 'can't apply equation, 
        End If

        numberToMultiplyBy = totalQty / (totalQty - qty4002)

        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorById(formulaColorTab(i).id_color)
            Dim oldCodeColor As Long = CType(curColor.colorCode, Long)
            Dim newColorCode As String
            Dim newQty As Decimal

            If oldCodeColor = 4960 Then
                newQty = formulaColorTab(i).quantite * 0.06
                newColorCode = "2060"
            Else
                If oldCodeColor = 4920 Then
                    newQty = formulaColorTab(i).quantite * 0.06
                    newColorCode = "2025"
                Else
                    If oldCodeColor <> 4002 Then
                        newQty = formulaColorTab(i).quantite
                        newColorCode = oldCodeColor - 2000
                    Else
                        newColorCode = oldCodeColor
                    End If
                End If
            End If
            Dim newColor() As Color = getColors(" WHERE colorCode='" & newColorCode & "'")

            If Not newColor Is Nothing Then
                If newColor.Length = 0 Then
                    newColor = Nothing 'ntek
                End If
            End If

            If newColor Is Nothing Then
                colorsnotfound = colorsnotfound & newColorCode & " "
            Else
                formulaColorTab(i).quantite = newQty
                formulaColorTab(i).id_color = newColor(0).id_color
            End If

        Next


        If colorsnotfound <> "" Then
            MsgBox("Formula could not be saved and equation was not applied because the following colors doesn't exist:" & vbNewLine & colorsnotfound, MsgBoxStyle.Critical)
            Return Nothing
        Else
            'delete "4002" from formula 
            Dim MyArray As New ArrayList
            Dim newTotalQty As Decimal = 0
            For i = 0 To formulaColorTab.Length - 1
                Dim curColor As Color = getColorById(formulaColorTab(i).id_color)
                If curColor.colorCode.Trim <> "4002" Then
                    MyArray.Add(formulaColorTab(i))
                    newTotalQty = newTotalQty + formulaColorTab(i).quantite
                End If
            Next


            formulaColorTab = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())

            For i = 0 To formulaColorTab.Length - 1
                formulaColorTab(i).quantite = formulaColorTab(i).quantite * totalQty / newTotalQty
            Next

            Return formulaColorTab

        End If

    End Function
    Public Function applyEquation3Old(ByVal formulaColorTabReturn As FormulaColor()) As FormulaColor()
        Dim formulaColorTab() As FormulaColor
        ReDim formulaColorTab(formulaColorTabReturn.Length - 1)
        Dim j As Integer
        For j = 0 To formulaColorTab.Length - 1
            formulaColorTab(j) = New FormulaColor
            formulaColorTab(j).id_color = formulaColorTabReturn(j).id_color
            formulaColorTab(j).quantite = formulaColorTabReturn(j).quantite
        Next


        'Dim colornotfound As Boolean = False
        Dim colorsnotfound As String = ""
        Dim listOfColorCodeToUse As String()
        ReDim listOfColorCodeToUse(0)
        listOfColorCodeToUse(0) = "4002"
        'find number to multiply by in order to empty the "4010"
        Dim i As Integer
        Dim totalQty As Decimal = 0
        Dim qty4002 As Decimal = 0
        Dim numberToMultiplyBy As Decimal = 0
        For i = 0 To formulaColorTab.Length - 1
            totalQty = totalQty + formulaColorTab(i).quantite
            Dim curColor As Color = getColorById(formulaColorTab(i).id_color)

            If curColor.colorCode = "4002" Then
                qty4002 = qty4002 + formulaColorTab(i).quantite
            End If

        Next
        If qty4002 = 0 Then
            MsgBox("Formula could not be saved because color 4002 has Zero quantity or does not exist in this formula", MsgBoxStyle.Critical)
            Return Nothing
        End If
        numberToMultiplyBy = totalQty / (totalQty - qty4002)

        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorById(formulaColorTab(i).id_color)
            Dim oldCodeColor As Long = CType(curColor.colorCode, Long)
            If oldCodeColor <> "4002" Then
                Dim newCodeColor = oldCodeColor - 2000
                Dim newColor() As Color = getColors(" WHERE colorCode='" & newCodeColor & "'")
                If Not newColor Is Nothing Then
                    If newColor.Length = 0 Then
                        newColor = Nothing 'ntek
                    End If
                End If
                If newColor Is Nothing Then
                    colorsnotfound = colorsnotfound & newCodeColor & " "
                Else
                    formulaColorTab(i).id_color = newColor(0).id_color
                    Dim curQty As Decimal = formulaColorTab(i).quantite
                    'find the color to use, the one that contains enough qty
                    Dim colorToUse As Color = Nothing
                    Dim k As Integer
                    For k = 0 To listOfColorCodeToUse.Length - 1
                        Dim index As Integer = findIndexOfColorToUse(formulaColorTab, listOfColorCodeToUse(k))
                        If index <> -1 Then 'colorToUse exist, else continue to next colorToUse
                            Dim qty As Decimal = formulaColorTab(index).quantite
                            If qty >= curQty Then 'colorToUse has enoughQty, else continue to next colorToUse
                                formulaColorTab(i).quantite = curQty * numberToMultiplyBy 'double the qty of the colorCode to replace
                                'formulaColorTab(index).quantite = formulaColorTab(index).quantite - curQty 'substract the qty of the colorCode to replace
                            End If
                        End If
                    Next
                End If
            End If
        Next


        If colorsnotfound <> "" Then
            MsgBox("Formula could not be saved and equation was not applied because the following colors doesn't exist:" & vbNewLine & colorsnotfound, MsgBoxStyle.Critical)
            Return Nothing
        Else
            'delete "4010" from formula
            Dim MyArray As New ArrayList
            For i = 0 To formulaColorTab.Length - 1
                Dim curColor As Color = getColorById(formulaColorTab(i).id_color)
                If curColor.colorCode.Trim <> "4002" Then
                    MyArray.Add(formulaColorTab(i))
                End If
            Next
            Return DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())

        End If

    End Function
    Private Function findIndexOfColorToUse(ByVal formulaColorTab As FormulaColor(), ByVal listOfColorCodeToUse As String) As Integer
        Dim index As Integer = -1
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorById(formulaColorTab(i).id_color)
            If curColor.colorCode.Trim = listOfColorCodeToUse.Trim Then
                index = i
                Exit For
            End If
        Next
        Return index
    End Function

    Private colorsAddedAutomaticaly As New ArrayList
    Private Function modifyQtysLS69LS29(ByVal formulaColorTab As FormulaColor(), ByVal percCurrent As Double, ByVal colorCodeCurrent As String, ByVal percNew As Double, ByVal colorCodeNew As String) As FormulaColor()
        If colorsAddedAutomaticaly.Contains(colorCodeCurrent) Then
            Return formulaColorTab
        End If

        Dim idColor As Integer = getColorIdByCode(colorCodeCurrent)
        'getColors(" where colorCode = '" & colorCodeCurrent & "'")(0).id_color
        Dim i As Integer
        Dim found As Boolean = False
        Dim intiQty As Decimal
        Dim idFormula As Integer = -1
        Dim idUnit As Integer = -1
        'Dim MyArray As New ArrayList
        For i = 0 To formulaColorTab.Length - 1
            idFormula = formulaColorTab(i).id_formula
            idUnit = formulaColorTab(i).id_Unit
            If idColor = formulaColorTab(i).id_color Then
                intiQty = formulaColorTab(i).quantite
                If intiQty < 30 Then
                    Return formulaColorTab
                End If
                formulaColorTab(i).quantite = formulaColorTab(i).quantite + formulaColorTab(i).quantite * percCurrent / 100
                found = True
            End If
            'MyArray.Add(formulaColorTab(i))
        Next
        If colorCodeNew <> "" And found Then
            Dim idColorNew As Integer = getColorIdByCode(colorCodeNew)
            'getColors(" where colorCode = '" & colorCodeNew & "'")(0).id_color

            'get the newPerc of the newColor
            Dim foundNew As Boolean = False
            Dim qtyToAdd As Decimal = 0
            For i = 0 To formulaColorTab.Length - 1
                If idColorNew = formulaColorTab(i).id_color Then
                    qtyToAdd = intiQty * percNew / 100
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + qtyToAdd
                    foundNew = True
                End If
                'MyArray.Add(formulaColorTab(i))
            Next
            If Not foundNew Then
                Dim myArray As New ArrayList
                'add the new color to the formula
                For i = 0 To formulaColorTab.Length - 1
                    myArray.Add(formulaColorTab(i))
                Next
                Dim newFormulaColor As New FormulaColor
                newFormulaColor.id_formula = idFormula
                newFormulaColor.id_Unit = idUnit
                newFormulaColor.id_color = idColorNew
                newFormulaColor.quantite = intiQty * percNew / 100
                myArray.Add(newFormulaColor)
                colorsAddedAutomaticaly.Add(colorCodeNew)

                formulaColorTab = DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If

        End If

        'remove first color
        Dim myArrayLast As New ArrayList
        'add the new color to the formula
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color <> idColor Then
                myArrayLast.Add(formulaColorTab(i))
            End If

        Next

        Return DirectCast(myArrayLast.ToArray(GetType(FormulaColor)), FormulaColor())
    End Function
    Public Function clearLsEquation(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        If formulaColorTab Is Nothing Then
            Return formulaColorTab
        Else
            If formulaColorTab.Length = 0 Then
                Return formulaColorTab
            End If
        End If
        Dim intiFormulaQty As Decimal = getTotalQty(formulaColorTab)
        formulaColorTab = modifyQtysLS69LS29(formulaColorTab, 0, "69", 8, "67")

        formulaColorTab = modifyQtysLS69LS29(formulaColorTab, 0, "29", 15, "20")

        colorsAddedAutomaticaly = New ArrayList

        formulaColorTab = regleDeTrois(formulaColorTab, intiFormulaQty)


        Return formulaColorTab
    End Function
    Public Function applyEquation4503(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        If formulaColorTab Is Nothing Then
            Return formulaColorTab
        Else
            If formulaColorTab.Length = 0 Then
                Return formulaColorTab
            End If
        End If

        Dim index4503 As Integer = findIndexOfColorToUse(formulaColorTab, "4503")
        If index4503 = -1 Then
            Return formulaColorTab
        End If


        Dim qty4503 As Double = formulaColorTab(index4503).quantite
        Dim idColor4403 As Integer = getColorIdByCode("4403")
        Dim idColor4508 As Integer = getColorIdByCode("4508")
        Dim index4403 As Integer = findIndexOfColorToUse(formulaColorTab, "4403")
        Dim index4508 As Integer = findIndexOfColorToUse(formulaColorTab, "4508")

        If idColor4403 = -1 Or idColor4508 = -1 Then
            Return formulaColorTab
        End If


        Dim myArray As New ArrayList
        'add the new color to the formula
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color <> formulaColorTab(index4503).id_color Then
                If index4403 = i Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + (qty4503 / 2)
                End If

                If index4508 = i Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + (qty4503 / 2)
                End If

                myArray.Add(formulaColorTab(i))
            End If
        Next

        If index4403 = -1 Then
            Dim newFormulaColor4403 As New FormulaColor
            newFormulaColor4403.id_formula = formulaColorTab(index4503).id_formula
            newFormulaColor4403.id_Unit = formulaColorTab(index4503).id_Unit
            newFormulaColor4403.id_color = idColor4403
            newFormulaColor4403.quantite = qty4503 / 2
            myArray.Add(newFormulaColor4403)
        End If

        If index4508 = -1 Then
            Dim newFormulaColor4508 As New FormulaColor
            newFormulaColor4508.id_formula = formulaColorTab(index4503).id_formula
            newFormulaColor4508.id_Unit = formulaColorTab(index4503).id_Unit
            newFormulaColor4508.id_color = idColor4508
            newFormulaColor4508.quantite = qty4503 / 2
            myArray.Add(newFormulaColor4508)
        End If



        formulaColorTab = DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())

        Return formulaColorTab
    End Function

    Public Function applyEquation4761(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        If formulaColorTab Is Nothing Then
            Return formulaColorTab
        Else
            If formulaColorTab.Length = 0 Then
                Return formulaColorTab
            End If
        End If

        Dim index4761 As Integer = findIndexOfColorToUse(formulaColorTab, "4761")
        If index4761 = -1 Then
            Return formulaColorTab
        End If


        Dim qty4761 As Double = formulaColorTab(index4761).quantite
        Dim idColor4063 As Integer = getColorIdByCode("4063")
        Dim idColor4561 As Integer = getColorIdByCode("4561")
        Dim index4063 As Integer = findIndexOfColorToUse(formulaColorTab, "4063")
        Dim index4561 As Integer = findIndexOfColorToUse(formulaColorTab, "4561")

        If idColor4063 = -1 Or idColor4561 = -1 Then
            Return formulaColorTab
        End If


        Dim myArray As New ArrayList
        'add the new color to the formula
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color <> formulaColorTab(index4761).id_color Then

                If index4063 = i Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + (qty4761 * 0.6)
                End If

                If index4561 = i Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + (qty4761 * 0.4)
                End If


                myArray.Add(formulaColorTab(i))
            End If
        Next
        If index4063 = -1 Then
            Dim newFormulaColor4063 As New FormulaColor
            newFormulaColor4063.id_formula = formulaColorTab(index4761).id_formula
            newFormulaColor4063.id_Unit = formulaColorTab(index4761).id_Unit
            newFormulaColor4063.id_color = idColor4063
            newFormulaColor4063.quantite = qty4761 * 0.6
            myArray.Add(newFormulaColor4063)
        End If

        If index4561 = -1 Then
            Dim newFormulaColor4561 As New FormulaColor
            newFormulaColor4561.id_formula = formulaColorTab(index4761).id_formula
            newFormulaColor4561.id_Unit = formulaColorTab(index4761).id_Unit
            newFormulaColor4561.id_color = idColor4561
            newFormulaColor4561.quantite = qty4761 * 0.4
            myArray.Add(newFormulaColor4561)
        End If

        formulaColorTab = DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())

        Return formulaColorTab
    End Function

    Public Function applyEquation4001(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        If formulaColorTab Is Nothing Then
            Return formulaColorTab
        Else
            If formulaColorTab.Length = 0 Then
                Return formulaColorTab
            End If
        End If
        Dim index4001 As Integer = findIndexOfColorToUse(formulaColorTab, "4001")
        If index4001 = -1 Then
            Return formulaColorTab
        End If
        Dim intiFormulaQty As Decimal = getTotalQty(formulaColorTab)

        Dim qty4001 As Double = formulaColorTab(index4001).quantite
        Dim idColor4111 As Integer = getColorIdByCode("4111")
        Dim index4111 As Integer = findIndexOfColorToUse(formulaColorTab, "4111")
        If idColor4111 = -1 Then
            Return formulaColorTab
        End If


        Dim myArray As New ArrayList
        'add the new color to the formula
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color <> formulaColorTab(index4001).id_color Then
                If index4111 = i Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + (qty4001 * 1.5)
                End If

                myArray.Add(formulaColorTab(i))
            End If
        Next
        If index4111 = -1 Then
            Dim newFormulaColor4111 As New FormulaColor
            newFormulaColor4111.id_formula = formulaColorTab(index4001).id_formula
            newFormulaColor4111.id_Unit = formulaColorTab(index4001).id_Unit
            newFormulaColor4111.id_color = idColor4111
            newFormulaColor4111.quantite = qty4001 * 1.5
            myArray.Add(newFormulaColor4111)
        End If



        formulaColorTab = DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())

        formulaColorTab = regleDeTrois(formulaColorTab, intiFormulaQty)

        Return formulaColorTab
    End Function

    Public Function majdiPerc(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        If formulaColorTab Is Nothing Then
            Return formulaColorTab
        Else
            If formulaColorTab.Length = 0 Then
                Return formulaColorTab
            End If
        End If

        Dim intiFormulaQty As Decimal = getTotalQty(formulaColorTab)

        formulaColorTab = modifyQtys(formulaColorTab, -40, "4201", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, -20, "4014", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, 0, "4018", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4019", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4061", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 50, "4110", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, -0, "4510", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4517", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4518", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4519", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4560", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -40, "4920", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -60, "4940", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -30, "4941", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4960", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -40, "4980", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, -10, "4030", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4040", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 80, "4041", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -15, "4047", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4050", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -25, "4051", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -30, "4060", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4063", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, 50, "4070", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4074", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -10, "4081", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -10, "4082", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4084", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4085", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4162", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 50, "4188", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -10, "4283", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, -20, "4440", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -10, "4580", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4582", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4640", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 200, "4681", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4882", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, 90, "4025", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -25, "4080", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4561", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4340", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, 50, "4111", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4211", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4411", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4425", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4436", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 10, "4511", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4525", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 25, "4526", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4528", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4711", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 15, "4910", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, 10, "4091", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 500, "4101", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 200, "4206", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 10, "4581", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 200, "4704", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4705", 0, "")

        formulaColorTab = modifyQtys(formulaColorTab, 100, "4107", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4306", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 50, "4307", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -10, "4308", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -15, "4403", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -40, "4405", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4407", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4504", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4507", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, -10, "4508", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4605", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 200, "4606", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4607", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4707", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4708", 0, "")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4805", 0, "")



        formulaColorTab = modifyQtys(formulaColorTab, -20, "4811", 2, "4403")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4017", 20, "4517")
        formulaColorTab = modifyQtys(formulaColorTab, 0, "4026", 30, "4025")
        formulaColorTab = modifyQtys(formulaColorTab, -20, "4117", 20, "4517")
        colorsAddedAutomaticaly = New ArrayList

        formulaColorTab = regleDeTrois(formulaColorTab, intiFormulaQty)


        Return formulaColorTab
    End Function
    Private Function getTotalQty(ByVal formulaColorTab As FormulaColor()) As Decimal
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            getTotalQty = getTotalQty + formulaColorTab(i).quantite
        Next
    End Function
    Private Function regleDeTrois(ByVal formulaColorTab As FormulaColor(), ByVal intiFormulaQty As Decimal) As FormulaColor()
        Dim i As Integer
        Dim newFormulaQty As Decimal = getTotalQty(formulaColorTab)
        If newFormulaQty > 0 Then
            For i = 0 To formulaColorTab.Length - 1
                formulaColorTab(i).quantite = intiFormulaQty * formulaColorTab(i).quantite / newFormulaQty
            Next
        End If

        Return formulaColorTab
    End Function
    Private Function getColorIdByCode(ByVal colorCode As String) As Integer
        Dim result As Integer = -1
        Dim i As Integer
        For i = 0 To colors.Length - 1
            If colorCode.ToLower = colors(i).colorCode.ToLower Then
                result = colors(i).id_color
            End If
        Next
        Return result
    End Function

    Public Function getColorByIdFromArray(ByVal idColor As Integer, Optional ByVal specificConString As String = Nothing) As Color
        Dim allColorsToUse As Color()
        If specificConString Is Nothing Then
            allColorsToUse = colors
        Else
            allColorsToUse = colorsFromSpecificDB
        End If

        Dim result As Color = Nothing
        Dim i As Integer
        For i = 0 To colors.Length - 1
            If idColor = colors(i).id_color Then
                result = colors(i)
            End If
        Next
        Return result

    End Function

    Private Function modifyQtys(ByVal formulaColorTab As FormulaColor(), ByVal percCurrent As Double, ByVal colorCodeCurrent As String, ByVal percNew As Double, ByVal colorCodeNew As String) As FormulaColor()
        If colorsAddedAutomaticaly.Contains(colorCodeCurrent) Then
            Return formulaColorTab
        End If

        Dim idColor As Integer = getColorIdByCode(colorCodeCurrent)
        Dim i As Integer
        Dim found As Boolean = False
        Dim intiQty As Decimal
        Dim idFormula As Integer = -1
        Dim idUnit As Integer = -1
        'Dim MyArray As New ArrayList
        For i = 0 To formulaColorTab.Length - 1
            idFormula = formulaColorTab(i).id_formula
            idUnit = formulaColorTab(i).id_Unit
            If idColor = formulaColorTab(i).id_color Then
                intiQty = formulaColorTab(i).quantite
                formulaColorTab(i).quantite = formulaColorTab(i).quantite + formulaColorTab(i).quantite * percCurrent / 100
                found = True
            End If
            'MyArray.Add(formulaColorTab(i))
        Next
        If colorCodeNew <> "" And found Then
            Dim idColorNew As Integer = getColorIdByCode(colorCodeNew) 'getColors(" where colorCode = '" & colorCodeNew & "'")(0).id_color
            'getColors(" where colorCode = '" & colorCodeNew & "'")(0).id_color

            'get the newPerc of the newColor
            Dim foundNew As Boolean = False
            Dim qtyToAdd As Decimal = 0
            For i = 0 To formulaColorTab.Length - 1
                If idColorNew = formulaColorTab(i).id_color Then
                    qtyToAdd = intiQty * percNew / 100
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + qtyToAdd
                    foundNew = True
                End If
                'MyArray.Add(formulaColorTab(i))
            Next
            If Not foundNew Then
                Dim myArray As New ArrayList
                'add the new color to the formula
                For i = 0 To formulaColorTab.Length - 1
                    myArray.Add(formulaColorTab(i))
                Next
                Dim newFormulaColor As New FormulaColor
                newFormulaColor.id_formula = idFormula
                newFormulaColor.id_Unit = idUnit
                newFormulaColor.id_color = idColorNew
                newFormulaColor.quantite = intiQty * percNew / 100
                myArray.Add(newFormulaColor)
                colorsAddedAutomaticaly.Add(colorCodeNew)
                Return DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If

        End If
        Return formulaColorTab
    End Function
    Public Function eq15perc4201(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        If formulaColorTab Is Nothing Then
            Return formulaColorTab
        End If
        If formulaColorTab.Length = 0 Then
            Return formulaColorTab
        End If
        Dim index4201 As Integer = findIndexOfColorToUse(formulaColorTab, "4201")
        If index4201 = -1 Then
            Return formulaColorTab
        End If
        Dim initTotalQty As Double = 0
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            initTotalQty += formulaColorTab(i).quantite
        Next
        Dim init4201Qty As Double = formulaColorTab(index4201).quantite
        Dim final4201Qty As Double = init4201Qty * 0.85 'decrease 15% the qty of 4201
        formulaColorTab(index4201).quantite = final4201Qty

        Dim finalTotalQty As Double = initTotalQty - (init4201Qty - final4201Qty)


        'regle de trois
        For i = 0 To formulaColorTab.Length - 1
            Dim curQty As Double = formulaColorTab(i).quantite
            formulaColorTab(i).quantite = curQty * initTotalQty / finalTotalQty
        Next

        Return formulaColorTab
    End Function
    Public Function isCouche(ByVal fname As String) As Boolean
        isCouche = False
        If fname.ToLower.Contains("(couche)") Then
            isCouche = True
        End If
        If fname.ToLower.Contains("(couche 1)") Then
            isCouche = True
        End If
        If fname.ToLower.Contains("(couche 2)") Then
            isCouche = True
        End If
        If fname.ToLower.Contains("(sous-couche)") Then
            isCouche = True
        End If
    End Function

    Public Function inListOf4010(ByVal colorCode As String) As Boolean
        Dim listOf4010(25) As String
        listOf4010(0) = "4111"
        listOf4010(1) = "4511"
        listOf4010(2) = "4526"
        listOf4010(3) = "4811"
        listOf4010(4) = "4910"
        listOf4010(5) = "4107"
        listOf4010(6) = "4306"
        listOf4010(7) = "4307"
        listOf4010(8) = "4308"
        listOf4010(9) = "4403"
        listOf4010(10) = "4405"
        listOf4010(11) = "4407"
        listOf4010(12) = "4504"
        listOf4010(13) = "4507"
        listOf4010(14) = "4508"
        listOf4010(15) = "4606"
        listOf4010(16) = "4708"
        listOf4010(17) = "4805"
        listOf4010(18) = "4091"
        listOf4010(19) = "4101"
        listOf4010(20) = "4206"
        listOf4010(21) = "4581"
        listOf4010(22) = "4605"
        listOf4010(23) = "4704"
        listOf4010(24) = "4705"

        Dim i As Integer = 0
        For i = 0 To listOf4010.Length
            If listOf4010(i) = colorCode Then
                Return True
            End If
        Next

        Return False
    End Function
    Public Function applyEquation4010(ByVal formulaColorTab As FormulaColor(), ByVal nameFormula As String) As FormulaColor()
        Dim idColor4010 As Integer = getColorIdByCode("4010")
        Dim idColor4111 As Integer = getColorIdByCode("4111")
        Dim idColor4091 As Integer = getColorIdByCode("4091")
        If formulaColorTab Is Nothing Then
            Return Nothing
        End If

        If formulaColorTab.Length = 0 Then
            Return Nothing
        End If

        Dim i As Integer
        'check if this equation should be applied

        'check if its couche and having 4111 or 4091
        Dim coucheFormula As Boolean = isCouche(nameFormula)

        'check if it contains 4111 or 4091, and if it contains4010
        Dim contains4114091 As Boolean = False
        Dim contains4010 As Boolean = False
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color = idColor4111 Or formulaColorTab(i).id_color = idColor4091 Then
                contains4114091 = True
            End If
            If formulaColorTab(i).id_color = idColor4010 Then
                contains4010 = True
            End If
        Next
        If coucheFormula And contains4114091 Then
            Return formulaColorTab 'do nothing
        End If
        ''''''''''''''''''''''''''''''''''''''
        If Not contains4010 Then
            Return formulaColorTab 'do nothing
        End If
        ''''''''''''''''''''''''''''''''''''''

        Dim havePearlOrXyl As Boolean = False
        For i = 0 To formulaColorTab.Length - 1
            Dim colorTmp As Color = getColorById(formulaColorTab(i).id_color)
            If inListOf4010(colorTmp.colorCode) Then
                havePearlOrXyl = True
                Exit For
            End If
        Next
        If Not havePearlOrXyl Then
            Return formulaColorTab 'do nothing
        End If
        '''''''''''''''''''''''''''''''''''''''''

        'find number to multiply by in order to empty the "4010"

        Dim totalQty As Decimal = 0
        Dim substractTotal As Decimal = 0
        For i = 0 To formulaColorTab.Length - 1
            totalQty = totalQty + formulaColorTab(i).quantite

            Dim currendIdColor As Integer = formulaColorTab(i).id_color
            If idColor4010 = currendIdColor Then
                substractTotal = formulaColorTab(i).quantite / 2
                formulaColorTab(i).quantite = formulaColorTab(i).quantite / 2

                Exit For
            End If

        Next
        If totalQty = 0 Then
            Return formulaColorTab 'do nothing
        End If
        Dim newTotal As Decimal = 0
        newTotal = totalQty - substractTotal
        Dim rate As Decimal = totalQty / newTotal

        'convert to original total
        For i = 0 To formulaColorTab.Length - 1
            formulaColorTab(i).quantite = formulaColorTab(i).quantite * rate
        Next
        Return formulaColorTab
    End Function
    Public Function swapColorsByName(ByVal formulaTab() As Formula, ByVal valDown As String, ByVal valUp As String)
        'fix sous-couche before couche
        Dim lastIndexSwaped As Integer = -2
        For i = 0 To formulaTab.Length - 1
            'swap sous-couche with couche
            If i < formulaTab.Length - 1 And i > lastIndexSwaped + 1 Then
                Dim nameFormula As String = formulaTab(i).name_formula
                If nameFormula.ToLower.Contains(valDown) And Not nameFormula.ToLower.Contains(valUp) Then
                    Dim nameFormulaPlus1 As String = formulaTab(i + 1).name_formula
                    If nameFormulaPlus1.ToLower.Contains(valUp) Then
                        nameFormula = nameFormula.ToLower
                        nameFormulaPlus1 = nameFormulaPlus1.ToLower

                        nameFormula = nameFormula.Substring(0, nameFormula.IndexOf(valDown))
                        nameFormulaPlus1 = nameFormulaPlus1.Substring(0, nameFormulaPlus1.IndexOf(valUp))
                        If nameFormula = nameFormulaPlus1 Then
                            'do the swap
                            Dim tempFormula As Formula = formulaTab(i)
                            formulaTab(i) = formulaTab(i + 1)
                            formulaTab(i + 1) = tempFormula
                            lastIndexSwaped = i
                        End If
                    End If
                End If

            End If
        Next
        Return formulaTab
    End Function


    Public Function BC_4_conversions(ByVal formulaColorTab As FormulaColor()) As FormulaColor()


        Dim idColor4517O As Integer = getColorIdByCode("4517O")
        If colorExistByIdColor(idColor4517O, formulaColorTab) Then
            Return formulaColorTab
        End If



        Dim intiFormulaQty As Decimal = getTotalQty(formulaColorTab)

        '1g of 4047o ==> 1.25g of 4047
        'xg of 4047o ==> x * 1.25g

        formulaColorTab = replaceColorsInFormula4030O(formulaColorTab)
        formulaColorTab = replaceColorsInFormula4040(formulaColorTab)
        formulaColorTab = replaceColorsInFormula4047O(formulaColorTab)
        formulaColorTab = replaceColorsInFormula4120(formulaColorTab)

        formulaColorTab = regleDeTrois(formulaColorTab, intiFormulaQty)

        Return formulaColorTab
    End Function

    Private Function replaceColorsInFormula4030O(ByVal formulaColorTab As FormulaColor()) As FormulaColor()

        Dim idColor4030O As Integer = getColorIdByCode("4030O")

        'getColors(" where colorCode = '" & colorCodeCurrent & "'")(0).id_color
        Dim i As Integer
        Dim found4030O As Boolean = False
        Dim intiQty4030O As Decimal
        Dim newQty4030 As Decimal
        Dim newQty4640 As Decimal
        Dim idFormula As Integer = -1
        Dim idUnit As Integer = -1
        'Dim MyArray As New ArrayList
        For i = 0 To formulaColorTab.Length - 1
            idFormula = formulaColorTab(i).id_formula
            idUnit = formulaColorTab(i).id_Unit
            If idColor4030O = formulaColorTab(i).id_color Then
                intiQty4030O = formulaColorTab(i).quantite
                newQty4030 = intiQty4030O * 0.9
                newQty4640 = intiQty4030O * 0.1
                found4030O = True
            End If
            'MyArray.Add(formulaColorTab(i))
        Next
        If found4030O Then
            Dim idColorNew4030 As Integer = getColorIdByCode("4030")
            'getColors(" where colorCode = '" & colorCodeNew & "'")(0).id_color

            'get the newPerc of the newColor
            Dim foundNew As Boolean = False
            For i = 0 To formulaColorTab.Length - 1
                If idColorNew4030 = formulaColorTab(i).id_color Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + newQty4030
                    foundNew = True
                End If
                'MyArray.Add(formulaColorTab(i))
            Next
            If Not foundNew Then
                Dim myArray As New ArrayList
                'add the new color to the formula
                For i = 0 To formulaColorTab.Length - 1
                    myArray.Add(formulaColorTab(i))
                Next
                Dim newFormulaColor As New FormulaColor
                newFormulaColor.id_formula = idFormula
                newFormulaColor.id_Unit = idUnit
                newFormulaColor.id_color = idColorNew4030
                newFormulaColor.quantite = newQty4030
                myArray.Add(newFormulaColor)

                formulaColorTab = DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If
            foundNew = False

            Dim idColorNew4640 As Integer = getColorIdByCode("4640")
            'getColors(" where colorCode = '" & colorCodeNew & "'")(0).id_color

            'get the newPerc of the newColor
            For i = 0 To formulaColorTab.Length - 1
                If idColorNew4640 = formulaColorTab(i).id_color Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + newQty4640
                    foundNew = True
                End If
                'MyArray.Add(formulaColorTab(i))
            Next
            If Not foundNew Then
                Dim myArray As New ArrayList
                'add the new color to the formula
                For i = 0 To formulaColorTab.Length - 1
                    myArray.Add(formulaColorTab(i))
                Next
                Dim newFormulaColor As New FormulaColor
                newFormulaColor.id_formula = idFormula
                newFormulaColor.id_Unit = idUnit
                newFormulaColor.id_color = idColorNew4640
                newFormulaColor.quantite = newQty4640
                myArray.Add(newFormulaColor)

                formulaColorTab = DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If
        Else
            Return formulaColorTab
        End If

        Dim myArrayLast As New ArrayList
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color <> idColor4030O Then
                myArrayLast.Add(formulaColorTab(i))
            End If

        Next

        Return DirectCast(myArrayLast.ToArray(GetType(FormulaColor)), FormulaColor())


    End Function


    Private Function replaceColorsInFormula4040(ByVal formulaColorTab As FormulaColor()) As FormulaColor()

        Dim idColor4040 As Integer = getColorIdByCode("4040")
        'getColors(" where colorCode = '" & colorCodeCurrent & "'")(0).id_color
        Dim i As Integer
        Dim found4040 As Boolean = False
        Dim intiQty4040 As Decimal
        Dim newQty4040 As Decimal
        Dim idFormula As Integer = -1
        Dim idUnit As Integer = -1
        'Dim MyArray As New ArrayList
        For i = 0 To formulaColorTab.Length - 1
            idFormula = formulaColorTab(i).id_formula
            idUnit = formulaColorTab(i).id_Unit
            If idColor4040 = formulaColorTab(i).id_color Then
                intiQty4040 = formulaColorTab(i).quantite
                newQty4040 = intiQty4040 * 0.5
                found4040 = True
            End If
            'MyArray.Add(formulaColorTab(i))
        Next
        If found4040 Then
            Dim idColorNew4440 As Integer = getColorIdByCode("4440")
            'getColors(" where colorCode = '" & colorCodeNew & "'")(0).id_color

            'get the newPerc of the newColor
            Dim foundNew As Boolean = False
            For i = 0 To formulaColorTab.Length - 1
                If idColorNew4440 = formulaColorTab(i).id_color Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + newQty4040
                    foundNew = True
                End If
                'MyArray.Add(formulaColorTab(i))
            Next
            If Not foundNew Then
                Dim myArray As New ArrayList
                'add the new color to the formula
                For i = 0 To formulaColorTab.Length - 1
                    myArray.Add(formulaColorTab(i))
                Next
                Dim newFormulaColor As New FormulaColor
                newFormulaColor.id_formula = idFormula
                newFormulaColor.id_Unit = idUnit
                newFormulaColor.id_color = idColorNew4440
                newFormulaColor.quantite = newQty4040
                myArray.Add(newFormulaColor)

                formulaColorTab = DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If
        Else
            Return formulaColorTab
        End If

        'remove first color
        Dim myArrayLast As New ArrayList
        'add the new color to the formula
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color <> idColor4040 Then
                myArrayLast.Add(formulaColorTab(i))
            End If

        Next

        Return DirectCast(myArrayLast.ToArray(GetType(FormulaColor)), FormulaColor())


    End Function

    Private Function replaceColorsInFormula4120(ByVal formulaColorTab As FormulaColor()) As FormulaColor()

        Dim idColor4120 As Integer = getColorIdByCode("4120")
        'getColors(" where colorCode = '" & colorCodeCurrent & "'")(0).id_color
        Dim i As Integer
        Dim found4120 As Boolean = False
        Dim intiQty4120 As Decimal
        Dim newQty4120 As Decimal
        Dim idFormula As Integer = -1
        Dim idUnit As Integer = -1
        'Dim MyArray As New ArrayList
        For i = 0 To formulaColorTab.Length - 1
            idFormula = formulaColorTab(i).id_formula
            idUnit = formulaColorTab(i).id_Unit
            If idColor4120 = formulaColorTab(i).id_color Then
                intiQty4120 = formulaColorTab(i).quantite
                newQty4120 = intiQty4120 * 0.5
                found4120 = True
            End If
            'MyArray.Add(formulaColorTab(i))
        Next
        If found4120 Then
            Dim idColorNew4201 As Integer = getColorIdByCode("4201")
            'getColors(" where colorCode = '" & colorCodeNew & "'")(0).id_color

            'get the newPerc of the newColor
            Dim foundNew As Boolean = False
            For i = 0 To formulaColorTab.Length - 1
                If idColorNew4201 = formulaColorTab(i).id_color Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + newQty4120
                    foundNew = True
                End If
                'MyArray.Add(formulaColorTab(i))
            Next
            If Not foundNew Then
                Dim myArray As New ArrayList
                'add the new color to the formula
                For i = 0 To formulaColorTab.Length - 1
                    myArray.Add(formulaColorTab(i))
                Next
                Dim newFormulaColor As New FormulaColor
                newFormulaColor.id_formula = idFormula
                newFormulaColor.id_Unit = idUnit
                newFormulaColor.id_color = idColorNew4201
                newFormulaColor.quantite = newQty4120
                myArray.Add(newFormulaColor)

                formulaColorTab = DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If
        Else
            Return formulaColorTab
        End If

        'remove first color
        Dim myArrayLast As New ArrayList
        'add the new color to the formula
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color <> idColor4120 Then
                myArrayLast.Add(formulaColorTab(i))
            End If

        Next

        Return DirectCast(myArrayLast.ToArray(GetType(FormulaColor)), FormulaColor())


    End Function
    Private Function replaceColorsInFormula4047O(ByVal formulaColorTab As FormulaColor()) As FormulaColor()

        Dim idColor4047O As Integer = getColorIdByCode("4047O")
        'getColors(" where colorCode = '" & colorCodeCurrent & "'")(0).id_color
        Dim i As Integer
        Dim found4047O As Boolean = False
        Dim intiQty4047O As Decimal
        Dim newQty4047O As Decimal
        Dim idFormula As Integer = -1
        Dim idUnit As Integer = -1
        'Dim MyArray As New ArrayList
        For i = 0 To formulaColorTab.Length - 1
            idFormula = formulaColorTab(i).id_formula
            idUnit = formulaColorTab(i).id_Unit
            If idColor4047O = formulaColorTab(i).id_color Then
                intiQty4047O = formulaColorTab(i).quantite
                newQty4047O = intiQty4047O * 1.25
                found4047O = True
            End If
            'MyArray.Add(formulaColorTab(i))
        Next
        If found4047O Then
            Dim idColorNew4047 As Integer = getColorIdByCode("4047")
            'getColors(" where colorCode = '" & colorCodeNew & "'")(0).id_color

            'get the newPerc of the newColor
            Dim foundNew As Boolean = False
            For i = 0 To formulaColorTab.Length - 1
                If idColorNew4047 = formulaColorTab(i).id_color Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite + newQty4047O
                    foundNew = True
                End If
                'MyArray.Add(formulaColorTab(i))
            Next
            If Not foundNew Then
                Dim myArray As New ArrayList
                'add the new color to the formula
                For i = 0 To formulaColorTab.Length - 1
                    myArray.Add(formulaColorTab(i))
                Next
                Dim newFormulaColor As New FormulaColor
                newFormulaColor.id_formula = idFormula
                newFormulaColor.id_Unit = idUnit
                newFormulaColor.id_color = idColorNew4047
                newFormulaColor.quantite = newQty4047O
                myArray.Add(newFormulaColor)

                formulaColorTab = DirectCast(myArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If
        Else
            Return formulaColorTab
        End If

        'remove first color
        Dim myArrayLast As New ArrayList
        'add the new color to the formula
        For i = 0 To formulaColorTab.Length - 1
            If formulaColorTab(i).id_color <> idColor4047O Then
                myArrayLast.Add(formulaColorTab(i))
            End If

        Next

        Return DirectCast(myArrayLast.ToArray(GetType(FormulaColor)), FormulaColor())
    End Function

    Private Function getMinYearIndex(ByVal formulas As Formula()) As Integer
        Dim i As Integer
        Dim yearMin As Integer = -1
        Dim indexYearMin As Integer = 0
        For i = 0 To formulas.Length - 1
            Dim fnamecurrent As String = formulas(i).name_formula.ToLower
            Dim years As String = formulas(i).c_year
            If years Is Nothing Then
                Continue For
            End If
            If years.Trim = "" Then
                Continue For
            End If
            If years.IndexOf("-") < 0 Then
                Continue For
            End If
            If years.Trim = "-" Then
                Continue For
            End If

            Dim yearFirst As Integer = Integer.Parse(years.Substring(0, years.IndexOf("-") - 1).Trim)
            If i = 0 Then
                yearMin = yearFirst
                indexYearMin = i
            Else
                If yearFirst < yearMin Then
                    yearMin = yearFirst
                    indexYearMin = i
                End If
            End If
        Next
        Return indexYearMin
    End Function
    Public Function sortByYear(ByVal formulas As Formula()) As Formula()

        Dim targetCount As Integer = formulas.Length
        Dim yearMin As Integer = -1
        Dim MyArray As New ArrayList
        While MyArray.Count < targetCount
            Dim indexMin As Integer = getMinYearIndex(formulas)
            MyArray.Add(formulas(indexMin))
            'remove this element from the array
            Dim i As Integer
            Dim MyArrayTmp As New ArrayList
            For i = 0 To formulas.Length - 1
                If formulas(i).id_formula <> formulas(indexMin).id_formula Then
                    MyArrayTmp.Add(formulas(i))
                End If
            Next
            formulas = DirectCast(MyArrayTmp.ToArray(GetType(Formula)), Formula())
        End While

        Return DirectCast(MyArray.ToArray(GetType(Formula)), Formula())
    End Function
    Public Function placeMetAndMat(ByVal formulas As Formula()) As Formula()
        Dim i As Integer
        Dim MyMetArray As New ArrayList
        Dim MyMatArray As New ArrayList
        Dim MyElseArray As New ArrayList
        Dim MyAllArray As New ArrayList

        For i = 0 To formulas.Length - 1
            Dim fname As String = formulas(i).name_formula
            fname = fname.ToLower.Replace("(couche)", "").Trim
            fname = fname.ToLower.Replace("(couche 1)", "").Trim
            fname = fname.ToLower.Replace("(couche 2)", "").Trim
            fname = fname.ToLower.Replace("(sous-couche)", "").Trim

            If fname.ToLower.EndsWith(" met") Then
                MyMetArray.Add(formulas(i))
            Else
                If fname.ToLower.EndsWith(" mat") Then
                    MyMetArray.Add(formulas(i))
                Else
                    MyElseArray.Add(formulas(i))
                End If
            End If
        Next

        MyAllArray.AddRange(MyMetArray)
        MyAllArray.AddRange(MyElseArray)
        MyAllArray.AddRange(MyMatArray)
        formulas = DirectCast(MyAllArray.ToArray(GetType(Formula)), Formula())

        Return formulas
    End Function


    Public Function placeMetAndMat_old(ByVal formulas As Formula()) As Formula()
        Dim i As Integer
        Dim indexOfMet As Integer = -1
        For i = 0 To formulas.Length - 1
            Dim fname As String = formulas(i).name_formula
            fname = fname.ToLower.Replace("(couche)", "").Trim
            fname = fname.ToLower.Replace("(couche 1)", "").Trim
            fname = fname.ToLower.Replace("(couche 2)", "").Trim
            fname = fname.ToLower.Replace("(sous-couche)", "").Trim

            If fname.ToLower.EndsWith(" met") Then
                indexOfMet = i
                Exit For
            End If
        Next

        If indexOfMet > -1 Then
            ' put met first
            Dim MyArray As New ArrayList
            MyArray.Add(formulas(indexOfMet))
            For i = 0 To formulas.Length - 1
                If i <> indexOfMet Then
                    MyArray.Add(formulas(i))
                End If
            Next
            formulas = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())
        End If

        Dim indexOfMat As Integer = -1
        For i = 0 To formulas.Length - 1
            Dim fname As String = formulas(i).name_formula
            fname = fname.ToLower.Replace("(couche)", "").Trim
            fname = fname.ToLower.Replace("(couche 1)", "").Trim
            fname = fname.ToLower.Replace("(couche 2)", "").Trim
            fname = fname.ToLower.Replace("(sous-couche)", "").Trim

            If fname.ToLower.EndsWith(" mat") Then
                indexOfMat = i
                Exit For
            End If
        Next
        If indexOfMat > -1 Then
            ' put mat last
            Dim MyArray As New ArrayList

            For i = 0 To formulas.Length - 1
                If i <> indexOfMat Then
                    MyArray.Add(formulas(i))
                End If
            Next
            MyArray.Add(formulas(indexOfMat))
            formulas = DirectCast(MyArray.ToArray(GetType(Formula)), Formula())
        End If
        Return formulas
    End Function
    Public Function getColorPercentage(ByVal fColors As FormulaColor()) As String

        'deduct the formula rgb color
        Dim colorsCollectionArray As New ArrayList
        Dim colorsQtyCollectionArray As New ArrayList
        Dim totalQty As Double = 0
        Dim j As Integer = 0
        For j = 0 To fColors.Length - 1
            Dim bColor As Color = getColorById(fColors(j).id_color)
            If bColor Is Nothing Then
                Continue For
            End If
            Dim colorARGB As System.Drawing.Color = Nothing
            If Not bColor.argb Is Nothing Then
                Dim colorAgbTab() As String = bColor.argb.Split(",")
                If colorAgbTab.Length = 4 Then
                    Dim colorA As String = colorAgbTab(0)
                    Dim colorR As String = colorAgbTab(1)
                    Dim colorG As String = colorAgbTab(2)
                    Dim colorB As String = colorAgbTab(3)
                    colorARGB = System.Drawing.Color.FromArgb(colorA, colorR, colorG, colorB)


                    Dim qty As Double = fColors(j).quantite
                    totalQty = totalQty + qty

                    colorsQtyCollectionArray.Add(qty)
                    colorsCollectionArray.Add(colorARGB)
                End If

            End If
        Next

        Dim formulaColorRGBPercentage As String = ""

        If Not colorsCollectionArray Is Nothing And colorsCollectionArray.Count > 0 Then
            Dim colorsCollection() As System.Drawing.Color = DirectCast(colorsCollectionArray.ToArray(GetType(System.Drawing.Color)), System.Drawing.Color())
            Dim colorsQtyCollection() As Double = DirectCast(colorsQtyCollectionArray.ToArray(GetType(Double)), Double())

            Dim k As Integer = 0
            For k = 0 To colorsCollection.Length - 1
                Dim percentage As Double = Math.Round((colorsQtyCollection(k) * 100 / totalQty), 2)
                Dim colorRGB As String = colorsCollection(k).ToArgb
                formulaColorRGBPercentage = formulaColorRGBPercentage & colorRGB & ":" & percentage & ";"
            Next
        End If
        Return formulaColorRGBPercentage
    End Function
    Public Function deduceColorFromCollection(ByVal colorsCollection() As System.Drawing.Color) As System.Drawing.Color
        Dim deductedColor As System.Drawing.Color = Nothing
        Dim i As Integer
        For i = 0 To colorsCollection.Length - 1
            If i = 0 Then
                deductedColor = colorsCollection(i)
                Continue For
            End If
            Dim mixedA As Byte = (CInt(colorsCollection(i).A.ToString) + CInt(deductedColor.A.ToString)) / 2

            Dim mixedR As Byte = (CInt(colorsCollection(i).R.ToString) + CInt(deductedColor.R.ToString)) / 2

            Dim mixedG As Byte = (CInt(colorsCollection(i).G.ToString) + CInt(deductedColor.G.ToString)) / 2

            Dim mixedB As Byte = (CInt(colorsCollection(i).B.ToString) + CInt(deductedColor.B.ToString)) / 2

            deductedColor = System.Drawing.Color.FromArgb(mixedA, mixedR, mixedG, mixedB)

        Next
        Return deductedColor
    End Function

  



#Region "startOptimizationProcedure"
    Public Function startOptimizationProcedure(ByVal dbFileLocation As String, ByVal forMobile As Boolean) As Boolean
        Dim specificConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
            dbFileLocation & ";Jet OLEDB:Database Password=A!mA@HaP#pYZ$o;"


        Dim scriptsFolder As String = My.Application.Info.DirectoryPath & "\\VBAsqlScripts"

        Dim createCarTablesScript As String = File.ReadAllText(scriptsFolder & "\\sqlCreateCarTables.txt")
        Dim insertIntoCarTablesScript As String = File.ReadAllText(scriptsFolder & "\\sqlInsertCarQueries.txt")
        Dim createFormulaColorTablesScript As String = ""
        If forMobile Then
            createFormulaColorTablesScript = File.ReadAllText(scriptsFolder & "\\sqlCreateFormColorTable.mobile.txt")
        Else
            createFormulaColorTablesScript = File.ReadAllText(scriptsFolder & "\\sqlCreateFormColorTable.txt")
        End If

        Dim insertIntoFormulaColorTablesScript As String = File.ReadAllText(scriptsFolder & "\\sqlInsertFormColorQueries.txt")
        Dim dropTablesScript As String = File.ReadAllText(scriptsFolder & "\\sqlDropOldTablesQueries.txt")
        Dim alterCarsTablesScript As String = File.ReadAllText(scriptsFolder & "\\sqlAlterCarsTablesScript.txt")

        Dim updateMultif_x As String = File.ReadAllText(scriptsFolder & "\\sqlUpdateMultif_x.txt")
        Dim updateMultif_xp As String = File.ReadAllText(scriptsFolder & "\\sqlUpdateMultif_xp.txt")
        Dim updateMultif_xpp As String = File.ReadAllText(scriptsFolder & "\\sqlUpdateMultif_xpp.txt")

        Dim updateMultif_y As String = File.ReadAllText(scriptsFolder & "\\sqlUpdateMultif_y.txt")
        Dim updateMultif_yp As String = File.ReadAllText(scriptsFolder & "\\sqlUpdateMultif_yp.txt")
        Dim updateMultif_ypp As String = File.ReadAllText(scriptsFolder & "\\sqlUpdateMultif_ypp.txt")

        Dim updateMultif_z As String = File.ReadAllText(scriptsFolder & "\\sqlUpdateMultif_z.txt")
        Dim updateMultif_zp As String = File.ReadAllText(scriptsFolder & "\\sqlUpdateMultif_zp.txt")
        Dim updateMultif_zpp As String = File.ReadAllText(scriptsFolder & "\\sqlUpdateMultif_zpp.txt")

        Dim logFilePath As String = scriptsFolder & "\\logSql.log"

        'execute car tables creation
        Dim queries() As String = createCarTablesScript.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeCreateDropQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next

        'insert into car tables creation
        queries = insertIntoCarTablesScript.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next

        'create car formula table 
        queries = createFormulaColorTablesScript.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeCreateDropQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next

        'insert into create car formula table 
        queries = insertIntoFormulaColorTablesScript.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next

        'drop formula and formulaColor table 
        queries = dropTablesScript.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeCreateDropQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next

        'drop formula and formulaColor table 
        queries = alterCarsTablesScript.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeCreateDropQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next

        'update multi-formula codes
        queries = updateMultif_x.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next
        queries = updateMultif_xp.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next
        queries = updateMultif_xpp.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next
        queries = updateMultif_y.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next
        queries = updateMultif_yp.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next
        queries = updateMultif_ypp.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next
        queries = updateMultif_z.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next
        queries = updateMultif_zp.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next
        queries = updateMultif_zpp.Split(";")
        For i = 0 To queries.Length - 1
            If queries(i).Trim = "" Then
                Continue For
            End If
            Try
                If Not executeInsertQuery(queries(i), specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & queries(i)
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & queries(i)
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try
        Next
        Try

            closeSpecificConnection()
        Catch ex As Exception

        End Try
    End Function

    Public Sub appendFile(ByVal filePath As String, ByVal textMsg As String, Optional ByVal logFile As Boolean = True)
        Using sw As StreamWriter = File.AppendText(filePath)
            If logFile Then
                sw.WriteLine(Now & ": " & textMsg)
            Else
                sw.WriteLine(textMsg)
            End If

        End Using
    End Sub
#End Region


#Region "security"
    Public Function hashGarageKeys(ByVal dbFileLocation As String) As Boolean


        Dim specificConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & dbFileLocation & "';Jet OLEDB:Database Password=" & password & ";"
        'MsgBox("specificConString:" & specificConString, MsgBoxStyle.Information)

        Dim scriptsFolder As String = My.Application.Info.DirectoryPath & "\\VBAsqlScripts"

        Dim logFilePath As String = scriptsFolder & "\\logSql.log"

        Dim garagesArray() As Garage = getAllGarages(specificConString)

        For i = 0 To garagesArray.Length - 1
            Dim clearKey As String = garagesArray(i).key
            Dim salt As String = garagesArray(i).garage_name & garagesArray(i).id_garage
            Dim hashedKey As String = hashStringWithSalt(clearKey, salt)

            Dim query As String = "Update garage set [key]='" & hashedKey & "' where id_garage=" & garagesArray(i).id_garage
            Try
                ' MsgBox("executing executeCreateDropQuery:" & specificConString)

                If Not executeCreateDropQuery(query, specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & query
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & query
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try

        Next


    End Function
    Public Function decryptQuantitiesSaipa(ByVal dbFileLocation As String) As Boolean
        Dim specificConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbFileLocation & ";Jet OLEDB:Database Password=" & password & ";"


        Dim scriptsFolder As String = My.Application.Info.DirectoryPath & "\\VBAsqlScripts"

        Dim logFilePath As String = scriptsFolder & "\\logSql.log"

        Dim formulaColorsArray() As FormulaColor = getAllFormulaColorEncryptedSaipa(specificConString)

        For i = 0 To formulaColorsArray.Length - 1

            Dim encQuantity As String = formulaColorsArray(i).quantiteEnc


            Dim clearQuantity As String = decryptData(encQuantity, password & formulaColorsArray(i).id_formulaColor)


            Dim query As String = "Update saipa_formulaColor set quantite='" & clearQuantity & "', encrypted=0 where id_formulacolor=" & formulaColorsArray(i).id_formulaColor

            Try
                If Not executeCreateDropQuery(query, specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & query
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & query
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try

        Next


    End Function

    Public Function decryptQuantities(ByVal dbFileLocation As String) As Boolean
        Dim specificConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbFileLocation & ";Jet OLEDB:Database Password=" & password & ";"


        Dim scriptsFolder As String = My.Application.Info.DirectoryPath & "\\VBAsqlScripts"

        Dim logFilePath As String = scriptsFolder & "\\logSql.log"

        Dim formulaColorsArray() As FormulaColor = getAllFormulaColorEncrypted()

        For i = 0 To formulaColorsArray.Length - 1

            Dim encQuantity As String = formulaColorsArray(i).quantiteEnc


            Dim clearQuantity As String = decryptData(encQuantity, password & formulaColorsArray(i).id_formulaColor)


            Dim query As String = "Update formulaColor set quantite='" & clearQuantity & "', encrypted=0 where id_formulacolor=" & formulaColorsArray(i).id_formulaColor

            Try
                If Not executeCreateDropQuery(query, specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & query
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & query
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try

        Next


    End Function

    Public Function ecnryptColors(ByVal dbFileLocation As String, ByVal generatedGarage As Garage) As Boolean
        Dim specificConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbFileLocation & ";Jet OLEDB:Database Password=" & password & ";"


        Dim scriptsFolder As String = My.Application.Info.DirectoryPath & "\\VBAsqlScripts"

        Dim logFilePath As String = scriptsFolder & "\\logSql.log"

        Dim colorsArray() As Color = getAllColors(specificConString)

        For i = 0 To colorsArray.Length - 1

            Dim clearColorCode As String = colorsArray(i).colorCode
            Dim clearColorName As String = colorsArray(i).name_color
            Dim clearColorNameAlt As String = colorsArray(i).name_color_alternative
            Dim clearColorNameAlt2 As String = colorsArray(i).name_color_alternative2

            Dim encColorCode As String = encryptData(clearColorCode, password & generatedGarage.garage_name)
            Dim encColorName As String = encryptData(clearColorName, password & generatedGarage.garage_name)
            Dim encColorNameAlt As String = encryptData(clearColorNameAlt, password & generatedGarage.garage_name)
            Dim encColorNameAlt2 As String = encryptData(clearColorNameAlt2, password & generatedGarage.garage_name)

            Dim query As String = "Update color set colorCode='" & encColorCode & "', name_color='" & encColorName & "', name_color_alternative='" & encColorNameAlt & "', name_color_alternative2='" & encColorNameAlt2 & "' where id_color=" & colorsArray(i).id_color
            Try
                If Not executeCreateDropQuery(query, specificConString) Then
                    'write in log file
                    Dim errorMsg As String = "NO RESULT with the query: " & query
                    appendFile(logFilePath, errorMsg)
                End If
            Catch ex As Exception
                'write in log file
                Dim errorMsg As String = "ERROR with the query: " & query
                errorMsg = errorMsg & ex.Message & vbNewLine & ex.StackTrace
                appendFile(logFilePath, errorMsg)
            End Try

        Next


    End Function

    Public Function encryptFormulaColor(ByVal formulaColor As FormulaColor) As FormulaColor
        If encryptionActive = 0 Then
            Return formulaColor
        End If

        Dim clearQuantity As String = formulaColor.quantite
        Dim encQuantity As String = encryptData(clearQuantity, password & chosenGarage.garage_name)
        formulaColor.quantite = encQuantity
        Return formulaColor
    End Function

    Public Function decryptFormulaColor(ByVal formulaColor As FormulaColor) As FormulaColor
        If encryptionActive = 0 Then
            Return formulaColor
        End If

        Dim encQuantity As String = formulaColor.quantite
        Dim clearQuantity As String = decryptData(encQuantity, password & formulaColor.id_formulaColor)
        formulaColor.quantite = clearQuantity
        Return formulaColor
    End Function

    Public Function encryptQuantity(ByVal clearQuantity As String, ByVal idFormulaColor As Integer) As String
        If encryptionActive = 0 Then
            Return clearQuantity
        End If

        Dim encQuantity As String = encryptData(clearQuantity, password & idFormulaColor)
        Return encQuantity
    End Function

    Public Function decryptQuantity(ByVal encQuantity As String, ByVal idFormulaColor As Integer) As String
        If encryptionActive = 0 Then
            Return encQuantity
        End If

        Dim clearQuantity As String = decryptData(encQuantity, password & idFormulaColor)
        Return clearQuantity
    End Function






    Public Function hashStringWithSalt(ByVal password As String, ByVal salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function



    Private Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)
        Dim hashString As String = ""
        For Each b As Byte In hash
            hashString += b.ToString("x2")
        Next

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
    Public Function encryptData(ByVal plaintext As String, ByVal encryptionKey As String) As String
        Dim result As String = ""
        Try
            TripleDes.Key = TruncateHash(encryptionKey, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)


            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte =
                System.Text.Encoding.Unicode.GetBytes(plaintext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            result = Convert.ToBase64String(ms.ToArray)
        Catch ex As Exception

        End Try
        Return result
    End Function
    Public Function decryptData(ByVal encryptedtext As String, ByVal encryptionKey As String) As String
        Dim result As String = ""
        Try
            TripleDes.Key = TruncateHash(encryptionKey, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)

            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string.
            result = System.Text.Encoding.Unicode.GetString(ms.ToArray)
        Catch ex As Exception

        End Try
        Return result



    End Function

#End Region
End Module
