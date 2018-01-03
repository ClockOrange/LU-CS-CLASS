'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  Author: Zhuocheng Shang                                      '
'  Date:  06/12/2017                                            '
'  Purpose: Game window, allow user to start playing            '
'                                                               '
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class GameForm
    Private nextCard As newCard ' new  card object
    Private cardList As New ArrayList 'card list 

    Private count As Integer ' track click count of panel

    Private firstCol As Color ' the color of first card clicked
    Private secondCol As Color ' the color of second card clicked
    Private firstIndex As Integer ' index of fitst card clicked in the cardlist 
    Private secondIndex As Integer 'index of the second card clicked in the cardlist 

    Private oneIndex As Integer ' index of first random card
    Private twoIndex As Integer ' index of second random card

    Private playerScore As Integer = 0 ' score of player
    Private computerScore As Integer = 0 ' score of computer

    Private full_file As String ' file URL for image
    Private drawColor As Color ' back color for card 


    Private Sub initializeGame()

        cardHolder.Controls.Clear()
        cardList.Clear()
        computerScore = 0
        computerS.Text = computerScore
        playerScore = 0
        playerS.Text = computerScore
        full_file = Nothing

    End Sub

    ' call method when start a new game
    Public Sub newGame(size As Integer, col As ArrayList, back As Color, fullfile As String)

        initializeGame() ' initial all value when start a new game

        ' start add cards to page

        Dim m As Integer = 0 ' index for adding color to each card

        Dim nCard As Integer ' get slider value
        nCard = size

        Dim Row = nCard ' get row number
        Dim Column = nCard - 1 ' get column numebr

        Dim side As Integer ' generate width and height of each card
        side = 500 / (nCard) - 15

        Dim yPos As Integer = 0

        For cardNum As Integer = 1 To Row ' put cards to each row

            Dim xPos As Integer = side

            For num As Integer = 1 To Column ' put cards to each column

                nextCard = New newCard(back) ' get a new card

                ' add handler to each card, to response click event
                AddHandler nextCard.MouseClick, AddressOf clickedCheck

                nextCard.ForeColor = col(m) ' set each card's foreColor

                nextCard.Width = side  ' set width and height
                nextCard.Height = side

                If fullfile IsNot Nothing Then ' if the card back is an image, change card back to the image
                    nextCard.BackColor = Nothing
                    nextCard.BackgroundImage = System.Drawing.Image.FromFile(fullfile)
                    full_file = fullfile
                End If

                nextCard.Left = xPos + 20 ' generate positio 
                nextCard.Top = yPos + 5

                xPos = xPos + 10 + side ' update x position

                nextCard.Tag = m ' set ecah card's tag same as it's index in cardlist 
                cardList.Add(nextCard)

                cardHolder.Controls.Add(nextCard)
                m += 1 ' update colorList index

            Next

            yPos = yPos + 10 + side ' update y position 

        Next

        drawColor = back ' get the card back color

    End Sub

    ' method to get color pair values when uploading a file
    Public Sub setPair(r As Integer, b As Integer, g As Integer, y As Integer)
        rVal.Text = r / 2
        bVal.Text = b / 2
        gVal.Text = g / 2
        yVal.Text = y / 2
    End Sub

    ' method to update left color pairs during game 
    Public Sub updatePair(col As Color)
        If col.Equals(Color.Red) Then
            rVal.Text = rVal.Text - 1
        ElseIf col.Equals(Color.Blue) Then
            bVal.Text = bVal.Text - 1
        ElseIf col.Equals(Color.Green) Then
            gVal.Text = gVal.Text - 1
        ElseIf col.Equals(Color.Yellow) Then
            yVal.Text = yVal.Text - 1
        End If

    End Sub

    ' method to response when two cards with same color are clicked
    Public Sub hideCard()
        ' update score
        playerScore += 1
        playerS.Text = playerScore

        ' hide both cards
        cardList(firstIndex).hide()
        cardList(secondIndex).hide()

        'update pairs
        updatePair(secondCol)

        cardHolder.Enabled = True ' user can continue clicking 
    End Sub

    ' method to show back of card
    Private Sub flipToCardBack(obj1 As Object, obj2 As Object)

        ' if the card back is an image
        If full_file IsNot Nothing Then
            obj1.BackgroundImage = System.Drawing.Image.FromFile(full_file)
            obj2.BackgroundImage = System.Drawing.Image.FromFile(full_file)

        Else ' if the card back is olive or gray
            obj1.backColor = drawColor
            obj2.backColor = drawColor
        End If
    End Sub

    'a method to response card click event
    Private Sub clickedCheck(sender As Object, ByVal e As System.EventArgs)

        count += 1 ' when click a card, count of click increase by 1

        If count = 1 Then
            firstCol = sender.ForeColor ' get the forecolor of first card
            firstIndex = sender.tag ' get cardlist index

        End If

        If count = 2 Then
            secondCol = sender.ForeColor ' get the forecolor of second card
            secondIndex = sender.tag ' get cardlist index
            cardHolder.Enabled = False ' panel can not be clicked since only can click 2 cards one game round

            ' return color and compaire

            If firstCol.Equals(secondCol) Then ' if two cards have same color

                'pop up a message box after flip
                ' MessageBox.Show("right")
                sender.setCon(1)
                'remove card
                'hideCard()

            Else ' if two colors are different

                ' pop up a message box after flip
                ' MessageBox.Show("Wrong pair")
                sender.setCon(2)

                ' flip card, and show card back 
                ' change to computer play mode
                ' computerMode()

            End If
            firstCol = Nothing
            secondCol = Nothing
            count = 0
        End If

    End Sub

    Public Sub callAction()

    End Sub
    Private Sub getTwoRandCard()

        Dim indexList As New ArrayList ' set up an arrylist to hold all visible cards

        ' get current left card number
        For Each leftCard In cardHolder.Controls ' if not empty go through
            If leftCard.visible = True Then ' avoid chooose hidden cards 
                indexList.Add(leftCard.tag)
            End If
        Next

        Dim indexCount As Integer = indexList.Count ' get element num of array

        ' randomly get one index
        Dim rand = New Random
        oneIndex = Int(rand.Next(0, indexCount - 1))

        ' randomly get another index
        twoIndex = Int(rand.Next(0, indexCount - 1))

        ' keep choose random second index until they are different 
        ' to avoid computer choosing same card
        While oneIndex = twoIndex
            twoIndex = Int(rand.Next(0, indexCount - 1))
        End While

        ' get card.tag value
        oneIndex = indexList(oneIndex)
        twoIndex = indexList(twoIndex)

    End Sub

    ' method called when computer start playing
    Public Sub computerMode()
        flipToCardBack(cardList(firstIndex), cardList(secondIndex))
        cardHolder.Enabled = False
        ' get two cards
        getTwoRandCard()

        Dim obj1 As Object
        obj1 = cardList(oneIndex) ' get first card object
        obj1.BackgroundImage = Nothing

        Dim obj2 As Object
        obj2 = cardList(twoIndex) ' get second card object
        obj2.BackgroundImage = Nothing

        ' show cards' forecolor
        obj1.BackColor = obj1.ForeColor
        obj2.BackColor = obj2.ForeColor

        ' return color and compaire both
        If obj1.ForeColor.Equals(obj2.ForeColor) Then ' if two colors are the same

            ' pop up a message box and continuew playing
            MessageBox.Show("Computer picked right pair")

            ' update score
            computerScore += 1
            computerS.Text = computerScore

            ' remove both cards
            obj1.hide()
            obj2.hide()

            'update pairs
            updatePair(obj2.ForeColor)

        Else ' if two colors are different

            'pop up a message box
            MessageBox.Show("Computer picked wrong pair")

            ' card flip back
            flipToCardBack(obj1, obj2)

        End If

        cardHolder.Enabled = True

    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Application.Exit() ' exit the application
    End Sub

    Private Sub returnButton_Click(sender As Object, e As EventArgs) Handles returnButton.Click
        Me.Visible = False
        ' switch to menu window
        MenuForm.Visible = True
    End Sub


End Class