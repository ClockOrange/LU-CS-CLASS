<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Me.cardHolder = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.returnButton = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.computerS = New System.Windows.Forms.Label()
        Me.playerS = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.yVal = New System.Windows.Forms.Label()
        Me.gVal = New System.Windows.Forms.Label()
        Me.bVal = New System.Windows.Forms.Label()
        Me.rVal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cardHolder
        '
        Me.cardHolder.BackColor = System.Drawing.Color.Lavender
        Me.cardHolder.Location = New System.Drawing.Point(37, 93)
        Me.cardHolder.Name = "cardHolder"
        Me.cardHolder.Size = New System.Drawing.Size(572, 493)
        Me.cardHolder.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Player :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Computer :"
        '
        'returnButton
        '
        Me.returnButton.BackColor = System.Drawing.Color.Plum
        Me.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.returnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnButton.Location = New System.Drawing.Point(373, 602)
        Me.returnButton.Name = "returnButton"
        Me.returnButton.Size = New System.Drawing.Size(75, 23)
        Me.returnButton.TabIndex = 3
        Me.returnButton.Text = "Return"
        Me.returnButton.UseVisualStyleBackColor = False
        '
        'quitButton
        '
        Me.quitButton.BackColor = System.Drawing.Color.Plum
        Me.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.quitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitButton.Location = New System.Drawing.Point(534, 602)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(75, 23)
        Me.quitButton.TabIndex = 4
        Me.quitButton.Text = "Exit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Red :   "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Blue :  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Green
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(114, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Green :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(114, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Yellow :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.computerS)
        Me.Panel1.Controls.Add(Me.playerS)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(37, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 65)
        Me.Panel1.TabIndex = 9
        '
        'computerS
        '
        Me.computerS.AutoSize = True
        Me.computerS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computerS.Location = New System.Drawing.Point(290, 21)
        Me.computerS.Name = "computerS"
        Me.computerS.Size = New System.Drawing.Size(18, 20)
        Me.computerS.TabIndex = 4
        Me.computerS.Text = "0"
        '
        'playerS
        '
        Me.playerS.AutoSize = True
        Me.playerS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerS.Location = New System.Drawing.Point(107, 21)
        Me.playerS.Name = "playerS"
        Me.playerS.Size = New System.Drawing.Size(18, 20)
        Me.playerS.TabIndex = 3
        Me.playerS.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.yVal)
        Me.Panel2.Controls.Add(Me.gVal)
        Me.Panel2.Controls.Add(Me.bVal)
        Me.Panel2.Controls.Add(Me.rVal)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(373, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 65)
        Me.Panel2.TabIndex = 10
        '
        'yVal
        '
        Me.yVal.AutoSize = True
        Me.yVal.Location = New System.Drawing.Point(178, 41)
        Me.yVal.Name = "yVal"
        Me.yVal.Size = New System.Drawing.Size(13, 13)
        Me.yVal.TabIndex = 12
        Me.yVal.Text = "0"
        '
        'gVal
        '
        Me.gVal.AutoSize = True
        Me.gVal.Location = New System.Drawing.Point(178, 12)
        Me.gVal.Name = "gVal"
        Me.gVal.Size = New System.Drawing.Size(13, 13)
        Me.gVal.TabIndex = 11
        Me.gVal.Text = "0"
        '
        'bVal
        '
        Me.bVal.AutoSize = True
        Me.bVal.Location = New System.Drawing.Point(64, 43)
        Me.bVal.Name = "bVal"
        Me.bVal.Size = New System.Drawing.Size(13, 13)
        Me.bVal.TabIndex = 10
        Me.bVal.Text = "0"
        '
        'rVal
        '
        Me.rVal.AutoSize = True
        Me.rVal.Location = New System.Drawing.Point(66, 11)
        Me.rVal.Name = "rVal"
        Me.rVal.Size = New System.Drawing.Size(13, 13)
        Me.rVal.TabIndex = 9
        Me.rVal.Text = "0"
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(644, 648)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.returnButton)
        Me.Controls.Add(Me.cardHolder)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximumSize = New System.Drawing.Size(660, 686)
        Me.MinimumSize = New System.Drawing.Size(660, 686)
        Me.Name = "GameForm"
        Me.Text = "GameForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cardHolder As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents returnButton As Button
    Friend WithEvents quitButton As Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents computerS As System.Windows.Forms.Label
    Friend WithEvents playerS As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents yVal As System.Windows.Forms.Label
    Friend WithEvents gVal As System.Windows.Forms.Label
    Friend WithEvents bVal As System.Windows.Forms.Label
    Friend WithEvents rVal As System.Windows.Forms.Label
End Class
