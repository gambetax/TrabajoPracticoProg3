using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class cMateria
    {
        private int idMateria;
        private int idUsuario;
        private string Nombre;
        private string Descripcion;


        public cMateria(){ }

        public cMateria(int id, int iduser, string nom, string des)
        {
            this.IdMateria = (!id.Equals(null)) ? id : 0; ;
            this.IdUsuario = (!iduser.Equals(null)) ? iduser : 0; ;
            this.Nombre1 = (!nom.Equals(null)) ? nom : "";
            this.Descripcion1 = (!des.Equals(null)) ? des : "";

        }


        //GETTERS & SETTERS



        public int IdMateria { get => idMateria; set => idMateria = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
    }
}
