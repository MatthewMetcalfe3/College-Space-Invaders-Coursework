Public Class Frmlogon
    Public passwordcorrect As Boolean ' a public variable to store the correct password
    Dim Filename As String ' a variuable to store the file name for the file handel
    Public username As String ' a public variable to store the username, this is also used on the high scores form
    Dim password As String ' a variable to store the password
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filename = CurDir() & "\name.txt" ' the directory for the file
    End Sub
    Private Sub btnlogon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogon.Click

        username = txtname.Text 'set the variables to the data in the text box
        password = txtpass.Text 'set the variables to the data in the text box

        If username = "" And password = "" Then 'if the username and password are both blank display a message telling the user to enter data
            MsgBox("Please Enter Username and Password")

        ElseIf username = "" Then 'if only the username is blank, display a message telling the user to enter a username
            MsgBox("Enter Username")

        ElseIf password = "" Then 'if only the password is blank, display a message telling the user to enter a username
            MsgBox("Enter Password")

        ElseIf checkdata(username & password) Then 'if the text file is the same as the username & pass, let them onto the game
            passwordcorrect = True ' sets a boolean value to true
            frmstartpage.Show() ' opens the start page
            Me.Hide() ' closes the current page

        Else
            MsgBox("Error Please Try Again") ' displays a error message
            txtname.Clear() ' clears the text box
            txtpass.Clear() ' clears the text box
            txtname.Focus() ' focuses the mouse over txtname
        End If
    End Sub
    Private Function checkdata(ByVal nametocheck As String)
        Dim datatocheck As String = ""
        FileOpen(1, Filename, OpenMode.Input) ' starts the file handel
        Do While Not EOF(1) And (Not String.Equals(nametocheck, datatocheck)) ' when it is not the end of the file it checks the name and password
            datatocheck = LineInput(1) ' checks the next line
        Loop
        FileClose(1) ' closes the file handel
        If String.Equals(nametocheck, datatocheck) Then ' if the name is there
            Return True ' returns a true value
        Else ' if it isnt there
            Return False ' returns a false value
        End If ' ends the if statement
    End Function
    Private Sub Btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnregister.Click
        Dim newname As String ' a variable to store a new name in
        Dim newpass As String ' a variable to store a new password in
        newname = InputBox("Add Your Username") ' opens a input box for the user to input their name into
        newpass = InputBox("Add Your Password") ' opens a input box for the user to input their password into
        If checkdata(newname & newpass) = False Then 'check to see if name is already there
            Call checkdata(newname & newpass) 'call check data function
            FileOpen(1, Filename, OpenMode.Append) ' opens the file handel to change the contents
            PrintLine(1, newname & newpass) 'if its not there then add name to list
            FileClose() ' closes the file handel
        Else
            MsgBox("That Has Allready Been Entered Please Use Other Details") 'if it is then show a message box
        End If
        txtname.Focus() ' focuses the mouse over the name
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub
End Class