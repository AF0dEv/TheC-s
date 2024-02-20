using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Cliente
{
    DataBaseAccess obj = new DataBaseAccess();
    private string sql;
    private string sc;
    DataTable dt = new DataTable();

    public void inserirCliente(string cliente, DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = " INSERT INTO Clientes(nomeCliente) VALUES ('" + cliente + "');";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }
    public void removerCliente(string idCliente, DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = "DELETE FROM Clientes WHERE clienteID = '" + idCliente + "';";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }
    public void preencherClientes(DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = "SELECT * FROM Clientes";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }
}

