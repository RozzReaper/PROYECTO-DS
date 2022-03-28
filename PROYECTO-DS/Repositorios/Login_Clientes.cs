using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo2.Cache;
using Ejemplo2.Message;


namespace Ejemplo2.Repositorios
{
    public class Login_Clientes:RepositorioM
    {
        //se añaden campos
        private int Id_cliente;
        private string Nombres;
        private string Email;
        private string Estado;
        private string Calle;
        private int Casa_num;
        private int Telefono;
        private string Clave;

        //metodos de acceso

        public int Id_c { get { return Id_cliente; } set { Id_cliente = value; } }
        public string Nom { get { return Nombres; } set { Nombres = value; } }
        public string Mail { get { return Email; } set { Email = value; } }
        public string Estd { get { return Estado; } set { Estado = value; } }
        public string Cal { get { return Calle; } set { Calle = value; } }
        public int C_num { get { return Casa_num; } set { Casa_num = value; } }
        public int Tel { get { return Telefono; } set { Telefono = value; } }
        public string Cla { get { return Clave; } set { Clave = value; } }

        //constructor
        public Login_Clientes()
        {
            Id_cliente = Id_c;
            Nombres = Nom;
            Email = Mail;
            Estado = Estd;
            Calle = Cal;
            Casa_num = C_num;
            Telefono = Tel;
            Clave = Cla;
        }

        //inicio de sesion
        public bool LoginC(int telefono)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = @"select * from Clientes where Teléfono = @telefono";
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    SqlDataReader lector = comando.ExecuteReader();
                    //Si la tabla tiene datos
                    if(lector.HasRows)
                    {
                        //mientras se revisa con la base de datos a ver si existe las sentencias
                        while (lector.Read())
                        {
                            //revisa cada elemento dependiendo de su numero de columna
                            CacheS.Nombres = lector.GetString(1);
                            CacheS.Telefono = lector.GetInt32(6);
                            CacheS.Clave = lector.GetString(7);
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
