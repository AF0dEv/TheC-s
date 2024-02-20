using System;
using System.Data;

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
    public void RemoverCategoria(string funcionario_ID, DataGridView dgv)
    {
        sc = obj.ConnectionString();
        sql = " DELETE FROM Funcionarios" +
              "	WHERE funcionario_ID = " + funcionario_ID;
        dt = obj.BuscarDados(sc, sql);
        dgv.DataSource = dt;
    }
}
