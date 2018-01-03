'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  Author: Zhuocheng Shang                                      '
'  Date:  06/12/2017                                            '
'  Purpose: Menu form, let user choose game mode                '
'                                                               '
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class MenuForm
    Private drawColor As Color = Color.Olive ' default color for card back
    Private fullFile As String ' image file address
    Private colorList As New ArrayList ' a list to hold all color of pairs

    Private r As Integer ' red pair
    Private b As Integer ' blue pair
    Private g As Integer ' green pair
    Private y As Integer ' yellow pair

    ' if click New Game, let user set up game date
    Private Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click
        Me.Visible = False
        setValForm.Visible = True 'pop up set value window
    End Sub

    ' re set all value
    Private Sub reSetVal()

        r = 0
        b = 0
        g = 0
        y = 0
        fullFile = Nothing

    End Sub

    ' click Re-Play and pop up a file dailog
    Private Sub replayButton_Click(sender As Object, e As EventArgs) Handles replayButton.Click

        ' if user click Ok
        If OpenFile.ShowDialog() = DialogResult.OK Then
            uploadGameFile()
        End If

    End Sub

    Private Sub uploadGameFile()
        ' get file URL
        Dim filename As String = OpenFile.FileName

        Dim objReader As New System.IO.StreamReader(filename)

        ' get first line : card back color
        Dim line As String = objReader.ReadLine()
        Dim backColor As String = line

        If backColor.Equals("Olive") Or backColor.Equals("Gray") Then
            Dim back As Color = Color.FromName(backColor)
            drawColor = back
        Else 'if card back if an image
            fullFile = backColor
        End If

        ' get second line : game size
        Dim line2 As Integer = objReader.ReadLine()
        Dim size As Integer = line2

        ' calculate card's width and height
        Dim side As Integer
        side = 700 / (size) - 15

        Dim ctag As Integer = 0 ' index for adding color to each card

        For i As Integer = 0 To size - 1  ' row

            ' read  line of color part
            Dim line3 As String = objReader.ReadLine()
            ' split line by space
            Dim colors As String() = line3.Split()
            For j As Integer = 0 To size - 2  ' column
                ' get color 
                Dim C As Color = Color.FromName(colors(j))
                ' get color pair
                countPair(C)
                ' add to color list 
                colorList.Add(C)
            Next
        Next

        objReader.Close()

        Me.Visible = False

        ' call method to start the new game
        GameForm.newGame(size, colorList, drawColor, fullFile)
        ' send color pairs value to the new game
        GameForm.setPair(r, b, g, y)
        ' switch to game form 
        GameForm.Visible = True

    End Sub

    ' method to calculate color pairs in the file
    Public Sub countPair(col As Color)
        If col.Equals(Color.Red) Then
            r += 1
        ElseIf col.Equals(Color.Blue) Then
            b += 1
        ElseIf col.Equals(Color.Green) Then
            g += 1
        ElseIf col.Equals(Color.Yellow) Then
            y += 1
        End If

    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Application.Exit() ' exit the application
    End Sub

    ' help window
    Private Sub helpButton_Click(sender As Object, e As EventArgs) Handles helpButton.Click
        MessageBox.Show("New Game : you can click and set up data" &
                        Environment.NewLine & "Re-Play : choose a txt file saved before and re play the game " &
                        Environment.NewLine &
                        Environment.NewLine & " Once you pick a wrong pair, computer have chance to play once," &
                        Environment.NewLine & " and you can continue playing.")
    End Sub

End Class

