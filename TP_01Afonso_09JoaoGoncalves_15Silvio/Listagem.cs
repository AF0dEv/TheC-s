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
        sql = "SELECT * FROM Processos order by processoID desc";
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
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }

    // ================= PREENCHER COMBOBOXES =============================
    public void PreencherComboBoxes(ComboBox cbx, string tabela, string valueMember, string displayMember)
    {
        sc = obj.ConnectionString();
        if (tabela == "Funcionarios")
        {
            sql = "SELECT * FROM Funcionarios order by nomeFuncionario";
            dt = obj.BuscarDados(sc, sql);
            cbx.DataSource = dt;
            cbx.ValueMember = valueMember;
            cbx.DisplayMember = displayMember;
            cbx = formatarCbx(cbx, dt, "nomeFuncionario");
        }
        else if (tabela == "Clientes")
        {
            sql = "SELECT * FROM Clientes order by nomeCliente";
            dt = obj.BuscarDados(sc, sql);
            cbx.DataSource = dt;
            cbx.ValueMember = valueMember;
            cbx.DisplayMember = displayMember;
            cbx = formatarCbx(cbx, dt, "nomeCliente");
        }
        else if (tabela == "Categorias")
        {
            sql = "SELECT * FROM Categorias order by designacao";
            dt = obj.BuscarDados(sc, sql);
            cbx.DataSource = dt;
            cbx.ValueMember = valueMember;
            cbx.DisplayMember = displayMember;
            cbx = formatarCbx(cbx, dt, "designacao");
        }

    }

    // ===================== FORMATA CBX ================================================
    ComboBox formatarCbx(ComboBox cbx, DataTable tabela, string nomeColuna)
    {
        // Obtenha os itens da coluna da DataTable
        AutoCompleteStringCollection autoCompleteOptions = new AutoCompleteStringCollection();
        foreach (DataRow row in tabela.Rows)
        {
            // Adicione os valores da coluna à coleção
            autoCompleteOptions.Add(row[nomeColuna].ToString());
        }

        // Definir as propriedades de autocompletar da ComboBox
        cbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
        cbx.AutoCompleteCustomSource = autoCompleteOptions;
        cbx.AutoCompleteMode = AutoCompleteMode.Append;

        return cbx;
    }

    // ====================== LISTAR FUNCIONÁRIO =====================
    public void ListarFuncionario(string nomeFuncionario, string mes, DataGridView dgv)
    {
        try
        {
            sc = obj.ConnectionString();
            if (mes == "00")
            {
                sql = "SELECT Clientes.nomeCliente as nome, SUM(Processos.minutos) as total_minutos, MONTH(Processos.data) as Mes FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Funcionarios.funcionarioID = " + nomeFuncionario + " group by Processos.cliente_id, Clientes.nomeCliente, MONTH(Processos.data);";
            }
            else
            {
                sql = "SELECT Clientes.nomeCliente, Processos.minutos FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Funcionarios.funcionarioID = '" + nomeFuncionario + "' AND MONTH(Processos.data) = '" + mes + "'; ";
            }
            dt = obj.BuscarDados(sc, sql);
            dgv.DataSource = dt;
        } catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }
    // ====================== LISTAR CLIENTES =====================
    public void ListarClientes(string nomeCliente, string mes, DataGridView dgv)
    {
        sc = obj.ConnectionString();
        if (mes == "00")
        {
            sql = "SELECT Funcionarios.nomeFuncionario as nome, SUM(Processos.minutos) as total_minutos, MONTH(Processos.data) as Mes FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Clientes.clienteID = " + nomeCliente + " group by Processos.funcionario_id, Funcionarios.nomeFuncionario, MONTH (Processos.data); ";
        }
        else
        {
            sql = "SELECT Funcionarios.nomeFuncionario, Processos.minutos FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Clientes.clienteID = '" + nomeCliente + "' AND MONTH(Processos.data) = '" + mes + "'; ";
        }
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }

    // ====================== CALCULA TOTAL FUNCIONARIO ========================

    public string CalculaTotalFuncionario (string nomeFuncionario, string mes)
    {
        sc = obj.ConnectionString();
        if(mes == "00")
        {
            sql = "SELECT SUM(Processos.minutos) FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Funcionarios.funcionarioID = " + nomeFuncionario + "; ";
        }
        else
        {    
            sql = "SELECT SUM(Processos.minutos) FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Funcionarios.funcionarioID = '" + nomeFuncionario + "' AND MONTH(Processos.data) = '" + mes + "'; ";
        }
        dt = obj.BuscarDados (sc, sql);
        return dt.Rows[0][0].ToString();
    }

    // ====================== CALCULA TOTAL CLIENTE ========================

    public string CalculaTotalCliente(string nomeCliente, string mes)
    {
        sc = obj.ConnectionString();
        if (mes == "00")
        {
            sql = "SELECT SUM(Processos.minutos) FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Clientes.clienteID = " + nomeCliente + "; ";
        }
        else
        {
            sql = "SELECT SUM(Processos.minutos) FROM Processos LEFT JOIN Clientes ON Clientes.clienteID = Processos.cliente_id RIGHT JOIN Funcionarios ON Funcionarios.funcionarioID = Processos.funcionario_id WHERE Clientes.clienteID = '" + nomeCliente + "' AND MONTH(Processos.data) = '" + mes + "'; ";
        }
            dt = obj.BuscarDados(sc, sql);
        return dt.Rows[0][0].ToString();
    }

    // =================== PREENCHE CBX MESES =======================================
    public void listarMes(ComboBox cbx)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("MesNumero", typeof(string));
        dt.Columns.Add("MesNome", typeof(string));

        dt.Rows.Add("00", "Todos");
        dt.Rows.Add("01", "Janeiro");
        dt.Rows.Add("02", "Fevereiro");
        dt.Rows.Add("03", "Março");
        dt.Rows.Add("04", "Abril");
        dt.Rows.Add("05", "Maio");
        dt.Rows.Add("06", "Junho");
        dt.Rows.Add("07", "Julho");
        dt.Rows.Add("08", "Agosto");
        dt.Rows.Add("09", "Setembro");
        dt.Rows.Add("10", "Outubro");
        dt.Rows.Add("11", "Novembro");
        dt.Rows.Add("12", "Dezembro");

        cbx.DataSource = dt;
        cbx.ValueMember = "MesNumero";
        cbx.DisplayMember = "MesNome";
    }


}

