<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assignColor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(assignColor))
        Me.lsvColor = New System.Windows.Forms.ListView()
        Me.cccode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbQty = New System.Windows.Forms.Label()
        Me.butChoose = New System.Windows.Forms.Button()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.lbUnitMesureValue = New System.Windows.Forms.Label()
        Me.lbUnitMesure = New System.Windows.Forms.Label()
        Me.txtQty = New HeadQApplication.MyTextBox()
        Me.SuspendLayout()
        '
        'lsvColor
        '
        Me.lsvColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvColor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cccode, Me.cname})
        Me.lsvColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvColor.FullRowSelect = True
        Me.lsvColor.GridLines = True
        Me.lsvColor.HideSelection = False
        Me.lsvColor.Location = New System.Drawing.Point(12, 57)
        Me.lsvColor.MultiSelect = False
        Me.lsvColor.Name = "lsvColor"
        Me.lsvColor.Size = New System.Drawing.Size(614, 227)
        Me.lsvColor.TabIndex = 56
        Me.lsvColor.UseCompatibleStateImageBehavior = False
        Me.lsvColor.View = System.Windows.Forms.View.Details
        '
        'cccode
        '
        Me.cccode.Text = "Color Code"
        Me.cccode.Width = 278
        '
        'cname
        '
        Me.cname.Text = "Name"
        Me.cname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cname.Width = 300
        '
        'lbQty
        '
        Me.lbQty.AutoSize = True
        Me.lbQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbQty.Location = New System.Drawing.Point(14, 21)
        Me.lbQty.Name = "lbQty"
        Me.lbQty.Size = New System.Drawing.Size(63, 15)
        Me.lbQty.TabIndex = 70
        Me.lbQty.Text = "Quantity:"
        '
        'butChoose
        '
        Me.butChoose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butChoose.BackColor = System.Drawing.SystemColors.Control
        Me.butChoose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butChoose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butChoose.Location = New System.Drawing.Point(448, 295)
        Me.butChoose.Name = "butChoose"
        Me.butChoose.Size = New System.Drawing.Size(181, 31)
        Me.butChoose.TabIndex = 72
        Me.butChoose.Text = "Choose"
        Me.butChoose.UseVisualStyleBackColor = False
        '
        'butCancel
        '
        Me.butCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancel.BackColor = System.Drawing.SystemColors.Control
        Me.butCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butCancel.Location = New System.Drawing.Point(261, 295)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(181, 31)
        Me.butCancel.TabIndex = 73
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = False
        '
        'lbUnitMesureValue
        '
        Me.lbUnitMesureValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbUnitMesureValue.AutoSize = True
        Me.lbUnitMesureValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnitMesureValue.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbUnitMesureValue.Location = New System.Drawing.Point(601, 21)
        Me.lbUnitMesureValue.Name = "lbUnitMesureValue"
        Me.lbUnitMesureValue.Size = New System.Drawing.Size(21, 15)
        Me.lbUnitMesureValue.TabIndex = 106
        Me.lbUnitMesureValue.Text = "- -"
        '
        'lbUnitMesure
        '
        Me.lbUnitMesure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbUnitMesure.AutoSize = True
        Me.lbUnitMesure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnitMesure.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbUnitMesure.Location = New System.Drawing.Point(558, 21)
        Me.lbUnitMesure.Name = "lbUnitMesure"
        Me.lbUnitMesure.Size = New System.Drawing.Size(37, 15)
        Me.lbUnitMesure.TabIndex = 105
        Me.lbUnitMesure.Text = "Unit:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(83, 21)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(148, 20)
        Me.txtQty.TabIndex = 71
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'assignColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 333)
        Me.Controls.Add(Me.lbUnitMesureValue)
        Me.Controls.Add(Me.lbUnitMesure)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butChoose)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lbQty)
        Me.Controls.Add(Me.lsvColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "assignColor"
        Me.Text = "Add Color"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvColor As System.Windows.Forms.ListView
    Friend WithEvents cname As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtQty As MyTextBox
    Friend WithEvents lbQty As System.Windows.Forms.Label
    Friend WithEvents butChoose As System.Windows.Forms.Button
    Friend WithEvents butCancel As System.Windows.Forms.Button
    Friend WithEvents lbUnitMesureValue As System.Windows.Forms.Label
    Friend WithEvents lbUnitMesure As System.Windows.Forms.Label
    Friend WithEvents cccode As System.Windows.Forms.ColumnHeader
End Class
