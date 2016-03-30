Public Class frmstartpage
    Private Sub lbllogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbllogin.Click
        Frmlogon.Show() ' shows the logon form
        Me.Hide() ' gides the current form
    End Sub
    Private Sub lblhighscores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhighscores.Click
        frmhighscore.Show() ' shows the high score form
        Me.Hide() ' hides the current form
    End Sub
    Private Sub lblhowtoplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhowtoplay.Click
        MsgBox(" You Need to log on to the Game to be able to play, Once you have logged in you then use the left and right arrows to move across the screen and use the space bar to fire, your objective is to destroy all the space invadors before they reach your defences") ' diaplays the message box showinghow to play the game
    End Sub
    Private Sub lblplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblplay.Click
        If Frmlogon.passwordcorrect = True Then ' if the user has logged in
            frmgame.Show() ' shows game from 
            Me.Hide() ' hides the current from
        Else 'if the user hasnt logged in
            MsgBox(" You have not logged in, please log in and try again") ' displays error box
            Frmlogon.Show() ' opens the log on from
            Me.Hide() 'colses the current from
        End If 'ends if
    End Sub

    
End Class
