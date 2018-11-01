using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class cNovedad
    {
        private int idNovedad;
        private int idUsuario;
        private int idTipoNovedad;
        private int idMateria;
        private DateTime Fecha;
        private DateTime Hora;
        private string Descripcion;

        

        

        public cNovedad( int id, int iduser, int idtipo, int idmat, string des, DateTime fecha, DateTime hora ) {
            this.IdNovedad = ( !id.Equals(null) )? id : 0;
            this.IdUsuario = (!iduser.Equals(null)) ? iduser : 0;
            this.IdTipoNovedad = (!idtipo.Equals(null)) ? idtipo : 0;
            this.IdMateria = (!idmat.Equals(null)) ? idmat : 0;
            this.Descripcion1 = (!des.Equals(null)) ? des: "";
            this.Fecha1 = (!fecha.Equals(null)) ? fecha.Date : DateTime.Now;            

        }


        //GETTERS & SETTERS

        public int IdNovedad { get => idNovedad; set => idNovedad = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdTipoNovedad { get => idTipoNovedad; set => idTipoNovedad = value; }
        public int IdMateria { get => idMateria; set => idMateria = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public DateTime Hora1 { get => Hora; set => Hora = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
    }

}
