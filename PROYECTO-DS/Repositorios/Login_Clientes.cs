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
        private int id_cliente;
        private string nombres;
        private string apellidos;
        private string email;
        private string estado;
        private string calle;
        private int casa_num;
        private int telefono;
        private string clave;

        //metodos de acceso

        public int Id_c { get { return id_cliente; } set { id_cliente = value; } }
        public string Nom { get { return nombres; } set { nombres = value; } }
        public string Ape { get { return apellidos; } set { apellidos = value; } }
        public string Mail { get { return email; } set { email = value; } }
        public string Estd { get { return estado; } set { estado = value; } }
        public string Cal { get { return calle; } set { calle = value; } }
        public int C_num { get { return casa_num; } set { casa_num = value; } }
        public int Tel { get { return telefono; } set { telefono = value; } }
        public string Cla { get { return clave; } set { clave = value; } }

        //constructor
        public Login_Clientes()
        {
            id_cliente = Id_c;
            nombres = Nom;
            apellidos = Ape;
            email = Mail;
            estado = Estd;
            calle = Cal;
            casa_num = C_num;
            telefono = Tel;
            clave = Cla;
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
                    comando.CommandText = @"select * from clientes where telefono = @telefono";
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
                            CacheS.telefono = lector.GetInt32(7);
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
