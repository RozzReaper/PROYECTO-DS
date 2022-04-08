using System.Data;
using System.Data.SqlClient;

//Libreria proveedora de datos, que describe una conexión de clases  
namespace Ejemplo2
{
    public class Casos //Creacion de clase dentro del entorno en Ejemplo2 
    {
        Conexion cn = new Conexion();

        public DataTable mostrarcasos() //DataTable representa la tabla de datos en memoria 
        {
            SqlDataAdapter da = new SqlDataAdapter("EXA_CASOS", cn.cadenaconexion());//Recuperacion de un origen de datos 
            da.SelectCommand.CommandType = CommandType.StoredProcedure;//Obtiene un procedimiento almacenado en sql para el registro de datos 

            DataTable dt = new DataTable(); //DataTable representa la tabla de datos en memoria 
            da.Fill(dt);
            return dt;
            //Valor en retorno de procedimiento en sql server 

        }

    }
}
