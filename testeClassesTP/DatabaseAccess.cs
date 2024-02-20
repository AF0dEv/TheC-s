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
            string SCLagostimExterna = "Data Source=10.30.10.2,62555;Initial Catalog=exercicioTP;User ID=EFAGONCALVES;Password=123.Abc;";

            //return the one you want to use:
            return SCLagostimExterna;
        }
        //################################################################################
        //METHOD THAT RETURNS A DATATABLE FROM THE PARAMETERS
        // SC (string connection) and ssql (query to the DB).
        public DataTable BuscarDados(string SC, string ssql)
        {
            using SqlConnection Con = new(SC);
            Con.Open();

            using SqlCommand cmd = new(ssql, Con);
            using SqlDataAdapter adapter = new(cmd);
            DataTable dt = new();
            adapter.Fill(dt);

            return dt;
        }
    }
