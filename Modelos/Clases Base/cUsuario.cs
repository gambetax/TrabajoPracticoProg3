using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{    
    public class cUsuario
    {
        private int idUsuario;
        private int idTipoUsuario;
        private string Nombre;
        private string Apellido;
        private string Dni;
        private string Usuario;
        private string Pass;
        private string Email;

        public int GetSetIdUsuario { get => idUsuario; set => idUsuario = value; }
        public int GetSetIdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public string GetSetNombre { get => Nombre; set => Nombre = value; }
        public string GetSetApellido { get => Apellido; set => Apellido = value; }
        public string GetSetDni { get => Dni; set => Dni = value; }
        public string GetSetUsuario { get => Usuario; set => Usuario = value; }
        public string GetSetPass { get => Pass; set => Pass = value; }
        public string GetSetEmail { get => Email; set => Email = value; }

        public cUsuario()
        {

        }

        //GETTERS & SETTERS

        public cUsuario(int id, int tipo, string nom, string ape, string dni, string user, string pass, string email ) {
            this.GetSetIdUsuario = id;
            this.GetSetIdTipoUsuario = tipo;
            this.GetSetNombre = nom;    
            this.GetSetApellido = ape;
            this.GetSetDni = dni;
            this.GetSetUsuario = user;
            this.GetSetPass = pass;
            this.GetSetEmail = email;           
        }






    }
}
