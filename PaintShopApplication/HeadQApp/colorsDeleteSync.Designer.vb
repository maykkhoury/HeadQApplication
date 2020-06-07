<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colorsDeleteSync
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(colorsDeleteSync))
        Me.fileDialogCar = New System.Windows.Forms.OpenFileDialog()
        Me.butSearchBColorForm = New System.Windows.Forms.Button()
        Me.butClearGarage = New System.Windows.Forms.Button()
        Me.ButGoBack = New System.Windows.Forms.Button()
        Me.butAddToSync = New System.Windows.Forms.Button()
        Me.butSelectAll = New System.Windows.Forms.Button()
        Me.butListSelected = New System.Windows.Forms.Button()
        Me.butRemoveFromSync = New System.Windows.Forms.Button()
        Me.grpCarForm = New System.Windows.Forms.GroupBox()
        Me.chkBColorFormCode = New System.Windows.Forms.CheckBox()
        Me.txtBColorCodeForm = New HeadQApplication.MyTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkBColorFormName = New System.Windows.Forms.CheckBox()
        Me.txtBColorNameForm = New HeadQApplication.MyTextBox()
        Me.lbBColorNameForm = New System.Windows.Forms.Label()
        Me.lsvBColors = New HeadQApplication.MyListView()
        Me.cidBColor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbIdBColorForm = New System.Windows.Forms.Label()
        Me.grpCarForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'fileDialogCar
        '
        Me.fileDialogCar.FileName = " "
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
        'grpCarForm
        '
        Me.grpCarForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCarForm.BackColor = System.Drawing.Color.Transparent
        Me.grpCarForm.Controls.Add(Me.lbIdBColorForm)
        Me.grpCarForm.Controls.Add(Me.chkBColorFormCode)
        Me.grpCarForm.Controls.Add(Me.txtBColorCodeForm)
        Me.grpCarForm.Controls.Add(Me.Label21)
        Me.grpCarForm.Controls.Add(Me.chkBColorFormName)
        Me.grpCarForm.Controls.Add(Me.txtBColorNameForm)
        Me.grpCarForm.Controls.Add(Me.lbBColorNameForm)
        Me.grpCarForm.Controls.Add(Me.lsvBColors)
        Me.grpCarForm.Controls.Add(Me.butRemoveFromSync)
        Me.grpCarForm.Controls.Add(Me.butListSelected)
        Me.grpCarForm.Controls.Add(Me.butSelectAll)
        Me.grpCarForm.Controls.Add(Me.butAddToSync)
        Me.grpCarForm.Controls.Add(Me.ButGoBack)
        Me.grpCarForm.Controls.Add(Me.butClearGarage)
        Me.grpCarForm.Controls.Add(Me.butSearchBColorForm)
        Me.grpCarForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCarForm.ForeColor = System.Drawing.Color.Red
        Me.grpCarForm.Location = New System.Drawing.Point(13, 9)
        Me.grpCarForm.Name = "grpCarForm"
        Me.grpCarForm.Size = New System.Drawing.Size(1140, 721)
        Me.grpCarForm.TabIndex = 71
        Me.grpCarForm.TabStop = False
        Me.grpCarForm.Text = "Colors - Delete Sync"
        '
        'chkBColorFormCode
        '
        Me.chkBColorFormCode.AutoSize = True
        Me.chkBColorFormCode.Checked = True
        Me.chkBColorFormCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBColorFormCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormCode.Location = New System.Drawing.Point(317, 29)
        Me.chkBColorFormCode.Name = "chkBColorFormCode"
        Me.chkBColorFormCode.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormCode.TabIndex = 224
        Me.chkBColorFormCode.Text = "Contains"
        Me.chkBColorFormCode.UseVisualStyleBackColor = True
        '
        'txtBColorCodeForm
        '
        Me.txtBColorCodeForm.Location = New System.Drawing.Point(162, 25)
        Me.txtBColorCodeForm.Name = "txtBColorCodeForm"
        Me.txtBColorCodeForm.Size = New System.Drawing.Size(149, 23)
        Me.txtBColorCodeForm.TabIndex = 209
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 15)
        Me.Label21.TabIndex = 223
        Me.Label21.Text = "BColor code:"
        '
        'chkBColorFormName
        '
        Me.chkBColorFormName.AutoSize = True
        Me.chkBColorFormName.Checked = True
        Me.chkBColorFormName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBColorFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBColorFormName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBColorFormName.Location = New System.Drawing.Point(317, 58)
        Me.chkBColorFormName.Name = "chkBColorFormName"
        Me.chkBColorFormName.Size = New System.Drawing.Size(75, 17)
        Me.chkBColorFormName.TabIndex = 215
        Me.chkBColorFormName.Text = "Contains"
        Me.chkBColorFormName.UseVisualStyleBackColor = True
        '
        'txtBColorNameForm
        '
        Me.txtBColorNameForm.Location = New System.Drawing.Point(162, 54)
        Me.txtBColorNameForm.Name = "txtBColorNameForm"
        Me.txtBColorNameForm.Size = New System.Drawing.Size(149, 23)
        Me.txtBColorNameForm.TabIndex = 210
        '
        'lbBColorNameForm
        '
        Me.lbBColorNameForm.AutoSize = True
        Me.lbBColorNameForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBColorNameForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbBColorNameForm.Location = New System.Drawing.Point(8, 54)
        Me.lbBColorNameForm.Name = "lbBColorNameForm"
        Me.lbBColorNameForm.Size = New System.Drawing.Size(94, 15)
        Me.lbBColorNameForm.TabIndex = 214
        Me.lbBColorNameForm.Text = "BColor name:"
        '
        'lsvBColors
        '
        Me.lsvBColors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvBColors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidBColor, Me.ColumnHeader2, Me.ColumnHeader10})
        Me.lsvBColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvBColors.FullRowSelect = True
        Me.lsvBColors.GridLines = True
        Me.lsvBColors.HideSelection = False
        Me.lsvBColors.Location = New System.Drawing.Point(8, 228)
        Me.lsvBColors.Name = "lsvBColors"
        Me.lsvBColors.Size = New System.Drawing.Size(1128, 487)
        Me.lsvBColors.TabIndex = 213
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
        Me.ColumnHeader2.Width = 407
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Name"
        Me.ColumnHeader10.Width = 847
        '
        'lbIdBColorForm
        '
        Me.lbIdBColorForm.AutoSize = True
        Me.lbIdBColorForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdBColorForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdBColorForm.Location = New System.Drawing.Point(8, 194)
        Me.lbIdBColorForm.Name = "lbIdBColorForm"
        Me.lbIdBColorForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdBColorForm.TabIndex = 225
        Me.lbIdBColorForm.Text = "-1"
        Me.lbIdBColorForm.Visible = False
        '
        'colorsDeleteSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 742)
        Me.Controls.Add(Me.grpCarForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "colorsDeleteSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Sync"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpCarForm.ResumeLayout(False)
        Me.grpCarForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fileDialogCar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents butSearchBColorForm As System.Windows.Forms.Button
    Friend WithEvents butClearGarage As System.Windows.Forms.Button
    Friend WithEvents ButGoBack As System.Windows.Forms.Button
    Friend WithEvents butAddToSync As System.Windows.Forms.Button
    Friend WithEvents butSelectAll As System.Windows.Forms.Button
    Friend WithEvents butListSelected As System.Windows.Forms.Button
    Friend WithEvents butRemoveFromSync As System.Windows.Forms.Button
    Friend WithEvents grpCarForm As System.Windows.Forms.GroupBox
    Friend WithEvents chkBColorFormCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorCodeForm As HeadQApplication.MyTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chkBColorFormName As System.Windows.Forms.CheckBox
    Friend WithEvents txtBColorNameForm As HeadQApplication.MyTextBox
    Friend WithEvents lbBColorNameForm As System.Windows.Forms.Label
    Friend WithEvents lsvBColors As HeadQApplication.MyListView
    Friend WithEvents cidBColor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbIdBColorForm As System.Windows.Forms.Label
End Class
