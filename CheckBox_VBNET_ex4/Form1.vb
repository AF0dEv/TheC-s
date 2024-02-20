Public Class Form1
    ' COM BOTAO

    'Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
    '    Dim resultado As Integer
    '    resultado = 0

    '    If (chkAtletismo.Checked) Then
    '        resultado = resultado + 1
    '    End If
    '    If (chkCiclismo.Checked) Then
    '        resultado = resultado + 1
    '    End If
    '    If (chkNatacao.Checked) Then
    '        resultado = resultado + 1
    '    End If

    '    txtResultado.Text = resultado


    'End Sub

    ' SEM BOTAO

    Sub ContarChecked()
        Dim resultado As Integer
        resultado = 0

        If (chkAtletismo.Checked) Then
            resultado = resultado + 1
        End If
        If (chkCiclismo.Checked) Then
            resultado = resultado + 1
        End If
        If (chkNatacao.Checked) Then
            resultado = resultado + 1
        End If

        txtResultado.Text = CStr(resultado)
    End Sub

    Private Sub chkCiclismo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCiclismo.CheckedChanged
        ContarChecked()
    End Sub

    Private Sub chkAtletismo_CheckedChanged(sender As Object, e As EventArgs) Handles chkAtletismo.CheckedChanged
        ContarChecked()
    End Sub

    Private Sub chkNatacao_CheckedChanged(sender As Object, e As EventArgs) Handles chkNatacao.CheckedChanged
        ContarChecked()
    End Sub
End Class
