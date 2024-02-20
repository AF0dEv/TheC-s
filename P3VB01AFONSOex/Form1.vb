Public Class Form1
    Dim dt as DataTable
    Dim obj as New DataBaseAccess
    Dim sc As String = obj.ConnectionString()

    ' ############################################## CRIAR INSCRIÇÃO ######################################################
    Sub CriarInscricao(idCandidato As String, nomeCandidato As String)
        Dim escalao As String = cbxEscalao.SelectedIndex.ToString()
        Dim local As String = cbxLocal.SelectedIndex.ToString()
        Dim sql As String
        If Convert.ToInt16(escalao) > 0 And Convert.ToInt16(local) > 0 Then
            escalao = cbxEscalao.SelectedText
            local = cbxLocal.SelectedText
            sql = "INSERT INTO Inscrição(id_candidato, nome_candidato, escalao, local)
                   VALUES (" + idCandidato + ", '" + nomeCandidato + "', '" + escalao + "', '" + local + "')"
            MessageBox.Show(sql)
            dt = obj.BuscarDados(sc, sql)
        End If
    End Sub
    ' ##################################### POVOAR DATAGRIDVIEW INSCRIÇÕES #####################################################
    Sub PovoarDGVInscricoes()
        Dim sql As String = "SELECT * FROM Inscrição" ' Query Buscar Todas Incriçoes
        dt = obj.BuscarDados(sc, sql) ' Guardar Tabela
        dgvBD.DataSource = dt ' Atirar para DGV
    End Sub
    ' ##################################### POVOAR COMBOBOX ESCALAO ######################################################
    Sub PovoarComboEscalao()

        Dim sql As String = "SELECT * FROM Escalão" ' Query Todos os Escalões
        dt = obj.BuscarDados(sc, sql) ' Buscar Tabela

        Dim r As DataRow = dt.NewRow() ' Criar Row 
        r("escalao") = 0 ' Index Primeiro Item
        r("escalao") = "Selecione Escalao" ' Nome

        dt.Rows.InsertAt(r, 0) ' Inserir Primeiro de Povoar

        '################### POVOAR ########################
        cbxEscalao.DataSource = dt ' Atirar datatable para combo
        cbxEscalao.DisplayMember = "escalao" ' Mostrar membro escalao
        cbxEscalao.ValueMember = "escalao" ' membro de valor escalao

    End Sub
    ' ##################################### POVOAR COMBOBOX LOCAL ######################################################
    Sub PovoarComboLocal()

        Dim sql As String = "SELECT * FROM Localidade" ' Query Todos os Escalões
        dt = obj.BuscarDados(sc, sql) ' Buscar Tabela

        Dim r As DataRow = dt.NewRow() ' Criar Row 
        r("local") = 0 ' Index Primeiro Item
        r("local") = "Selecione Localidade" ' Nome

        dt.Rows.InsertAt(r, 0) ' Inserir Primeiro de Povoar

        '################### POVOAR ########################
        cbxLocal.DataSource = dt ' Atirar datatable para combo
        cbxLocal.DisplayMember = "local" ' Mostrar membro escalao
        cbxLocal.ValueMember = "local" ' membro de valor escalao

    End Sub
    ' ############################################ EVENTOS #############################################################
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PovoarComboEscalao()
        PovoarComboLocal()
        PovoarDGVInscricoes()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = txtIdCandidato.Text
        Dim nome As String = txtNomeCandidato.Text
        CriarInscricao(id, nome)
    End Sub
End Class
