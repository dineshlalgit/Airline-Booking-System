Public Class Admin
    Private Sub AirlinetableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AirlinetableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AirlinetableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AirlinedataDataSet)

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AirlinedataDataSet.Airlinetable' table. You can move, or remove it, as needed.
        Me.AirlinetableTableAdapter.Fill(Me.AirlinedataDataSet.Airlinetable)

    End Sub
End Class