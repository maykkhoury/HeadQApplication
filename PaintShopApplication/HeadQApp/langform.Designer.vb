<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class langForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(langForm))
        Me.grpLanguageForm = New System.Windows.Forms.GroupBox()
        Me.butChooseLang = New System.Windows.Forms.Button()
        Me.butDeleteLangForm = New System.Windows.Forms.Button()
        Me.lbIdLanguageForm = New System.Windows.Forms.Label()
        Me.butEditLangForm = New System.Windows.Forms.Button()
        Me.chLanguageLabelForm = New System.Windows.Forms.CheckBox()
        Me.txtLanguageLabelForm = New HeadQApplication.MyTextBox()
        Me.lbModelCarForm = New System.Windows.Forms.Label()
        Me.butAddLang = New System.Windows.Forms.Button()
        Me.chkLanguageFormCode = New System.Windows.Forms.CheckBox()
        Me.txtLanguageCodeForm = New HeadQApplication.MyTextBox()
        Me.lbCarNameForm = New System.Windows.Forms.Label()
        Me.lsvLanguage = New System.Windows.Forms.ListView()
        Me.cidLang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.butSearchLangForm = New System.Windows.Forms.Button()
        Me.grpLanguageForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLanguageForm
        '
        Me.grpLanguageForm.BackColor = System.Drawing.Color.Transparent
        Me.grpLanguageForm.Controls.Add(Me.butChooseLang)
        Me.grpLanguageForm.Controls.Add(Me.butDeleteLangForm)
        Me.grpLanguageForm.Controls.Add(Me.lbIdLanguageForm)
        Me.grpLanguageForm.Controls.Add(Me.butEditLangForm)
        Me.grpLanguageForm.Controls.Add(Me.chLanguageLabelForm)
        Me.grpLanguageForm.Controls.Add(Me.txtLanguageLabelForm)
        Me.grpLanguageForm.Controls.Add(Me.lbModelCarForm)
        Me.grpLanguageForm.Controls.Add(Me.butAddLang)
        Me.grpLanguageForm.Controls.Add(Me.chkLanguageFormCode)
        Me.grpLanguageForm.Controls.Add(Me.txtLanguageCodeForm)
        Me.grpLanguageForm.Controls.Add(Me.lbCarNameForm)
        Me.grpLanguageForm.Controls.Add(Me.lsvLanguage)
        Me.grpLanguageForm.Controls.Add(Me.butSearchLangForm)
        Me.grpLanguageForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLanguageForm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpLanguageForm.Location = New System.Drawing.Point(12, 12)
        Me.grpLanguageForm.Name = "grpLanguageForm"
        Me.grpLanguageForm.Size = New System.Drawing.Size(961, 490)
        Me.grpLanguageForm.TabIndex = 67
        Me.grpLanguageForm.TabStop = False
        Me.grpLanguageForm.Text = "Languages"
        '
        'butChooseLang
        '
        Me.butChooseLang.BackColor = System.Drawing.SystemColors.Control
        Me.butChooseLang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butChooseLang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butChooseLang.Location = New System.Drawing.Point(838, 20)
        Me.butChooseLang.Name = "butChooseLang"
        Me.butChooseLang.Size = New System.Drawing.Size(113, 78)
        Me.butChooseLang.TabIndex = 78
        Me.butChooseLang.Text = "Choose"
        Me.butChooseLang.UseVisualStyleBackColor = False
        '
        'butDeleteLangForm
        '
        Me.butDeleteLangForm.BackColor = System.Drawing.SystemColors.Control
        Me.butDeleteLangForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDeleteLangForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butDeleteLangForm.Location = New System.Drawing.Point(600, 20)
        Me.butDeleteLangForm.Name = "butDeleteLangForm"
        Me.butDeleteLangForm.Size = New System.Drawing.Size(113, 78)
        Me.butDeleteLangForm.TabIndex = 77
        Me.butDeleteLangForm.Text = "Delete Selected"
        Me.butDeleteLangForm.UseVisualStyleBackColor = False
        '
        'lbIdLanguageForm
        '
        Me.lbIdLanguageForm.AutoSize = True
        Me.lbIdLanguageForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdLanguageForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdLanguageForm.Location = New System.Drawing.Point(16, 109)
        Me.lbIdLanguageForm.Name = "lbIdLanguageForm"
        Me.lbIdLanguageForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdLanguageForm.TabIndex = 76
        Me.lbIdLanguageForm.Text = "-1"
        Me.lbIdLanguageForm.Visible = False
        '
        'butEditLangForm
        '
        Me.butEditLangForm.BackColor = System.Drawing.SystemColors.Control
        Me.butEditLangForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEditLangForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butEditLangForm.Location = New System.Drawing.Point(481, 20)
        Me.butEditLangForm.Name = "butEditLangForm"
        Me.butEditLangForm.Size = New System.Drawing.Size(113, 78)
        Me.butEditLangForm.TabIndex = 75
        Me.butEditLangForm.Text = "Edit Selected"
        Me.butEditLangForm.UseVisualStyleBackColor = False
        '
        'chLanguageLabelForm
        '
        Me.chLanguageLabelForm.AutoSize = True
        Me.chLanguageLabelForm.Location = New System.Drawing.Point(319, 77)
        Me.chLanguageLabelForm.Name = "chLanguageLabelForm"
        Me.chLanguageLabelForm.Size = New System.Drawing.Size(15, 14)
        Me.chLanguageLabelForm.TabIndex = 74
        Me.chLanguageLabelForm.UseVisualStyleBackColor = True
        '
        'txtLanguageLabelForm
        '
        Me.txtLanguageLabelForm.Location = New System.Drawing.Point(126, 75)
        Me.txtLanguageLabelForm.Name = "txtLanguageLabelForm"
        Me.txtLanguageLabelForm.Size = New System.Drawing.Size(187, 23)
        Me.txtLanguageLabelForm.TabIndex = 73
        '
        'lbModelCarForm
        '
        Me.lbModelCarForm.AutoSize = True
        Me.lbModelCarForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModelCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbModelCarForm.Location = New System.Drawing.Point(16, 75)
        Me.lbModelCarForm.Name = "lbModelCarForm"
        Me.lbModelCarForm.Size = New System.Drawing.Size(43, 15)
        Me.lbModelCarForm.TabIndex = 72
        Me.lbModelCarForm.Text = "Label"
        '
        'butAddLang
        '
        Me.butAddLang.BackColor = System.Drawing.SystemColors.Control
        Me.butAddLang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddLang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butAddLang.Location = New System.Drawing.Point(362, 20)
        Me.butAddLang.Name = "butAddLang"
        Me.butAddLang.Size = New System.Drawing.Size(113, 78)
        Me.butAddLang.TabIndex = 71
        Me.butAddLang.Text = "Add New"
        Me.butAddLang.UseVisualStyleBackColor = False
        '
        'chkLanguageFormCode
        '
        Me.chkLanguageFormCode.AutoSize = True
        Me.chkLanguageFormCode.Location = New System.Drawing.Point(319, 27)
        Me.chkLanguageFormCode.Name = "chkLanguageFormCode"
        Me.chkLanguageFormCode.Size = New System.Drawing.Size(15, 14)
        Me.chkLanguageFormCode.TabIndex = 70
        Me.chkLanguageFormCode.UseVisualStyleBackColor = True
        '
        'txtLanguageCodeForm
        '
        Me.txtLanguageCodeForm.Location = New System.Drawing.Point(126, 25)
        Me.txtLanguageCodeForm.Name = "txtLanguageCodeForm"
        Me.txtLanguageCodeForm.Size = New System.Drawing.Size(187, 23)
        Me.txtLanguageCodeForm.TabIndex = 69
        '
        'lbCarNameForm
        '
        Me.lbCarNameForm.AutoSize = True
        Me.lbCarNameForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCarNameForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarNameForm.Location = New System.Drawing.Point(16, 25)
        Me.lbCarNameForm.Name = "lbCarNameForm"
        Me.lbCarNameForm.Size = New System.Drawing.Size(40, 15)
        Me.lbCarNameForm.TabIndex = 68
        Me.lbCarNameForm.Text = "Code"
        '
        'lsvLanguage
        '
        Me.lsvLanguage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvLanguage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidLang, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lsvLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvLanguage.FullRowSelect = True
        Me.lsvLanguage.GridLines = True
        Me.lsvLanguage.HideSelection = False
        Me.lsvLanguage.Location = New System.Drawing.Point(10, 133)
        Me.lsvLanguage.MultiSelect = False
        Me.lsvLanguage.Name = "lsvLanguage"
        Me.lsvLanguage.Size = New System.Drawing.Size(945, 351)
        Me.lsvLanguage.TabIndex = 55
        Me.lsvLanguage.UseCompatibleStateImageBehavior = False
        Me.lsvLanguage.View = System.Windows.Forms.View.Details
        '
        'cidLang
        '
        Me.cidLang.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 400
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Label"
        Me.ColumnHeader2.Width = 300
        '
        'butSearchLangForm
        '
        Me.butSearchLangForm.BackColor = System.Drawing.SystemColors.Control
        Me.butSearchLangForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSearchLangForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSearchLangForm.Location = New System.Drawing.Point(719, 20)
        Me.butSearchLangForm.Name = "butSearchLangForm"
        Me.butSearchLangForm.Size = New System.Drawing.Size(113, 78)
        Me.butSearchLangForm.TabIndex = 9
        Me.butSearchLangForm.Text = "Find"
        Me.butSearchLangForm.UseVisualStyleBackColor = False
        '
        'langform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 632)
        Me.Controls.Add(Me.grpLanguageForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "langform"
        Me.Text = "Choose"
        Me.grpLanguageForm.ResumeLayout(False)
        Me.grpLanguageForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpLanguageForm As System.Windows.Forms.GroupBox
    Friend WithEvents butDeleteLangForm As System.Windows.Forms.Button
    Friend WithEvents lbIdLanguageForm As System.Windows.Forms.Label
    Friend WithEvents butEditLangForm As System.Windows.Forms.Button
    Friend WithEvents chLanguageLabelForm As System.Windows.Forms.CheckBox
    Friend WithEvents txtLanguageLabelForm As MyTextBox
    Friend WithEvents lbModelCarForm As System.Windows.Forms.Label
    Friend WithEvents butAddLang As System.Windows.Forms.Button
    Friend WithEvents chkLanguageFormCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtLanguageCodeForm As MyTextBox
    Friend WithEvents lbCarNameForm As System.Windows.Forms.Label
    Friend WithEvents lsvLanguage As System.Windows.Forms.ListView
    Friend WithEvents cidLang As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents butSearchLangForm As System.Windows.Forms.Button
    Friend WithEvents butChooseLang As System.Windows.Forms.Button
End Class
