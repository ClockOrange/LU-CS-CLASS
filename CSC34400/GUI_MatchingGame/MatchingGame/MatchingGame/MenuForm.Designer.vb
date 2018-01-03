<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.newButton = New System.Windows.Forms.Button()
        Me.replayButton = New System.Windows.Forms.Button()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'newButton
        '
        Me.newButton.BackColor = System.Drawing.Color.LightPink
        Me.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.newButton.ForeColor = System.Drawing.Color.Black
        Me.newButton.Location = New System.Drawing.Point(103, 86)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(75, 23)
        Me.newButton.TabIndex = 0
        Me.newButton.Text = "New Game"
        Me.newButton.UseVisualStyleBackColor = False
        '
        'replayButton
        '
        Me.replayButton.BackColor = System.Drawing.Color.LightSalmon
        Me.replayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.replayButton.Location = New System.Drawing.Point(103, 136)
        Me.replayButton.Name = "replayButton"
        Me.replayButton.Size = New System.Drawing.Size(75, 23)
        Me.replayButton.TabIndex = 1
        Me.replayButton.Text = "Re-Play"
        Me.replayButton.UseVisualStyleBackColor = False
        '
        'helpButton
        '
        Me.helpButton.BackColor = System.Drawing.Color.Salmon
        Me.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.helpButton.Location = New System.Drawing.Point(103, 184)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(75, 23)
        Me.helpButton.TabIndex = 2
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Matching Game"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'quitButton
        '
        Me.quitButton.BackColor = System.Drawing.Color.Thistle
        Me.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.quitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.quitButton.Location = New System.Drawing.Point(103, 236)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(75, 23)
        Me.quitButton.TabIndex = 4
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(293, 349)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.replayButton)
        Me.Controls.Add(Me.newButton)
        Me.MaximumSize = New System.Drawing.Size(309, 387)
        Me.MinimumSize = New System.Drawing.Size(309, 387)
        Me.Name = "MenuForm"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newButton As Button
    Friend WithEvents replayButton As Button
    Friend WithEvents helpButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFile As OpenFileDialog
    Friend WithEvents quitButton As System.Windows.Forms.Button
End Class
