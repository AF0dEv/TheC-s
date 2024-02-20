Public Class Form1

    Dim total As Integer                ' Variavel guarda total
    Dim descontoEscalao As Integer      ' guarda valor desconto escalao
    Dim descontoSocio As Integer        ' guarda valor desconto Socio
    Dim agravamento As Integer = 12     ' guarda valor agravamento
    Dim descontoDistrito As Integer     ' guarda valor desconto distrito
    Dim descontoAno As Integer          ' guarda valor desconto Ano
    Dim avenca As String               ' guarda valor avença
    Dim descontoConcelho As Integer     ' guarda valor desconto concelho

    Sub CalcularPreço()
        Dim avenca As String
        Dim total As Integer

        avenca = txtValorBase.Text
        total = CInt(avenca)
        If (chkEscalao.Checked) Then
            descontoEscalao = avenca * 0.1
            total = total - descontoEscalao
            txtTotal.Text = CStr(total)
        Else
            txtTotal.Text = CStr(total)
        End If
        If (chkSocio.Checked) Then
            descontoSocio = avenca * 0.1
            total = total - descontoSocio
            txtTotal.Text = CStr(total)
        Else
            txtTotal.Text = CStr(total)
        End If
        If (chkAgravamento.Checked) Then
            total = total + agravamento
            txtTotal.Text = CStr(total)
        Else
            txtTotal.Text = CStr(total)
        End If
        If (rbtSim.Checked) Then
            descontoDistrito = avenca * 0.01
            total = total - descontoDistrito
            txtTotal.Text = CStr(total)
        Else
            txtTotal.Text = CStr(total)
        End If
        If (cbxConcelho.Text = "Amares") Then
            descontoConcelho = avenca * 0.2
            total = total - descontoConcelho
            txtTotal.Text = CStr(total)
        Else
            txtTotal.Text = CStr(total)
        End If
        If (txtIdade.Text >= "2000") Then
            descontoAno = avenca * 0.1
            total = total - descontoAno
            txtTotal.Text = CStr(total)
        Else
            txtTotal.Text = CStr(total)
        End If


    End Sub

    Private Sub chkEscalao_CheckedChanged(sender As Object, e As EventArgs) Handles chkEscalao.CheckedChanged
        CalcularPreço()
    End Sub

    Private Sub txtValorBase_TextChanged(sender As Object, e As EventArgs) Handles txtValorBase.TextChanged
        If txtValorBase.Text = "" Then
            avenca = "0"
            total = CInt(avenca)
        Else
            avenca = txtValorBase.Text
            total = CInt(avenca)
        End If
        txtTotal.Text = total
    End Sub

    Private Sub chkSocio_CheckedChanged(sender As Object, e As EventArgs) Handles chkSocio.CheckedChanged
        CalcularPreço()
    End Sub

    Private Sub chkAgravamento_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgravamento.CheckedChanged
        CalcularPreço()
    End Sub

    Private Sub rbtSim_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSim.CheckedChanged
        CalcularPreço()
    End Sub

    Private Sub cbxConcelho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxConcelho.SelectedIndexChanged
        CalcularPreço()
    End Sub

    Private Sub txtIdade_TextChanged(sender As Object, e As EventArgs) Handles txtIdade.TextChanged
        If (txtIdade.Text >= "2000") Then
            CalcularPreço()
        End If

    End Sub



    '    Dim total As Integer                ' Variavel guarda total
    '    Dim descontoEscalao As Integer      ' guarda valor desconto escalao
    '    Dim descontoSocio As Integer        ' guarda valor desconto Socio
    '    Dim agravamento As Integer = 12     ' guarda valor agravamento
    '    Dim descontoDistrito As Integer     ' guarda valor desconto distrito
    '    Dim descontoAno As Integer          ' guarda valor desconto Ano
    '    Dim avenca As Integer               ' guarda valor avença
    '    Dim descontoConcelho As Integer     ' guarda valor desconto concelho

    '    avenca = txtValorBase.Text
    '    total = CInt(avenca)

    '    ' Se tiver escalao
    '    If (chkEscalao.Checked) Then
    '        descontoEscalao = avenca * 0.1
    '        total = avenca - descontoEscalao
    '    End If

    '    'Se for socio
    '    If (chkSocio.Checked) Then
    '        descontoSocio = avenca * 0.05
    '        total = total - descontoSocio
    '    End If

    '    'se tiver agravamento
    '    If (chkAgravamento.Checked) Then
    '        total = total + agravamento
    '    End If

    '    'se for maior ou igual a 2000
    '    If (txtIdade.Text >= "2000") Then
    '        descontoAno = avenca * 0.1
    '        total = total - descontoAno
    '    End If

    '    'se for de Amares
    '    If (cbxConcelho.Text = "Amares") Then
    '        descontoConcelho = avenca * 0.2
    '        total = total - descontoConcelho
    '    End If

    '    ' se for do Distrito
    '    If (rbtSim.Checked) Then
    '        descontoDistrito = avenca * 0.01
    '        total = total - descontoDistrito
    '    End If


    '    txtTotal.Text = CStr(total)
    'End Sub

End Class

