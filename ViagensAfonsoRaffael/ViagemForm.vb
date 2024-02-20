Public Class ViagemForm

    Dim Viagem As New Viagem
    Dim obj As New DataBaseAccess
    Dim dt As New DataTable
    Dim form1 As New Form1
    Dim sc As String = obj.ConnectionString()
    Dim ssql As String


    Private Sub btnCriarViagem_Click(sender As Object, e As EventArgs) Handles btnCriarViagem.Click

        Viagem.criarViagem(txtDuracaoViagem.Text, txtKm.Text, cbxViagem.SelectedIndex + 1)

    End Sub

    ' #################### POVOAR COMBOBOX ############################
    Sub PovoarCombo()
        Dim sql As String = "SELECT * FROM Viaturas" ' Query Todos as Viaturas
        dt = obj.BuscarDados(sc, sql) ' Buscar Tabela

        '################### POVOAR ########################
        cbxViagem.DataSource = dt
        cbxViagem.DisplayMember = "Designacao"
        cbxViagem.ValueMember = "id"
    End Sub


    Private Sub btnSairViagem_Click(sender As Object, e As EventArgs) Handles btnSairViagem.Click
        Close()
    End Sub

    Private Sub ViagemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PovoarCombo()
    End Sub
End Class