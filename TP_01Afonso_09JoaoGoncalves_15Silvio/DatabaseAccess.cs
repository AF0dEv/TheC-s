using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DataBaseAccess
{
    //################################################################################
    //METHOD THAT RETURNS A STRING WITH THE DATABASE CONNECTION
    //note: there may be several SC; choose the one you want to use
    public string ConnectionString()
    {
        string SCLagostimExterna = "Data Source=62.28.39.135,62444;Initial Catalog=ASJregistoTempos;User ID=EFAGONCALVES;Password=123.Abc;";

        //return the one you want to use:
        return SCLagostimExterna;
    }
    //################################################################################
    //METHOD THAT RETURNS A DATATABLE FROM THE PARAMETERS
    // SC (string connection) and ssql (query to the DB).
    public DataTable BuscarDados(string SC, string ssql)
    {
        SqlConnection Con = null;
        try
        {
            Con = new SqlConnection(SC);
            Con.Open();

            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(ssql, Con);
                SqlDataAdapter adapter = null;
                try
                {
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                finally
                {
                    adapter?.Dispose();
                }
            }
            finally
            {
                cmd?.Dispose();
            }
        }
        finally
        {
            Con?.Dispose();
        }
    }
}
