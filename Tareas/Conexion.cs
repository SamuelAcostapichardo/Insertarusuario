using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Tareas
{
    public class Conexion
    {

        private readonly string Connexion = ConfigurationManager.ConnectionStrings["Tareas.Properties.Settings.Setting"].ConnectionString;


        public SqlConnection GetConnection()
        {
            return new SqlConnection(Connexion);
        }


        public void Insertarusuario(string nombre, string Apellido, string correo,string contrasena)
        {
            using (var conection = GetConnection())
            {
                using (var sqlcmd = new SqlCommand())
                {
                    conection.Open();
                    sqlcmd.Connection = conection;
                    sqlcmd.CommandText = "insert into Usuario values (@nombre,@Apellidos,@Correo,@Contrasena)";
                   // sqlcmd.Parameters.AddWithValue("@idusuario",id);
                    sqlcmd.Parameters.AddWithValue("@nombre",nombre);
                    sqlcmd.Parameters.AddWithValue("@Apellidos",Apellido);
                    sqlcmd.Parameters.AddWithValue("@Correo",correo);
                    sqlcmd.Parameters.AddWithValue("@Contrasena",contrasena);
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.ExecuteNonQuery();
                }
            }
        }

         

    }
}
