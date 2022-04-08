using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Ejemplo2
{
    public class Conexion
    {
        //Utilizamos la biblioteca System.data.sqlclient para utilizar una forma de conectar visual studio a sql
        public SqlConnection cadenaconexion()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["database-conection"].ConnectionString);

            if(cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }
    }
}
