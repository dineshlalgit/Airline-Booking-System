Public Class confirm
    Public Property stringpass As String
    Private Sub confirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label14.Text = payflight.name_card.Text
        Label16.Text = payflight.Card_number.Text
        Label17.Text = payflight.email_id.Text
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        End
    End Sub
End Class


