Public Class Bookurflight
    Dim obj As New confirm
    Private Sub Bookurflight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        destination_c.Enabled = False
        arrival_c.Enabled = False
        dtpicker_d.Enabled = False
        dtpicker_a.Enabled = False
        concession_c.Enabled = False
        adults_c.Enabled = False
        Children_c.Enabled = False
        store_c.Enabled = False
        class_c.Enabled = False

    End Sub

    Private Function Randomize(v1 As Integer, v2 As Integer) As Label
        Throw New NotImplementedException()
    End Function

    Private Sub onebtnrd_CheckedChanged(sender As Object, e As EventArgs) Handles onebtnrd.CheckedChanged
        destination_c.Enabled = True
        arrival_c.Enabled = True
        dtpicker_d.Enabled = True
        dtpicker_a.Enabled = False
        adults_c.Enabled = True
        Children_c.Enabled = True
        store_c.Enabled = True
        class_c.Enabled = True
    End Sub

    Private Sub conrdbtn1_CheckedChanged(sender As Object, e As EventArgs) Handles conrdbtn1.CheckedChanged
        concession_c.Enabled = True
    End Sub

    Private Sub roundrd_CheckedChanged(sender As Object, e As EventArgs) Handles roundrd.CheckedChanged
        destination_c.Enabled = True
        arrival_c.Enabled = True
        dtpicker_d.Enabled = True
        dtpicker_a.Enabled = True
        adults_c.Enabled = True
        Children_c.Enabled = True
        store_c.Enabled = True
        class_c.Enabled = True
    End Sub
    Private Sub conrdbtn2_CheckedChanged(sender As Object, e As EventArgs) Handles conrdbtn2.CheckedChanged
        concession_c.Enabled = False
    End Sub

    Private Sub destination_c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles destination_c.SelectedIndexChanged
        confirm.lbldestination.Text = destination_c.SelectedItem
    End Sub



    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Login_pass.Show()
        Hide()
    End Sub

    Private Sub arrival_c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles arrival_c.SelectedIndexChanged
        confirm.lblarrival.Text = arrival_c.SelectedItem
    End Sub

    Private Sub concession_c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles concession_c.SelectedIndexChanged
        confirm.lblconcession.Text = concession_c.SelectedItem
    End Sub

    Private Sub adults_c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles adults_c.SelectedIndexChanged

        confirm.lbladults.Text = adults_c.SelectedItem
    End Sub

    Private Sub Children_c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Children_c.SelectedIndexChanged
        confirm.lblchild.Text = Children_c.SelectedItem
    End Sub

    Private Sub Infants_c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles store_c.SelectedIndexChanged
        confirm.lblinfants.Text = store_c.SelectedItem
    End Sub

    Private Sub class_c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles class_c.SelectedIndexChanged
        confirm.lblclass.Text = class_c.SelectedItem
    End Sub

    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        Dim d As String
        Dim f As String
        d = dtpicker_d.Value.ToShortDateString.ToString()
        f = dtpicker_a.Value.ToShortDateString.ToString()
        confirm.destination_date.Text = d
        confirm.return_date.Text = f
        payflight.Show()
        Hide()
    End Sub

    Private Sub dtpicker_d_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker_d.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dtpicker_a_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker_a.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class