using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Almacenamiento de datos momentaneos para el registro del cliente y empleado
namespace Ejemplo2.Cache
{
    public static class CacheS
    {
        //Cache Login Empleados Universal
        public static int Id_Usuario { get; set; }

        public static string usuario { get; set; }
        public static string t_empleado { get; set; }

        //Cache Login Cliente
        public static int Telefono { get; set; }
        public static string Nombres { get; set; }
        public static string Clave { get; set; }
    }
}
