Public Class login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click

        If Text1box.Text = "Dineshlal" And Text2box.Text = "DINESHLAL" Then
            Bookingflight.Show()

        Else
            MsgBox("incorrect username or password", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class
