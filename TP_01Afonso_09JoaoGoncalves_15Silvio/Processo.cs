using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Processo
    {
        DataBaseAccess obj = new DataBaseAccess();
        private string sql;
        private string sc;
        DataTable dt = new DataTable();

        public void inserirProcesso(string funcionario, string cliente, string categoria, string descricao, string data, int minutos)
        {
            sc = obj.ConnectionString();
            sql = " INSERT INTO Processos(funcionario_id, cliente_id, categoria_id, descricao, data, minutos) VALUES ('" + funcionario + "','" + cliente + "', '" + categoria + "','" + descricao + "', '" + data + "', '" + minutos + "');";
            dt = obj.BuscarDados(sc, sql);
        }
        public void removerProcesso(string idProcesso)
        {
            sc = obj.ConnectionString();
            sql = " DELETE FROM Processos WHERE processoID = '" + idProcesso + "';";
            dt = obj.BuscarDados(sc, sql);
        }
    }
}
