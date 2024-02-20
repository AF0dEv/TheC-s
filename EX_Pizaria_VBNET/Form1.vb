Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim total As Integer
        Dim desconto As Integer
        total = 0
        If (rbtNao.Checked) Then
            total = (CInt(txtPrecoPizza.Text) * CInt(txtQtdPizza.Text)) + (CInt(txtPrecoBebida.Text) * CInt(txtQtdBebida.Text)) + (CInt(txtPrecoExtra.Text) * CInt(txtQtdExtra.Text))
        End If
        If (rbtSim.Checked) Then
            total = (CInt(txtPrecoPizza.Text) * CInt(txtQtdPizza.Text)) + (CInt(txtPrecoBebida.Text) * CInt(txtQtdBebida.Text)) + (CInt(txtPrecoExtra.Text) * CInt(txtQtdExtra.Text))
            desconto = total * 0.1
            total = total - desconto
        End If
        txtTotal.Text = CStr(total)

    End Sub

    Private Sub cbxPizzas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPizzas.SelectedIndexChanged
        If (cbxPizzas.Text = "4 Estações") Then
            txtPrecoPizza.Text = "10"
        End If
        If (cbxPizzas.Text = "Margarida") Then
            txtPrecoPizza.Text = "9"
        End If
        If (cbxPizzas.Text = "Ananas") Then
            txtPrecoPizza.Text = "8"
        End If
    End Sub
    Sub CalcularExtras()
        Dim soma As Integer

        soma = 0

        If (chkQueijo.Checked) Then
            soma = soma + 1
        End If
        If (chkAzeitona.Checked) Then
            soma = soma + 1
        End If
        If (chkPepino.Checked) Then
            soma = soma + 2
        End If
        txtPrecoExtra.Text = CStr(soma)
    End Sub

    Private Sub chkQueijo_CheckedChanged(sender As Object, e As EventArgs) Handles chkQueijo.CheckedChanged
        CalcularExtras()
    End Sub

    Private Sub chkAzeitona_CheckedChanged(sender As Object, e As EventArgs) Handles chkAzeitona.CheckedChanged
        CalcularExtras()
    End Sub

    Private Sub chkPepino_CheckedChanged(sender As Object, e As EventArgs) Handles chkPepino.CheckedChanged
        CalcularExtras()
    End Sub

    Private Sub cbxBebidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBebidas.SelectedIndexChanged
        If (cbxBebidas.Text = "Coca-Cola") Then
            txtPrecoBebida.Text = "2"
        End If
        If (cbxBebidas.Text = "Água") Then
            txtPrecoBebida.Text = "1"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanciar a Classe Nova
        Dim obj As New DataBaseAccess

        'Definir a String Connection
        Dim strConn As String = obj.ConnectionString()
        'Definir String SQL
        Dim strSQL As String = "select Produtos, Preços from Produto"
        'Trazer Dados e Atribuilos a Grid
        dgvBD.DataSource = obj.BuscarDados(strConn, strSQL)
    End Sub

End Class
