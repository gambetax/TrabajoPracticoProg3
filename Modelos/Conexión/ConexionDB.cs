using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Sql;

namespace Modelos.Conexión
{
    public class ConexionDB
    {

        public OleDbConnection conexion;
        public OleDbDataAdapter adaptador;
        public OleDbCommand comando;

        private static ConexionDB ConDB = null;

        public static ConexionDB CrearConexion()
        {
            if (ConDB == null)
            {
                ConDB = new ConexionDB();
            }

            return ConDB;
        }

      /*  public static ConexionDB CerrarConexion(ConexionDB conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (Exception e)
            {
            }
        }
        */
    }


}
