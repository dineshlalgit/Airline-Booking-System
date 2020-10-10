Public Class payflight
    Private Sub pay_btn_Click(sender As Object, e As EventArgs) Handles pay_btn.Click

        confirm.Show()
        Me.Hide()
    End Sub

    Private Sub cancel_btnpay_Click(sender As Object, e As EventArgs) Handles cancel_btnpay.Click
        Hide()
    End Sub

    Private Sub payflight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim random As New Random

        Dim a As Integer
        a = Random.Next(3000, 15000)
        If Bookurflight.adults_c.Enabled = True And Bookurflight.store_c.Enabled = True Then
            price.Text = a * Bookurflight.adults_c.SelectedItem + Bookurflight.Children_c.SelectedItem * a / 2 + Bookurflight.store_c.SelectedItem * 5
        End If
    End Sub
End Class