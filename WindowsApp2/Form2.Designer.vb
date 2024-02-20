<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSampleBox = New System.Windows.Forms.TextBox()
        Me.rdbGreen = New System.Windows.Forms.RadioButton()
        Me.rdbGaramond = New System.Windows.Forms.RadioButton()
        Me.rdbRed = New System.Windows.Forms.RadioButton()
        Me.rdbBlue = New System.Windows.Forms.RadioButton()
        Me.rdbTahoma = New System.Windows.Forms.RadioButton()
        Me.rdbMagneto = New System.Windows.Forms.RadioButton()
        Me.chbItalic = New System.Windows.Forms.CheckBox()
        Me.chbBoldItalic = New System.Windows.Forms.CheckBox()
        Me.chbBold = New System.Windows.Forms.CheckBox()
        Me.btnLoadPicture = New System.Windows.Forms.Button()
        Me.pctLoadPicture = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pctLoadPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(593, 374)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(152, 39)
        Me.btnGoBack.TabIndex = 0
        Me.btnGoBack.Text = "Exit"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSampleBox)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 81)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display Text"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbMagneto)
        Me.GroupBox2.Controls.Add(Me.rdbTahoma)
        Me.GroupBox2.Controls.Add(Me.rdbGaramond)
        Me.GroupBox2.Location = New System.Drawing.Point(352, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 81)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Font"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbBold)
        Me.GroupBox3.Controls.Add(Me.chbBoldItalic)
        Me.GroupBox3.Controls.Add(Me.chbItalic)
        Me.GroupBox3.Location = New System.Drawing.Point(365, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(165, 209)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Font Style"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdbBlue)
        Me.GroupBox4.Controls.Add(Me.rdbRed)
        Me.GroupBox4.Controls.Add(Me.rdbGreen)
        Me.GroupBox4.Location = New System.Drawing.Point(571, 142)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(174, 217)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Font Color"
        '
        'txtSampleBox
        '
        Me.txtSampleBox.Location = New System.Drawing.Point(24, 31)
        Me.txtSampleBox.Name = "txtSampleBox"
        Me.txtSampleBox.Size = New System.Drawing.Size(226, 20)
        Me.txtSampleBox.TabIndex = 0
        Me.txtSampleBox.Text = "Sample Text"
        '
        'rdbGreen
        '
        Me.rdbGreen.AutoSize = True
        Me.rdbGreen.Location = New System.Drawing.Point(22, 36)
        Me.rdbGreen.Name = "rdbGreen"
        Me.rdbGreen.Size = New System.Drawing.Size(54, 17)
        Me.rdbGreen.TabIndex = 0
        Me.rdbGreen.TabStop = True
        Me.rdbGreen.Text = "Green"
        Me.rdbGreen.UseVisualStyleBackColor = True
        '
        'rdbGaramond
        '
        Me.rdbGaramond.AutoSize = True
        Me.rdbGaramond.Location = New System.Drawing.Point(21, 32)
        Me.rdbGaramond.Name = "rdbGaramond"
        Me.rdbGaramond.Size = New System.Drawing.Size(74, 17)
        Me.rdbGaramond.TabIndex = 1
        Me.rdbGaramond.TabStop = True
        Me.rdbGaramond.Text = "Garamond"
        Me.rdbGaramond.UseVisualStyleBackColor = True
        '
        'rdbRed
        '
        Me.rdbRed.AutoSize = True
        Me.rdbRed.Location = New System.Drawing.Point(22, 141)
        Me.rdbRed.Name = "rdbRed"
        Me.rdbRed.Size = New System.Drawing.Size(45, 17)
        Me.rdbRed.TabIndex = 2
        Me.rdbRed.TabStop = True
        Me.rdbRed.Text = "Red"
        Me.rdbRed.UseVisualStyleBackColor = True
        '
        'rdbBlue
        '
        Me.rdbBlue.AutoSize = True
        Me.rdbBlue.Location = New System.Drawing.Point(22, 88)
        Me.rdbBlue.Name = "rdbBlue"
        Me.rdbBlue.Size = New System.Drawing.Size(46, 17)
        Me.rdbBlue.TabIndex = 3
        Me.rdbBlue.TabStop = True
        Me.rdbBlue.Text = "Blue"
        Me.rdbBlue.UseVisualStyleBackColor = True
        '
        'rdbTahoma
        '
        Me.rdbTahoma.AutoSize = True
        Me.rdbTahoma.Location = New System.Drawing.Point(264, 32)
        Me.rdbTahoma.Name = "rdbTahoma"
        Me.rdbTahoma.Size = New System.Drawing.Size(64, 17)
        Me.rdbTahoma.TabIndex = 4
        Me.rdbTahoma.TabStop = True
        Me.rdbTahoma.Text = "Tahoma"
        Me.rdbTahoma.UseVisualStyleBackColor = True
        '
        'rdbMagneto
        '
        Me.rdbMagneto.AutoSize = True
        Me.rdbMagneto.Location = New System.Drawing.Point(146, 32)
        Me.rdbMagneto.Name = "rdbMagneto"
        Me.rdbMagneto.Size = New System.Drawing.Size(67, 17)
        Me.rdbMagneto.TabIndex = 5
        Me.rdbMagneto.TabStop = True
        Me.rdbMagneto.Text = "Magneto"
        Me.rdbMagneto.UseVisualStyleBackColor = True
        '
        'chbItalic
        '
        Me.chbItalic.AutoSize = True
        Me.chbItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbItalic.Location = New System.Drawing.Point(23, 37)
        Me.chbItalic.Name = "chbItalic"
        Me.chbItalic.Size = New System.Drawing.Size(48, 17)
        Me.chbItalic.TabIndex = 0
        Me.chbItalic.Text = "Italic"
        Me.chbItalic.UseVisualStyleBackColor = True
        '
        'chbBoldItalic
        '
        Me.chbBoldItalic.AutoSize = True
        Me.chbBoldItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBoldItalic.Location = New System.Drawing.Point(23, 141)
        Me.chbBoldItalic.Name = "chbBoldItalic"
        Me.chbBoldItalic.Size = New System.Drawing.Size(83, 17)
        Me.chbBoldItalic.TabIndex = 1
        Me.chbBoldItalic.Text = "Bold Italic"
        Me.chbBoldItalic.UseVisualStyleBackColor = True
        '
        'chbBold
        '
        Me.chbBold.AutoSize = True
        Me.chbBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBold.Location = New System.Drawing.Point(23, 88)
        Me.chbBold.Name = "chbBold"
        Me.chbBold.Size = New System.Drawing.Size(51, 17)
        Me.chbBold.TabIndex = 2
        Me.chbBold.Text = "Bold"
        Me.chbBold.UseVisualStyleBackColor = True
        '
        'btnLoadPicture
        '
        Me.btnLoadPicture.Location = New System.Drawing.Point(69, 374)
        Me.btnLoadPicture.Name = "btnLoadPicture"
        Me.btnLoadPicture.Size = New System.Drawing.Size(152, 39)
        Me.btnLoadPicture.TabIndex = 5
        Me.btnLoadPicture.Text = "Load Picture"
        Me.btnLoadPicture.UseVisualStyleBackColor = True
        '
        'pctLoadPicture
        '
        Me.pctLoadPicture.ImageLocation = ""
        Me.pctLoadPicture.InitialImage = Nothing
        Me.pctLoadPicture.Location = New System.Drawing.Point(38, 142)
        Me.pctLoadPicture.Name = "pctLoadPicture"
        Me.pctLoadPicture.Size = New System.Drawing.Size(301, 217)
        Me.pctLoadPicture.TabIndex = 6
        Me.pctLoadPicture.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pctLoadPicture)
        Me.Controls.Add(Me.btnLoadPicture)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGoBack)
        Me.Name = "Form2"
        Me.Text = "Object Demonstrations"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pctLoadPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGoBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtSampleBox As TextBox
    Friend WithEvents rdbMagneto As RadioButton
    Friend WithEvents rdbTahoma As RadioButton
    Friend WithEvents rdbGaramond As RadioButton
    Friend WithEvents chbBold As CheckBox
    Friend WithEvents chbBoldItalic As CheckBox
    Friend WithEvents chbItalic As CheckBox
    Friend WithEvents rdbBlue As RadioButton
    Friend WithEvents rdbRed As RadioButton
    Friend WithEvents rdbGreen As RadioButton
    Friend WithEvents btnLoadPicture As Button
    Friend WithEvents pctLoadPicture As PictureBox
End Class
