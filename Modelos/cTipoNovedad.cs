using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{       

    public class cTipoNovedad
    {
        private int idTipoNovedad;
        private string Nombre;
        private string Descripcion;

        //

        public cTipoNovedad( int id, string nom, string des) {
            this.IdTipoNovedad = ( !id.Equals(null) ) ? id : 0;
            this.Nombre1 = (!nom.Equals(null)) ? nom : "";
            this.Descripcion1 = (!des.Equals(null)) ? des : "";
        }

        public cTipoNovedad() { }

        //GETTERS & SETTERS

        public int IdTipoNovedad { get => idTipoNovedad; set => idTipoNovedad = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }

    }

}
