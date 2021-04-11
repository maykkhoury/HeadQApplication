<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addFormula
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addFormula))
        Me.grpEditFormula = New System.Windows.Forms.GroupBox()
        Me.lbVariants = New System.Windows.Forms.Label()
        Me.butAddCar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pctFormulaColor = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkStar = New System.Windows.Forms.CheckBox()
        Me.chkVariantCL = New System.Windows.Forms.CheckBox()
        Me.chkVariantG = New System.Windows.Forms.CheckBox()
        Me.cmbCars = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkVariantCO = New System.Windows.Forms.CheckBox()
        Me.lbCarId = New System.Windows.Forms.Label()
        Me.chkVariantB = New System.Windows.Forms.CheckBox()
        Me.chkVariantY = New System.Windows.Forms.CheckBox()
        Me.chkVariantR = New System.Windows.Forms.CheckBox()
        Me.chkVariantL = New System.Windows.Forms.CheckBox()
        Me.chkVariantDRT = New System.Windows.Forms.CheckBox()
        Me.chkVariantF = New System.Windows.Forms.CheckBox()
        Me.chkVariantD = New System.Windows.Forms.CheckBox()
        Me.cmbVersion = New System.Windows.Forms.ComboBox()
        Me.pctCarImg = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lbFormulaId = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.butclose = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.butDeleteHidden = New System.Windows.Forms.Button()
        Me.butAddHidden = New System.Windows.Forms.Button()
        Me.lbColorDetails = New System.Windows.Forms.Label()
        Me.lbQuantity = New System.Windows.Forms.Label()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.chkApplyEquation = New System.Windows.Forms.CheckBox()
        Me.ToolTipVariant = New System.Windows.Forms.ToolTip(Me.components)
        Me.butClear = New System.Windows.Forms.Button()
        Me.pctColorDetailHidden = New System.Windows.Forms.PictureBox()
        Me.cmbChosenCars = New System.Windows.Forms.ComboBox()
        Me.butAssign = New System.Windows.Forms.Button()
        Me.butEditHidden = New System.Windows.Forms.Button()
        Me.chkEquation15perc4201 = New System.Windows.Forms.CheckBox()
        Me.chkMajdi = New System.Windows.Forms.CheckBox()
        Me.chkClearLs = New System.Windows.Forms.CheckBox()
        Me.txtQuantityDetailHidden = New HeadQApplication.MyTextBox()
        Me.txtColorsDetailHidden = New HeadQApplication.MyTextBox()
        Me.txtCardNumber = New HeadQApplication.MyTextBox()
        Me.txtYearMax = New HeadQApplication.MyTextBox()
        Me.txtYearMin = New HeadQApplication.MyTextBox()
        Me.txtColorCode = New HeadQApplication.MyTextBox()
        Me.txtFormulaName = New HeadQApplication.MyTextBox()
        Me.grpEditFormula.SuspendLayout()
        CType(Me.pctFormulaColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCarImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctColorDetailHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEditFormula
        '
        Me.grpEditFormula.Controls.Add(Me.lbVariants)
        Me.grpEditFormula.Controls.Add(Me.butAddCar)
        Me.grpEditFormula.Controls.Add(Me.txtCardNumber)
        Me.grpEditFormula.Controls.Add(Me.Label9)
        Me.grpEditFormula.Controls.Add(Me.Label7)
        Me.grpEditFormula.Controls.Add(Me.txtYearMax)
        Me.grpEditFormula.Controls.Add(Me.txtYearMin)
        Me.grpEditFormula.Controls.Add(Me.Label8)
        Me.grpEditFormula.Controls.Add(Me.pctFormulaColor)
        Me.grpEditFormula.Controls.Add(Me.Label6)
        Me.grpEditFormula.Controls.Add(Me.txtColorCode)
        Me.grpEditFormula.Controls.Add(Me.Label5)
        Me.grpEditFormula.Controls.Add(Me.chkStar)
        Me.grpEditFormula.Controls.Add(Me.chkVariantCL)
        Me.grpEditFormula.Controls.Add(Me.chkVariantG)
        Me.grpEditFormula.Controls.Add(Me.cmbCars)
        Me.grpEditFormula.Controls.Add(Me.Label1)
        Me.grpEditFormula.Controls.Add(Me.chkVariantCO)
        Me.grpEditFormula.Controls.Add(Me.lbCarId)
        Me.grpEditFormula.Controls.Add(Me.chkVariantB)
        Me.grpEditFormula.Controls.Add(Me.chkVariantY)
        Me.grpEditFormula.Controls.Add(Me.chkVariantR)
        Me.grpEditFormula.Controls.Add(Me.chkVariantL)
        Me.grpEditFormula.Controls.Add(Me.chkVariantDRT)
        Me.grpEditFormula.Controls.Add(Me.chkVariantF)
        Me.grpEditFormula.Controls.Add(Me.chkVariantD)
        Me.grpEditFormula.Controls.Add(Me.cmbVersion)
        Me.grpEditFormula.Controls.Add(Me.pctCarImg)
        Me.grpEditFormula.Controls.Add(Me.Label2)
        Me.grpEditFormula.Controls.Add(Me.txtFormulaName)
        Me.grpEditFormula.Controls.Add(Me.cmbType)
        Me.grpEditFormula.Controls.Add(Me.lbFormulaId)
        Me.grpEditFormula.Controls.Add(Me.Label3)
        Me.grpEditFormula.Controls.Add(Me.Label4)
        Me.grpEditFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEditFormula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpEditFormula.Location = New System.Drawing.Point(18, 15)
        Me.grpEditFormula.Margin = New System.Windows.Forms.Padding(4)
        Me.grpEditFormula.Name = "grpEditFormula"
        Me.grpEditFormula.Padding = New System.Windows.Forms.Padding(4)
        Me.grpEditFormula.Size = New System.Drawing.Size(891, 278)
        Me.grpEditFormula.TabIndex = 79
        Me.grpEditFormula.TabStop = False
        '
        'lbVariants
        '
        Me.lbVariants.AutoSize = True
        Me.lbVariants.ForeColor = System.Drawing.Color.Red
        Me.lbVariants.Location = New System.Drawing.Point(385, 217)
        Me.lbVariants.Name = "lbVariants"
        Me.lbVariants.Size = New System.Drawing.Size(14, 13)
        Me.lbVariants.TabIndex = 160
        Me.lbVariants.Text = "+"
        '
        'butAddCar
        '
        Me.butAddCar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.butAddCar.BackColor = System.Drawing.SystemColors.Control
        Me.butAddCar.Font = New System.Drawing.Font("Verdana", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddCar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butAddCar.Location = New System.Drawing.Point(57, 20)
        Me.butAddCar.Margin = New System.Windows.Forms.Padding(4)
        Me.butAddCar.Name = "butAddCar"
        Me.butAddCar.Size = New System.Drawing.Size(114, 21)
        Me.butAddCar.TabIndex = 154
        Me.butAddCar.Text = "Multi Car Mode"
        Me.butAddCar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 116)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "Card number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(266, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 154
        Me.Label8.Text = "Year:"
        '
        'pctFormulaColor
        '
        Me.pctFormulaColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pctFormulaColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctFormulaColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctFormulaColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctFormulaColor.Location = New System.Drawing.Point(179, 145)
        Me.pctFormulaColor.Margin = New System.Windows.Forms.Padding(4)
        Me.pctFormulaColor.Name = "pctFormulaColor"
        Me.pctFormulaColor.Size = New System.Drawing.Size(107, 29)
        Me.pctFormulaColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFormulaColor.TabIndex = 126
        Me.pctFormulaColor.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 144)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Color:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Color Code:"
        '
        'chkStar
        '
        Me.chkStar.AutoSize = True
        Me.chkStar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStar.Location = New System.Drawing.Point(366, 237)
        Me.chkStar.Name = "chkStar"
        Me.chkStar.Size = New System.Drawing.Size(44, 35)
        Me.chkStar.TabIndex = 8
        Me.chkStar.Text = "*"
        Me.chkStar.UseVisualStyleBackColor = True
        '
        'chkVariantCL
        '
        Me.chkVariantCL.AutoCheck = False
        Me.chkVariantCL.AutoSize = True
        Me.chkVariantCL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantCL.Location = New System.Drawing.Point(587, 190)
        Me.chkVariantCL.Name = "chkVariantCL"
        Me.chkVariantCL.Size = New System.Drawing.Size(41, 17)
        Me.chkVariantCL.TabIndex = 121
        Me.chkVariantCL.Text = "CL"
        Me.chkVariantCL.UseVisualStyleBackColor = True
        '
        'chkVariantG
        '
        Me.chkVariantG.AutoCheck = False
        Me.chkVariantG.AutoSize = True
        Me.chkVariantG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantG.Location = New System.Drawing.Point(536, 190)
        Me.chkVariantG.Name = "chkVariantG"
        Me.chkVariantG.Size = New System.Drawing.Size(35, 17)
        Me.chkVariantG.TabIndex = 120
        Me.chkVariantG.Text = "G"
        Me.chkVariantG.UseVisualStyleBackColor = True
        '
        'cmbCars
        '
        Me.cmbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCars.FormattingEnabled = True
        Me.cmbCars.Location = New System.Drawing.Point(179, 21)
        Me.cmbCars.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCars.Name = "cmbCars"
        Me.cmbCars.Size = New System.Drawing.Size(456, 21)
        Me.cmbCars.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Car:"
        '
        'chkVariantCO
        '
        Me.chkVariantCO.AutoCheck = False
        Me.chkVariantCO.AutoSize = True
        Me.chkVariantCO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantCO.Location = New System.Drawing.Point(474, 190)
        Me.chkVariantCO.Name = "chkVariantCO"
        Me.chkVariantCO.Size = New System.Drawing.Size(43, 17)
        Me.chkVariantCO.TabIndex = 119
        Me.chkVariantCO.Text = "CO"
        Me.chkVariantCO.UseVisualStyleBackColor = True
        '
        'lbCarId
        '
        Me.lbCarId.AutoSize = True
        Me.lbCarId.Location = New System.Drawing.Point(3, 21)
        Me.lbCarId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCarId.Name = "lbCarId"
        Me.lbCarId.Size = New System.Drawing.Size(18, 13)
        Me.lbCarId.TabIndex = 95
        Me.lbCarId.Text = "-1"
        Me.lbCarId.Visible = False
        '
        'chkVariantB
        '
        Me.chkVariantB.AutoCheck = False
        Me.chkVariantB.AutoSize = True
        Me.chkVariantB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantB.Location = New System.Drawing.Point(427, 190)
        Me.chkVariantB.Name = "chkVariantB"
        Me.chkVariantB.Size = New System.Drawing.Size(34, 17)
        Me.chkVariantB.TabIndex = 118
        Me.chkVariantB.Text = "B"
        Me.chkVariantB.UseVisualStyleBackColor = True
        '
        'chkVariantY
        '
        Me.chkVariantY.AutoCheck = False
        Me.chkVariantY.AutoSize = True
        Me.chkVariantY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantY.Location = New System.Drawing.Point(377, 190)
        Me.chkVariantY.Name = "chkVariantY"
        Me.chkVariantY.Size = New System.Drawing.Size(34, 17)
        Me.chkVariantY.TabIndex = 117
        Me.chkVariantY.Text = "Y"
        Me.chkVariantY.UseVisualStyleBackColor = True
        '
        'chkVariantR
        '
        Me.chkVariantR.AutoCheck = False
        Me.chkVariantR.AutoSize = True
        Me.chkVariantR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantR.Location = New System.Drawing.Point(587, 155)
        Me.chkVariantR.Name = "chkVariantR"
        Me.chkVariantR.Size = New System.Drawing.Size(35, 17)
        Me.chkVariantR.TabIndex = 116
        Me.chkVariantR.Text = "R"
        Me.chkVariantR.UseVisualStyleBackColor = True
        '
        'chkVariantL
        '
        Me.chkVariantL.AutoCheck = False
        Me.chkVariantL.AutoSize = True
        Me.chkVariantL.BackColor = System.Drawing.SystemColors.Control
        Me.chkVariantL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantL.Location = New System.Drawing.Point(536, 155)
        Me.chkVariantL.Name = "chkVariantL"
        Me.chkVariantL.Size = New System.Drawing.Size(33, 17)
        Me.chkVariantL.TabIndex = 115
        Me.chkVariantL.Text = "L"
        Me.chkVariantL.UseVisualStyleBackColor = False
        '
        'chkVariantDRT
        '
        Me.chkVariantDRT.AutoCheck = False
        Me.chkVariantDRT.AutoSize = True
        Me.chkVariantDRT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantDRT.Location = New System.Drawing.Point(474, 155)
        Me.chkVariantDRT.Name = "chkVariantDRT"
        Me.chkVariantDRT.Size = New System.Drawing.Size(52, 17)
        Me.chkVariantDRT.TabIndex = 114
        Me.chkVariantDRT.Text = "DRT"
        Me.chkVariantDRT.UseVisualStyleBackColor = True
        '
        'chkVariantF
        '
        Me.chkVariantF.AutoCheck = False
        Me.chkVariantF.AutoSize = True
        Me.chkVariantF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantF.Location = New System.Drawing.Point(427, 155)
        Me.chkVariantF.Name = "chkVariantF"
        Me.chkVariantF.Size = New System.Drawing.Size(33, 17)
        Me.chkVariantF.TabIndex = 113
        Me.chkVariantF.Text = "F"
        Me.chkVariantF.UseVisualStyleBackColor = True
        '
        'chkVariantD
        '
        Me.chkVariantD.AutoCheck = False
        Me.chkVariantD.AutoSize = True
        Me.chkVariantD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantD.Location = New System.Drawing.Point(377, 155)
        Me.chkVariantD.Name = "chkVariantD"
        Me.chkVariantD.Size = New System.Drawing.Size(35, 17)
        Me.chkVariantD.TabIndex = 112
        Me.chkVariantD.Text = "D"
        Me.chkVariantD.UseVisualStyleBackColor = True
        '
        'cmbVersion
        '
        Me.cmbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVersion.FormattingEnabled = True
        Me.cmbVersion.Items.AddRange(New Object() {"S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10"})
        Me.cmbVersion.Location = New System.Drawing.Point(179, 242)
        Me.cmbVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbVersion.Name = "cmbVersion"
        Me.cmbVersion.Size = New System.Drawing.Size(180, 21)
        Me.cmbVersion.TabIndex = 7
        '
        'pctCarImg
        '
        Me.pctCarImg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pctCarImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctCarImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctCarImg.Location = New System.Drawing.Point(643, 12)
        Me.pctCarImg.Margin = New System.Windows.Forms.Padding(4)
        Me.pctCarImg.Name = "pctCarImg"
        Me.pctCarImg.Size = New System.Drawing.Size(226, 188)
        Me.pctCarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCarImg.TabIndex = 110
        Me.pctCarImg.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Formula Name:"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"2K", "BC", "BC/2K", "LS"})
        Me.cmbType.Location = New System.Drawing.Point(179, 214)
        Me.cmbType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(180, 21)
        Me.cmbType.TabIndex = 6
        '
        'lbFormulaId
        '
        Me.lbFormulaId.AutoSize = True
        Me.lbFormulaId.Location = New System.Drawing.Point(125, 57)
        Me.lbFormulaId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFormulaId.Name = "lbFormulaId"
        Me.lbFormulaId.Size = New System.Drawing.Size(18, 13)
        Me.lbFormulaId.TabIndex = 96
        Me.lbFormulaId.Text = "-1"
        Me.lbFormulaId.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 242)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Hue:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Base coat:"
        '
        'butclose
        '
        Me.butclose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.butclose.BackColor = System.Drawing.SystemColors.Control
        Me.butclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butclose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butclose.Location = New System.Drawing.Point(446, 654)
        Me.butclose.Margin = New System.Windows.Forms.Padding(4)
        Me.butclose.Name = "butclose"
        Me.butclose.Size = New System.Drawing.Size(170, 30)
        Me.butclose.TabIndex = 108
        Me.butclose.Text = "Cancel"
        Me.butclose.UseVisualStyleBackColor = False
        '
        'butSave
        '
        Me.butSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.butSave.BackColor = System.Drawing.SystemColors.Control
        Me.butSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSave.Location = New System.Drawing.Point(267, 654)
        Me.butSave.Margin = New System.Windows.Forms.Padding(4)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(170, 30)
        Me.butSave.TabIndex = 109
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'butDeleteHidden
        '
        Me.butDeleteHidden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butDeleteHidden.BackColor = System.Drawing.SystemColors.Control
        Me.butDeleteHidden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDeleteHidden.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butDeleteHidden.Location = New System.Drawing.Point(720, 334)
        Me.butDeleteHidden.Margin = New System.Windows.Forms.Padding(4)
        Me.butDeleteHidden.Name = "butDeleteHidden"
        Me.butDeleteHidden.Size = New System.Drawing.Size(36, 25)
        Me.butDeleteHidden.TabIndex = 115
        Me.butDeleteHidden.Text = "-"
        Me.butDeleteHidden.UseVisualStyleBackColor = False
        Me.butDeleteHidden.Visible = False
        '
        'butAddHidden
        '
        Me.butAddHidden.BackColor = System.Drawing.SystemColors.Control
        Me.butAddHidden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddHidden.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddHidden.Location = New System.Drawing.Point(21, 371)
        Me.butAddHidden.Margin = New System.Windows.Forms.Padding(4)
        Me.butAddHidden.Name = "butAddHidden"
        Me.butAddHidden.Size = New System.Drawing.Size(36, 28)
        Me.butAddHidden.TabIndex = 110
        Me.butAddHidden.Text = "+"
        Me.butAddHidden.UseVisualStyleBackColor = False
        Me.butAddHidden.Visible = False
        '
        'lbColorDetails
        '
        Me.lbColorDetails.AutoSize = True
        Me.lbColorDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbColorDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbColorDetails.Location = New System.Drawing.Point(72, 297)
        Me.lbColorDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbColorDetails.Name = "lbColorDetails"
        Me.lbColorDetails.Size = New System.Drawing.Size(41, 15)
        Me.lbColorDetails.TabIndex = 112
        Me.lbColorDetails.Text = "Color"
        '
        'lbQuantity
        '
        Me.lbQuantity.AutoSize = True
        Me.lbQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuantity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbQuantity.Location = New System.Drawing.Point(356, 297)
        Me.lbQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbQuantity.Name = "lbQuantity"
        Me.lbQuantity.Size = New System.Drawing.Size(59, 15)
        Me.lbQuantity.TabIndex = 111
        Me.lbQuantity.Text = "Quantity"
        '
        'chkApplyEquation
        '
        Me.chkApplyEquation.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkApplyEquation.AutoSize = True
        Me.chkApplyEquation.Location = New System.Drawing.Point(12, 660)
        Me.chkApplyEquation.Name = "chkApplyEquation"
        Me.chkApplyEquation.Size = New System.Drawing.Size(136, 21)
        Me.chkApplyEquation.TabIndex = 152
        Me.chkApplyEquation.Text = "Apply Equation"
        Me.chkApplyEquation.UseVisualStyleBackColor = True
        Me.chkApplyEquation.Visible = False
        '
        'butClear
        '
        Me.butClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butClear.BackColor = System.Drawing.SystemColors.Control
        Me.butClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClear.Location = New System.Drawing.Point(739, 651)
        Me.butClear.Margin = New System.Windows.Forms.Padding(4)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(170, 30)
        Me.butClear.TabIndex = 153
        Me.butClear.Text = "Clear"
        Me.butClear.UseVisualStyleBackColor = False
        '
        'pctColorDetailHidden
        '
        Me.pctColorDetailHidden.InitialImage = Nothing
        Me.pctColorDetailHidden.Location = New System.Drawing.Point(48, 336)
        Me.pctColorDetailHidden.Name = "pctColorDetailHidden"
        Me.pctColorDetailHidden.Size = New System.Drawing.Size(21, 23)
        Me.pctColorDetailHidden.TabIndex = 151
        Me.pctColorDetailHidden.TabStop = False
        Me.pctColorDetailHidden.Visible = False
        Me.pctColorDetailHidden.WaitOnLoad = True
        '
        'cmbChosenCars
        '
        Me.cmbChosenCars.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbChosenCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChosenCars.FormattingEnabled = True
        Me.cmbChosenCars.Location = New System.Drawing.Point(661, 297)
        Me.cmbChosenCars.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbChosenCars.Name = "cmbChosenCars"
        Me.cmbChosenCars.Size = New System.Drawing.Size(248, 24)
        Me.cmbChosenCars.TabIndex = 160
        Me.cmbChosenCars.Visible = False
        '
        'butAssign
        '
        Me.butAssign.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butAssign.BackColor = System.Drawing.SystemColors.Control
        Me.butAssign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAssign.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAssign.Location = New System.Drawing.Point(783, 329)
        Me.butAssign.Margin = New System.Windows.Forms.Padding(4)
        Me.butAssign.Name = "butAssign"
        Me.butAssign.Size = New System.Drawing.Size(126, 30)
        Me.butAssign.TabIndex = 161
        Me.butAssign.Text = "Assign"
        Me.butAssign.UseVisualStyleBackColor = False
        '
        'butEditHidden
        '
        Me.butEditHidden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butEditHidden.BackColor = System.Drawing.SystemColors.Control
        Me.butEditHidden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEditHidden.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butEditHidden.Location = New System.Drawing.Point(661, 334)
        Me.butEditHidden.Margin = New System.Windows.Forms.Padding(4)
        Me.butEditHidden.Name = "butEditHidden"
        Me.butEditHidden.Size = New System.Drawing.Size(51, 25)
        Me.butEditHidden.TabIndex = 162
        Me.butEditHidden.Text = "Edit"
        Me.butEditHidden.UseVisualStyleBackColor = False
        Me.butEditHidden.Visible = False
        '
        'chkEquation15perc4201
        '
        Me.chkEquation15perc4201.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkEquation15perc4201.AutoSize = True
        Me.chkEquation15perc4201.Location = New System.Drawing.Point(10, 573)
        Me.chkEquation15perc4201.Name = "chkEquation15perc4201"
        Me.chkEquation15perc4201.Size = New System.Drawing.Size(179, 21)
        Me.chkEquation15perc4201.TabIndex = 163
        Me.chkEquation15perc4201.Text = "15% - 4201 Equation"
        Me.chkEquation15perc4201.UseVisualStyleBackColor = True
        Me.chkEquation15perc4201.Visible = False
        '
        'chkMajdi
        '
        Me.chkMajdi.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkMajdi.AutoSize = True
        Me.chkMajdi.Location = New System.Drawing.Point(177, 657)
        Me.chkMajdi.Name = "chkMajdi"
        Me.chkMajdi.Size = New System.Drawing.Size(83, 21)
        Me.chkMajdi.TabIndex = 164
        Me.chkMajdi.Text = "Majdi %"
        Me.chkMajdi.UseVisualStyleBackColor = True
        Me.chkMajdi.Visible = False
        '
        'chkClearLs
        '
        Me.chkClearLs.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkClearLs.AutoSize = True
        Me.chkClearLs.Location = New System.Drawing.Point(177, 630)
        Me.chkClearLs.Name = "chkClearLs"
        Me.chkClearLs.Size = New System.Drawing.Size(89, 21)
        Me.chkClearLs.TabIndex = 165
        Me.chkClearLs.Text = "Clear LS"
        Me.chkClearLs.UseVisualStyleBackColor = True
        Me.chkClearLs.Visible = False
        '
        'txtQuantityDetailHidden
        '
        Me.txtQuantityDetailHidden.Location = New System.Drawing.Point(360, 336)
        Me.txtQuantityDetailHidden.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantityDetailHidden.Name = "txtQuantityDetailHidden"
        Me.txtQuantityDetailHidden.ReadOnly = True
        Me.txtQuantityDetailHidden.Size = New System.Drawing.Size(198, 23)
        Me.txtQuantityDetailHidden.TabIndex = 114
        Me.txtQuantityDetailHidden.Visible = False
        '
        'txtColorsDetailHidden
        '
        Me.txtColorsDetailHidden.Location = New System.Drawing.Point(76, 336)
        Me.txtColorsDetailHidden.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColorsDetailHidden.Name = "txtColorsDetailHidden"
        Me.txtColorsDetailHidden.ReadOnly = True
        Me.txtColorsDetailHidden.Size = New System.Drawing.Size(283, 23)
        Me.txtColorsDetailHidden.TabIndex = 113
        Me.txtColorsDetailHidden.Visible = False
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(179, 116)
        Me.txtCardNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(457, 20)
        Me.txtCardNumber.TabIndex = 158
        '
        'txtYearMax
        '
        Me.txtYearMax.Location = New System.Drawing.Point(292, 180)
        Me.txtYearMax.MaxLength = 5
        Me.txtYearMax.Name = "txtYearMax"
        Me.txtYearMax.Size = New System.Drawing.Size(74, 20)
        Me.txtYearMax.TabIndex = 5
        '
        'txtYearMin
        '
        Me.txtYearMin.Location = New System.Drawing.Point(179, 180)
        Me.txtYearMin.MaxLength = 5
        Me.txtYearMin.Name = "txtYearMin"
        Me.txtYearMin.Size = New System.Drawing.Size(75, 20)
        Me.txtYearMin.TabIndex = 4
        '
        'txtColorCode
        '
        Me.txtColorCode.Location = New System.Drawing.Point(179, 88)
        Me.txtColorCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColorCode.Name = "txtColorCode"
        Me.txtColorCode.Size = New System.Drawing.Size(457, 20)
        Me.txtColorCode.TabIndex = 2
        '
        'txtFormulaName
        '
        Me.txtFormulaName.Location = New System.Drawing.Point(179, 57)
        Me.txtFormulaName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFormulaName.Name = "txtFormulaName"
        Me.txtFormulaName.Size = New System.Drawing.Size(457, 20)
        Me.txtFormulaName.TabIndex = 1
        '
        'addFormula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 686)
        Me.Controls.Add(Me.chkClearLs)
        Me.Controls.Add(Me.chkMajdi)
        Me.Controls.Add(Me.chkEquation15perc4201)
        Me.Controls.Add(Me.butEditHidden)
        Me.Controls.Add(Me.butAssign)
        Me.Controls.Add(Me.cmbChosenCars)
        Me.Controls.Add(Me.butClear)
        Me.Controls.Add(Me.chkApplyEquation)
        Me.Controls.Add(Me.pctColorDetailHidden)
        Me.Controls.Add(Me.butDeleteHidden)
        Me.Controls.Add(Me.butAddHidden)
        Me.Controls.Add(Me.txtQuantityDetailHidden)
        Me.Controls.Add(Me.txtColorsDetailHidden)
        Me.Controls.Add(Me.lbColorDetails)
        Me.Controls.Add(Me.lbQuantity)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.butclose)
        Me.Controls.Add(Me.grpEditFormula)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addFormula"
        Me.Text = "addFormula"
        Me.grpEditFormula.ResumeLayout(False)
        Me.grpEditFormula.PerformLayout()
        CType(Me.pctFormulaColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCarImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctColorDetailHidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEditFormula As System.Windows.Forms.GroupBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lbFormulaId As System.Windows.Forms.Label
    Friend WithEvents lbCarId As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFormulaName As MyTextBox
    Friend WithEvents butclose As System.Windows.Forms.Button
    Friend WithEvents butSave As System.Windows.Forms.Button
    Friend WithEvents cmbCars As System.Windows.Forms.ComboBox
    Friend WithEvents pctCarImg As System.Windows.Forms.PictureBox
    Friend WithEvents butDeleteHidden As System.Windows.Forms.Button
    Friend WithEvents butAddHidden As System.Windows.Forms.Button
    Friend WithEvents txtQuantityDetailHidden As HeadQApplication.MyTextBox
    Friend WithEvents txtColorsDetailHidden As HeadQApplication.MyTextBox
    Friend WithEvents lbColorDetails As System.Windows.Forms.Label
    Friend WithEvents lbQuantity As System.Windows.Forms.Label
    Friend WithEvents cmbVersion As System.Windows.Forms.ComboBox
    Friend WithEvents chkVariantCL As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantG As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantCO As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantB As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantY As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantR As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantL As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantDRT As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantF As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantD As System.Windows.Forms.CheckBox
    Friend WithEvents chkStar As System.Windows.Forms.CheckBox
    Friend WithEvents txtColorCode As HeadQApplication.MyTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pctColorDetailHidden As System.Windows.Forms.PictureBox
    Friend WithEvents pctFormulaColor As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtYearMax As HeadQApplication.MyTextBox
    Friend WithEvents txtYearMin As HeadQApplication.MyTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkApplyEquation As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTipVariant As System.Windows.Forms.ToolTip
    Friend WithEvents txtCardNumber As HeadQApplication.MyTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents butClear As System.Windows.Forms.Button
    Friend WithEvents butAddCar As System.Windows.Forms.Button
    Friend WithEvents cmbChosenCars As System.Windows.Forms.ComboBox
    Friend WithEvents butAssign As System.Windows.Forms.Button
    Friend WithEvents butEditHidden As System.Windows.Forms.Button
    Friend WithEvents lbVariants As System.Windows.Forms.Label
    Friend WithEvents chkEquation15perc4201 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMajdi As System.Windows.Forms.CheckBox
    Friend WithEvents chkClearLs As System.Windows.Forms.CheckBox
End Class
