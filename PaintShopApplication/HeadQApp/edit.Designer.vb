<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit
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
        Me.grpEdit = New System.Windows.Forms.GroupBox()
        Me.butClear = New System.Windows.Forms.Button()
        Me.chkApplyEquation = New System.Windows.Forms.CheckBox()
        Me.butExit = New System.Windows.Forms.Button()
        Me.spltColor = New System.Windows.Forms.SplitContainer()
        Me.txtColorsDetailHidden = New HeadQApplication.MyTextBox()
        Me.pctColorDetailHidden = New System.Windows.Forms.PictureBox()
        Me.lbColorDetails = New System.Windows.Forms.Label()
        Me.butAddHidden = New System.Windows.Forms.Button()
        Me.lbQuantity = New System.Windows.Forms.Label()
        Me.txtQuantityDetailHidden = New HeadQApplication.MyTextBox()
        Me.butDeleteHidden = New System.Windows.Forms.Button()
        Me.grpEditFormula = New System.Windows.Forms.GroupBox()
        Me.lbAsteriks = New System.Windows.Forms.Label()
        Me.lbMultiplyBy = New System.Windows.Forms.Label()
        Me.chkEquation4201_180 = New System.Windows.Forms.CheckBox()
        Me.butMultiply = New System.Windows.Forms.Button()
        Me.txtModDate = New HeadQApplication.MyTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkMajdi4conv = New System.Windows.Forms.CheckBox()
        Me.chkClearLs = New System.Windows.Forms.CheckBox()
        Me.chkMajdi = New System.Windows.Forms.CheckBox()
        Me.txtLSConv = New HeadQApplication.MyTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbEquation = New System.Windows.Forms.Label()
        Me.chkEquation15perc4201 = New System.Windows.Forms.CheckBox()
        Me.butAddCar = New System.Windows.Forms.Button()
        Me.lbVariants = New System.Windows.Forms.Label()
        Me.txtCardNumber = New HeadQApplication.MyTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFormulaCode = New HeadQApplication.MyTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtYearMax = New HeadQApplication.MyTextBox()
        Me.txtYearMin = New HeadQApplication.MyTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pctFormulaColor = New System.Windows.Forms.PictureBox()
        Me.pctCarImgDetails = New System.Windows.Forms.PictureBox()
        Me.cmbCarNameModelEdit = New System.Windows.Forms.ComboBox()
        Me.chkVariantCL = New System.Windows.Forms.CheckBox()
        Me.chkVariantR = New System.Windows.Forms.CheckBox()
        Me.chkVariantG = New System.Windows.Forms.CheckBox()
        Me.chkVariantCO = New System.Windows.Forms.CheckBox()
        Me.chkVariantL = New System.Windows.Forms.CheckBox()
        Me.chkVariantDRT = New System.Windows.Forms.CheckBox()
        Me.chkVariantB = New System.Windows.Forms.CheckBox()
        Me.chkVariantY = New System.Windows.Forms.CheckBox()
        Me.chkVariantF = New System.Windows.Forms.CheckBox()
        Me.chkVariantD = New System.Windows.Forms.CheckBox()
        Me.chkStar = New System.Windows.Forms.CheckBox()
        Me.cmbVersionEdit = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lbFormulaId = New System.Windows.Forms.Label()
        Me.lbCarId = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butValidateHidden = New System.Windows.Forms.Button()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.ToolTipVariant = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpEdit.SuspendLayout()
        Me.spltColor.Panel1.SuspendLayout()
        Me.spltColor.Panel2.SuspendLayout()
        Me.spltColor.SuspendLayout()
        CType(Me.pctColorDetailHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEditFormula.SuspendLayout()
        CType(Me.pctFormulaColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCarImgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEdit
        '
        Me.grpEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEdit.BackColor = System.Drawing.Color.Transparent
        Me.grpEdit.Controls.Add(Me.butClear)
        Me.grpEdit.Controls.Add(Me.chkApplyEquation)
        Me.grpEdit.Controls.Add(Me.butExit)
        Me.grpEdit.Controls.Add(Me.spltColor)
        Me.grpEdit.Controls.Add(Me.grpEditFormula)
        Me.grpEdit.Controls.Add(Me.butValidateHidden)
        Me.grpEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpEdit.Location = New System.Drawing.Point(12, 12)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Size = New System.Drawing.Size(1104, 623)
        Me.grpEdit.TabIndex = 66
        Me.grpEdit.TabStop = False
        Me.grpEdit.Text = "Edit"
        Me.grpEdit.Visible = False
        '
        'butClear
        '
        Me.butClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClear.Location = New System.Drawing.Point(16, 595)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(125, 26)
        Me.butClear.TabIndex = 154
        Me.butClear.Text = "Clear"
        Me.butClear.UseVisualStyleBackColor = True
        Me.butClear.Visible = False
        '
        'chkApplyEquation
        '
        Me.chkApplyEquation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkApplyEquation.AutoSize = True
        Me.chkApplyEquation.Location = New System.Drawing.Point(662, 595)
        Me.chkApplyEquation.Name = "chkApplyEquation"
        Me.chkApplyEquation.Size = New System.Drawing.Size(136, 21)
        Me.chkApplyEquation.TabIndex = 153
        Me.chkApplyEquation.Text = "Apply Equation"
        Me.chkApplyEquation.UseVisualStyleBackColor = True
        Me.chkApplyEquation.Visible = False
        '
        'butExit
        '
        Me.butExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butExit.BackColor = System.Drawing.SystemColors.Control
        Me.butExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butExit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.butExit.Location = New System.Drawing.Point(979, 591)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(119, 26)
        Me.butExit.TabIndex = 152
        Me.butExit.Text = "Back"
        Me.butExit.UseVisualStyleBackColor = False
        '
        'spltColor
        '
        Me.spltColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spltColor.IsSplitterFixed = True
        Me.spltColor.Location = New System.Drawing.Point(17, 184)
        Me.spltColor.Name = "spltColor"
        '
        'spltColor.Panel1
        '
        Me.spltColor.Panel1.Controls.Add(Me.txtColorsDetailHidden)
        Me.spltColor.Panel1.Controls.Add(Me.pctColorDetailHidden)
        Me.spltColor.Panel1.Controls.Add(Me.lbColorDetails)
        Me.spltColor.Panel1.Controls.Add(Me.butAddHidden)
        '
        'spltColor.Panel2
        '
        Me.spltColor.Panel2.Controls.Add(Me.lbQuantity)
        Me.spltColor.Panel2.Controls.Add(Me.txtQuantityDetailHidden)
        Me.spltColor.Panel2.Controls.Add(Me.butDeleteHidden)
        Me.spltColor.Size = New System.Drawing.Size(1081, 401)
        Me.spltColor.SplitterDistance = 661
        Me.spltColor.SplitterWidth = 1
        Me.spltColor.TabIndex = 151
        '
        'txtColorsDetailHidden
        '
        Me.txtColorsDetailHidden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtColorsDetailHidden.Location = New System.Drawing.Point(68, 36)
        Me.txtColorsDetailHidden.Name = "txtColorsDetailHidden"
        Me.txtColorsDetailHidden.ReadOnly = True
        Me.txtColorsDetailHidden.Size = New System.Drawing.Size(1226, 23)
        Me.txtColorsDetailHidden.TabIndex = 91
        Me.txtColorsDetailHidden.Visible = False
        '
        'pctColorDetailHidden
        '
        Me.pctColorDetailHidden.InitialImage = Nothing
        Me.pctColorDetailHidden.Location = New System.Drawing.Point(41, 35)
        Me.pctColorDetailHidden.Name = "pctColorDetailHidden"
        Me.pctColorDetailHidden.Size = New System.Drawing.Size(21, 23)
        Me.pctColorDetailHidden.TabIndex = 150
        Me.pctColorDetailHidden.TabStop = False
        Me.pctColorDetailHidden.Visible = False
        Me.pctColorDetailHidden.WaitOnLoad = True
        '
        'lbColorDetails
        '
        Me.lbColorDetails.AutoSize = True
        Me.lbColorDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbColorDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbColorDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbColorDetails.Location = New System.Drawing.Point(0, 0)
        Me.lbColorDetails.Name = "lbColorDetails"
        Me.lbColorDetails.Size = New System.Drawing.Size(41, 15)
        Me.lbColorDetails.TabIndex = 90
        Me.lbColorDetails.Text = "Color"
        '
        'butAddHidden
        '
        Me.butAddHidden.BackColor = System.Drawing.SystemColors.Control
        Me.butAddHidden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddHidden.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddHidden.Location = New System.Drawing.Point(16, 64)
        Me.butAddHidden.Name = "butAddHidden"
        Me.butAddHidden.Size = New System.Drawing.Size(24, 23)
        Me.butAddHidden.TabIndex = 78
        Me.butAddHidden.Text = "+"
        Me.butAddHidden.UseVisualStyleBackColor = False
        Me.butAddHidden.Visible = False
        '
        'lbQuantity
        '
        Me.lbQuantity.AutoSize = True
        Me.lbQuantity.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuantity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbQuantity.Location = New System.Drawing.Point(0, 0)
        Me.lbQuantity.Name = "lbQuantity"
        Me.lbQuantity.Size = New System.Drawing.Size(59, 15)
        Me.lbQuantity.TabIndex = 89
        Me.lbQuantity.Text = "Quantity"
        '
        'txtQuantityDetailHidden
        '
        Me.txtQuantityDetailHidden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantityDetailHidden.Location = New System.Drawing.Point(6, 36)
        Me.txtQuantityDetailHidden.Name = "txtQuantityDetailHidden"
        Me.txtQuantityDetailHidden.ReadOnly = True
        Me.txtQuantityDetailHidden.Size = New System.Drawing.Size(373, 23)
        Me.txtQuantityDetailHidden.TabIndex = 92
        Me.txtQuantityDetailHidden.Visible = False
        '
        'butDeleteHidden
        '
        Me.butDeleteHidden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butDeleteHidden.BackColor = System.Drawing.SystemColors.Control
        Me.butDeleteHidden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDeleteHidden.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butDeleteHidden.Location = New System.Drawing.Point(385, 36)
        Me.butDeleteHidden.Name = "butDeleteHidden"
        Me.butDeleteHidden.Size = New System.Drawing.Size(24, 23)
        Me.butDeleteHidden.TabIndex = 94
        Me.butDeleteHidden.Text = "-"
        Me.butDeleteHidden.UseVisualStyleBackColor = False
        Me.butDeleteHidden.Visible = False
        '
        'grpEditFormula
        '
        Me.grpEditFormula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEditFormula.Controls.Add(Me.lbAsteriks)
        Me.grpEditFormula.Controls.Add(Me.lbMultiplyBy)
        Me.grpEditFormula.Controls.Add(Me.chkEquation4201_180)
        Me.grpEditFormula.Controls.Add(Me.butMultiply)
        Me.grpEditFormula.Controls.Add(Me.txtModDate)
        Me.grpEditFormula.Controls.Add(Me.Label9)
        Me.grpEditFormula.Controls.Add(Me.chkMajdi4conv)
        Me.grpEditFormula.Controls.Add(Me.chkClearLs)
        Me.grpEditFormula.Controls.Add(Me.chkMajdi)
        Me.grpEditFormula.Controls.Add(Me.txtLSConv)
        Me.grpEditFormula.Controls.Add(Me.Label8)
        Me.grpEditFormula.Controls.Add(Me.lbEquation)
        Me.grpEditFormula.Controls.Add(Me.chkEquation15perc4201)
        Me.grpEditFormula.Controls.Add(Me.butAddCar)
        Me.grpEditFormula.Controls.Add(Me.lbVariants)
        Me.grpEditFormula.Controls.Add(Me.txtCardNumber)
        Me.grpEditFormula.Controls.Add(Me.Label7)
        Me.grpEditFormula.Controls.Add(Me.txtFormulaCode)
        Me.grpEditFormula.Controls.Add(Me.Label6)
        Me.grpEditFormula.Controls.Add(Me.Label5)
        Me.grpEditFormula.Controls.Add(Me.txtYearMax)
        Me.grpEditFormula.Controls.Add(Me.txtYearMin)
        Me.grpEditFormula.Controls.Add(Me.Label2)
        Me.grpEditFormula.Controls.Add(Me.pctFormulaColor)
        Me.grpEditFormula.Controls.Add(Me.pctCarImgDetails)
        Me.grpEditFormula.Controls.Add(Me.cmbCarNameModelEdit)
        Me.grpEditFormula.Controls.Add(Me.chkVariantCL)
        Me.grpEditFormula.Controls.Add(Me.chkVariantR)
        Me.grpEditFormula.Controls.Add(Me.chkVariantG)
        Me.grpEditFormula.Controls.Add(Me.chkVariantCO)
        Me.grpEditFormula.Controls.Add(Me.chkVariantL)
        Me.grpEditFormula.Controls.Add(Me.chkVariantDRT)
        Me.grpEditFormula.Controls.Add(Me.chkVariantB)
        Me.grpEditFormula.Controls.Add(Me.chkVariantY)
        Me.grpEditFormula.Controls.Add(Me.chkVariantF)
        Me.grpEditFormula.Controls.Add(Me.chkVariantD)
        Me.grpEditFormula.Controls.Add(Me.chkStar)
        Me.grpEditFormula.Controls.Add(Me.cmbVersionEdit)
        Me.grpEditFormula.Controls.Add(Me.cmbType)
        Me.grpEditFormula.Controls.Add(Me.lbFormulaId)
        Me.grpEditFormula.Controls.Add(Me.lbCarId)
        Me.grpEditFormula.Controls.Add(Me.Label3)
        Me.grpEditFormula.Controls.Add(Me.Label4)
        Me.grpEditFormula.Controls.Add(Me.Label1)
        Me.grpEditFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEditFormula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpEditFormula.Location = New System.Drawing.Point(16, 16)
        Me.grpEditFormula.Name = "grpEditFormula"
        Me.grpEditFormula.Size = New System.Drawing.Size(1082, 162)
        Me.grpEditFormula.TabIndex = 78
        Me.grpEditFormula.TabStop = False
        '
        'lbAsteriks
        '
        Me.lbAsteriks.AutoSize = True
        Me.lbAsteriks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAsteriks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbAsteriks.Location = New System.Drawing.Point(271, 47)
        Me.lbAsteriks.Name = "lbAsteriks"
        Me.lbAsteriks.Size = New System.Drawing.Size(16, 20)
        Me.lbAsteriks.TabIndex = 174
        Me.lbAsteriks.Text = "*"
        '
        'lbMultiplyBy
        '
        Me.lbMultiplyBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbMultiplyBy.AutoSize = True
        Me.lbMultiplyBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbMultiplyBy.Location = New System.Drawing.Point(893, 71)
        Me.lbMultiplyBy.Name = "lbMultiplyBy"
        Me.lbMultiplyBy.Size = New System.Drawing.Size(20, 13)
        Me.lbMultiplyBy.TabIndex = 167
        Me.lbMultiplyBy.Text = "x1"
        '
        'chkEquation4201_180
        '
        Me.chkEquation4201_180.AutoSize = True
        Me.chkEquation4201_180.Location = New System.Drawing.Point(316, 129)
        Me.chkEquation4201_180.Name = "chkEquation4201_180"
        Me.chkEquation4201_180.Size = New System.Drawing.Size(168, 17)
        Me.chkEquation4201_180.TabIndex = 173
        Me.chkEquation4201_180.Text = "Apply 4201-180 Equation"
        Me.chkEquation4201_180.UseVisualStyleBackColor = True
        '
        'butMultiply
        '
        Me.butMultiply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butMultiply.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butMultiply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butMultiply.Location = New System.Drawing.Point(709, 68)
        Me.butMultiply.Name = "butMultiply"
        Me.butMultiply.Size = New System.Drawing.Size(180, 23)
        Me.butMultiply.TabIndex = 155
        Me.butMultiply.Text = "Multiply quantities by"
        Me.butMultiply.UseVisualStyleBackColor = True
        '
        'txtModDate
        '
        Me.txtModDate.Location = New System.Drawing.Point(289, 45)
        Me.txtModDate.MaxLength = 30
        Me.txtModDate.Name = "txtModDate"
        Me.txtModDate.ReadOnly = True
        Me.txtModDate.Size = New System.Drawing.Size(210, 20)
        Me.txtModDate.TabIndex = 172
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(206, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "Mod. date:"
        '
        'chkMajdi4conv
        '
        Me.chkMajdi4conv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMajdi4conv.AutoSize = True
        Me.chkMajdi4conv.Location = New System.Drawing.Point(811, 137)
        Me.chkMajdi4conv.Name = "chkMajdi4conv"
        Me.chkMajdi4conv.Size = New System.Drawing.Size(116, 17)
        Me.chkMajdi4conv.TabIndex = 170
        Me.chkMajdi4conv.Text = "Majdi 4 conv. %"
        Me.chkMajdi4conv.UseVisualStyleBackColor = True
        '
        'chkClearLs
        '
        Me.chkClearLs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkClearLs.AutoSize = True
        Me.chkClearLs.Location = New System.Drawing.Point(853, 91)
        Me.chkClearLs.Name = "chkClearLs"
        Me.chkClearLs.Size = New System.Drawing.Size(74, 17)
        Me.chkClearLs.TabIndex = 169
        Me.chkClearLs.Text = "Clear LS"
        Me.chkClearLs.UseVisualStyleBackColor = True
        Me.chkClearLs.Visible = False
        '
        'chkMajdi
        '
        Me.chkMajdi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMajdi.AutoSize = True
        Me.chkMajdi.Location = New System.Drawing.Point(853, 114)
        Me.chkMajdi.Name = "chkMajdi"
        Me.chkMajdi.Size = New System.Drawing.Size(69, 17)
        Me.chkMajdi.TabIndex = 168
        Me.chkMajdi.Text = "Majdi %"
        Me.chkMajdi.UseVisualStyleBackColor = True
        Me.chkMajdi.Visible = False
        '
        'txtLSConv
        '
        Me.txtLSConv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLSConv.Location = New System.Drawing.Point(808, 44)
        Me.txtLSConv.MaxLength = 30
        Me.txtLSConv.Name = "txtLSConv"
        Me.txtLSConv.Size = New System.Drawing.Size(115, 20)
        Me.txtLSConv.TabIndex = 167
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(736, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 166
        Me.Label8.Text = "Conversion:"
        '
        'lbEquation
        '
        Me.lbEquation.AutoSize = True
        Me.lbEquation.ForeColor = System.Drawing.Color.Red
        Me.lbEquation.Location = New System.Drawing.Point(313, 74)
        Me.lbEquation.Name = "lbEquation"
        Me.lbEquation.Size = New System.Drawing.Size(187, 26)
        Me.lbEquation.TabIndex = 165
        Me.lbEquation.Text = "Attention: Equation 15% - 4201 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is already applied"
        Me.lbEquation.Visible = False
        '
        'chkEquation15perc4201
        '
        Me.chkEquation15perc4201.AutoSize = True
        Me.chkEquation15perc4201.Location = New System.Drawing.Point(316, 103)
        Me.chkEquation15perc4201.Name = "chkEquation15perc4201"
        Me.chkEquation15perc4201.Size = New System.Drawing.Size(143, 17)
        Me.chkEquation15perc4201.TabIndex = 164
        Me.chkEquation15perc4201.Text = "15% - 4201 Equation"
        Me.chkEquation15perc4201.UseVisualStyleBackColor = True
        Me.chkEquation15perc4201.Visible = False
        '
        'butAddCar
        '
        Me.butAddCar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butAddCar.BackColor = System.Drawing.SystemColors.Control
        Me.butAddCar.Font = New System.Drawing.Font("Verdana", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddCar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butAddCar.Location = New System.Drawing.Point(808, 16)
        Me.butAddCar.Margin = New System.Windows.Forms.Padding(4)
        Me.butAddCar.Name = "butAddCar"
        Me.butAddCar.Size = New System.Drawing.Size(114, 21)
        Me.butAddCar.TabIndex = 155
        Me.butAddCar.Text = "Multi Car Mode"
        Me.butAddCar.UseVisualStyleBackColor = False
        '
        'lbVariants
        '
        Me.lbVariants.AutoSize = True
        Me.lbVariants.ForeColor = System.Drawing.Color.Red
        Me.lbVariants.Location = New System.Drawing.Point(571, 75)
        Me.lbVariants.Name = "lbVariants"
        Me.lbVariants.Size = New System.Drawing.Size(14, 13)
        Me.lbVariants.TabIndex = 161
        Me.lbVariants.Text = "+"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(605, 45)
        Me.txtCardNumber.MaxLength = 30
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(129, 20)
        Me.txtCardNumber.TabIndex = 157
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(523, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Card number:"
        '
        'txtFormulaCode
        '
        Me.txtFormulaCode.Location = New System.Drawing.Point(605, 16)
        Me.txtFormulaCode.MaxLength = 30
        Me.txtFormulaCode.Name = "txtFormulaCode"
        Me.txtFormulaCode.Size = New System.Drawing.Size(129, 20)
        Me.txtFormulaCode.TabIndex = 155
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(523, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(206, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "-"
        '
        'txtYearMax
        '
        Me.txtYearMax.Location = New System.Drawing.Point(232, 100)
        Me.txtYearMax.MaxLength = 5
        Me.txtYearMax.Name = "txtYearMax"
        Me.txtYearMax.Size = New System.Drawing.Size(74, 20)
        Me.txtYearMax.TabIndex = 152
        '
        'txtYearMin
        '
        Me.txtYearMin.Location = New System.Drawing.Point(119, 100)
        Me.txtYearMin.MaxLength = 5
        Me.txtYearMin.Name = "txtYearMin"
        Me.txtYearMin.Size = New System.Drawing.Size(75, 20)
        Me.txtYearMin.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Year:"
        '
        'pctFormulaColor
        '
        Me.pctFormulaColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctFormulaColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctFormulaColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctFormulaColor.Location = New System.Drawing.Point(119, 124)
        Me.pctFormulaColor.Margin = New System.Windows.Forms.Padding(4)
        Me.pctFormulaColor.Name = "pctFormulaColor"
        Me.pctFormulaColor.Size = New System.Drawing.Size(187, 26)
        Me.pctFormulaColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFormulaColor.TabIndex = 137
        Me.pctFormulaColor.TabStop = False
        '
        'pctCarImgDetails
        '
        Me.pctCarImgDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctCarImgDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctCarImgDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctCarImgDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctCarImgDetails.Location = New System.Drawing.Point(930, 16)
        Me.pctCarImgDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.pctCarImgDetails.Name = "pctCarImgDetails"
        Me.pctCarImgDetails.Size = New System.Drawing.Size(145, 139)
        Me.pctCarImgDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCarImgDetails.TabIndex = 135
        Me.pctCarImgDetails.TabStop = False
        '
        'cmbCarNameModelEdit
        '
        Me.cmbCarNameModelEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarNameModelEdit.FormattingEnabled = True
        Me.cmbCarNameModelEdit.Location = New System.Drawing.Point(119, 16)
        Me.cmbCarNameModelEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCarNameModelEdit.Name = "cmbCarNameModelEdit"
        Me.cmbCarNameModelEdit.Size = New System.Drawing.Size(381, 21)
        Me.cmbCarNameModelEdit.TabIndex = 134
        '
        'chkVariantCL
        '
        Me.chkVariantCL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantCL.AutoCheck = False
        Me.chkVariantCL.AutoSize = True
        Me.chkVariantCL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantCL.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantCL.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantCL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantCL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantCL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantCL.Location = New System.Drawing.Point(762, 129)
        Me.chkVariantCL.Name = "chkVariantCL"
        Me.chkVariantCL.Size = New System.Drawing.Size(41, 17)
        Me.chkVariantCL.TabIndex = 133
        Me.chkVariantCL.Text = "CL"
        Me.chkVariantCL.UseVisualStyleBackColor = True
        '
        'chkVariantR
        '
        Me.chkVariantR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantR.AutoCheck = False
        Me.chkVariantR.AutoSize = True
        Me.chkVariantR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantR.Location = New System.Drawing.Point(762, 99)
        Me.chkVariantR.Name = "chkVariantR"
        Me.chkVariantR.Size = New System.Drawing.Size(35, 17)
        Me.chkVariantR.TabIndex = 132
        Me.chkVariantR.Text = "R"
        Me.chkVariantR.UseVisualStyleBackColor = True
        '
        'chkVariantG
        '
        Me.chkVariantG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantG.AutoCheck = False
        Me.chkVariantG.AutoSize = True
        Me.chkVariantG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantG.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantG.Location = New System.Drawing.Point(699, 129)
        Me.chkVariantG.Name = "chkVariantG"
        Me.chkVariantG.Size = New System.Drawing.Size(35, 17)
        Me.chkVariantG.TabIndex = 131
        Me.chkVariantG.Text = "G"
        Me.chkVariantG.UseVisualStyleBackColor = True
        '
        'chkVariantCO
        '
        Me.chkVariantCO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantCO.AutoCheck = False
        Me.chkVariantCO.AutoSize = True
        Me.chkVariantCO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantCO.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantCO.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantCO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantCO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantCO.Location = New System.Drawing.Point(625, 129)
        Me.chkVariantCO.Name = "chkVariantCO"
        Me.chkVariantCO.Size = New System.Drawing.Size(43, 17)
        Me.chkVariantCO.TabIndex = 130
        Me.chkVariantCO.Text = "CO"
        Me.chkVariantCO.UseVisualStyleBackColor = True
        '
        'chkVariantL
        '
        Me.chkVariantL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantL.AutoCheck = False
        Me.chkVariantL.AutoSize = True
        Me.chkVariantL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantL.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantL.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantL.Location = New System.Drawing.Point(699, 99)
        Me.chkVariantL.Name = "chkVariantL"
        Me.chkVariantL.Size = New System.Drawing.Size(33, 17)
        Me.chkVariantL.TabIndex = 129
        Me.chkVariantL.Text = "L"
        Me.chkVariantL.UseVisualStyleBackColor = True
        '
        'chkVariantDRT
        '
        Me.chkVariantDRT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantDRT.AutoCheck = False
        Me.chkVariantDRT.AutoSize = True
        Me.chkVariantDRT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantDRT.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantDRT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantDRT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantDRT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantDRT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantDRT.Location = New System.Drawing.Point(625, 99)
        Me.chkVariantDRT.Name = "chkVariantDRT"
        Me.chkVariantDRT.Size = New System.Drawing.Size(52, 17)
        Me.chkVariantDRT.TabIndex = 128
        Me.chkVariantDRT.Text = "DRT"
        Me.chkVariantDRT.UseVisualStyleBackColor = True
        '
        'chkVariantB
        '
        Me.chkVariantB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantB.AutoCheck = False
        Me.chkVariantB.AutoSize = True
        Me.chkVariantB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantB.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantB.Location = New System.Drawing.Point(566, 129)
        Me.chkVariantB.Name = "chkVariantB"
        Me.chkVariantB.Size = New System.Drawing.Size(34, 17)
        Me.chkVariantB.TabIndex = 127
        Me.chkVariantB.Text = "B"
        Me.chkVariantB.UseVisualStyleBackColor = True
        '
        'chkVariantY
        '
        Me.chkVariantY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantY.AutoCheck = False
        Me.chkVariantY.AutoSize = True
        Me.chkVariantY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantY.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantY.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantY.Location = New System.Drawing.Point(507, 129)
        Me.chkVariantY.Name = "chkVariantY"
        Me.chkVariantY.Size = New System.Drawing.Size(34, 17)
        Me.chkVariantY.TabIndex = 126
        Me.chkVariantY.Text = "Y"
        Me.chkVariantY.UseVisualStyleBackColor = True
        '
        'chkVariantF
        '
        Me.chkVariantF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantF.AutoCheck = False
        Me.chkVariantF.AutoSize = True
        Me.chkVariantF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantF.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantF.Location = New System.Drawing.Point(566, 99)
        Me.chkVariantF.Name = "chkVariantF"
        Me.chkVariantF.Size = New System.Drawing.Size(33, 17)
        Me.chkVariantF.TabIndex = 125
        Me.chkVariantF.Text = "F"
        Me.chkVariantF.UseVisualStyleBackColor = True
        '
        'chkVariantD
        '
        Me.chkVariantD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVariantD.AutoCheck = False
        Me.chkVariantD.AutoSize = True
        Me.chkVariantD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkVariantD.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkVariantD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkVariantD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.chkVariantD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chkVariantD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVariantD.Location = New System.Drawing.Point(507, 99)
        Me.chkVariantD.Name = "chkVariantD"
        Me.chkVariantD.Size = New System.Drawing.Size(35, 17)
        Me.chkVariantD.TabIndex = 124
        Me.chkVariantD.Text = "D"
        Me.chkVariantD.UseVisualStyleBackColor = True
        '
        'chkStar
        '
        Me.chkStar.AutoSize = True
        Me.chkStar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStar.Location = New System.Drawing.Point(507, 64)
        Me.chkStar.Name = "chkStar"
        Me.chkStar.Size = New System.Drawing.Size(44, 35)
        Me.chkStar.TabIndex = 123
        Me.chkStar.Text = "*"
        Me.chkStar.UseVisualStyleBackColor = True
        '
        'cmbVersionEdit
        '
        Me.cmbVersionEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVersionEdit.FormattingEnabled = True
        Me.cmbVersionEdit.Items.AddRange(New Object() {"S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10"})
        Me.cmbVersionEdit.Location = New System.Drawing.Point(119, 71)
        Me.cmbVersionEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbVersionEdit.Name = "cmbVersionEdit"
        Me.cmbVersionEdit.Size = New System.Drawing.Size(187, 21)
        Me.cmbVersionEdit.TabIndex = 112
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"2K", "BC", "BC/2K", "LS"})
        Me.cmbType.Location = New System.Drawing.Point(119, 45)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(75, 21)
        Me.cmbType.TabIndex = 97
        '
        'lbFormulaId
        '
        Me.lbFormulaId.AutoSize = True
        Me.lbFormulaId.Location = New System.Drawing.Point(59, 22)
        Me.lbFormulaId.Name = "lbFormulaId"
        Me.lbFormulaId.Size = New System.Drawing.Size(18, 13)
        Me.lbFormulaId.TabIndex = 96
        Me.lbFormulaId.Text = "-1"
        Me.lbFormulaId.Visible = False
        '
        'lbCarId
        '
        Me.lbCarId.AutoSize = True
        Me.lbCarId.Location = New System.Drawing.Point(83, 22)
        Me.lbCarId.Name = "lbCarId"
        Me.lbCarId.Size = New System.Drawing.Size(18, 13)
        Me.lbCarId.TabIndex = 95
        Me.lbCarId.Text = "-1"
        Me.lbCarId.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Hue:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Base coat:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Car:"
        '
        'butValidateHidden
        '
        Me.butValidateHidden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butValidateHidden.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butValidateHidden.Location = New System.Drawing.Point(804, 591)
        Me.butValidateHidden.Name = "butValidateHidden"
        Me.butValidateHidden.Size = New System.Drawing.Size(125, 26)
        Me.butValidateHidden.TabIndex = 93
        Me.butValidateHidden.Text = "Validate"
        Me.butValidateHidden.UseVisualStyleBackColor = True
        Me.butValidateHidden.Visible = False
        '
        'edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 647)
        Me.Controls.Add(Me.grpEdit)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "edit"
        Me.Text = "edit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpEdit.ResumeLayout(False)
        Me.grpEdit.PerformLayout()
        Me.spltColor.Panel1.ResumeLayout(False)
        Me.spltColor.Panel1.PerformLayout()
        Me.spltColor.Panel2.ResumeLayout(False)
        Me.spltColor.Panel2.PerformLayout()
        Me.spltColor.ResumeLayout(False)
        CType(Me.pctColorDetailHidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEditFormula.ResumeLayout(False)
        Me.grpEditFormula.PerformLayout()
        CType(Me.pctFormulaColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCarImgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpEdit As System.Windows.Forms.GroupBox
    Friend WithEvents pctColorDetailHidden As System.Windows.Forms.PictureBox
    Friend WithEvents butDeleteHidden As System.Windows.Forms.Button
    Friend WithEvents grpEditFormula As System.Windows.Forms.GroupBox
    Friend WithEvents pctFormulaColor As System.Windows.Forms.PictureBox
    Friend WithEvents pctCarImgDetails As System.Windows.Forms.PictureBox
    Friend WithEvents cmbCarNameModelEdit As System.Windows.Forms.ComboBox
    Friend WithEvents chkVariantCL As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantR As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantG As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantCO As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantL As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantDRT As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantB As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantY As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantF As System.Windows.Forms.CheckBox
    Friend WithEvents chkVariantD As System.Windows.Forms.CheckBox
    Friend WithEvents chkStar As System.Windows.Forms.CheckBox
    Friend WithEvents cmbVersionEdit As System.Windows.Forms.ComboBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lbFormulaId As System.Windows.Forms.Label
    Friend WithEvents lbCarId As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butAddHidden As System.Windows.Forms.Button
    Friend WithEvents butValidateHidden As System.Windows.Forms.Button
    Friend WithEvents txtQuantityDetailHidden As HeadQApplication.MyTextBox
    Friend WithEvents txtColorsDetailHidden As HeadQApplication.MyTextBox
    Friend WithEvents lbColorDetails As System.Windows.Forms.Label
    Friend WithEvents lbQuantity As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtYearMax As HeadQApplication.MyTextBox
    Friend WithEvents txtYearMin As HeadQApplication.MyTextBox
    Friend WithEvents spltColor As System.Windows.Forms.SplitContainer
    Friend WithEvents butExit As System.Windows.Forms.Button
    Friend WithEvents chkApplyEquation As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTipVariant As System.Windows.Forms.ToolTip
    Friend WithEvents txtFormulaCode As HeadQApplication.MyTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCardNumber As HeadQApplication.MyTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents butClear As System.Windows.Forms.Button
    Friend WithEvents lbVariants As System.Windows.Forms.Label
    Friend WithEvents butAddCar As System.Windows.Forms.Button
    Friend WithEvents lbEquation As System.Windows.Forms.Label
    Friend WithEvents chkEquation15perc4201 As System.Windows.Forms.CheckBox
    Friend WithEvents txtLSConv As HeadQApplication.MyTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkClearLs As System.Windows.Forms.CheckBox
    Friend WithEvents chkMajdi As System.Windows.Forms.CheckBox
    Friend WithEvents chkMajdi4conv As System.Windows.Forms.CheckBox
    Friend WithEvents txtModDate As HeadQApplication.MyTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkEquation4201_180 As System.Windows.Forms.CheckBox
    Friend WithEvents lbMultiplyBy As System.Windows.Forms.Label
    Friend WithEvents butMultiply As System.Windows.Forms.Button
    Friend WithEvents lbAsteriks As System.Windows.Forms.Label
End Class
