using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class cTipoUsuario
    {
        private int idTipoUsuario;
        private string Nombre;
        private string Descripcion;

        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public string GetSetNombre { get => Nombre; set => Nombre = value; }
        public string GetSetDescripcion { get => Descripcion; set => Descripcion = value; }

        public cTipoUsuario( int id, string nom, string des ) {

            this.IdTipoUsuario = (!id.Equals(null)) ? id : 0; 
            this.GetSetNombre = ( !nom.Equals(null) ) ? nom : "";
            this.GetSetDescripcion = (!des.Equals(null)) ? des : "";

        }
        public cTipoUsuario() { }



        

        //GETTERS & SETTERS


   
    }
}
