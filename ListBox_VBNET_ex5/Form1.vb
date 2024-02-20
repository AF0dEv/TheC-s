Public Class Form1
    Private Sub lstNomes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNomes.SelectedIndexChanged
        txtNome.Text = lstNomes.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstNomes.Items.Add("Ivo")
        lstNomes.Items.Add("Bela")
    End Sub
End Class
