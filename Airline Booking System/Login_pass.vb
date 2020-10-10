Public Class Login_pass

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "DINESHLAL" And PasswordTextBox.Text = "dineshlal" Then
            Bookurflight.Show()
            Hide()
        Else
            MsgBox("incorrect username or password", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UsernameTextBox.Refresh()
        PasswordLabel.Refresh()
    End Sub

    Private Sub Login_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Enabled = False
        PasswordTextBox.Enabled = False
        admin_text.Enabled = False
        passtext.Enabled = False
    End Sub

    Private Sub adminrd_CheckedChanged(sender As Object, e As EventArgs) Handles adminrd.CheckedChanged
        If adminbtn.Enabled = True Then
            UsernameTextBox.ResetText()
            PasswordTextBox.ResetText()
            UsernameTextBox.Enabled = False
            PasswordTextBox.Enabled = False
            admin_text.Enabled = True
            passtext.Enabled = True
        End If
        UsernameTextBox.Refresh()
        PasswordTextBox.Refresh()
    End Sub

    Private Sub adminbtn_Click(sender As Object, e As EventArgs) Handles adminbtn.Click
        If admin_text.Text = "DINESHLAL" And passtext.Text = "dineshlal" Then
            Admin.Show()
            Hide()
        Else
            MsgBox("Incorrect password or username", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub admincancel_Click(sender As Object, e As EventArgs) Handles admincancel.Click
        admin_text.ResetText()
        passtext.ResetText()
    End Sub

    Private Sub userrdbtn_CheckedChanged(sender As Object, e As EventArgs) Handles userrdbtn.CheckedChanged
        If userrdbtn.Enabled = True Then
            admin_text.ResetText()
            passtext.ResetText()
            UsernameTextBox.Enabled = True
            PasswordTextBox.Enabled = True
            admin_text.Enabled = False
            passtext.Enabled = False
        End If
    End Sub
End Class
