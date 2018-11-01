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


        public cUsuario(int id, int tipo, string nom, string ape, string dni, string user, string pass, string email ) {
            this.IdUsuario = id;
            this.IdTipoUsuario = tipo;
            this.Nombre1 = nom;
            this.Apellido1 = ape;
            this.Dni1 = dni;
            this.Usuario1 = user;
            this.Pass1 = pass;
            this.Email1 = email;           
        }


        public cUsuario() {

        }

        //GETTERS & SETTERS

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Dni1 { get => Dni; set => Dni = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Pass1 { get => Pass; set => Pass = value; }
        public string Email1 { get => Email; set => Email = value; }


    }
}
