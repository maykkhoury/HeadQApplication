<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TranslateForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TranslateForm))
        Me.lsvLabels = New System.Windows.Forms.ListView()
        Me.cidLang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbTranslateToValue = New System.Windows.Forms.Label()
        Me.lbTranslateTo = New System.Windows.Forms.Label()
        Me.lbIdLabel = New System.Windows.Forms.Label()
        Me.txtLabelNew = New HeadQApplication.MyTextBox()
        Me.butSave = New System.Windows.Forms.Button()
        Me.lbLabelName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lsvLabels
        '
        Me.lsvLabels.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvLabels.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidLang, Me.ColumnHeader4, Me.ColumnHeader1})
        Me.lsvLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvLabels.FullRowSelect = True
        Me.lsvLabels.GridLines = True
        Me.lsvLabels.HideSelection = False
        Me.lsvLabels.Location = New System.Drawing.Point(12, 145)
        Me.lsvLabels.MultiSelect = False
        Me.lsvLabels.Name = "lsvLabels"
        Me.lsvLabels.Size = New System.Drawing.Size(525, 397)
        Me.lsvLabels.TabIndex = 56
        Me.lsvLabels.UseCompatibleStateImageBehavior = False
        Me.lsvLabels.View = System.Windows.Forms.View.Details
        '
        'cidLang
        '
        Me.cidLang.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Label"
        Me.ColumnHeader4.Width = 500
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'lbTranslateToValue
        '
        Me.lbTranslateToValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTranslateToValue.AutoSize = True
        Me.lbTranslateToValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTranslateToValue.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbTranslateToValue.Location = New System.Drawing.Point(303, 9)
        Me.lbTranslateToValue.Name = "lbTranslateToValue"
        Me.lbTranslateToValue.Size = New System.Drawing.Size(21, 15)
        Me.lbTranslateToValue.TabIndex = 108
        Me.lbTranslateToValue.Text = "- -"
        '
        'lbTranslateTo
        '
        Me.lbTranslateTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTranslateTo.AutoSize = True
        Me.lbTranslateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTranslateTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTranslateTo.Location = New System.Drawing.Point(169, 9)
        Me.lbTranslateTo.Name = "lbTranslateTo"
        Me.lbTranslateTo.Size = New System.Drawing.Size(99, 15)
        Me.lbTranslateTo.TabIndex = 107
        Me.lbTranslateTo.Text = "Translation to:"
        '
        'lbIdLabel
        '
        Me.lbIdLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbIdLabel.AutoSize = True
        Me.lbIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdLabel.Location = New System.Drawing.Point(12, 113)
        Me.lbIdLabel.Name = "lbIdLabel"
        Me.lbIdLabel.Size = New System.Drawing.Size(20, 15)
        Me.lbIdLabel.TabIndex = 109
        Me.lbIdLabel.Text = "-1"
        Me.lbIdLabel.Visible = False
        '
        'txtLabelNew
        '
        Me.txtLabelNew.Location = New System.Drawing.Point(15, 61)
        Me.txtLabelNew.Name = "txtLabelNew"
        Me.txtLabelNew.Size = New System.Drawing.Size(238, 20)
        Me.txtLabelNew.TabIndex = 110
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.SystemColors.Control
        Me.butSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSave.Location = New System.Drawing.Point(273, 50)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(113, 78)
        Me.butSave.TabIndex = 111
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'lbLabelName
        '
        Me.lbLabelName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLabelName.AutoSize = True
        Me.lbLabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLabelName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbLabelName.Location = New System.Drawing.Point(38, 113)
        Me.lbLabelName.Name = "lbLabelName"
        Me.lbLabelName.Size = New System.Drawing.Size(20, 15)
        Me.lbLabelName.TabIndex = 112
        Me.lbLabelName.Text = "-1"
        Me.lbLabelName.Visible = False
        '
        'TranslateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 554)
        Me.Controls.Add(Me.lbLabelName)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.txtLabelNew)
        Me.Controls.Add(Me.lbIdLabel)
        Me.Controls.Add(Me.lbTranslateToValue)
        Me.Controls.Add(Me.lbTranslateTo)
        Me.Controls.Add(Me.lsvLabels)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TranslateForm"
        Me.Text = "TranslateForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvLabels As System.Windows.Forms.ListView
    Friend WithEvents cidLang As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbTranslateToValue As System.Windows.Forms.Label
    Friend WithEvents lbTranslateTo As System.Windows.Forms.Label
    Friend WithEvents lbIdLabel As System.Windows.Forms.Label
    Friend WithEvents txtLabelNew As MyTextBox
    Friend WithEvents butSave As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbLabelName As System.Windows.Forms.Label
End Class
