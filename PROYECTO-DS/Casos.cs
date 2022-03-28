using System.Data;
using System.Data.SqlClient;

namespace Ejemplo2
{
    public class Casos
    {
        Conexion cn = new Conexion();

        public DataTable mostrarcasos()
        {
            SqlDataAdapter da = new SqlDataAdapter("EXA_CASOS", cn.cadenaconexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

    }
}
