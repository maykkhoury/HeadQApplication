<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMoreCars
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.chkBoxCars = New System.Windows.Forms.CheckedListBox()
        Me.pctCarImg = New System.Windows.Forms.PictureBox()
        Me.butUncheck = New System.Windows.Forms.Button()
        Me.butOk = New System.Windows.Forms.Button()
        Me.lbCarIdCombo = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbNote = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pctCarImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.butCancel)
        Me.Panel1.Controls.Add(Me.chkBoxCars)
        Me.Panel1.Controls.Add(Me.pctCarImg)
        Me.Panel1.Controls.Add(Me.butUncheck)
        Me.Panel1.Controls.Add(Me.butOk)
        Me.Panel1.Controls.Add(Me.lbCarIdCombo)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 269)
        Me.Panel1.TabIndex = 0
        '
        'butCancel
        '
        Me.butCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCancel.Location = New System.Drawing.Point(534, 243)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(227, 23)
        Me.butCancel.TabIndex = 161
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'chkBoxCars
        '
        Me.chkBoxCars.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkBoxCars.CheckOnClick = True
        Me.chkBoxCars.FormattingEnabled = True
        Me.chkBoxCars.Location = New System.Drawing.Point(14, 33)
        Me.chkBoxCars.Name = "chkBoxCars"
        Me.chkBoxCars.Size = New System.Drawing.Size(498, 229)
        Me.chkBoxCars.TabIndex = 160
        '
        'pctCarImg
        '
        Me.pctCarImg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pctCarImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctCarImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctCarImg.Location = New System.Drawing.Point(534, 8)
        Me.pctCarImg.Margin = New System.Windows.Forms.Padding(4)
        Me.pctCarImg.Name = "pctCarImg"
        Me.pctCarImg.Size = New System.Drawing.Size(226, 188)
        Me.pctCarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCarImg.TabIndex = 159
        Me.pctCarImg.TabStop = False
        '
        'butUncheck
        '
        Me.butUncheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butUncheck.BackColor = System.Drawing.SystemColors.Control
        Me.butUncheck.Font = New System.Drawing.Font("Verdana", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butUncheck.ForeColor = System.Drawing.Color.Black
        Me.butUncheck.Location = New System.Drawing.Point(441, 5)
        Me.butUncheck.Margin = New System.Windows.Forms.Padding(4)
        Me.butUncheck.Name = "butUncheck"
        Me.butUncheck.Size = New System.Drawing.Size(71, 21)
        Me.butUncheck.TabIndex = 158
        Me.butUncheck.Text = "Clear"
        Me.butUncheck.UseVisualStyleBackColor = False
        '
        'butOk
        '
        Me.butOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butOk.Location = New System.Drawing.Point(534, 217)
        Me.butOk.Name = "butOk"
        Me.butOk.Size = New System.Drawing.Size(227, 23)
        Me.butOk.TabIndex = 157
        Me.butOk.Text = "Ok"
        Me.butOk.UseVisualStyleBackColor = True
        '
        'lbCarIdCombo
        '
        Me.lbCarIdCombo.AutoSize = True
        Me.lbCarIdCombo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarIdCombo.Location = New System.Drawing.Point(129, 13)
        Me.lbCarIdCombo.Name = "lbCarIdCombo"
        Me.lbCarIdCombo.Size = New System.Drawing.Size(16, 13)
        Me.lbCarIdCombo.TabIndex = 140
        Me.lbCarIdCombo.Text = "-1"
        Me.lbCarIdCombo.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(20, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 13)
        Me.Label23.TabIndex = 139
        Me.Label23.Text = "Cars:"
        '
        'lbNote
        '
        Me.lbNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbNote.AutoSize = True
        Me.lbNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNote.Location = New System.Drawing.Point(16, 294)
        Me.lbNote.Name = "lbNote"
        Me.lbNote.Size = New System.Drawing.Size(17, 13)
        Me.lbNote.TabIndex = 1
        Me.lbNote.Text = "lb"
        '
        'addMoreCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 337)
        Me.Controls.Add(Me.lbNote)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "addMoreCars"
        Me.Text = "Multiple Cars Mode"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pctCarImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbCarIdCombo As System.Windows.Forms.Label
    Friend WithEvents butOk As System.Windows.Forms.Button
    Friend WithEvents butUncheck As System.Windows.Forms.Button
    Friend WithEvents pctCarImg As System.Windows.Forms.PictureBox
    Friend WithEvents chkBoxCars As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents butCancel As System.Windows.Forms.Button
    Friend WithEvents lbNote As System.Windows.Forms.Label
End Class
