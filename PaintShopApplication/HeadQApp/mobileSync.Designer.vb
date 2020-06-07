<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mobileSync
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mobileSync))
        Me.lbFormulas = New System.Windows.Forms.Label()
        Me.butSelectGaragesForEdit = New System.Windows.Forms.Button()
        Me.grpLanguageForm = New System.Windows.Forms.GroupBox()
        Me.butAutoSelect = New System.Windows.Forms.Button()
        Me.butSelectFormulasForDelete = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.butSelectCarsForDelete = New System.Windows.Forms.Button()
        Me.butGenerate = New System.Windows.Forms.Button()
        Me.butSelectColorsForDelete = New System.Windows.Forms.Button()
        Me.butSelectGaragesForDelete = New System.Windows.Forms.Button()
        Me.butClear = New System.Windows.Forms.Button()
        Me.lbFormulasSyncResult = New System.Windows.Forms.Label()
        Me.lbCarsSyncResult = New System.Windows.Forms.Label()
        Me.lbColorsSyncResult = New System.Windows.Forms.Label()
        Me.lbGaragesSyncResult = New System.Windows.Forms.Label()
        Me.butSelectFormulasForEdit = New System.Windows.Forms.Button()
        Me.butSelectCarsForEdit = New System.Windows.Forms.Button()
        Me.butSelectColorsForEdit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FBrowserSync = New System.Windows.Forms.FolderBrowserDialog()
        Me.bgWorkerSelectChanges = New System.ComponentModel.BackgroundWorker()
        Me.lbProcessEnd = New System.Windows.Forms.Label()
        Me.txtcount = New System.Windows.Forms.TextBox()
        Me.butResetSynch = New System.Windows.Forms.Button()
        Me.grpLanguageForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbFormulas
        '
        Me.lbFormulas.AutoSize = True
        Me.lbFormulas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormulas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbFormulas.Location = New System.Drawing.Point(12, 139)
        Me.lbFormulas.Name = "lbFormulas"
        Me.lbFormulas.Size = New System.Drawing.Size(67, 15)
        Me.lbFormulas.TabIndex = 68
        Me.lbFormulas.Text = "Formulas"
        '
        'butSelectGaragesForEdit
        '
        Me.butSelectGaragesForEdit.BackColor = System.Drawing.SystemColors.Control
        Me.butSelectGaragesForEdit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSelectGaragesForEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSelectGaragesForEdit.Location = New System.Drawing.Point(94, 31)
        Me.butSelectGaragesForEdit.Name = "butSelectGaragesForEdit"
        Me.butSelectGaragesForEdit.Size = New System.Drawing.Size(150, 28)
        Me.butSelectGaragesForEdit.TabIndex = 71
        Me.butSelectGaragesForEdit.Text = "Select for edit"
        Me.butSelectGaragesForEdit.UseVisualStyleBackColor = False
        '
        'grpLanguageForm
        '
        Me.grpLanguageForm.BackColor = System.Drawing.Color.Transparent
        Me.grpLanguageForm.Controls.Add(Me.butAutoSelect)
        Me.grpLanguageForm.Controls.Add(Me.butSelectFormulasForDelete)
        Me.grpLanguageForm.Controls.Add(Me.butClose)
        Me.grpLanguageForm.Controls.Add(Me.butSelectCarsForDelete)
        Me.grpLanguageForm.Controls.Add(Me.butGenerate)
        Me.grpLanguageForm.Controls.Add(Me.butSelectColorsForDelete)
        Me.grpLanguageForm.Controls.Add(Me.butSelectGaragesForDelete)
        Me.grpLanguageForm.Controls.Add(Me.butClear)
        Me.grpLanguageForm.Controls.Add(Me.lbFormulasSyncResult)
        Me.grpLanguageForm.Controls.Add(Me.lbCarsSyncResult)
        Me.grpLanguageForm.Controls.Add(Me.lbColorsSyncResult)
        Me.grpLanguageForm.Controls.Add(Me.lbGaragesSyncResult)
        Me.grpLanguageForm.Controls.Add(Me.butSelectFormulasForEdit)
        Me.grpLanguageForm.Controls.Add(Me.butSelectCarsForEdit)
        Me.grpLanguageForm.Controls.Add(Me.butSelectColorsForEdit)
        Me.grpLanguageForm.Controls.Add(Me.Label3)
        Me.grpLanguageForm.Controls.Add(Me.Label2)
        Me.grpLanguageForm.Controls.Add(Me.Label1)
        Me.grpLanguageForm.Controls.Add(Me.butSelectGaragesForEdit)
        Me.grpLanguageForm.Controls.Add(Me.lbFormulas)
        Me.grpLanguageForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLanguageForm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpLanguageForm.Location = New System.Drawing.Point(12, 12)
        Me.grpLanguageForm.Name = "grpLanguageForm"
        Me.grpLanguageForm.Size = New System.Drawing.Size(760, 204)
        Me.grpLanguageForm.TabIndex = 67
        Me.grpLanguageForm.TabStop = False
        Me.grpLanguageForm.Text = "Select sync data"
        '
        'butAutoSelect
        '
        Me.butAutoSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butAutoSelect.BackColor = System.Drawing.SystemColors.Control
        Me.butAutoSelect.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAutoSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butAutoSelect.Location = New System.Drawing.Point(6, 172)
        Me.butAutoSelect.Name = "butAutoSelect"
        Me.butAutoSelect.Size = New System.Drawing.Size(238, 26)
        Me.butAutoSelect.TabIndex = 153
        Me.butAutoSelect.Text = "Select all changes"
        Me.butAutoSelect.UseVisualStyleBackColor = False
        '
        'butSelectFormulasForDelete
        '
        Me.butSelectFormulasForDelete.BackColor = System.Drawing.SystemColors.Control
        Me.butSelectFormulasForDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSelectFormulasForDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSelectFormulasForDelete.Location = New System.Drawing.Point(250, 133)
        Me.butSelectFormulasForDelete.Name = "butSelectFormulasForDelete"
        Me.butSelectFormulasForDelete.Size = New System.Drawing.Size(150, 28)
        Me.butSelectFormulasForDelete.TabIndex = 157
        Me.butSelectFormulasForDelete.Text = "Select for delete"
        Me.butSelectFormulasForDelete.UseVisualStyleBackColor = False
        '
        'butClose
        '
        Me.butClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butClose.BackColor = System.Drawing.SystemColors.Control
        Me.butClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClose.ForeColor = System.Drawing.Color.Red
        Me.butClose.Location = New System.Drawing.Point(669, 172)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(84, 26)
        Me.butClose.TabIndex = 151
        Me.butClose.Text = "Close"
        Me.butClose.UseVisualStyleBackColor = False
        '
        'butSelectCarsForDelete
        '
        Me.butSelectCarsForDelete.BackColor = System.Drawing.SystemColors.Control
        Me.butSelectCarsForDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSelectCarsForDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSelectCarsForDelete.Location = New System.Drawing.Point(250, 99)
        Me.butSelectCarsForDelete.Name = "butSelectCarsForDelete"
        Me.butSelectCarsForDelete.Size = New System.Drawing.Size(150, 28)
        Me.butSelectCarsForDelete.TabIndex = 156
        Me.butSelectCarsForDelete.Text = "Select for delete"
        Me.butSelectCarsForDelete.UseVisualStyleBackColor = False
        '
        'butGenerate
        '
        Me.butGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butGenerate.BackColor = System.Drawing.SystemColors.Control
        Me.butGenerate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butGenerate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butGenerate.Location = New System.Drawing.Point(569, 172)
        Me.butGenerate.Name = "butGenerate"
        Me.butGenerate.Size = New System.Drawing.Size(94, 26)
        Me.butGenerate.TabIndex = 150
        Me.butGenerate.Text = "Generate"
        Me.butGenerate.UseVisualStyleBackColor = False
        '
        'butSelectColorsForDelete
        '
        Me.butSelectColorsForDelete.BackColor = System.Drawing.SystemColors.Control
        Me.butSelectColorsForDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSelectColorsForDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSelectColorsForDelete.Location = New System.Drawing.Point(250, 65)
        Me.butSelectColorsForDelete.Name = "butSelectColorsForDelete"
        Me.butSelectColorsForDelete.Size = New System.Drawing.Size(150, 28)
        Me.butSelectColorsForDelete.TabIndex = 155
        Me.butSelectColorsForDelete.Text = "Select for delete"
        Me.butSelectColorsForDelete.UseVisualStyleBackColor = False
        '
        'butSelectGaragesForDelete
        '
        Me.butSelectGaragesForDelete.BackColor = System.Drawing.SystemColors.Control
        Me.butSelectGaragesForDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSelectGaragesForDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSelectGaragesForDelete.Location = New System.Drawing.Point(250, 31)
        Me.butSelectGaragesForDelete.Name = "butSelectGaragesForDelete"
        Me.butSelectGaragesForDelete.Size = New System.Drawing.Size(150, 28)
        Me.butSelectGaragesForDelete.TabIndex = 154
        Me.butSelectGaragesForDelete.Text = "Select for delete"
        Me.butSelectGaragesForDelete.UseVisualStyleBackColor = False
        '
        'butClear
        '
        Me.butClear.BackColor = System.Drawing.SystemColors.Control
        Me.butClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClear.ForeColor = System.Drawing.Color.Red
        Me.butClear.Location = New System.Drawing.Point(250, 172)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(150, 26)
        Me.butClear.TabIndex = 153
        Me.butClear.Text = "Clear"
        Me.butClear.UseVisualStyleBackColor = False
        '
        'lbFormulasSyncResult
        '
        Me.lbFormulasSyncResult.AutoSize = True
        Me.lbFormulasSyncResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormulasSyncResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbFormulasSyncResult.Location = New System.Drawing.Point(421, 139)
        Me.lbFormulasSyncResult.Name = "lbFormulasSyncResult"
        Me.lbFormulasSyncResult.Size = New System.Drawing.Size(88, 15)
        Me.lbFormulasSyncResult.TabIndex = 88
        Me.lbFormulasSyncResult.Text = "Result: none"
        '
        'lbCarsSyncResult
        '
        Me.lbCarsSyncResult.AutoSize = True
        Me.lbCarsSyncResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCarsSyncResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarsSyncResult.Location = New System.Drawing.Point(421, 105)
        Me.lbCarsSyncResult.Name = "lbCarsSyncResult"
        Me.lbCarsSyncResult.Size = New System.Drawing.Size(88, 15)
        Me.lbCarsSyncResult.TabIndex = 87
        Me.lbCarsSyncResult.Text = "Result: none"
        '
        'lbColorsSyncResult
        '
        Me.lbColorsSyncResult.AutoSize = True
        Me.lbColorsSyncResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbColorsSyncResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbColorsSyncResult.Location = New System.Drawing.Point(421, 71)
        Me.lbColorsSyncResult.Name = "lbColorsSyncResult"
        Me.lbColorsSyncResult.Size = New System.Drawing.Size(88, 15)
        Me.lbColorsSyncResult.TabIndex = 86
        Me.lbColorsSyncResult.Text = "Result: none"
        '
        'lbGaragesSyncResult
        '
        Me.lbGaragesSyncResult.AutoSize = True
        Me.lbGaragesSyncResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGaragesSyncResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbGaragesSyncResult.Location = New System.Drawing.Point(421, 37)
        Me.lbGaragesSyncResult.Name = "lbGaragesSyncResult"
        Me.lbGaragesSyncResult.Size = New System.Drawing.Size(88, 15)
        Me.lbGaragesSyncResult.TabIndex = 85
        Me.lbGaragesSyncResult.Text = "Result: none"
        '
        'butSelectFormulasForEdit
        '
        Me.butSelectFormulasForEdit.BackColor = System.Drawing.SystemColors.Control
        Me.butSelectFormulasForEdit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSelectFormulasForEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSelectFormulasForEdit.Location = New System.Drawing.Point(94, 133)
        Me.butSelectFormulasForEdit.Name = "butSelectFormulasForEdit"
        Me.butSelectFormulasForEdit.Size = New System.Drawing.Size(150, 28)
        Me.butSelectFormulasForEdit.TabIndex = 84
        Me.butSelectFormulasForEdit.Text = "Select for edit"
        Me.butSelectFormulasForEdit.UseVisualStyleBackColor = False
        '
        'butSelectCarsForEdit
        '
        Me.butSelectCarsForEdit.BackColor = System.Drawing.SystemColors.Control
        Me.butSelectCarsForEdit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSelectCarsForEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSelectCarsForEdit.Location = New System.Drawing.Point(94, 99)
        Me.butSelectCarsForEdit.Name = "butSelectCarsForEdit"
        Me.butSelectCarsForEdit.Size = New System.Drawing.Size(150, 28)
        Me.butSelectCarsForEdit.TabIndex = 83
        Me.butSelectCarsForEdit.Text = "Select for edit"
        Me.butSelectCarsForEdit.UseVisualStyleBackColor = False
        '
        'butSelectColorsForEdit
        '
        Me.butSelectColorsForEdit.BackColor = System.Drawing.SystemColors.Control
        Me.butSelectColorsForEdit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSelectColorsForEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSelectColorsForEdit.Location = New System.Drawing.Point(94, 65)
        Me.butSelectColorsForEdit.Name = "butSelectColorsForEdit"
        Me.butSelectColorsForEdit.Size = New System.Drawing.Size(150, 28)
        Me.butSelectColorsForEdit.TabIndex = 82
        Me.butSelectColorsForEdit.Text = "Select for edit"
        Me.butSelectColorsForEdit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Garages"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Colors"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Cars"
        '
        'bgWorkerSelectChanges
        '
        '
        'lbProcessEnd
        '
        Me.lbProcessEnd.AutoSize = True
        Me.lbProcessEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProcessEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbProcessEnd.Location = New System.Drawing.Point(419, 235)
        Me.lbProcessEnd.Name = "lbProcessEnd"
        Me.lbProcessEnd.Size = New System.Drawing.Size(65, 15)
        Me.lbProcessEnd.TabIndex = 158
        Me.lbProcessEnd.Text = "message"
        '
        'txtcount
        '
        Me.txtcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcount.Location = New System.Drawing.Point(18, 226)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.ReadOnly = True
        Me.txtcount.Size = New System.Drawing.Size(394, 21)
        Me.txtcount.TabIndex = 163
        '
        'butResetSynch
        '
        Me.butResetSynch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butResetSynch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butResetSynch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butResetSynch.ForeColor = System.Drawing.Color.Red
        Me.butResetSynch.Location = New System.Drawing.Point(581, 224)
        Me.butResetSynch.Name = "butResetSynch"
        Me.butResetSynch.Size = New System.Drawing.Size(184, 26)
        Me.butResetSynch.TabIndex = 164
        Me.butResetSynch.Text = "Reset Synch"
        Me.butResetSynch.UseVisualStyleBackColor = False
        '
        'mobileSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 259)
        Me.Controls.Add(Me.butResetSynch)
        Me.Controls.Add(Me.txtcount)
        Me.Controls.Add(Me.lbProcessEnd)
        Me.Controls.Add(Me.grpLanguageForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "mobileSync"
        Me.Text = "Mobile Sync"
        Me.grpLanguageForm.ResumeLayout(false)
        Me.grpLanguageForm.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lbFormulas As System.Windows.Forms.Label
    Friend WithEvents butSelectGaragesForEdit As System.Windows.Forms.Button
    Friend WithEvents grpLanguageForm As System.Windows.Forms.GroupBox
    Friend WithEvents lbFormulasSyncResult As System.Windows.Forms.Label
    Friend WithEvents lbCarsSyncResult As System.Windows.Forms.Label
    Friend WithEvents lbColorsSyncResult As System.Windows.Forms.Label
    Friend WithEvents lbGaragesSyncResult As System.Windows.Forms.Label
    Friend WithEvents butSelectFormulasForEdit As System.Windows.Forms.Button
    Friend WithEvents butSelectCarsForEdit As System.Windows.Forms.Button
    Friend WithEvents butSelectColorsForEdit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents butGenerate As System.Windows.Forms.Button
    Friend WithEvents FBrowserSync As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents butClear As System.Windows.Forms.Button
    Friend WithEvents butSelectFormulasForDelete As System.Windows.Forms.Button
    Friend WithEvents butSelectCarsForDelete As System.Windows.Forms.Button
    Friend WithEvents butSelectColorsForDelete As System.Windows.Forms.Button
    Friend WithEvents butSelectGaragesForDelete As System.Windows.Forms.Button
    Friend WithEvents butAutoSelect As System.Windows.Forms.Button
    Friend WithEvents bgWorkerSelectChanges As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbProcessEnd As System.Windows.Forms.Label
    Friend WithEvents txtcount As System.Windows.Forms.TextBox
    Friend WithEvents butResetSynch As System.Windows.Forms.Button
End Class
