Public Class Form1
    Private Sub cbxLocalidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLocalidades.SelectedIndexChanged

        txtLocalidade.Text = cbxLocalidades.Text ' Texto localidade = texto combobox

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxLocalidades.Items.Add("Porto")
        cbxLocalidades.Items.Add("Braga")
    End Sub
End Class
