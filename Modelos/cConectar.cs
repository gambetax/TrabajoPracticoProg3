using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class cConectar
    {
        protected  OleDbConnection con;

        protected static string connectionString = @"Data Source =.\datos\bd_facultad.mdb;Provider=Microsoft.Jet.OLEDB.4.0;";
        public cConectar()
        {
            try {
                this.con = new OleDbConnection(connectionString);                
                this.con.Open();                
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        //metodo generico que recibe nombre de tabla y un IDictionary(nombreCampo, Valor)  y asi arma la consulta
        protected bool addRow( string tableName , IDictionary<string,object> param )
        {
            if (this.con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    using( OleDbCommand cm = this.con.CreateCommand() )
                    {
                        string sql = "INSERT INTO " + tableName + " ( ";
                        string sqlval = " VALUES ( ";

                        foreach ( KeyValuePair<string, object> d in param ) {
                            sql += d.Key + ", ";
                            sqlval += "@"+ d.Key + ", "; 
                        }
                        //quito ultima coma y unifico
                        sql = sql.Substring(0, sql.Length-2);
                        sqlval = sqlval.Substring(0, sqlval.Length - 2);
                        sql += " ) " + sqlval + " )";

                        cm.CommandText = sql;

                        //parametros al command
                        foreach (KeyValuePair<string, object> d in param)
                        {
                            cm.Parameters.AddWithValue( "@"+d.Key , d.Value );
                        }

                        if ( cm.ExecuteNonQuery() > 0 )
                                return true;
                        else
                                return false;
                        
                    }
                } catch (Exception e) { Console.WriteLine(e.Message.ToString()); }

            }
            else
                Console.WriteLine("Conexion no establecida.");

            return false;
        }

        protected bool delRow( string sql, int id ) {
            if (this.con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    using (OleDbCommand cm = this.con.CreateCommand())
                    {
                        cm.CommandText = sql;
                        cm.Parameters.AddWithValue("@id", id);
                        
                        if (cm.ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            else
                Console.WriteLine("Conexion no establecida.");

            return false;


        }

        //Edita registro de tabla, recibe nombre de tabla y IDictionary(nombrecampo, valor)
        //LOS PARAMETROS DEBEN ESTAR EN EL ORDEN QUE VAN EN LA CONSULTA, ¿?
        protected bool editRow( string idName, string tableName , IDictionary<string,object> param ) {
            if (this.con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    using (OleDbCommand cm = this.con.CreateCommand())
                    {
                        string sql = "UPDATE " + tableName + " SET ";                                                

                        foreach (KeyValuePair<string,object> d in param)
                        {                            
                            if ( d.Key.ToString() != idName )                                                               
                                sql += d.Key + "=@" + d.Key + ", ";
                        }
                        //quito ultima coma
                        sql = sql.Substring(0, sql.Length - 2);
                                                
                        sql += " WHERE " + idName + "=@" + idName;

                        Console.WriteLine(@sql);
                        cm.CommandText = @sql;

                        //parametros al command
                        foreach (KeyValuePair<string,object> d in param)
                        {
                            cm.Parameters.AddWithValue("@" + d.Key, d.Value);                            
                        }
                        
                        if ( cm.ExecuteNonQuery() > 0 )
                            return true;
                        else
                            return false;

                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message.ToString()); }

            }
            else
                Console.WriteLine("Conexion no establecida.");

            return false;

        }

     
        protected OleDbDataReader getRows( string sql )
        {
            if (this.con.State == System.Data.ConnectionState.Open)
            {
                try {
                
                        using (OleDbCommand cm = this.con.CreateCommand())
                        {
                            cm.CommandText = sql;
                            return cm.ExecuteReader();
                        }        
                                        
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                
                }

            }
            else
                Console.WriteLine("Conexion no establecida.");

            return null;
        }

      
        protected OleDbDataReader getRowId( string sql , int id ) {

            if (this.con.State == System.Data.ConnectionState.Open) { 
                try
                {
                    using (OleDbCommand cm = this.con.CreateCommand()) {
                        cm.CommandText = sql;
                        cm.Parameters.AddWithValue("@id", id);
                        return cm.ExecuteReader();
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            else
                Console.WriteLine("Conexion no establecida.");

            return null;
        }

        ~cConectar() {
            try
            {
                if (this.con.State == System.Data.ConnectionState.Open) {
                    con.Close();
                    con.Dispose();
                }
                            
            }
            catch (Exception e) { Console.WriteLine(e.Message.ToString()); }
        }

    }
}
