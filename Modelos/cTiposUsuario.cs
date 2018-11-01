using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    cTipoUsuario no realiza modificaciones en la bd, solo recupera los valores asociados   
     
*/

namespace Modelos
{
    public class cTiposUsuario : cConectar
    {
        ArrayList listado;
        public cTiposUsuario( ) : base()
        {
            this.listado = new ArrayList();
        }

        //obtiene todos los registros
        public ArrayList getAll() {

            this.listado.Clear();

            using (OleDbDataReader datos = base.getRows("SELECT idTipoUsuario, Nombre, Descripcion FROM tbTipoUsuario") ) {
                while (datos.Read())
                {
                    this.listado.Add( new cTipoUsuario( (int)datos["idTipoUsuario"], datos["Nombre"].ToString() , datos["Descripcion"].ToString() ));                    
                }
            }

            return this.listado;            
        
        }

        public cTipoUsuario getId( int id ) {

            cTipoUsuario tipo;

            using (OleDbDataReader datos = base.getRowId("SELECT idTipoUsuario, Nombre, Descripcion FROM tbTipoUsuario WHERE idTipoUsuario=@id", id ))
            {
                if (datos.Read())
                {                    
                    tipo = new cTipoUsuario((int)datos["idTipoUsuario"], (string)datos["Nombre"], (string)datos["Descripcion"]);
                    return tipo;
                }
            }

            return null;

        }




    }
}
