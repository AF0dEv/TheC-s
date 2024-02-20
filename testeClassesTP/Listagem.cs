using System;
using System.Data;
using System.Xml.Serialization;
using System.Windows.Forms;
public class Listagem
{
    DataBaseAccess obj = new DataBaseAccess();
    private string sql;
    private string sc;
    DataTable dt = new DataTable();

    // ==================== PREENCHER DGV PROCESSO =================
    public void PreencherDgvProcesso(DataGridView dgv)
    {
        sc = obj.ConnectionString(); 
        sql = "SELECT * FROM Processos";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }

    // ===================== PREENCHER DGV CATEGORIA ================= 
    public void PreencherDgvCategoria(DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = "SELECT * FROM Categorias";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }

    // =================== PREENCHER DGV FUNCIONÁRIO =================
    public void PreencherDgvFuncionario(DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = "SELECT * FROM Funcionarios";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }

    // ================== PREENCHER DGV CLIENTES ====================== 
    public void PreencherDgvCliente(DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = "SELECT * FROM Clientes";
        dt = obj.BuscarDados(sc,sql);
        dgv.DataSource = dt;
    }

    // ================= PREENCHER COMBOBOXES =============================
    public void PreencherComboBoxes(ComboBox cbx, string tabela, string valueMember, string displayMember)
    {
        sc = obj.ConnectionString();
        if (tabela == "Funcionarios")
        {
            sql = "SELECT * FROM Funcionarios";
            dt = obj.BuscarDados(sc,sql);
            cbx.DataSource = dt;   
            cbx.ValueMember = valueMember;
            cbx.DisplayMember = displayMember;
        }
        else if (tabela == "Clientes")
        {
            sql = "SELECT * FROM Clientes";
            dt = obj.BuscarDados(sc, sql);
            cbx.DataSource = dt;
            cbx.ValueMember = valueMember;
            cbx.DisplayMember = displayMember;
        }
        else if (tabela == "Categorias")
        {
            sql = "SELECT * FROM Categorias";
            dt = obj.BuscarDados(sc, sql);
            cbx.DataSource = dt;
            cbx.ValueMember = valueMember;
            cbx.DisplayMember = displayMember;
        }
    }

    // ====================== LISTAR FUNCIONÁRIO =====================
    public void ListarFuncionario(string nomeFuncionario, string mes, DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = "SELECT Clientes.nomeCliente AS 'Cliente', Funcionarios.nomeFuncionario AS 'fUNCIONÁRIO , SUM(Processos.minutos) AS 'TempoTotal' FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Funcionarios.nomeFuncionario = '" + nomeFuncionario + "' AND MONTH(Processos.data) = '" + mes + "' GROUP BY Funcionarios.nomeFuncionario, Clientes.nomeCliente, Processos.minutos;";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }
    // ====================== LISTAR CLIENTES =====================
    public void ListarClientes(string nomeCliente, string mes, DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = "SELECT Funcionarios.nomeFuncionario AS 'Funcionário', Clientes.nomeCliente AS 'Cliente', SUM(Processos.minutos) AS 'TempoTotal' FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Clientes.nomeCliente = '" + nomeCliente + "' AND MONTH(Processos.data) = '" + mes + "' GROUP BY Funcionarios.nomeFuncionario, Clientes.nomeCliente, Processos.minutos;";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }


}

