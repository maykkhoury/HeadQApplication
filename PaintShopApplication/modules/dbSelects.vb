Imports System.Data.SQLite

Module dbSelects
    Public password As String = "A!mA@HaP#pYZ$o"
    Public conString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "//dbPaintShop.mdb;Jet OLEDB:Database Password=" & password & ";"

    Public mySQLITEConnectionString As String = "Data Source=" & My.Application.Info.DirectoryPath & "\mobileSync\mobileSyncApp.db;Version=3;"

    Public DB As New OleDb.OleDbConnection
    Public specifDB As New OleDb.OleDbConnection

#Region "optimizing garage db"

    Public Function getAllColors(ByVal specificConString As String) As Color()
        Dim MyArray As New ArrayList

        If openSpecificConnection(specificConString) Then
            Try

                Dim DR As OleDb.OleDbDataReader = selectQuerySpecificDB("Select * FROM [color] ")
                Dim i As Integer = 0

                While DR.Read
                    Dim newcolor As New Color

                    newcolor.id_color = DR.Item("id_color")
                    newcolor.id_colorStr = newcolor.id_color
                    If Not DR.Item("name_color") Is DBNull.Value Then
                        newcolor.name_color = DR.Item("name_color").trim
                    End If
                    If Not DR.Item("name_color_alternative") Is DBNull.Value Then
                        newcolor.name_color_alternative = DR.Item("name_color_alternative")
                    End If
                    If Not DR.Item("name_color_alternative2") Is DBNull.Value Then
                        newcolor.name_color_alternative2 = DR.Item("name_color_alternative2")
                    End If
                    If Not DR.Item("defaultPrice") Is DBNull.Value Then
                        newcolor.defaultPrice = DR.Item("defaultPrice")
                        newcolor.defaultPriceStr = newcolor.defaultPrice
                    End If
                    If Not DR.Item("id_defaultCurreny") Is DBNull.Value Then
                        newcolor.id_defaultCurreny = DR.Item("id_defaultCurreny")
                        newcolor.id_defaultCurrenyStr = newcolor.id_defaultCurreny
                    End If
                    If Not DR.Item("id_defaultUnit") Is DBNull.Value Then
                        newcolor.id_defaultUnit = DR.Item("id_defaultUnit")
                        newcolor.id_defaultUnitStr = newcolor.id_defaultUnit
                    End If
                    If Not DR.Item("colorImgPath") Is DBNull.Value Then
                        newcolor.colorImgPath = DR.Item("colorImgPath")
                    End If
                    If Not DR.Item("colorCode") Is DBNull.Value Then
                        newcolor.colorCode = DR.Item("colorCode")
                    End If
                    If Not DR.Item("id_unit_on_entry") Is DBNull.Value Then
                        newcolor.id_unit_on_entry = DR.Item("id_unit_on_entry")
                        newcolor.id_unit_on_entryStr = newcolor.id_unit_on_entry
                    End If
                    If Not DR.Item("masse_volumique") Is DBNull.Value Then
                        newcolor.masse_volumique = DR.Item("masse_volumique")
                    End If
                    If Not DR.Item("masse_volumique_ext") Is DBNull.Value Then
                        newcolor.masse_volumique_ext = DR.Item("masse_volumique_ext")
                    End If
                    If Not DR.Item("argb") Is DBNull.Value Then
                        newcolor.argb = DR.Item("argb")

                    End If
                    MyArray.Add(newcolor)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Color)), Color())
    End Function

    Public Function getAllFormulaColors(ByVal specificConString As String) As FormulaColor()

        Dim MyArray As New ArrayList
        If openSpecificConnection(specificConString) Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuerySpecificDB("Select * FROM [FormulaColor]")
                Dim i As Integer = 0

                While DR.Read
                    Dim newFormulaColor As New FormulaColor
                    newFormulaColor.id_formulaColor = DR.Item("id_formulaColor")
                    If Not DR.Item("id_color") Is DBNull.Value Then
                        newFormulaColor.id_color = DR.Item("id_color")
                    End If
                    newFormulaColor.id_formula = DR.Item("id_formula")
                    If Not DR.Item("id_Unit") Is DBNull.Value Then
                        newFormulaColor.id_Unit = DR.Item("id_Unit")
                    End If

                   
                    Dim dbQuantity As String = ""
                    If Not DR.Item("quantite") Is DBNull.Value Then
                        dbQuantity = DR.Item("quantite")
                    End If

                    

                    If Not DR.Item("encrypted") Is DBNull.Value Then
                        newFormulaColor.encryptedStr = DR.Item("encrypted")
                        If DR.Item("encrypted") = 1 Then
                            newFormulaColor.encrypted = True

                        End If
                    End If

                    If newFormulaColor.encrypted Then
                        'decrypt
                        newFormulaColor.quantite = decryptQuantity(dbQuantity, newFormulaColor.id_formulaColor)
                        '''''
                    Else
                        newFormulaColor.quantite = dbQuantity
                    End If

                    newFormulaColor.id_carStr = newFormulaColor.id_car
                    newFormulaColor.id_formulaColorStr = newFormulaColor.id_formulaColor
                    newFormulaColor.id_colorStr = newFormulaColor.id_color
                    newFormulaColor.id_formulaStr = newFormulaColor.id_formula
                    newFormulaColor.quantiteStr = newFormulaColor.quantite

                    MyArray.Add(newFormulaColor)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeSpecificConnection()
        Dim formulaColorTab() As FormulaColor = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
        Return formulaColorTab

    End Function

    Public Function getAllGarages(ByVal specificConString As String) As Garage()
        Dim MyArray As New ArrayList


        If openSpecificConnection(specificConString) Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuerySpecificDB("Select * FROM [garage] ")
                Dim i As Integer = 0

                While DR.Read
                    Dim newGarage As New Garage

                    newGarage.id_garage = DR.Item("id_garage")
                    If Not DR.Item("garage_name") Is DBNull.Value Then
                        newGarage.garage_name = DR.Item("garage_name").trim
                    End If
                    If Not DR.Item("name_responsible") Is DBNull.Value Then
                        newGarage.name_responsible = DR.Item("name_responsible").trim
                    End If
                    If Not DR.Item("location") Is DBNull.Value Then
                        newGarage.location = DR.Item("location").trim
                    End If
                    If Not DR.Item("version") Is DBNull.Value Then
                        newGarage.version = DR.Item("version").trim
                    End If
                    If Not DR.Item("id_language") Is DBNull.Value Then
                        newGarage.id_language = DR.Item("id_language")
                    End If
                    If Not DR.Item("logo") Is DBNull.Value Then
                        newGarage.logo = DR.Item("logo")
                    End If
                    If Not DR.Item("chosen") Is DBNull.Value Then
                        If DR.Item("chosen") = "1" Then
                            newGarage.chosen = True
                        Else
                            newGarage.chosen = False
                        End If

                    End If
                    newGarage.showAlternativeName = False
                    newGarage.showAlternativeName2 = False
                    If Not DR.Item("showAlternativeName") Is DBNull.Value Then
                        If DR.Item("showAlternativeName") = "1" Then
                            newGarage.showAlternativeName = True
                        Else
                            If DR.Item("showAlternativeName") = "2" Then
                                newGarage.showAlternativeName2 = True

                            End If
                        End If

                    End If


                    If Not DR.Item("coat") Is DBNull.Value Then
                        newGarage.coat = DR.Item("coat").trim
                    End If
                    If Not DR.Item("tel") Is DBNull.Value Then
                        newGarage.tel = DR.Item("tel")
                    End If
                    If Not DR.Item("key") Is DBNull.Value Then
                        newGarage.key = DR.Item("key")
                    End If
                    If Not DR.Item("key1") Is DBNull.Value Then
                        newGarage.key1 = DR.Item("key1")
                    End If
                    If Not DR.Item("theme_color") Is DBNull.Value Then
                        newGarage.themeColor = DR.Item("theme_color")
                    End If
                    If Not DR.Item("username") Is DBNull.Value Then
                        newGarage.username = DR.Item("username")
                    End If


                    newGarage.apply_equation = False
                    newGarage.apply_equation2 = False
                    If Not DR.Item("apply_equation") Is DBNull.Value Then
                        Dim appEqDB As String = DR.Item("apply_equation")
                        Dim appEq As Integer = 0
                        Dim eqq5 As Boolean = False
                        Dim eqq6 As Boolean = False

                        If appEqDB.IndexOf("+") = -1 Then
                            appEq = Integer.Parse(appEqDB)
                        Else
                            Try
                                appEq = Integer.Parse(appEqDB.Substring(0, appEqDB.IndexOf("+")))

                                If appEqDB.Substring(appEqDB.IndexOf("+") + 1).Contains("eq6") Then
                                    Dim temp As String = (appEqDB.Substring(appEqDB.IndexOf("+") + 1))
                                    eqq5 = Boolean.Parse(temp.Substring(0, temp.IndexOf("eq6")))
                                    eqq6 = Boolean.Parse(temp.Substring(temp.IndexOf("eq6") + 3))
                                Else
                                    eqq5 = Boolean.Parse(appEqDB.Substring(appEqDB.IndexOf("+") + 1))
                                End If

                            Catch ex As Exception
                                MsgBox("Verify garage data (Appy eq field)", MsgBoxStyle.Exclamation)
                                Throw ex
                            End Try
                        End If

                        newGarage.apply_equation5 = eqq5
                        newGarage.apply_equation6 = eqq6

                        If appEq = 1 Then
                            newGarage.apply_equation = True
                        Else
                            If appEq = 2 Then
                                newGarage.apply_equation2 = True
                            Else
                                If appEq = 3 Then
                                    newGarage.apply_equation3 = True
                                Else
                                    If appEq = 4 Then
                                        newGarage.apply_equation4 = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                    MyArray.Add(newGarage)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Garage)), Garage())
    End Function
    Public Function selectQuerySpecificDB(ByVal query As String) As OleDb.OleDbDataReader
        Try
            Dim DR As OleDb.OleDbDataReader
            Dim DBC As New OleDb.OleDbCommand
            DBC.Connection = specifDB
            DBC.CommandText = query
            DR = DBC.ExecuteReader
            Return DR
        Catch ex As Exception
            MsgBox("selectQuery=" & query & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function



    Public Function getFormulasMap(ByVal whereStr As String) As Hashtable
        Dim MyHashset As New Hashtable
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select car.id_car,car.carName,id_otherCurreny, [version],name_formula,type,id_otherUnit,id_formula,formulaImgPath,otherPrice,variant,duplicate,colorCode,colorRGB,c_year,cardNumber,id_formulaX,id_formulaY,id_formulaZ,id_formulaXp,id_formulaX2p,id_formulaYp,id_formulaY2p,id_formulaZp,id_formulaZ2p,isEquation15perc4201,date_cre_mod,noEquation4201_180,modified_once FROM [formula],[car] WHERE formula.id_car=car.id_car " & whereStr & " ORDER BY colorCode,[version] ")
                Dim i As Integer = 0

                While DR.Read
                    Dim newFormula As New Formula
                    newFormula.id_formula = DR.Item("id_formula")
                    If Not DR.Item("formulaImgPath") Is DBNull.Value Then
                        newFormula.formulaImgPath = DR.Item("formulaImgPath")
                    End If
                    If Not DR.Item("otherPrice") Is DBNull.Value Then
                        newFormula.otherPrice = DR.Item("otherPrice")
                    End If
                    If Not DR.Item("id_otherCurreny") Is DBNull.Value Then
                        newFormula.id_otherCurreny = DR.Item("id_otherCurreny")
                    End If
                    If Not DR.Item("id_otherUnit") Is DBNull.Value Then
                        newFormula.id_otherUnit = DR.Item("id_otherUnit")
                    End If
                    If Not DR.Item("type") Is DBNull.Value Then
                        newFormula.type = DR.Item("type")
                    End If
                    If Not DR.Item(0) Is DBNull.Value Then
                        newFormula.id_car = DR.Item(0)
                    End If
                    If Not DR.Item(1) Is DBNull.Value Then
                        newFormula.name_car = DR.Item(1)
                    End If
                    If Not DR.Item("name_formula") Is DBNull.Value Then
                        newFormula.name_formula = DR.Item("name_formula")
                    End If
                    If Not DR.Item("version") Is DBNull.Value Then
                        newFormula.version = DR.Item("version")
                    End If
                    If Not DR.Item("variant") Is DBNull.Value Then
                        newFormula.variant = DR.Item("variant")
                    End If
                    If Not DR.Item("duplicate") Is DBNull.Value Then
                        newFormula.duplicate = DR.Item("duplicate")
                    End If
                    If Not DR.Item("colorCode") Is DBNull.Value Then
                        newFormula.colorCode = DR.Item("colorCode")
                    End If
                    If Not DR.Item("colorRGB") Is DBNull.Value Then
                        newFormula.colorRGB = DR.Item("colorRGB")
                    End If
                    If Not DR.Item("c_year") Is DBNull.Value Then
                        newFormula.c_year = DR.Item("c_year")
                    End If

                    If Not DR.Item("id_formulaX") Is DBNull.Value Then
                        newFormula.id_formulaX = DR.Item("id_formulaX")
                    End If
                    If Not DR.Item("id_formulaXp") Is DBNull.Value Then
                        newFormula.id_formulaXp = DR.Item("id_formulaXp")
                    End If
                    If Not DR.Item("id_formulaX2p") Is DBNull.Value Then
                        newFormula.id_formulaX2p = DR.Item("id_formulaX2p")
                    End If

                    If Not DR.Item("id_formulaY") Is DBNull.Value Then
                        newFormula.id_formulaY = DR.Item("id_formulaY")
                    End If
                    If Not DR.Item("id_formulaYp") Is DBNull.Value Then
                        newFormula.id_formulaYp = DR.Item("id_formulaYp")
                    End If
                    If Not DR.Item("id_formulaY2p") Is DBNull.Value Then
                        newFormula.id_formulaY2p = DR.Item("id_formulaY2p")
                    End If

                    If Not DR.Item("id_formulaZ") Is DBNull.Value Then
                        newFormula.id_formulaZ = DR.Item("id_formulaZ")
                    End If
                    If Not DR.Item("id_formulaZp") Is DBNull.Value Then
                        newFormula.id_formulaZp = DR.Item("id_formulaZp")
                    End If
                    If Not DR.Item("id_formulaZ2p") Is DBNull.Value Then
                        newFormula.id_formulaZ2p = DR.Item("id_formulaZ2p")
                    End If

                    If Not DR.Item("cardNumber") Is DBNull.Value Then
                        newFormula.cardNumber = DR.Item("cardNumber")
                    End If

                    If Not DR.Item("modified_once") Is DBNull.Value Then
                        If DR.Item("modified_once") = 1 Then
                            newFormula.modified_once = True
                        Else
                            newFormula.modified_once = False
                        End If
                    Else
                        newFormula.modified_once = True 'we dont want to show an asteriks
                    End If

                    newFormula.Date_cre_mod = ""
                    If Not DR.Item("date_cre_mod") Is DBNull.Value Then
                        Dim dateCreModStr As String = DR.Item("date_cre_mod")
                        newFormula.Date_cre_mod = dateCreModStr

                        Dim dateCreModStrTab() As String = dateCreModStr.Split(":")
                        Dim day As Integer = Integer.Parse(dateCreModStrTab(0))
                        Dim month As Integer = Integer.Parse(dateCreModStrTab(1))
                        Dim year As Integer = Integer.Parse(dateCreModStrTab(2))
                        Dim hour As Integer = Integer.Parse(dateCreModStrTab(3))
                        Dim minute As Integer = Integer.Parse(dateCreModStrTab(4))
                        Dim second As Integer = Integer.Parse(dateCreModStrTab(5))

                        Dim dateCreMod As New DateTime(year, month, day, hour, minute, second)
                        newFormula.dateCreMod = dateCreMod

                    End If
                    newFormula.isEquation15perc4201Str = ""
                    If Not DR.Item("isEquation15perc4201") Is DBNull.Value Then
                        newFormula.isEquation15perc4201Str = DR.Item("isEquation15perc4201")
                        If DR.Item("isEquation15perc4201") = 1 Then
                            newFormula.isEquation15perc4201 = True
                        Else
                            newFormula.isEquation15perc4201 = False
                        End If
                    Else
                        newFormula.isEquation15perc4201 = False
                    End If

                    newFormula.noEquation4201_180Str = ""
                    If Not DR.Item("noEquation4201_180") Is DBNull.Value Then
                        newFormula.noEquation4201_180Str = DR.Item("noEquation4201_180")
                        If DR.Item("noEquation4201_180") = 1 Then
                            newFormula.isEquation4201_180 = False
                        Else
                            newFormula.isEquation4201_180 = True
                        End If
                    Else
                        newFormula.isEquation4201_180 = True
                    End If

                    newFormula.id_formulaStr = newFormula.id_formula

                    newFormula.id_formulaXStr = newFormula.id_formulaX
                    newFormula.id_formulaXpStr = newFormula.id_formulaXp
                    newFormula.id_formulaX2pStr = newFormula.id_formulaX2p

                    newFormula.id_formulaYStr = newFormula.id_formulaY
                    newFormula.id_formulaYpStr = newFormula.id_formulaYp
                    newFormula.id_formulaY2pStr = newFormula.id_formulaY2p

                    newFormula.id_formulaZStr = newFormula.id_formulaZ
                    newFormula.id_formulaZpStr = newFormula.id_formulaZp
                    newFormula.id_formulaZ2pStr = newFormula.id_formulaZ2p

                    newFormula.id_carStr = newFormula.id_car
                    newFormula.id_otherCurrenyStr = newFormula.id_otherCurreny
                    newFormula.id_otherUnitStr = newFormula.id_otherUnit

                    newFormula.otherPriceStr = newFormula.otherPrice


                    MyHashset.Add(newFormula.id_formula, newFormula)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox("whereStr=" & whereStr & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return MyHashset
    End Function

    Public Function getCarsMap(ByVal whereStr As String) As Hashtable
        Dim MyHashset As New Hashtable
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [car] " & whereStr & " Order by carName")
                Dim i As Integer = 0

                While DR.Read
                    Dim newcar As New Car

                    newcar.id_car = DR.Item("id_car")
                    newcar.id_carStr = newcar.id_car
                    If Not DR.Item("carName") Is DBNull.Value Then
                        newcar.carName = DR.Item("carName").trim
                    End If
                    If Not DR.Item("tableName") Is DBNull.Value Then
                        newcar.tableName = DR.Item("tableName")
                    End If
                    If Not DR.Item("model") Is DBNull.Value Then
                        newcar.model = DR.Item("model").trim
                    End If
                    If Not DR.Item("carImgPath") Is DBNull.Value Then
                        newcar.carImgPath = DR.Item("carImgPath").trim
                    End If
                    MyHashset.Add(newcar.id_car, newcar)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return MyHashset
    End Function

    Public Sub getFormulaColorsMap(ByRef mainHashTable As Hashtable)
        'Dim mainHashTable As New Hashtable
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [FormulaColor]")
                Dim i As Integer = 0


                Dim nestedFormulaColorsList As New ArrayList

                While DR.Read
                    Dim newFormulaColor As New FormulaColor
                    newFormulaColor.id_formulaColor = DR.Item("id_formulaColor")
                    If Not DR.Item("id_color") Is DBNull.Value Then
                        newFormulaColor.id_color = DR.Item("id_color")
                    End If
                    newFormulaColor.id_formula = DR.Item("id_formula")
                    If Not DR.Item("id_Unit") Is DBNull.Value Then
                        newFormulaColor.id_Unit = DR.Item("id_Unit")
                    End If
                    Dim dbQuantity As String = ""
                    If Not DR.Item("quantite") Is DBNull.Value Then
                        dbQuantity = DR.Item("quantite")
                    End If
                    If Not DR.Item("encrypted") Is DBNull.Value Then
                        newFormulaColor.encryptedStr = DR.Item("encrypted")
                        If DR.Item("encrypted") = 1 Then
                            newFormulaColor.encrypted = True

                        End If
                    End If

                    If newFormulaColor.encrypted Then
                        'decrypt
                        newFormulaColor.quantite = decryptQuantity(dbQuantity, newFormulaColor.id_formulaColor)
                        '''''
                    Else
                        newFormulaColor.quantite = dbQuantity
                    End If

                    newFormulaColor.id_carStr = newFormulaColor.id_car
                    newFormulaColor.id_formulaColorStr = newFormulaColor.id_formulaColor
                    newFormulaColor.id_colorStr = newFormulaColor.id_color
                    newFormulaColor.id_formulaStr = newFormulaColor.id_formula
                    newFormulaColor.quantiteStr = newFormulaColor.quantite




                    'get the existing arraylist
                    Dim existingArrayList As ArrayList = mainHashTable.Item(newFormulaColor.id_formula)
                    If existingArrayList Is Nothing Then 'first entry for this formulaid
                        nestedFormulaColorsList = New ArrayList
                        nestedFormulaColorsList.Add(newFormulaColor)
                        mainHashTable.Add(newFormulaColor.id_formula, nestedFormulaColorsList)
                    Else 'already added formulacolor for this formulaid
                        nestedFormulaColorsList = existingArrayList.Clone
                        nestedFormulaColorsList.Add(newFormulaColor)

                        'update the existing by remove/add process
                        mainHashTable.Remove(newFormulaColor.id_formula)
                        mainHashTable.Add(newFormulaColor.id_formula, nestedFormulaColorsList)
                    End If
                    '
                    i += 1
                End While

                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()

        'Return mainHashTable

    End Sub

#End Region

#Region "mobileSync"

    Public Function getEditedMobileSync(ByVal currentLastSyncVersion As Integer, ByVal syncTable As String) As Integer()

        Dim myArray As New ArrayList
        Dim strSQL As String = "select * from mobileEditSync where syncTable=? and currentLastSyncVersion=? "
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)


            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()


            Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

            Using rdr
                While (rdr.Read())
                    Dim idTable As Integer = rdr("idTable")
                    myArray.Add(idTable)
                End While
            End Using
            rdr.Close()

            cn.Close()
        End Using

        Return DirectCast(myArray.ToArray(GetType(Integer)), Integer())
    End Function

    Public Function getDeletedCarsBySyncVersion(ByVal currentLastSyncVersion As Integer, ByVal whereStr As String) As Car()
        Dim syncTable As String = "car"
        Dim myArray As New ArrayList
        Dim strSQL As String = "select * from mobileDeleteSync where syncTable=? and currentLastSyncVersion=? " & whereStr
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)


            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()


            Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

            Using rdr
                While (rdr.Read())
                    Dim newCar As New Car

                    newCar.id_car = rdr("idTable")
                    newCar.id_carStr = newCar.id_car
                    If Not rdr("tableName") Is DBNull.Value Then
                        newCar.tableName = rdr("tableName")
                    End If

                    If Not rdr("carName") Is DBNull.Value Then
                        newCar.carName = rdr("carName")
                    End If



                    myArray.Add(newCar)
                End While
            End Using
            rdr.Close()

            cn.Close()
        End Using

        Return DirectCast(myArray.ToArray(GetType(Car)), Car())
    End Function

    Public Function getDeletedColorsBySyncVersion(ByVal currentLastSyncVersion As Integer, ByVal whereStr As String) As Color()
        Dim syncTable As String = "color"
        Dim myArray As New ArrayList
        Dim strSQL As String = "select * from mobileDeleteSync where syncTable=? and currentLastSyncVersion=? " & whereStr
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)


            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()


            Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

            Using rdr
                While (rdr.Read())
                    Dim newColor As New Color

                    newColor.id_color = rdr("idTable")
                    newColor.id_colorStr = newColor.id_color
                    If Not rdr("colorCode") Is DBNull.Value Then
                        newColor.colorCode = rdr("colorCode")
                    End If

                    If Not rdr("name_color") Is DBNull.Value Then
                        newColor.name_color = rdr("name_color")
                    End If



                    myArray.Add(newColor)
                End While
            End Using
            rdr.Close()

            cn.Close()
        End Using

        Return DirectCast(myArray.ToArray(GetType(Color)), Color())
    End Function


    Public Function getDeletedGaragesBySyncVersion(ByVal currentLastSyncVersion As Integer, ByVal whereStr As String) As Garage()
        Dim syncTable As String = "garage"
        Dim myArray As New ArrayList
        Dim strSQL As String = "select * from mobileDeleteSync where syncTable=? and currentLastSyncVersion=? " & whereStr
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)


            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()


            Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

            Using rdr
                While (rdr.Read())
                    Dim newGarage As New Garage

                    newGarage.id_garage = rdr("idTable")
                    newGarage.id_garageStr = newGarage.id_garage
                    If Not rdr("garage_name") Is DBNull.Value Then
                        newGarage.garage_name = rdr("garage_name").trim
                    End If
                    If Not rdr("name_responsible") Is DBNull.Value Then
                        newGarage.name_responsible = rdr("name_responsible").trim
                    End If
                    If Not rdr("location") Is DBNull.Value Then
                        newGarage.location = rdr("location").trim
                    End If
                    If Not rdr("version") Is DBNull.Value Then
                        newGarage.version = rdr("version").trim
                    End If
                    If Not rdr("id_language") Is DBNull.Value Then
                        newGarage.id_language = rdr("id_language")
                        newGarage.id_languageStr = newGarage.id_language
                    End If


                    If Not rdr("coat") Is DBNull.Value Then
                        newGarage.coat = rdr("coat").trim
                    End If

                    If Not rdr("username") Is DBNull.Value Then
                        newGarage.username = rdr("username")
                    End If


                    newGarage.apply_equation = False
                    newGarage.apply_equation2 = False
                    If Not rdr("apply_equation") Is DBNull.Value Then
                        Dim appEqDB As String = rdr("apply_equation")
                        newGarage.apply_equationDBValue = appEqDB

                        Dim appEq As Integer = 0
                        Dim eqq5 As Boolean = False
                        If appEqDB.IndexOf("+") = -1 Then
                            appEq = Integer.Parse(appEqDB)
                        Else
                            Try
                                appEq = Integer.Parse(appEqDB.Substring(0, appEqDB.IndexOf("+")))
                                eqq5 = Boolean.Parse(appEqDB.Substring(appEqDB.IndexOf("+") + 1))
                            Catch ex As Exception
                                MsgBox("Verify garage data (Appy eq field)", MsgBoxStyle.Exclamation)
                                Throw ex
                            End Try
                        End If

                        newGarage.apply_equation5 = eqq5

                        If appEq = 1 Then
                            newGarage.apply_equation = True
                        Else
                            If appEq = 2 Then
                                newGarage.apply_equation2 = True
                            Else
                                If appEq = 3 Then
                                    newGarage.apply_equation3 = True
                                Else
                                    If appEq = 4 Then
                                        newGarage.apply_equation4 = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                    myArray.Add(newGarage)
                End While
            End Using
            rdr.Close()

            cn.Close()
        End Using

        Return DirectCast(myArray.ToArray(GetType(Garage)), Garage())
    End Function


    Public Function getDeletedFormulasBySyncVersion(ByVal currentLastSyncVersion As Integer, ByVal whereStr As String) As Formula()
        Dim syncTable As String = "formula"
        Dim myArray As New ArrayList
        Dim strSQL As String = "select * from mobileDeleteSync where syncTable=? and currentLastSyncVersion=? " & whereStr
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)


            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()


            Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

            Using rdr
                While (rdr.Read())
                    Dim newFormula As New Formula

                    newFormula.id_formula = rdr("idTable")
                    newFormula.id_formulaStr = newFormula.id_formula
                    If Not rdr("colorCode") Is DBNull.Value Then
                        newFormula.colorCode = rdr("colorCode")
                    End If

                    If Not rdr("name_color") Is DBNull.Value Then
                        newFormula.name_formula = rdr("name_color")
                    End If

                    If Not rdr("type") Is DBNull.Value Then
                        newFormula.type = rdr("type")
                    End If

                    If Not rdr("version") Is DBNull.Value Then
                        newFormula.version = rdr("version")
                    End If

                    If Not rdr("id_car") Is DBNull.Value Then
                        newFormula.id_car = rdr("id_car")
                    End If

                    If Not rdr("carName") Is DBNull.Value Then
                        newFormula.name_car = rdr("carName")
                    End If

                    myArray.Add(newFormula)
                End While
            End Using
            rdr.Close()

            cn.Close()
        End Using

        Return DirectCast(myArray.ToArray(GetType(Formula)), Formula())
    End Function

#End Region

#Region "Connection"
    Public Function openSpecificConnection(ByVal specifConString As String) As Boolean
        Try
            If specifDB.State = ConnectionState.Closed Or specifDB.State = ConnectionState.Broken Then
                specifDB.ConnectionString = specifConString
                specifDB.Open()
            End If
            openSpecificConnection = True
        Catch ex As Exception
            openSpecificConnection = False
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function

    Public Function openConnection() As Boolean
        Try
            If DB.State = ConnectionState.Closed Or DB.State = ConnectionState.Broken Then
                DB.ConnectionString = conString
                DB.Open()
            End If
            openConnection = True
        Catch ex As Exception
            openConnection = False
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function
    Public Function closeConnection() As Boolean
        Try
            DB.Close()
            closeConnection = True
        Catch ex As Exception
            closeConnection = False
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function
    Public Function closeSpecificConnection() As Boolean
        Try
            specifDB.Close()
            closeSpecificConnection = True
        Catch ex As Exception
            closeSpecificConnection = False
            MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function
    Public Function selectQuery(ByVal query) As OleDb.OleDbDataReader
        Try
            Dim DR As OleDb.OleDbDataReader
            Dim DBC As New OleDb.OleDbCommand
            DBC.Connection = DB
            DBC.CommandText = query
            DR = DBC.ExecuteReader
            Return DR
        Catch ex As Exception
            MsgBox("selectQuery=" & query & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function

    Public Function selectQuerySpecificDB(ByVal query) As OleDb.OleDbDataReader
        Try
            Dim DR As OleDb.OleDbDataReader
            Dim DBC As New OleDb.OleDbCommand
            DBC.Connection = specifDB
            DBC.CommandText = query
            DR = DBC.ExecuteReader
            Return DR
        Catch ex As Exception
            MsgBox("selectQuery=" & query & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function

#End Region

#Region "beansBinding"

    Public Function getLanguages() As Language()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [language]")
                Dim i As Integer = 0

                While DR.Read
                    Dim language As Language
                    language = New Language()

                    language.id_language = DR.Item("id_language")
                    If Not DR.Item("code_language") Is DBNull.Value Then
                        language.code_language = DR.Item("code_language")
                    End If
                    If Not DR.Item("dateTimeFormat") Is DBNull.Value Then
                        language.dateTimeFormat = DR.Item("dateTimeFormat")
                    End If
                    If Not DR.Item("isDefault") Is DBNull.Value Then
                        language.isDefault = DR.Item("isDefault")
                    End If
                    If Not DR.Item("label_language") Is DBNull.Value Then
                        language.label_language = DR.Item("label_language")
                    End If
                    MyArray.Add(language)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Language)), Language())
    End Function

    Public Function getUnits() As Unit()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [unit]")
                Dim i As Integer = 0

                While DR.Read
                    Dim newUnit As New Unit
                    newUnit.id_unit = DR.Item("id_unit")
                    If Not DR.Item("rateToLitre") Is DBNull.Value Then
                        newUnit.rateToLitre = DR.Item("rateToLitre")
                    End If
                    If Not DR.Item("code_unit") Is DBNull.Value Then
                        newUnit.code_unit = DR.Item("code_unit")
                    End If

                    Dim MyArray2 As New ArrayList
                    Dim unitLanguageTab() As UnitLanguage
                    Dim DR2 As OleDb.OleDbDataReader = selectQuery("Select * FROM unitLanguage where id_unit=" & DR.Item("id_unit"))
                    While DR2.Read
                        Dim unitLanguage As New UnitLanguage
                        unitLanguage.id_unitLanguage = DR2.Item("id_unitLanguage")
                        unitLanguage.id_unit = DR2.Item("id_unit")
                        unitLanguage.id_language = DR2.Item("id_language")
                        If Not DR2.Item("name_unit") Is DBNull.Value Then
                            unitLanguage.name_unit = DR2.Item("name_unit")
                        End If

                        MyArray2.Add(unitLanguage)
                    End While
                    DR2.Close()
                    unitLanguageTab = DirectCast(MyArray2.ToArray(GetType(UnitLanguage)), UnitLanguage())
                    newUnit.unitLanguage = unitLanguageTab
                    MyArray.Add(newUnit)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Unit)), Unit())
    End Function

    Public Function getColors() As Color()
        Dim MyArray As New ArrayList

        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [color]")


                Dim i As Integer = 0

                While DR.Read
                    Dim newColor As New Color
                    newColor.id_color = DR.Item("id_color")
                    If Not DR.Item("colorImgPath") Is DBNull.Value Then
                        newColor.colorImgPath = DR.Item("colorImgPath")
                    End If
                    If Not DR.Item("defaultPrice") Is DBNull.Value Then
                        newColor.defaultPrice = DR.Item("defaultPrice")
                    End If
                    If Not DR.Item("id_defaultCurreny") Is DBNull.Value Then
                        newColor.id_defaultCurreny = DR.Item("id_defaultCurreny")
                    End If
                    If Not DR.Item("id_defaultUnit") Is DBNull.Value Then
                        newColor.id_defaultUnit = DR.Item("id_defaultUnit")
                    End If
                    If Not DR.Item("name_color") Is DBNull.Value Then
                        newColor.name_color = DR.Item("name_color")
                    End If
                    If Not DR.Item("name_color_alternative") Is DBNull.Value Then
                        newColor.name_color_alternative = DR.Item("name_color_alternative")
                    End If
                    If Not DR.Item("name_color_alternative2") Is DBNull.Value Then
                        newColor.name_color_alternative2 = DR.Item("name_color_alternative2")
                    End If
                    If Not DR.Item("colorCode") Is DBNull.Value Then
                        newColor.colorCode = DR.Item("colorCode")
                    End If
                    If Not DR.Item("id_unit_on_entry") Is DBNull.Value Then
                        newColor.id_unit_on_entry = DR.Item("id_unit_on_entry")
                    End If
                    If Not DR.Item("masse_volumique") Is DBNull.Value Then
                        newColor.masse_volumique = DR.Item("masse_volumique")
                    End If
                    MyArray.Add(newColor)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Color)), Color())
    End Function

    Public Function getCurrencies() As Currency()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [usercurrency]")
                Dim i As Integer = 0

                While DR.Read
                    Dim newCurrency As New Currency
                    newCurrency.id_currency = DR.Item("id_currency")
                    If Not DR.Item("code_currency") Is DBNull.Value Then
                        newCurrency.code_currency = DR.Item("code_currency")
                    End If
                    If Not DR.Item("symbol") Is DBNull.Value Then
                        newCurrency.symbol = DR.Item("symbol")
                    End If
                    If Not DR.Item("rateToDollar") Is DBNull.Value Then
                        newCurrency.rateToDollar = DR.Item("rateToDollar")
                    End If

                    Dim MyArray2 As New ArrayList
                    Dim currencyLanguageTab() As CurrencyLanguage
                    Dim DR2 As OleDb.OleDbDataReader = selectQuery("Select * FROM currencyLanguage where id_currency=" & DR.Item("id_currency"))
                    While DR2.Read
                        Dim currencyLanguage As New CurrencyLanguage
                        currencyLanguage.id_currencyLanguage = DR2.Item("id_currencyLanguage")
                        currencyLanguage.id_currency = DR2.Item("id_currency")
                        currencyLanguage.id_language = DR2.Item("id_language")
                        If Not DR2.Item("label") Is DBNull.Value Then
                            currencyLanguage.label = DR2.Item("label")
                        End If

                        MyArray2.Add(currencyLanguage)
                    End While
                    DR2.Close()
                    currencyLanguageTab = DirectCast(MyArray2.ToArray(GetType(CurrencyLanguage)), CurrencyLanguage())
                    newCurrency.currencyLanguage = currencyLanguageTab
                    MyArray.Add(newCurrency)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Currency)), Currency())
    End Function


    Public Function getLabels() As Label()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [label]")
                Dim i As Integer = 0

                While DR.Read
                    Dim newLabel As New Label
                    newLabel.id_label = DR.Item("id_label")
                    If Not DR.Item("name_label") Is DBNull.Value Then
                        newLabel.name_label = DR.Item("name_label")
                    End If
                    Dim MyArray2 As New ArrayList
                    Dim labelLanguageTab() As LabelLanguage
                    Dim DR2 As OleDb.OleDbDataReader = selectQuery("Select * FROM labelLanguage where id_label=" & DR.Item("id_label"))
                    While DR2.Read
                        Dim labelLanguage As New LabelLanguage
                        labelLanguage.id_labelLanguage = DR2.Item("id_labelLanguage")
                        labelLanguage.id_label = DR.Item("id_label")
                        labelLanguage.id_language = DR2.Item("id_language")
                        If Not DR2.Item("description") Is DBNull.Value Then
                            labelLanguage.description = DR2.Item("description")
                        End If

                        MyArray2.Add(labelLanguage)
                    End While
                    DR2.Close()
                    labelLanguageTab = DirectCast(MyArray2.ToArray(GetType(LabelLanguage)), LabelLanguage())
                    newLabel.labelLanguage = labelLanguageTab
                    MyArray.Add(newLabel)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Label)), Label())
    End Function


#End Region

#Region "Formulas"

    Public Function getAllFormulaColorEncryptedSaipa(ByVal specificConString) As FormulaColor()

        Dim MyArray As New ArrayList
        If openSpecificConnection(specificConString) Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuerySpecificDB("Select * FROM [saipa_FormulaColor] where encrypted=1")
                Dim i As Integer = 0

                While DR.Read
                    Dim newFormulaColor As New FormulaColor
                    newFormulaColor.id_formulaColor = DR.Item("id_formulaColor")
                    If Not DR.Item("id_color") Is DBNull.Value Then
                        newFormulaColor.id_color = DR.Item("id_color")
                    End If
                    newFormulaColor.id_formula = DR.Item("id_formula")
                    If Not DR.Item("id_Unit") Is DBNull.Value Then
                        newFormulaColor.id_Unit = DR.Item("id_Unit")
                    End If
                    If Not DR.Item("quantite") Is DBNull.Value Then
                        newFormulaColor.quantiteEnc = DR.Item("quantite")
                    End If
                   
                    If Not DR.Item("encrypted") Is DBNull.Value Then
                        newFormulaColor.encryptedStr = DR.Item("encrypted")
                        If DR.Item("encrypted") = 1 Then
                            newFormulaColor.encrypted = True

                        End If
                    End If
                    newFormulaColor.id_carStr = newFormulaColor.id_car
                    newFormulaColor.id_formulaColorStr = newFormulaColor.id_formulaColor
                    newFormulaColor.id_colorStr = newFormulaColor.id_color
                    newFormulaColor.id_formulaStr = newFormulaColor.id_formula
                    newFormulaColor.quantiteStr = newFormulaColor.quantiteEnc



                    MyArray.Add(newFormulaColor)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeSpecificConnection()
        Dim formulaColorTab() As FormulaColor = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
        Return formulaColorTab


    End Function
    Public Function getAllFormulaColorEncrypted() As FormulaColor()

        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [FormulaColor] where encrypted=1")
                Dim i As Integer = 0

                While DR.Read
                    Dim newFormulaColor As New FormulaColor
                    newFormulaColor.id_formulaColor = DR.Item("id_formulaColor")
                    If Not DR.Item("id_color") Is DBNull.Value Then
                        newFormulaColor.id_color = DR.Item("id_color")
                    End If
                    newFormulaColor.id_formula = DR.Item("id_formula")
                    If Not DR.Item("id_Unit") Is DBNull.Value Then
                        newFormulaColor.id_Unit = DR.Item("id_Unit")
                    End If
                    If Not DR.Item("quantite") Is DBNull.Value Then
                        newFormulaColor.quantiteEnc = DR.Item("quantite")
                    End If
                  
                    If Not DR.Item("encrypted") Is DBNull.Value Then
                        newFormulaColor.encryptedStr = DR.Item("encrypted")
                        If DR.Item("encrypted") = 1 Then
                            newFormulaColor.encrypted = True

                        End If
                    End If

                    newFormulaColor.id_carStr = newFormulaColor.id_car
                    newFormulaColor.id_formulaColorStr = newFormulaColor.id_formulaColor
                    newFormulaColor.id_colorStr = newFormulaColor.id_color
                    newFormulaColor.id_formulaStr = newFormulaColor.id_formula
                    newFormulaColor.quantiteStr = newFormulaColor.quantiteEnc


                    MyArray.Add(newFormulaColor)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Dim formulaColorTab() As FormulaColor = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
        Return formulaColorTab

    End Function

    Public Function getLinkedMulticolor(ByVal id_formula As Integer) As String()

        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim sqlQuery = "SELECT name_formula,colorCode"
                sqlQuery &= " FROM formula f"
                sqlQuery &= " WHERE id_formulax=" & id_formula
                sqlQuery &= " OR id_formulay=" & id_formula
                sqlQuery &= " OR id_formulaz=" & id_formula
                sqlQuery &= " OR id_formulaxp=" & id_formula
                sqlQuery &= " OR id_formulax2p=" & id_formula
                sqlQuery &= " OR id_formulayp=" & id_formula
                sqlQuery &= " OR id_formulay2p=" & id_formula
                sqlQuery &= " OR id_formulazp=" & id_formula
                sqlQuery &= " OR id_formulaz2p=" & id_formula

                Dim DR As OleDb.OleDbDataReader = selectQuery(sqlQuery)
                Dim i As Integer = 0

                While DR.Read
                    Dim multiC As String
                    multiC = "Name = """ & DR.Item("name_formula") & """ , Code = """ & DR.Item("colorCode") & """"

                    MyArray.Add(multiC)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Dim formulaColorTab() As String = DirectCast(MyArray.ToArray(GetType(String)), String())
        Return formulaColorTab

    End Function
    Public Function testIfBColorsExist(ByVal formulaColorTab As FormulaColor()) As Boolean
        Dim allColorsExist As Boolean = True
        For i = 0 To formulaColorTab.Length - 1
            If getColorById(formulaColorTab(i).id_color) Is Nothing Then
                allColorsExist = False
                Exit For
            End If
        Next
        Return allColorsExist

    End Function


    Public Function getAllFormulaColors(Optional ByVal justNegatives As Boolean = False) As FormulaColor()

        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [FormulaColor]")
                Dim i As Integer = 0

                While DR.Read
                    i += 1
                    Dim newFormulaColor As New FormulaColor
                    newFormulaColor.id_formulaColor = DR.Item("id_formulaColor")
                    If Not DR.Item("id_color") Is DBNull.Value Then
                        newFormulaColor.id_color = DR.Item("id_color")
                    End If
                    newFormulaColor.id_formula = DR.Item("id_formula")
                    If Not DR.Item("id_Unit") Is DBNull.Value Then
                        newFormulaColor.id_Unit = DR.Item("id_Unit")
                    End If

                    Dim dbQuantity As String = ""
                    If Not DR.Item("quantite") Is DBNull.Value Then
                        dbQuantity = DR.Item("quantite")
                    End If
                    If Not DR.Item("encrypted") Is DBNull.Value Then
                        newFormulaColor.encryptedStr = DR.Item("encrypted")
                        If DR.Item("encrypted") = 1 Then
                            newFormulaColor.encrypted = True

                        End If
                    End If



                    If newFormulaColor.encrypted Then
                        'decrypt
                        newFormulaColor.quantite = decryptQuantity(dbQuantity, newFormulaColor.id_formulaColor)
                        '''''
                    Else
                        newFormulaColor.quantite = dbQuantity
                    End If


                    newFormulaColor.id_carStr = newFormulaColor.id_car
                    newFormulaColor.id_formulaColorStr = newFormulaColor.id_formulaColor
                    newFormulaColor.id_colorStr = newFormulaColor.id_color
                    newFormulaColor.id_formulaStr = newFormulaColor.id_formula
                    newFormulaColor.quantiteStr = newFormulaColor.quantite

                    If justNegatives Then
                        If newFormulaColor.quantite <= 0 Then
                            MyArray.Add(newFormulaColor)
                        End If
                    Else
                        MyArray.Add(newFormulaColor)
                    End If

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Dim formulaColorTab() As FormulaColor = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
        Return formulaColorTab

    End Function


    Public Function getFormulaColorsByIdColor(ByVal colorId As Integer) As FormulaColor()

        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [FormulaColor] WHERE id_color =" & colorId)
                Dim i As Integer = 0

                While DR.Read
                    Dim newFormulaColor As New FormulaColor
                    newFormulaColor.id_formulaColor = DR.Item("id_formulaColor")
                    If Not DR.Item("id_color") Is DBNull.Value Then
                        newFormulaColor.id_color = DR.Item("id_color")
                    End If
                    newFormulaColor.id_formula = DR.Item("id_formula")
                    If Not DR.Item("id_Unit") Is DBNull.Value Then
                        newFormulaColor.id_Unit = DR.Item("id_Unit")
                    End If

                    Dim dbQuantity As String = ""
                    If Not DR.Item("quantite") Is DBNull.Value Then
                        dbQuantity = DR.Item("quantite")
                    End If
                    If Not DR.Item("encrypted") Is DBNull.Value Then
                        newFormulaColor.encryptedStr = DR.Item("encrypted")
                        If DR.Item("encrypted") = 1 Then
                            newFormulaColor.encrypted = True

                        End If
                    End If



                    If newFormulaColor.encrypted Then
                        'decrypt
                        newFormulaColor.quantite = decryptQuantity(dbQuantity, newFormulaColor.id_formulaColor)
                        '''''
                    Else
                        newFormulaColor.quantite = dbQuantity
                    End If


                    newFormulaColor.id_carStr = newFormulaColor.id_car
                    newFormulaColor.id_formulaColorStr = newFormulaColor.id_formulaColor
                    newFormulaColor.id_colorStr = newFormulaColor.id_color
                    newFormulaColor.id_formulaStr = newFormulaColor.id_formula
                    newFormulaColor.quantiteStr = newFormulaColor.quantite

                    MyArray.Add(newFormulaColor)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Dim formulaColorTab() As FormulaColor = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
        Return formulaColorTab

    End Function


    Public Function getFormulaColorsByIdFormulaForHqConversion(ByVal formulaId As Integer, ByVal specificConnection As String) As FormulaColor()

        Dim MyArray As New ArrayList
        If openSpecificConnection(specificConnection) Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuerySpecificDB("Select * FROM [FormulaColor] WHERE id_formula =" & formulaId)
                Dim i As Integer = 0

                While DR.Read
                    Dim newFormulaColor As New FormulaColor
                    newFormulaColor.id_formulaColor = DR.Item("id_formulaColor")
                    If Not DR.Item("id_color") Is DBNull.Value Then
                        newFormulaColor.id_color = DR.Item("id_color")
                    End If
                    newFormulaColor.id_formula = DR.Item("id_formula")
                    If Not DR.Item("id_Unit") Is DBNull.Value Then
                        newFormulaColor.id_Unit = DR.Item("id_Unit")
                    End If

                    Dim dbQuantity As String = ""
                    If Not DR.Item("quantite") Is DBNull.Value Then
                        dbQuantity = DR.Item("quantite")
                    End If
                    If Not DR.Item("encrypted") Is DBNull.Value Then
                        newFormulaColor.encryptedStr = DR.Item("encrypted")
                        If DR.Item("encrypted") = 1 Then
                            newFormulaColor.encrypted = True

                        End If
                    End If

                    If newFormulaColor.encrypted Then
                        'decrypt
                        newFormulaColor.quantite = decryptQuantity(dbQuantity, newFormulaColor.id_formulaColor)
                        '''''
                    Else
                        newFormulaColor.quantite = dbQuantity
                    End If

                    newFormulaColor.id_carStr = newFormulaColor.id_car
                    newFormulaColor.id_formulaColorStr = newFormulaColor.id_formulaColor
                    newFormulaColor.id_colorStr = newFormulaColor.id_color
                    newFormulaColor.id_formulaStr = newFormulaColor.id_formula
                    newFormulaColor.quantiteStr = newFormulaColor.quantite

                    MyArray.Add(newFormulaColor)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeSpecificConnection()
        Dim formulaColorTab() As FormulaColor = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
        Return formulaColorTab

    End Function


    Public Function getFormulaColorsByIdFormula(ByVal formulaId As Integer, ByVal typeFormula As String, Optional ByVal ignoreEq As Boolean = False) As FormulaColor()

        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [FormulaColor] WHERE id_formula =" & formulaId)
                Dim i As Integer = 0

                While DR.Read
                    Dim newFormulaColor As New FormulaColor
                    newFormulaColor.id_formulaColor = DR.Item("id_formulaColor")
                    If Not DR.Item("id_color") Is DBNull.Value Then
                        newFormulaColor.id_color = DR.Item("id_color")
                    End If
                    newFormulaColor.id_formula = DR.Item("id_formula")
                    If Not DR.Item("id_Unit") Is DBNull.Value Then
                        newFormulaColor.id_Unit = DR.Item("id_Unit")
                    End If

                    Dim dbQuantity As String = ""
                    If Not DR.Item("quantite") Is DBNull.Value Then
                        dbQuantity = DR.Item("quantite")
                    End If
                    If Not DR.Item("encrypted") Is DBNull.Value Then
                        newFormulaColor.encryptedStr = DR.Item("encrypted")
                        If DR.Item("encrypted") = 1 Then
                            newFormulaColor.encrypted = True

                        End If
                    End If

                    If newFormulaColor.encrypted Then
                        'decrypt
                        newFormulaColor.quantite = decryptQuantity(dbQuantity, newFormulaColor.id_formulaColor)
                        '''''
                    Else
                        newFormulaColor.quantite = dbQuantity
                    End If

                    newFormulaColor.id_carStr = newFormulaColor.id_car
                    newFormulaColor.id_formulaColorStr = newFormulaColor.id_formulaColor
                    newFormulaColor.id_colorStr = newFormulaColor.id_color
                    newFormulaColor.id_formulaStr = newFormulaColor.id_formula
                    newFormulaColor.quantiteStr = newFormulaColor.quantite

                    MyArray.Add(newFormulaColor)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Dim formulaColorTab() As FormulaColor = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())

        'test if all basic colors exist
        If testIfBColorsExist(formulaColorTab) = False Then
            MsgBox("This Formula is corrupted because a basic color in it is absent from the basic colors list", MsgBoxStyle.Exclamation)
            Return Nothing
        End If
        ''''''''''''''''''''''''''''''''
        If Not ignoreEq Then


            If typeFormula = "LS" Then
                'formulaColorTab = applyEquationLS(formulaColorTab, "01")
                'formulaColorTab = applyEquationLS(formulaColorTab, "10") open Later

                'the queation is applied on creation
                'formulaColorTab = applyEquationLS_tmp(formulaColorTab)

                'sort descending
                formulaColorTab = sortDescending(formulaColorTab)
            Else
                If typeFormula = "BC" Then
                    formulaColorTab = applyEquationBC(formulaColorTab, "4002", "4110")
                End If
            End If
        End If
        Return formulaColorTab

    End Function
    Public Function applyEquationLS_tmp(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        If formulaColorTab Is Nothing Then
            MsgBox("Formula is empty!", MsgBoxStyle.Exclamation)
            Return Nothing
            If formulaColorTab.Length = 0 Then
                MsgBox("Formula is empty!", MsgBoxStyle.Exclamation)
                Return Nothing
            End If
        End If



        Dim indexOfLS01 As Integer = findIndexOfColorToUse(formulaColorTab, "01")

        Dim MyArray2 As New ArrayList
        Dim MyArrayIdFormulas As New ArrayList

        If indexOfLS01 <> -1 Then
            MyArray2.Add(formulaColorTab(indexOfLS01))
        End If

        Dim lengthTarget As Integer = formulaColorTab.Length
        While MyArray2.Count < lengthTarget
            'find max
            Dim min As Decimal = 999999999999999999
            Dim indexMin As Integer = -1
            For i = 0 To formulaColorTab.Length - 1
                If formulaColorTab(i).quantite < min And Not MyArrayIdFormulas.Contains(formulaColorTab(i).id_formulaColor) And i <> indexOfLS01 Then
                    min = formulaColorTab(i).quantite
                    indexMin = i
                End If
            Next
            MyArray2.Add(formulaColorTab(indexMin))
            'formulaColorTab(indexMin).id_formula = -1
            MyArrayIdFormulas.Add(formulaColorTab(indexMin).id_formulaColor)
        End While

        formulaColorTab = DirectCast(MyArray2.ToArray(GetType(FormulaColor)), FormulaColor())
        ''''''''''''''''''''''''''''''

        Return formulaColorTab
    End Function
    Public Function findIndexOfColorToUse(ByVal formulaColorTab As FormulaColor(), ByVal listOfColorCodeToUse As String, Optional ByVal specificConString As String = Nothing) As Integer
        Dim index As Integer = -1
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorByIdFromArray(formulaColorTab(i).id_color, specificConString)
            If curColor Is Nothing Then
                Continue For
            End If
            If curColor.colorCode.Trim = listOfColorCodeToUse.Trim Then
                index = i
                Exit For
            End If
        Next
        Return index
    End Function

    
    Public Function findQuantityOfColorInformula(ByVal formulaColorTab As FormulaColor(), ByVal colorCode As String, ByVal specificConString As String) As Double
        Dim indexColor As Integer = findIndexOfColorToUse(formulaColorTab, colorCode, specificConString)
        If indexColor = -1 Then
            Return 0
        End If
        Dim qty As Double = formulaColorTab(indexColor).quantite

        Return qty
    End Function

    Public Function getNegativeQtyFormulas() As Formula()
        Dim allNegativeFormulaColors As FormulaColor() = getAllFormulaColors(True)

        If allNegativeFormulaColors Is Nothing Then
            Return Nothing
        End If

        If allNegativeFormulaColors.Length = 0 Then
            Return Nothing
        End If


        Dim whereStr As String = " and formula.id_formula in("

        For i = 0 To allNegativeFormulaColors.Length - 1
            Dim formulaColor As FormulaColor = allNegativeFormulaColors(i)
            Dim idFormula As Integer = formulaColor.id_formula
            whereStr = whereStr & idFormula

            If i < allNegativeFormulaColors.Length - 1 Then
                whereStr = whereStr & ","
            End If
        Next
        whereStr = whereStr & ")"

        Dim allNegativeFormulas As Formula() = getFormulas(whereStr)


        Return allNegativeFormulas
    End Function
    Public Function getFormulas(ByVal whereStr As String, Optional ByVal specificConnection As String = Nothing) As Formula()
        Dim MyArray As New ArrayList
        Dim connectionOpened As Boolean = False
        If specificConnection Is Nothing Then
            connectionOpened = openConnection()
        Else
            connectionOpened = openSpecificConnection(specificConnection)
        End If

        If connectionOpened Then
            Try
                Dim DR As OleDb.OleDbDataReader
                If specificConnection Is Nothing Then
                    DR = selectQuery("Select car.id_car,car.carName,id_otherCurreny, [version],name_formula,type,id_otherUnit,id_formula,formulaImgPath,otherPrice,variant,duplicate,colorCode,colorRGB,c_year,cardNumber,id_formulaX,id_formulaY,id_formulaZ,id_formulaXp,id_formulaX2p,id_formulaYp,id_formulaY2p,id_formulaZp,id_formulaZ2p,isEquation15perc4201,date_cre_mod,noEquation4201_180,modified_once FROM [formula],[car] WHERE formula.id_car=car.id_car " & whereStr & " ORDER BY colorCode,[version] ")
                Else
                    DR = selectQuerySpecificDB("Select car.id_car,car.carName,id_otherCurreny, [version],name_formula,type,id_otherUnit,id_formula,formulaImgPath,otherPrice,variant,duplicate,colorCode,colorRGB,c_year,cardNumber,id_formulaX,id_formulaY,id_formulaZ,id_formulaXp,id_formulaX2p,id_formulaYp,id_formulaY2p,id_formulaZp,id_formulaZ2p,isEquation15perc4201,date_cre_mod,noEquation4201_180,modified_once FROM [formula],[car] WHERE formula.id_car=car.id_car " & whereStr & " ORDER BY colorCode,[version] ")

                End If
                Dim i As Integer = 0

                While DR.Read
                    Dim newFormula As New Formula
                    newFormula.id_formula = DR.Item("id_formula")
                    If Not DR.Item("formulaImgPath") Is DBNull.Value Then
                        newFormula.formulaImgPath = DR.Item("formulaImgPath")
                    End If
                    If Not DR.Item("otherPrice") Is DBNull.Value Then
                        newFormula.otherPrice = DR.Item("otherPrice")
                    End If
                    If Not DR.Item("id_otherCurreny") Is DBNull.Value Then
                        newFormula.id_otherCurreny = DR.Item("id_otherCurreny")
                    End If
                    If Not DR.Item("id_otherUnit") Is DBNull.Value Then
                        newFormula.id_otherUnit = DR.Item("id_otherUnit")
                    End If
                    If Not DR.Item("type") Is DBNull.Value Then
                        newFormula.type = DR.Item("type")
                    End If
                    If Not DR.Item(0) Is DBNull.Value Then
                        newFormula.id_car = DR.Item(0)
                    End If
                    If Not DR.Item(1) Is DBNull.Value Then
                        newFormula.name_car = DR.Item(1)
                    End If
                    If Not DR.Item("name_formula") Is DBNull.Value Then
                        newFormula.name_formula = DR.Item("name_formula")
                    End If
                    If Not DR.Item("version") Is DBNull.Value Then
                        newFormula.version = DR.Item("version")
                    End If
                    If Not DR.Item("variant") Is DBNull.Value Then
                        newFormula.variant = DR.Item("variant")
                    End If
                    If Not DR.Item("duplicate") Is DBNull.Value Then
                        newFormula.duplicate = DR.Item("duplicate")
                    End If
                    If Not DR.Item("colorCode") Is DBNull.Value Then
                        newFormula.colorCode = DR.Item("colorCode")
                    End If
                    If Not DR.Item("colorRGB") Is DBNull.Value Then
                        newFormula.colorRGB = DR.Item("colorRGB")
                    End If
                    If Not DR.Item("c_year") Is DBNull.Value Then
                        newFormula.c_year = DR.Item("c_year")
                    End If

                    If Not DR.Item("id_formulaX") Is DBNull.Value Then
                        newFormula.id_formulaX = DR.Item("id_formulaX")
                    End If
                    If Not DR.Item("id_formulaXp") Is DBNull.Value Then
                        newFormula.id_formulaXp = DR.Item("id_formulaXp")
                    End If
                    If Not DR.Item("id_formulaX2p") Is DBNull.Value Then
                        newFormula.id_formulaX2p = DR.Item("id_formulaX2p")
                    End If

                    If Not DR.Item("id_formulaY") Is DBNull.Value Then
                        newFormula.id_formulaY = DR.Item("id_formulaY")
                    End If
                    If Not DR.Item("id_formulaYp") Is DBNull.Value Then
                        newFormula.id_formulaYp = DR.Item("id_formulaYp")
                    End If
                    If Not DR.Item("id_formulaY2p") Is DBNull.Value Then
                        newFormula.id_formulaY2p = DR.Item("id_formulaY2p")
                    End If

                    If Not DR.Item("id_formulaZ") Is DBNull.Value Then
                        newFormula.id_formulaZ = DR.Item("id_formulaZ")
                    End If
                    If Not DR.Item("id_formulaZp") Is DBNull.Value Then
                        newFormula.id_formulaZp = DR.Item("id_formulaZp")
                    End If
                    If Not DR.Item("id_formulaZ2p") Is DBNull.Value Then
                        newFormula.id_formulaZ2p = DR.Item("id_formulaZ2p")
                    End If

                    If Not DR.Item("cardNumber") Is DBNull.Value Then
                        newFormula.cardNumber = DR.Item("cardNumber")
                    End If

                    If Not DR.Item("modified_once") Is DBNull.Value Then
                        If DR.Item("modified_once") = 1 Then
                            newFormula.modified_once = True
                        Else
                            newFormula.modified_once = False
                        End If
                    Else
                        newFormula.modified_once = True 'we dont want to show an asteriks
                    End If

                    newFormula.Date_cre_mod = ""
                    If Not DR.Item("date_cre_mod") Is DBNull.Value Then
                        Dim dateCreModStr As String = DR.Item("date_cre_mod")
                        newFormula.Date_cre_mod = dateCreModStr

                        Dim dateCreModStrTab() As String = dateCreModStr.Split(":")
                        Dim day As Integer = Integer.Parse(dateCreModStrTab(0))
                        Dim month As Integer = Integer.Parse(dateCreModStrTab(1))
                        Dim year As Integer = Integer.Parse(dateCreModStrTab(2))
                        Dim hour As Integer = Integer.Parse(dateCreModStrTab(3))
                        Dim minute As Integer = Integer.Parse(dateCreModStrTab(4))
                        Dim second As Integer = Integer.Parse(dateCreModStrTab(5))

                        Dim dateCreMod As New DateTime(year, month, day, hour, minute, second)
                        newFormula.dateCreMod = dateCreMod

                    End If
                    newFormula.isEquation15perc4201Str = ""
                    If Not DR.Item("isEquation15perc4201") Is DBNull.Value Then
                        newFormula.isEquation15perc4201Str = DR.Item("isEquation15perc4201")
                        If DR.Item("isEquation15perc4201") = 1 Then
                            newFormula.isEquation15perc4201 = True
                        Else
                            newFormula.isEquation15perc4201 = False
                        End If
                    Else
                        newFormula.isEquation15perc4201 = False
                    End If

                    newFormula.noEquation4201_180Str = ""
                    If Not DR.Item("noEquation4201_180") Is DBNull.Value Then
                        newFormula.noEquation4201_180Str = DR.Item("noEquation4201_180")
                        If DR.Item("noEquation4201_180") = 1 Then
                            newFormula.isEquation4201_180 = False
                        Else
                            newFormula.isEquation4201_180 = True
                        End If
                    Else
                        newFormula.isEquation4201_180 = True
                    End If

                    newFormula.id_formulaStr = newFormula.id_formula

                    newFormula.id_formulaXStr = newFormula.id_formulaX
                    newFormula.id_formulaXpStr = newFormula.id_formulaXp
                    newFormula.id_formulaX2pStr = newFormula.id_formulaX2p

                    newFormula.id_formulaYStr = newFormula.id_formulaY
                    newFormula.id_formulaYpStr = newFormula.id_formulaYp
                    newFormula.id_formulaY2pStr = newFormula.id_formulaY2p

                    newFormula.id_formulaZStr = newFormula.id_formulaZ
                    newFormula.id_formulaZpStr = newFormula.id_formulaZp
                    newFormula.id_formulaZ2pStr = newFormula.id_formulaZ2p

                    newFormula.id_carStr = newFormula.id_car
                    newFormula.id_otherCurrenyStr = newFormula.id_otherCurreny
                    newFormula.id_otherUnitStr = newFormula.id_otherUnit

                    newFormula.otherPriceStr = newFormula.otherPrice


                    MyArray.Add(newFormula)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox("whereStr=" & whereStr & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If

        If specificConnection Is Nothing Then
            closeConnection()
        Else
            closeSpecificConnection()
        End If

        Return DirectCast(MyArray.ToArray(GetType(Formula)), Formula())
    End Function


    Public Function getNextDuplicate(ByVal iFormula As Formula) As Formula
        Dim formulasTab As Formula()
        Dim whereStr As String
        If Not iFormula.version Is Nothing Then
            If iFormula.type = "" Then
                whereStr = " AND (type IS NULL or type='') AND "
            Else
                whereStr = " AND type='" & iFormula.type & "' AND "
            End If
        Else
            whereStr = " AND (type IS NULL or type='') AND "
        End If

        whereStr &= "car.id_car=" & iFormula.id_car & " AND "
        If Not iFormula.version Is Nothing Then
            If iFormula.version = "" Then
                whereStr &= " (version IS NULL or version='') AND "
            Else
                whereStr &= "version='" & iFormula.version & "' AND "
            End If

        Else
            whereStr &= " (version IS NULL or version='') AND "
        End If
        If Not iFormula.name_formula Is Nothing Then
            If iFormula.name_formula = "" Then
                whereStr &= " (name_formula IS NULL or name_formula='') AND "
            Else
                whereStr &= "name_formula='" & iFormula.name_formula & "' AND "
            End If

        Else
            whereStr &= " (name_formula IS NULL or name_formula='') AND "
        End If

        If Not iFormula.c_year Is Nothing Then
            If iFormula.c_year = "" Then
                whereStr &= " (c_year IS NULL or c_year='') AND "
            Else
                whereStr &= "c_year='" & iFormula.c_year & "' AND "
            End If

        Else
            whereStr &= " (c_year IS NULL or c_year='') AND "
        End If

        If Not iFormula.variant Is Nothing Then
            If iFormula.variant = "" Then
                whereStr &= " (variant IS NULL or variant='') AND "
            Else
                whereStr &= "variant='" & iFormula.variant & "' AND "
            End If

        Else
            whereStr &= " (variant IS NULL or variant='') AND "
        End If

        If Not iFormula.colorCode Is Nothing Then
            If iFormula.colorCode = "" Then
                whereStr &= " (colorCode IS NULL or colorCode='') AND "
            Else
                whereStr &= "colorCode='" & iFormula.colorCode & "' AND "
            End If

        Else
            whereStr &= " (colorCode IS NULL or colorCode='') AND "
        End If

        If Not iFormula.colorRGB Is Nothing Then
            If iFormula.colorRGB = "" Then
                whereStr &= " (colorRGB IS NULL or colorRGB='') order by id_formula "
            Else
                whereStr &= "colorRGB='" & iFormula.colorRGB & "' order by id_formula"
            End If

        Else
            whereStr &= " (colorRGB IS NULL AND or colorRGB='') order by id_formula"
        End If


        formulasTab = getFormulas(whereStr)
        Dim idThis = iFormula.id_formula
        Dim i As Integer
        Dim retFormula As Formula = Nothing
        For i = 0 To formulasTab.Length - 1
            If formulasTab(i).id_formula > idThis Then
                retFormula = formulasTab(i)
                Exit For
            End If
        Next
        If retFormula Is Nothing Then
            For i = 0 To formulasTab.Length - 1
                If formulasTab(i).id_formula <> idThis Then
                    retFormula = formulasTab(i)
                    Exit For
                End If
            Next
        End If
        If Not retFormula Is Nothing Then
            Return retFormula
        End If

        Return iFormula
    End Function

    Public Function applyEquationBC(ByVal formulaColorTab As FormulaColor(), ByVal colorCodeToFirst As String, ByVal colorCodeToLast As String, Optional ByVal specificConString As String = nothing) As FormulaColor()
        If formulaColorTab Is Nothing Then
            MsgBox("Formula is empty!", MsgBoxStyle.Exclamation)
            Return Nothing
            If formulaColorTab.Length = 0 Then
                MsgBox("Formula is empty!", MsgBoxStyle.Exclamation)
                Return Nothing
            End If
        End If



        Dim indexOfBC_first As Integer = findIndexOfColorToUse(formulaColorTab, colorCodeToFirst, specificConString)
        Dim indexOfBC_last As Integer = findIndexOfColorToUse(formulaColorTab, colorCodeToLast, specificConString)

        Dim MyArray2 As New ArrayList
        Dim MyArrayIdFormulas As New ArrayList

        If indexOfBC_first <> -1 Then
            MyArray2.Add(formulaColorTab(indexOfBC_first))
        End If

        Dim lengthTarget As Integer = formulaColorTab.Length
        If indexOfBC_last <> -1 Then
            lengthTarget = lengthTarget - 1
        End If

        While MyArray2.Count < lengthTarget
            'find max
            Dim max As Decimal = 0
            Dim indexMax As Integer = -1
            For i = 0 To formulaColorTab.Length - 1
                If (formulaColorTab(i).quantite > max) And Not MyArrayIdFormulas.Contains(formulaColorTab(i).id_formulaColor) And i <> indexOfBC_first And i <> indexOfBC_last Then
                    max = formulaColorTab(i).quantite

                    indexMax = i
                End If
            Next
            If indexMax <> -1 Then
                MyArray2.Add(formulaColorTab(indexMax))
                'formulaColorTab(indexMin).id_formula = -1
                MyArrayIdFormulas.Add(formulaColorTab(indexMax).id_formulaColor)
            End If
        End While

        If indexOfBC_last <> -1 Then
            MyArray2.Add(formulaColorTab(indexOfBC_last))
        End If

        formulaColorTab = DirectCast(MyArray2.ToArray(GetType(FormulaColor)), FormulaColor())
        ''''''''''''''''''''''''''''''


        Return formulaColorTab
    End Function

    Public Function applyEquationLS(ByVal formulaColorTab As FormulaColor(), ByVal colorCodeToSpread As String, Optional ByVal specificConString As String = Nothing) As FormulaColor()
        If formulaColorTab Is Nothing Then
            MsgBox("Formula is empty!", MsgBoxStyle.Exclamation)
            Return Nothing
        Else
            If formulaColorTab.Length = 0 Then
                MsgBox("Formula is empty!", MsgBoxStyle.Exclamation)
                Return Nothing
            End If
        End If

        'Dim colorCodeToSpread As String = "01"
        'delete "LS01" from formula 
        Dim MyArray As New ArrayList
        Dim originalTotal As Decimal = 0
        Dim clrSpreadQty As Decimal = 0
        For i = 0 To formulaColorTab.Length - 1
            originalTotal = originalTotal + formulaColorTab(i).quantite
            Dim curColor As Color = getColorByIdFromArray(formulaColorTab(i).id_color, specificConString)
            If curColor Is Nothing Then
                Continue For
            End If

            If curColor.colorCode = colorCodeToSpread Then
                clrSpreadQty = clrSpreadQty + formulaColorTab(i).quantite
            Else
                MyArray.Add(formulaColorTab(i))
            End If
        Next

        'safer testings
        If MyArray Is Nothing Then
            'MsgBox("Formula is empty without " & colorCodeToSpread & "!", MsgBoxStyle.Exclamation)
            Return formulaColorTab
        Else
            If MyArray.Count = 0 Then
                'MsgBox("Formula is empty without " & colorCodeToSpread & "!", MsgBoxStyle.Exclamation)
                Return formulaColorTab
            End If
        End If
        formulaColorTab = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())

        ''spread by % and find index of biggest qty
        Dim newTotal As Decimal = 0
        Dim biggestQty As Decimal = 0
        Dim indexBiggestQty = -1
        For i = 0 To formulaColorTab.Length - 1
            Dim qty As Decimal = formulaColorTab(i).quantite
            Dim newQty As Decimal
            newQty = qty + (qty * 100 / originalTotal) * clrSpreadQty / 100
            formulaColorTab(i).quantite = newQty
            newTotal = newTotal + formulaColorTab(i).quantite
            If newQty >= biggestQty Then
                biggestQty = newQty
                indexBiggestQty = i
            End If
        Next


        ''go back to original total
        For i = 0 To formulaColorTab.Length - 1
            Dim qty As Decimal = formulaColorTab(i).quantite
            Dim newQty As Decimal = originalTotal * qty / newTotal
            formulaColorTab(i).quantite = newQty
        Next

        '' make color with bigger qty first
        Dim biggestFormulaColor As FormulaColor = formulaColorTab(indexBiggestQty)
        Dim MyArray2 As New ArrayList
        MyArray2.Add(biggestFormulaColor)
        For i = 0 To formulaColorTab.Length - 1
            If i <> indexBiggestQty Then
                MyArray2.Add(formulaColorTab(i))
            End If
        Next
        formulaColorTab = DirectCast(MyArray2.ToArray(GetType(FormulaColor)), FormulaColor())
        ''''''''''''''''''''''''''''''

        Return formulaColorTab
    End Function


    Public Function sortDescending(ByVal formulaColorTab As FormulaColor()) As FormulaColor()
        If formulaColorTab Is Nothing Then
            MsgBox("Formula is empty!", MsgBoxStyle.Exclamation)
            Return Nothing
            If formulaColorTab.Length = 0 Then
                MsgBox("Formula is empty!", MsgBoxStyle.Exclamation)
                Return Nothing
            End If
        End If


        Dim MyArray2 As New ArrayList
        Dim MyArrayIdFormulas As New ArrayList
        Dim lengthTarget As Integer = formulaColorTab.Length

        While MyArray2.Count < lengthTarget
            'find max
            Dim indexMax As Integer = -1
            Dim max As Decimal = 0
            For i = 0 To formulaColorTab.Length - 1
                If formulaColorTab(i).quantite >= max And Not MyArrayIdFormulas.Contains(formulaColorTab(i).id_formulaColor) Then
                    max = formulaColorTab(i).quantite
                    indexMax = i
                End If
            Next
            MyArray2.Add(formulaColorTab(indexMax))
            'formulaColorTab(indexMin).id_formula = -1
            MyArrayIdFormulas.Add(formulaColorTab(indexMax).id_formulaColor)
        End While




        formulaColorTab = DirectCast(MyArray2.ToArray(GetType(FormulaColor)), FormulaColor())
        ''''''''''''''''''''''''''''''

        Return formulaColorTab
    End Function

    Public Function eqDoubleCBXB_50per4010(ByVal formulaColorTab As FormulaColor(), ByVal specificConString As String) As FormulaColor()
        Dim initTotalQty As Double = 0
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            initTotalQty += formulaColorTab(i).quantite
        Next



        'decrease 50% 4010
        Dim index4010 As Integer = findIndexOfColorToUse(formulaColorTab, "4010", specificConString)
        If index4010 <> -1 Then
            formulaColorTab(index4010).quantite = formulaColorTab(index4010).quantite / 2
        End If
        ''''''''''''''''''''''''''''''''''''''''

        'multiply *2 all the color below if they exist
        Dim listOfColorCode As String()
        ReDim listOfColorCode(21)
        listOfColorCode(0) = "4091"
        listOfColorCode(1) = "4101"
        listOfColorCode(2) = "4206"
        listOfColorCode(3) = "4581"
        'listOfColorCode(4) = "4704"
        listOfColorCode(4) = "4705"
        listOfColorCode(5) = "4107"
        listOfColorCode(6) = "4306"
        listOfColorCode(7) = "4307"
        listOfColorCode(8) = "4308"
        listOfColorCode(9) = "4403"
        listOfColorCode(10) = "4405"
        listOfColorCode(11) = "4407"
        listOfColorCode(12) = "4504"
        listOfColorCode(13) = "4507"
        listOfColorCode(14) = "4508"
        listOfColorCode(15) = "4605"
        listOfColorCode(16) = "4606"
        listOfColorCode(17) = "4607"
        listOfColorCode(18) = "4707"
        listOfColorCode(19) = "4708"
        listOfColorCode(20) = "4805"


        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorByIdFromArray(formulaColorTab(i).id_color, specificConString)
            If curColor Is Nothing Then
                Continue For
            End If
            '' if color 4002 divide the qty by 2
            If curColor.colorCode = "4002" Then
                formulaColorTab(i).quantite = formulaColorTab(i).quantite / 2
            End If

            'test if exist in listOfColorCode
            Dim j As Integer
            For j = 0 To listOfColorCode.Length - 1
                If listOfColorCode(j) = curColor.colorCode.Trim Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite * 2
                    Exit For
                End If
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''



        Dim finalTotalQty As Double = 0
        For i = 0 To formulaColorTab.Length - 1
            finalTotalQty += formulaColorTab(i).quantite
        Next

        'regle de trois
        For i = 0 To formulaColorTab.Length - 1
            Dim curQty As Double = formulaColorTab(i).quantite
            formulaColorTab(i).quantite = curQty * initTotalQty / finalTotalQty
        Next

        Return formulaColorTab
    End Function

    Public Function eqDoubleCBXB_50per4010Extended(ByVal formulaColorTab As FormulaColor(), ByVal specificConString As String) As FormulaColor()

        Dim initTotalQty As Double = 0
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            initTotalQty += formulaColorTab(i).quantite
        Next



        'decrease 50% 4010
        Dim index4010 As Integer = findIndexOfColorToUse(formulaColorTab, "4010", specificConString)
        If index4010 <> -1 Then
            formulaColorTab(index4010).quantite = formulaColorTab(index4010).quantite / 2
        End If
        ''''''''''''''''''''''''''''''''''''''''

        'multiply *2 all the color below if they exist
        Dim listOfColorCode As String()
        ReDim listOfColorCode(33)
        listOfColorCode(0) = "4091"
        listOfColorCode(1) = "4101"
        listOfColorCode(2) = "4206"
        listOfColorCode(3) = "4581"
        'listOfColorCode(4) = "4704"
        listOfColorCode(4) = "4705"
        listOfColorCode(5) = "4107"
        listOfColorCode(6) = "4306"
        listOfColorCode(7) = "4307"
        listOfColorCode(8) = "4308"
        listOfColorCode(9) = "4403"
        listOfColorCode(10) = "4405"
        listOfColorCode(11) = "4407"
        listOfColorCode(12) = "4504"
        listOfColorCode(13) = "4507"
        listOfColorCode(14) = "4508"
        listOfColorCode(15) = "4605"
        listOfColorCode(16) = "4606"
        listOfColorCode(17) = "4607"
        listOfColorCode(18) = "4707"
        listOfColorCode(19) = "4708"
        listOfColorCode(20) = "4805"
        listOfColorCode(21) = "4111"
        listOfColorCode(22) = "4211"
        listOfColorCode(23) = "4411"
        listOfColorCode(24) = "4425"
        listOfColorCode(25) = "4436"
        listOfColorCode(26) = "4511"
        listOfColorCode(27) = "4525"
        listOfColorCode(28) = "4526"
        listOfColorCode(29) = "4528"
        listOfColorCode(30) = "4711"
        listOfColorCode(31) = "4811"
        listOfColorCode(32) = "4910"



        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorByIdFromArray(formulaColorTab(i).id_color, specificConString)
            If curColor Is Nothing Then
                Continue For
            End If
            '' if color 4002 divide the qty by 2
            If curColor.colorCode = "4002" Then
                formulaColorTab(i).quantite = formulaColorTab(i).quantite / 2
            End If

            'test if exist in listOfColorCode
            Dim j As Integer
            For j = 0 To listOfColorCode.Length - 1
                If listOfColorCode(j) = curColor.colorCode.Trim Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite * 2
                    Exit For
                End If
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''



        Dim finalTotalQty As Double = 0
        For i = 0 To formulaColorTab.Length - 1
            finalTotalQty += formulaColorTab(i).quantite
        Next

        'regle de trois
        For i = 0 To formulaColorTab.Length - 1
            Dim curQty As Double = formulaColorTab(i).quantite
            formulaColorTab(i).quantite = curQty * initTotalQty / finalTotalQty
        Next

        Return formulaColorTab
    End Function

    Public Function extendedOptimization(ByVal formulaColorTab As FormulaColor(), ByVal isCouche As Boolean, ByVal specificConString As String) As FormulaColor()

        Dim initTotalQty As Double = 0
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            initTotalQty += formulaColorTab(i).quantite
        Next

        'remove 4002
        Dim MyArray As New ArrayList
        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorByIdFromArray(formulaColorTab(i).id_color, specificConString)
            If curColor Is Nothing Then
                Continue For
            End If
            If Not curColor.colorCode.Trim = "4002" Then
                MyArray.Add(formulaColorTab(i))
            End If
        Next
        formulaColorTab = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())

        'decrease 50% 4010 in case it wasn't couche
        Dim index4010 As Integer = findIndexOfColorToUse(formulaColorTab, "4010", specificConString)
        If index4010 <> -1 And Not isCouche Then
            formulaColorTab(index4010).quantite = formulaColorTab(index4010).quantite / 2
        End If
        ''''''''''''''''''''''''''''''''''''''''


        Dim finalTotalQty As Double = 0
        For i = 0 To formulaColorTab.Length - 1
            finalTotalQty += formulaColorTab(i).quantite
        Next

        'regle de trois
        For i = 0 To formulaColorTab.Length - 1
            Dim curQty As Double = formulaColorTab(i).quantite
            formulaColorTab(i).quantite = curQty * initTotalQty / finalTotalQty
        Next

        Return formulaColorTab
    End Function

    Public Function eqDoubleCBXB_50per4010_no4581_no4091(ByVal formulaColorTab As FormulaColor(), ByVal specificConString As String) As FormulaColor()

        Dim initTotalQty As Double = 0
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            initTotalQty += formulaColorTab(i).quantite
        Next



        'decrease 50% 4010
        Dim index4010 As Integer = findIndexOfColorToUse(formulaColorTab, "4010", specificConString)
        If index4010 <> -1 Then
            formulaColorTab(index4010).quantite = formulaColorTab(index4010).quantite / 2
        End If
        ''''''''''''''''''''''''''''''''''''''''

        'multiply *2 all the color below if they exist
        Dim listOfColorCode As String()
        ReDim listOfColorCode(19)
        'listOfColorCode(0) = "4091"
        listOfColorCode(0) = "4101"
        listOfColorCode(1) = "4206"
        'listOfColorCode(3) = "4581"
        'listOfColorCode(4) = "4704"
        listOfColorCode(2) = "4705"
        listOfColorCode(3) = "4107"
        listOfColorCode(4) = "4306"
        listOfColorCode(5) = "4307"
        listOfColorCode(6) = "4308"
        listOfColorCode(7) = "4403"
        listOfColorCode(8) = "4405"
        listOfColorCode(9) = "4407"
        listOfColorCode(10) = "4504"
        listOfColorCode(11) = "4507"
        listOfColorCode(12) = "4508"
        listOfColorCode(13) = "4605"
        listOfColorCode(14) = "4606"
        listOfColorCode(15) = "4607"
        listOfColorCode(16) = "4707"
        listOfColorCode(17) = "4708"
        listOfColorCode(18) = "4805"


        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorByIdFromArray(formulaColorTab(i).id_color, specificConString)
            If curColor Is Nothing Then
                Continue For
            End If
            '' if color 4002 divide the qty by 2
            If curColor.colorCode = "4002" Then
                formulaColorTab(i).quantite = formulaColorTab(i).quantite / 2
            End If

            'test if exist in listOfColorCode
            Dim j As Integer
            For j = 0 To listOfColorCode.Length - 1
                If listOfColorCode(j) = curColor.colorCode.Trim Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite * 2
                    Exit For
                End If
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''



        Dim finalTotalQty As Double = 0
        For i = 0 To formulaColorTab.Length - 1
            finalTotalQty += formulaColorTab(i).quantite
        Next

        'regle de trois
        For i = 0 To formulaColorTab.Length - 1
            Dim curQty As Double = formulaColorTab(i).quantite
            formulaColorTab(i).quantite = curQty * initTotalQty / finalTotalQty
        Next

        Return formulaColorTab
    End Function

    Public Function eqDivedBy2If4201BigThenOrEq180(ByVal formulaColorTab As FormulaColor(), ByVal specificConString As String) As FormulaColor()

        ''''' checking the existance and the quanty of 4201 is done before
        ''''''''''''''''''''''''''''''''''''''''

        Dim initTotalQty As Double = 0
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            initTotalQty += formulaColorTab(i).quantite
        Next



        'dived by 2 all the color below if they exist
        Dim listOfColorCode As String()
        ReDim listOfColorCode(11)
        listOfColorCode(0) = "4025"
        listOfColorCode(1) = "4640"
        listOfColorCode(2) = "4440"
        listOfColorCode(3) = "4047"
        listOfColorCode(4) = "4041"
        listOfColorCode(5) = "4188"
        listOfColorCode(6) = "4084"
        listOfColorCode(7) = "4082"
        listOfColorCode(8) = "4030"
        listOfColorCode(9) = "4985"
        listOfColorCode(10) = "4934"



        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorByIdFromArray(formulaColorTab(i).id_color, specificConString)
            If curColor Is Nothing Then
                Continue For
            End If
            'test if exist in listOfColorCode
            Dim j As Integer
            For j = 0 To listOfColorCode.Length - 1
                If listOfColorCode(j) = curColor.colorCode.Trim Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite / 2
                    Exit For
                End If
            Next
        Next
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''



        Dim finalTotalQty As Double = 0
        For i = 0 To formulaColorTab.Length - 1
            finalTotalQty += formulaColorTab(i).quantite
        Next

        'regle de trois
        For i = 0 To formulaColorTab.Length - 1
            Dim curQty As Double = formulaColorTab(i).quantite
            formulaColorTab(i).quantite = curQty * initTotalQty / finalTotalQty
        Next

        Return formulaColorTab
    End Function

    Public Function eq4080_4082_4060(ByVal formulaColorTab As FormulaColor(), ByVal specificConString As String) As FormulaColor()

        ''''' checking the existance and the quanty of 4201 is done before
        ''''''''''''''''''''''''''''''''''''''''

        Dim initTotalQty As Double = 0
        Dim i As Integer
        For i = 0 To formulaColorTab.Length - 1
            initTotalQty += formulaColorTab(i).quantite
        Next



        'multiply by 1.25 all the color below if they exist
        Dim listOfColorCode As String()
        ReDim listOfColorCode(11)
        listOfColorCode(0) = "4080"
        listOfColorCode(1) = "4082"
        listOfColorCode(2) = "4060"


        For i = 0 To formulaColorTab.Length - 1
            Dim curColor As Color = getColorByIdFromArray(formulaColorTab(i).id_color, specificConString)
            If curColor Is Nothing Then
                Continue For
            End If
            'test if exist in listOfColorCode
            Dim j As Integer
            For j = 0 To listOfColorCode.Length - 1
                If listOfColorCode(j) = curColor.colorCode.Trim Then
                    formulaColorTab(i).quantite = formulaColorTab(i).quantite * 1.25
                    Exit For
                End If
            Next
        Next
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''



        Dim finalTotalQty As Double = 0
        For i = 0 To formulaColorTab.Length - 1
            finalTotalQty += formulaColorTab(i).quantite
        Next

        'regle de trois
        For i = 0 To formulaColorTab.Length - 1
            Dim curQty As Double = formulaColorTab(i).quantite
            formulaColorTab(i).quantite = curQty * initTotalQty / finalTotalQty
        Next

        Return formulaColorTab
    End Function

#End Region

#Region "Cars"

    Public Function getCarById(ByVal id) As Car
        Dim car As Car
        car = New Car()
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [car] where id_car =" & id)
                Dim i As Integer = 0

                If DR.Read Then
                    car.id_car = DR.Item("id_car")
                    car.id_carStr = car.id_car
                    If Not DR.Item("model") Is DBNull.Value Then
                        car.model = DR.Item("model")
                    End If
                    If Not DR.Item("carImgPath") Is DBNull.Value Then
                        car.carImgPath = DR.Item("carImgPath")
                    End If
                    If Not DR.Item("carName") Is DBNull.Value Then
                        car.carName = DR.Item("carName")
                    End If
                    If Not DR.Item("tableName") Is DBNull.Value Then
                        car.tableName = DR.Item("tableName")
                    End If
                    If Not DR.Item("colorCodeLocation") Is DBNull.Value Then
                        car.colorCodeLocation = DR.Item("colorCodeLocation")
                    End If
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return car
    End Function
    Public Function getLastChosenCar() As Car
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [globalVariables] WHERE variable_name='id_car'")
                Dim i As Integer = 0

                If DR.Read Then
                    If Not DR.Item("variable_value") Is DBNull.Value Then
                        getLastChosenCar = getCarById(DR.Item("variable_value"))
                    Else
                        getLastChosenCar = Nothing
                    End If

                Else
                    getLastChosenCar = Nothing
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
    End Function
    Public Function getLastChosenBaseCoat() As String
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [globalVariables] WHERE variable_name='chosenBaseCoat'")
                Dim i As Integer = 0

                If DR.Read Then
                    If Not DR.Item("variable_value") Is DBNull.Value Then
                        getLastChosenBaseCoat = DR.Item("variable_value").trim
                    Else
                        getLastChosenBaseCoat = Nothing
                    End If

                Else
                    getLastChosenBaseCoat = Nothing
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
    End Function
    Public Function getCars(ByVal whereStr As String) As Car()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [car] " & whereStr & " Order by carName")
                Dim i As Integer = 0

                While DR.Read
                    Dim newcar As New Car

                    newcar.id_car = DR.Item("id_car")
                    newcar.id_carStr = newcar.id_car
                    If Not DR.Item("carName") Is DBNull.Value Then
                        newcar.carName = DR.Item("carName").trim
                    End If
                    If Not DR.Item("tableName") Is DBNull.Value Then
                        newcar.tableName = DR.Item("tableName")
                    End If
                    If Not DR.Item("model") Is DBNull.Value Then
                        newcar.model = DR.Item("model").trim
                    End If
                    If Not DR.Item("carImgPath") Is DBNull.Value Then
                        newcar.carImgPath = DR.Item("carImgPath").trim
                    End If
                    MyArray.Add(newcar)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Car)), Car())
    End Function

#End Region

#Region "language"

    Public Function getLanguages(ByVal whereStr As String) As Language()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [language] " & whereStr)
                Dim i As Integer = 0

                While DR.Read
                    Dim newLang As New Language

                    newLang.id_language = DR.Item("id_language")
                    If Not DR.Item("code_language") Is DBNull.Value Then
                        newLang.code_language = DR.Item("code_language").trim
                    End If
                    If Not DR.Item("label_language") Is DBNull.Value Then
                        newLang.label_language = DR.Item("label_language").trim
                    End If

                    MyArray.Add(newLang)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Language)), Language())
    End Function

#End Region

#Region "garage"

    Public Function getGarages(ByVal whereStr As String) As Garage()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [garage] " & whereStr)
                Dim i As Integer = 0

                While DR.Read
                    Dim newGarage As New Garage

                    newGarage.id_garage = DR.Item("id_garage")
                    newGarage.id_garageStr = DR.Item("id_garage")

                    If Not DR.Item("garage_name") Is DBNull.Value Then
                        newGarage.garage_name = DR.Item("garage_name").trim
                    End If
                    If Not DR.Item("name_responsible") Is DBNull.Value Then
                        newGarage.name_responsible = DR.Item("name_responsible").trim
                    End If
                    If Not DR.Item("location") Is DBNull.Value Then
                        newGarage.location = DR.Item("location").trim
                    End If
                    If Not DR.Item("version") Is DBNull.Value Then
                        newGarage.version = DR.Item("version").trim
                    End If
                    If Not DR.Item("id_language") Is DBNull.Value Then
                        newGarage.id_language = DR.Item("id_language")
                        newGarage.id_languageStr = newGarage.id_language
                    End If
                    If Not DR.Item("logo") Is DBNull.Value Then
                        newGarage.logo = DR.Item("logo")
                    End If

                    If Not DR.Item("chosen") Is DBNull.Value Then
                        newGarage.chosenStr = DR.Item("chosen")
                        If DR.Item("chosen") = "1" Then
                            newGarage.chosen = True
                        Else
                            newGarage.chosen = False
                        End If

                    End If

                    newGarage.showAlternativeName = False
                    newGarage.showAlternativeName2 = False

                    If Not DR.Item("showAlternativeName") Is DBNull.Value Then
                        newGarage.showAlternativeNameDBValue = DR.Item("showAlternativeName")
                        If DR.Item("showAlternativeName") = "1" Then
                            newGarage.showAlternativeName = True
                        Else
                            If DR.Item("showAlternativeName") = "2" Then
                                newGarage.showAlternativeName2 = True
                            End If
                        End If

                    End If


                    If Not DR.Item("coat") Is DBNull.Value Then
                        newGarage.coat = DR.Item("coat").trim
                    End If
                    If Not DR.Item("tel") Is DBNull.Value Then
                        newGarage.tel = DR.Item("tel")
                    End If
                    If Not DR.Item("key") Is DBNull.Value Then
                        newGarage.key = DR.Item("key")
                    End If

                    If Not DR.Item("theme_color") Is DBNull.Value Then
                        newGarage.themeColor = DR.Item("theme_color")
                    End If

                    If Not DR.Item("username") Is DBNull.Value Then
                        newGarage.username = DR.Item("username")
                    End If


                    newGarage.apply_equation = False
                    newGarage.apply_equation2 = False
                    If Not DR.Item("apply_equation") Is DBNull.Value Then
                        Dim appEqDB As String = DR.Item("apply_equation")
                        newGarage.apply_equationDBValue = appEqDB

                        Dim appEq As Integer = 0
                        Dim eqq5 As Boolean = False
                        Dim eqq6 As Boolean = False
                        If appEqDB.IndexOf("+") = -1 Then
                            appEq = Integer.Parse(appEqDB)
                        Else
                            Try
                                appEq = Integer.Parse(appEqDB.Substring(0, appEqDB.IndexOf("+")))
                                If appEqDB.Substring(appEqDB.IndexOf("+") + 1).Contains("eq6") Then
                                    Dim temp As String = (appEqDB.Substring(appEqDB.IndexOf("+") + 1))
                                    eqq5 = Boolean.Parse(temp.Substring(0, temp.IndexOf("eq6")))
                                    eqq6 = Boolean.Parse(temp.Substring(temp.IndexOf("eq6") + 3))
                                Else
                                    eqq5 = Boolean.Parse(appEqDB.Substring(appEqDB.IndexOf("+") + 1))
                                End If
                            Catch ex As Exception
                                MsgBox("Verify garage data (Appy eq field)", MsgBoxStyle.Exclamation)
                                Throw ex
                            End Try
                        End If

                        newGarage.apply_equation5 = eqq5
                        newGarage.apply_equation6 = eqq6

                        If appEq = 1 Then
                            newGarage.apply_equation = True
                        Else
                            If appEq = 2 Then
                                newGarage.apply_equation2 = True
                            Else
                                If appEq = 3 Then
                                    newGarage.apply_equation3 = True
                                Else
                                    If appEq = 4 Then
                                        newGarage.apply_equation4 = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                    MyArray.Add(newGarage)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(Garage)), Garage())
    End Function

    Public Function getChosenGarage(Optional ByVal specificConnection As String = Nothing) As Garage
        Dim connectionOpened As Boolean = False
        If specificConnection Is Nothing Then
            connectionOpened = openConnection()
        Else
            connectionOpened = openSpecificConnection(specificConnection)
        End If

        If connectionOpened Then
            Try
                Dim DR As OleDb.OleDbDataReader
                If specificConnection Is Nothing Then
                    DR = selectQuery("Select * FROM [Garage] where chosen='1'")
                Else
                    DR = selectQuerySpecificDB("Select * FROM [Garage] where chosen='1'")
                End If
                Dim i As Integer = 0

                If DR.Read Then
                    Dim garage As Garage
                    garage = New Garage()

                    garage.id_garage = DR.Item("id_garage")
                    garage.id_garageStr = DR.Item("id_garage")
                    garage.chosenStr = "1"
                    garage.chosen = True

                    If Not DR.Item("id_language") Is DBNull.Value Then
                        garage.id_language = DR.Item("id_language")
                        garage.id_languageStr = garage.id_language
                    End If
                    If Not DR.Item("name_responsible") Is DBNull.Value Then
                        garage.name_responsible = DR.Item("name_responsible")
                    End If
                    If Not DR.Item("garage_name") Is DBNull.Value Then
                        garage.garage_name = DR.Item("garage_name")
                    End If
                    If Not DR.Item("location") Is DBNull.Value Then
                        garage.location = DR.Item("location")
                    End If
                    If Not DR.Item("version") Is DBNull.Value Then
                        garage.version = DR.Item("version").trim
                    End If
                    If Not DR.Item("logo") Is DBNull.Value Then
                        garage.logo = DR.Item("logo")
                    End If
                    If Not DR.Item("coat") Is DBNull.Value Then
                        garage.coat = DR.Item("coat")
                    End If
                    If Not DR.Item("tel") Is DBNull.Value Then
                        garage.tel = DR.Item("tel")
                    End If
                    If Not DR.Item("key") Is DBNull.Value Then
                        garage.key = DR.Item("key")
                    End If
                    If Not DR.Item("key1") Is DBNull.Value Then
                        garage.key1 = DR.Item("key1")
                    End If
                    If Not DR.Item("theme_color") Is DBNull.Value Then
                        garage.themeColor = DR.Item("theme_color")
                    End If
                    If Not DR.Item("username") Is DBNull.Value Then
                        garage.username = DR.Item("username")
                    End If


                    garage.apply_equation = False
                    garage.apply_equation2 = False
                    If Not DR.Item("apply_equation") Is DBNull.Value Then
                        Dim appEqDB As String = DR.Item("apply_equation")
                        garage.apply_equationDBValue = appEqDB
                        Dim appEq As Integer = 0
                        Dim eqq5 As Boolean = False
                        Dim eqq6 As Boolean = False
                        If appEqDB.IndexOf("+") = -1 Then
                            appEq = Integer.Parse(appEqDB)
                        Else
                            Try
                                appEq = Integer.Parse(appEqDB.Substring(0, appEqDB.IndexOf("+")))
                                If appEqDB.Substring(appEqDB.IndexOf("+") + 1).Contains("eq6") Then
                                    Dim temp As String = (appEqDB.Substring(appEqDB.IndexOf("+") + 1))
                                    eqq5 = Boolean.Parse(temp.Substring(0, temp.IndexOf("eq6")))
                                    eqq6 = Boolean.Parse(temp.Substring(temp.IndexOf("eq6") + 3))
                                Else
                                    eqq5 = Boolean.Parse(appEqDB.Substring(appEqDB.IndexOf("+") + 1))
                                End If
                            Catch ex As Exception
                                MsgBox("Verify garage data (Appy eq field)", MsgBoxStyle.Exclamation)
                                Throw ex
                            End Try
                        End If

                        garage.apply_equation5 = eqq5
                        garage.apply_equation6 = eqq6
                        If appEq = 1 Then
                            garage.apply_equation = True
                        Else
                            If appEq = 2 Then
                                garage.apply_equation2 = True
                            Else
                                If appEq = 3 Then
                                    garage.apply_equation3 = True
                                Else
                                    If appEq = 4 Then
                                        garage.apply_equation4 = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                    garage.showAlternativeName = False
                    garage.showAlternativeName2 = False
                    If Not DR.Item("showAlternativeName") Is DBNull.Value Then
                        garage.showAlternativeNameDBValue = DR.Item("showAlternativeName")

                        If DR.Item("showAlternativeName") = "1" Then
                            garage.showAlternativeName = True
                        Else
                            If DR.Item("showAlternativeName") = "2" Then
                                garage.showAlternativeName2 = True
                            End If
                        End If

                    End If

                    garage.chosen = True
                    getChosenGarage = garage

                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        If specificConnection Is Nothing Then
            closeConnection()
        Else
            closeSpecificConnection()
        End If
    End Function

#End Region

#Region "color"

    Public Function getColorTotalQty(ByVal idColor As Integer) As Decimal
        getColorTotalQty = 0
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select id_formulaColor,quantite,encrypted FROM [formulaColor] where id_color=" & idColor)

                While DR.Read

                    Dim quantiteDec As Decimal
                    Dim encrypted As Boolean = False
                    Dim id_formulaColor As Integer = DR.Item("id_formulaColor")

                    Dim dbQuantity As String = ""
                    If Not DR.Item("quantite") Is DBNull.Value Then
                        dbQuantity = DR.Item("quantite")
                    End If
                    If Not DR.Item("encrypted") Is DBNull.Value Then
                        If DR.Item("encrypted") = 1 Then
                            encrypted = True

                        End If
                    End If

                    If encrypted Then
                        'decrypt
                        quantiteDec = decryptQuantity(dbQuantity, id_formulaColor)
                        '''''
                    Else
                        quantiteDec = dbQuantity
                    End If
                    getColorTotalQty += quantiteDec
                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return getColorTotalQty
    End Function
    Public Function getNumberOfFormulas(ByVal idColor As Integer) As Decimal
        getNumberOfFormulas = 0
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select count(*) as totalCount FROM [formulaColor] where id_color=" & idColor)

                If DR.Read Then
                    If Not DR.Item("totalCount") Is DBNull.Value Then
                        getNumberOfFormulas = DR.Item("totalCount")
                    End If
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
    End Function
    Public Function getColors(ByVal whereStr As String, Optional ByVal specificConString As String = Nothing) As Color()
        Dim MyArray As New ArrayList
        Dim connectionOpened As Boolean = False
        If specificConString Is Nothing Then
            connectionOpened = openConnection()
        Else
            connectionOpened = openSpecificConnection(specificConString)
        End If
        If connectionOpened Then
            Try
                Dim DR As OleDb.OleDbDataReader
                If specificConString Is Nothing Then
                    DR = selectQuery("Select * FROM [color] " & whereStr)
                Else
                    DR = selectQuerySpecificDB("Select * FROM [color] " & whereStr)
                End If

                Dim i As Integer = 0

                While DR.Read
                    Dim newcolor As New Color

                    newcolor.id_color = DR.Item("id_color")
                    newcolor.id_colorStr = newcolor.id_color
                    If Not DR.Item("name_color") Is DBNull.Value Then
                        newcolor.name_color = DR.Item("name_color").trim
                    End If
                    If Not DR.Item("name_color_alternative") Is DBNull.Value Then
                        newcolor.name_color_alternative = DR.Item("name_color_alternative")
                    End If
                    If Not DR.Item("name_color_alternative2") Is DBNull.Value Then
                        newcolor.name_color_alternative2 = DR.Item("name_color_alternative2")
                    End If
                    If Not DR.Item("defaultPrice") Is DBNull.Value Then
                        newcolor.defaultPrice = DR.Item("defaultPrice")
                        newcolor.defaultPriceStr = newcolor.defaultPrice
                    End If
                    If Not DR.Item("id_defaultCurreny") Is DBNull.Value Then
                        newcolor.id_defaultCurreny = DR.Item("id_defaultCurreny")
                        newcolor.id_defaultCurrenyStr = newcolor.id_defaultCurreny
                    End If
                    If Not DR.Item("id_defaultUnit") Is DBNull.Value Then
                        newcolor.id_defaultUnit = DR.Item("id_defaultUnit")
                        newcolor.id_defaultUnitStr = newcolor.id_defaultUnit
                    End If
                    If Not DR.Item("colorImgPath") Is DBNull.Value Then
                        newcolor.colorImgPath = DR.Item("colorImgPath")
                    End If
                    If Not DR.Item("colorCode") Is DBNull.Value Then
                        newcolor.colorCode = DR.Item("colorCode")
                    End If
                    If Not DR.Item("id_unit_on_entry") Is DBNull.Value Then
                        newcolor.id_unit_on_entry = DR.Item("id_unit_on_entry")
                        newcolor.id_unit_on_entryStr = newcolor.id_unit_on_entry
                    End If
                    If Not DR.Item("masse_volumique") Is DBNull.Value Then
                        newcolor.masse_volumique = DR.Item("masse_volumique")
                    End If
                    If Not DR.Item("masse_volumique_ext") Is DBNull.Value Then
                        newcolor.masse_volumique_ext = DR.Item("masse_volumique_ext")
                    End If
                    If Not DR.Item("argb") Is DBNull.Value Then
                        newcolor.argb = DR.Item("argb")

                    End If
                    MyArray.Add(newcolor)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        If specificConString Is Nothing Then
            closeConnection()
        Else
            closeSpecificConnection()
        End If

        Return DirectCast(MyArray.ToArray(GetType(Color)), Color())
    End Function
#End Region

#Region "Labels"

    Public Function getLabelDescription(ByVal name_label As String) As String
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader
                DR = selectQuery(String.Format("SELECT description FROM [Label] lb,[labelLanguage] la WHERE lb.id_label=la.id_label AND la.id_language={0} AND name_label='{1}'", chosenLanguage.id_language, name_label))
                Dim i As Integer = 0

                If DR.Read Then
                    If Not DR.Item("description") Is DBNull.Value Then
                        getLabelDescription = DR.Item("description").trim
                    Else
                        getLabelDescription = ""
                    End If
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
    End Function
#End Region

#Region "font"
    Public Function getFontSize() As Integer
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader
                DR = selectQuery(String.Format("SELECT font_size FROM [lastFont]"))
                Dim i As Integer = 0

                If DR.Read Then
                    If Not DR.Item("font_size") Is DBNull.Value Then
                        getFontSize = DR.Item("font_size")
                    Else
                        getFontSize = 9
                    End If
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
    End Function

#End Region

#Region "unit"
    Public Function getUnitLanguage(ByVal id_unit) As UnitLanguage()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [UnitLanguage] where id_unit=" & id_unit)
                Dim i As Integer = 0

                While DR.Read
                    Dim unitLanguage As UnitLanguage
                    unitLanguage = New UnitLanguage()

                    unitLanguage.id_unitLanguage = DR.Item("id_unitLanguage")
                    If Not DR.Item("id_unit") Is DBNull.Value Then
                        unitLanguage.id_unit = DR.Item("id_unit")
                    End If
                    If Not DR.Item("id_language") Is DBNull.Value Then
                        unitLanguage.id_language = DR.Item("id_language")
                    End If

                    If Not DR.Item("name_unit") Is DBNull.Value Then
                        unitLanguage.name_unit = DR.Item("name_unit")
                    End If

                    MyArray.Add(unitLanguage)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(UnitLanguage)), UnitLanguage())
    End Function


    Public Function getChosenUnit() As Unit
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [unit] where chosen='1'")
                Dim i As Integer = 0

                If DR.Read Then
                    Dim unit As Unit
                    unit = New Unit()

                    unit.id_unit = DR.Item("id_unit")
                    If Not DR.Item("code_unit") Is DBNull.Value Then
                        unit.code_unit = DR.Item("code_unit")
                    End If
                    If Not DR.Item("rateToLitre") Is DBNull.Value Then
                        unit.rateToLitre = DR.Item("rateToLitre")
                    End If
                    unit.unitLanguage = getUnitLanguage(unit.id_unit)
                    unit.chosen = True
                    getChosenUnit = unit
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
    End Function

#End Region

#Region "currency"
    Public Function getCurrencyLanguage(ByVal id_unit) As CurrencyLanguage()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [currencyLanguage] where id_currency=" & id_unit)
                Dim i As Integer = 0

                While DR.Read
                    Dim currencyLanguage As CurrencyLanguage
                    currencyLanguage = New CurrencyLanguage()

                    currencyLanguage.id_currencyLanguage = DR.Item("id_currencyLanguage")
                    If Not DR.Item("id_currency") Is DBNull.Value Then
                        currencyLanguage.id_currency = DR.Item("id_currency")
                    End If
                    If Not DR.Item("id_language") Is DBNull.Value Then
                        currencyLanguage.id_language = DR.Item("id_language")
                    End If

                    If Not DR.Item("label") Is DBNull.Value Then
                        currencyLanguage.label = DR.Item("label")
                    End If

                    MyArray.Add(currencyLanguage)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(CurrencyLanguage)), CurrencyLanguage())
    End Function


    Public Function getChosenCurreny() As Currency
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [userCurrency] where chosen='1'")
                Dim i As Integer = 0

                If DR.Read Then
                    Dim currency As Currency
                    currency = New Currency()

                    currency.id_currency = DR.Item("id_currency")
                    If Not DR.Item("code_currency") Is DBNull.Value Then
                        currency.code_currency = DR.Item("code_currency")
                    End If
                    If Not DR.Item("rateToDollar") Is DBNull.Value Then
                        currency.rateToDollar = DR.Item("rateToDollar")
                    End If
                    currency.currencyLanguage = getCurrencyLanguage(currency.id_currency)
                    currency.chosen = True
                    getChosenCurreny = currency
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
    End Function

#End Region
End Module
