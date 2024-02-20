using System;
using System.Data;

public class Categoria
{
	DataBaseAccess obj = new DataBaseAccess();
	private string sql;
	private string sc;
	DataTable dt = new DataTable();
	 
	// ================== MÉTODO INSERIR CATEGORIA ============================
    public void InserirCategoria(string categoria, DataGridView dgv)
	{
		sc = obj.ConnectionString();
		sql = " INSERT INTO Categorias(designacao)" +
			"			VALUES('" + categoria + "');";
		dt = obj.BuscarDados(sc, sql);
		dgv.DataSource = dt;
	}

	// ================== MÉTODO REMOVER CATEGORIA ==============================
	public void RemoverCategoria(string categoriaID, DataGridView dgv)
	{
		sc = obj.ConnectionString();
        sql = " DELETE FROM Categorias" +
			  "	WHERE categoriaID = " + categoriaID;
        dt = obj.BuscarDados(sc, sql);
		dgv.DataSource = dt;
	}
}	
