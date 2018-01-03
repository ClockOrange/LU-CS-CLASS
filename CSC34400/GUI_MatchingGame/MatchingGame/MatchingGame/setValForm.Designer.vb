<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setValForm
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
        Me.doneButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.imgFileLoad = New System.Windows.Forms.OpenFileDialog()
        Me.yellowBox = New System.Windows.Forms.TextBox()
        Me.yellow = New System.Windows.Forms.Label()
        Me.green = New System.Windows.Forms.Label()
        Me.blue = New System.Windows.Forms.Label()
        Me.greenBox = New System.Windows.Forms.TextBox()
        Me.oliveRadio = New System.Windows.Forms.RadioButton()
        Me.blueBox = New System.Windows.Forms.TextBox()
        Me.grayRadio = New System.Windows.Forms.RadioButton()
        Me.red = New System.Windows.Forms.Label()
        Me.imgRadio = New System.Windows.Forms.RadioButton()
        Me.redBox = New System.Windows.Forms.TextBox()
        Me.imgBox = New System.Windows.Forms.PictureBox()
        Me.slider = New System.Windows.Forms.TrackBar()
        Me.size = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'doneButton
        '
        Me.doneButton.BackColor = System.Drawing.Color.Coral
        Me.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.doneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doneButton.Location = New System.Drawing.Point(268, 371)
        Me.doneButton.Name = "doneButton"
        Me.doneButton.Size = New System.Drawing.Size(75, 23)
        Me.doneButton.TabIndex = 14
        Me.doneButton.Text = "Done"
        Me.doneButton.UseVisualStyleBackColor = False
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.Coral
        Me.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(413, 371)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 15
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'imgFileLoad
        '
        Me.imgFileLoad.FileName = "OpenFileDialog1"
        Me.imgFileLoad.Title = "Pick your image"
        '
        'yellowBox
        '
        Me.yellowBox.Location = New System.Drawing.Point(93, 195)
        Me.yellowBox.Name = "yellowBox"
        Me.yellowBox.Size = New System.Drawing.Size(100, 26)
        Me.yellowBox.TabIndex = 3
        Me.yellowBox.Text = "0"
        '
        'yellow
        '
        Me.yellow.AutoSize = True
        Me.yellow.BackColor = System.Drawing.Color.Yellow
        Me.yellow.ForeColor = System.Drawing.Color.Gray
        Me.yellow.Location = New System.Drawing.Point(24, 198)
        Me.yellow.Name = "yellow"
        Me.yellow.Size = New System.Drawing.Size(55, 20)
        Me.yellow.TabIndex = 7
        Me.yellow.Text = "Yellow"
        '
        'green
        '
        Me.green.AutoSize = True
        Me.green.BackColor = System.Drawing.Color.Green
        Me.green.ForeColor = System.Drawing.Color.White
        Me.green.Location = New System.Drawing.Point(21, 147)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(58, 20)
        Me.green.TabIndex = 6
        Me.green.Text = " Green"
        '
        'blue
        '
        Me.blue.AutoSize = True
        Me.blue.BackColor = System.Drawing.Color.Blue
        Me.blue.ForeColor = System.Drawing.Color.White
        Me.blue.Location = New System.Drawing.Point(30, 87)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(49, 20)
        Me.blue.TabIndex = 5
        Me.blue.Text = "  Blue"
        '
        'greenBox
        '
        Me.greenBox.Location = New System.Drawing.Point(93, 144)
        Me.greenBox.Name = "greenBox"
        Me.greenBox.Size = New System.Drawing.Size(100, 26)
        Me.greenBox.TabIndex = 2
        Me.greenBox.Text = "0"
        '
        'oliveRadio
        '
        Me.oliveRadio.AutoSize = True
        Me.oliveRadio.BackColor = System.Drawing.Color.Olive
        Me.oliveRadio.ForeColor = System.Drawing.Color.White
        Me.oliveRadio.Location = New System.Drawing.Point(17, 38)
        Me.oliveRadio.Name = "oliveRadio"
        Me.oliveRadio.Size = New System.Drawing.Size(61, 24)
        Me.oliveRadio.TabIndex = 8
        Me.oliveRadio.TabStop = True
        Me.oliveRadio.Text = "Olive"
        Me.oliveRadio.UseVisualStyleBackColor = False
        '
        'blueBox
        '
        Me.blueBox.Location = New System.Drawing.Point(93, 84)
        Me.blueBox.Name = "blueBox"
        Me.blueBox.Size = New System.Drawing.Size(100, 26)
        Me.blueBox.TabIndex = 1
        Me.blueBox.Text = "0"
        '
        'grayRadio
        '
        Me.grayRadio.AutoSize = True
        Me.grayRadio.BackColor = System.Drawing.Color.Gray
        Me.grayRadio.ForeColor = System.Drawing.Color.White
        Me.grayRadio.Location = New System.Drawing.Point(17, 99)
        Me.grayRadio.Name = "grayRadio"
        Me.grayRadio.Size = New System.Drawing.Size(61, 24)
        Me.grayRadio.TabIndex = 9
        Me.grayRadio.TabStop = True
        Me.grayRadio.Text = "Gray"
        Me.grayRadio.UseVisualStyleBackColor = False
        '
        'red
        '
        Me.red.AutoSize = True
        Me.red.BackColor = System.Drawing.Color.Red
        Me.red.ForeColor = System.Drawing.Color.White
        Me.red.Location = New System.Drawing.Point(28, 39)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(51, 20)
        Me.red.TabIndex = 4
        Me.red.Text = "   Red"
        '
        'imgRadio
        '
        Me.imgRadio.AutoSize = True
        Me.imgRadio.BackColor = System.Drawing.Color.LightGray
        Me.imgRadio.Location = New System.Drawing.Point(17, 162)
        Me.imgRadio.Name = "imgRadio"
        Me.imgRadio.Size = New System.Drawing.Size(72, 24)
        Me.imgRadio.TabIndex = 10
        Me.imgRadio.TabStop = True
        Me.imgRadio.Text = "Image"
        Me.imgRadio.UseVisualStyleBackColor = False
        '
        'redBox
        '
        Me.redBox.Location = New System.Drawing.Point(93, 36)
        Me.redBox.Name = "redBox"
        Me.redBox.Size = New System.Drawing.Size(100, 26)
        Me.redBox.TabIndex = 0
        Me.redBox.Text = "0"
        '
        'imgBox
        '
        Me.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgBox.Location = New System.Drawing.Point(74, 206)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(114, 111)
        Me.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBox.TabIndex = 11
        Me.imgBox.TabStop = False
        '
        'slider
        '
        Me.slider.Location = New System.Drawing.Point(92, 43)
        Me.slider.Minimum = 4
        Me.slider.Name = "slider"
        Me.slider.Size = New System.Drawing.Size(104, 45)
        Me.slider.TabIndex = 13
        Me.slider.Value = 4
        '
        'size
        '
        Me.size.AutoSize = True
        Me.size.Location = New System.Drawing.Point(21, 43)
        Me.size.Name = "size"
        Me.size.Size = New System.Drawing.Size(57, 20)
        Me.size.TabIndex = 12
        Me.size.Text = "Size: 4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.greenBox)
        Me.GroupBox1.Controls.Add(Me.red)
        Me.GroupBox1.Controls.Add(Me.green)
        Me.GroupBox1.Controls.Add(Me.blueBox)
        Me.GroupBox1.Controls.Add(Me.yellowBox)
        Me.GroupBox1.Controls.Add(Me.yellow)
        Me.GroupBox1.Controls.Add(Me.redBox)
        Me.GroupBox1.Controls.Add(Me.blue)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 264)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color Pair"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.size)
        Me.GroupBox2.Controls.Add(Me.slider)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 100)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Game Size"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.imgRadio)
        Me.GroupBox3.Controls.Add(Me.imgBox)
        Me.GroupBox3.Controls.Add(Me.grayRadio)
        Me.GroupBox3.Controls.Add(Me.oliveRadio)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(268, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 335)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Card Back"
        '
        'setValForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(532, 437)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.doneButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximumSize = New System.Drawing.Size(548, 475)
        Me.MinimumSize = New System.Drawing.Size(548, 475)
        Me.Name = "setValForm"
        Me.Text = "Set Value"
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents doneButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents SaveFile As SaveFileDialog
    Friend WithEvents imgFileLoad As System.Windows.Forms.OpenFileDialog
    Friend WithEvents yellowBox As System.Windows.Forms.TextBox
    Friend WithEvents yellow As System.Windows.Forms.Label
    Friend WithEvents green As System.Windows.Forms.Label
    Friend WithEvents blue As System.Windows.Forms.Label
    Friend WithEvents greenBox As System.Windows.Forms.TextBox
    Friend WithEvents oliveRadio As System.Windows.Forms.RadioButton
    Friend WithEvents blueBox As System.Windows.Forms.TextBox
    Friend WithEvents grayRadio As System.Windows.Forms.RadioButton
    Friend WithEvents red As System.Windows.Forms.Label
    Friend WithEvents imgRadio As System.Windows.Forms.RadioButton
    Friend WithEvents redBox As System.Windows.Forms.TextBox
    Friend WithEvents imgBox As System.Windows.Forms.PictureBox
    Friend WithEvents slider As System.Windows.Forms.TrackBar
    Friend WithEvents size As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
