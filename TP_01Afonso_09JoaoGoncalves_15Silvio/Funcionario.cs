using System;
using System.Data;
using System.Windows.Forms;

public class Funcionario
{
    DataBaseAccess obj = new DataBaseAccess();
    private string sql;
    private string sc;
    DataTable dt = new DataTable();

    // ================== MÉTODO INSERIR CATEGORIA ============================
    public void InserirFuncionario(string funcionario, DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = " INSERT INTO Funcionarios(nomeFuncionario)" +
            "			VALUES('" + funcionario + "');";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }

    // ================== MÉTODO REMOVER CATEGORIA ==============================
    public void RemoverFuncionario(string funcionario_ID, DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = " DELETE FROM Funcionarios" +
              "	WHERE funcionarioID = " + funcionario_ID;
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }

    public void preencherDgvFuncionario(DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = "select * from Funcionarios;";
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }
}
