using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class cMaterias : cConectar
    {
        ArrayList listado;

        public cMaterias() : base() {
            this.listado = new ArrayList();
        }
        
        public bool add( cMateria mat ) {
            
            IDictionary<string, object> param = new Dictionary<string, object>();

            param.Add( "idUsuario" , mat.idUsuario );
            param.Add( "Nombre", mat.Nombre );
            param.Add( "Descripcion", mat.Descripcion );

            return base.addRow( "tbMateria", param );

        }

        public bool edit( cMateria mat ) {

            IDictionary<string, object> param = new Dictionary<string, object>();

            param.Add("idUsuario", mat.idUsuario );
            param.Add("Nombre", mat.Nombre );
            param.Add("Descripcion", mat.Descripcion );
            param.Add("idMateria", mat.idMateria );

            return base.editRow( "idMateria" , "tbMateria", param );
        }

        public bool del( int id ) {
            return base.delRow("DELETE * FROM tbMateria WHERE idMateria=@id", id);
        }

        public cMateria getId(int id)
        {
            string sql = "SELECT idMateria, Nombre, Descripcion, idUsuario  FROM tbMateria WHERE idMateria=@id";
            //getRowId retorna un DataReader con los datos, con el se crea la clase
            using (OleDbDataReader datos = base.getRowId( sql , id ))
            {
                if (datos.Read())
                {
                    return new cMateria( (int)datos["idMateria"], (int)datos["idUsuario"], datos["Nombre"].ToString(), datos["Descripcion"].ToString() );
                }

            }

            return null;

        }

        public ArrayList getAll()
        {

            this.listado.Clear();


            using (OleDbDataReader datos = base.getRows("SELECT * FROM tbMateria"))
            {

                while (datos.Read())
                {
                    this.listado.Add(new cMateria((int)datos["idMateria"], (int)datos["idUsuario"], datos["Nombre"].ToString(), datos["Descripcion"].ToString() ));
                }
            }

            return this.listado;
        }


    }
}
