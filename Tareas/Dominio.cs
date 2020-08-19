using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    public class Dominio: Conexion
    {

        private int iduser;
        private string nombre;
        private string apellido;
        private string correo;
        private string contrasena;

        public Dominio( string nombre, string apellido, string correo, string contrasena)
        {
            this.iduser = iduser;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.contrasena = contrasena;
        }

        public Dominio()
        {

        }

        public string Insertarusuario()
        {
            Conexion con = new Conexion();
            con.Insertarusuario(nombre,apellido,correo,contrasena );
            return "Registrado exitosamente";
        }
    }
}
