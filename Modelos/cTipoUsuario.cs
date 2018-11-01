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

        public cTipoUsuario( int id, string nom, string des ) {

            this.IdTipoUsuario = (!id.Equals(null)) ? id : 0; 
            this.Nombre1 = ( !nom.Equals(null) ) ? nom : "";
            this.Descripcion1 = (!des.Equals(null)) ? des : "";

        }
        public cTipoUsuario() { }

        //GETTERS & SETTERS

        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }

   
    }
}
