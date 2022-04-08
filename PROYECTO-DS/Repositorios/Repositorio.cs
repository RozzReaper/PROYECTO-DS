using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//Cadena de conexión
namespace Ejemplo2
{
    public abstract class Repositorio
    {
        //Utilizamos la biblioteca System.data.sqlclient para utilizar una forma de conectar visual studio a sql
        private readonly string CadenaConexion;

        public Repositorio()
        {
            CadenaConexion = "server=server-andromeda.database.windows.net;Initial Catalog=Andromeda-database;Persist Security Info=True;User ID=Administrador;Password=@ndr0med@";
        }

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }

    }
}
