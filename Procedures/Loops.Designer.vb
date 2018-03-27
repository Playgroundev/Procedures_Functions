<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loops
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
        Me.LstOutput = New System.Windows.Forms.ListBox()
        Me.BtnPopulate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstOutput
        '
        Me.LstOutput.FormattingEnabled = True
        Me.LstOutput.Location = New System.Drawing.Point(12, 12)
        Me.LstOutput.Name = "LstOutput"
        Me.LstOutput.Size = New System.Drawing.Size(204, 212)
        Me.LstOutput.TabIndex = 0
        '
        'BtnPopulate
        '
        Me.BtnPopulate.Location = New System.Drawing.Point(56, 254)
        Me.BtnPopulate.Name = "BtnPopulate"
        Me.BtnPopulate.Size = New System.Drawing.Size(131, 23)
        Me.BtnPopulate.TabIndex = 1
        Me.BtnPopulate.Text = "Button1"
        Me.BtnPopulate.UseVisualStyleBackColor = True
        '
        'Loops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 289)
        Me.Controls.Add(Me.BtnPopulate)
        Me.Controls.Add(Me.LstOutput)
        Me.Name = "Loops"
        Me.Text = "Loops"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstOutput As System.Windows.Forms.ListBox
    Friend WithEvents BtnPopulate As System.Windows.Forms.Button
End Class
