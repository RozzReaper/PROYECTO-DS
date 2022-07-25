using System;
using System.Collections.Generic;
using System.Data;
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
        private int id_usuario;
        private int fk_empleados;
        private string tipo_empleado;
        private string n_usuario;
        private string contraseña;

        //Metodos de Acesso
        public int ID { get { return id_usuario; } set { id_usuario = value; } }

        public int ID_Empleado { get { return fk_empleados; } set { fk_empleados = value; } }

        public string TP_Empleado { get { return tipo_empleado; } set { tipo_empleado = value; } }

        public string Usuario { get { return n_usuario; } set { n_usuario = value; } }

        public string Contraseña { get { return contraseña; } set { contraseña = value; } }

        //Constructor
        public DatosLogin()
        {
            id_usuario = ID;
            fk_empleados = ID_Empleado;
            tipo_empleado = TP_Empleado;
            n_usuario = Usuario;
            contraseña = Contraseña;
        }

        //Inicio de sesion 

        Form7 foru=new Form7();

        public bool login(string usuario, string contraseña, string t_empleado, int id)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    //Segun el codigo de encripación, que el inicio también dependa de si el empleado es Agente o Supervisor
                    comando.Connection = conexion;
                    comando.CommandText = @"select * from usuario where fk_empleados = @id and n_usuario = @usuario and tipo_empleado = @t_empleado and CONVERT(nvarchar(max), DECRYPTBYPASSPHRASE('password', contraseña))= @contraseña";
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@t_empleado", t_empleado);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    SqlDataReader lector = comando.ExecuteReader();
                    //Si la tabla tiene datos
                    if(lector.HasRows)
                    {
                        //mientras se revisa con la base de datos a ver si existe las sentencias
                        while (lector.Read())
                        {
                            //revisa cada elemento dependiendo de su numero de columna
                            CacheS.Id_Usuario = lector.GetInt32(1);
                            CacheS.usuario=lector.GetString(3);
                            CacheS.t_empleado=lector.GetString(2);
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
