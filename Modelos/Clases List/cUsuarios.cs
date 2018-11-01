using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class cUsuarios : cConectar
    {
        private ArrayList listado;

        public cUsuarios() : base() {
            this.listado = new ArrayList();
        }

        public bool add( cUsuario user ) {

            IDictionary<string, object> param = new Dictionary<string, object>();

            param.Add( "idTipoUsuario" , user.GetSetIdTipoUsuario );
            param.Add("Nombre", user.GetSetNombre);
            param.Add("Apellido", user.GetSetApellido);
            param.Add("Dni", user.GetSetDni );
            param.Add("Usuario", user.GetSetUsuario );
            param.Add("Pass", user.GetSetPass );
            param.Add("Email", user.GetSetEmail );

            return base.addRow( "tbUsuario" , param );
            
        }

        public bool edit( cUsuario user ) {            
            IDictionary<string, object> param = new Dictionary<string, object>();
                        
            param.Add("idTipoUsuario", user.GetSetIdTipoUsuario);
            param.Add("Nombre", user.GetSetNombre);
            param.Add("Apellido", user.GetSetApellido);
            param.Add("Dni", user.GetSetDni);
            param.Add("Usuario", user.GetSetUsuario);
            param.Add("Pass", user.GetSetPass);
            param.Add("Email", user.GetSetEmail);
            param.Add("idUsuario", user.GetSetIdUsuario);
                        
            return base.editRow( "idUsuario", "tbUsuario", param );

        }

        public bool del( int id ) {
            return base.delRow( "DELETE * FROM tbUsuario WHERE idUsuario=@id", id );
        }


        //busca usuario, Null si no encuentra
        public cUsuario getId (int id) {
                        
            //getRowId retorna un DataReader con los datos, con el se crea la clase
            using ( OleDbDataReader datos = base.getRowId("SELECT * FROM tbUsuario WHERE idUsuario=@id", id) )
            {
                if (datos.Read())
                {
                    return new cUsuario( (int)datos["idUsuario"], (int)datos["idTipoUsuario"], datos["Nombre"].ToString(), (string)datos["Apellido"], datos["Dni"].ToString(), datos["Usuario"].ToString(), datos["Pass"].ToString(), datos["Email"].ToString() );
                }
                
            }

            return null;
        }

        public ArrayList getAll() {

            this.listado.Clear();


            using (OleDbDataReader datos = base.getRows("SELECT * FROM tbUsuario"))
            {
                
                while (datos.Read())
                {
                    this.listado.Add( new cUsuario( (int)datos["idUsuario"], (int)datos["idTipoUsuario"], datos["Nombre"].ToString(), (string)datos["Apellido"], datos["Dni"].ToString(), datos["Usuario"].ToString() , datos["Pass"].ToString(), datos["Email"].ToString()) );                    
                }
            }
            
            return this.listado;
        }



    }
}
