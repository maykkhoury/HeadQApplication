Public Class assignColorByCode

    Private Sub txtQuantity_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity.GotFocus, txtColorCode.GotFocus
        sender.selectAll()
    End Sub

    Private Sub txtColorCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtColorCode.KeyPress, txtQuantity.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            Me.Close()
        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            assign()
        End If
    End Sub

    Private Sub txtColorsCode_keyStroke(ByVal sender As System.Object, ByVal e As KeyEventArgs) ' Handles txtColorCode.KeyUp, txtQuantity.KeyUp
        
    End Sub

    Private Sub assignColorByCode_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub assign()
        If Not IsNumeric(txtQuantity.Text) Then
            MessageBox.Show("The quantity must be a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim chosencolor() As Color = getColors("WHERE colorCode='" & txtColorCode.Text & "'")
        If chosencolor Is Nothing Then
            MessageBox.Show("Color code does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If chosencolor.Length = 0 Then
            MessageBox.Show("Color code does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim id_color As Integer = chosencolor(0).id_color

        Dim id_unit As Integer = 2 'kilo
        Dim quantite As Decimal = CType(txtQuantity.Text, Decimal)
        Dim id_formula As Integer = edit.lbFormulaId.Text
        Dim alreadyexist = False
        Dim formulaColor As New FormulaColor
        formulaColor.id_color = id_color
        formulaColor.id_Unit = id_unit
        formulaColor.quantite = quantite


        If fromAddFormula Then

            addFormula.ratioFormulaColor = 1

            If addFormula.chosenFormulaColors Is Nothing Then
                If fromEditFormula Then
                    MsgBox("Error! should not be able to edit nothing", MsgBoxStyle.Exclamation)
                    fromEditFormula = False
                End If
                Dim MyArray As New ArrayList
                MyArray.Add(formulaColor)

                addFormula.chosenFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
            Else

                Dim MyArray As New ArrayList
                Dim i As Integer

                If fromEditFormula Then 'client clicked on the edit button to add an existing color

                    For i = 0 To addFormula.chosenFormulaColors.Length - 1
                        MyArray.Add(addFormula.chosenFormulaColors(i))
                        If i <> Me.AccessibleDescription And addFormula.chosenFormulaColors(i).id_color = id_color Then
                            alreadyexist = True
                        End If
                    Next
                    If alreadyexist Then
                        MsgBox("Color already exist for this formula", MessageBoxIcon.Information)
                    Else
                        addFormula.chosenFormulaColors(Me.AccessibleDescription) = New FormulaColor()
                        addFormula.chosenFormulaColors(Me.AccessibleDescription).id_formulaColor = formulaColor.id_formulaColor
                        addFormula.chosenFormulaColors(Me.AccessibleDescription).id_color = formulaColor.id_color
                        addFormula.chosenFormulaColors(Me.AccessibleDescription).id_car = formulaColor.id_car
                        addFormula.chosenFormulaColors(Me.AccessibleDescription).quantite = formulaColor.quantite
                        addFormula.chosenFormulaColors(Me.AccessibleDescription).id_Unit = formulaColor.id_Unit
                        fromEditFormula = False
                    End If

                Else 'client wants to add a new color
                    For i = 0 To addFormula.chosenFormulaColors.Length - 1
                        MyArray.Add(addFormula.chosenFormulaColors(i))
                        If addFormula.chosenFormulaColors(i).id_color = id_color Then
                            alreadyexist = True
                        End If
                    Next
                    If alreadyexist Then
                        MsgBox("Color already exist for this formula", MessageBoxIcon.Information)
                    Else
                        MyArray.Add(formulaColor)
                    End If

                    addFormula.chosenFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
                End If
            End If
            addFormula.generatesDetails(addFormula.chosenFormulaColors)
            If Not alreadyexist Then
                Me.Close()
            End If
        Else 'from HeadQhome
            formulaColor.id_formula = id_formula
            If selectedFormulaColors Is Nothing Then
                Dim MyArray As New ArrayList
                MyArray.Add(formulaColor)

                selectedFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
            Else

                Dim MyArray As New ArrayList
                Dim i As Integer

                For i = 0 To selectedFormulaColors.Length - 1
                    MyArray.Add(selectedFormulaColors(i))
                    If selectedFormulaColors(i).id_color = id_color Then
                        alreadyexist = True
                    End If
                Next
                If alreadyexist Then
                    MsgBox("Color already exist for this formula", MessageBoxIcon.Information)
                Else
                    MyArray.Add(formulaColor)
                End If

                selectedFormulaColors = DirectCast(MyArray.ToArray(GetType(FormulaColor)), FormulaColor())
            End If

            Dim carid As String = edit.lbCarId.Text
            Dim carNameModel As String = edit.cmbCarNameModelEdit.Text
            Dim version As String = edit.cmbVersionEdit.Text
            Dim type As String = edit.cmbType.Text
            edit.generatesDetails(edit.formulaDup)

            edit.lbCarId.Text = carid
            edit.cmbCarNameModelEdit.Text = carNameModel
            edit.cmbVersionEdit.Text = version
            edit.cmbType.Text = type


            edit.grpEdit.Visible = True
            Me.Close()
        End If
    End Sub

    Private Sub assignColorByCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fromAddFormula Then
            Dim butAddColor As Button = addFormula.Controls.Find("butAddColor", True)(0)

            Dim x As Integer = addFormula.Location.X + butAddColor.Location.X
            Dim y As Integer = addFormula.Location.Y + butAddColor.Location.Y
            Dim newPoint As New Point(x, y)
            Me.Location = newPoint
        Else
            Dim butAddColor As Button = edit.spltColor.Panel1.Controls.Find("butAddColor", True)(0)

            Dim x As Integer = edit.spltColor.Location.X + butAddColor.Location.X
            Dim y As Integer = edit.spltColor.Location.Y + butAddColor.Location.Y
            Dim newPoint As New Point(x, y)
            Me.Location = newPoint
           
        End If

        txtColorCode.Focus()
        txtColorCode.SelectAll()
    End Sub
End Class