<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeadQHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeadQHome))
        Me.tbTabs = New System.Windows.Forms.TabControl()
        Me.tbFormulas = New System.Windows.Forms.TabPage()
        Me.grpFormulas = New System.Windows.Forms.GroupBox()
        Me.butNegativeQty = New System.Windows.Forms.Button()
        Me.lbAttention = New System.Windows.Forms.Label()
        Me.txtBasicColor = New HeadQApplication.MyTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.butExcel = New System.Windows.Forms.Button()
        Me.lbCountFormulas = New System.Windows.Forms.Label()
        Me.butClear = New System.Windows.Forms.Button()
        Me.butDelete = New System.Windows.Forms.Button()
        Me.chkCardNumber = New System.Windows.Forms.CheckBox()
        Me.txtCardNumber = New HeadQApplication.MyTextBox()
        Me.lbCardNumber = New System.Windows.Forms.Label()
        Me.grpXY = New System.Windows.Forms.GroupBox()
        Me.butAssignZ2p = New System.Windows.Forms.Button()
        Me.butAssignZp = New System.Windows.Forms.Button()
        Me.butAssignY2p = New System.Windows.Forms.Button()
        Me.butAssignYp = New System.Windows.Forms.Button()
        Me.butAssignX2p = New System.Windows.Forms.Button()
        Me.butAssignXp = New System.Windows.Forms.Button()
        Me.butCancelZ = New System.Windows.Forms.Button()
        Me.butAssignZ = New System.Windows.Forms.Button()
        Me.lbformulaZ = New System.Windows.Forms.Label()
        Me.butCancelAss = New System.Windows.Forms.Button()
        Me.butCancelY = New System.Windows.Forms.Button()
        Me.butCancelX = New System.Windows.Forms.Button()
        Me.lbSelectedXYZ = New System.Windows.Forms.Label()
        Me.butSaveAssign = New System.Windows.Forms.Button()
        Me.butAssignY = New System.Windows.Forms.Button()
        Me.butAssignX = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtYearSpec = New HeadQApplication.MyTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtYearMax = New HeadQApplication.MyTextBox()
        Me.txtYearMin = New HeadQApplication.MyTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdLS = New System.Windows.Forms.RadioButton()
        Me.rdAny = New System.Windows.Forms.RadioButton()
        Me.rdBC = New System.Windows.Forms.RadioButton()
        Me.rd2k = New System.Windows.Forms.RadioButton()
        Me.cmbCarNameSearch = New System.Windows.Forms.ComboBox()
        Me.lbCarIdSearch = New System.Windows.Forms.Label()
        Me.butEditColor = New System.Windows.Forms.Button()
        Me.lsvFamily = New HeadQApplication.MyListView()
        Me.cformulaId = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cctype = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ccarname = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ccode = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ccname = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cmodcredate = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cyear = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cversion = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ccardNbr = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chkColorCode = New System.Windows.Forms.CheckBox()
        Me.txtColorCode = New HeadQApplication.MyTextBox()
        Me.lbColorCode = New System.Windows.Forms.Label()
        Me.butAddNewFormula = New System.Windows.Forms.Button()
        Me.lbCurrencyDetailsValue = New System.Windows.Forms.Label()
        Me.lbCurrencyDetails = New System.Windows.Forms.Label()
        Me.chkFormulaName = New System.Windows.Forms.CheckBox()
        Me.txtFormulaName = New HeadQApplication.MyTextBox()
        Me.lbFormulaName = New System.Windows.Forms.Label()
        Me.butGo = New System.Windows.Forms.Button()
        Me.tbCars = New System.Windows.Forms.TabPage()
        Me.grpCars = New System.Windows.Forms.GroupBox()
        Me.butClearCars = New System.Windows.Forms.Button()
        Me.cclCar = New System.Windows.Forms.Button()
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
        Me.lsvCars = New HeadQApplication.MyListView()
        Me.cidcar = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.butSearchCarForm = New System.Windows.Forms.Button()
        Me.tbLanguage = New System.Windows.Forms.TabPage()
        Me.grpLanguageForm = New System.Windows.Forms.GroupBox()
        Me.butClearLang = New System.Windows.Forms.Button()
        Me.butDeleteLangForm = New System.Windows.Forms.Button()
        Me.lbIdLanguageForm = New System.Windows.Forms.Label()
        Me.butEditLangForm = New System.Windows.Forms.Button()
        Me.chkLanguageLabelForm = New System.Windows.Forms.CheckBox()
        Me.txtLanguageLabelForm = New HeadQApplication.MyTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.butAddLang = New System.Windows.Forms.Button()
        Me.chkLanguageFormCode = New System.Windows.Forms.CheckBox()
        Me.txtLanguageCodeForm = New HeadQApplication.MyTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lsvLanguage = New HeadQApplication.MyListView()
        Me.cidLang = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.butSearchLangForm = New System.Windows.Forms.Button()
        Me.tbGarages = New System.Windows.Forms.TabPage()
        Me.grpGarageForm = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbHqConversionProgress = New System.Windows.Forms.Label()
        Me.butBrowseHqDirectory = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtHqDirectory = New HeadQApplication.MyTextBox()
        Me.butConvertToHQ = New System.Windows.Forms.Button()
        Me.chkUsername = New System.Windows.Forms.CheckBox()
        Me.txtusername = New HeadQApplication.MyTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdShowAltNone = New System.Windows.Forms.RadioButton()
        Me.rdShowAlternative = New System.Windows.Forms.RadioButton()
        Me.rdShowAlternative2 = New System.Windows.Forms.RadioButton()
        Me.pctThemeColor = New System.Windows.Forms.PictureBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.butBrowseDb = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtDBDirectory = New HeadQApplication.MyTextBox()
        Me.butInstallMobile = New System.Windows.Forms.Button()
        Me.chkkey = New System.Windows.Forms.CheckBox()
        Me.txtkey = New HeadQApplication.MyTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.chktel = New System.Windows.Forms.CheckBox()
        Me.txttel = New HeadQApplication.MyTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdGarage2k = New System.Windows.Forms.RadioButton()
        Me.rdGarageLS = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.chkversion = New System.Windows.Forms.CheckBox()
        Me.txtversion = New HeadQApplication.MyTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.grpradio = New System.Windows.Forms.GroupBox()
        Me.rdApply0 = New System.Windows.Forms.RadioButton()
        Me.butClearGarage = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.butFindGarageImg = New System.Windows.Forms.Button()
        Me.txtGarageImgPath = New HeadQApplication.MyTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtfnamegaragehidden = New HeadQApplication.MyTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pctGarageImg = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.butBrowse = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGarageDirectory = New HeadQApplication.MyTextBox()
        Me.butInstall = New System.Windows.Forms.Button()
        Me.butFindLang = New System.Windows.Forms.Button()
        Me.lbIdLanguage = New System.Windows.Forms.Label()
        Me.txtLanguage = New HeadQApplication.MyTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkGarageRespForm = New System.Windows.Forms.CheckBox()
        Me.txtGarageRespform = New HeadQApplication.MyTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.butDeleteGarageForm = New System.Windows.Forms.Button()
        Me.lbIdGarageForm = New System.Windows.Forms.Label()
        Me.butEditGarageForm = New System.Windows.Forms.Button()
        Me.chkGarageLocationForm = New System.Windows.Forms.CheckBox()
        Me.txtGarageLocationForm = New HeadQApplication.MyTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.butAddGarage = New System.Windows.Forms.Button()
        Me.chkGarageFormCode = New System.Windows.Forms.CheckBox()
        Me.txtGarageNameForm = New HeadQApplication.MyTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lsvGarage = New HeadQApplication.MyListView()
        Me.cidGarage = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cidlanggarage = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cappequation = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cgversion = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cgcoat = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.butSearchGarageForm = New System.Windows.Forms.Button()
        Me.tbColors = New System.Windows.Forms.TabPage()
        Me.grpBColors = New System.Windows.Forms.GroupBox()
        Me.chkBColorFormNameAlt2 = New System.Windows.Forms.CheckBox()
        Me.txtBColorNameFormAlt2 = New HeadQApplication.MyTextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.pctBColorRGB = New System.Windows.Forms.PictureBox()
        Me.txtMasseVolumiqueExt = New HeadQApplication.MyTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.chkBColorFormNameAlt = New System.Windows.Forms.CheckBox()
        Me.txtBColorNameFormAlt = New HeadQApplication.MyTextBox()
        Me.lbBColorNameFormAlt = New System.Windows.Forms.Label()
        Me.butReportAll = New System.Windows.Forms.Button()
        Me.butClearBColor = New System.Windows.Forms.Button()
        Me.txtMasseVolumique = New HeadQApplication.MyTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkBColorFormCode = New System.Windows.Forms.CheckBox()
        Me.txtBColorCodeForm = New HeadQApplication.MyTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtfnamehideenColor = New HeadQApplication.MyTextBox()
        Me.butFindBColorImg = New System.Windows.Forms.Button()
        Me.txtBColorImgPath = New HeadQApplication.MyTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pctBColorImg = New System.Windows.Forms.PictureBox()
        Me.txtPriceBcolorForm = New HeadQApplication.MyTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbCurrencyDetailsValue2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.butDeleteBColorForm = New System.Windows.Forms.Button()
        Me.lbIdBColorForm = New System.Windows.Forms.Label()
        Me.butEditBColorForm = New System.Windows.Forms.Button()
        Me.butAddBColor = New System.Windows.Forms.Button()
        Me.chkBColorFormName = New System.Windows.Forms.CheckBox()
        Me.txtBColorNameForm = New HeadQApplication.MyTextBox()
        Me.lbBColorNameForm = New System.Windows.Forms.Label()
        Me.lsvBColors = New HeadQApplication.MyListView()
        Me.cidBColor = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.butSearchBColorForm = New System.Windows.Forms.Button()
        Me.tbUpdate = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.butClearUpdate = New System.Windows.Forms.Button()
        Me.butBrowseUpdate = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUpdatePath = New HeadQApplication.MyTextBox()
        Me.butUpdateFile = New System.Windows.Forms.Button()
        Me.butExit = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MobileSyncToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FBrowserGarage = New System.Windows.Forms.FolderBrowserDialog()
        Me.FBrowserUpdate = New System.Windows.Forms.FolderBrowserDialog()
        Me.fileDialogCar = New System.Windows.Forms.OpenFileDialog()
        Me.fileDialogBColor = New System.Windows.Forms.OpenFileDialog()
        Me.fileDialogGarage = New System.Windows.Forms.OpenFileDialog()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.ToolTipVariant = New System.Windows.Forms.ToolTip(Me.components)
        Me.fldExcelDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.dlgBasicColorDialog = New System.Windows.Forms.ColorDialog()
        Me.rdApply1 = New System.Windows.Forms.RadioButton()
        Me.tbTabs.SuspendLayout
        Me.tbFormulas.SuspendLayout
        Me.grpFormulas.SuspendLayout
        Me.grpXY.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.tbCars.SuspendLayout
        Me.grpCars.SuspendLayout
        CType(Me.pctCarImg,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tbLanguage.SuspendLayout
        Me.grpLanguageForm.SuspendLayout
        Me.tbGarages.SuspendLayout
        Me.grpGarageForm.SuspendLayout
        Me.GroupBox7.SuspendLayout
        Me.GroupBox6.SuspendLayout
        CType(Me.pctThemeColor,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox5.SuspendLayout
        Me.GroupBox4.SuspendLayout
        Me.grpradio.SuspendLayout
        CType(Me.pctGarageImg,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.tbColors.SuspendLayout
        Me.grpBColors.SuspendLayout
        CType(Me.pctBColorRGB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pctBColorImg,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tbUpdate.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.MenuStrip2.SuspendLayout
        Me.SuspendLayout
        '
        'tbTabs
        '
        Me.tbTabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbTabs.Controls.Add(Me.tbFormulas)
        Me.tbTabs.Controls.Add(Me.tbCars)
        Me.tbTabs.Controls.Add(Me.tbLanguage)
        Me.tbTabs.Controls.Add(Me.tbGarages)
        Me.tbTabs.Controls.Add(Me.tbColors)
        Me.tbTabs.Controls.Add(Me.tbUpdate)
        Me.tbTabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbTabs.Location = New System.Drawing.Point(12, 27)
        Me.tbTabs.Name = "tbTabs"
        Me.tbTabs.SelectedIndex = 0
        Me.tbTabs.Size = New System.Drawing.Size(1195, 686)
        Me.tbTabs.TabIndex = 0
        '
        'tbFormulas
        '
        Me.tbFormulas.Controls.Add(Me.grpFormulas)
        Me.tbFormulas.Location = New System.Drawing.Point(4, 25)
        Me.tbFormulas.Name = "tbFormulas"
        Me.tbFormulas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFormulas.Size = New System.Drawing.Size(1187, 657)
        Me.tbFormulas.TabIndex = 0
        Me.tbFormulas.Text = "Formulas"
        Me.tbFormulas.UseVisualStyleBackColor = true
        '
        'grpFormulas
        '
        Me.grpFormulas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpFormulas.BackColor = System.Drawing.Color.Transparent
        Me.grpFormulas.Controls.Add(Me.butNegativeQty)
        Me.grpFormulas.Controls.Add(Me.lbAttention)
        Me.grpFormulas.Controls.Add(Me.txtBasicColor)
        Me.grpFormulas.Controls.Add(Me.Label26)
        Me.grpFormulas.Controls.Add(Me.butExcel)
        Me.grpFormulas.Controls.Add(Me.lbCountFormulas)
        Me.grpFormulas.Controls.Add(Me.butClear)
        Me.grpFormulas.Controls.Add(Me.butDelete)
        Me.grpFormulas.Controls.Add(Me.chkCardNumber)
        Me.grpFormulas.Controls.Add(Me.txtCardNumber)
        Me.grpFormulas.Controls.Add(Me.lbCardNumber)
        Me.grpFormulas.Controls.Add(Me.grpXY)
        Me.grpFormulas.Controls.Add(Me.txtYearSpec)
        Me.grpFormulas.Controls.Add(Me.Label15)
        Me.grpFormulas.Controls.Add(Me.Label3)
        Me.grpFormulas.Controls.Add(Me.txtYearMax)
        Me.grpFormulas.Controls.Add(Me.txtYearMin)
        Me.grpFormulas.Controls.Add(Me.Label1)
        Me.grpFormulas.Controls.Add(Me.GroupBox1)
        Me.grpFormulas.Controls.Add(Me.cmbCarNameSearch)
        Me.grpFormulas.Controls.Add(Me.lbCarIdSearch)
        Me.grpFormulas.Controls.Add(Me.butEditColor)
        Me.grpFormulas.Controls.Add(Me.lsvFamily)
        Me.grpFormulas.Controls.Add(Me.Label23)
        Me.grpFormulas.Controls.Add(Me.chkColorCode)
        Me.grpFormulas.Controls.Add(Me.txtColorCode)
        Me.grpFormulas.Controls.Add(Me.lbColorCode)
        Me.grpFormulas.Controls.Add(Me.butAddNewFormula)
        Me.grpFormulas.Controls.Add(Me.lbCurrencyDetailsValue)
        Me.grpFormulas.Controls.Add(Me.lbCurrencyDetails)
        Me.grpFormulas.Controls.Add(Me.chkFormulaName)
        Me.grpFormulas.Controls.Add(Me.txtFormulaName)
        Me.grpFormulas.Controls.Add(Me.lbFormulaName)
        Me.grpFormulas.Controls.Add(Me.butGo)
        Me.grpFormulas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpFormulas.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpFormulas.Location = New System.Drawing.Point(6, 6)
        Me.grpFormulas.Name = "grpFormulas"
        Me.grpFormulas.Size = New System.Drawing.Size(1175, 645)
        Me.grpFormulas.TabIndex = 63
        Me.grpFormulas.TabStop = false
        Me.grpFormulas.Text = "Formulas"
        '
        'butNegativeQty
        '
        Me.butNegativeQty.BackColor = System.Drawing.SystemColors.Control
        Me.butNegativeQty.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butNegativeQty.ForeColor = System.Drawing.Color.Red
        Me.butNegativeQty.Location = New System.Drawing.Point(526, 100)
        Me.butNegativeQty.Name = "butNegativeQty"
        Me.butNegativeQty.Size = New System.Drawing.Size(84, 44)
        Me.butNegativeQty.TabIndex = 157
        Me.butNegativeQty.Text = "Negative quantity"
        Me.butNegativeQty.UseVisualStyleBackColor = false
        '
        'lbAttention
        '
        Me.lbAttention.AutoSize = true
        Me.lbAttention.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbAttention.ForeColor = System.Drawing.Color.Red
        Me.lbAttention.Location = New System.Drawing.Point(523, 159)
        Me.lbAttention.Name = "lbAttention"
        Me.lbAttention.Size = New System.Drawing.Size(87, 45)
        Me.lbAttention.TabIndex = 155
        Me.lbAttention.Text = "Attention!"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Linked to a"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"multicolored"
        Me.lbAttention.Visible = false
        '
        'txtBasicColor
        '
        Me.txtBasicColor.Location = New System.Drawing.Point(420, 165)
        Me.txtBasicColor.Name = "txtBasicColor"
        Me.txtBasicColor.Size = New System.Drawing.Size(97, 23)
        Me.txtBasicColor.TabIndex = 153
        '
        'Label26
        '
        Me.Label26.AutoSize = true
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(324, 165)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 15)
        Me.Label26.TabIndex = 154
        Me.Label26.Text = "Basic Color:"
        '
        'butExcel
        '
        Me.butExcel.BackColor = System.Drawing.SystemColors.Control
        Me.butExcel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.butExcel.Location = New System.Drawing.Point(528, 212)
        Me.butExcel.Name = "butExcel"
        Me.butExcel.Size = New System.Drawing.Size(84, 26)
        Me.butExcel.TabIndex = 152
        Me.butExcel.Text = "Excel"
        Me.butExcel.UseVisualStyleBackColor = false
        '
        'lbCountFormulas
        '
        Me.lbCountFormulas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbCountFormulas.AutoSize = true
        Me.lbCountFormulas.Location = New System.Drawing.Point(1069, 227)
        Me.lbCountFormulas.Name = "lbCountFormulas"
        Me.lbCountFormulas.Size = New System.Drawing.Size(32, 17)
        Me.lbCountFormulas.TabIndex = 151
        Me.lbCountFormulas.Text = "nbr"
        '
        'butClear
        '
        Me.butClear.BackColor = System.Drawing.SystemColors.Control
        Me.butClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClear.Location = New System.Drawing.Point(400, 98)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(113, 48)
        Me.butClear.TabIndex = 150
        Me.butClear.Text = "Clear"
        Me.butClear.UseVisualStyleBackColor = false
        '
        'butDelete
        '
        Me.butDelete.BackColor = System.Drawing.SystemColors.Control
        Me.butDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butDelete.Location = New System.Drawing.Point(420, 212)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(84, 26)
        Me.butDelete.TabIndex = 149
        Me.butDelete.Text = "Delete"
        Me.butDelete.UseVisualStyleBackColor = false
        '
        'chkCardNumber
        '
        Me.chkCardNumber.AutoSize = true
        Me.chkCardNumber.Checked = true
        Me.chkCardNumber.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCardNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCardNumber.Location = New System.Drawing.Point(319, 132)
        Me.chkCardNumber.Name = "chkCardNumber"
        Me.chkCardNumber.Size = New System.Drawing.Size(75, 17)
        Me.chkCardNumber.TabIndex = 148
        Me.chkCardNumber.Text = "Contains"
        Me.chkCardNumber.UseVisualStyleBackColor = true
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(126, 130)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(187, 23)
        Me.txtCardNumber.TabIndex = 146
        '
        'lbCardNumber
        '
        Me.lbCardNumber.AutoSize = true
        Me.lbCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbCardNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCardNumber.Location = New System.Drawing.Point(16, 130)
        Me.lbCardNumber.Name = "lbCardNumber"
        Me.lbCardNumber.Size = New System.Drawing.Size(94, 15)
        Me.lbCardNumber.TabIndex = 147
        Me.lbCardNumber.Text = "Card number:"
        '
        'grpXY
        '
        Me.grpXY.Controls.Add(Me.butAssignZ2p)
        Me.grpXY.Controls.Add(Me.butAssignZp)
        Me.grpXY.Controls.Add(Me.butAssignY2p)
        Me.grpXY.Controls.Add(Me.butAssignYp)
        Me.grpXY.Controls.Add(Me.butAssignX2p)
        Me.grpXY.Controls.Add(Me.butAssignXp)
        Me.grpXY.Controls.Add(Me.butCancelZ)
        Me.grpXY.Controls.Add(Me.butAssignZ)
        Me.grpXY.Controls.Add(Me.lbformulaZ)
        Me.grpXY.Controls.Add(Me.butCancelAss)
        Me.grpXY.Controls.Add(Me.butCancelY)
        Me.grpXY.Controls.Add(Me.butCancelX)
        Me.grpXY.Controls.Add(Me.lbSelectedXYZ)
        Me.grpXY.Controls.Add(Me.butSaveAssign)
        Me.grpXY.Controls.Add(Me.butAssignY)
        Me.grpXY.Controls.Add(Me.butAssignX)
        Me.grpXY.Controls.Add(Me.Label24)
        Me.grpXY.Controls.Add(Me.Label22)
        Me.grpXY.Location = New System.Drawing.Point(618, 16)
        Me.grpXY.Name = "grpXY"
        Me.grpXY.Size = New System.Drawing.Size(445, 225)
        Me.grpXY.TabIndex = 145
        Me.grpXY.TabStop = false
        Me.grpXY.Text = "X + Y + Z"
        Me.grpXY.Visible = false
        '
        'butAssignZ2p
        '
        Me.butAssignZ2p.Location = New System.Drawing.Point(256, 169)
        Me.butAssignZ2p.Name = "butAssignZ2p"
        Me.butAssignZ2p.Size = New System.Drawing.Size(150, 23)
        Me.butAssignZ2p.TabIndex = 17
        Me.butAssignZ2p.Text = "Z''"
        Me.butAssignZ2p.UseVisualStyleBackColor = true
        '
        'butAssignZp
        '
        Me.butAssignZp.Location = New System.Drawing.Point(99, 169)
        Me.butAssignZp.Name = "butAssignZp"
        Me.butAssignZp.Size = New System.Drawing.Size(150, 23)
        Me.butAssignZp.TabIndex = 16
        Me.butAssignZp.Text = "Z'"
        Me.butAssignZp.UseVisualStyleBackColor = true
        '
        'butAssignY2p
        '
        Me.butAssignY2p.Location = New System.Drawing.Point(256, 110)
        Me.butAssignY2p.Name = "butAssignY2p"
        Me.butAssignY2p.Size = New System.Drawing.Size(150, 23)
        Me.butAssignY2p.TabIndex = 15
        Me.butAssignY2p.Text = "Y''"
        Me.butAssignY2p.UseVisualStyleBackColor = true
        '
        'butAssignYp
        '
        Me.butAssignYp.Location = New System.Drawing.Point(99, 110)
        Me.butAssignYp.Name = "butAssignYp"
        Me.butAssignYp.Size = New System.Drawing.Size(150, 23)
        Me.butAssignYp.TabIndex = 14
        Me.butAssignYp.Text = "Y'"
        Me.butAssignYp.UseVisualStyleBackColor = true
        '
        'butAssignX2p
        '
        Me.butAssignX2p.Location = New System.Drawing.Point(256, 48)
        Me.butAssignX2p.Name = "butAssignX2p"
        Me.butAssignX2p.Size = New System.Drawing.Size(150, 23)
        Me.butAssignX2p.TabIndex = 13
        Me.butAssignX2p.Text = "X''"
        Me.butAssignX2p.UseVisualStyleBackColor = true
        '
        'butAssignXp
        '
        Me.butAssignXp.Location = New System.Drawing.Point(99, 48)
        Me.butAssignXp.Name = "butAssignXp"
        Me.butAssignXp.Size = New System.Drawing.Size(150, 23)
        Me.butAssignXp.TabIndex = 12
        Me.butAssignXp.Text = "X'"
        Me.butAssignXp.UseVisualStyleBackColor = true
        '
        'butCancelZ
        '
        Me.butCancelZ.Location = New System.Drawing.Point(256, 143)
        Me.butCancelZ.Name = "butCancelZ"
        Me.butCancelZ.Size = New System.Drawing.Size(150, 23)
        Me.butCancelZ.TabIndex = 11
        Me.butCancelZ.Text = "Cancel"
        Me.butCancelZ.UseVisualStyleBackColor = true
        '
        'butAssignZ
        '
        Me.butAssignZ.Location = New System.Drawing.Point(99, 143)
        Me.butAssignZ.Name = "butAssignZ"
        Me.butAssignZ.Size = New System.Drawing.Size(150, 23)
        Me.butAssignZ.TabIndex = 10
        Me.butAssignZ.Text = "Z"
        Me.butAssignZ.UseVisualStyleBackColor = true
        '
        'lbformulaZ
        '
        Me.lbformulaZ.AutoSize = true
        Me.lbformulaZ.Location = New System.Drawing.Point(9, 146)
        Me.lbformulaZ.Name = "lbformulaZ"
        Me.lbformulaZ.Size = New System.Drawing.Size(86, 17)
        Me.lbformulaZ.TabIndex = 9
        Me.lbformulaZ.Text = "Formula Z:"
        '
        'butCancelAss
        '
        Me.butCancelAss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butCancelAss.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butCancelAss.Location = New System.Drawing.Point(410, 16)
        Me.butCancelAss.Name = "butCancelAss"
        Me.butCancelAss.Size = New System.Drawing.Size(29, 27)
        Me.butCancelAss.TabIndex = 8
        Me.butCancelAss.Text = "X"
        Me.butCancelAss.UseVisualStyleBackColor = true
        '
        'butCancelY
        '
        Me.butCancelY.Location = New System.Drawing.Point(256, 85)
        Me.butCancelY.Name = "butCancelY"
        Me.butCancelY.Size = New System.Drawing.Size(150, 23)
        Me.butCancelY.TabIndex = 7
        Me.butCancelY.Text = "Cancel"
        Me.butCancelY.UseVisualStyleBackColor = true
        '
        'butCancelX
        '
        Me.butCancelX.Location = New System.Drawing.Point(256, 23)
        Me.butCancelX.Name = "butCancelX"
        Me.butCancelX.Size = New System.Drawing.Size(150, 23)
        Me.butCancelX.TabIndex = 6
        Me.butCancelX.Text = "Cancel"
        Me.butCancelX.UseVisualStyleBackColor = true
        '
        'lbSelectedXYZ
        '
        Me.lbSelectedXYZ.AutoSize = true
        Me.lbSelectedXYZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSelectedXYZ.Location = New System.Drawing.Point(106, 195)
        Me.lbSelectedXYZ.Name = "lbSelectedXYZ"
        Me.lbSelectedXYZ.Size = New System.Drawing.Size(2, 19)
        Me.lbSelectedXYZ.TabIndex = 5
        '
        'butSaveAssign
        '
        Me.butSaveAssign.Location = New System.Drawing.Point(20, 195)
        Me.butSaveAssign.Name = "butSaveAssign"
        Me.butSaveAssign.Size = New System.Drawing.Size(75, 23)
        Me.butSaveAssign.TabIndex = 4
        Me.butSaveAssign.Text = "Save"
        Me.butSaveAssign.UseVisualStyleBackColor = true
        '
        'butAssignY
        '
        Me.butAssignY.Location = New System.Drawing.Point(99, 85)
        Me.butAssignY.Name = "butAssignY"
        Me.butAssignY.Size = New System.Drawing.Size(150, 23)
        Me.butAssignY.TabIndex = 3
        Me.butAssignY.Text = "Y"
        Me.butAssignY.UseVisualStyleBackColor = true
        '
        'butAssignX
        '
        Me.butAssignX.Location = New System.Drawing.Point(99, 23)
        Me.butAssignX.Name = "butAssignX"
        Me.butAssignX.Size = New System.Drawing.Size(150, 23)
        Me.butAssignX.TabIndex = 2
        Me.butAssignX.Text = "X"
        Me.butAssignX.UseVisualStyleBackColor = true
        '
        'Label24
        '
        Me.Label24.AutoSize = true
        Me.Label24.Location = New System.Drawing.Point(9, 88)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 17)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Formula Y:"
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Location = New System.Drawing.Point(9, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 17)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Formula X:"
        '
        'txtYearSpec
        '
        Me.txtYearSpec.Location = New System.Drawing.Point(126, 165)
        Me.txtYearSpec.MaxLength = 11
        Me.txtYearSpec.Name = "txtYearSpec"
        Me.txtYearSpec.Size = New System.Drawing.Size(187, 23)
        Me.txtYearSpec.TabIndex = 144
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(525, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 17)
        Me.Label15.TabIndex = 143
        Me.Label15.Text = "Specific:"
        Me.Label15.Visible = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(579, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 17)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "-"
        Me.Label3.Visible = false
        '
        'txtYearMax
        '
        Me.txtYearMax.Location = New System.Drawing.Point(528, 39)
        Me.txtYearMax.MaxLength = 5
        Me.txtYearMax.Name = "txtYearMax"
        Me.txtYearMax.Size = New System.Drawing.Size(45, 23)
        Me.txtYearMax.TabIndex = 3
        Me.txtYearMax.Visible = false
        '
        'txtYearMin
        '
        Me.txtYearMin.Location = New System.Drawing.Point(528, 71)
        Me.txtYearMin.MaxLength = 5
        Me.txtYearMin.Name = "txtYearMin"
        Me.txtYearMin.Size = New System.Drawing.Size(45, 23)
        Me.txtYearMin.TabIndex = 2
        Me.txtYearMin.Visible = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Year:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdLS)
        Me.GroupBox1.Controls.Add(Me.rdAny)
        Me.GroupBox1.Controls.Add(Me.rdBC)
        Me.GroupBox1.Controls.Add(Me.rd2k)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 35)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = false
        '
        'rdLS
        '
        Me.rdLS.AutoSize = true
        Me.rdLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdLS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdLS.Location = New System.Drawing.Point(92, 12)
        Me.rdLS.Name = "rdLS"
        Me.rdLS.Size = New System.Drawing.Size(40, 17)
        Me.rdLS.TabIndex = 81
        Me.rdLS.Text = "LS"
        Me.rdLS.UseVisualStyleBackColor = true
        '
        'rdAny
        '
        Me.rdAny.AutoSize = true
        Me.rdAny.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdAny.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdAny.Location = New System.Drawing.Point(151, 11)
        Me.rdAny.Name = "rdAny"
        Me.rdAny.Size = New System.Drawing.Size(46, 17)
        Me.rdAny.TabIndex = 80
        Me.rdAny.Text = "Any"
        Me.rdAny.UseVisualStyleBackColor = true
        '
        'rdBC
        '
        Me.rdBC.AutoSize = true
        Me.rdBC.Checked = true
        Me.rdBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdBC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdBC.Location = New System.Drawing.Point(45, 12)
        Me.rdBC.Name = "rdBC"
        Me.rdBC.Size = New System.Drawing.Size(41, 17)
        Me.rdBC.TabIndex = 79
        Me.rdBC.TabStop = true
        Me.rdBC.Text = "BC"
        Me.rdBC.UseVisualStyleBackColor = true
        '
        'rd2k
        '
        Me.rd2k.AutoSize = true
        Me.rd2k.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rd2k.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rd2k.Location = New System.Drawing.Point(4, 11)
        Me.rd2k.Name = "rd2k"
        Me.rd2k.Size = New System.Drawing.Size(40, 17)
        Me.rd2k.TabIndex = 78
        Me.rd2k.Text = "2K"
        Me.rd2k.UseVisualStyleBackColor = true
        '
        'cmbCarNameSearch
        '
        Me.cmbCarNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarNameSearch.FormattingEnabled = true
        Me.cmbCarNameSearch.Location = New System.Drawing.Point(126, 16)
        Me.cmbCarNameSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCarNameSearch.Name = "cmbCarNameSearch"
        Me.cmbCarNameSearch.Size = New System.Drawing.Size(187, 24)
        Me.cmbCarNameSearch.TabIndex = 4
        '
        'lbCarIdSearch
        '
        Me.lbCarIdSearch.AutoSize = true
        Me.lbCarIdSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarIdSearch.Location = New System.Drawing.Point(90, 22)
        Me.lbCarIdSearch.Name = "lbCarIdSearch"
        Me.lbCarIdSearch.Size = New System.Drawing.Size(23, 17)
        Me.lbCarIdSearch.TabIndex = 137
        Me.lbCarIdSearch.Text = "-1"
        Me.lbCarIdSearch.Visible = false
        '
        'butEditColor
        '
        Me.butEditColor.BackColor = System.Drawing.SystemColors.Control
        Me.butEditColor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butEditColor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butEditColor.Location = New System.Drawing.Point(239, 212)
        Me.butEditColor.Name = "butEditColor"
        Me.butEditColor.Size = New System.Drawing.Size(90, 26)
        Me.butEditColor.TabIndex = 111
        Me.butEditColor.Text = "Edit Color"
        Me.butEditColor.UseVisualStyleBackColor = false
        '
        'lsvFamily
        '
        Me.lsvFamily.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lsvFamily.BackColor = System.Drawing.Color.White
        Me.lsvFamily.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cformulaId, Me.cctype, Me.ccarname, Me.ccode, Me.ccname, Me.cmodcredate, Me.cyear, Me.cversion, Me.ccardNbr})
        Me.lsvFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lsvFamily.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lsvFamily.FullRowSelect = true
        Me.lsvFamily.GridLines = true
        Me.lsvFamily.HideSelection = false
        Me.lsvFamily.Location = New System.Drawing.Point(12, 247)
        Me.lsvFamily.Name = "lsvFamily"
        Me.lsvFamily.Size = New System.Drawing.Size(1153, 392)
        Me.lsvFamily.TabIndex = 55
        Me.lsvFamily.UseCompatibleStateImageBehavior = false
        Me.lsvFamily.View = System.Windows.Forms.View.Details
        '
        'cformulaId
        '
        Me.cformulaId.Tag = "cformulaId"
        Me.cformulaId.Text = "id"
        Me.cformulaId.Width = 0
        '
        'cctype
        '
        Me.cctype.Tag = "cctype"
        Me.cctype.Text = "Type"
        Me.cctype.Width = 59
        '
        'ccarname
        '
        Me.ccarname.Tag = "ccarname"
        Me.ccarname.Text = "Car"
        Me.ccarname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ccarname.Width = 117
        '
        'ccode
        '
        Me.ccode.Tag = "ccode"
        Me.ccode.Text = "Code"
        Me.ccode.Width = 86
        '
        'ccname
        '
        Me.ccname.Tag = "ccname"
        Me.ccname.Text = "Name"
        Me.ccname.Width = 119
        '
        'cmodcredate
        '
        Me.cmodcredate.Text = "Mod/Cre. Date"
        Me.cmodcredate.Width = 114
        '
        'cyear
        '
        Me.cyear.Tag = "cyear"
        Me.cyear.Text = "Year"
        Me.cyear.Width = 103
        '
        'cversion
        '
        Me.cversion.Tag = "cversion"
        Me.cversion.Text = "Hue"
        Me.cversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cversion.Width = 88
        '
        'ccardNbr
        '
        Me.ccardNbr.Tag = "ccardNbr"
        Me.ccardNbr.Text = "Card Number"
        Me.ccardNbr.Width = 105
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(19, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 17)
        Me.Label23.TabIndex = 136
        Me.Label23.Text = "Car:"
        '
        'chkColorCode
        '
        Me.chkColorCode.AutoSize = true
        Me.chkColorCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkColorCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkColorCode.Location = New System.Drawing.Point(319, 61)
        Me.chkColorCode.Name = "chkColorCode"
        Me.chkColorCode.Size = New System.Drawing.Size(75, 17)
        Me.chkColorCode.TabIndex = 110
        Me.chkColorCode.Text = "Contains"
        Me.chkColorCode.UseVisualStyleBackColor = true
        '
        'txtColorCode
        '
        Me.txtColorCode.Location = New System.Drawing.Point(126, 59)
        Me.txtColorCode.Name = "txtColorCode"
        Me.txtColorCode.Size = New System.Drawing.Size(187, 23)
        Me.txtColorCode.TabIndex = 0
        '
        'lbColorCode
        '
        Me.lbColorCode.AutoSize = true
        Me.lbColorCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbColorCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbColorCode.Location = New System.Drawing.Point(16, 59)
        Me.lbColorCode.Name = "lbColorCode"
        Me.lbColorCode.Size = New System.Drawing.Size(82, 15)
        Me.lbColorCode.TabIndex = 108
        Me.lbColorCode.Text = "Color Code:"
        '
        'butAddNewFormula
        '
        Me.butAddNewFormula.BackColor = System.Drawing.SystemColors.Control
        Me.butAddNewFormula.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butAddNewFormula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddNewFormula.Location = New System.Drawing.Point(335, 212)
        Me.butAddNewFormula.Name = "butAddNewFormula"
        Me.butAddNewFormula.Size = New System.Drawing.Size(79, 26)
        Me.butAddNewFormula.TabIndex = 107
        Me.butAddNewFormula.Text = "Add New"
        Me.butAddNewFormula.UseVisualStyleBackColor = false
        '
        'lbCurrencyDetailsValue
        '
        Me.lbCurrencyDetailsValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbCurrencyDetailsValue.AutoSize = true
        Me.lbCurrencyDetailsValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbCurrencyDetailsValue.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbCurrencyDetailsValue.Location = New System.Drawing.Point(1139, 25)
        Me.lbCurrencyDetailsValue.Name = "lbCurrencyDetailsValue"
        Me.lbCurrencyDetailsValue.Size = New System.Drawing.Size(21, 15)
        Me.lbCurrencyDetailsValue.TabIndex = 106
        Me.lbCurrencyDetailsValue.Text = "- -"
        '
        'lbCurrencyDetails
        '
        Me.lbCurrencyDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbCurrencyDetails.AutoSize = true
        Me.lbCurrencyDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbCurrencyDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCurrencyDetails.Location = New System.Drawing.Point(1069, 25)
        Me.lbCurrencyDetails.Name = "lbCurrencyDetails"
        Me.lbCurrencyDetails.Size = New System.Drawing.Size(67, 15)
        Me.lbCurrencyDetails.TabIndex = 105
        Me.lbCurrencyDetails.Text = "Currency:"
        '
        'chkFormulaName
        '
        Me.chkFormulaName.AutoSize = true
        Me.chkFormulaName.Checked = true
        Me.chkFormulaName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFormulaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkFormulaName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFormulaName.Location = New System.Drawing.Point(319, 97)
        Me.chkFormulaName.Name = "chkFormulaName"
        Me.chkFormulaName.Size = New System.Drawing.Size(75, 17)
        Me.chkFormulaName.TabIndex = 70
        Me.chkFormulaName.Text = "Contains"
        Me.chkFormulaName.UseVisualStyleBackColor = true
        '
        'txtFormulaName
        '
        Me.txtFormulaName.Location = New System.Drawing.Point(126, 95)
        Me.txtFormulaName.Name = "txtFormulaName"
        Me.txtFormulaName.Size = New System.Drawing.Size(187, 23)
        Me.txtFormulaName.TabIndex = 1
        '
        'lbFormulaName
        '
        Me.lbFormulaName.AutoSize = true
        Me.lbFormulaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbFormulaName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbFormulaName.Location = New System.Drawing.Point(16, 95)
        Me.lbFormulaName.Name = "lbFormulaName"
        Me.lbFormulaName.Size = New System.Drawing.Size(104, 15)
        Me.lbFormulaName.TabIndex = 68
        Me.lbFormulaName.Text = "Formula name:"
        '
        'butGo
        '
        Me.butGo.BackColor = System.Drawing.SystemColors.Control
        Me.butGo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butGo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butGo.Location = New System.Drawing.Point(400, 16)
        Me.butGo.Name = "butGo"
        Me.butGo.Size = New System.Drawing.Size(113, 78)
        Me.butGo.TabIndex = 9
        Me.butGo.Text = "Go"
        Me.butGo.UseVisualStyleBackColor = false
        '
        'tbCars
        '
        Me.tbCars.Controls.Add(Me.grpCars)
        Me.tbCars.Location = New System.Drawing.Point(4, 25)
        Me.tbCars.Name = "tbCars"
        Me.tbCars.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCars.Size = New System.Drawing.Size(1187, 657)
        Me.tbCars.TabIndex = 1
        Me.tbCars.Text = "Cars"
        Me.tbCars.UseVisualStyleBackColor = true
        '
        'grpCars
        '
        Me.grpCars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpCars.BackColor = System.Drawing.Color.Transparent
        Me.grpCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpCars.Controls.Add(Me.butClearCars)
        Me.grpCars.Controls.Add(Me.cclCar)
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
        Me.grpCars.Controls.Add(Me.lsvCars)
        Me.grpCars.Controls.Add(Me.butSearchCarForm)
        Me.grpCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpCars.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpCars.Location = New System.Drawing.Point(20, 19)
        Me.grpCars.Name = "grpCars"
        Me.grpCars.Size = New System.Drawing.Size(1150, 630)
        Me.grpCars.TabIndex = 65
        Me.grpCars.TabStop = false
        Me.grpCars.Text = "Cars"
        '
        'butClearCars
        '
        Me.butClearCars.BackColor = System.Drawing.SystemColors.Control
        Me.butClearCars.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butClearCars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClearCars.Location = New System.Drawing.Point(756, 104)
        Me.butClearCars.Name = "butClearCars"
        Me.butClearCars.Size = New System.Drawing.Size(113, 79)
        Me.butClearCars.TabIndex = 151
        Me.butClearCars.Text = "Clear"
        Me.butClearCars.UseVisualStyleBackColor = false
        '
        'cclCar
        '
        Me.cclCar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cclCar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cclCar.Location = New System.Drawing.Point(399, 104)
        Me.cclCar.Name = "cclCar"
        Me.cclCar.Size = New System.Drawing.Size(113, 79)
        Me.cclCar.TabIndex = 86
        Me.cclCar.Text = "Color Code Locator"
        Me.cclCar.UseVisualStyleBackColor = false
        '
        'txtfnamehideen
        '
        Me.txtfnamehideen.Location = New System.Drawing.Point(233, 90)
        Me.txtfnamehideen.Name = "txtfnamehideen"
        Me.txtfnamehideen.ReadOnly = true
        Me.txtfnamehideen.Size = New System.Drawing.Size(101, 23)
        Me.txtfnamehideen.TabIndex = 83
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(16, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Thumbnail:"
        '
        'pctCarImg
        '
        Me.pctCarImg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.pctCarImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctCarImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctCarImg.Location = New System.Drawing.Point(126, 87)
        Me.pctCarImg.Name = "pctCarImg"
        Me.pctCarImg.Size = New System.Drawing.Size(101, 72)
        Me.pctCarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCarImg.TabIndex = 81
        Me.pctCarImg.TabStop = false
        '
        'butFindCarImg
        '
        Me.butFindCarImg.BackColor = System.Drawing.SystemColors.Control
        Me.butFindCarImg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butFindCarImg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butFindCarImg.Location = New System.Drawing.Point(299, 58)
        Me.butFindCarImg.Name = "butFindCarImg"
        Me.butFindCarImg.Size = New System.Drawing.Size(35, 23)
        Me.butFindCarImg.TabIndex = 80
        Me.butFindCarImg.Text = " -- "
        Me.butFindCarImg.UseVisualStyleBackColor = false
        '
        'txtCarImgPath
        '
        Me.txtCarImgPath.Location = New System.Drawing.Point(126, 58)
        Me.txtCarImgPath.Name = "txtCarImgPath"
        Me.txtCarImgPath.ReadOnly = true
        Me.txtCarImgPath.Size = New System.Drawing.Size(161, 23)
        Me.txtCarImgPath.TabIndex = 79
        '
        'lbCarImgPath
        '
        Me.lbCarImgPath.AutoSize = true
        Me.lbCarImgPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        Me.butDeleteCarForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butDeleteCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butDeleteCarForm.Location = New System.Drawing.Point(637, 20)
        Me.butDeleteCarForm.Name = "butDeleteCarForm"
        Me.butDeleteCarForm.Size = New System.Drawing.Size(113, 78)
        Me.butDeleteCarForm.TabIndex = 77
        Me.butDeleteCarForm.Text = "Delete Selected"
        Me.butDeleteCarForm.UseVisualStyleBackColor = false
        '
        'lbIdCarForm
        '
        Me.lbIdCarForm.AutoSize = true
        Me.lbIdCarForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbIdCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdCarForm.Location = New System.Drawing.Point(16, 171)
        Me.lbIdCarForm.Name = "lbIdCarForm"
        Me.lbIdCarForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdCarForm.TabIndex = 76
        Me.lbIdCarForm.Text = "-1"
        Me.lbIdCarForm.Visible = false
        '
        'butEditCarForm
        '
        Me.butEditCarForm.BackColor = System.Drawing.SystemColors.Control
        Me.butEditCarForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butEditCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butEditCarForm.Location = New System.Drawing.Point(518, 20)
        Me.butEditCarForm.Name = "butEditCarForm"
        Me.butEditCarForm.Size = New System.Drawing.Size(113, 78)
        Me.butEditCarForm.TabIndex = 75
        Me.butEditCarForm.Text = "Edit Selected"
        Me.butEditCarForm.UseVisualStyleBackColor = false
        '
        'butAddCar
        '
        Me.butAddCar.BackColor = System.Drawing.SystemColors.Control
        Me.butAddCar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butAddCar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddCar.Location = New System.Drawing.Point(399, 20)
        Me.butAddCar.Name = "butAddCar"
        Me.butAddCar.Size = New System.Drawing.Size(113, 78)
        Me.butAddCar.TabIndex = 71
        Me.butAddCar.Text = "Add New"
        Me.butAddCar.UseVisualStyleBackColor = false
        '
        'chkCarFormName
        '
        Me.chkCarFormName.AutoSize = true
        Me.chkCarFormName.Checked = true
        Me.chkCarFormName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCarFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCarFormName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCarFormName.Location = New System.Drawing.Point(319, 27)
        Me.chkCarFormName.Name = "chkCarFormName"
        Me.chkCarFormName.Size = New System.Drawing.Size(75, 17)
        Me.chkCarFormName.TabIndex = 70
        Me.chkCarFormName.Text = "Contains"
        Me.chkCarFormName.UseVisualStyleBackColor = true
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
        Me.lbCarNameForm.AutoSize = true
        Me.lbCarNameForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbCarNameForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarNameForm.Location = New System.Drawing.Point(16, 25)
        Me.lbCarNameForm.Name = "lbCarNameForm"
        Me.lbCarNameForm.Size = New System.Drawing.Size(73, 15)
        Me.lbCarNameForm.TabIndex = 68
        Me.lbCarNameForm.Text = "Car name:"
        '
        'lsvCars
        '
        Me.lsvCars.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lsvCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidcar, Me.ColumnHeader1})
        Me.lsvCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lsvCars.FullRowSelect = true
        Me.lsvCars.GridLines = true
        Me.lsvCars.HideSelection = false
        Me.lsvCars.Location = New System.Drawing.Point(10, 181)
        Me.lsvCars.MultiSelect = false
        Me.lsvCars.Name = "lsvCars"
        Me.lsvCars.Size = New System.Drawing.Size(1134, 443)
        Me.lsvCars.TabIndex = 55
        Me.lsvCars.UseCompatibleStateImageBehavior = false
        Me.lsvCars.View = System.Windows.Forms.View.Details
        '
        'cidcar
        '
        Me.cidcar.Tag = "cidcar"
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
        Me.butSearchCarForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butSearchCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSearchCarForm.Location = New System.Drawing.Point(756, 20)
        Me.butSearchCarForm.Name = "butSearchCarForm"
        Me.butSearchCarForm.Size = New System.Drawing.Size(113, 78)
        Me.butSearchCarForm.TabIndex = 9
        Me.butSearchCarForm.Text = "Find"
        Me.butSearchCarForm.UseVisualStyleBackColor = false
        '
        'tbLanguage
        '
        Me.tbLanguage.Controls.Add(Me.grpLanguageForm)
        Me.tbLanguage.Location = New System.Drawing.Point(4, 25)
        Me.tbLanguage.Name = "tbLanguage"
        Me.tbLanguage.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLanguage.Size = New System.Drawing.Size(1187, 657)
        Me.tbLanguage.TabIndex = 2
        Me.tbLanguage.Text = "Languages"
        Me.tbLanguage.UseVisualStyleBackColor = true
        '
        'grpLanguageForm
        '
        Me.grpLanguageForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpLanguageForm.BackColor = System.Drawing.Color.Transparent
        Me.grpLanguageForm.Controls.Add(Me.butClearLang)
        Me.grpLanguageForm.Controls.Add(Me.butDeleteLangForm)
        Me.grpLanguageForm.Controls.Add(Me.lbIdLanguageForm)
        Me.grpLanguageForm.Controls.Add(Me.butEditLangForm)
        Me.grpLanguageForm.Controls.Add(Me.chkLanguageLabelForm)
        Me.grpLanguageForm.Controls.Add(Me.txtLanguageLabelForm)
        Me.grpLanguageForm.Controls.Add(Me.Label2)
        Me.grpLanguageForm.Controls.Add(Me.butAddLang)
        Me.grpLanguageForm.Controls.Add(Me.chkLanguageFormCode)
        Me.grpLanguageForm.Controls.Add(Me.txtLanguageCodeForm)
        Me.grpLanguageForm.Controls.Add(Me.Label5)
        Me.grpLanguageForm.Controls.Add(Me.lsvLanguage)
        Me.grpLanguageForm.Controls.Add(Me.butSearchLangForm)
        Me.grpLanguageForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpLanguageForm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpLanguageForm.Location = New System.Drawing.Point(6, 6)
        Me.grpLanguageForm.Name = "grpLanguageForm"
        Me.grpLanguageForm.Size = New System.Drawing.Size(1117, 668)
        Me.grpLanguageForm.TabIndex = 68
        Me.grpLanguageForm.TabStop = false
        Me.grpLanguageForm.Text = "Languages"
        '
        'butClearLang
        '
        Me.butClearLang.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.butClearLang.BackColor = System.Drawing.SystemColors.Control
        Me.butClearLang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butClearLang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClearLang.Location = New System.Drawing.Point(998, 20)
        Me.butClearLang.Name = "butClearLang"
        Me.butClearLang.Size = New System.Drawing.Size(113, 79)
        Me.butClearLang.TabIndex = 152
        Me.butClearLang.Text = "Clear"
        Me.butClearLang.UseVisualStyleBackColor = false
        '
        'butDeleteLangForm
        '
        Me.butDeleteLangForm.BackColor = System.Drawing.SystemColors.Control
        Me.butDeleteLangForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butDeleteLangForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butDeleteLangForm.Location = New System.Drawing.Point(651, 20)
        Me.butDeleteLangForm.Name = "butDeleteLangForm"
        Me.butDeleteLangForm.Size = New System.Drawing.Size(113, 78)
        Me.butDeleteLangForm.TabIndex = 77
        Me.butDeleteLangForm.Text = "Delete Selected"
        Me.butDeleteLangForm.UseVisualStyleBackColor = false
        '
        'lbIdLanguageForm
        '
        Me.lbIdLanguageForm.AutoSize = true
        Me.lbIdLanguageForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbIdLanguageForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdLanguageForm.Location = New System.Drawing.Point(16, 109)
        Me.lbIdLanguageForm.Name = "lbIdLanguageForm"
        Me.lbIdLanguageForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdLanguageForm.TabIndex = 76
        Me.lbIdLanguageForm.Text = "-1"
        Me.lbIdLanguageForm.Visible = false
        '
        'butEditLangForm
        '
        Me.butEditLangForm.BackColor = System.Drawing.SystemColors.Control
        Me.butEditLangForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butEditLangForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butEditLangForm.Location = New System.Drawing.Point(532, 20)
        Me.butEditLangForm.Name = "butEditLangForm"
        Me.butEditLangForm.Size = New System.Drawing.Size(113, 78)
        Me.butEditLangForm.TabIndex = 75
        Me.butEditLangForm.Text = "Edit Selected"
        Me.butEditLangForm.UseVisualStyleBackColor = false
        '
        'chkLanguageLabelForm
        '
        Me.chkLanguageLabelForm.AutoSize = true
        Me.chkLanguageLabelForm.Checked = true
        Me.chkLanguageLabelForm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLanguageLabelForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkLanguageLabelForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLanguageLabelForm.Location = New System.Drawing.Point(319, 77)
        Me.chkLanguageLabelForm.Name = "chkLanguageLabelForm"
        Me.chkLanguageLabelForm.Size = New System.Drawing.Size(75, 17)
        Me.chkLanguageLabelForm.TabIndex = 74
        Me.chkLanguageLabelForm.Text = "Contains"
        Me.chkLanguageLabelForm.UseVisualStyleBackColor = true
        '
        'txtLanguageLabelForm
        '
        Me.txtLanguageLabelForm.Location = New System.Drawing.Point(126, 75)
        Me.txtLanguageLabelForm.Name = "txtLanguageLabelForm"
        Me.txtLanguageLabelForm.Size = New System.Drawing.Size(187, 23)
        Me.txtLanguageLabelForm.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Label"
        '
        'butAddLang
        '
        Me.butAddLang.BackColor = System.Drawing.SystemColors.Control
        Me.butAddLang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butAddLang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddLang.Location = New System.Drawing.Point(413, 20)
        Me.butAddLang.Name = "butAddLang"
        Me.butAddLang.Size = New System.Drawing.Size(113, 78)
        Me.butAddLang.TabIndex = 71
        Me.butAddLang.Text = "Add New"
        Me.butAddLang.UseVisualStyleBackColor = false
        '
        'chkLanguageFormCode
        '
        Me.chkLanguageFormCode.AutoSize = true
        Me.chkLanguageFormCode.Checked = true
        Me.chkLanguageFormCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLanguageFormCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkLanguageFormCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLanguageFormCode.Location = New System.Drawing.Point(319, 27)
        Me.chkLanguageFormCode.Name = "chkLanguageFormCode"
        Me.chkLanguageFormCode.Size = New System.Drawing.Size(75, 17)
        Me.chkLanguageFormCode.TabIndex = 70
        Me.chkLanguageFormCode.Text = "Contains"
        Me.chkLanguageFormCode.UseVisualStyleBackColor = true
        '
        'txtLanguageCodeForm
        '
        Me.txtLanguageCodeForm.Location = New System.Drawing.Point(126, 25)
        Me.txtLanguageCodeForm.Name = "txtLanguageCodeForm"
        Me.txtLanguageCodeForm.Size = New System.Drawing.Size(187, 23)
        Me.txtLanguageCodeForm.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Code"
        '
        'lsvLanguage
        '
        Me.lsvLanguage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lsvLanguage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidLang, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lsvLanguage.FullRowSelect = true
        Me.lsvLanguage.GridLines = true
        Me.lsvLanguage.HideSelection = false
        Me.lsvLanguage.Location = New System.Drawing.Point(10, 139)
        Me.lsvLanguage.MultiSelect = false
        Me.lsvLanguage.Name = "lsvLanguage"
        Me.lsvLanguage.Size = New System.Drawing.Size(1101, 523)
        Me.lsvLanguage.TabIndex = 55
        Me.lsvLanguage.UseCompatibleStateImageBehavior = false
        Me.lsvLanguage.View = System.Windows.Forms.View.Details
        '
        'cidLang
        '
        Me.cidLang.Tag = "cidLang"
        Me.cidLang.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Code"
        Me.ColumnHeader3.Width = 400
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Label"
        Me.ColumnHeader4.Width = 300
        '
        'butSearchLangForm
        '
        Me.butSearchLangForm.BackColor = System.Drawing.SystemColors.Control
        Me.butSearchLangForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butSearchLangForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSearchLangForm.Location = New System.Drawing.Point(770, 20)
        Me.butSearchLangForm.Name = "butSearchLangForm"
        Me.butSearchLangForm.Size = New System.Drawing.Size(113, 78)
        Me.butSearchLangForm.TabIndex = 9
        Me.butSearchLangForm.Text = "Find"
        Me.butSearchLangForm.UseVisualStyleBackColor = false
        '
        'tbGarages
        '
        Me.tbGarages.Controls.Add(Me.grpGarageForm)
        Me.tbGarages.Location = New System.Drawing.Point(4, 25)
        Me.tbGarages.Name = "tbGarages"
        Me.tbGarages.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGarages.Size = New System.Drawing.Size(1187, 657)
        Me.tbGarages.TabIndex = 3
        Me.tbGarages.Text = "Garages"
        Me.tbGarages.UseVisualStyleBackColor = true
        '
        'grpGarageForm
        '
        Me.grpGarageForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpGarageForm.BackColor = System.Drawing.Color.Transparent
        Me.grpGarageForm.Controls.Add(Me.GroupBox7)
        Me.grpGarageForm.Controls.Add(Me.chkUsername)
        Me.grpGarageForm.Controls.Add(Me.txtusername)
        Me.grpGarageForm.Controls.Add(Me.Label35)
        Me.grpGarageForm.Controls.Add(Me.GroupBox6)
        Me.grpGarageForm.Controls.Add(Me.pctThemeColor)
        Me.grpGarageForm.Controls.Add(Me.Label33)
        Me.grpGarageForm.Controls.Add(Me.GroupBox5)
        Me.grpGarageForm.Controls.Add(Me.chkkey)
        Me.grpGarageForm.Controls.Add(Me.txtkey)
        Me.grpGarageForm.Controls.Add(Me.Label31)
        Me.grpGarageForm.Controls.Add(Me.chktel)
        Me.grpGarageForm.Controls.Add(Me.txttel)
        Me.grpGarageForm.Controls.Add(Me.Label30)
        Me.grpGarageForm.Controls.Add(Me.GroupBox4)
        Me.grpGarageForm.Controls.Add(Me.Label28)
        Me.grpGarageForm.Controls.Add(Me.chkversion)
        Me.grpGarageForm.Controls.Add(Me.txtversion)
        Me.grpGarageForm.Controls.Add(Me.Label27)
        Me.grpGarageForm.Controls.Add(Me.grpradio)
        Me.grpGarageForm.Controls.Add(Me.butClearGarage)
        Me.grpGarageForm.Controls.Add(Me.Label20)
        Me.grpGarageForm.Controls.Add(Me.butFindGarageImg)
        Me.grpGarageForm.Controls.Add(Me.txtGarageImgPath)
        Me.grpGarageForm.Controls.Add(Me.Label19)
        Me.grpGarageForm.Controls.Add(Me.txtfnamegaragehidden)
        Me.grpGarageForm.Controls.Add(Me.Label18)
        Me.grpGarageForm.Controls.Add(Me.pctGarageImg)
        Me.grpGarageForm.Controls.Add(Me.GroupBox2)
        Me.grpGarageForm.Controls.Add(Me.butFindLang)
        Me.grpGarageForm.Controls.Add(Me.lbIdLanguage)
        Me.grpGarageForm.Controls.Add(Me.txtLanguage)
        Me.grpGarageForm.Controls.Add(Me.Label6)
        Me.grpGarageForm.Controls.Add(Me.chkGarageRespForm)
        Me.grpGarageForm.Controls.Add(Me.txtGarageRespform)
        Me.grpGarageForm.Controls.Add(Me.Label7)
        Me.grpGarageForm.Controls.Add(Me.butDeleteGarageForm)
        Me.grpGarageForm.Controls.Add(Me.lbIdGarageForm)
        Me.grpGarageForm.Controls.Add(Me.butEditGarageForm)
        Me.grpGarageForm.Controls.Add(Me.chkGarageLocationForm)
        Me.grpGarageForm.Controls.Add(Me.txtGarageLocationForm)
        Me.grpGarageForm.Controls.Add(Me.Label8)
        Me.grpGarageForm.Controls.Add(Me.butAddGarage)
        Me.grpGarageForm.Controls.Add(Me.chkGarageFormCode)
        Me.grpGarageForm.Controls.Add(Me.txtGarageNameForm)
        Me.grpGarageForm.Controls.Add(Me.Label9)
        Me.grpGarageForm.Controls.Add(Me.lsvGarage)
        Me.grpGarageForm.Controls.Add(Me.butSearchGarageForm)
        Me.grpGarageForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpGarageForm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpGarageForm.Location = New System.Drawing.Point(6, 6)
        Me.grpGarageForm.Name = "grpGarageForm"
        Me.grpGarageForm.Size = New System.Drawing.Size(1175, 664)
        Me.grpGarageForm.TabIndex = 70
        Me.grpGarageForm.TabStop = false
        Me.grpGarageForm.Text = "Garages"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lbHqConversionProgress)
        Me.GroupBox7.Controls.Add(Me.butBrowseHqDirectory)
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Controls.Add(Me.txtHqDirectory)
        Me.GroupBox7.Controls.Add(Me.butConvertToHQ)
        Me.GroupBox7.Location = New System.Drawing.Point(433, 115)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(236, 117)
        Me.GroupBox7.TabIndex = 89
        Me.GroupBox7.TabStop = false
        '
        'lbHqConversionProgress
        '
        Me.lbHqConversionProgress.AutoSize = true
        Me.lbHqConversionProgress.Location = New System.Drawing.Point(16, 44)
        Me.lbHqConversionProgress.Name = "lbHqConversionProgress"
        Me.lbHqConversionProgress.Size = New System.Drawing.Size(0, 17)
        Me.lbHqConversionProgress.TabIndex = 89
        '
        'butBrowseHqDirectory
        '
        Me.butBrowseHqDirectory.BackColor = System.Drawing.SystemColors.Control
        Me.butBrowseHqDirectory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butBrowseHqDirectory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butBrowseHqDirectory.Location = New System.Drawing.Point(194, 16)
        Me.butBrowseHqDirectory.Name = "butBrowseHqDirectory"
        Me.butBrowseHqDirectory.Size = New System.Drawing.Size(37, 26)
        Me.butBrowseHqDirectory.TabIndex = 88
        Me.butBrowseHqDirectory.Text = "--"
        Me.butBrowseHqDirectory.UseVisualStyleBackColor = false
        '
        'Label36
        '
        Me.Label36.AutoSize = true
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(13, 23)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(85, 15)
        Me.Label36.TabIndex = 87
        Me.Label36.Text = "Folder Path:"
        '
        'txtHqDirectory
        '
        Me.txtHqDirectory.Location = New System.Drawing.Point(104, 18)
        Me.txtHqDirectory.Name = "txtHqDirectory"
        Me.txtHqDirectory.ReadOnly = true
        Me.txtHqDirectory.Size = New System.Drawing.Size(84, 23)
        Me.txtHqDirectory.TabIndex = 86
        '
        'butConvertToHQ
        '
        Me.butConvertToHQ.BackColor = System.Drawing.SystemColors.Control
        Me.butConvertToHQ.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butConvertToHQ.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butConvertToHQ.Location = New System.Drawing.Point(16, 64)
        Me.butConvertToHQ.Name = "butConvertToHQ"
        Me.butConvertToHQ.Size = New System.Drawing.Size(205, 47)
        Me.butConvertToHQ.TabIndex = 85
        Me.butConvertToHQ.Text = "Generate corresponding HQ"
        Me.butConvertToHQ.UseVisualStyleBackColor = false
        '
        'chkUsername
        '
        Me.chkUsername.AutoSize = true
        Me.chkUsername.Checked = true
        Me.chkUsername.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkUsername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUsername.Location = New System.Drawing.Point(272, 208)
        Me.chkUsername.Name = "chkUsername"
        Me.chkUsername.Size = New System.Drawing.Size(75, 17)
        Me.chkUsername.TabIndex = 174
        Me.chkUsername.Text = "Contains"
        Me.chkUsername.UseVisualStyleBackColor = true
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(126, 203)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(136, 23)
        Me.txtusername.TabIndex = 7
        '
        'Label35
        '
        Me.Label35.AutoSize = true
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(16, 203)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(73, 15)
        Me.Label35.TabIndex = 172
        Me.Label35.Text = "Username"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdShowAltNone)
        Me.GroupBox6.Controls.Add(Me.rdShowAlternative)
        Me.GroupBox6.Controls.Add(Me.rdShowAlternative2)
        Me.GroupBox6.Location = New System.Drawing.Point(237, 275)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(495, 38)
        Me.GroupBox6.TabIndex = 159
        Me.GroupBox6.TabStop = false
        '
        'rdShowAltNone
        '
        Me.rdShowAltNone.AutoSize = true
        Me.rdShowAltNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdShowAltNone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdShowAltNone.Location = New System.Drawing.Point(6, 15)
        Me.rdShowAltNone.Name = "rdShowAltNone"
        Me.rdShowAltNone.Size = New System.Drawing.Size(55, 17)
        Me.rdShowAltNone.TabIndex = 17
        Me.rdShowAltNone.TabStop = true
        Me.rdShowAltNone.Text = "None"
        Me.rdShowAltNone.UseVisualStyleBackColor = true
        '
        'rdShowAlternative
        '
        Me.rdShowAlternative.AutoSize = true
        Me.rdShowAlternative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdShowAlternative.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdShowAlternative.Location = New System.Drawing.Point(80, 15)
        Me.rdShowAlternative.Name = "rdShowAlternative"
        Me.rdShowAlternative.Size = New System.Drawing.Size(186, 17)
        Me.rdShowAlternative.TabIndex = 18
        Me.rdShowAlternative.TabStop = true
        Me.rdShowAlternative.Text = "Show alternative color name"
        Me.rdShowAlternative.UseVisualStyleBackColor = true
        '
        'rdShowAlternative2
        '
        Me.rdShowAlternative2.AutoSize = true
        Me.rdShowAlternative2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdShowAlternative2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdShowAlternative2.Location = New System.Drawing.Point(285, 15)
        Me.rdShowAlternative2.Name = "rdShowAlternative2"
        Me.rdShowAlternative2.Size = New System.Drawing.Size(197, 17)
        Me.rdShowAlternative2.TabIndex = 19
        Me.rdShowAlternative2.TabStop = true
        Me.rdShowAlternative2.Text = "Show alternative color name 2"
        Me.rdShowAlternative2.UseVisualStyleBackColor = true
        '
        'pctThemeColor
        '
        Me.pctThemeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctThemeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctThemeColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctThemeColor.Location = New System.Drawing.Point(126, 351)
        Me.pctThemeColor.Margin = New System.Windows.Forms.Padding(4)
        Me.pctThemeColor.Name = "pctThemeColor"
        Me.pctThemeColor.Size = New System.Drawing.Size(161, 25)
        Me.pctThemeColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctThemeColor.TabIndex = 170
        Me.pctThemeColor.TabStop = false
        '
        'Label33
        '
        Me.Label33.AutoSize = true
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(16, 351)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(91, 15)
        Me.Label33.TabIndex = 169
        Me.Label33.Text = "Theme color:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.butBrowseDb)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.txtDBDirectory)
        Me.GroupBox5.Controls.Add(Me.butInstallMobile)
        Me.GroupBox5.Location = New System.Drawing.Point(933, 276)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(236, 117)
        Me.GroupBox5.TabIndex = 89
        Me.GroupBox5.TabStop = false
        '
        'butBrowseDb
        '
        Me.butBrowseDb.BackColor = System.Drawing.SystemColors.Control
        Me.butBrowseDb.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butBrowseDb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butBrowseDb.Location = New System.Drawing.Point(193, 16)
        Me.butBrowseDb.Name = "butBrowseDb"
        Me.butBrowseDb.Size = New System.Drawing.Size(37, 26)
        Me.butBrowseDb.TabIndex = 88
        Me.butBrowseDb.Text = "--"
        Me.butBrowseDb.UseVisualStyleBackColor = false
        '
        'Label32
        '
        Me.Label32.AutoSize = true
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(13, 20)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(85, 15)
        Me.Label32.TabIndex = 87
        Me.Label32.Text = "Folder Path:"
        '
        'txtDBDirectory
        '
        Me.txtDBDirectory.Location = New System.Drawing.Point(104, 18)
        Me.txtDBDirectory.Name = "txtDBDirectory"
        Me.txtDBDirectory.ReadOnly = true
        Me.txtDBDirectory.Size = New System.Drawing.Size(83, 23)
        Me.txtDBDirectory.TabIndex = 86
        '
        'butInstallMobile
        '
        Me.butInstallMobile.BackColor = System.Drawing.SystemColors.Control
        Me.butInstallMobile.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butInstallMobile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butInstallMobile.Location = New System.Drawing.Point(16, 55)
        Me.butInstallMobile.Name = "butInstallMobile"
        Me.butInstallMobile.Size = New System.Drawing.Size(205, 57)
        Me.butInstallMobile.TabIndex = 85
        Me.butInstallMobile.Text = "Generate Mobile Insallation File"
        Me.butInstallMobile.UseVisualStyleBackColor = false
        '
        'chkkey
        '
        Me.chkkey.AutoSize = true
        Me.chkkey.Checked = true
        Me.chkkey.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkkey.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkkey.Location = New System.Drawing.Point(272, 179)
        Me.chkkey.Name = "chkkey"
        Me.chkkey.Size = New System.Drawing.Size(75, 17)
        Me.chkkey.TabIndex = 168
        Me.chkkey.Text = "Contains"
        Me.chkkey.UseVisualStyleBackColor = true
        '
        'txtkey
        '
        Me.txtkey.Location = New System.Drawing.Point(126, 174)
        Me.txtkey.Name = "txtkey"
        Me.txtkey.Size = New System.Drawing.Size(136, 23)
        Me.txtkey.TabIndex = 6
        '
        'Label31
        '
        Me.Label31.AutoSize = true
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(16, 174)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(30, 15)
        Me.Label31.TabIndex = 166
        Me.Label31.Text = "Key"
        '
        'chktel
        '
        Me.chktel.AutoSize = true
        Me.chktel.Checked = true
        Me.chktel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chktel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chktel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chktel.Location = New System.Drawing.Point(272, 150)
        Me.chktel.Name = "chktel"
        Me.chktel.Size = New System.Drawing.Size(75, 17)
        Me.chktel.TabIndex = 165
        Me.chktel.Text = "Contains"
        Me.chktel.UseVisualStyleBackColor = true
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(126, 145)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(136, 23)
        Me.txttel.TabIndex = 5
        '
        'Label30
        '
        Me.Label30.AutoSize = true
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(16, 145)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(31, 15)
        Me.Label30.TabIndex = 163
        Me.Label30.Text = "Tel."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdGarage2k)
        Me.GroupBox4.Controls.Add(Me.rdGarageLS)
        Me.GroupBox4.Location = New System.Drawing.Point(126, 274)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(101, 36)
        Me.GroupBox4.TabIndex = 161
        Me.GroupBox4.TabStop = false
        '
        'rdGarage2k
        '
        Me.rdGarage2k.AutoSize = true
        Me.rdGarage2k.Checked = true
        Me.rdGarage2k.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdGarage2k.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdGarage2k.Location = New System.Drawing.Point(6, 12)
        Me.rdGarage2k.Name = "rdGarage2k"
        Me.rdGarage2k.Size = New System.Drawing.Size(40, 17)
        Me.rdGarage2k.TabIndex = 15
        Me.rdGarage2k.TabStop = true
        Me.rdGarage2k.Text = "2K"
        Me.rdGarage2k.UseVisualStyleBackColor = true
        '
        'rdGarageLS
        '
        Me.rdGarageLS.AutoSize = true
        Me.rdGarageLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdGarageLS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdGarageLS.Location = New System.Drawing.Point(61, 12)
        Me.rdGarageLS.Name = "rdGarageLS"
        Me.rdGarageLS.Size = New System.Drawing.Size(40, 17)
        Me.rdGarageLS.TabIndex = 16
        Me.rdGarageLS.Text = "LS"
        Me.rdGarageLS.UseVisualStyleBackColor = true
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(16, 283)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 15)
        Me.Label28.TabIndex = 160
        Me.Label28.Text = "Coat"
        '
        'chkversion
        '
        Me.chkversion.AutoSize = true
        Me.chkversion.Checked = true
        Me.chkversion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkversion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkversion.Location = New System.Drawing.Point(272, 120)
        Me.chkversion.Name = "chkversion"
        Me.chkversion.Size = New System.Drawing.Size(75, 17)
        Me.chkversion.TabIndex = 159
        Me.chkversion.Text = "Contains"
        Me.chkversion.UseVisualStyleBackColor = true
        '
        'txtversion
        '
        Me.txtversion.Location = New System.Drawing.Point(126, 115)
        Me.txtversion.Name = "txtversion"
        Me.txtversion.Size = New System.Drawing.Size(136, 23)
        Me.txtversion.TabIndex = 4
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(16, 115)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 15)
        Me.Label27.TabIndex = 157
        Me.Label27.Text = "Version"
        '
        'grpradio
        '
        Me.grpradio.Controls.Add(Me.rdApply1)
        Me.grpradio.Controls.Add(Me.rdApply0)
        Me.grpradio.Location = New System.Drawing.Point(126, 236)
        Me.grpradio.Name = "grpradio"
        Me.grpradio.Size = New System.Drawing.Size(221, 38)
        Me.grpradio.TabIndex = 156
        Me.grpradio.TabStop = false
        '
        'rdApply0
        '
        Me.rdApply0.AutoSize = true
        Me.rdApply0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdApply0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdApply0.Location = New System.Drawing.Point(6, 12)
        Me.rdApply0.Name = "rdApply0"
        Me.rdApply0.Size = New System.Drawing.Size(55, 17)
        Me.rdApply0.TabIndex = 8
        Me.rdApply0.TabStop = true
        Me.rdApply0.Text = "None"
        Me.rdApply0.UseVisualStyleBackColor = true
        '
        'butClearGarage
        '
        Me.butClearGarage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.butClearGarage.BackColor = System.Drawing.SystemColors.Control
        Me.butClearGarage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butClearGarage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClearGarage.Location = New System.Drawing.Point(1056, 22)
        Me.butClearGarage.Name = "butClearGarage"
        Me.butClearGarage.Size = New System.Drawing.Size(113, 79)
        Me.butClearGarage.TabIndex = 153
        Me.butClearGarage.Text = "Clear"
        Me.butClearGarage.UseVisualStyleBackColor = false
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(16, 245)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 15)
        Me.Label20.TabIndex = 127
        Me.Label20.Text = "Equation"
        '
        'butFindGarageImg
        '
        Me.butFindGarageImg.BackColor = System.Drawing.SystemColors.Control
        Me.butFindGarageImg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butFindGarageImg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butFindGarageImg.Location = New System.Drawing.Point(521, 321)
        Me.butFindGarageImg.Name = "butFindGarageImg"
        Me.butFindGarageImg.Size = New System.Drawing.Size(35, 23)
        Me.butFindGarageImg.TabIndex = 21
        Me.butFindGarageImg.Text = " -- "
        Me.butFindGarageImg.UseVisualStyleBackColor = false
        '
        'txtGarageImgPath
        '
        Me.txtGarageImgPath.Location = New System.Drawing.Point(638, 348)
        Me.txtGarageImgPath.Name = "txtGarageImgPath"
        Me.txtGarageImgPath.ReadOnly = true
        Me.txtGarageImgPath.Size = New System.Drawing.Size(161, 23)
        Me.txtGarageImgPath.TabIndex = 125
        Me.txtGarageImgPath.Visible = false
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(347, 321)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 15)
        Me.Label19.TabIndex = 124
        Me.Label19.Text = "Logo:"
        '
        'txtfnamegaragehidden
        '
        Me.txtfnamegaragehidden.Location = New System.Drawing.Point(563, 400)
        Me.txtfnamegaragehidden.Name = "txtfnamegaragehidden"
        Me.txtfnamegaragehidden.ReadOnly = true
        Me.txtfnamegaragehidden.Size = New System.Drawing.Size(101, 23)
        Me.txtfnamegaragehidden.TabIndex = 123
        Me.txtfnamegaragehidden.Visible = false
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(346, 362)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 15)
        Me.Label18.TabIndex = 122
        Me.Label18.Text = "Thumbnail:"
        Me.Label18.Visible = false
        '
        'pctGarageImg
        '
        Me.pctGarageImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctGarageImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctGarageImg.Location = New System.Drawing.Point(414, 321)
        Me.pctGarageImg.Name = "pctGarageImg"
        Me.pctGarageImg.Size = New System.Drawing.Size(101, 72)
        Me.pctGarageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctGarageImg.TabIndex = 121
        Me.pctGarageImg.TabStop = false
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.butBrowse)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtGarageDirectory)
        Me.GroupBox2.Controls.Add(Me.butInstall)
        Me.GroupBox2.Location = New System.Drawing.Point(933, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 117)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = false
        '
        'butBrowse
        '
        Me.butBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.butBrowse.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butBrowse.Location = New System.Drawing.Point(194, 16)
        Me.butBrowse.Name = "butBrowse"
        Me.butBrowse.Size = New System.Drawing.Size(37, 26)
        Me.butBrowse.TabIndex = 88
        Me.butBrowse.Text = "--"
        Me.butBrowse.UseVisualStyleBackColor = false
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(13, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 15)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Folder Path:"
        '
        'txtGarageDirectory
        '
        Me.txtGarageDirectory.Location = New System.Drawing.Point(104, 18)
        Me.txtGarageDirectory.Name = "txtGarageDirectory"
        Me.txtGarageDirectory.ReadOnly = true
        Me.txtGarageDirectory.Size = New System.Drawing.Size(84, 23)
        Me.txtGarageDirectory.TabIndex = 86
        '
        'butInstall
        '
        Me.butInstall.BackColor = System.Drawing.SystemColors.Control
        Me.butInstall.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butInstall.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butInstall.Location = New System.Drawing.Point(16, 54)
        Me.butInstall.Name = "butInstall"
        Me.butInstall.Size = New System.Drawing.Size(205, 57)
        Me.butInstall.TabIndex = 85
        Me.butInstall.Text = "Generate Insallation File"
        Me.butInstall.UseVisualStyleBackColor = false
        '
        'butFindLang
        '
        Me.butFindLang.BackColor = System.Drawing.SystemColors.Control
        Me.butFindLang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butFindLang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butFindLang.Location = New System.Drawing.Point(268, 321)
        Me.butFindLang.Name = "butFindLang"
        Me.butFindLang.Size = New System.Drawing.Size(66, 23)
        Me.butFindLang.TabIndex = 20
        Me.butFindLang.Text = "Find"
        Me.butFindLang.UseVisualStyleBackColor = false
        '
        'lbIdLanguage
        '
        Me.lbIdLanguage.AutoSize = true
        Me.lbIdLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbIdLanguage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdLanguage.Location = New System.Drawing.Point(100, 324)
        Me.lbIdLanguage.Name = "lbIdLanguage"
        Me.lbIdLanguage.Size = New System.Drawing.Size(20, 15)
        Me.lbIdLanguage.TabIndex = 83
        Me.lbIdLanguage.Text = "-1"
        Me.lbIdLanguage.Visible = false
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(126, 321)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.ReadOnly = true
        Me.txtLanguage.Size = New System.Drawing.Size(136, 23)
        Me.txtLanguage.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Language:"
        '
        'chkGarageRespForm
        '
        Me.chkGarageRespForm.AutoSize = true
        Me.chkGarageRespForm.Checked = true
        Me.chkGarageRespForm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGarageRespForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGarageRespForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGarageRespForm.Location = New System.Drawing.Point(272, 91)
        Me.chkGarageRespForm.Name = "chkGarageRespForm"
        Me.chkGarageRespForm.Size = New System.Drawing.Size(75, 17)
        Me.chkGarageRespForm.TabIndex = 80
        Me.chkGarageRespForm.Text = "Contains"
        Me.chkGarageRespForm.UseVisualStyleBackColor = true
        '
        'txtGarageRespform
        '
        Me.txtGarageRespform.Location = New System.Drawing.Point(126, 86)
        Me.txtGarageRespform.Name = "txtGarageRespform"
        Me.txtGarageRespform.Size = New System.Drawing.Size(136, 23)
        Me.txtGarageRespform.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Responsible"
        '
        'butDeleteGarageForm
        '
        Me.butDeleteGarageForm.BackColor = System.Drawing.SystemColors.Control
        Me.butDeleteGarageForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butDeleteGarageForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butDeleteGarageForm.Location = New System.Drawing.Point(671, 22)
        Me.butDeleteGarageForm.Name = "butDeleteGarageForm"
        Me.butDeleteGarageForm.Size = New System.Drawing.Size(113, 78)
        Me.butDeleteGarageForm.TabIndex = 77
        Me.butDeleteGarageForm.Text = "Delete Selected"
        Me.butDeleteGarageForm.UseVisualStyleBackColor = false
        '
        'lbIdGarageForm
        '
        Me.lbIdGarageForm.AutoSize = true
        Me.lbIdGarageForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbIdGarageForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdGarageForm.Location = New System.Drawing.Point(347, 408)
        Me.lbIdGarageForm.Name = "lbIdGarageForm"
        Me.lbIdGarageForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdGarageForm.TabIndex = 76
        Me.lbIdGarageForm.Text = "-1"
        Me.lbIdGarageForm.Visible = false
        '
        'butEditGarageForm
        '
        Me.butEditGarageForm.BackColor = System.Drawing.SystemColors.Control
        Me.butEditGarageForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butEditGarageForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butEditGarageForm.Location = New System.Drawing.Point(552, 22)
        Me.butEditGarageForm.Name = "butEditGarageForm"
        Me.butEditGarageForm.Size = New System.Drawing.Size(113, 78)
        Me.butEditGarageForm.TabIndex = 75
        Me.butEditGarageForm.Text = "Edit Selected"
        Me.butEditGarageForm.UseVisualStyleBackColor = false
        '
        'chkGarageLocationForm
        '
        Me.chkGarageLocationForm.AutoSize = true
        Me.chkGarageLocationForm.Checked = true
        Me.chkGarageLocationForm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGarageLocationForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGarageLocationForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGarageLocationForm.Location = New System.Drawing.Point(272, 62)
        Me.chkGarageLocationForm.Name = "chkGarageLocationForm"
        Me.chkGarageLocationForm.Size = New System.Drawing.Size(75, 17)
        Me.chkGarageLocationForm.TabIndex = 74
        Me.chkGarageLocationForm.Text = "Contains"
        Me.chkGarageLocationForm.UseVisualStyleBackColor = true
        '
        'txtGarageLocationForm
        '
        Me.txtGarageLocationForm.Location = New System.Drawing.Point(126, 57)
        Me.txtGarageLocationForm.Name = "txtGarageLocationForm"
        Me.txtGarageLocationForm.Size = New System.Drawing.Size(136, 23)
        Me.txtGarageLocationForm.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Location"
        '
        'butAddGarage
        '
        Me.butAddGarage.BackColor = System.Drawing.SystemColors.Control
        Me.butAddGarage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butAddGarage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddGarage.Location = New System.Drawing.Point(433, 22)
        Me.butAddGarage.Name = "butAddGarage"
        Me.butAddGarage.Size = New System.Drawing.Size(113, 78)
        Me.butAddGarage.TabIndex = 71
        Me.butAddGarage.Text = "Add New"
        Me.butAddGarage.UseVisualStyleBackColor = false
        '
        'chkGarageFormCode
        '
        Me.chkGarageFormCode.AutoSize = true
        Me.chkGarageFormCode.Checked = true
        Me.chkGarageFormCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGarageFormCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGarageFormCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGarageFormCode.Location = New System.Drawing.Point(272, 30)
        Me.chkGarageFormCode.Name = "chkGarageFormCode"
        Me.chkGarageFormCode.Size = New System.Drawing.Size(75, 17)
        Me.chkGarageFormCode.TabIndex = 70
        Me.chkGarageFormCode.Text = "Contains"
        Me.chkGarageFormCode.UseVisualStyleBackColor = true
        '
        'txtGarageNameForm
        '
        Me.txtGarageNameForm.Location = New System.Drawing.Point(126, 25)
        Me.txtGarageNameForm.Name = "txtGarageNameForm"
        Me.txtGarageNameForm.Size = New System.Drawing.Size(136, 23)
        Me.txtGarageNameForm.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Name"
        '
        'lsvGarage
        '
        Me.lsvGarage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lsvGarage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidGarage, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.cidlanggarage, Me.cappequation, Me.cgversion, Me.cgcoat})
        Me.lsvGarage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lsvGarage.FullRowSelect = true
        Me.lsvGarage.GridLines = true
        Me.lsvGarage.HideSelection = false
        Me.lsvGarage.Location = New System.Drawing.Point(10, 455)
        Me.lsvGarage.MultiSelect = false
        Me.lsvGarage.Name = "lsvGarage"
        Me.lsvGarage.Size = New System.Drawing.Size(1159, 203)
        Me.lsvGarage.TabIndex = 99999999
        Me.lsvGarage.UseCompatibleStateImageBehavior = false
        Me.lsvGarage.View = System.Windows.Forms.View.Details
        '
        'cidGarage
        '
        Me.cidGarage.Tag = "cidGarage"
        Me.cidGarage.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "name"
        Me.ColumnHeader5.Width = 250
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "location"
        Me.ColumnHeader6.Width = 185
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Responsible"
        Me.ColumnHeader7.Width = 178
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Language"
        Me.ColumnHeader8.Width = 90
        '
        'cidlanggarage
        '
        Me.cidlanggarage.Tag = "cidlanggarage"
        Me.cidlanggarage.Width = 0
        '
        'cappequation
        '
        Me.cappequation.Tag = "cappequation"
        Me.cappequation.Text = "Apply Equation"
        Me.cappequation.Width = 135
        '
        'cgversion
        '
        Me.cgversion.Text = "Version"
        Me.cgversion.Width = 238
        '
        'cgcoat
        '
        Me.cgcoat.Text = "Coat"
        '
        'butSearchGarageForm
        '
        Me.butSearchGarageForm.BackColor = System.Drawing.SystemColors.Control
        Me.butSearchGarageForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butSearchGarageForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSearchGarageForm.Location = New System.Drawing.Point(790, 22)
        Me.butSearchGarageForm.Name = "butSearchGarageForm"
        Me.butSearchGarageForm.Size = New System.Drawing.Size(113, 78)
        Me.butSearchGarageForm.TabIndex = 9
        Me.butSearchGarageForm.Text = "Find"
        Me.butSearchGarageForm.UseVisualStyleBackColor = false
        '
        'tbColors
        '
        Me.tbColors.Controls.Add(Me.grpBColors)
        Me.tbColors.Location = New System.Drawing.Point(4, 25)
        Me.tbColors.Name = "tbColors"
        Me.tbColors.Padding = New System.Windows.Forms.Padding(3)
        Me.tbColors.Size = New System.Drawing.Size(1187, 657)
        Me.tbColors.TabIndex = 4
        Me.tbColors.Text = "Basic Colors"
        Me.tbColors.UseVisualStyleBackColor = true
        '
        'grpBColors
        '
        Me.grpBColors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpBColors.BackColor = System.Drawing.Color.Transparent
        Me.grpBColors.Controls.Add(Me.chkBColorFormNameAlt2)
        Me.grpBColors.Controls.Add(Me.txtBColorNameFormAlt2)
        Me.grpBColors.Controls.Add(Me.Label34)
        Me.grpBColors.Controls.Add(Me.pctBColorRGB)
        Me.grpBColors.Controls.Add(Me.txtMasseVolumiqueExt)
        Me.grpBColors.Controls.Add(Me.Label29)
        Me.grpBColors.Controls.Add(Me.chkBColorFormNameAlt)
        Me.grpBColors.Controls.Add(Me.txtBColorNameFormAlt)
        Me.grpBColors.Controls.Add(Me.lbBColorNameFormAlt)
        Me.grpBColors.Controls.Add(Me.butReportAll)
        Me.grpBColors.Controls.Add(Me.butClearBColor)
        Me.grpBColors.Controls.Add(Me.txtMasseVolumique)
        Me.grpBColors.Controls.Add(Me.Label25)
        Me.grpBColors.Controls.Add(Me.cmbUnit)
        Me.grpBColors.Controls.Add(Me.Label4)
        Me.grpBColors.Controls.Add(Me.chkBColorFormCode)
        Me.grpBColors.Controls.Add(Me.txtBColorCodeForm)
        Me.grpBColors.Controls.Add(Me.Label21)
        Me.grpBColors.Controls.Add(Me.txtfnamehideenColor)
        Me.grpBColors.Controls.Add(Me.butFindBColorImg)
        Me.grpBColors.Controls.Add(Me.txtBColorImgPath)
        Me.grpBColors.Controls.Add(Me.Label17)
        Me.grpBColors.Controls.Add(Me.Label16)
        Me.grpBColors.Controls.Add(Me.pctBColorImg)
        Me.grpBColors.Controls.Add(Me.txtPriceBcolorForm)
        Me.grpBColors.Controls.Add(Me.Label11)
        Me.grpBColors.Controls.Add(Me.lbCurrencyDetailsValue2)
        Me.grpBColors.Controls.Add(Me.Label13)
        Me.grpBColors.Controls.Add(Me.butDeleteBColorForm)
        Me.grpBColors.Controls.Add(Me.lbIdBColorForm)
        Me.grpBColors.Controls.Add(Me.butEditBColorForm)
        Me.grpBColors.Controls.Add(Me.butAddBColor)
        Me.grpBColors.Controls.Add(Me.chkBColorFormName)
        Me.grpBColors.Controls.Add(Me.txtBColorNameForm)
        Me.grpBColors.Controls.Add(Me.lbBColorNameForm)
        Me.grpBColors.Controls.Add(Me.lsvBColors)
        Me.grpBColors.Controls.Add(Me.butSearchBColorForm)
        Me.grpBColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpBColors.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpBColors.Location = New System.Drawing.Point(6, 6)
        Me.grpBColors.Name = "grpBColors"
        Me.grpBColors.Size = New System.Drawing.Size(1159, 662)
        Me.grpBColors.TabIndex = 67
        Me.grpBColors.TabStop = false
        Me.grpBColors.Text = "BColors"
        '
        'chkBColorFormNameAlt2
        '
        Me.chkBColorFormNameAlt2.AutoSize = true
        Me.chkBColorFormNameAlt2.Checked = true
        Me.chkBColorFormNameAlt2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormNameAlt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkBColorFormNameAlt2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormNameAlt2.Location = New System.Drawing.Point(363, 132)
        Me.chkBColorFormNameAlt2.Name = "chkBColorFormNameAlt2"
        Me.chkBColorFormNameAlt2.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormNameAlt2.TabIndex = 164
        Me.chkBColorFormNameAlt2.Text = "Contains"
        Me.chkBColorFormNameAlt2.UseVisualStyleBackColor = true
        '
        'txtBColorNameFormAlt2
        '
        Me.txtBColorNameFormAlt2.Location = New System.Drawing.Point(170, 130)
        Me.txtBColorNameFormAlt2.Name = "txtBColorNameFormAlt2"
        Me.txtBColorNameFormAlt2.Size = New System.Drawing.Size(187, 23)
        Me.txtBColorNameFormAlt2.TabIndex = 162
        '
        'Label34
        '
        Me.Label34.AutoSize = true
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(16, 130)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(130, 15)
        Me.Label34.TabIndex = 163
        Me.Label34.Text = "Alt. BColor name 2:"
        '
        'pctBColorRGB
        '
        Me.pctBColorRGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctBColorRGB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctBColorRGB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctBColorRGB.Location = New System.Drawing.Point(233, 309)
        Me.pctBColorRGB.Name = "pctBColorRGB"
        Me.pctBColorRGB.Size = New System.Drawing.Size(101, 80)
        Me.pctBColorRGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBColorRGB.TabIndex = 161
        Me.pctBColorRGB.TabStop = false
        '
        'txtMasseVolumiqueExt
        '
        Me.txtMasseVolumiqueExt.Location = New System.Drawing.Point(170, 235)
        Me.txtMasseVolumiqueExt.Name = "txtMasseVolumiqueExt"
        Me.txtMasseVolumiqueExt.Size = New System.Drawing.Size(187, 23)
        Me.txtMasseVolumiqueExt.TabIndex = 159
        '
        'Label29
        '
        Me.Label29.AutoSize = true
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(15, 235)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(153, 15)
        Me.Label29.TabIndex = 160
        Me.Label29.Text = "Ext. Masse Volumique:"
        '
        'chkBColorFormNameAlt
        '
        Me.chkBColorFormNameAlt.AutoSize = true
        Me.chkBColorFormNameAlt.Checked = true
        Me.chkBColorFormNameAlt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormNameAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkBColorFormNameAlt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormNameAlt.Location = New System.Drawing.Point(363, 103)
        Me.chkBColorFormNameAlt.Name = "chkBColorFormNameAlt"
        Me.chkBColorFormNameAlt.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormNameAlt.TabIndex = 158
        Me.chkBColorFormNameAlt.Text = "Contains"
        Me.chkBColorFormNameAlt.UseVisualStyleBackColor = true
        '
        'txtBColorNameFormAlt
        '
        Me.txtBColorNameFormAlt.Location = New System.Drawing.Point(170, 101)
        Me.txtBColorNameFormAlt.Name = "txtBColorNameFormAlt"
        Me.txtBColorNameFormAlt.Size = New System.Drawing.Size(187, 23)
        Me.txtBColorNameFormAlt.TabIndex = 156
        '
        'lbBColorNameFormAlt
        '
        Me.lbBColorNameFormAlt.AutoSize = true
        Me.lbBColorNameFormAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbBColorNameFormAlt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbBColorNameFormAlt.Location = New System.Drawing.Point(16, 101)
        Me.lbBColorNameFormAlt.Name = "lbBColorNameFormAlt"
        Me.lbBColorNameFormAlt.Size = New System.Drawing.Size(118, 15)
        Me.lbBColorNameFormAlt.TabIndex = 157
        Me.lbBColorNameFormAlt.Text = "Alt. BColor name:"
        '
        'butReportAll
        '
        Me.butReportAll.BackColor = System.Drawing.SystemColors.Control
        Me.butReportAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butReportAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.butReportAll.Location = New System.Drawing.Point(448, 106)
        Me.butReportAll.Name = "butReportAll"
        Me.butReportAll.Size = New System.Drawing.Size(113, 89)
        Me.butReportAll.TabIndex = 155
        Me.butReportAll.Text = "Report all basic colors"
        Me.butReportAll.UseVisualStyleBackColor = false
        '
        'butClearBColor
        '
        Me.butClearBColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.butClearBColor.BackColor = System.Drawing.SystemColors.Control
        Me.butClearBColor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butClearBColor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClearBColor.Location = New System.Drawing.Point(1040, 22)
        Me.butClearBColor.Name = "butClearBColor"
        Me.butClearBColor.Size = New System.Drawing.Size(113, 79)
        Me.butClearBColor.TabIndex = 154
        Me.butClearBColor.Text = "Clear"
        Me.butClearBColor.UseVisualStyleBackColor = false
        '
        'txtMasseVolumique
        '
        Me.txtMasseVolumique.Location = New System.Drawing.Point(170, 201)
        Me.txtMasseVolumique.Name = "txtMasseVolumique"
        Me.txtMasseVolumique.Size = New System.Drawing.Size(187, 23)
        Me.txtMasseVolumique.TabIndex = 131
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(15, 201)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 15)
        Me.Label25.TabIndex = 132
        Me.Label25.Text = "Masse Volumique:"
        '
        'cmbUnit
        '
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FormattingEnabled = true
        Me.cmbUnit.Items.AddRange(New Object() {"2.5L", "Gallon", "Liter", "500ML"})
        Me.cmbUnit.Location = New System.Drawing.Point(343, 162)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(96, 24)
        Me.cmbUnit.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(324, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "/"
        '
        'chkBColorFormCode
        '
        Me.chkBColorFormCode.AutoSize = true
        Me.chkBColorFormCode.Checked = true
        Me.chkBColorFormCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkBColorFormCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormCode.Location = New System.Drawing.Point(363, 45)
        Me.chkBColorFormCode.Name = "chkBColorFormCode"
        Me.chkBColorFormCode.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormCode.TabIndex = 121
        Me.chkBColorFormCode.Text = "Contains"
        Me.chkBColorFormCode.UseVisualStyleBackColor = true
        '
        'txtBColorCodeForm
        '
        Me.txtBColorCodeForm.Location = New System.Drawing.Point(170, 43)
        Me.txtBColorCodeForm.Name = "txtBColorCodeForm"
        Me.txtBColorCodeForm.Size = New System.Drawing.Size(187, 23)
        Me.txtBColorCodeForm.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(16, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 15)
        Me.Label21.TabIndex = 119
        Me.Label21.Text = "BColor code:"
        '
        'txtfnamehideenColor
        '
        Me.txtfnamehideenColor.Location = New System.Drawing.Point(343, 270)
        Me.txtfnamehideenColor.Name = "txtfnamehideenColor"
        Me.txtfnamehideenColor.ReadOnly = true
        Me.txtfnamehideenColor.Size = New System.Drawing.Size(101, 23)
        Me.txtfnamehideenColor.TabIndex = 118
        Me.txtfnamehideenColor.Visible = false
        '
        'butFindBColorImg
        '
        Me.butFindBColorImg.BackColor = System.Drawing.SystemColors.Control
        Me.butFindBColorImg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butFindBColorImg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butFindBColorImg.Location = New System.Drawing.Point(302, 270)
        Me.butFindBColorImg.Name = "butFindBColorImg"
        Me.butFindBColorImg.Size = New System.Drawing.Size(35, 23)
        Me.butFindBColorImg.TabIndex = 117
        Me.butFindBColorImg.Text = " -- "
        Me.butFindBColorImg.UseVisualStyleBackColor = false
        '
        'txtBColorImgPath
        '
        Me.txtBColorImgPath.Location = New System.Drawing.Point(138, 270)
        Me.txtBColorImgPath.Name = "txtBColorImgPath"
        Me.txtBColorImgPath.ReadOnly = true
        Me.txtBColorImgPath.Size = New System.Drawing.Size(154, 23)
        Me.txtBColorImgPath.TabIndex = 116
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(16, 270)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 15)
        Me.Label17.TabIndex = 115
        Me.Label17.Text = "Color:"
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(16, 320)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 15)
        Me.Label16.TabIndex = 114
        Me.Label16.Text = "Thumbnail:"
        '
        'pctBColorImg
        '
        Me.pctBColorImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctBColorImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctBColorImg.Location = New System.Drawing.Point(126, 309)
        Me.pctBColorImg.Name = "pctBColorImg"
        Me.pctBColorImg.Size = New System.Drawing.Size(101, 80)
        Me.pctBColorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBColorImg.TabIndex = 113
        Me.pctBColorImg.TabStop = false
        '
        'txtPriceBcolorForm
        '
        Me.txtPriceBcolorForm.Location = New System.Drawing.Point(170, 162)
        Me.txtPriceBcolorForm.Name = "txtPriceBcolorForm"
        Me.txtPriceBcolorForm.Size = New System.Drawing.Size(149, 23)
        Me.txtPriceBcolorForm.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(16, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 15)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "Price per unit:"
        '
        'lbCurrencyDetailsValue2
        '
        Me.lbCurrencyDetailsValue2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbCurrencyDetailsValue2.AutoSize = true
        Me.lbCurrencyDetailsValue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbCurrencyDetailsValue2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbCurrencyDetailsValue2.Location = New System.Drawing.Point(997, 53)
        Me.lbCurrencyDetailsValue2.Name = "lbCurrencyDetailsValue2"
        Me.lbCurrencyDetailsValue2.Size = New System.Drawing.Size(21, 15)
        Me.lbCurrencyDetailsValue2.TabIndex = 110
        Me.lbCurrencyDetailsValue2.Text = "- -"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(924, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 15)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = "Currency:"
        '
        'butDeleteBColorForm
        '
        Me.butDeleteBColorForm.BackColor = System.Drawing.SystemColors.Control
        Me.butDeleteBColorForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butDeleteBColorForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butDeleteBColorForm.Location = New System.Drawing.Point(686, 22)
        Me.butDeleteBColorForm.Name = "butDeleteBColorForm"
        Me.butDeleteBColorForm.Size = New System.Drawing.Size(113, 78)
        Me.butDeleteBColorForm.TabIndex = 77
        Me.butDeleteBColorForm.Text = "Delete Selected"
        Me.butDeleteBColorForm.UseVisualStyleBackColor = false
        '
        'lbIdBColorForm
        '
        Me.lbIdBColorForm.AutoSize = true
        Me.lbIdBColorForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbIdBColorForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdBColorForm.Location = New System.Drawing.Point(16, 174)
        Me.lbIdBColorForm.Name = "lbIdBColorForm"
        Me.lbIdBColorForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdBColorForm.TabIndex = 76
        Me.lbIdBColorForm.Text = "-1"
        Me.lbIdBColorForm.Visible = false
        '
        'butEditBColorForm
        '
        Me.butEditBColorForm.BackColor = System.Drawing.SystemColors.Control
        Me.butEditBColorForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butEditBColorForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butEditBColorForm.Location = New System.Drawing.Point(567, 22)
        Me.butEditBColorForm.Name = "butEditBColorForm"
        Me.butEditBColorForm.Size = New System.Drawing.Size(113, 78)
        Me.butEditBColorForm.TabIndex = 75
        Me.butEditBColorForm.Text = "Edit Selected"
        Me.butEditBColorForm.UseVisualStyleBackColor = false
        '
        'butAddBColor
        '
        Me.butAddBColor.BackColor = System.Drawing.SystemColors.Control
        Me.butAddBColor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butAddBColor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddBColor.Location = New System.Drawing.Point(448, 22)
        Me.butAddBColor.Name = "butAddBColor"
        Me.butAddBColor.Size = New System.Drawing.Size(113, 78)
        Me.butAddBColor.TabIndex = 71
        Me.butAddBColor.Text = "Add New"
        Me.butAddBColor.UseVisualStyleBackColor = false
        '
        'chkBColorFormName
        '
        Me.chkBColorFormName.AutoSize = true
        Me.chkBColorFormName.Checked = true
        Me.chkBColorFormName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkBColorFormName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormName.Location = New System.Drawing.Point(363, 74)
        Me.chkBColorFormName.Name = "chkBColorFormName"
        Me.chkBColorFormName.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormName.TabIndex = 70
        Me.chkBColorFormName.Text = "Contains"
        Me.chkBColorFormName.UseVisualStyleBackColor = true
        '
        'txtBColorNameForm
        '
        Me.txtBColorNameForm.Location = New System.Drawing.Point(170, 72)
        Me.txtBColorNameForm.Name = "txtBColorNameForm"
        Me.txtBColorNameForm.Size = New System.Drawing.Size(187, 23)
        Me.txtBColorNameForm.TabIndex = 11
        '
        'lbBColorNameForm
        '
        Me.lbBColorNameForm.AutoSize = true
        Me.lbBColorNameForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbBColorNameForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbBColorNameForm.Location = New System.Drawing.Point(16, 72)
        Me.lbBColorNameForm.Name = "lbBColorNameForm"
        Me.lbBColorNameForm.Size = New System.Drawing.Size(94, 15)
        Me.lbBColorNameForm.TabIndex = 68
        Me.lbBColorNameForm.Text = "BColor name:"
        '
        'lsvBColors
        '
        Me.lsvBColors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lsvBColors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidBColor, Me.ColumnHeader2, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader9, Me.ColumnHeader14})
        Me.lsvBColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lsvBColors.FullRowSelect = true
        Me.lsvBColors.GridLines = true
        Me.lsvBColors.HideSelection = false
        Me.lsvBColors.Location = New System.Drawing.Point(8, 395)
        Me.lsvBColors.MultiSelect = false
        Me.lsvBColors.Name = "lsvBColors"
        Me.lsvBColors.Size = New System.Drawing.Size(1145, 250)
        Me.lsvBColors.TabIndex = 55
        Me.lsvBColors.UseCompatibleStateImageBehavior = false
        Me.lsvBColors.View = System.Windows.Forms.View.Details
        '
        'cidBColor
        '
        Me.cidBColor.Tag = "cidBColor"
        Me.cidBColor.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Code"
        Me.ColumnHeader2.Width = 104
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Name"
        Me.ColumnHeader10.Width = 206
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Price"
        Me.ColumnHeader11.Width = 300
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Currency"
        Me.ColumnHeader12.Width = 94
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Unit"
        Me.ColumnHeader13.Width = 91
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Masse Volumique"
        Me.ColumnHeader9.Width = 147
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Masse Volumique ext"
        Me.ColumnHeader14.Width = 190
        '
        'butSearchBColorForm
        '
        Me.butSearchBColorForm.BackColor = System.Drawing.SystemColors.Control
        Me.butSearchBColorForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butSearchBColorForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSearchBColorForm.Location = New System.Drawing.Point(805, 22)
        Me.butSearchBColorForm.Name = "butSearchBColorForm"
        Me.butSearchBColorForm.Size = New System.Drawing.Size(113, 78)
        Me.butSearchBColorForm.TabIndex = 9
        Me.butSearchBColorForm.Text = "Find"
        Me.butSearchBColorForm.UseVisualStyleBackColor = false
        '
        'tbUpdate
        '
        Me.tbUpdate.Controls.Add(Me.GroupBox3)
        Me.tbUpdate.Location = New System.Drawing.Point(4, 25)
        Me.tbUpdate.Name = "tbUpdate"
        Me.tbUpdate.Padding = New System.Windows.Forms.Padding(3)
        Me.tbUpdate.Size = New System.Drawing.Size(1187, 657)
        Me.tbUpdate.TabIndex = 5
        Me.tbUpdate.Text = "Update"
        Me.tbUpdate.UseVisualStyleBackColor = true
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.butClearUpdate)
        Me.GroupBox3.Controls.Add(Me.butBrowseUpdate)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtUpdatePath)
        Me.GroupBox3.Controls.Add(Me.butUpdateFile)
        Me.GroupBox3.Location = New System.Drawing.Point(202, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(702, 187)
        Me.GroupBox3.TabIndex = 89
        Me.GroupBox3.TabStop = false
        '
        'butClearUpdate
        '
        Me.butClearUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.butClearUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.butClearUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butClearUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClearUpdate.Location = New System.Drawing.Point(583, 116)
        Me.butClearUpdate.Name = "butClearUpdate"
        Me.butClearUpdate.Size = New System.Drawing.Size(113, 57)
        Me.butClearUpdate.TabIndex = 155
        Me.butClearUpdate.Text = "Clear"
        Me.butClearUpdate.UseVisualStyleBackColor = false
        '
        'butBrowseUpdate
        '
        Me.butBrowseUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.butBrowseUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.butBrowseUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butBrowseUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butBrowseUpdate.Location = New System.Drawing.Point(659, 18)
        Me.butBrowseUpdate.Name = "butBrowseUpdate"
        Me.butBrowseUpdate.Size = New System.Drawing.Size(37, 26)
        Me.butBrowseUpdate.TabIndex = 88
        Me.butBrowseUpdate.Text = "--"
        Me.butBrowseUpdate.UseVisualStyleBackColor = false
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(13, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 15)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Folder Path:"
        '
        'txtUpdatePath
        '
        Me.txtUpdatePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtUpdatePath.Location = New System.Drawing.Point(104, 18)
        Me.txtUpdatePath.Name = "txtUpdatePath"
        Me.txtUpdatePath.ReadOnly = true
        Me.txtUpdatePath.Size = New System.Drawing.Size(549, 23)
        Me.txtUpdatePath.TabIndex = 86
        '
        'butUpdateFile
        '
        Me.butUpdateFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.butUpdateFile.BackColor = System.Drawing.SystemColors.Control
        Me.butUpdateFile.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butUpdateFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butUpdateFile.Location = New System.Drawing.Point(215, 117)
        Me.butUpdateFile.Name = "butUpdateFile"
        Me.butUpdateFile.Size = New System.Drawing.Size(303, 57)
        Me.butUpdateFile.TabIndex = 85
        Me.butUpdateFile.Text = "Generate Update File"
        Me.butUpdateFile.UseVisualStyleBackColor = false
        '
        'butExit
        '
        Me.butExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.butExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.butExit.Location = New System.Drawing.Point(1134, 715)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(73, 26)
        Me.butExit.TabIndex = 62
        Me.butExit.Text = "Exit"
        Me.butExit.UseVisualStyleBackColor = true
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1219, 24)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.MobileSyncToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(38, 20)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripMenuItem2.Text = "&Exit"
        '
        'MobileSyncToolStripMenuItem
        '
        Me.MobileSyncToolStripMenuItem.Name = "MobileSyncToolStripMenuItem"
        Me.MobileSyncToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MobileSyncToolStripMenuItem.Text = "&Mobile Sync"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(71, 20)
        Me.ToolStripMenuItem3.Text = "&Settings"
        '
        'fileDialogCar
        '
        Me.fileDialogCar.FileName = " "
        '
        'fileDialogBColor
        '
        Me.fileDialogBColor.FileName = " "
        '
        'fileDialogGarage
        '
        Me.fileDialogGarage.FileName = " "
        '
        'prgBar
        '
        Me.prgBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.prgBar.Location = New System.Drawing.Point(12, 718)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(1111, 23)
        Me.prgBar.TabIndex = 63
        Me.prgBar.Visible = false
        '
        'rdApply1
        '
        Me.rdApply1.AutoSize = true
        Me.rdApply1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rdApply1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdApply1.Location = New System.Drawing.Point(81, 12)
        Me.rdApply1.Name = "rdApply1"
        Me.rdApply1.Size = New System.Drawing.Size(109, 17)
        Me.rdApply1.TabIndex = 9
        Me.rdApply1.TabStop = true
        Me.rdApply1.Text = "Apply equation"
        Me.rdApply1.UseVisualStyleBackColor = true
        '
        'HeadQHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 742)
        Me.Controls.Add(Me.prgBar)
        Me.Controls.Add(Me.butExit)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.tbTabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1235, 726)
        Me.Name = "HeadQHome"
        Me.Text = "HeadQuarters"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbTabs.ResumeLayout(false)
        Me.tbFormulas.ResumeLayout(false)
        Me.grpFormulas.ResumeLayout(false)
        Me.grpFormulas.PerformLayout
        Me.grpXY.ResumeLayout(false)
        Me.grpXY.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.tbCars.ResumeLayout(false)
        Me.grpCars.ResumeLayout(false)
        Me.grpCars.PerformLayout
        CType(Me.pctCarImg,System.ComponentModel.ISupportInitialize).EndInit
        Me.tbLanguage.ResumeLayout(false)
        Me.grpLanguageForm.ResumeLayout(false)
        Me.grpLanguageForm.PerformLayout
        Me.tbGarages.ResumeLayout(false)
        Me.grpGarageForm.ResumeLayout(false)
        Me.grpGarageForm.PerformLayout
        Me.GroupBox7.ResumeLayout(false)
        Me.GroupBox7.PerformLayout
        Me.GroupBox6.ResumeLayout(false)
        Me.GroupBox6.PerformLayout
        CType(Me.pctThemeColor,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox5.ResumeLayout(false)
        Me.GroupBox5.PerformLayout
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.grpradio.ResumeLayout(false)
        Me.grpradio.PerformLayout
        CType(Me.pctGarageImg,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.tbColors.ResumeLayout(false)
        Me.grpBColors.ResumeLayout(false)
        Me.grpBColors.PerformLayout
        CType(Me.pctBColorRGB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pctBColorImg,System.ComponentModel.ISupportInitialize).EndInit
        Me.tbUpdate.ResumeLayout(false)
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.MenuStrip2.ResumeLayout(false)
        Me.MenuStrip2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents tbTabs As System.Windows.Forms.TabControl
    Friend WithEvents tbFormulas As System.Windows.Forms.TabPage
    Friend WithEvents tbCars As System.Windows.Forms.TabPage
    Friend WithEvents butExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdAny As System.Windows.Forms.RadioButton
    Friend WithEvents rdBC As System.Windows.Forms.RadioButton
    Friend WithEvents rd2k As System.Windows.Forms.RadioButton
    Friend WithEvents lsvFamily As MyListView
    Friend WithEvents cctype As System.Windows.Forms.ColumnHeader
    Friend WithEvents cversion As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpFormulas As System.Windows.Forms.GroupBox
    Friend WithEvents chkFormulaName As System.Windows.Forms.CheckBox
    Friend WithEvents txtFormulaName As MyTextBox
    Friend WithEvents lbFormulaName As System.Windows.Forms.Label
    Friend WithEvents butGo As System.Windows.Forms.Button
    Friend WithEvents tbLanguage As System.Windows.Forms.TabPage
    Friend WithEvents tbGarages As System.Windows.Forms.TabPage
    Friend WithEvents tbColors As System.Windows.Forms.TabPage
    Friend WithEvents tbUpdate As System.Windows.Forms.TabPage
    Friend WithEvents lbCurrencyDetailsValue As System.Windows.Forms.Label
    Friend WithEvents lbCurrencyDetails As System.Windows.Forms.Label
    Friend WithEvents grpCars As System.Windows.Forms.GroupBox
    Friend WithEvents butAddCar As System.Windows.Forms.Button
    Friend WithEvents chkCarFormName As System.Windows.Forms.CheckBox
    Friend WithEvents txtCarNameForm As MyTextBox
    Friend WithEvents lbCarNameForm As System.Windows.Forms.Label
    Friend WithEvents lsvCars As MyListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butSearchCarForm As System.Windows.Forms.Button
    Friend WithEvents lbIdCarForm As System.Windows.Forms.Label
    Friend WithEvents butEditCarForm As System.Windows.Forms.Button
    Friend WithEvents cidcar As System.Windows.Forms.ColumnHeader
    Friend WithEvents butDeleteCarForm As System.Windows.Forms.Button
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpLanguageForm As System.Windows.Forms.GroupBox
    Friend WithEvents butDeleteLangForm As System.Windows.Forms.Button
    Friend WithEvents lbIdLanguageForm As System.Windows.Forms.Label
    Friend WithEvents butEditLangForm As System.Windows.Forms.Button
    Friend WithEvents chkLanguageLabelForm As System.Windows.Forms.CheckBox
    Friend WithEvents txtLanguageLabelForm As MyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents butAddLang As System.Windows.Forms.Button
    Friend WithEvents chkLanguageFormCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtLanguageCodeForm As MyTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lsvLanguage As MyListView
    Friend WithEvents cidLang As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butSearchLangForm As System.Windows.Forms.Button
    Friend WithEvents grpGarageForm As System.Windows.Forms.GroupBox
    Friend WithEvents butFindLang As System.Windows.Forms.Button
    Friend WithEvents lbIdLanguage As System.Windows.Forms.Label
    Friend WithEvents txtLanguage As MyTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkGarageRespForm As System.Windows.Forms.CheckBox
    Friend WithEvents txtGarageRespform As MyTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents butDeleteGarageForm As System.Windows.Forms.Button
    Friend WithEvents lbIdGarageForm As System.Windows.Forms.Label
    Friend WithEvents butEditGarageForm As System.Windows.Forms.Button
    Friend WithEvents chkGarageLocationForm As System.Windows.Forms.CheckBox
    Friend WithEvents txtGarageLocationForm As MyTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents butAddGarage As System.Windows.Forms.Button
    Friend WithEvents chkGarageFormCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtGarageNameForm As MyTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lsvGarage As MyListView
    Friend WithEvents cidGarage As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butSearchGarageForm As System.Windows.Forms.Button
    Friend WithEvents cidlanggarage As System.Windows.Forms.ColumnHeader
    Friend WithEvents butInstall As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpBColors As System.Windows.Forms.GroupBox
    Friend WithEvents txtPriceBcolorForm As MyTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbCurrencyDetailsValue2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents butDeleteBColorForm As System.Windows.Forms.Button
    Friend WithEvents lbIdBColorForm As System.Windows.Forms.Label
    Friend WithEvents butEditBColorForm As System.Windows.Forms.Button
    Friend WithEvents butAddBColor As System.Windows.Forms.Button
    Friend WithEvents chkBColorFormName As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorNameForm As MyTextBox
    Friend WithEvents lbBColorNameForm As System.Windows.Forms.Label
    Friend WithEvents lsvBColors As MyListView
    Friend WithEvents cidBColor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butSearchBColorForm As System.Windows.Forms.Button
    Friend WithEvents butAddNewFormula As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGarageDirectory As MyTextBox
    Friend WithEvents FBrowserGarage As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents butBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents butBrowseUpdate As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtUpdatePath As MyTextBox
    Friend WithEvents butUpdateFile As System.Windows.Forms.Button
    Friend WithEvents FBrowserUpdate As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtCarImgPath As HeadQApplication.MyTextBox
    Friend WithEvents lbCarImgPath As System.Windows.Forms.Label
    Friend WithEvents butFindCarImg As System.Windows.Forms.Button
    Friend WithEvents fileDialogCar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pctCarImg As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtfnamehideen As HeadQApplication.MyTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents pctBColorImg As System.Windows.Forms.PictureBox
    Friend WithEvents butFindBColorImg As System.Windows.Forms.Button
    Friend WithEvents txtBColorImgPath As HeadQApplication.MyTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents fileDialogBColor As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtfnamehideenColor As HeadQApplication.MyTextBox
    Friend WithEvents butFindGarageImg As System.Windows.Forms.Button
    Friend WithEvents txtGarageImgPath As HeadQApplication.MyTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtfnamegaragehidden As HeadQApplication.MyTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents pctGarageImg As System.Windows.Forms.PictureBox
    Friend WithEvents fileDialogGarage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chkColorCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtColorCode As HeadQApplication.MyTextBox
    Friend WithEvents lbColorCode As System.Windows.Forms.Label
    Friend WithEvents butEditColor As System.Windows.Forms.Button
    Friend WithEvents chkBColorFormCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorCodeForm As HeadQApplication.MyTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbCarNameSearch As System.Windows.Forms.ComboBox
    Friend WithEvents lbCarIdSearch As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Friend WithEvents ccname As System.Windows.Forms.ColumnHeader
    Friend WithEvents ccode As System.Windows.Forms.ColumnHeader
    Friend WithEvents cyear As System.Windows.Forms.ColumnHeader
    Friend WithEvents cformulaId As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtYearMax As HeadQApplication.MyTextBox
    Friend WithEvents txtYearMin As HeadQApplication.MyTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ccarname As System.Windows.Forms.ColumnHeader
    Friend WithEvents cclCar As System.Windows.Forms.Button
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtYearSpec As HeadQApplication.MyTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents grpXY As System.Windows.Forms.GroupBox
    Friend WithEvents butSaveAssign As System.Windows.Forms.Button
    Friend WithEvents butAssignY As System.Windows.Forms.Button
    Friend WithEvents butAssignX As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents butCancelY As System.Windows.Forms.Button
    Friend WithEvents butCancelX As System.Windows.Forms.Button
    Friend WithEvents lbSelectedXYZ As System.Windows.Forms.Label
    Friend WithEvents cappequation As System.Windows.Forms.ColumnHeader
    Friend WithEvents butCancelAss As System.Windows.Forms.Button
    Friend WithEvents chkCardNumber As System.Windows.Forms.CheckBox
    Friend WithEvents txtCardNumber As HeadQApplication.MyTextBox
    Friend WithEvents lbCardNumber As System.Windows.Forms.Label
    Friend WithEvents ccardNbr As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtMasseVolumique As HeadQApplication.MyTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butDelete As System.Windows.Forms.Button
    Friend WithEvents butClear As System.Windows.Forms.Button
    Friend WithEvents butClearCars As System.Windows.Forms.Button
    Friend WithEvents butClearLang As System.Windows.Forms.Button
    Friend WithEvents butClearGarage As System.Windows.Forms.Button
    Friend WithEvents butClearBColor As System.Windows.Forms.Button
    Friend WithEvents butClearUpdate As System.Windows.Forms.Button
    Friend WithEvents butCancelZ As System.Windows.Forms.Button
    Friend WithEvents butAssignZ As System.Windows.Forms.Button
    Friend WithEvents lbformulaZ As System.Windows.Forms.Label
    Friend WithEvents butAssignZ2p As System.Windows.Forms.Button
    Friend WithEvents butAssignZp As System.Windows.Forms.Button
    Friend WithEvents butAssignY2p As System.Windows.Forms.Button
    Friend WithEvents butAssignYp As System.Windows.Forms.Button
    Friend WithEvents butAssignX2p As System.Windows.Forms.Button
    Friend WithEvents butAssignXp As System.Windows.Forms.Button
    Friend WithEvents ToolTipVariant As System.Windows.Forms.ToolTip
    Friend WithEvents lbCountFormulas As System.Windows.Forms.Label
    Friend WithEvents butExcel As System.Windows.Forms.Button
    Friend WithEvents fldExcelDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents prgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents txtBasicColor As HeadQApplication.MyTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents grpradio As System.Windows.Forms.GroupBox
    Friend WithEvents rdApply0 As System.Windows.Forms.RadioButton
    Friend WithEvents lbAttention As System.Windows.Forms.Label
    Friend WithEvents chkversion As System.Windows.Forms.CheckBox
    Friend WithEvents txtversion As HeadQApplication.MyTextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cgversion As System.Windows.Forms.ColumnHeader
    Friend WithEvents rdLS As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdGarage2k As System.Windows.Forms.RadioButton
    Friend WithEvents rdGarageLS As System.Windows.Forms.RadioButton
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cgcoat As System.Windows.Forms.ColumnHeader
    Friend WithEvents butReportAll As System.Windows.Forms.Button
    Friend WithEvents chkBColorFormNameAlt As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorNameFormAlt As HeadQApplication.MyTextBox
    Friend WithEvents lbBColorNameFormAlt As System.Windows.Forms.Label
    Friend WithEvents txtMasseVolumiqueExt As HeadQApplication.MyTextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkkey As System.Windows.Forms.CheckBox
    Friend WithEvents txtkey As HeadQApplication.MyTextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents chktel As System.Windows.Forms.CheckBox
    Friend WithEvents txttel As HeadQApplication.MyTextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents pctBColorRGB As System.Windows.Forms.PictureBox
    Friend WithEvents dlgBasicColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents butBrowseDb As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtDBDirectory As HeadQApplication.MyTextBox
    Friend WithEvents butInstallMobile As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents pctThemeColor As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdShowAltNone As System.Windows.Forms.RadioButton
    Friend WithEvents rdShowAlternative As System.Windows.Forms.RadioButton
    Friend WithEvents rdShowAlternative2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkBColorFormNameAlt2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorNameFormAlt2 As HeadQApplication.MyTextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents chkUsername As System.Windows.Forms.CheckBox
    Friend WithEvents txtusername As HeadQApplication.MyTextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents MobileSyncToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents butNegativeQty As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents butBrowseHqDirectory As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtHqDirectory As HeadQApplication.MyTextBox
    Friend WithEvents butConvertToHQ As System.Windows.Forms.Button
    Friend WithEvents lbHqConversionProgress As System.Windows.Forms.Label
    Friend WithEvents cmodcredate As System.Windows.Forms.ColumnHeader
    Friend WithEvents rdApply1 As System.Windows.Forms.RadioButton
End Class
