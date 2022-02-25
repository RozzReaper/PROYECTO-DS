using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejemplo2
{
    public abstract class RepositorioM:Repositorio
    {
        protected List<SqlParameter> Parametros;

        //Ejecutar Procedimientos de Querys
        protected void ExecuteNonQuery(String transactSql)
        {
            using (var Conexion = ObtenerConexion())
            {
                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = transactSql;
                    Comando.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter item in Parametros)
                    {
                        Comando.Parameters.Add(item);
                    }
                    Comando.ExecuteNonQuery(); 
                    Parametros.Clear();
                }
                    
            }
        }

        //Mostrar Tablas
        protected DataTable ExecuteReader (String transactSql)
        {
            using (var Conexion = ObtenerConexion())
            {
                Conexion.Open();
                using (var Comando = new  SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = transactSql;
                    Comando.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter item in Parametros)
                    {
                        Comando.Parameters.Add(item);
                    }

                    SqlDataReader Lector = Comando.ExecuteReader();
                    using (var Tabla = new DataTable())
                    {
                        Tabla.Load(Lector);
                        Lector.Dispose();
                        return Tabla;
                    }
                }
            }

        }
    }
}

