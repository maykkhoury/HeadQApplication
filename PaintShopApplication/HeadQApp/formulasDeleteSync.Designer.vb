<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formulasDeleteSync
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formulasDeleteSync))
        Me.fileDialogCar = New System.Windows.Forms.OpenFileDialog()
        Me.butGo = New System.Windows.Forms.Button()
        Me.butClearFormula = New System.Windows.Forms.Button()
        Me.ButGoBack = New System.Windows.Forms.Button()
        Me.butAddToSync = New System.Windows.Forms.Button()
        Me.butSelectAll = New System.Windows.Forms.Button()
        Me.butListSelected = New System.Windows.Forms.Button()
        Me.butRemoveFromSync = New System.Windows.Forms.Button()
        Me.grpFormulaForm = New System.Windows.Forms.GroupBox()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.lbCountFormulas = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdLS = New System.Windows.Forms.RadioButton()
        Me.rdAny = New System.Windows.Forms.RadioButton()
        Me.rdBC = New System.Windows.Forms.RadioButton()
        Me.rd2k = New System.Windows.Forms.RadioButton()
        Me.cmbCarNameSearch = New System.Windows.Forms.ComboBox()
        Me.lbCarIdSearch = New System.Windows.Forms.Label()
        Me.lsvFormula = New HeadQApplication.MyListView()
        Me.cformulaId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cctype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ccarname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ccode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ccname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cversion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chkColorCode = New System.Windows.Forms.CheckBox()
        Me.txtColorCode = New HeadQApplication.MyTextBox()
        Me.lbColorCode = New System.Windows.Forms.Label()
        Me.chkFormulaName = New System.Windows.Forms.CheckBox()
        Me.txtFormulaName = New HeadQApplication.MyTextBox()
        Me.lbFormulaName = New System.Windows.Forms.Label()
        Me.grpFormulaForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fileDialogCar
        '
        Me.fileDialogCar.FileName = " "
        '
        'butGo
        '
        Me.butGo.BackColor = System.Drawing.SystemColors.Control
        Me.butGo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butGo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butGo.Location = New System.Drawing.Point(414, 23)
        Me.butGo.Name = "butGo"
        Me.butGo.Size = New System.Drawing.Size(113, 78)
        Me.butGo.TabIndex = 9
        Me.butGo.Text = "Find"
        Me.butGo.UseVisualStyleBackColor = False
        '
        'butClearFormula
        '
        Me.butClearFormula.BackColor = System.Drawing.SystemColors.Control
        Me.butClearFormula.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClearFormula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClearFormula.Location = New System.Drawing.Point(695, 25)
        Me.butClearFormula.Name = "butClearFormula"
        Me.butClearFormula.Size = New System.Drawing.Size(113, 79)
        Me.butClearFormula.TabIndex = 153
        Me.butClearFormula.Text = "Clear"
        Me.butClearFormula.UseVisualStyleBackColor = False
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
        'grpFormulaForm
        '
        Me.grpFormulaForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFormulaForm.BackColor = System.Drawing.Color.Transparent
        Me.grpFormulaForm.Controls.Add(Me.prgBar)
        Me.grpFormulaForm.Controls.Add(Me.lbCountFormulas)
        Me.grpFormulaForm.Controls.Add(Me.GroupBox1)
        Me.grpFormulaForm.Controls.Add(Me.cmbCarNameSearch)
        Me.grpFormulaForm.Controls.Add(Me.lbCarIdSearch)
        Me.grpFormulaForm.Controls.Add(Me.lsvFormula)
        Me.grpFormulaForm.Controls.Add(Me.Label23)
        Me.grpFormulaForm.Controls.Add(Me.chkColorCode)
        Me.grpFormulaForm.Controls.Add(Me.txtColorCode)
        Me.grpFormulaForm.Controls.Add(Me.lbColorCode)
        Me.grpFormulaForm.Controls.Add(Me.chkFormulaName)
        Me.grpFormulaForm.Controls.Add(Me.txtFormulaName)
        Me.grpFormulaForm.Controls.Add(Me.lbFormulaName)
        Me.grpFormulaForm.Controls.Add(Me.butRemoveFromSync)
        Me.grpFormulaForm.Controls.Add(Me.butListSelected)
        Me.grpFormulaForm.Controls.Add(Me.butSelectAll)
        Me.grpFormulaForm.Controls.Add(Me.butAddToSync)
        Me.grpFormulaForm.Controls.Add(Me.ButGoBack)
        Me.grpFormulaForm.Controls.Add(Me.butClearFormula)
        Me.grpFormulaForm.Controls.Add(Me.butGo)
        Me.grpFormulaForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFormulaForm.ForeColor = System.Drawing.Color.Red
        Me.grpFormulaForm.Location = New System.Drawing.Point(13, 9)
        Me.grpFormulaForm.Name = "grpFormulaForm"
        Me.grpFormulaForm.Size = New System.Drawing.Size(1140, 721)
        Me.grpFormulaForm.TabIndex = 71
        Me.grpFormulaForm.TabStop = False
        Me.grpFormulaForm.Text = "Formulas - Delete Sync"
        '
        'prgBar
        '
        Me.prgBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.prgBar.Location = New System.Drawing.Point(6, 694)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(1126, 23)
        Me.prgBar.TabIndex = 229
        Me.prgBar.Visible = False
        '
        'lbCountFormulas
        '
        Me.lbCountFormulas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCountFormulas.AutoSize = True
        Me.lbCountFormulas.Location = New System.Drawing.Point(1007, 238)
        Me.lbCountFormulas.Name = "lbCountFormulas"
        Me.lbCountFormulas.Size = New System.Drawing.Size(32, 17)
        Me.lbCountFormulas.TabIndex = 228
        Me.lbCountFormulas.Text = "nbr"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdLS)
        Me.GroupBox1.Controls.Add(Me.rdAny)
        Me.GroupBox1.Controls.Add(Me.rdBC)
        Me.GroupBox1.Controls.Add(Me.rd2k)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 35)
        Me.GroupBox1.TabIndex = 213
        Me.GroupBox1.TabStop = False
        '
        'rdLS
        '
        Me.rdLS.AutoSize = True
        Me.rdLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdLS.Location = New System.Drawing.Point(92, 12)
        Me.rdLS.Name = "rdLS"
        Me.rdLS.Size = New System.Drawing.Size(40, 17)
        Me.rdLS.TabIndex = 81
        Me.rdLS.Text = "LS"
        Me.rdLS.UseVisualStyleBackColor = True
        '
        'rdAny
        '
        Me.rdAny.AutoSize = True
        Me.rdAny.Checked = True
        Me.rdAny.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAny.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdAny.Location = New System.Drawing.Point(151, 11)
        Me.rdAny.Name = "rdAny"
        Me.rdAny.Size = New System.Drawing.Size(46, 17)
        Me.rdAny.TabIndex = 80
        Me.rdAny.TabStop = True
        Me.rdAny.Text = "Any"
        Me.rdAny.UseVisualStyleBackColor = True
        '
        'rdBC
        '
        Me.rdBC.AutoSize = True
        Me.rdBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdBC.Location = New System.Drawing.Point(45, 12)
        Me.rdBC.Name = "rdBC"
        Me.rdBC.Size = New System.Drawing.Size(41, 17)
        Me.rdBC.TabIndex = 79
        Me.rdBC.Text = "BC"
        Me.rdBC.UseVisualStyleBackColor = True
        '
        'rd2k
        '
        Me.rd2k.AutoSize = True
        Me.rd2k.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd2k.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rd2k.Location = New System.Drawing.Point(4, 11)
        Me.rd2k.Name = "rd2k"
        Me.rd2k.Size = New System.Drawing.Size(40, 17)
        Me.rd2k.TabIndex = 78
        Me.rd2k.Text = "2K"
        Me.rd2k.UseVisualStyleBackColor = True
        '
        'cmbCarNameSearch
        '
        Me.cmbCarNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarNameSearch.FormattingEnabled = True
        Me.cmbCarNameSearch.Location = New System.Drawing.Point(121, 30)
        Me.cmbCarNameSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCarNameSearch.Name = "cmbCarNameSearch"
        Me.cmbCarNameSearch.Size = New System.Drawing.Size(187, 24)
        Me.cmbCarNameSearch.TabIndex = 209
        '
        'lbCarIdSearch
        '
        Me.lbCarIdSearch.AutoSize = True
        Me.lbCarIdSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarIdSearch.Location = New System.Drawing.Point(85, 36)
        Me.lbCarIdSearch.Name = "lbCarIdSearch"
        Me.lbCarIdSearch.Size = New System.Drawing.Size(23, 17)
        Me.lbCarIdSearch.TabIndex = 217
        Me.lbCarIdSearch.Text = "-1"
        Me.lbCarIdSearch.Visible = False
        '
        'lsvFormula
        '
        Me.lsvFormula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvFormula.BackColor = System.Drawing.Color.White
        Me.lsvFormula.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cformulaId, Me.cctype, Me.ccarname, Me.ccode, Me.ccname, Me.cversion})
        Me.lsvFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvFormula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lsvFormula.FullRowSelect = True
        Me.lsvFormula.GridLines = True
        Me.lsvFormula.HideSelection = False
        Me.lsvFormula.Location = New System.Drawing.Point(7, 261)
        Me.lsvFormula.Name = "lsvFormula"
        Me.lsvFormula.Size = New System.Drawing.Size(1126, 430)
        Me.lsvFormula.TabIndex = 210
        Me.lsvFormula.UseCompatibleStateImageBehavior = False
        Me.lsvFormula.View = System.Windows.Forms.View.Details
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
        Me.cctype.Width = 69
        '
        'ccarname
        '
        Me.ccarname.Tag = "ccarname"
        Me.ccarname.Text = "Car"
        Me.ccarname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ccarname.Width = 208
        '
        'ccode
        '
        Me.ccode.Tag = "ccode"
        Me.ccode.Text = "Code"
        Me.ccode.Width = 186
        '
        'ccname
        '
        Me.ccname.Tag = "ccname"
        Me.ccname.Text = "Name"
        Me.ccname.Width = 321
        '
        'cversion
        '
        Me.cversion.Tag = "cversion"
        Me.cversion.Text = "Hue"
        Me.cversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cversion.Width = 110
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(14, 33)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 17)
        Me.Label23.TabIndex = 216
        Me.Label23.Text = "Car:"
        '
        'chkColorCode
        '
        Me.chkColorCode.AutoSize = True
        Me.chkColorCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkColorCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkColorCode.Location = New System.Drawing.Point(314, 75)
        Me.chkColorCode.Name = "chkColorCode"
        Me.chkColorCode.Size = New System.Drawing.Size(75, 17)
        Me.chkColorCode.TabIndex = 215
        Me.chkColorCode.Text = "Contains"
        Me.chkColorCode.UseVisualStyleBackColor = True
        '
        'txtColorCode
        '
        Me.txtColorCode.Location = New System.Drawing.Point(121, 73)
        Me.txtColorCode.Name = "txtColorCode"
        Me.txtColorCode.Size = New System.Drawing.Size(187, 23)
        Me.txtColorCode.TabIndex = 205
        '
        'lbColorCode
        '
        Me.lbColorCode.AutoSize = True
        Me.lbColorCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbColorCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbColorCode.Location = New System.Drawing.Point(11, 73)
        Me.lbColorCode.Name = "lbColorCode"
        Me.lbColorCode.Size = New System.Drawing.Size(82, 15)
        Me.lbColorCode.TabIndex = 214
        Me.lbColorCode.Text = "Color Code:"
        '
        'chkFormulaName
        '
        Me.chkFormulaName.AutoSize = True
        Me.chkFormulaName.Checked = True
        Me.chkFormulaName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFormulaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFormulaName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFormulaName.Location = New System.Drawing.Point(314, 111)
        Me.chkFormulaName.Name = "chkFormulaName"
        Me.chkFormulaName.Size = New System.Drawing.Size(75, 17)
        Me.chkFormulaName.TabIndex = 212
        Me.chkFormulaName.Text = "Contains"
        Me.chkFormulaName.UseVisualStyleBackColor = True
        '
        'txtFormulaName
        '
        Me.txtFormulaName.Location = New System.Drawing.Point(121, 109)
        Me.txtFormulaName.Name = "txtFormulaName"
        Me.txtFormulaName.Size = New System.Drawing.Size(187, 23)
        Me.txtFormulaName.TabIndex = 206
        '
        'lbFormulaName
        '
        Me.lbFormulaName.AutoSize = True
        Me.lbFormulaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormulaName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbFormulaName.Location = New System.Drawing.Point(11, 109)
        Me.lbFormulaName.Name = "lbFormulaName"
        Me.lbFormulaName.Size = New System.Drawing.Size(104, 15)
        Me.lbFormulaName.TabIndex = 211
        Me.lbFormulaName.Text = "Formula name:"
        '
        'formulasDeleteSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 742)
        Me.Controls.Add(Me.grpFormulaForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formulasDeleteSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formula Sync"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpFormulaForm.ResumeLayout(False)
        Me.grpFormulaForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fileDialogCar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents butGo As System.Windows.Forms.Button
    Friend WithEvents butClearFormula As System.Windows.Forms.Button
    Friend WithEvents ButGoBack As System.Windows.Forms.Button
    Friend WithEvents butAddToSync As System.Windows.Forms.Button
    Friend WithEvents butSelectAll As System.Windows.Forms.Button
    Friend WithEvents butListSelected As System.Windows.Forms.Button
    Friend WithEvents butRemoveFromSync As System.Windows.Forms.Button
    Friend WithEvents grpFormulaForm As System.Windows.Forms.GroupBox
    Friend WithEvents lbCountFormulas As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLS As System.Windows.Forms.RadioButton
    Friend WithEvents rdAny As System.Windows.Forms.RadioButton
    Friend WithEvents rdBC As System.Windows.Forms.RadioButton
    Friend WithEvents rd2k As System.Windows.Forms.RadioButton
    Friend WithEvents cmbCarNameSearch As System.Windows.Forms.ComboBox
    Friend WithEvents lbCarIdSearch As System.Windows.Forms.Label
    Friend WithEvents lsvFormula As HeadQApplication.MyListView
    Friend WithEvents cformulaId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cctype As System.Windows.Forms.ColumnHeader
    Friend WithEvents ccarname As System.Windows.Forms.ColumnHeader
    Friend WithEvents ccode As System.Windows.Forms.ColumnHeader
    Friend WithEvents ccname As System.Windows.Forms.ColumnHeader
    Friend WithEvents cversion As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chkColorCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtColorCode As HeadQApplication.MyTextBox
    Friend WithEvents lbColorCode As System.Windows.Forms.Label
    Friend WithEvents chkFormulaName As System.Windows.Forms.CheckBox
    Friend WithEvents txtFormulaName As HeadQApplication.MyTextBox
    Friend WithEvents lbFormulaName As System.Windows.Forms.Label
    Friend WithEvents prgBar As System.Windows.Forms.ProgressBar
End Class
