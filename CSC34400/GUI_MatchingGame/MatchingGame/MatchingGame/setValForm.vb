'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  Author: Zhuocheng Shang                                      '
'  Date:  06/12/2017                                            '
'  Purpose: Let user to set up game data                        '
'                                                               '
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class setValForm

    Private drawColor As Color = Color.Olive ' default color for card back
    Private fullFile As String ' image file address
    Private colorList As New ArrayList ' a list to hold all color of pairs
    Private cardList As New ArrayList 'card list 
    Private checkPairs As Boolean = True
    Private count As Integer ' track click count of panel

    Private r As Integer ' red pair
    Private b As Integer ' blue pair
    Private g As Integer ' green pair
    Private y As Integer ' yellow pair

    Private canPlay As Boolean ' set a boolean to check if user enter correct pair value

    ' if click Cancle, return to menu 
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Visible = False
        MenuForm.Visible = True
    End Sub

    ' if click Done, start a new game
    Private Sub doneButton_Click(sender As Object, e As EventArgs) Handles doneButton.Click
        ' remove previous value
        cardList.Clear()
        ' get a color list 
        UpdateColorList()

        'check if can play ot not 
        'show up save file 
        ' otherwise, return to set value page
        If canPlay = True Then
            startNewGame()
        Else
            Me.Visible = True
        End If

    End Sub

    ' start a new game
    Public Sub startNewGame()

        Dim nRow = slider.Value ' get row
        Dim nColumn = slider.Value - 1 ' get column

        ' pop up a message box to ask user if save file or not
        Dim Message As String = "Do you want to Save your setup?"
        Dim result As Integer = MessageBox.Show(Message, "Caption", MessageBoxButtons.YesNo)

        ' if save file
        If result = DialogResult.Yes Then
            ' show up a file dialog
            If SaveFile.ShowDialog() = DialogResult.OK Then
                ' save file       
                saveGameFile(nRow, nColumn)
            End If
        End If

        ' switch to game form
        Me.Visible = False
        GameForm.newGame(nRow, colorList, drawColor, fullFile)
        GameForm.setPair(r, b, g, y)
        GameForm.Visible = True

    End Sub

    ' method to save file
    Private Sub saveGameFile(nRow As Integer, nColumn As Integer)

        Dim index As Integer = 0 ' set index to track

        ' get file URL
        Dim filename As String = SaveFile.FileName
        Dim objWriter As New System.IO.StreamWriter(filename)

        If fullFile IsNot Nothing Then ' if the card back is an image
            objWriter.WriteLine(fullFile)
        Else ' if the card back is olive or gray
            Dim convertS As String = drawColor.ToString().Replace("Color [", "").Replace("]", "")
            objWriter.WriteLine(convertS)
        End If

        objWriter.WriteLine(nRow) ' write game size

        ' write colors
        For i As Integer = 0 To nRow - 1 ' row
            For j As Integer = 0 To nColumn - 1 ' column
                Dim convert As String = colorList(index).ToString().Replace("Color [", "").Replace("]", "")
                objWriter.Write(convert)
                objWriter.Write(" ")
                index += 1
            Next
            objWriter.WriteLine() ' point to next line
        Next

        objWriter.Close()

    End Sub


    ' method to get slider value
    Private Sub slider_ValueChanged(sender As Object, e As EventArgs) Handles slider.ValueChanged
        size.Text = "Size: " & slider.Value ' get radio button value
    End Sub

    ' method to get radio button value, and change card back to olive color 
    Private Sub oliveRadio_CheckChanged(sender As Object, e As EventArgs) Handles oliveRadio.CheckedChanged
        imgRadio.Checked = False ' set image radio button to false
        imgBox.BackgroundImage = Nothing  ' clear image box
        drawColor = Color.Olive ' get radio button value
        fullFile = Nothing ' claer image file name
    End Sub

    ' method to get radio button value, and change card back to gray color
    Private Sub grayRadio_CheckedChanged(sender As Object, e As EventArgs) Handles grayRadio.CheckedChanged
        imgRadio.Checked = False ' set image radio button to false
        imgBox.BackgroundImage = Nothing  ' clear image box
        drawColor = Color.Gray ' get radio button value
        fullFile = Nothing ' claer image file name
    End Sub

    ' method to get radio button value, and change card back to an image
    Private Sub ImgRadio_CheckedChanged(sender As Object, e As EventArgs) Handles imgRadio.CheckedChanged
        imgFileLoad.Title = "Select an Iamge File"
        imgFileLoad.RestoreDirectory = True

        If imgRadio.Checked = True Then
            If imgFileLoad.ShowDialog() = DialogResult.OK Then
                fullFile = imgFileLoad.FileName ' get image full file name
                imgBox.BackgroundImage = System.Drawing.Image.FromFile(fullFile) ' add image to image box
            End If
        End If

    End Sub


    ' method to create a random color list 
    Private Sub UpdateColorList()

        colorList.Clear() ' clear color list

        ' set default font color
        blueBox.ForeColor = Color.Black
        redBox.ForeColor = Color.Black
        greenBox.ForeColor = Color.Black
        yellowBox.ForeColor = Color.Black

        Dim blueN As Integer ' get "blue" pair number
        blueN = blueBox.Text
        b = blueN * 2


        Dim redN As Integer ' get "red" pair number
        redN = redBox.Text
        r = redN * 2


        Dim greenN As Integer ' get "green" pair number
        greenN = greenBox.Text
        g = greenN * 2


        Dim yellowN As Integer ' get "yellow" pair number
        yellowN = yellowBox.Text
        y = yellowN * 2


        Dim totalP = blueN + redN + greenN + yellowN ' get total pairs entered
        Dim totalN = totalP * 2 ' get total color number

        Dim nCard As Integer ' get slider value
        nCard = slider.Value

        Dim checkPairs As Integer ' the correct pairs 
        checkPairs = nCard * (nCard - 1) / 2

        ' check , and modify if user enter wrong pairs
        If totalP <> checkPairs Then

            ' alert user
            invalidChange()

        Else
            canPlay = True ' user can start a new game

            For b As Integer = 0 To blueN * 2 - 1  ' put color blue into array list
                colorList.Add(Color.Blue)
            Next

            For r As Integer = blueN * 2 To (blueN + redN) * 2 - 1 ' put color red into array list
                colorList.Add(Color.Red)
            Next

            For g As Integer = (blueN + redN) * 2 To (blueN + redN + greenN) * 2 - 1 ' put color greed into array list
                colorList.Add(Color.Green)
            Next

            For y As Integer = (totalP - yellowN) To totalN - 1 ' put color yellow into array list
                colorList.Add(Color.Yellow)
            Next

            ' assign random color

            Dim rnd As New Random
            Dim tmp As Color
            Dim m, n As Integer
            For m = 0 To totalP
                n = Int(rnd.Next(m + 1, totalN))
                tmp = colorList(m)
                colorList(m) = colorList(n)
                colorList(n) = tmp
            Next
        End If

    End Sub

    ' method to alert user for entirng wrong color pairs
    Private Sub invalidChange()

        ' change text box value
        blueBox.Text = 0
        redBox.Text = 0
        greenBox.Text = 0
        yellowBox.Text = 0

        ' change font color to red
        blueBox.ForeColor = Color.Red
        redBox.ForeColor = Color.Red
        greenBox.ForeColor = Color.Red
        yellowBox.ForeColor = Color.Red

        'pop up a message box
        MessageBox.Show("Invalid pairs")
        canPlay = False

    End Sub


End Class