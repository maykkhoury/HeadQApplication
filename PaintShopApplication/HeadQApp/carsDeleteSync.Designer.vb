<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carsDeleteSync
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(carsDeleteSync))
        Me.fileDialogCar = New System.Windows.Forms.OpenFileDialog()
        Me.butSearchCarForm = New System.Windows.Forms.Button()
        Me.butClearGarage = New System.Windows.Forms.Button()
        Me.ButGoBack = New System.Windows.Forms.Button()
        Me.butAddToSync = New System.Windows.Forms.Button()
        Me.butSelectAll = New System.Windows.Forms.Button()
        Me.butListSelected = New System.Windows.Forms.Button()
        Me.butRemoveFromSync = New System.Windows.Forms.Button()
        Me.grpCarForm = New System.Windows.Forms.GroupBox()
        Me.lbIdCarForm = New System.Windows.Forms.Label()
        Me.lsvCars = New HeadQApplication.MyListView()
        Me.cidcar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtfnamehideen = New HeadQApplication.MyTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pctCarImg = New System.Windows.Forms.PictureBox()
        Me.butFindCarImg = New System.Windows.Forms.Button()
        Me.txtCarImgPath = New HeadQApplication.MyTextBox()
        Me.lbCarImgPath = New System.Windows.Forms.Label()
        Me.chkCarFormName = New System.Windows.Forms.CheckBox()
        Me.txtCarNameForm = New HeadQApplication.MyTextBox()
        Me.lbCarNameForm = New System.Windows.Forms.Label()
        Me.grpCarForm.SuspendLayout()
        CType(Me.pctCarImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fileDialogCar
        '
        Me.fileDialogCar.FileName = " "
        '
        'butSearchCarForm
        '
        Me.butSearchCarForm.BackColor = System.Drawing.SystemColors.Control
        Me.butSearchCarForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSearchCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butSearchCarForm.Location = New System.Drawing.Point(414, 23)
        Me.butSearchCarForm.Name = "butSearchCarForm"
        Me.butSearchCarForm.Size = New System.Drawing.Size(113, 78)
        Me.butSearchCarForm.TabIndex = 9
        Me.butSearchCarForm.Text = "Find"
        Me.butSearchCarForm.UseVisualStyleBackColor = False
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
        Me.grpCarForm.Controls.Add(Me.lbIdCarForm)
        Me.grpCarForm.Controls.Add(Me.lsvCars)
        Me.grpCarForm.Controls.Add(Me.txtfnamehideen)
        Me.grpCarForm.Controls.Add(Me.Label14)
        Me.grpCarForm.Controls.Add(Me.pctCarImg)
        Me.grpCarForm.Controls.Add(Me.butFindCarImg)
        Me.grpCarForm.Controls.Add(Me.txtCarImgPath)
        Me.grpCarForm.Controls.Add(Me.lbCarImgPath)
        Me.grpCarForm.Controls.Add(Me.chkCarFormName)
        Me.grpCarForm.Controls.Add(Me.txtCarNameForm)
        Me.grpCarForm.Controls.Add(Me.lbCarNameForm)
        Me.grpCarForm.Controls.Add(Me.butRemoveFromSync)
        Me.grpCarForm.Controls.Add(Me.butListSelected)
        Me.grpCarForm.Controls.Add(Me.butSelectAll)
        Me.grpCarForm.Controls.Add(Me.butAddToSync)
        Me.grpCarForm.Controls.Add(Me.ButGoBack)
        Me.grpCarForm.Controls.Add(Me.butClearGarage)
        Me.grpCarForm.Controls.Add(Me.butSearchCarForm)
        Me.grpCarForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCarForm.ForeColor = System.Drawing.Color.Red
        Me.grpCarForm.Location = New System.Drawing.Point(13, 9)
        Me.grpCarForm.Name = "grpCarForm"
        Me.grpCarForm.Size = New System.Drawing.Size(1140, 721)
        Me.grpCarForm.TabIndex = 71
        Me.grpCarForm.TabStop = False
        Me.grpCarForm.Text = "Cars - Delete Sync"
        '
        'lbIdCarForm
        '
        Me.lbIdCarForm.AutoSize = True
        Me.lbIdCarForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdCarForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIdCarForm.Location = New System.Drawing.Point(14, 236)
        Me.lbIdCarForm.Name = "lbIdCarForm"
        Me.lbIdCarForm.Size = New System.Drawing.Size(20, 15)
        Me.lbIdCarForm.TabIndex = 201
        Me.lbIdCarForm.Text = "-1"
        Me.lbIdCarForm.Visible = False
        '
        'lsvCars
        '
        Me.lsvCars.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cidcar, Me.ColumnHeader1})
        Me.lsvCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvCars.FullRowSelect = True
        Me.lsvCars.GridLines = True
        Me.lsvCars.HideSelection = False
        Me.lsvCars.Location = New System.Drawing.Point(6, 254)
        Me.lsvCars.Name = "lsvCars"
        Me.lsvCars.Size = New System.Drawing.Size(1128, 461)
        Me.lsvCars.TabIndex = 200
        Me.lsvCars.UseCompatibleStateImageBehavior = False
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
        'txtfnamehideen
        '
        Me.txtfnamehideen.Location = New System.Drawing.Point(231, 115)
        Me.txtfnamehideen.Name = "txtfnamehideen"
        Me.txtfnamehideen.ReadOnly = True
        Me.txtfnamehideen.Size = New System.Drawing.Size(101, 23)
        Me.txtfnamehideen.TabIndex = 199
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(14, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 198
        Me.Label14.Text = "Thumbnail:"
        '
        'pctCarImg
        '
        Me.pctCarImg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pctCarImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctCarImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctCarImg.Location = New System.Drawing.Point(124, 112)
        Me.pctCarImg.Name = "pctCarImg"
        Me.pctCarImg.Size = New System.Drawing.Size(101, 72)
        Me.pctCarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCarImg.TabIndex = 197
        Me.pctCarImg.TabStop = False
        '
        'butFindCarImg
        '
        Me.butFindCarImg.BackColor = System.Drawing.SystemColors.Control
        Me.butFindCarImg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butFindCarImg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butFindCarImg.Location = New System.Drawing.Point(297, 83)
        Me.butFindCarImg.Name = "butFindCarImg"
        Me.butFindCarImg.Size = New System.Drawing.Size(35, 23)
        Me.butFindCarImg.TabIndex = 196
        Me.butFindCarImg.Text = " -- "
        Me.butFindCarImg.UseVisualStyleBackColor = False
        '
        'txtCarImgPath
        '
        Me.txtCarImgPath.Location = New System.Drawing.Point(124, 83)
        Me.txtCarImgPath.Name = "txtCarImgPath"
        Me.txtCarImgPath.ReadOnly = True
        Me.txtCarImgPath.Size = New System.Drawing.Size(161, 23)
        Me.txtCarImgPath.TabIndex = 195
        '
        'lbCarImgPath
        '
        Me.lbCarImgPath.AutoSize = True
        Me.lbCarImgPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCarImgPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarImgPath.Location = New System.Drawing.Point(14, 83)
        Me.lbCarImgPath.Name = "lbCarImgPath"
        Me.lbCarImgPath.Size = New System.Drawing.Size(51, 15)
        Me.lbCarImgPath.TabIndex = 194
        Me.lbCarImgPath.Text = "Image:"
        '
        'chkCarFormName
        '
        Me.chkCarFormName.AutoSize = True
        Me.chkCarFormName.Checked = True
        Me.chkCarFormName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCarFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCarFormName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCarFormName.Location = New System.Drawing.Point(317, 52)
        Me.chkCarFormName.Name = "chkCarFormName"
        Me.chkCarFormName.Size = New System.Drawing.Size(75, 17)
        Me.chkCarFormName.TabIndex = 193
        Me.chkCarFormName.Text = "Contains"
        Me.chkCarFormName.UseVisualStyleBackColor = True
        '
        'txtCarNameForm
        '
        Me.txtCarNameForm.Location = New System.Drawing.Point(124, 50)
        Me.txtCarNameForm.Name = "txtCarNameForm"
        Me.txtCarNameForm.Size = New System.Drawing.Size(187, 23)
        Me.txtCarNameForm.TabIndex = 192
        '
        'lbCarNameForm
        '
        Me.lbCarNameForm.AutoSize = True
        Me.lbCarNameForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCarNameForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCarNameForm.Location = New System.Drawing.Point(14, 50)
        Me.lbCarNameForm.Name = "lbCarNameForm"
        Me.lbCarNameForm.Size = New System.Drawing.Size(73, 15)
        Me.lbCarNameForm.TabIndex = 191
        Me.lbCarNameForm.Text = "Car name:"
        '
        'carsDeleteSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 742)
        Me.Controls.Add(Me.grpCarForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "carsDeleteSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Sync"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpCarForm.ResumeLayout(False)
        Me.grpCarForm.PerformLayout()
        CType(Me.pctCarImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fileDialogCar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents butSearchCarForm As System.Windows.Forms.Button
    Friend WithEvents butClearGarage As System.Windows.Forms.Button
    Friend WithEvents ButGoBack As System.Windows.Forms.Button
    Friend WithEvents butAddToSync As System.Windows.Forms.Button
    Friend WithEvents butSelectAll As System.Windows.Forms.Button
    Friend WithEvents butListSelected As System.Windows.Forms.Button
    Friend WithEvents butRemoveFromSync As System.Windows.Forms.Button
    Friend WithEvents grpCarForm As System.Windows.Forms.GroupBox
    Friend WithEvents lbIdCarForm As System.Windows.Forms.Label
    Friend WithEvents lsvCars As HeadQApplication.MyListView
    Friend WithEvents cidcar As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtfnamehideen As HeadQApplication.MyTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents pctCarImg As System.Windows.Forms.PictureBox
    Friend WithEvents butFindCarImg As System.Windows.Forms.Button
    Friend WithEvents txtCarImgPath As HeadQApplication.MyTextBox
    Friend WithEvents lbCarImgPath As System.Windows.Forms.Label
    Friend WithEvents chkCarFormName As System.Windows.Forms.CheckBox
    Friend WithEvents txtCarNameForm As HeadQApplication.MyTextBox
    Friend WithEvents lbCarNameForm As System.Windows.Forms.Label
End Class
