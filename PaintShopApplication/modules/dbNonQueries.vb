Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SQLite

Module dbNonQueries
#Region "optimizing garage db"
    Public Function executeCreateDropQuery(ByVal query As String, ByVal specificConString As String) As Boolean
        openSpecificConnection(specificConString)
        Dim SQLstr As String
        SQLstr = String.Format(query)
        Dim Command As New OleDb.OleDbCommand(SQLstr, specifDB)

        Dim icount As Integer = Command.ExecuteNonQuery()

        closeSpecificConnection()
        Return True
    End Function

    Public Function executeInsertQuery(ByVal query As String, ByVal specificConString As String) As Boolean
        openSpecificConnection(specificConString)
        Dim SQLstr As String
        SQLstr = String.Format(query)
        Dim Command As New OleDb.OleDbCommand(SQLstr, specifDB)

        Dim icount As Integer = Command.ExecuteNonQuery()
        If icount > 0 Then
            executeInsertQuery = True
        Else
            executeInsertQuery = False
        End If
        closeSpecificConnection()

    End Function

#End Region

#Region "mobileSync"
    Public Sub insertFormulaIntoMobileSyncDeleteTable(ByVal idTable As Integer, ByVal colorCode As String, ByVal name_formula As String, ByVal formulaType As String, ByVal id_car As String, ByVal name_car As String, ByVal version As String)
        Dim syncTable As String = "formula"

        Dim strSQL As String = "INSERT INTO mobileDeleteSync (syncTable, idTable, colorCode, name_color, type, id_car, carName, version,currentLastSyncVersion) VALUES (?,?,?,?,?,?,?,?,?)"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)


            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@idTable", idTable)
            cmd.Parameters.AddWithValue("@colorCode", colorCode)
            cmd.Parameters.AddWithValue("@name_color", name_formula)
            cmd.Parameters.AddWithValue("@type", formulaType)
            cmd.Parameters.AddWithValue("@id_car", id_car)
            cmd.Parameters.AddWithValue("@carName", name_car)
            cmd.Parameters.AddWithValue("@version", version)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using

        deleteFromEditMobileSync(idTable, syncTable)
    End Sub

    Public Sub insertGarageIntoMobileSyncDeleteTable(ByVal idTable As Integer, ByVal garage_name As String, ByVal location As String, ByVal name_responsible As String, ByVal id_language As Integer, ByVal version As String, ByVal coat As String, ByVal username As String, ByVal apply_equation As String)
        Dim syncTable As String = "garage"

        Dim strSQL As String = "INSERT INTO mobileDeleteSync (syncTable, idTable, garage_name, location, name_responsible, id_language, version, coat, username, apply_equation, currentLastSyncVersion) VALUES (?,?,?,?,?,?,?,?,?,?,?)"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)


            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@idTable", idTable)
            cmd.Parameters.AddWithValue("@garage_name", garage_name)
            cmd.Parameters.AddWithValue("@location", location)
            cmd.Parameters.AddWithValue("@name_responsible", name_responsible)
            cmd.Parameters.AddWithValue("@id_language", id_language)
            cmd.Parameters.AddWithValue("@version", version)
            cmd.Parameters.AddWithValue("@coat", coat)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@apply_equation", apply_equation)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using

        deleteFromEditMobileSync(idTable, syncTable)

    End Sub


    Public Sub insertCarIntoMobileSyncDeleteTable(ByVal idTable As Integer, ByVal carName As String, ByVal tableName As String)
        Dim syncTable As String = "car"

        Dim strSQL As String = "INSERT INTO mobileDeleteSync (syncTable, idTable, carName, tableName, currentLastSyncVersion) VALUES (?,?,?,?,?)"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)


            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@idTable", idTable)
            cmd.Parameters.AddWithValue("@carName", carName)
            cmd.Parameters.AddWithValue("@tableName", tableName)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using
        deleteFromEditMobileSync(idTable, syncTable)
    End Sub


    Public Sub insertColorIntoMobileSyncDeleteTable(ByVal idTable As Integer, ByVal colorCode As String, ByVal name_color As String)
        Dim syncTable As String = "color"

        Dim strSQL As String = "INSERT INTO mobileDeleteSync (syncTable, idTable, colorCode, name_color, currentLastSyncVersion) VALUES (?,?,?,?,?)"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)


            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@idTable", idTable)
            cmd.Parameters.AddWithValue("@colorCode", colorCode)
            cmd.Parameters.AddWithValue("@name_color", name_color)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using
        deleteFromEditMobileSync(idTable, syncTable)

    End Sub

    Public Sub deleteFromDeleteMobileSync(ByVal idTable As Integer, syncTable As String)

        Dim strSQL As String = "DELETE FROM mobileDeleteSync where idTable=? and syncTable=? and currentLastSyncVersion=?"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)

            cmd.Parameters.AddWithValue("@idTable", idTable)
            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using
    End Sub

    Public Sub deleteFromEditMobileSync(ByVal idTable As Integer, syncTable As String)

        Dim strSQL As String = "DELETE FROM mobileEditSync where idTable=? and syncTable=? and currentLastSyncVersion=?"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)

            cmd.Parameters.AddWithValue("@idTable", idTable)
            cmd.Parameters.AddWithValue("@syncTable", syncTable)
            cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using
    End Sub

    Public Sub emptyMobileSync()

        Dim strSQLEdit As String = "DELETE FROM mobileEditSync"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQLEdit, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using

        Dim strSQLDelete As String = "DELETE FROM mobileDeleteSync"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQLDelete, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using

        'only for sqlite db
        Dim strSQLLiteSeq As String = "DELETE FROM sqlite_sequence"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQLLiteSeq, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using



    End Sub

    Public Sub insertIntoMobileSyncEditTable(ByVal idTable As Integer, ByVal syncTable As String)
        Try
            Dim strSQL As String = "INSERT INTO mobileEditSync (syncTable, idTable, currentLastSyncVersion) VALUES (?,?,?)"
            Using cn As New SQLiteConnection(mySQLITEConnectionString), _
                cmd As New SQLiteCommand(strSQL, cn)


                cmd.Parameters.AddWithValue("@syncTable", syncTable)
                cmd.Parameters.AddWithValue("@idTable", idTable)
                cmd.Parameters.AddWithValue("@currentLastSyncVersion", currentLastSyncVersion)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
            End Using

            deleteFromDeleteMobileSync(idTable, syncTable)
        Catch ex As SQLiteException

        End Try
    End Sub

    Public Sub setVersionMobileSyncDeleteTable()


        Dim strSQL As String = "update mobileDeleteSync set currentLastSyncVersion=" & currentLastSyncVersion & " where currentLastSyncVersion=-1"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using


    End Sub

    Public Sub setVersionMobileSyncEditTable()


        Dim strSQL As String = "update mobileEditSync set currentLastSyncVersion=" & currentLastSyncVersion & " where currentLastSyncVersion=-1"
        Using cn As New SQLiteConnection(mySQLITEConnectionString), _
            cmd As New SQLiteCommand(strSQL, cn)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using


    End Sub

#End Region

#Region "UpdateFile"
    Public Sub insertIntoUpdateTable(ByVal str As String, ByVal actionType As String)
        Try
            'actionType = "UPDATE"
            'str = "UPDATE [formula] set type='2K', version='S1', id_car=28,state='U',variant='',colorRGB='-2830136',c_year='2004 - 2005',colorCode='UK',cardNumber='Kia UD Solo 1', seqnum=seqnum + 1 WHERE id_formula=93512"
            Dim id_action As String = 0
            Try
                openConnection()
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select MAX(id_action)  FROM [UpdateTable]")
                If DR.Read Then
                    If Not DR.Item(0) Is DBNull.Value Then
                        id_action = DR.Item(0)
                    End If
                End If
                DR.Close()
                closeConnection()
            Catch ex As Exception
                closeConnection()
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
                Exit Sub
            End Try
            id_action += 1
            str = SafeSqlLiteral(str, False) & ";"
            'insert line by line (200 char per line)

            While str.Length > 0
                openConnection()
                Dim line As String = ""
                If str.Length > 200 Then
                    line = str.Substring(0, 200)
                    str = str.Substring(200)
                Else
                    line = str
                    str = ""
                End If

                Dim SQLstr As String = String.Format("INSERT INTO [updateTable] (id_action, text_line,actionType) VALUES({0},?,'{1}')", id_action, actionType)
                Dim Command As New OleDb.OleDbCommand(SQLstr, DB)


                Command.Parameters.Add("text_line", OleDbType.VarWChar, 255)
                Command.Parameters(0).Value = line

                Command.Prepare()
                Dim icount As Integer = Command.ExecuteNonQuery()

                closeConnection()
            End While
            '--------------------------
        Catch ex As Exception
            closeConnection()

            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Sub

    Public Sub restoreDatabase()
        Try
            'delete DeleteTable
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM [UpdateTable]")
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)
            Dim icount As Integer = Command.ExecuteNonQuery()

            closeConnection()

        Catch ex As Exception
            closeConnection()
            MessageBox.Show("could not DELETE record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub
    Public Function getUpdateTable() As UpdateTable()
        Dim MyArray As New ArrayList
        If openConnection() Then
            Try
                Dim DR As OleDb.OleDbDataReader = selectQuery("Select * FROM [UpdateTable] ORDER BY id_updateTable asc")
                Dim i As Integer = 0

                While DR.Read
                    Dim newRow As New UpdateTable

                    newRow.id_updateTable = DR.Item("id_updateTable")
                    If Not DR.Item("id_action") Is DBNull.Value Then
                        newRow.id_action = DR.Item("id_action")
                    End If
                    If Not DR.Item("actionType") Is DBNull.Value Then
                        newRow.actionType = DR.Item("actionType").trim
                    End If
                    If Not DR.Item("text_line") Is DBNull.Value Then
                        newRow.text_lineType = DR.Item("text_line")
                    End If
                    MyArray.Add(newRow)

                End While
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            End Try
        End If
        closeConnection()
        Return DirectCast(MyArray.ToArray(GetType(UpdateTable)), UpdateTable())
    End Function

    Public Function performQuery(ByVal query As String) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format(query)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                performQuery = True
            Else
                performQuery = False
            End If
            closeConnection()

        Catch ex As Exception
            closeConnection()
            performQuery = False
            MessageBox.Show("could not execute query:" & query & vbNewLine & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function
#End Region

#Region "Formulas"

    Public Function updateFormulaRGBPercentage(ByVal idFormula As Integer, ByVal formulaRGBPerc As String) As Boolean
        Try

            'update formula
            openConnection()

            Dim SQLstr As String = String.Format("UPDATE [formula] set colorRGBPerc='{0}' WHERE id_formula={1}", formulaRGBPerc, idFormula)

            Dim Command2 As New OleDb.OleDbCommand(SQLstr, DB)
            Dim icount As Integer = Command2.ExecuteNonQuery()
            If icount > 0 Then
                updateFormulaRGBPercentage = True
            Else
                updateFormulaRGBPercentage = False
            End If
            closeConnection()
            insertIntoMobileSyncEditTable(idFormula, "formula")

        Catch ex As Exception
            closeConnection()
            updateFormulaRGBPercentage = False
            'MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function


    Public Function deleteFormula(ByVal id_formula, ByVal colorCode, ByVal name_formula, ByVal type, ByVal id_car, ByVal name_car, ByVal version) As Boolean

        'If currentLastSyncVersion = -1 Then
        ' MsgBox("Not allowed without internet connection, if the internet connection is available now please restart the program.", MsgBoxStyle.Exclamation)
        'Exit Function
        ' End If

        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM [formulaColor] WHERE id_formula={0} ", id_formula)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                deleteFormula = True
                insertIntoUpdateTable(SQLstr, "DELETE")
            Else
                deleteFormula = False
            End If
            closeConnection()
            openConnection()

            SQLstr = String.Format("DELETE FROM [formula] WHERE id_formula={0} ", id_formula)
            Dim Command2 As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount2 As Integer = Command2.ExecuteNonQuery()
            If icount2 > 0 Then
                deleteFormula = True
                insertIntoUpdateTable(SQLstr, "DELETE")
            Else
                deleteFormula = False
            End If
            closeConnection()
            insertFormulaIntoMobileSyncDeleteTable(id_formula, colorCode, name_formula, type, id_car, name_car, version)
        Catch ex As Exception
            closeConnection()
            deleteFormula = False
            MessageBox.Show("could not delete record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function getLastInsertedFormulaId() As Integer
        Try
            openConnection()
            Dim DR As OleDb.OleDbDataReader = selectQuery("Select max(id_formula) FROM [formula]")
            If DR.Read Then
                getLastInsertedFormulaId = DR.Item(0)
            End If
            DR.Close()
            closeConnection()
        Catch ex As Exception
            getLastInsertedFormulaId = -1
            MessageBox.Show("could not select max :" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function
    Public Function getLastInsertedFormulaColorId() As Integer
        Try
            openConnection()
            Dim DR As OleDb.OleDbDataReader = selectQuery("Select max(id_formulaColor) FROM [formulaColor]")
            If DR.Read Then
                getLastInsertedFormulaColorId = DR.Item(0)
            End If
            DR.Close()
            closeConnection()
        Catch ex As Exception
            getLastInsertedFormulaColorId = -1
            MessageBox.Show("could not select max :" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function

    Public Function getCurrentDateDBString(Optional theDate = Nothing) As String
        Dim dateCreMod As Date = Nothing
        If theDate Is Nothing Then
            dateCreMod = Now
        Else
            dateCreMod = theDate
        End If
        Dim day As Integer = dateCreMod.Day
        Dim month As Integer = dateCreMod.Month
        Dim year As Integer = dateCreMod.Year
        Dim hour As Integer = dateCreMod.Hour
        Dim minute As Integer = dateCreMod.Minute
        Dim second As Integer = dateCreMod.Second
        Dim dateCreModStr As String = day & ":" & month & ":" & year
        dateCreModStr = dateCreModStr & ":" & hour & ":" & minute & ":" & second

        Return dateCreModStr
    End Function

    Public Function insertIntoFormula(ByVal isApplyEquationMajdiPerc, ByVal isApplyEquation15perc4201, ByVal name_formula, ByVal id_car, ByVal type, ByVal version, ByVal formulaVariant, ByVal colorCode, ByVal duplicate, ByVal colorRGB, ByVal c_year, ByVal cardNumber, ByVal isEquation4201_180, Optional modate = Nothing, Optional newModDate = True) As Boolean
        Try
            Dim newId_formula As Integer = getLastInsertedFormulaId() + 1

            Dim dateCreModStr As String = ""
            If newModDate Then
                dateCreModStr = getCurrentDateDBString()
            Else
                dateCreModStr = getCurrentDateDBString(modate)
            End If
            openConnection()
            Dim SQLstr As String

            Dim no4201Eq As Integer
            If isEquation4201_180 Then
                no4201Eq = 0
            Else
                no4201Eq = 1
            End If

            SQLstr = String.Format("INSERT INTO [formula] (id_formula,name_formula, id_car, type, version, variant,duplicate,colorCode,colorRGB,c_year,cardNumber,isEquation15perc4201,converted,date_cre_mod,noEquation4201_180, state,seqnum,modified_once) VALUES({0},'{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11},{12},'{13}','{14}','I',0,0)", newId_formula, name_formula, id_car, type, version, formulaVariant, duplicate, colorCode, colorRGB, c_year, cardNumber, isApplyEquation15perc4201, isApplyEquationMajdiPerc, dateCreModStr, no4201Eq)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                insertIntoFormula = True
                insertIntoUpdateTable(SQLstr, "INSERT")
            Else
                insertIntoFormula = False
            End If
            closeConnection()

            insertIntoMobileSyncEditTable(newId_formula, "formula")
        Catch ex As Exception
            closeConnection()
            insertIntoFormula = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function

    Public Function insertIntoFormulaColor(ByVal id_formula, ByVal id_color, ByVal quantite, ByVal id_unit) As Boolean
        Try

            Dim newId_formulaColor As Integer = getLastInsertedFormulaColorId() + 1
            Dim encQuantity As String = encryptQuantity(quantite, newId_formulaColor)

            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("INSERT INTO [formulaColor] (id_formulaColor, id_formula,id_color,quantite,id_unit,state, encrypted) VALUES({0},{1},'{2}','{3}',{4},'I',{5})", newId_formulaColor, id_formula, id_color, encQuantity, id_unit, encryptionActive)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)


            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                insertIntoFormulaColor = True
                insertIntoUpdateTable(SQLstr, "INSERT")
            Else
                insertIntoFormulaColor = False
            End If
            closeConnection()

            insertIntoMobileSyncEditTable(id_formula, "formula")
        Catch ex As Exception
            closeConnection()
            insertIntoFormulaColor = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function
    Public Function assignFormulaXYZ(ByVal id_formulaXYZSeleced, ByVal id_formulaXSeleced, ByVal id_formulaYSeleced, ByVal id_formulaZSeleced, ByVal id_formulaXPSeleced, ByVal id_formulaX2PSeleced, ByVal id_formulaYPSeleced, ByVal id_formulaY2PSeleced, ByVal id_formulaZPSeleced, ByVal id_formulaZ2PSeleced) As Boolean
        Try

            'update formula
            Dim SQLstr As String
            openConnection()
            SQLstr = String.Format("UPDATE [formula] set id_formulaX={0}, id_formulaY={1}, id_formulaZ={2},id_formulaXp={3},id_formulaX2p={4},id_formulaYp={5},id_formulaY2p={6},id_formulaZp={7},id_formulaZ2p={8} WHERE id_formula={9}", id_formulaXSeleced, id_formulaYSeleced, id_formulaZSeleced, id_formulaXPSeleced, id_formulaX2PSeleced, id_formulaYPSeleced, id_formulaY2PSeleced, id_formulaZPSeleced, id_formulaZ2PSeleced, id_formulaXYZSeleced)
            Dim Command2 As New OleDb.OleDbCommand(SQLstr, DB)
            Dim icount As Integer = Command2.ExecuteNonQuery()
            If icount > 0 Then
                assignFormulaXYZ = True
                insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                assignFormulaXYZ = False
            End If
            closeConnection()
            insertIntoMobileSyncEditTable(id_formulaXYZSeleced, "formula")
        Catch ex As Exception
            closeConnection()
            assignFormulaXYZ = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function
    Public Function updateFormulaTable(ByVal formula As Formula, ByVal formulaColor() As FormulaColor, ByVal setModifDate As Boolean) As Boolean
        Try
            'delete formulaColor
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM [formulaColor] WHERE id_formula={0}", formula.id_formula)
            Try
                Dim Command As New OleDb.OleDbCommand(SQLstr, DB)
                Command.ExecuteNonQuery()
                closeConnection()
                insertIntoUpdateTable(SQLstr, "DELETE")
            Catch ex As Exception
                closeConnection()
                updateFormulaTable = False
                MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
                Exit Function
            End Try
            'update formula
            openConnection()
            Dim no4201Eq As Integer
            If formula.isEquation4201_180 Then
                no4201Eq = 0
            Else
                no4201Eq = 1
            End If
            If setModifDate Then
                Dim dateCreModStr As String = getCurrentDateDBString()
                SQLstr = String.Format("UPDATE [formula] set modified_once=1, type='{0}', version='{1}', id_car={2},state='U',variant='{3}',colorRGB='{4}',c_year='{5}',colorCode='{6}',cardNumber='{7}', date_cre_mod='{8}',noEquation4201_180={9}, seqnum=seqnum + 1 WHERE id_formula={10}", formula.type, formula.version, formula.id_car, formula.variant, formula.colorRGB, formula.c_year, formula.colorCode, formula.cardNumber, dateCreModStr, no4201Eq, formula.id_formula)
            Else
                SQLstr = String.Format("UPDATE [formula] set type='{0}', version='{1}', id_car={2},state='U',variant='{3}',colorRGB='{4}',c_year='{5}',colorCode='{6}',cardNumber='{7}',noEquation4201_180={8}, seqnum=seqnum + 1 WHERE id_formula={9}", formula.type, formula.version, formula.id_car, formula.variant, formula.colorRGB, formula.c_year, formula.colorCode, formula.cardNumber, no4201Eq, formula.id_formula)

            End If
            Dim Command2 As New OleDb.OleDbCommand(SQLstr, DB)
            Dim icount As Integer = Command2.ExecuteNonQuery()
            If icount > 0 Then
                updateFormulaTable = True
                insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                updateFormulaTable = False
            End If
            closeConnection()

            'insert into fromulaColor
            Dim i As Integer
            Dim idFormula As Integer = -1
            For i = 0 To formulaColor.Length - 1
                idFormula = formulaColor(i).id_formula
             
                If Not insertIntoFormulaColor(formulaColor(i).id_formula, formulaColor(i).id_color, formulaColor(i).quantite, formulaColor(i).id_Unit) Then
                    updateFormulaTable = False
                    MsgBox("problem setting color '" & formulaColor(i).id_color & "' to formula '" & formulaColor(i).id_formula & "'")
                    Exit For
                End If

            Next
            Dim formulaColorRGBPercentage As String = getColorPercentage(formulaColor)
            updateFormulaRGBPercentage(idFormula, formulaColorRGBPercentage)

            updateFormulaTable = True
            closeConnection()
            insertIntoMobileSyncEditTable(formula.id_formula, "formula")
        Catch ex As Exception
            closeConnection()
            updateFormulaTable = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function deleteIntoFormulaColor(ByVal idFormulaColor) As Boolean
        Try
            'delete formulaColor
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM [formulaColor] WHERE id_formulaColor={0}", idFormulaColor)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)
            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                deleteIntoFormulaColor = True
                insertIntoUpdateTable(SQLstr, "DELETE")
            Else
                deleteIntoFormulaColor = False
            End If
            closeConnection()

        Catch ex As Exception
            closeConnection()
            deleteIntoFormulaColor = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function




    Public Function editFormula(ByVal idFormula, ByVal colorCode, ByVal colorName, ByVal year, ByVal carid, ByVal cardNumber, ByVal setModifDate) As Boolean
        Try
            openConnection()

            Dim SQLstr As String
            If setModifDate Then
                Dim dateCreModStr As String = getCurrentDateDBString()
                SQLstr = String.Format("UPDATE [formula] set colorCode = '{0}',name_formula = '{1}',c_year = '{2}',id_car = {3},cardNumber='{4}', date_cre_mod='{5}' WHERE id_formula={6}", colorCode, colorName, year, carid, cardNumber, dateCreModStr, idFormula)
            Else
                SQLstr = String.Format("UPDATE [formula] set colorCode = '{0}',name_formula = '{1}',c_year = '{2}',id_car = {3},cardNumber='{4}' WHERE id_formula={5}", colorCode, colorName, year, carid, cardNumber, idFormula)
            End If

            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                editFormula = True
                'insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                editFormula = False
            End If
            closeConnection()
            insertIntoMobileSyncEditTable(idFormula, "formula")

        Catch ex As Exception
            closeConnection()
            editFormula = False
            MessageBox.Show("could not update record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function editFormulaYear(ByVal idFormula, ByVal year) As Boolean
        Try
            openConnection()

            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [formula] set c_year = '{0}' WHERE id_formula={1}", year, idFormula)

            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                editFormulaYear = True
                'insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                editFormulaYear = False
            End If
            closeConnection()
            insertIntoMobileSyncEditTable(idFormula, "formula")

        Catch ex As Exception
            closeConnection()
            editFormulaYear = False
            MessageBox.Show("could not update record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function


    Public Function updateColorCodeByFormulaId(ByVal idFormula, ByVal colorCode) As Boolean
        Try
            openConnection()
            Dim dateCreModStr As String = getCurrentDateDBString()

            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [formula] set colorCode = '{0}',date_cre_mod='{1}' WHERE id_formula={2}", colorCode, dateCreModStr, idFormula)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                updateColorCodeByFormulaId = True
                insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                updateColorCodeByFormulaId = False
            End If
            closeConnection()
            insertIntoMobileSyncEditTable(idFormula, "formula")

        Catch ex As Exception
            closeConnection()
            updateColorCodeByFormulaId = False
            MessageBox.Show("could not update record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Sub setLastChosenBaseCoat(ByVal chosenBaseCoat As String)
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("delete from [GlobalVariables] where variable_name like '%chosenBaseCoat%'")
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            closeConnection()
            MessageBox.Show("could not delete record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("INSERT INTO [GlobalVariables] (variable_name,variable_value) VALUES('chosenBaseCoat','{0}')", chosenBaseCoat)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            closeConnection()
            MessageBox.Show("could not INSERT record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

#End Region

#Region "Cars"
    Public Function getLastInsertedCarId() As Integer
        Try
            openConnection()
            Dim DR As OleDb.OleDbDataReader = selectQuery("Select max(id_car) FROM [car]")
            If DR.Read Then
                getLastInsertedCarId = DR.Item(0)
            End If
            DR.Close()
            closeConnection()
        Catch ex As Exception
            getLastInsertedCarId = -1
            MessageBox.Show("could not select max :" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function
    Public Function insertIntoCars(ByVal carName As String, ByVal carImg As String, ByVal tableName As String) As Boolean
        Try

            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("INSERT INTO [car] (carName,carImgPath,tableName, state,seqnum) VALUES('{0}','{1}','{2}','I',0)", carName, carImg, tableName)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                insertIntoCars = True
                insertIntoUpdateTable(SQLstr, "INSERT")
            Else
                insertIntoCars = False
            End If
            closeConnection()

            insertIntoMobileSyncEditTable(getLastInsertedCarId(), "car")
        Catch ex As Exception
            closeConnection()
            'insertIntoCars = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
            Return False
        End Try

        Dim scriptsFolder As String = My.Application.Info.DirectoryPath & "\\VBAsqlScripts"
        Dim query As String = ""
        Dim createCarTablesScriptPath As String = scriptsFolder & "\\sqlCreateCarTables.txt"
        query = vbNewLine & "create table " & tableName & "(id_formula long,id_formulaX long,id_formulaY long,formulaImgPath varchar(100),otherPrice double,id_otherCurreny long,id_otherUnit long, type varchar(50),id_car long,version varchar(5),name_formula varchar(50),c_year varchar(255),variant varchar(255),duplicate varchar(50),colorCode varchar(100),colorRGB varchar(50),clientName varchar(50),cardNumber varchar(100),seqnum long,state varchar(50),id_formulaZ long,id_formulaZp long,id_formulaZ2p long,id_formulaXp long,id_formulaX2p long,id_formulaYp long,id_formulaY2p long,isEquation15perc4201 long,converted varchar(255),Date_cre_mod varchar(255),noEquation4201_180 long,colorRGBPerc varchar(255), modified_once long, primary key (id_formula));"
        appendFile(createCarTablesScriptPath, query, False)

        Dim insertIntoCarTablesScriptPath As String = scriptsFolder & "\\sqlInsertCarQueries.txt"
        query = vbNewLine & "insert into " & tableName & " select * from formula where id_car=(select id_car from car where table_name='" & tableName & "')"
        appendFile(insertIntoCarTablesScriptPath, query, False)

        Dim createFormulaColorTablesScriptPath As String = scriptsFolder & "\\sqlCreateFormColorTable.txt"
        query = vbNewLine & "create table " & tableName & "_formulaColor(id_formulaColor long, id_formula long, id_color long, quantite varchar(255), id_unit long, state varchar(50), primary key(id_formulaColor))"
        appendFile(createFormulaColorTablesScriptPath, query, False)

        Dim insertIntoFormulaColorTablesScriptPath As String = scriptsFolder & "\\sqlInsertFormColorQueries.txt"
        query = vbNewLine & "insert into " & tableName & "_formulaColor select * from formulaColor where id_formula in (select id_formula from formula where id_car=(select id_car from car where table_name='" & tableName & "'))"
        appendFile(insertIntoFormulaColorTablesScriptPath, query, False)
    End Function
    Public Sub setLastChosenCar(ByVal chosenCar As Car)
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("delete from [GlobalVariables] where variable_name like '%id_car%'")
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            closeConnection()
            MessageBox.Show("could not delete record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("INSERT INTO [GlobalVariables] (variable_name,variable_value) VALUES('id_car','{0}')", chosenCar.id_car)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            closeConnection()
            MessageBox.Show("could not INSERT record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub
    Public Function updateCar(ByVal id_car, ByVal carName, ByVal carImg) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [car] set carName = '{0}',carImgPath='{1}', state='U',seqnum=seqnum+1 WHERE id_car={2}", carName, carImg, id_car)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                updateCar = True
                insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                updateCar = False
            End If
            closeConnection()

            insertIntoMobileSyncEditTable(id_car, "car")
        Catch ex As Exception
            closeConnection()
            updateCar = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function
    Public Function updateColorCodeLocator(ByVal idCar, ByVal location) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [car] set colorCodeLocation = ""{0}"" WHERE id_car={1}", idCar, location)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                updateColorCodeLocator = True
                insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                updateColorCodeLocator = False
            End If
            closeConnection()

            insertIntoMobileSyncEditTable(idCar, "car")
        Catch ex As Exception
            closeConnection()
            updateColorCodeLocator = False
            MessageBox.Show("could not update record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function deleteCar(ByVal id_car, ByVal carName, ByVal tableName) As Boolean
        ' If currentLastSyncVersion = -1 Then
        'MsgBox("Not allowed without internet connection, if the internet connection is available now please restart the program.", MsgBoxStyle.Exclamation)
        'Exit Function
        'End If


        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM [car]  WHERE id_car={0}", id_car)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                deleteCar = True
                insertIntoUpdateTable(SQLstr, "DELETE")
            Else
                deleteCar = False
            End If
            closeConnection()

            insertCarIntoMobileSyncDeleteTable(id_car, carName, tableName)
        Catch ex As Exception
            closeConnection()
            deleteCar = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

#End Region

#Region "language"

    Public Function insertIntoLanguages(ByVal code, ByVal label) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("INSERT INTO [language] (code_language,label_language,isDefault, state,seqnum) VALUES('{0}','{1}',0,'I',0)", code, label)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                insertIntoLanguages = True
                insertIntoUpdateTable(SQLstr, "INSERT")
            Else
                insertIntoLanguages = False
            End If
            closeConnection()


        Catch ex As Exception
            closeConnection()
            insertIntoLanguages = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function updateLanguage(ByVal id_language, ByVal code_language, ByVal label_language) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [language] set isDefault='0',code_language = '{0}',label_language='{1}',state='U',seqnum=seqnum+1 WHERE id_language={2}", code_language, label_language, id_language)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                updateLanguage = True
                insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                updateLanguage = False
            End If
            closeConnection()


        Catch ex As Exception
            closeConnection()
            updateLanguage = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function deleteLanguage(ByVal id_language) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM [language]  WHERE id_language={0}", id_language)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                deleteLanguage = True
                insertIntoUpdateTable(SQLstr, "DELETE")
            Else
                deleteLanguage = False
            End If
            closeConnection()


        Catch ex As Exception
            closeConnection()
            deleteLanguage = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

#End Region

#Region "garage"
    Public Function getLastInsertedGarageId() As Integer
        Try
            openConnection()
            Dim DR As OleDb.OleDbDataReader = selectQuery("Select max(id_garage) FROM [garage]")
            If DR.Read Then
                getLastInsertedGarageId = DR.Item(0)
            End If
            DR.Close()
            closeConnection()
        Catch ex As Exception
            getLastInsertedGarageId = -1
            MessageBox.Show("could not select max :" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function

    Public Function insertIntoGarages(ByVal name, ByVal location, ByVal responsible, ByVal id_language, ByVal logo, ByVal apply_equation, ByVal version, ByVal tel, ByVal key, ByVal coat, ByVal showAlternativeName, ByVal themeColor, ByVal username) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("INSERT INTO garage (garage_name,location,name_responsible,id_language,logo,apply_equation,state,seqnum,version,tel,[key],coat,showAlternativeName,theme_color,[username]) VALUES('{0}','{1}','{2}',{3},'{4}','{5}','I',0,'{6}','{7}','{8}','{9}','{10}','{11}','{12}')", name, location, responsible, id_language, logo, apply_equation, version, tel, key, coat, showAlternativeName, themeColor, username)

            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                insertIntoGarages = True
                insertIntoUpdateTable(SQLstr, "INSERT")
            Else
                insertIntoGarages = False
            End If
            closeConnection()
            insertIntoMobileSyncEditTable(getLastInsertedGarageId(), "garage")

        Catch ex As Exception
            closeConnection()
            insertIntoGarages = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function


    Public Function updateGarage(ByVal id_garage, ByVal garage_name, ByVal name_responsible, ByVal location, ByVal id_language, ByVal logo, ByVal apply_equation, ByVal version, ByVal tel, ByVal key, ByVal coat, ByVal showAlternativeName, ByVal themeColor, ByVal username) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [GARAGE] set garage_name = '{0}',name_responsible='{1}',location='{2}',id_language={3},logo='{4}',apply_equation='{5}',state='U',seqnum=seqnum+1,version='{6}',[tel]='{7}',[key]='{8}',coat='{9}',showAlternativeName='{10}',theme_Color='{11}', [username]='{12}' WHERE id_garage={13}", garage_name, name_responsible, location, id_language, logo, apply_equation, version, tel, key, coat, showAlternativeName, themeColor, username, id_garage)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                updateGarage = True
                insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                updateGarage = False
            End If
            closeConnection()
            insertIntoMobileSyncEditTable(id_garage, "garage")

        Catch ex As Exception
            closeConnection()
            updateGarage = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function deleteGarage(ByVal id_garage As Integer, ByVal garageToDelete As Garage) As Boolean
        'If currentLastSyncVersion = -1 Then
        'MsgBox("Not allowed without internet connection, if the internet connection is available now please restart the program.", MsgBoxStyle.Exclamation)
        ' Exit Function
        'End If


        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM [garage]  WHERE id_garage={0}", id_garage)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                deleteGarage = True
                insertIntoUpdateTable(SQLstr, "DELETE")
            Else
                deleteGarage = False
            End If
            closeConnection()

            insertGarageIntoMobileSyncDeleteTable(id_garage, garageToDelete.garage_name, garageToDelete.location, garageToDelete.name_responsible, garageToDelete.id_language, garageToDelete.version, garageToDelete.coat, garageToDelete.username, garageToDelete.apply_equationDBValue)
        Catch ex As Exception
            closeConnection()
            deleteGarage = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Sub setChosenGarage(ByVal id_garage)
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [garage] set chosen = '0' ")
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)
            Dim icount As Integer = Command.ExecuteNonQuery()
            closeConnection()

            insertIntoUpdateTable(SQLstr, "UPDATE")

            openConnection()
            Dim SQLstr2 As String
            SQLstr2 = String.Format("UPDATE [garage] set chosen = '1' WHERE id_garage={0}", id_garage)
            Dim Command2 As New OleDb.OleDbCommand(SQLstr2, DB)
            Dim icount2 As Integer = Command2.ExecuteNonQuery()
            closeConnection()
            insertIntoUpdateTable(SQLstr2, "UPDATE")

        Catch ex As Exception
            closeConnection()

            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Public Sub setMobileAppPubNum(ByVal public_tel)
        Try
            openConnection()
            Dim SQLstr2 As String
            SQLstr2 = String.Format("UPDATE [garage] set public_tel = '{0}'", public_tel)
            Dim Command2 As New OleDb.OleDbCommand(SQLstr2, DB)
            Dim icount2 As Integer = Command2.ExecuteNonQuery()
            closeConnection()
            'insertIntoUpdateTable(SQLstr2, "UPDATE")

        Catch ex As Exception
            closeConnection()

            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

#End Region

#Region "color"

    Public Function getLastInsertedColorId() As Integer
        Try
            openConnection()
            Dim DR As OleDb.OleDbDataReader = selectQuery("Select max(id_color) FROM [color]")
            If DR.Read Then
                getLastInsertedColorId = DR.Item(0)
            End If
            DR.Close()
            closeConnection()
        Catch ex As Exception
            getLastInsertedColorId = -1
            MessageBox.Show("could not select max :" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function
    Public Function insertIntoColors(ByVal colorImgFile, ByVal name, ByVal price, ByVal colorCode, ByVal id_currency, ByVal id_unit, ByVal id_unit_on_entry, ByVal massevolumique, ByVal massevolumiqueExt, ByVal name_alternative, ByVal name_alternative2, ByVal argb) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("INSERT INTO [color] (name_color,defaultPrice,id_defaultCurreny,id_defaultUnit,colorCode,state,seqnum,colorImgPath,id_unit_on_entry,masse_volumique,masse_volumique_ext,name_color_alternative,name_color_alternative2,argb) VALUES('{0}','{1}','{2}','{3}','{4}','I',0,'{5}','{6}','{7}','{8}','{9}','{10}','{11}')", name, price, id_currency, id_unit, colorCode, colorImgFile, id_unit_on_entry, massevolumique, massevolumiqueExt, name_alternative, name_alternative2, argb)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                insertIntoColors = True
                insertIntoUpdateTable(SQLstr, "INSERT")
            Else
                insertIntoColors = False
            End If
            closeConnection()
            insertIntoMobileSyncEditTable(getLastInsertedColorId(), "color")

        Catch ex As Exception
            closeConnection()
            insertIntoColors = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function updateColor(ByVal colorImgPath, ByVal id_color, ByVal name, ByVal price, ByVal colorCode, ByVal id_currency, ByVal id_unit, ByVal id_unit_on_entry, ByVal massevolumique, ByVal massevolumiqueExt, ByVal name_alternative, ByVal name_alternative2, ByVal argb) As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [color] set name_color = '{0}',defaultPrice='{1}', colorImgPath='{2}',colorCode='{3}',id_defaultUnit='{4}',id_defaultCurreny='{5}',id_unit_on_entry='{6}',masse_volumique='{7}',masse_volumique_ext='{8}',name_color_alternative='{9}',name_color_alternative2='{10}', argb='{11}',state='U',seqnum=seqnum+1 WHERE id_color={12}", name, price, colorImgPath, colorCode, id_unit, id_currency, id_unit_on_entry, massevolumique, massevolumiqueExt, name_alternative, name_alternative2, argb, id_color)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                updateColor = True
                insertIntoUpdateTable(SQLstr, "UPDATE")
            Else
                updateColor = False
            End If
            closeConnection()

            insertIntoMobileSyncEditTable(id_color, "color")
        Catch ex As Exception
            closeConnection()
            updateColor = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function deleteColor(ByVal id_color, ByVal colorCode, ByVal name_color) As Boolean
        'If currentLastSyncVersion = -1 Then
        'MsgBox("Not allowed without internet connection, if the internet connection is available now please restart the program.", MsgBoxStyle.Exclamation)
        'Exit Function
        'End If


        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM [color]  WHERE id_color={0}", id_color)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                deleteColor = True
                insertIntoUpdateTable(SQLstr, "DELETE")
            Else
                deleteColor = False
            End If
            closeConnection()
            insertColorIntoMobileSyncDeleteTable(id_color, colorCode, name_color)
        Catch ex As Exception
            closeConnection()
            deleteColor = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Function fixAfterdeleteColor() As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM formulaColor WHERE id_color not in (select id_color from color)")
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                fixAfterdeleteColor = True
                insertIntoUpdateTable(SQLstr, "DELETE")
            Else
                fixAfterdeleteColor = False
            End If
            closeConnection()
            fixAfterdeleteColorClient()
        Catch ex As Exception
            closeConnection()
            fixAfterdeleteColor = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function
    Public Function fixAfterdeleteColorClient() As Boolean
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM clientFormulaColor WHERE id_color not in (select id_color from color)")
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                fixAfterdeleteColorClient = True
                insertIntoUpdateTable(SQLstr, "DELETE")
            Else
                fixAfterdeleteColorClient = False
            End If
            closeConnection()
            fixAfterdeleteColorClient()
        Catch ex As Exception
            closeConnection()
            fixAfterdeleteColorClient = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try

    End Function
#End Region

#Region "Labels"

    Public Sub deleteLabelLang(ByVal idLabel, ByVal idLanguage)
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("DELETE FROM [labelLanguage]  WHERE id_label={0} AND id_language={1}", idLabel, idLanguage)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)

            Dim icount As Integer = Command.ExecuteNonQuery()
            If icount > 0 Then
                insertIntoUpdateTable(SQLstr, "DELETE")
            End If
            closeConnection()
        Catch ex As Exception
            closeConnection()

            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Public Function addLabelLanguage(ByVal id_label As String, ByVal value As String, ByVal id_language As Integer) As Boolean
        Try

            openConnection()

            Dim SQLstr2 As String
            SQLstr2 = String.Format("INSERT INTO [LABELLANGUAGE] (id_label, id_language, description) VALUES({0},{1},'{2}')", id_label, id_language, value)

            Dim Command2 As New OleDb.OleDbCommand(SQLstr2, DB)
            Dim icount As Integer = Command2.ExecuteNonQuery
            If icount > 0 Then
                addLabelLanguage = True
                insertIntoUpdateTable(SQLstr2, "INSERT")
            Else
                addLabelLanguage = False
            End If

            closeConnection()
        Catch ex As Exception
            closeConnection()
            addLabelLanguage = False
            MessageBox.Show("could not insert record int table labelLanguage:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function

    Public Function addLabel(ByVal name_label As String, ByVal value As String, ByVal id_language As Integer) As Boolean
        Try

            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("INSERT INTO [LABEL] (name_label) VALUES('{0}')", name_label)
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)
            Try
                Command.ExecuteNonQuery()
                insertIntoUpdateTable(SQLstr, "INSERT")
            Catch ex As Exception
                closeConnection()
                addLabel = False
                Exit Function
            End Try



            openConnection()
            Dim id_label As Integer = 0
            Dim DR2 As OleDb.OleDbDataReader = selectQuery("Select max(id_label) FROM [label]")
            If DR2.Read Then
                id_label = DR2.Item(0)
            End If
            DR2.Close()
            closeConnection()

            openConnection()
            If id_label > 0 Then
                Dim SQLstr2 As String
                SQLstr2 = String.Format("INSERT INTO [LABELLANGUAGE] (id_label, id_language, description) VALUES({0},{1},'{2}')", id_label, id_language, value)

                Dim Command2 As New OleDb.OleDbCommand(SQLstr2, DB)
                Dim icount As Integer '= Command2.ExecuteNonQuery
                If icount > 0 Then
                    addLabel = True
                    insertIntoUpdateTable(SQLstr2, "INSERT")
                Else
                    addLabel = False
                End If
            Else
                addLabel = False
            End If
            closeConnection()
        Catch ex As Exception
            closeConnection()
            addLabel = False
            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Function

#End Region

#Region "font"
    Public Sub insertNewFontSize(ByVal value As Integer)
        Try

            openConnection()

            Dim SQLstr2 As String
            SQLstr2 = String.Format("UPDATE [LastFont] set font_size={0}", value)

            Dim Command2 As New OleDb.OleDbCommand(SQLstr2, DB)
            Dim icount As Integer = Command2.ExecuteNonQuery

            closeConnection()
        Catch ex As Exception
            closeConnection()

            MessageBox.Show("could not insert record into font table:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub

#End Region

#Region "Unit"
    Public Sub setChosenUnit(ByVal id_unit)
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [unit] set chosen = '0' ")
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)
            Dim icount As Integer = Command.ExecuteNonQuery()
            closeConnection()
            openConnection()

            Dim SQLstr2 As String
            SQLstr2 = String.Format("UPDATE [unit] set chosen = '1' WHERE id_unit={0}", id_unit)
            Dim Command2 As New OleDb.OleDbCommand(SQLstr2, DB)

            Dim icount2 As Integer = Command2.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            closeConnection()

            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub
#End Region

#Region "currency"
    Public Sub setChosenCurrency(ByVal id_Currency)
        Try
            openConnection()
            Dim SQLstr As String
            SQLstr = String.Format("UPDATE [userCurrency] set chosen = '0' ")
            Dim Command As New OleDb.OleDbCommand(SQLstr, DB)
            Dim icount As Integer = Command.ExecuteNonQuery()
            closeConnection()
            openConnection()

            Dim SQLstr2 As String
            SQLstr2 = String.Format("UPDATE [userCurrency] set chosen = '1' WHERE id_currency={0}", id_Currency)
            Dim Command2 As New OleDb.OleDbCommand(SQLstr2, DB)

            Dim icount2 As Integer = Command2.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            closeConnection()

            MessageBox.Show("could not insert record:" & ex.Message.ToString & ": " & vbNewLine & ex.StackTrace)
        End Try
    End Sub
#End Region
End Module
