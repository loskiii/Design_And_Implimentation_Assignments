<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnObjectDemo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnObjectDemo
        '
        Me.btnObjectDemo.Location = New System.Drawing.Point(252, 187)
        Me.btnObjectDemo.Name = "btnObjectDemo"
        Me.btnObjectDemo.Size = New System.Drawing.Size(128, 64)
        Me.btnObjectDemo.TabIndex = 0
        Me.btnObjectDemo.Text = "Load Object Demo"
        Me.Tooltip.SetToolTip(Me.btnObjectDemo, "Loads and displays form ““Object Demonstrations””")
        Me.btnObjectDemo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(455, 187)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 64)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.Tooltip.SetToolTip(Me.btnExit, "This Button Exits The Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Tooltip
        '
        Me.Tooltip.ToolTipTitle = "Tooltip"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnObjectDemo)
        Me.Name = "Form1"
        Me.Text = "Welcoming Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnObjectDemo As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Tooltip As ToolTip
End Class
