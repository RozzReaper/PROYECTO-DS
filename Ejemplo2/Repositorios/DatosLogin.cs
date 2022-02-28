using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo2.Cache;

namespace Ejemplo2
{
    //Inicio
    public class DatosLogin : RepositorioM
    {
        //Se añaden Campos de la tabla login
        private int Id_usuario;
        private int FK_Empleados;
        private string Tipo_empleado;
        private string n_usuario;
        private string contraseña;

        //Metodos de Acesso
        public int ID { get { return Id_usuario; } set { Id_usuario = value; } }

        public int ID_Empleado { get { return FK_Empleados; } set { FK_Empleados = value; } }

        public string TP_Empleado { get { return Tipo_empleado; } set { Tipo_empleado = value; } }

        public string Usuario { get { return n_usuario; } set { n_usuario = value; } }

        public string Contraseña { get { return contraseña; } set { contraseña = value; } }


        //Constructor
        public DatosLogin()
        {
            Id_usuario = ID;
            FK_Empleados = ID_Empleado;
            Tipo_empleado = TP_Empleado;
            n_usuario = Usuario;
            contraseña = Contraseña;
        }

        //Inicio de sesion 

        public bool login(string usuario, string contraseña)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = @"select * from Usuario where n_usuario = @usuario and CONVERT(nvarchar(max), DECRYPTBYPASSPHRASE('password', contraseña))= @contraseña";
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    SqlDataReader lector = comando.ExecuteReader();
                    //Si la tabla tiene datos
                    if(lector.HasRows)
                    {
                        //mientras se revisa con la base de datos a ver si existe las sentencias
                        while (lector.Read())
                        {
                            CacheS.Id_Usuario = lector.GetInt32(0);
                            CacheS.usuario=lector.GetString(3);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
    }
}
