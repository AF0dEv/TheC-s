Imports System.Runtime.InteropServices

Public Class Form1
    ' ######################### DECLARAR VARIAVEIS GLOBAIS #####################
    Dim dt as DataTable ' Variavel Recebe Dados BD
    Dim obj as New DataBaseAccess ' Objeto Criado a Partir de classe DataBaseAccess
    Dim sc As String = obj.ConnectionString() ' Variavel String Connection a BD

    ' ##################################### POVOAR COMBOBOX ESCALAO ######################################################
    Sub PovoarComboEscalao()

        Dim sql As String = "SELECT * FROM Escalão" ' Query Todos os Escalões
        dt = obj.BuscarDados(sc, sql) ' Buscar Tabela

        Dim r As DataRow = dt.NewRow() ' Criar Row 
        r("escalao") = 0 ' Index Primeiro Item
        r("escalao") = "Todos" ' Nome

        dt.Rows.InsertAt(r, 0) ' Inserir Primeiro de Povoar

        '################### POVOAR ########################
        cbxEscalao.DataSource = dt ' Atirar datatable para combo
        cbxEscalao.DisplayMember = "escalao" ' Mostrar membro escalao
        cbxEscalao.ValueMember = "escalao" ' membro de valor escalao

    End Sub

    ' ################################ POVOAR DGV #######################################################
    Function PovoarDGV() as DataTable
        Dim sql As String
        Dim id As String = txtIdCandidatos.Text
        'Dim idint As Integer
        Try
            Dim escalao as String = cbxEscalao.SelectedValue.ToString()
            If cbxEscalao.SelectedIndex <> 0 And rbtTodos.Checked Then ' se for um certo escalao mas todos os locais
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE escalao = '" + escalao + "'"
                
            Elseif rbtBraga.Checked and cbxEscalao.SelectedIndex > 0 Then ' se for um certo escalao e Braga
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE escalao = '" + escalao + "' AND local = 'Braga'"
                

            Elseif rbtPorto.Checked and cbxEscalao.SelectedIndex > 0 Then  ' se for um certo escalao e porto
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE escalao = '" + escalao + "' AND local = 'Porto'"
                

            Elseif rbtBeja.Checked and cbxEscalao.SelectedIndex > 0 Then ' se for um certo escalao e beja
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE escalao = '" + escalao + "' AND local = 'Beja'"
                
            Elseif cbxEscalao.Selectedindex = 0 and rbtBraga.Checked Then ' se for todos escaloes mas braga
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE local = 'Braga'"
                
            Elseif cbxEscalao.Selectedindex = 0 and rbtPorto.Checked Then ' se for todos escaloes mas porto
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE local = 'Porto'"
                
            Elseif cbxEscalao.Selectedindex = 0 and rbtBeja.Checked Then ' se for todos escaloes mas beka
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE local = 'Beja'"
                
            
                Else  ' se for todos
                    sql = "SELECT * FROM Inscrição"
                    dgvBD.DataSource = obj.BuscarDados(sc, sql)
                End If
            dt = obj.BuscarDados(sc, sql)
            Return dt
        Catch ex As Exception
            sql = "SELECT * FROM Inscrição"
            dt = obj.BuscarDados(sc, sql)
            Return dt
        End Try

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PovoarComboEscalao()

    End Sub

    Private Sub cbxEscalao_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxEscalao.SelectionChangeCommitted
        dim datatable as DataTable
        datatable = PovoarDGV()
        dgvBD.DataSource = datatable
    End Sub
    Private Sub rbtTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTodos.CheckedChanged
        dt = PovoarDGV()
        dgvBD.DataSource = dt
    End Sub

    Private Sub rbtBraga_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBraga.CheckedChanged
        dt = PovoarDGV()
        dgvBD.DataSource = dt
    End Sub

    Private Sub rbtPorto_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPorto.CheckedChanged
        dt = PovoarDGV()
        dgvBD.DataSource = dt
    End Sub

    Private Sub rbtBeja_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBeja.CheckedChanged
        dt = PovoarDGV()
        dgvBD.DataSource = dt
    End Sub

    Private Sub btnBuscarID_Click(sender As Object, e As EventArgs) Handles btnBuscarID.Click
        Dim escalao As String = cbxEscalao.SelectedValue.ToString()
        Dim id As String = txtIdCandidatos.Text
        Dim sql As String 
        Dim datatable As DataTable
        Try
            Dim idint as Integer
            idint = convert.ToInt16(id)
            If cbxEscalao.SelectedIndex > 0 And rbtTodos.Checked Then ' se for um certo escalao mas todos os locais
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE escalao = '" + escalao + "' And id_candidato = " + id
                
            Elseif rbtBraga.Checked and cbxEscalao.SelectedIndex > 0 Then ' se for um certo escalao e Braga
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE escalao = '" + escalao + "' AND local = 'Braga' And id_candidato = " + id
                

            Elseif rbtPorto.Checked and cbxEscalao.SelectedIndex > 0 Then  ' se for um certo escalao e porto
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE escalao = '" + escalao + "' AND local = 'Porto' And id_candidato = " + id
                

            Elseif rbtBeja.Checked and cbxEscalao.SelectedIndex > 0 Then ' se for um certo escalao e beja
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE escalao = '" + escalao + "' AND local = 'Beja' And id_candidato = " + id
                

            Elseif cbxEscalao.Selectedindex = 0 and rbtTodos.Checked Then ' se for todos escaloes e todos locais
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE id_candidato = " + id
                
            Elseif cbxEscalao.Selectedindex = 0 and rbtBraga.Checked Then ' se for todos escaloes Braga
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE id_candidato = " + id + " AND local = 'Braga'"
                
            Elseif cbxEscalao.Selectedindex = 0 and rbtPorto.Checked Then ' se for todos escaloes e Porto
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE id_candidato = " + id + " AND local = 'Porto'"
                
            Elseif cbxEscalao.Selectedindex = 0 and rbtBeja.Checked Then ' se for todos escaloes e beja
                sql = "SELECT * 
                           FROM Inscrição
                           WHERE id_candidato = " + id + " AND local = 'Beja'"
                
        End If
            dgvBD.DataSource = obj.BuscarDados(sc, sql)

        Catch ex As Exception
            MessageBox.Show("Insira id Valido")
        End Try
    End Sub
End Class
