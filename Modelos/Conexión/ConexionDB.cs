using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Modelos.Conexión
{
    class ConexionAlternativa
    {
        protected OleDbConnection con;

        protected static string connectionString = @"Data Source =.\datos\bd_facultad.mdb;Provider=Microsoft.Jet.OLEDB.4.0;";
        public cConectar()
        {
            try
            {
                this.con = new OleDbConnection(connectionString);
                this.con.Open();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }



    }
}
