<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colorsEditSync
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(colorsEditSync))
        Me.grpColorForm = New System.Windows.Forms.GroupBox()
        Me.chkBColorFormNameAlt2 = New System.Windows.Forms.CheckBox()
        Me.txtBColorNameFormAlt2 = New HeadQApplication.MyTextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.pctBColorRGB = New System.Windows.Forms.PictureBox()
        Me.txtMasseVolumiqueExt = New HeadQApplication.MyTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.chkBColorFormNameAlt = New System.Windows.Forms.CheckBox()
        Me.txtBColorNameFormAlt = New HeadQApplication.MyTextBox()
        Me.lbBColorNameFormAlt = New System.Windows.Forms.Label()
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
        Me.lbIdBColorForm = New System.Windows.Forms.Label()
        Me.chkBColorFormName = New System.Windows.Forms.CheckBox()
        Me.txtBColorNameForm = New HeadQApplication.MyTextBox()
        Me.lbBColorNameForm = New System.Windows.Forms.Label()
        Me.lsvBColors = New HeadQApplication.MyListView()
        Me.cidBColor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.butRemoveFromSync = New System.Windows.Forms.Button()
        Me.butListSelected = New System.Windows.Forms.Button()
        Me.butSelectAll = New System.Windows.Forms.Button()
        Me.butAddToSync = New System.Windows.Forms.Button()
        Me.ButGoBack = New System.Windows.Forms.Button()
        Me.butClearGarage = New System.Windows.Forms.Button()
        Me.butSearchBColorForm = New System.Windows.Forms.Button()
        Me.fileDialogColor = New System.Windows.Forms.OpenFileDialog()
        Me.grpColorForm.SuspendLayout()
        CType(Me.pctBColorRGB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBColorImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpColorForm
        '
        Me.grpColorForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpColorForm.BackColor = System.Drawing.Color.Transparent
        Me.grpColorForm.Controls.Add(Me.chkBColorFormNameAlt2)
        Me.grpColorForm.Controls.Add(Me.txtBColorNameFormAlt2)
        Me.grpColorForm.Controls.Add(Me.Label34)
        Me.grpColorForm.Controls.Add(Me.pctBColorRGB)
        Me.grpColorForm.Controls.Add(Me.txtMasseVolumiqueExt)
        Me.grpColorForm.Controls.Add(Me.Label29)
        Me.grpColorForm.Controls.Add(Me.chkBColorFormNameAlt)
        Me.grpColorForm.Controls.Add(Me.txtBColorNameFormAlt)
        Me.grpColorForm.Controls.Add(Me.lbBColorNameFormAlt)
        Me.grpColorForm.Controls.Add(Me.txtMasseVolumique)
        Me.grpColorForm.Controls.Add(Me.Label25)
        Me.grpColorForm.Controls.Add(Me.cmbUnit)
        Me.grpColorForm.Controls.Add(Me.Label4)
        Me.grpColorForm.Controls.Add(Me.chkBColorFormCode)
        Me.grpColorForm.Controls.Add(Me.txtBColorCodeForm)
        Me.grpColorForm.Controls.Add(Me.Label21)
        Me.grpColorForm.Controls.Add(Me.txtfnamehideenColor)
        Me.grpColorForm.Controls.Add(Me.butFindBColorImg)
        Me.grpColorForm.Controls.Add(Me.txtBColorImgPath)
        Me.grpColorForm.Controls.Add(Me.Label17)
        Me.grpColorForm.Controls.Add(Me.Label16)
        Me.grpColorForm.Controls.Add(Me.pctBColorImg)
        Me.grpColorForm.Controls.Add(Me.txtPriceBcolorForm)
        Me.grpColorForm.Controls.Add(Me.Label11)
        Me.grpColorForm.Controls.Add(Me.lbIdBColorForm)
        Me.grpColorForm.Controls.Add(Me.chkBColorFormName)
        Me.grpColorForm.Controls.Add(Me.txtBColorNameForm)
        Me.grpColorForm.Controls.Add(Me.lbBColorNameForm)
        Me.grpColorForm.Controls.Add(Me.lsvBColors)
        Me.grpColorForm.Controls.Add(Me.butRemoveFromSync)
        Me.grpColorForm.Controls.Add(Me.butListSelected)
        Me.grpColorForm.Controls.Add(Me.butSelectAll)
        Me.grpColorForm.Controls.Add(Me.butAddToSync)
        Me.grpColorForm.Controls.Add(Me.ButGoBack)
        Me.grpColorForm.Controls.Add(Me.butClearGarage)
        Me.grpColorForm.Controls.Add(Me.butSearchBColorForm)
        Me.grpColorForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpColorForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grpColorForm.Location = New System.Drawing.Point(13, 9)
        Me.grpColorForm.Name = "grpColorForm"
        Me.grpColorForm.Size = New System.Drawing.Size(1140, 721)
        Me.grpColorForm.TabIndex = 71
        Me.grpColorForm.TabStop = False
        Me.grpColorForm.Text = "Colors - Edit Sync"
        '
        'chkBColorFormNameAlt2
        '
        Me.chkBColorFormNameAlt2.AutoSize = True
        Me.chkBColorFormNameAlt2.Checked = True
        Me.chkBColorFormNameAlt2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormNameAlt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBColorFormNameAlt2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormNameAlt2.Location = New System.Drawing.Point(315, 116)
        Me.chkBColorFormNameAlt2.Name = "chkBColorFormNameAlt2"
        Me.chkBColorFormNameAlt2.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormNameAlt2.TabIndex = 208
        Me.chkBColorFormNameAlt2.Text = "Contains"
        Me.chkBColorFormNameAlt2.UseVisualStyleBackColor = True
        '
        'txtBColorNameFormAlt2
        '
        Me.txtBColorNameFormAlt2.Location = New System.Drawing.Point(160, 112)
        Me.txtBColorNameFormAlt2.Name = "txtBColorNameFormAlt2"
        Me.txtBColorNameFormAlt2.Size = New System.Drawing.Size(149, 23)
        Me.txtBColorNameFormAlt2.TabIndex = 206
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(6, 112)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(130, 15)
        Me.Label34.TabIndex = 207
        Me.Label34.Text = "Alt. BColor name 2:"
        '
        'pctBColorRGB
        '
        Me.pctBColorRGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctBColorRGB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctBColorRGB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctBColorRGB.Location = New System.Drawing.Point(223, 291)
        Me.pctBColorRGB.Name = "pctBColorRGB"
        Me.pctBColorRGB.Size = New System.Drawing.Size(101, 80)
        Me.pctBColorRGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBColorRGB.TabIndex = 205
        Me.pctBColorRGB.TabStop = False
        '
        'txtMasseVolumiqueExt
        '
        Me.txtMasseVolumiqueExt.Location = New System.Drawing.Point(160, 217)
        Me.txtMasseVolumiqueExt.Name = "txtMasseVolumiqueExt"
        Me.txtMasseVolumiqueExt.Size = New System.Drawing.Size(149, 23)
        Me.txtMasseVolumiqueExt.TabIndex = 203
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(5, 217)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(153, 15)
        Me.Label29.TabIndex = 204
        Me.Label29.Text = "Ext. Masse Volumique:"
        '
        'chkBColorFormNameAlt
        '
        Me.chkBColorFormNameAlt.AutoSize = True
        Me.chkBColorFormNameAlt.Checked = True
        Me.chkBColorFormNameAlt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormNameAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBColorFormNameAlt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormNameAlt.Location = New System.Drawing.Point(315, 87)
        Me.chkBColorFormNameAlt.Name = "chkBColorFormNameAlt"
        Me.chkBColorFormNameAlt.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormNameAlt.TabIndex = 202
        Me.chkBColorFormNameAlt.Text = "Contains"
        Me.chkBColorFormNameAlt.UseVisualStyleBackColor = True
        '
        'txtBColorNameFormAlt
        '
        Me.txtBColorNameFormAlt.Location = New System.Drawing.Point(160, 83)
        Me.txtBColorNameFormAlt.Name = "txtBColorNameFormAlt"
        Me.txtBColorNameFormAlt.Size = New System.Drawing.Size(149, 23)
        Me.txtBColorNameFormAlt.TabIndex = 200
        '
        'lbBColorNameFormAlt
        '
        Me.lbBColorNameFormAlt.AutoSize = True
        Me.lbBColorNameFormAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBColorNameFormAlt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbBColorNameFormAlt.Location = New System.Drawing.Point(6, 83)
        Me.lbBColorNameFormAlt.Name = "lbBColorNameFormAlt"
        Me.lbBColorNameFormAlt.Size = New System.Drawing.Size(118, 15)
        Me.lbBColorNameFormAlt.TabIndex = 201
        Me.lbBColorNameFormAlt.Text = "Alt. BColor name:"
        '
        'txtMasseVolumique
        '
        Me.txtMasseVolumique.Location = New System.Drawing.Point(160, 183)
        Me.txtMasseVolumique.Name = "txtMasseVolumique"
        Me.txtMasseVolumique.Size = New System.Drawing.Size(149, 23)
        Me.txtMasseVolumique.TabIndex = 198
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(5, 183)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 15)
        Me.Label25.TabIndex = 199
        Me.Label25.Text = "Masse Volumique:"
        '
        'cmbUnit
        '
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Items.AddRange(New Object() {"2.5L", "Gallon", "Liter", "500ML"})
        Me.cmbUnit.Location = New System.Drawing.Point(294, 144)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(96, 24)
        Me.cmbUnit.TabIndex = 183
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(275, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 197
        Me.Label4.Text = "/"
        '
        'chkBColorFormCode
        '
        Me.chkBColorFormCode.AutoSize = True
        Me.chkBColorFormCode.Checked = True
        Me.chkBColorFormCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBColorFormCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormCode.Location = New System.Drawing.Point(315, 29)
        Me.chkBColorFormCode.Name = "chkBColorFormCode"
        Me.chkBColorFormCode.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormCode.TabIndex = 196
        Me.chkBColorFormCode.Text = "Contains"
        Me.chkBColorFormCode.UseVisualStyleBackColor = True
        '
        'txtBColorCodeForm
        '
        Me.txtBColorCodeForm.Location = New System.Drawing.Point(160, 25)
        Me.txtBColorCodeForm.Name = "txtBColorCodeForm"
        Me.txtBColorCodeForm.Size = New System.Drawing.Size(149, 23)
        Me.txtBColorCodeForm.TabIndex = 180
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(6, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 15)
        Me.Label21.TabIndex = 195
        Me.Label21.Text = "BColor code:"
        '
        'txtfnamehideenColor
        '
        Me.txtfnamehideenColor.Location = New System.Drawing.Point(333, 252)
        Me.txtfnamehideenColor.Name = "txtfnamehideenColor"
        Me.txtfnamehideenColor.ReadOnly = True
        Me.txtfnamehideenColor.Size = New System.Drawing.Size(101, 23)
        Me.txtfnamehideenColor.TabIndex = 194
        Me.txtfnamehideenColor.Visible = False
        '
        'butFindBColorImg
        '
        Me.butFindBColorImg.BackColor = System.Drawing.SystemColors.Control
        Me.butFindBColorImg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butFindBColorImg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butFindBColorImg.Location = New System.Drawing.Point(292, 252)
        Me.butFindBColorImg.Name = "butFindBColorImg"
        Me.butFindBColorImg.Size = New System.Drawing.Size(35, 23)
        Me.butFindBColorImg.TabIndex = 193
        Me.butFindBColorImg.Text = " -- "
        Me.butFindBColorImg.UseVisualStyleBackColor = False
        '
        'txtBColorImgPath
        '
        Me.txtBColorImgPath.Location = New System.Drawing.Point(128, 252)
        Me.txtBColorImgPath.Name = "txtBColorImgPath"
        Me.txtBColorImgPath.ReadOnly = True
        Me.txtBColorImgPath.Size = New System.Drawing.Size(154, 23)
        Me.txtBColorImgPath.TabIndex = 192
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(6, 252)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 15)
        Me.Label17.TabIndex = 191
        Me.Label17.Text = "Color:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(6, 302)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 15)
        Me.Label16.TabIndex = 190
        Me.Label16.Text = "Thumbnail:"
        '
        'pctBColorImg
        '
        Me.pctBColorImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctBColorImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctBColorImg.Location = New System.Drawing.Point(116, 291)
        Me.pctBColorImg.Name = "pctBColorImg"
        Me.pctBColorImg.Size = New System.Drawing.Size(101, 80)
        Me.pctBColorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBColorImg.TabIndex = 189
        Me.pctBColorImg.TabStop = False
        '
        'txtPriceBcolorForm
        '
        Me.txtPriceBcolorForm.Location = New System.Drawing.Point(160, 144)
        Me.txtPriceBcolorForm.Name = "txtPriceBcolorForm"
        Me.txtPriceBcolorForm.Size = New System.Drawing.Size(109, 23)
        Me.txtPriceBcolorForm.TabIndex = 182
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(6, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 15)
        Me.Label11.TabIndex = 188
        Me.Label11.Text = "Price per unit:"
        '
        'lbIdBColorForm
        '
        Me.lbIdBColorForm.AutoSize = True
        Me.lbIdBColorForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdBColorForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdBColorForm.Location = New System.Drawing.Point(6, 156)
        Me.lbIdBColorForm.Name = "lbIdBColorForm"
        Me.lbIdBColorForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdBColorForm.TabIndex = 187
        Me.lbIdBColorForm.Text = "-1"
        Me.lbIdBColorForm.Visible = False
        '
        'chkBColorFormName
        '
        Me.chkBColorFormName.AutoSize = True
        Me.chkBColorFormName.Checked = True
        Me.chkBColorFormName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBColorFormName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormName.Location = New System.Drawing.Point(315, 58)
        Me.chkBColorFormName.Name = "chkBColorFormName"
        Me.chkBColorFormName.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormName.TabIndex = 186
        Me.chkBColorFormName.Text = "Contains"
        Me.chkBColorFormName.UseVisualStyleBackColor = True
        '
        'txtBColorNameForm
        '
        Me.txtBColorNameForm.Location = New System.Drawing.Point(160, 54)
        Me.txtBColorNameForm.Name = "txtBColorNameForm"
        Me.txtBColorNameForm.Size = New System.Drawing.Size(149, 23)
        Me.txtBColorNameForm.TabIndex = 181
        '
        'lbBColorNameForm
        '
        Me.lbBColorNameForm.AutoSize = True
        Me.lbBColorNameForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBColorNameForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbBColorNameForm.Location = New System.Drawing.Point(6, 54)
        Me.lbBColorNameForm.Name = "lbBColorNameForm"
        Me.lbBColorNameForm.Size = New System.Drawing.Size(94, 15)
        Me.lbBColorNameForm.TabIndex = 185
        Me.lbBColorNameForm.Text = "BColor name:"
        '
        'lsvBColors
        '
        Me.lsvBColors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvBColors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidBColor, Me.ColumnHeader2, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader9, Me.ColumnHeader14})
        Me.lsvBColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvBColors.FullRowSelect = True
        Me.lsvBColors.GridLines = True
        Me.lsvBColors.HideSelection = False
        Me.lsvBColors.Location = New System.Drawing.Point(6, 377)
        Me.lsvBColors.Name = "lsvBColors"
        Me.lsvBColors.Size = New System.Drawing.Size(1128, 338)
        Me.lsvBColors.TabIndex = 184
        Me.lsvBColors.UseCompatibleStateImageBehavior = False
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
        'butRemoveFromSync
        '
        Me.butRemoveFromSync.BackColor = System.Drawing.Color.Lime
        Me.butRemoveFromSync.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRemoveFromSync.ForeColor = System.Drawing.Color.Red
        Me.butRemoveFromSync.Location = New System.Drawing.Point(576, 164)
        Me.butRemoveFromSync.Name = "butRemoveFromSync"
        Me.butRemoveFromSync.Size = New System.Drawing.Size(247, 45)
        Me.butRemoveFromSync.TabIndex = 179
        Me.butRemoveFromSync.Text = "Remove selected from sync"
        Me.butRemoveFromSync.UseVisualStyleBackColor = False
        '
        'butListSelected
        '
        Me.butListSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butListSelected.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butListSelected.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butListSelected.Location = New System.Drawing.Point(414, 115)
        Me.butListSelected.Name = "butListSelected"
        Me.butListSelected.Size = New System.Drawing.Size(155, 94)
        Me.butListSelected.TabIndex = 178
        Me.butListSelected.Text = "List the selected"
        Me.butListSelected.UseVisualStyleBackColor = False
        '
        'butSelectAll
        '
        Me.butSelectAll.BackColor = System.Drawing.SystemColors.Highlight
        Me.butSelectAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSelectAll.Location = New System.Drawing.Point(552, 24)
        Me.butSelectAll.Name = "butSelectAll"
        Me.butSelectAll.Size = New System.Drawing.Size(113, 78)
        Me.butSelectAll.TabIndex = 177
        Me.butSelectAll.Text = "Select All"
        Me.butSelectAll.UseVisualStyleBackColor = False
        '
        'butAddToSync
        '
        Me.butAddToSync.BackColor = System.Drawing.Color.Lime
        Me.butAddToSync.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddToSync.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddToSync.Location = New System.Drawing.Point(576, 115)
        Me.butAddToSync.Name = "butAddToSync"
        Me.butAddToSync.Size = New System.Drawing.Size(247, 45)
        Me.butAddToSync.TabIndex = 176
        Me.butAddToSync.Text = "Add selected to sync"
        Me.butAddToSync.UseVisualStyleBackColor = False
        '
        'ButGoBack
        '
        Me.ButGoBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButGoBack.BackColor = System.Drawing.SystemColors.Control
        Me.ButGoBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGoBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButGoBack.Location = New System.Drawing.Point(1011, 22)
        Me.ButGoBack.Name = "ButGoBack"
        Me.ButGoBack.Size = New System.Drawing.Size(113, 79)
        Me.ButGoBack.TabIndex = 175
        Me.ButGoBack.Text = "Go Back"
        Me.ButGoBack.UseVisualStyleBackColor = False
        '
        'butClearGarage
        '
        Me.butClearGarage.BackColor = System.Drawing.SystemColors.Control
        Me.butClearGarage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClearGarage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClearGarage.Location = New System.Drawing.Point(695, 25)
        Me.butClearGarage.Name = "butClearGarage"
        Me.butClearGarage.Size = New System.Drawing.Size(113, 79)
        Me.butClearGarage.TabIndex = 153
        Me.butClearGarage.Text = "Clear"
        Me.butClearGarage.UseVisualStyleBackColor = False
        '
        'butSearchBColorForm
        '
        Me.butSearchBColorForm.BackColor = System.Drawing.SystemColors.Control
        Me.butSearchBColorForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSearchBColorForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSearchBColorForm.Location = New System.Drawing.Point(414, 23)
        Me.butSearchBColorForm.Name = "butSearchBColorForm"
        Me.butSearchBColorForm.Size = New System.Drawing.Size(113, 78)
        Me.butSearchBColorForm.TabIndex = 9
        Me.butSearchBColorForm.Text = "Find"
        Me.butSearchBColorForm.UseVisualStyleBackColor = False
        '
        'fileDialogColor
        '
        Me.fileDialogColor.FileName = " "
        '
        'colorsEditSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 742)
        Me.Controls.Add(Me.grpColorForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "colorsEditSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Sync"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpColorForm.ResumeLayout(False)
        Me.grpColorForm.PerformLayout()
        CType(Me.pctBColorRGB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBColorImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpColorForm As System.Windows.Forms.GroupBox
    Friend WithEvents butClearGarage As System.Windows.Forms.Button
    Friend WithEvents butSearchBColorForm As System.Windows.Forms.Button
    Friend WithEvents fileDialogColor As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButGoBack As System.Windows.Forms.Button
    Friend WithEvents butSelectAll As System.Windows.Forms.Button
    Friend WithEvents butAddToSync As System.Windows.Forms.Button
    Friend WithEvents butRemoveFromSync As System.Windows.Forms.Button
    Friend WithEvents butListSelected As System.Windows.Forms.Button
    Friend WithEvents chkBColorFormNameAlt2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorNameFormAlt2 As HeadQApplication.MyTextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents pctBColorRGB As System.Windows.Forms.PictureBox
    Friend WithEvents txtMasseVolumiqueExt As HeadQApplication.MyTextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents chkBColorFormNameAlt As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorNameFormAlt As HeadQApplication.MyTextBox
    Friend WithEvents lbBColorNameFormAlt As System.Windows.Forms.Label
    Friend WithEvents txtMasseVolumique As HeadQApplication.MyTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkBColorFormCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorCodeForm As HeadQApplication.MyTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtfnamehideenColor As HeadQApplication.MyTextBox
    Friend WithEvents butFindBColorImg As System.Windows.Forms.Button
    Friend WithEvents txtBColorImgPath As HeadQApplication.MyTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents pctBColorImg As System.Windows.Forms.PictureBox
    Friend WithEvents txtPriceBcolorForm As HeadQApplication.MyTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbIdBColorForm As System.Windows.Forms.Label
    Friend WithEvents chkBColorFormName As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorNameForm As HeadQApplication.MyTextBox
    Friend WithEvents lbBColorNameForm As System.Windows.Forms.Label
    Friend WithEvents lsvBColors As HeadQApplication.MyListView
    Friend WithEvents cidBColor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
End Class
