<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class garagesDeleteSync
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(garagesDeleteSync))
        Me.grpGarageForm = New System.Windows.Forms.GroupBox()
        Me.butRemoveFromSync = New System.Windows.Forms.Button()
        Me.butListSelected = New System.Windows.Forms.Button()
        Me.butSelectAll = New System.Windows.Forms.Button()
        Me.butAddToSync = New System.Windows.Forms.Button()
        Me.ButGoBack = New System.Windows.Forms.Button()
        Me.chkUsername = New System.Windows.Forms.CheckBox()
        Me.txtusername = New HeadQApplication.MyTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.chkApply5 = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdGarage2k = New System.Windows.Forms.RadioButton()
        Me.rdGarageLS = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.chkversion = New System.Windows.Forms.CheckBox()
        Me.txtversion = New HeadQApplication.MyTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.grpradio = New System.Windows.Forms.GroupBox()
        Me.rdApply4 = New System.Windows.Forms.RadioButton()
        Me.rdApply3 = New System.Windows.Forms.RadioButton()
        Me.rdApply0 = New System.Windows.Forms.RadioButton()
        Me.rdApply1 = New System.Windows.Forms.RadioButton()
        Me.rdApply2 = New System.Windows.Forms.RadioButton()
        Me.butClearGarage = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtfnamegaragehidden = New HeadQApplication.MyTextBox()
        Me.lbIdLanguage = New System.Windows.Forms.Label()
        Me.txtLanguage = New HeadQApplication.MyTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkGarageRespForm = New System.Windows.Forms.CheckBox()
        Me.txtGarageRespform = New HeadQApplication.MyTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbIdGarageForm = New System.Windows.Forms.Label()
        Me.chkGarageLocationForm = New System.Windows.Forms.CheckBox()
        Me.txtGarageLocationForm = New HeadQApplication.MyTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkGarageFormCode = New System.Windows.Forms.CheckBox()
        Me.txtGarageNameForm = New HeadQApplication.MyTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lsvGarage = New HeadQApplication.MyListView()
        Me.cidGarage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cidlanggarage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cappequation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cgversion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cgcoat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.butSearchGarageForm = New System.Windows.Forms.Button()
        Me.fileDialogGarage = New System.Windows.Forms.OpenFileDialog()
        Me.grpGarageForm.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpradio.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpGarageForm
        '
        Me.grpGarageForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGarageForm.BackColor = System.Drawing.Color.Transparent
        Me.grpGarageForm.Controls.Add(Me.butRemoveFromSync)
        Me.grpGarageForm.Controls.Add(Me.butListSelected)
        Me.grpGarageForm.Controls.Add(Me.butSelectAll)
        Me.grpGarageForm.Controls.Add(Me.butAddToSync)
        Me.grpGarageForm.Controls.Add(Me.ButGoBack)
        Me.grpGarageForm.Controls.Add(Me.chkUsername)
        Me.grpGarageForm.Controls.Add(Me.txtusername)
        Me.grpGarageForm.Controls.Add(Me.Label35)
        Me.grpGarageForm.Controls.Add(Me.chkApply5)
        Me.grpGarageForm.Controls.Add(Me.GroupBox4)
        Me.grpGarageForm.Controls.Add(Me.Label28)
        Me.grpGarageForm.Controls.Add(Me.chkversion)
        Me.grpGarageForm.Controls.Add(Me.txtversion)
        Me.grpGarageForm.Controls.Add(Me.Label27)
        Me.grpGarageForm.Controls.Add(Me.grpradio)
        Me.grpGarageForm.Controls.Add(Me.butClearGarage)
        Me.grpGarageForm.Controls.Add(Me.Label20)
        Me.grpGarageForm.Controls.Add(Me.txtfnamegaragehidden)
        Me.grpGarageForm.Controls.Add(Me.lbIdLanguage)
        Me.grpGarageForm.Controls.Add(Me.txtLanguage)
        Me.grpGarageForm.Controls.Add(Me.Label6)
        Me.grpGarageForm.Controls.Add(Me.chkGarageRespForm)
        Me.grpGarageForm.Controls.Add(Me.txtGarageRespform)
        Me.grpGarageForm.Controls.Add(Me.Label7)
        Me.grpGarageForm.Controls.Add(Me.lbIdGarageForm)
        Me.grpGarageForm.Controls.Add(Me.chkGarageLocationForm)
        Me.grpGarageForm.Controls.Add(Me.txtGarageLocationForm)
        Me.grpGarageForm.Controls.Add(Me.Label8)
        Me.grpGarageForm.Controls.Add(Me.chkGarageFormCode)
        Me.grpGarageForm.Controls.Add(Me.txtGarageNameForm)
        Me.grpGarageForm.Controls.Add(Me.Label9)
        Me.grpGarageForm.Controls.Add(Me.lsvGarage)
        Me.grpGarageForm.Controls.Add(Me.butSearchGarageForm)
        Me.grpGarageForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGarageForm.ForeColor = System.Drawing.Color.Red
        Me.grpGarageForm.Location = New System.Drawing.Point(13, 9)
        Me.grpGarageForm.Name = "grpGarageForm"
        Me.grpGarageForm.Size = New System.Drawing.Size(1140, 721)
        Me.grpGarageForm.TabIndex = 71
        Me.grpGarageForm.TabStop = False
        Me.grpGarageForm.Text = "Garages - Delete Sync"
        '
        'butRemoveFromSync
        '
        Me.butRemoveFromSync.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.butRemoveFromSync.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRemoveFromSync.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butRemoveFromSync.Location = New System.Drawing.Point(576, 164)
        Me.butRemoveFromSync.Name = "butRemoveFromSync"
        Me.butRemoveFromSync.Size = New System.Drawing.Size(247, 45)
        Me.butRemoveFromSync.TabIndex = 179
        Me.butRemoveFromSync.Text = "Remove selected from sync"
        Me.butRemoveFromSync.UseVisualStyleBackColor = False
        '
        'butListSelected
        '
        Me.butListSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
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
        Me.butAddToSync.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
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
        'chkUsername
        '
        Me.chkUsername.AutoSize = True
        Me.chkUsername.Checked = True
        Me.chkUsername.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUsername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUsername.Location = New System.Drawing.Point(272, 201)
        Me.chkUsername.Name = "chkUsername"
        Me.chkUsername.Size = New System.Drawing.Size(75, 17)
        Me.chkUsername.TabIndex = 174
        Me.chkUsername.Text = "Contains"
        Me.chkUsername.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(126, 196)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(136, 23)
        Me.txtusername.TabIndex = 173
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(16, 196)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(73, 15)
        Me.Label35.TabIndex = 172
        Me.Label35.Text = "Username"
        '
        'chkApply5
        '
        Me.chkApply5.AutoSize = True
        Me.chkApply5.Checked = True
        Me.chkApply5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkApply5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkApply5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkApply5.Location = New System.Drawing.Point(671, 250)
        Me.chkApply5.Name = "chkApply5"
        Me.chkApply5.Size = New System.Drawing.Size(152, 17)
        Me.chkApply5.TabIndex = 171
        Me.chkApply5.Text = "Apply Eq. 4201 - 180g"
        Me.chkApply5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdGarage2k)
        Me.GroupBox4.Controls.Add(Me.rdGarageLS)
        Me.GroupBox4.Location = New System.Drawing.Point(126, 274)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(101, 36)
        Me.GroupBox4.TabIndex = 161
        Me.GroupBox4.TabStop = False
        '
        'rdGarage2k
        '
        Me.rdGarage2k.AutoSize = True
        Me.rdGarage2k.Checked = True
        Me.rdGarage2k.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGarage2k.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdGarage2k.Location = New System.Drawing.Point(6, 12)
        Me.rdGarage2k.Name = "rdGarage2k"
        Me.rdGarage2k.Size = New System.Drawing.Size(40, 17)
        Me.rdGarage2k.TabIndex = 156
        Me.rdGarage2k.TabStop = True
        Me.rdGarage2k.Text = "2K"
        Me.rdGarage2k.UseVisualStyleBackColor = True
        '
        'rdGarageLS
        '
        Me.rdGarageLS.AutoSize = True
        Me.rdGarageLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGarageLS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdGarageLS.Location = New System.Drawing.Point(61, 12)
        Me.rdGarageLS.Name = "rdGarageLS"
        Me.rdGarageLS.Size = New System.Drawing.Size(40, 17)
        Me.rdGarageLS.TabIndex = 154
        Me.rdGarageLS.Text = "LS"
        Me.rdGarageLS.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(16, 283)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 15)
        Me.Label28.TabIndex = 160
        Me.Label28.Text = "Coat"
        '
        'chkversion
        '
        Me.chkversion.AutoSize = True
        Me.chkversion.Checked = True
        Me.chkversion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkversion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkversion.Location = New System.Drawing.Point(272, 156)
        Me.chkversion.Name = "chkversion"
        Me.chkversion.Size = New System.Drawing.Size(75, 17)
        Me.chkversion.TabIndex = 159
        Me.chkversion.Text = "Contains"
        Me.chkversion.UseVisualStyleBackColor = True
        '
        'txtversion
        '
        Me.txtversion.Location = New System.Drawing.Point(126, 151)
        Me.txtversion.Name = "txtversion"
        Me.txtversion.Size = New System.Drawing.Size(136, 23)
        Me.txtversion.TabIndex = 158
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(16, 151)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 15)
        Me.Label27.TabIndex = 157
        Me.Label27.Text = "Version"
        '
        'grpradio
        '
        Me.grpradio.Controls.Add(Me.rdApply4)
        Me.grpradio.Controls.Add(Me.rdApply3)
        Me.grpradio.Controls.Add(Me.rdApply0)
        Me.grpradio.Controls.Add(Me.rdApply1)
        Me.grpradio.Controls.Add(Me.rdApply2)
        Me.grpradio.Location = New System.Drawing.Point(126, 236)
        Me.grpradio.Name = "grpradio"
        Me.grpradio.Size = New System.Drawing.Size(539, 38)
        Me.grpradio.TabIndex = 156
        Me.grpradio.TabStop = False
        '
        'rdApply4
        '
        Me.rdApply4.AutoSize = True
        Me.rdApply4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdApply4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdApply4.Location = New System.Drawing.Point(450, 12)
        Me.rdApply4.Name = "rdApply4"
        Me.rdApply4.Size = New System.Drawing.Size(89, 17)
        Me.rdApply4.TabIndex = 158
        Me.rdApply4.TabStop = True
        Me.rdApply4.Text = "Extended +"
        Me.rdApply4.UseVisualStyleBackColor = True
        '
        'rdApply3
        '
        Me.rdApply3.AutoSize = True
        Me.rdApply3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdApply3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdApply3.Location = New System.Drawing.Point(288, 12)
        Me.rdApply3.Name = "rdApply3"
        Me.rdApply3.Size = New System.Drawing.Size(155, 17)
        Me.rdApply3.TabIndex = 157
        Me.rdApply3.TabStop = True
        Me.rdApply3.Text = "Apply Eq. (no 4581-91)"
        Me.rdApply3.UseVisualStyleBackColor = True
        '
        'rdApply0
        '
        Me.rdApply0.AutoSize = True
        Me.rdApply0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdApply0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdApply0.Location = New System.Drawing.Point(6, 12)
        Me.rdApply0.Name = "rdApply0"
        Me.rdApply0.Size = New System.Drawing.Size(55, 17)
        Me.rdApply0.TabIndex = 156
        Me.rdApply0.TabStop = True
        Me.rdApply0.Text = "None"
        Me.rdApply0.UseVisualStyleBackColor = True
        '
        'rdApply1
        '
        Me.rdApply1.AutoSize = True
        Me.rdApply1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdApply1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdApply1.Location = New System.Drawing.Point(67, 12)
        Me.rdApply1.Name = "rdApply1"
        Me.rdApply1.Size = New System.Drawing.Size(79, 17)
        Me.rdApply1.TabIndex = 154
        Me.rdApply1.TabStop = True
        Me.rdApply1.Text = "Apply Eq."
        Me.rdApply1.UseVisualStyleBackColor = True
        '
        'rdApply2
        '
        Me.rdApply2.AutoSize = True
        Me.rdApply2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdApply2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdApply2.Location = New System.Drawing.Point(146, 12)
        Me.rdApply2.Name = "rdApply2"
        Me.rdApply2.Size = New System.Drawing.Size(136, 17)
        Me.rdApply2.TabIndex = 155
        Me.rdApply2.TabStop = True
        Me.rdApply2.Text = "Apply Extended Eq."
        Me.rdApply2.UseVisualStyleBackColor = True
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
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(16, 245)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 15)
        Me.Label20.TabIndex = 127
        Me.Label20.Text = "Equation"
        '
        'txtfnamegaragehidden
        '
        Me.txtfnamegaragehidden.Location = New System.Drawing.Point(552, 324)
        Me.txtfnamegaragehidden.Name = "txtfnamegaragehidden"
        Me.txtfnamegaragehidden.ReadOnly = True
        Me.txtfnamegaragehidden.Size = New System.Drawing.Size(101, 23)
        Me.txtfnamegaragehidden.TabIndex = 123
        Me.txtfnamegaragehidden.Visible = False
        '
        'lbIdLanguage
        '
        Me.lbIdLanguage.AutoSize = True
        Me.lbIdLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdLanguage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdLanguage.Location = New System.Drawing.Point(100, 324)
        Me.lbIdLanguage.Name = "lbIdLanguage"
        Me.lbIdLanguage.Size = New System.Drawing.Size(20, 15)
        Me.lbIdLanguage.TabIndex = 83
        Me.lbIdLanguage.Text = "-1"
        Me.lbIdLanguage.Visible = False
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(126, 321)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.ReadOnly = True
        Me.txtLanguage.Size = New System.Drawing.Size(136, 23)
        Me.txtLanguage.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Language:"
        '
        'chkGarageRespForm
        '
        Me.chkGarageRespForm.AutoSize = True
        Me.chkGarageRespForm.Checked = True
        Me.chkGarageRespForm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGarageRespForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarageRespForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGarageRespForm.Location = New System.Drawing.Point(272, 120)
        Me.chkGarageRespForm.Name = "chkGarageRespForm"
        Me.chkGarageRespForm.Size = New System.Drawing.Size(75, 17)
        Me.chkGarageRespForm.TabIndex = 80
        Me.chkGarageRespForm.Text = "Contains"
        Me.chkGarageRespForm.UseVisualStyleBackColor = True
        '
        'txtGarageRespform
        '
        Me.txtGarageRespform.Location = New System.Drawing.Point(126, 115)
        Me.txtGarageRespform.Name = "txtGarageRespform"
        Me.txtGarageRespform.Size = New System.Drawing.Size(136, 23)
        Me.txtGarageRespform.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Responsible"
        '
        'lbIdGarageForm
        '
        Me.lbIdGarageForm.AutoSize = True
        Me.lbIdGarageForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdGarageForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdGarageForm.Location = New System.Drawing.Point(659, 324)
        Me.lbIdGarageForm.Name = "lbIdGarageForm"
        Me.lbIdGarageForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdGarageForm.TabIndex = 76
        Me.lbIdGarageForm.Text = "-1"
        Me.lbIdGarageForm.Visible = False
        '
        'chkGarageLocationForm
        '
        Me.chkGarageLocationForm.AutoSize = True
        Me.chkGarageLocationForm.Checked = True
        Me.chkGarageLocationForm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGarageLocationForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarageLocationForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGarageLocationForm.Location = New System.Drawing.Point(272, 73)
        Me.chkGarageLocationForm.Name = "chkGarageLocationForm"
        Me.chkGarageLocationForm.Size = New System.Drawing.Size(75, 17)
        Me.chkGarageLocationForm.TabIndex = 74
        Me.chkGarageLocationForm.Text = "Contains"
        Me.chkGarageLocationForm.UseVisualStyleBackColor = True
        '
        'txtGarageLocationForm
        '
        Me.txtGarageLocationForm.Location = New System.Drawing.Point(126, 68)
        Me.txtGarageLocationForm.Name = "txtGarageLocationForm"
        Me.txtGarageLocationForm.Size = New System.Drawing.Size(136, 23)
        Me.txtGarageLocationForm.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Location"
        '
        'chkGarageFormCode
        '
        Me.chkGarageFormCode.AutoSize = True
        Me.chkGarageFormCode.Checked = True
        Me.chkGarageFormCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGarageFormCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarageFormCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGarageFormCode.Location = New System.Drawing.Point(272, 30)
        Me.chkGarageFormCode.Name = "chkGarageFormCode"
        Me.chkGarageFormCode.Size = New System.Drawing.Size(75, 17)
        Me.chkGarageFormCode.TabIndex = 70
        Me.chkGarageFormCode.Text = "Contains"
        Me.chkGarageFormCode.UseVisualStyleBackColor = True
        '
        'txtGarageNameForm
        '
        Me.txtGarageNameForm.Location = New System.Drawing.Point(126, 25)
        Me.txtGarageNameForm.Name = "txtGarageNameForm"
        Me.txtGarageNameForm.Size = New System.Drawing.Size(136, 23)
        Me.txtGarageNameForm.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Name"
        '
        'lsvGarage
        '
        Me.lsvGarage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvGarage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lsvGarage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidGarage, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.cidlanggarage, Me.cappequation, Me.cgversion, Me.cgcoat})
        Me.lsvGarage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvGarage.FullRowSelect = True
        Me.lsvGarage.GridLines = True
        Me.lsvGarage.HideSelection = False
        Me.lsvGarage.Location = New System.Drawing.Point(10, 353)
        Me.lsvGarage.Name = "lsvGarage"
        Me.lsvGarage.Size = New System.Drawing.Size(1124, 362)
        Me.lsvGarage.TabIndex = 55
        Me.lsvGarage.UseCompatibleStateImageBehavior = False
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
        Me.butSearchGarageForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSearchGarageForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSearchGarageForm.Location = New System.Drawing.Point(414, 23)
        Me.butSearchGarageForm.Name = "butSearchGarageForm"
        Me.butSearchGarageForm.Size = New System.Drawing.Size(113, 78)
        Me.butSearchGarageForm.TabIndex = 9
        Me.butSearchGarageForm.Text = "Find"
        Me.butSearchGarageForm.UseVisualStyleBackColor = False
        '
        'fileDialogGarage
        '
        Me.fileDialogGarage.FileName = " "
        '
        'garagesDeleteSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 742)
        Me.Controls.Add(Me.grpGarageForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "garagesDeleteSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Garage Sync"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpGarageForm.ResumeLayout(False)
        Me.grpGarageForm.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpradio.ResumeLayout(False)
        Me.grpradio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpGarageForm As System.Windows.Forms.GroupBox
    Friend WithEvents chkUsername As System.Windows.Forms.CheckBox
    Friend WithEvents txtusername As HeadQApplication.MyTextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents chkApply5 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdGarage2k As System.Windows.Forms.RadioButton
    Friend WithEvents rdGarageLS As System.Windows.Forms.RadioButton
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents chkversion As System.Windows.Forms.CheckBox
    Friend WithEvents txtversion As HeadQApplication.MyTextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents grpradio As System.Windows.Forms.GroupBox
    Friend WithEvents rdApply4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdApply3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdApply0 As System.Windows.Forms.RadioButton
    Friend WithEvents rdApply1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdApply2 As System.Windows.Forms.RadioButton
    Friend WithEvents butClearGarage As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtfnamegaragehidden As HeadQApplication.MyTextBox
    Friend WithEvents lbIdLanguage As System.Windows.Forms.Label
    Friend WithEvents txtLanguage As HeadQApplication.MyTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkGarageRespForm As System.Windows.Forms.CheckBox
    Friend WithEvents txtGarageRespform As HeadQApplication.MyTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbIdGarageForm As System.Windows.Forms.Label
    Friend WithEvents chkGarageLocationForm As System.Windows.Forms.CheckBox
    Friend WithEvents txtGarageLocationForm As HeadQApplication.MyTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkGarageFormCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtGarageNameForm As HeadQApplication.MyTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lsvGarage As HeadQApplication.MyListView
    Friend WithEvents cidGarage As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cidlanggarage As System.Windows.Forms.ColumnHeader
    Friend WithEvents cappequation As System.Windows.Forms.ColumnHeader
    Friend WithEvents cgversion As System.Windows.Forms.ColumnHeader
    Friend WithEvents cgcoat As System.Windows.Forms.ColumnHeader
    Friend WithEvents butSearchGarageForm As System.Windows.Forms.Button
    Friend WithEvents fileDialogGarage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButGoBack As System.Windows.Forms.Button
    Friend WithEvents butSelectAll As System.Windows.Forms.Button
    Friend WithEvents butAddToSync As System.Windows.Forms.Button
    Friend WithEvents butRemoveFromSync As System.Windows.Forms.Button
    Friend WithEvents butListSelected As System.Windows.Forms.Button
End Class
