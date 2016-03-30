Public Class frmgame
    'declares the global variables
    Dim speed As Integer = 10 ' variable for storing the speed at which the invaders move
    Dim invaders0(4) As PictureBox ' an array to store the first line of invaders
    Dim invaders1(4) As PictureBox ' an array to store the second line of invaders
    Dim invaders2(4) As PictureBox ' an array to store the third line of invaders
    Dim invadersbullet2 As PictureBox ' declares the invaders bullet
    Dim x As Integer = 50 '  the x co ordinate of all the space invaders
    Dim xx As Integer = 50 '  the x co ordinate of all the space invaders for the reset button
    Dim y1 As Integer = 100 ' the y co ordinate of the first line of invaders
    Dim y2 As Integer = 160 ' the y co ordinate of the second line of invaders
    Dim y3 As Integer = 220 ' the y co ordinate of the third line of invaders
    Dim widths As Integer = 50 ' declares the widths of  the invaders
    Dim heights As Integer = 50 ' declares the heights of the invaders
    Dim score As Integer = 0 '  declares the start score of the game to 0 also used to store the value for the score
    Dim timeplayed As Integer = 0  'sets the start time to 0, this is also used to store the value  of the time
    Dim win As Integer ' counts how many invaders have been shot
    Dim lives As Integer = 3 'counts the lifes the user has
    Dim visibleinvaders As Integer '; stores the amiount of visible invaders
    Dim wait As Integer ' stores a time to wait
    Private Sub frmgame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'moves the cannon 
        If e.KeyCode = Keys.Right Then ' checks to see if the right key has been pressed
            If PictureBox19.Left < Me.ClientSize.Width - PictureBox19.Width Then ' checks to see if the picture box will be touching the right of the screen 
                PictureBox19.Left = PictureBox19.Left + 10 ' moves the picturebox to the left
            End If 'ends the if statement
        End If 'ends the if statement

        If e.KeyCode = Keys.Left Then ' checks to see if there has been a left key press
            If PictureBox19.Left > 0 Then ' sees if the picturebox will touch the left of the screen then
                PictureBox19.Left = PictureBox19.Left - 10 ' moves the picture box -10 places to the left so moves it to the right
            End If 'ends if statement
        End If 'ends if statement

        '''''''''''''''''space bar code'''''''''''''''''

        If e.KeyCode = Keys.Space And Timer2.Enabled = False Then ' looks to see if the space bar has been pressed and to make sure the timer isnt working
            Timer2.Start() ' starts the timer that moves the bullet
            picbullet.Visible = True ' sets the visibility to visible


            ''''''''''''RESET THE BULLET'''''''''''''''''
            If picbullet.Visible = True Then ' sees if the pic bullet is visible
                picbullet.Left = PictureBox19.Location.X + 30 ' sets the pictureboxes porision to be in the middle of the the cannon 
                If picbullet.Top < 0 Then ' if the top of the picture box is higher the top of the page
                    picbullet.Top = PictureBox19.Location.Y '  resets the picture box to the y position of the cannon
                    picbullet.Left = PictureBox19.Location.X + 30 '  resets the picture box to the x position of the cannon
                    picbullet.Visible = False ' makes the bullet invisible
                End If 'ends the if statement
            End If 'ends the if statement
        End If 'ends the if statement
    End Sub ' moves the cannon and controld the space bar
    Private Sub frmgame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load ' calls sub to draw invaders
        drawinvaders() ' calls the sub to draw the indavers once the game form loads
        PictureBox16.Image = ImageList2.Images.Item(1) ' assigns a image from the imagelist to the picture box
        PictureBox17.Image = ImageList2.Images.Item(1) ' assigns a image from the imagelist to the picture box
        PictureBox18.Image = ImageList2.Images.Item(1) ' assigns a image from the imagelist to the picture box
    End Sub ' calls sub to draw invaders
    Private Sub drawinvaders() ' creats 3 lines of invaders on the screen 
        For count = 0 To 4 ' loops 5 times
            Dim newbox = New PictureBox ' creates  new picturebox
            invaders0(count) = newbox ' assigns a new picturebox to the array
            invaders0(count).Image = ImageList1.Images.Item(0) ' assigns a image from the imagelist to the picture box
            invaders0(count).SetBounds(x, y1, widths, heights) ' sets the size of the picturebox
            Controls.Add(invaders0(count)) ' adds the picturebox to the form


            Dim newbox2 = New PictureBox ' creates  new picturebox
            invaders1(count) = newbox2 ' assigns a new picturebox to the array
            invaders1(count).Image = ImageList1.Images.Item(1) ' assigns a image from the imagelist to the picture box
            invaders1(count).SetBounds(x, y2, widths, heights) ' sets the size of the picturebox
            Controls.Add(invaders1(count)) ' adds the picturebox to the form


            Dim newbox3 = New PictureBox ' creates  new picturebox
            invaders2(count) = newbox3 ' assigns a new picturebox to the array
            invaders2(count).Image = ImageList1.Images.Item(2) ' assigns a image from the imagelist to the picture box
            invaders2(count).SetBounds(x, y3, widths, heights) ' sets the size of the picturebox
            Controls.Add(invaders2(count)) ' adds the picturebox to the form
            x = x + widths * 2 ' changes the x co ordinate of the invaders
        Next count ' goes to the next line in the loop
    End Sub ' creats 3 lines of invaders on the screen 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) ' Back Button
        frmstartpage.Show() ' shows the start page
        Me.Close() ' closes the game page
    End Sub ' Back Button
    Private Sub Picstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picstart.Click ' starts timer
        Timer1.Start() ' starts the timer 
    End Sub ' starts timer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick 'moving the invaders
        Static invadfire As Integer ' a variable for storing a value used to deploy the bullets from the invaders
        Static imagenumber1 As Integer 'variable for storing the number of images that make the defences crumble
        Static imagenumber2 As Integer 'variable for storing the number of images that make the defences crumble
        Static imagenumber3 As Integer 'variable for storing the number of images that make the defences crumble
        Dim hit As Integer = 0 'variable for the cannon being hit

        invadfire = invadfire + 1 ' adds one to the variable for getting the invaders to fire

        If invadfire > 50 Then ' if invaders fire is over 50
            invadfire = 0 ' resets the variable
            Call invaderfires() ' calls the fuction to get the invaderw to fire
        End If ' ends the if statement

        Timer3.Start() ' starts timer 3
        Dim picsize As Integer ' holds the value of the size of the pictuire box


        For count = 0 To 4 'loop to move the first line of invaders

            picsize = invaders1(0).Width ' assigns the value of the size of a picture box to the variable

            invaders0(count).Left = invaders0(count).Left + speed ' moves the invaders to the left
            invaders1(count).Left = invaders1(count).Left + speed ' moves the invaders to the left
            invaders2(count).Left = invaders2(count).Left + speed ' moves the invaders to the left
        Next count ' goes to the next point in the loop

        For count = 0 To 4 ' starts a loop

            If invaders0(4).Left > Me.ClientSize.Width - picsize Then ' checks to see if the invaders are touching the right side of the screen 
                invaders0(count).Top = invaders0(count).Top + 10 ' moves the invaders down a line
                speed = -speed ' reverses the direction
            End If 'ends the if statement

            If invaders0(0).Left < 0 Then ' checks to see if the invader on the left side of the screen is touching the left side
                invaders0(count).Top = invaders0(count).Top + 10 ' moves the invaders down a line
                speed = -speed ' reverses the direction
            End If ' ends the if statement

            If invaders1(4).Left > Me.ClientSize.Width - picsize Then ' checks to see if the invaders are touching the right side of the screen 
                invaders1(count).Top = invaders1(count).Top + 10 ' moves the invaders down a line
                speed = -speed ' reverses the direction
            End If ' ends the if statement

            If invaders1(0).Left < 0 Then ' checks to see if the invader on the left side of the screen is touching the left side
                invaders1(count).Top = invaders1(count).Top + 10 ' moves the invaders down a line
                speed = -speed ' reverses the direction
            End If ' ends the if statement

            If invaders2(4).Left > Me.ClientSize.Width - picsize Then ' checks to see if the invaders are touching the right side of the screen 
                invaders2(count).Top = invaders2(count).Top + 10 ' moves the invaders down a line
                speed = -speed ' reverses the direction
            End If ' ends the if statement

            If invaders2(0).Left < 0 Then ' checks to see if the invader on the left side of the screen is touching the left side
                invaders2(count).Top = invaders2(count).Top + 10 ' moves the invaders down a line
                speed = -speed ' reverses the direction
            End If ' ends if statement
        Next count ' goes to the next part of the loop
        '''''''''''''''''''lose game code'''''''''''''''''''''
        For count = 0 To 4 ' starts a loop
            If invaders2(count).Top + invaders2(count).Height > PictureBox16.Top And invaders2(count).Enabled = True Then ' sees if the first line of invaders has hit the defences
                Timer1.Stop() ' stops the timer
                MsgBox("You Lose") ' displayes the message you lose
                count = 4 ' sets the count variable to 4
                Call endgame() ' calls the function which ends the game
            End If 'ends the if statement
            If invaders1(count).Top + invaders1(count).Height > PictureBox16.Top And invaders1(count).Enabled = True Then ' sees if the first line of invaders has hit the defences
                Timer1.Stop() ' stops the timer
                MsgBox("You Lose") ' displayes the message you lose
                count = 4 ' sets the count variable to 4
                Call endgame() ' calls the function which ends the game
            End If 'ends the if statement
            If invaders0(count).Top + invaders0(count).Height > PictureBox16.Top And invaders0(count).Enabled = True Then ' sees if the first line of invaders has hit the defences
                Timer1.Stop() ' stops the timer
                MsgBox("You Lose") ' displayes the message you lose
                count = 4 ' sets the count variable to 4
                Call endgame() ' calls the function which ends the game
            End If 'ends the if statement
        Next count ' goes to the next point in the loop
        '''''''''''''make invaders invisible''''''''''''''''''''
        For count = 0 To 4 ' starts a loop
            If invaders0(count).Bounds.IntersectsWith(picbullet.Bounds) And invaders0(count).Visible = True Then ' if the bounds of the bullet intersect with the bounds of the invader
                invaders0(count).Visible = False ' the invader becomes invisible
                invaders0(count).Enabled = False ' the invader is no longer enabled
                Timer2.Stop() ' the timer stops
                picbullet.Top = PictureBox19.Location.Y ' the bullet is reset
                picbullet.Left = PictureBox19.Location.X + 30 ' the bullet is reset
                picbullet.Visible = False ' the bullet is turned invisible
                score = score + 20 ' adds 20 to the score
                win = win + 1 ' adds one to the win variable which ends the game if it is full
                visibleinvaders = visibleinvaders + 1 ' adds one to the visible indavers variable
            End If ' ends the if statament
            If invaders1(count).Bounds.IntersectsWith(picbullet.Bounds) And invaders1(count).Visible = True Then ' if the bounds of the bullet intersect with the bounds of the invader
                invaders1(count).Visible = False ' the invader becomes invisible
                invaders1(count).Enabled = False ' the invader is no longer enabled
                Timer2.Stop() ' the timer stops
                picbullet.Top = PictureBox19.Location.Y ' the bullet is reset
                picbullet.Left = PictureBox19.Location.X + 30 ' the bullet is reset
                picbullet.Visible = False ' the bullet is turned invisible
                score = score + 15 ' adds 15 to the score
                win = win + 1 ' adds one to the win variable which ends the game if it is full
                visibleinvaders = visibleinvaders + 1 ' adds one to the visible indavers variable
            End If ' ends the if statement
            If invaders2(count).Bounds.IntersectsWith(picbullet.Bounds) And invaders2(count).Visible = True Then ' if the bounds of the bullet intersect with the bounds of the invader
                invaders2(count).Visible = False ' the invader becomes invisible
                invaders2(count).Enabled = False ' the invader is no longer enabled
                Timer2.Stop() ' the timer stops
                picbullet.Top = PictureBox19.Location.Y ' the bullet is reset
                picbullet.Left = PictureBox19.Location.X + 30 ' the bullet is reset
                picbullet.Visible = False ' the bullet is turned invisible
                score = score + 10 ' adds 10 to the score
                win = win + 1 ' adds one to the win variable which ends the game if it is full
                visibleinvaders = visibleinvaders + 1 ' adds one to the visible indavers variable
            End If ' ends the if startement

        Next ' goes to the next part of the loop 
        lbllife.Text = lives ' makes the lifes diaplay
        Lblscore.Text = score ' makes the score display
        If win = 15 Then ' if 15 invaders have been shot
            Timer1.Stop() ' timer 1 stops
            MsgBox("You Win") ' a message box appears saying you win
        End If ' ends the if statement
        '''''''''''''''''''''''''''''''''''''''''''get the defences to break''''''''''''''''''''''''''''
        Try ' error catching
            If PictureBox16.Bounds.IntersectsWith(invadersbullet2.Bounds) = True Then ' if the invaders bullet intersects with the bounds of the defences
                imagenumber1 = imagenumber1 + 1 ' goes to the next number in the image list

                PictureBox16.Image = ImageList2.Images.Item(imagenumber1) ' changes the image from the image list
                invadersbullet2.Enabled = False
            End If 'ends if starement
        Catch ' error catching
        End Try ' error catching
        Try ' error catching
            If PictureBox17.Bounds.IntersectsWith(invadersbullet2.Bounds) = True Then ' if the invaders bullet intersects with the bounds of the defences
                imagenumber2 = imagenumber2 + 1 ' goes to the next number in the image list
                PictureBox17.Image = ImageList2.Images.Item(imagenumber2) ' changes the image from the image list
            End If 'ends if starement
        Catch ' error catching
        End Try ' error catching
        Try ' error catching
            If PictureBox18.Bounds.IntersectsWith(invadersbullet2.Bounds) = True Then ' if the invaders bullet intersects with the bounds of the defences
                imagenumber3 = imagenumber3 + 1 ' goes to the next number in the image list
                PictureBox18.Image = ImageList2.Images.Item(imagenumber3) ' changes the image from the image list
            End If 'ends if starement
        Catch ' error catching
        End Try ' error catching
        '''''''''''''''''''''''''''' lose a life when the cannon is hit''''''''''
        Try ' error catching
            If invadersbullet2.Bounds.IntersectsWith(PictureBox19.Bounds) Then ' if the invaders bullet hits the cannon
                hit = hit + 1 ' adds one to the variable 
            End If 'ends if starement

            If wait = 2 And PictureBox19.Visible = False Then ' if the timer has got to 2 and the picture box isnt visible
                PictureBox19.Visible = True ' makes the box visible again

            End If 'ends if starement
            If hit = 1 And PictureBox19.Visible = True Then ' if the variable = 2 and the picturebox is visible
                PictureBox19.Visible = False ' makes the picture invisible
                lives = lives - 1 ' takes a life away
                MsgBox("You Lost a Life") ' tells the user they have lost a life
                wait = 0 ' sets the variable wait to 0
                Timerwait.Start() ' starts the wait timer
            End If 'ends if starement
            ''''''''''''''''''lose when you have no lifes''''''''''''''''''
            lbllife.Text = lives ' makes the lifes diaplay
            If lives = 0 Then ' if the user has no lives
                Timer1.Stop() ' stops the timer
                MsgBox("You Lose") ' tells the user they lose
                Call endgame() ' calls the function to end the game
            End If 'ends if starement
        Catch ' error catching
        End Try ' error catching
        '''''''''''''''''''''''''''''''when bullet goes to the top it resets''''''''''''''''''''''
        If picbullet.Top < 0 Then ' if the bullet is at the top of the page
            Timer2.Stop() ' the timer stops
            picbullet.Top = PictureBox19.Location.Y ' resets the bullets position
            picbullet.Left = PictureBox19.Location.X + 30 ' resets the bullets position
            picbullet.Visible = False ' makes the bullet invisible
        End If 'ends if starement
    End Sub ' moving the invaders
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim xx As Integer = 50
        Timer1.Stop() ' stops the timer
        Timer2.Stop() ' stops the timer
        Timer3.Stop() ' stops the timer
        Timerwait.Stop() ' stops the timer
        score = 0 ' resets the score
        Lblscore.Text = score ' resets the score label
        timeplayed = 0 ' restes the time
        lbltime.Text = timeplayed ' resets the time label
        For count = 0 To 4 'loops
            invaders0(count).SetBounds(xx, y1, widths, heights) ' restes the invaders
            invaders0(count).Visible = True ' makes the invaders visible
            invaders1(count).SetBounds(xx, y2, widths, heights) ' restes the invaders
            invaders1(count).Visible = True ' makes the invaders visible
            invaders2(count).SetBounds(xx, y3, widths, heights) ' restes the invaders
            invaders2(count).Visible = True ' makes the invaders visible
            xx = xx + widths * 2 ' changes the x co ordinate of the invaders

            Try ' error catching
                invadersbullet2.Dispose() ' stiops the invaders bullets from existing
            Catch ' error catching
            End Try ' error catching
            timerbullets.Stop() ' stops the timer
            PictureBox19.Visible = True ' makes the cannon visible
        Next count ' loops
        picbullet.Left = PictureBox19.Location.X + 30 ' resets the bullet to the position of the cannon
        picbullet.Visible = False ' makes the bullet invisible
        PictureBox16.Image = ImageList2.Images.Item(1) ' resets the defences
        PictureBox17.Image = ImageList2.Images.Item(1) ' resets the defences
        PictureBox18.Image = ImageList2.Images.Item(1) ' resets the defences
    End Sub 'reset button
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If picbullet.Top < Me.ClientSize.Height - picbullet.Height Then ' if the bullet hasnt reached the top oof the page
            picbullet.Top = picbullet.Top - 10 ' move the bullet up the page
        End If ' ends the if statement
    End Sub 'moves the bullet
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        timeplayed = timeplayed + 1 ' adds one to the variable that stores how much time has elapsed in the game
        lbltime.Text = timeplayed ' updates the label showing the time played

    End Sub ' time
    Private Sub invaderfires()
        ''''''''''''indaver bullet''''''''''''''
        Dim x As Integer ' a variable to store the x position
        Dim y As Integer ' a variable to store the y position
        Dim count As Integer ' a variable to store the number in

        Dim randomnum As New Random ' a variable to store the random number

        Dim num As Integer ' a variable to store the random number
        num = randomnum.Next(5) 'creates a random bumber up to 5


        count = num ' assigns a random number to the count
        x = invaders2(count).Location.X ' creates the x position of the bullet
        y = invaders2(count).Location.Y ' creates the y position of the bullet

        Dim newbullet As New PictureBox ' creates a new picturebox called new bullet
        invadersbullet2 = newbullet ' assignes the bullet to the array
        invadersbullet2.BackColor = Color.White ' sets the background colour of the bullet
        invadersbullet2.SetBounds(x, y, 5, 5) ' sets the size of the picturebox
        Controls.Add(invadersbullet2) ' adds the picturebox to the form
        timerbullets.Start() ' starts the bullet timer
        invadersbullet2.Enabled = True
    End Sub ' get the invaders to fire
    Private Sub timerbullets_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerbullets.Tick
        invadersbullet2.Top = invadersbullet2.Top + 10 ' moves the bullets
        If invadersbullet2.Top > 800 Then ' when the bullet gets to the bottom of the screen
            invadersbullet2.Dispose() '  makes the bullet not exist anymore
        End If ' ends the if statement
    End Sub ' timer to move the bullet
    Private Sub endgame()
        Dim highscore As Integer ' a variable to hold the high score in
        Dim name As String ' a variable to hold name in
        Dim oldname As String ' a variable to hold the old name in

        name = Frmlogon.username ' gets the name from when the user has loggen in
        frmhighscore.Show() ' shows the high score form
        frmhighscore.ListBox1.Items.Clear() ' clears the items in the list box
        Dim Hsfilename As String = CurDir() & "\highscore.txt" ' sets the directory for the file handel
        FileOpen(1, Hsfilename, OpenMode.Input) ' starts the file handel
        Do While Not EOF(1) ' do while it is not the end of the file
            oldname = LineInput(1) ' assigns the old name to the variable
            highscore = LineInput(1) 'assigns the old high score to the variable
            frmhighscore.ListBox1.Items.Add(oldname & "      " & highscore) ' adds the old high score to the list box
        Loop ' loops through the text file
        FileClose(1) ' closes the file handel
        If score > highscore Then ' sees if the new high score is greater then the old high score
            FileOpen(1, highscore, OpenMode.Output) ' opens the file to be wrote to
            PrintLine(1, name) ' prints the name
            PrintLine(1, score) ' prints the score
            FileClose(1) ' closes the file handel

            frmhighscore.ListBox1.Items.Add(name & "      " & score) ' displays the  digh scores in the list box
        End If ' ends the if ststement
        score = 0 ' sets the score to 0
    End Sub ' what happends at the end of the game
    Private Sub Timerwait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerwait.Tick
        wait = wait + 1 ' adds 1 to the wait variable so that the cannon can disappear then re appear
    End Sub ' counts up a time to wait
    Private Sub picboxback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxback.Click
        frmstartpage.Show() ' opens the main menu
        Me.Hide() ' hides the current page
    End Sub 'back button
End Class


