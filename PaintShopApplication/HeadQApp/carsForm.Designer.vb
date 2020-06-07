<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.fileDialogCar = New System.Windows.Forms.OpenFileDialog()
        Me.grpCars = New System.Windows.Forms.GroupBox()
        Me.cclCar = New System.Windows.Forms.Button()
        Me.butCarFormChoose = New System.Windows.Forms.Button()
        Me.txtfnamehideen = New HeadQApplication.MyTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pctCarImg = New System.Windows.Forms.PictureBox()
        Me.butFindCarImg = New System.Windows.Forms.Button()
        Me.txtCarImgPath = New HeadQApplication.MyTextBox()
        Me.lbCarImgPath = New System.Windows.Forms.Label()
        Me.butDeleteCarForm = New System.Windows.Forms.Button()
        Me.lbIdCarForm = New System.Windows.Forms.Label()
        Me.butEditCarForm = New System.Windows.Forms.Button()
        Me.butAddCar = New System.Windows.Forms.Button()
        Me.chkCarFormName = New System.Windows.Forms.CheckBox()
        Me.txtCarNameForm = New HeadQApplication.MyTextBox()
        Me.lbCarNameForm = New System.Windows.Forms.Label()
        Me.cclCars = New System.Windows.Forms.ListView()
        Me.cidcar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.butSearchCarForm = New System.Windows.Forms.Button()
        Me.grpCars.SuspendLayout()
        CType(Me.pctCarImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fileDialogCar
        '
        Me.fileDialogCar.FileName = " "
        '
        'grpCars
        '
        Me.grpCars.BackColor = System.Drawing.Color.Transparent
        Me.grpCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpCars.Controls.Add(Me.cclCar)
        Me.grpCars.Controls.Add(Me.butCarFormChoose)
        Me.grpCars.Controls.Add(Me.txtfnamehideen)
        Me.grpCars.Controls.Add(Me.Label14)
        Me.grpCars.Controls.Add(Me.pctCarImg)
        Me.grpCars.Controls.Add(Me.butFindCarImg)
        Me.grpCars.Controls.Add(Me.txtCarImgPath)
        Me.grpCars.Controls.Add(Me.lbCarImgPath)
        Me.grpCars.Controls.Add(Me.butDeleteCarForm)
        Me.grpCars.Controls.Add(Me.lbIdCarForm)
        Me.grpCars.Controls.Add(Me.butEditCarForm)
        Me.grpCars.Controls.Add(Me.butAddCar)
        Me.grpCars.Controls.Add(Me.chkCarFormName)
        Me.grpCars.Controls.Add(Me.txtCarNameForm)
        Me.grpCars.Controls.Add(Me.lbCarNameForm)
        Me.grpCars.Controls.Add(Me.cclCars)
        Me.grpCars.Controls.Add(Me.butSearchCarForm)
        Me.grpCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCars.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpCars.Location = New System.Drawing.Point(12, 12)
        Me.grpCars.Name = "grpCars"
        Me.grpCars.Size = New System.Drawing.Size(1150, 638)
        Me.grpCars.TabIndex = 66
        Me.grpCars.TabStop = False
        Me.grpCars.Text = "Cars"
        '
        'cclCar
        '
        Me.cclCar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cclCar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cclCar.Location = New System.Drawing.Point(362, 104)
        Me.cclCar.Name = "cclCar"
        Me.cclCar.Size = New System.Drawing.Size(113, 79)
        Me.cclCar.TabIndex = 85
        Me.cclCar.Text = "Color Code Locator"
        Me.cclCar.UseVisualStyleBackColor = False
        '
        'butCarFormChoose
        '
        Me.butCarFormChoose.BackColor = System.Drawing.SystemColors.Control
        Me.butCarFormChoose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCarFormChoose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butCarFormChoose.Location = New System.Drawing.Point(838, 20)
        Me.butCarFormChoose.Name = "butCarFormChoose"
        Me.butCarFormChoose.Size = New System.Drawing.Size(113, 78)
        Me.butCarFormChoose.TabIndex = 84
        Me.butCarFormChoose.Text = "Choose"
        Me.butCarFormChoose.UseVisualStyleBackColor = False
        '
        'txtfnamehideen
        '
        Me.txtfnamehideen.Location = New System.Drawing.Point(233, 90)
        Me.txtfnamehideen.Name = "txtfnamehideen"
        Me.txtfnamehideen.ReadOnly = True
        Me.txtfnamehideen.Size = New System.Drawing.Size(101, 23)
        Me.txtfnamehideen.TabIndex = 83
        Me.txtfnamehideen.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(16, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Thumbnail:"
        '
        'pctCarImg
        '
        Me.pctCarImg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pctCarImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctCarImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctCarImg.Location = New System.Drawing.Point(126, 87)
        Me.pctCarImg.Name = "pctCarImg"
        Me.pctCarImg.Size = New System.Drawing.Size(101, 80)
        Me.pctCarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCarImg.TabIndex = 81
        Me.pctCarImg.TabStop = False
        '
        'butFindCarImg
        '
        Me.butFindCarImg.BackColor = System.Drawing.SystemColors.Control
        Me.butFindCarImg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butFindCarImg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butFindCarImg.Location = New System.Drawing.Point(299, 58)
        Me.butFindCarImg.Name = "butFindCarImg"
        Me.butFindCarImg.Size = New System.Drawing.Size(35, 23)
        Me.butFindCarImg.TabIndex = 80
        Me.butFindCarImg.Text = " -- "
        Me.butFindCarImg.UseVisualStyleBackColor = False
        '
        'txtCarImgPath
        '
        Me.txtCarImgPath.Location = New System.Drawing.Point(126, 58)
        Me.txtCarImgPath.Name = "txtCarImgPath"
        Me.txtCarImgPath.ReadOnly = True
        Me.txtCarImgPath.Size = New System.Drawing.Size(161, 23)
        Me.txtCarImgPath.TabIndex = 79
        '
        'lbCarImgPath
        '
        Me.lbCarImgPath.AutoSize = True
        Me.lbCarImgPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCarImgPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarImgPath.Location = New System.Drawing.Point(16, 58)
        Me.lbCarImgPath.Name = "lbCarImgPath"
        Me.lbCarImgPath.Size = New System.Drawing.Size(51, 15)
        Me.lbCarImgPath.TabIndex = 78
        Me.lbCarImgPath.Text = "Image:"
        '
        'butDeleteCarForm
        '
        Me.butDeleteCarForm.BackColor = System.Drawing.SystemColors.Control
        Me.butDeleteCarForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDeleteCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butDeleteCarForm.Location = New System.Drawing.Point(600, 20)
        Me.butDeleteCarForm.Name = "butDeleteCarForm"
        Me.butDeleteCarForm.Size = New System.Drawing.Size(113, 78)
        Me.butDeleteCarForm.TabIndex = 77
        Me.butDeleteCarForm.Text = "Delete Selected"
        Me.butDeleteCarForm.UseVisualStyleBackColor = False
        '
        'lbIdCarForm
        '
        Me.lbIdCarForm.AutoSize = True
        Me.lbIdCarForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdCarForm.Location = New System.Drawing.Point(16, 171)
        Me.lbIdCarForm.Name = "lbIdCarForm"
        Me.lbIdCarForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdCarForm.TabIndex = 76
        Me.lbIdCarForm.Text = "-1"
        Me.lbIdCarForm.Visible = False
        '
        'butEditCarForm
        '
        Me.butEditCarForm.BackColor = System.Drawing.SystemColors.Control
        Me.butEditCarForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEditCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butEditCarForm.Location = New System.Drawing.Point(481, 20)
        Me.butEditCarForm.Name = "butEditCarForm"
        Me.butEditCarForm.Size = New System.Drawing.Size(113, 78)
        Me.butEditCarForm.TabIndex = 75
        Me.butEditCarForm.Text = "Edit Selected"
        Me.butEditCarForm.UseVisualStyleBackColor = False
        '
        'butAddCar
        '
        Me.butAddCar.BackColor = System.Drawing.SystemColors.Control
        Me.butAddCar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddCar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddCar.Location = New System.Drawing.Point(362, 20)
        Me.butAddCar.Name = "butAddCar"
        Me.butAddCar.Size = New System.Drawing.Size(113, 78)
        Me.butAddCar.TabIndex = 71
        Me.butAddCar.Text = "Add New"
        Me.butAddCar.UseVisualStyleBackColor = False
        '
        'chkCarFormName
        '
        Me.chkCarFormName.AutoSize = True
        Me.chkCarFormName.Location = New System.Drawing.Point(319, 27)
        Me.chkCarFormName.Name = "chkCarFormName"
        Me.chkCarFormName.Size = New System.Drawing.Size(15, 14)
        Me.chkCarFormName.TabIndex = 70
        Me.chkCarFormName.UseVisualStyleBackColor = True
        '
        'txtCarNameForm
        '
        Me.txtCarNameForm.Location = New System.Drawing.Point(126, 25)
        Me.txtCarNameForm.Name = "txtCarNameForm"
        Me.txtCarNameForm.Size = New System.Drawing.Size(187, 23)
        Me.txtCarNameForm.TabIndex = 69
        '
        'lbCarNameForm
        '
        Me.lbCarNameForm.AutoSize = True
        Me.lbCarNameForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCarNameForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarNameForm.Location = New System.Drawing.Point(16, 25)
        Me.lbCarNameForm.Name = "lbCarNameForm"
        Me.lbCarNameForm.Size = New System.Drawing.Size(73, 15)
        Me.lbCarNameForm.TabIndex = 68
        Me.lbCarNameForm.Text = "Car name:"
        '
        'cclCars
        '
        Me.cclCars.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cclCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidcar, Me.ColumnHeader1})
        Me.cclCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cclCars.FullRowSelect = True
        Me.cclCars.GridLines = True
        Me.cclCars.HideSelection = False
        Me.cclCars.Location = New System.Drawing.Point(10, 189)
        Me.cclCars.MultiSelect = False
        Me.cclCars.Name = "cclCars"
        Me.cclCars.Size = New System.Drawing.Size(1134, 443)
        Me.cclCars.TabIndex = 55
        Me.cclCars.UseCompatibleStateImageBehavior = False
        Me.cclCars.View = System.Windows.Forms.View.Details
        '
        'cidcar
        '
        Me.cidcar.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Car Name"
        Me.ColumnHeader1.Width = 400
        '
        'butSearchCarForm
        '
        Me.butSearchCarForm.BackColor = System.Drawing.SystemColors.Control
        Me.butSearchCarForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSearchCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSearchCarForm.Location = New System.Drawing.Point(719, 20)
        Me.butSearchCarForm.Name = "butSearchCarForm"
        Me.butSearchCarForm.Size = New System.Drawing.Size(113, 78)
        Me.butSearchCarForm.TabIndex = 9
        Me.butSearchCarForm.Text = "Find"
        Me.butSearchCarForm.UseVisualStyleBackColor = False
        '
        'carsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 609)
        Me.Controls.Add(Me.grpCars)
        Me.Name = "carsForm"
        Me.Text = "Choose"
        Me.grpCars.ResumeLayout(False)
        Me.grpCars.PerformLayout()
        CType(Me.pctCarImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fileDialogCar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grpCars As System.Windows.Forms.GroupBox
    Friend WithEvents butCarFormChoose As System.Windows.Forms.Button
    Friend WithEvents txtfnamehideen As HeadQApplication.MyTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents pctCarImg As System.Windows.Forms.PictureBox
    Friend WithEvents butFindCarImg As System.Windows.Forms.Button
    Friend WithEvents txtCarImgPath As HeadQApplication.MyTextBox
    Friend WithEvents lbCarImgPath As System.Windows.Forms.Label
    Friend WithEvents butDeleteCarForm As System.Windows.Forms.Button
    Friend WithEvents lbIdCarForm As System.Windows.Forms.Label
    Friend WithEvents butEditCarForm As System.Windows.Forms.Button
    Friend WithEvents butAddCar As System.Windows.Forms.Button
    Friend WithEvents chkCarFormName As System.Windows.Forms.CheckBox
    Friend WithEvents txtCarNameForm As HeadQApplication.MyTextBox
    Friend WithEvents lbCarNameForm As System.Windows.Forms.Label
    Friend WithEvents cclCars As System.Windows.Forms.ListView
    Friend WithEvents cidcar As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butSearchCarForm As System.Windows.Forms.Button
    Friend WithEvents cclCar As System.Windows.Forms.Button
End Class
