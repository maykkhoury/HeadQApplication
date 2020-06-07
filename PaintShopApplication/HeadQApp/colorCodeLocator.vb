Public Class colorCodeLocator
    Dim MyCheckboxes(30) As CheckBox

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox(HeadQHome.txtCarNameForm.Text)


        Dim carname As String = HeadQHome.txtCarNameForm.Text
        Dim carImg As String = HeadQHome.txtCarImgPath.Text
        Dim carImgFile As String = HeadQHome.txtfnamehideen.Text
        Dim idCar As Long = HeadQHome.lsvCars.SelectedItems(0).SubItems(0).Text
        Dim ccl As String = getCarById(idCar).colorCodeLocation
        'MsgBox(ccl)
        'CREATE NEW CHECKBOX CONTROL ARRAY

        Dim CX As Integer
        Dim CY As Integer
        'LOOP THROUGH THE LAYERS AND CREATE A CHECKBOX FOR EACH
        cclTitle.Text = carname
        Dim i As Integer
        For i = 0 To 29


            'if the number of layers is 5 our Layer array will be 0 to 4

            MyCheckboxes(i) = New CheckBox

            'CYCLE THROUGH AND POPULATE CHECKBOXES
            'MsgBox(i)
            MyCheckboxes(i).Visible = True
            MyCheckboxes(i).Text = ""
            MyCheckboxes(i).Width = 15
            MyCheckboxes(i).Height = 14
            Me.Controls.Add(MyCheckboxes(i))

            MyCheckboxes(i).BringToFront()
            MyCheckboxes(i).Location = New Point(CX, CY)
        Next
        MyCheckboxes(0).Location = CheckBox1.Location
        MyCheckboxes(1).Location = CheckBox2.Location
        MyCheckboxes(2).Location = CheckBox3.Location
        MyCheckboxes(3).Location = CheckBox4.Location
        MyCheckboxes(4).Location = CheckBox5.Location
        MyCheckboxes(5).Location = CheckBox6.Location
        MyCheckboxes(6).Location = CheckBox7.Location
        MyCheckboxes(7).Location = CheckBox8.Location
        MyCheckboxes(8).Location = CheckBox9.Location
        MyCheckboxes(9).Location = CheckBox10.Location
        MyCheckboxes(10).Location = CheckBox11.Location
        MyCheckboxes(11).Location = CheckBox12.Location
        MyCheckboxes(12).Location = CheckBox13.Location
        MyCheckboxes(13).Location = CheckBox14.Location
        MyCheckboxes(14).Location = CheckBox15.Location
        MyCheckboxes(15).Location = CheckBox16.Location
        MyCheckboxes(16).Location = CheckBox17.Location
        MyCheckboxes(17).Location = CheckBox18.Location
        MyCheckboxes(18).Location = CheckBox19.Location
        MyCheckboxes(19).Location = CheckBox20.Location
        MyCheckboxes(20).Location = CheckBox21.Location
        MyCheckboxes(21).Location = CheckBox22.Location
        MyCheckboxes(22).Location = CheckBox23.Location
        MyCheckboxes(23).Location = CheckBox24.Location
        MyCheckboxes(24).Location = CheckBox25.Location
        MyCheckboxes(25).Location = CheckBox26.Location
        MyCheckboxes(26).Location = CheckBox27.Location
        MyCheckboxes(27).Location = CheckBox28.Location
        MyCheckboxes(28).Location = CheckBox29.Location
        MyCheckboxes(29).Location = CheckBox30.Location


        selectCheckBoxes(ccl, MyCheckboxes)
    End Sub



    Private Sub cclSaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cclSaveBtn.Click
        ' updateColorCodeLocator(d, idCar)

        Dim idCar As Long = HeadQHome.lsvCars.SelectedItems(0).SubItems(0).Text
        ' MsgBox(getLocation(MyCheckboxes))
        updateColorCodeLocator(getLocation(MyCheckboxes), idCar)
        Me.Dispose()
    End Sub
    Private Function getLocation(ByVal Mycheckboxes() As CheckBox) As String
        Dim location As String = ""
        Dim i As Integer
        For i = 0 To (Mycheckboxes.Length - 2)
            If (Mycheckboxes(i).Checked = True) Then
                location += i.ToString + ","
            End If
        Next
        Return location
    End Function

    Private Sub cclCancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cclCancelBtn.Click
        Me.Dispose()
    End Sub
    Private Sub selectCheckBoxes(ByVal selection As String, ByVal MyCheckboxes() As CheckBox)
        Dim arrData() As String
        Dim i As Long
        arrData = Split(selection, ",")
        If UBound(arrData) > 0 Then
            For i = 0 To UBound(arrData)
                Try
                    If Not arrData(i) = "" Then
                        MyCheckboxes(arrData(i)).Checked = True
                    End If
                Catch
                End Try
            Next
        End If
    End Sub
End Class
