Public Class Form1
    Private Sub rbtM_CheckedChanged(sender As Object, e As EventArgs) Handles rbtM.CheckedChanged
        If (rbtM.Checked) Then
            txtSexo.Text = "Masculino"
        End If
    End Sub

    Private Sub rbtF_CheckedChanged(sender As Object, e As EventArgs) Handles rbtF.CheckedChanged
        If (rbtF.Checked) Then
            txtSexo.Text = "Feminino"
        End If
    End Sub
End Class
