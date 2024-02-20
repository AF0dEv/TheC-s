Imports Microsoft.Win32

Public Class Form1
    ' #################### CONECTAR TABLE ############################
    Dim dt As New DataTable
    Dim obj As New DataBaseAccess
    Dim sc As String = obj.ConnectionString()
    Dim viagens As New Viagem
    Dim viaturas As New Viatura

    ' #################### POVOAR COMBOBOX ############################
    Sub PovoarCombo()
        Dim sql As String = "SELECT * FROM Viaturas" ' Query Todos as Viaturas
        dt = obj.BuscarDados(sc, sql) ' Buscar Tabela

        Dim r As DataRow = dt.NewRow() ' Criar Row Todos
        Try
            r("id") = 0 ' Index Todos
            r("Designacao") = "Todos" ' Nome

        Catch ex As Exception
            Throw ex
        End Try

        dt.Rows.InsertAt(r, 0) ' Inserir Primeiro de Povoar

        '################### POVOAR ########################
        cbxListaViagem.DataSource = dt
        cbxListaViagem.DisplayMember = "Designacao"
        cbxListaViagem.ValueMember = "id"
    End Sub
    ' ################## CRIAR VIAGEM #####################
    Sub CriarViagem()
        Dim form As New ViagemForm
        form.ShowDialog()
    End Sub
    ' ################## CRIAR VEICULO ####################
    Sub CriarViatura()
        Dim CriarViatura As New Form2
        CriarViatura.ShowDialog()
    End Sub
    ' ################# LISTAR VIAGENS #####################
    Sub listarViagens()
        Dim sql As String
        Dim id_viatura As String = cbxListaViagem.SelectedValue.ToString()
        Try
            If rbtListarMenor1Dia.Checked Then
                If id_viatura = 0 Then
                    sql = "SELECT * FROM Viagens"
                    dgvRegistos.DataSource = viagens.getViagem(sql)
                ElseIf id_viatura <> 0 Then
                    sql = "SELECT * FROM Viagens WHERE id_viatura = " + id_viatura
                    dgvRegistos.DataSource = viagens.getViagem(sql)
                End If
            ElseIf rbtListarMaior1dia.Checked Then
                If id_viatura = 0 Then
                    sql = "SELECT * FROM Viagens WHERE duracao > 1"
                    dgvRegistos.DataSource = viagens.getViagem(sql)
                ElseIf id_viatura <> 0 Then
                    sql = "SELECT * FROM Viagens WHERE id_viatura = " + id_viatura + " AND duracao > 1;"
                    dgvRegistos.DataSource = viagens.getViagem(sql)
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PovoarCombo()
    End Sub

    Private Sub btnListarViatura_Click(sender As Object, e As EventArgs) Handles btnListarViatura.Click
        Dim sql As String = "SELECT * FROM Viaturas"
        dt = viaturas.ListarViaturas(sql)
        dgvRegistos.DataSource = dt
    End Sub

    Private Sub btnCriarViatura_Click(sender As Object, e As EventArgs) Handles btnCriarViatura.Click
        CriarViatura()
    End Sub

    Private Sub btnEliminarViatura_Click(sender As Object, e As EventArgs) Handles btnEliminarViatura.Click
        MessageBox.Show("Para Eliminar uma Viatura, Clique 2X na Viatura a Eliminar", "Informaçao", MessageBoxButtons.OK)
    End Sub

    Private Sub dgvRegistos_CellMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvRegistos.CellMouseClick
        Dim pos As String = dgvRegistos.CurrentRow.Cells(0).Value.ToString()
        viaturas.Eliminar(pos)
    End Sub

    Private Sub btnCriarViagem_Click(sender As Object, e As EventArgs) Handles btnCriarViagem.Click
        CriarViagem()
    End Sub

    Private Sub btnListarViagem_Click(sender As Object, e As EventArgs) Handles btnListarViagem.Click
        listarViagens()
    End Sub

    Private Sub btnEliminarViagem_Click(sender As Object, e As EventArgs) Handles btnEliminarViagem.Click
        Dim id As String = dgvRegistos.CurrentRow.Cells(0).Value.ToString()
        viagens.eliminarViagem(id)
    End Sub
End Class
