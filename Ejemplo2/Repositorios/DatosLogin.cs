using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    //Inicio
    class DatosLogin:RepositorioM
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

    }
}
