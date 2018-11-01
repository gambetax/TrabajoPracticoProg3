using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class cTiposNovedad : cConectar
    {
        ArrayList listado;
        public cTiposNovedad() : base() {
            this.listado = new ArrayList();
        }

        //obtiene todos los registros
        public ArrayList getAll()
        {
            this.listado.Clear();

            using (OleDbDataReader datos = base.getRows("SELECT idTipoNovedad, Nombre, Descripcion FROM tbTipoNovedad"))
            {
                while (datos.Read())
                {
                    //Console.WriteLine(datos["idTipoNovedad"] + ": " + datos["Nombre"]);
                    this.listado.Add( new cTipoNovedad( (int)datos["idTipoNovedad"], datos["Nombre"].ToString() , datos["Descripcion"].ToString() ) );
                }
            }

            return this.listado;

        }

        public cTipoNovedad getId(int id)
        {
            
            using (OleDbDataReader datos = base.getRowId("SELECT idTipoNovedad, Nombre, Descripcion FROM tbTipoNovedad WHERE idTipoNovedad=@id", id))
            {
                if (datos.Read())
                {
                    return new cTipoNovedad( (int)datos["idTipoNovedad"] , datos["Nombre"].ToString() , datos["Descripcion"].ToString() ); 
                }
            }

            return null;

        }


    }
}
