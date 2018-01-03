'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'  Author: Zhuocheng Shang                                      '
'  Date:  06/12/2017                                            '
'  Purpose: Card class, set for each card when created          '
'                                                               '
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class newCard
    Private originalS As Integer = 0 ' set to get original size of card
    Private con As Integer = 0 ' set to get condition 

    Public Sub New(col As Color)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BackColor = col

    End Sub


    Public Sub newCard_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

        movingTimer.Start()

    End Sub

    ' set an animation for flipping card
    Private Sub movingTimer_Tick(sender As Object, e As EventArgs) Handles movingTimer.Tick

        Me.Height -= 1
        originalS += 1

        If Me.Height <= 0 Then  ' if the card is gone
            movingTimer.Stop() ' animation stop 
            Me.BackgroundImage = Nothing
            Me.BackColor = Me.ForeColor ' show foreColor
            Me.Height += originalS ' set back to original size  
            originalS = 0 ' reset orginal size

            showMessage() ' show message box
        End If

    End Sub

    ' method to pop up message box 
    Public Sub showMessage()

        If con = 1 Then ' if two color are the same
            'pop up a message box after flip
            MessageBox.Show("Congratulate! You pick the right pair. Continue Playing.")
            GameForm.hideCard()

        ElseIf con = 2 Then ' if two color are different
            ' pop up a message box after flip
            MessageBox.Show("You pick the wrong pair. Computer's turn.")
            GameForm.computerMode()

        End If

    End Sub

    ' method to ditermine which condition
    Public Sub setCon(val As Integer)
        con = val
    End Sub

End Class
