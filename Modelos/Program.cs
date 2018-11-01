using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Program
    {
        static void Main(string[] args)
        {

            //obtener tipos de usuario ----------------------
            
                cTiposUsuario tipos = new cTiposUsuario();
                cTipoUsuario t = tipos.getId(2); //retorna null si no encontro nada
                if (!t.Equals(null)) {
                    Console.WriteLine("Tipo encontrado: {0} - {1} ", t.idTipoUsuario, t.Nombre);
                    t = null; //libero
                }

                //ahora recupero todos los tipos de usuario
                ArrayList todos;
                todos = tipos.getAll();
                Console.WriteLine("\n\nAhora listamos todos los tipos de usuario:");
                foreach (cTipoUsuario ct in todos) {
                    Console.WriteLine("{0} - {1} - ({2}) ", ct.idTipoUsuario, ct.Nombre, ct.Descripcion );
                }
                tipos = null;
            
            //---------------------------------------------

            //obtener tipos de Novedad ----------------------
            /*
                cTiposNovedad tipos = new cTiposNovedad();
                cTipoNovedad t = tipos.getId(2); //retorna null si no encontro nada
                if (!t.Equals(null)) {
                    Console.WriteLine("{0} - {1} ", t.idTipoNovedad, t.Nombre);
                    t = null; //libero
                }

                //ahora recupero todos los tipos de usuario
                ArrayList todos;
                todos = tipos.getAll();
                Console.WriteLine("\n\nAhora listamos todos los tipos de usuario:");
                foreach (cTipoNovedad ct in todos) {
                    Console.WriteLine("{0} - {1} - ({2}) ", ct.idTipoNovedad, ct.Nombre, ct.Descripcion );
                }
                tipos = null;
            */
            //---------------------------------------------



            //---------------------------------------------
            //ejemplos para usuarios
            /*
                cUsuarios user = new cUsuarios();

                //ejemplo para obtener todos los usuarios
                ArrayList A = user.getAll();
                foreach (cUsuario u in A) {
                    Console.WriteLine(  "{0} [Tipo:{1}] {2} {3}" , u.idUsuario, u.idTipoUsuario, u.Nombre, u.Apellido );
                }
                
                //obtener usuario por id
                cUsuario us = user.getId(2);
                Console.WriteLine( "\n\nUsuario 2: {0} {1}" , us.Nombre , us.Apellido);
                
                //add (primer param id se carga con cualquier numero, no es tenido en cuenta)
                if (user.edit(new cUsuario(0, 2, "mabel", "sharpe", "65432", "sharpm", "1234", "sharpe@utn.gob.ar")))
                    Console.WriteLine("Agregado!!!");

                //edit
                 if (user.edit(new cUsuario( 4, 2, "mabel", "sharpe", "1111", "msharpe", "11111", "sharpe@utn.gob.ar")))
                    Console.WriteLine("Editado!!!");
                //eliminar            
                if (user.del(4))
                    Console.WriteLine("Eliminado!");
                else
                    Console.WriteLine("No Eliminado!");
           */
            /// FIN usuarios ----------------------

            //---------------------------------------------
            //ejemplos para Materias
            /*
                cMaterias mat = new cMaterias();

                //ejemplo para obtener todos las materias
                ArrayList A = mat.getAll();
                Console.WriteLine("Listado de Materias:\n\n");
                foreach (cMateria u in A) {
                    Console.WriteLine(  "{0} [Docente(usuario):{1}] {2} {3}" , u.idMateria, u.idUsuario, u.Nombre, u.Descripcion );
                }

                //obtener materia por id
                Console.WriteLine("\n\nMateria a partir de id:");
                cMateria m = mat.getId(2);
                Console.WriteLine( "\n\nMateria 2: {0}, Docente: {1}" , m.Nombre, m.idUsuario);

                //add (primer param id se carga con cualquier numero, no es tenido en cuenta)
                // if (mat.add(new cMateria( 0, 2, "Laboratorio IV" , "html, javascript y php" )))
                //    Console.WriteLine("Materia agregada!!!");

            */
            /// FIN materias ----------------------

            Console.Read();
        }
    }
}
