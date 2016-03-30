Public Class frmhighscore
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        frmstartpage.Show() ' showes the start page
        Me.Hide() ' closes the current page
    End Sub
End Class