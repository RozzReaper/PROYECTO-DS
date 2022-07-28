using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ejemplo2.Cache;
using Ejemplo2.Message;
using Ejemplo2.Repositorios;
using System.Configuration;
using System.Drawing.Drawing2D;
namespace Ejemplo2
{
    public partial class frm_inicio_sesion : Form
    {

        public frm_inicio_sesion()
        {
            InitializeComponent();
        }


        //Instancia para la conexión con la Base de Datos
        Conexion cn = new Conexion();

        //Evento "Enter" del control "txtuser"
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "USUARIO") 
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.LightGray;
            }
        }

        //Evento "Leave" del control "txtuser"
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "USUARIO";
                txt_usuario.ForeColor = Color.DimGray;
            }
        }

        //Evento "Enter" del control "txtpass"
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "CONTRASEÑA")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.LightGray;
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        //Evento "Leave" del control "txtpass"
        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
            {
                txt_contraseña.Text = "CONTRASEÑA";
                txt_contraseña.ForeColor = Color.DimGray;
                txt_contraseña.UseSystemPasswordChar = false;
            }
        }

        //Evento "Enter" del control "txtidentidad"
        private void txtidentidad_Enter(object sender, EventArgs e)
        {
            if (txt_id_empleado.Text == "ID EMPLEADO")
            {
                txt_id_empleado.Text = "";
                txt_id_empleado.ForeColor = Color.LightGray;
            }
        }

        //Evento "Leave" del control "txtidentidad"
        private void txtidentidad_Leave(object sender, EventArgs e)
        {
            if (txt_id_empleado.Text == "")
            {
                txt_id_empleado.Text = "ID EMPLEADO";
                txt_id_empleado.ForeColor = Color.DimGray;
            }
        }

        //Evento "ClicK" del control "btnMinimizar"
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Evento "Click" del control "btnRegresar"
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["database-conection"].ConnectionString);

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Herencia al evento
            try
            {
                //Datos info
                //Instancia de la clase DatosLogin para loguearse.
                DatosLogin obj = new DatosLogin();

                //Declaración booleana para verificar si los datos ingresados coinciden con datos existentes en la Base de Datos.
                bool Valido = obj.login(txt_usuario.Text, txt_contraseña.Text, cmb_tipo_empleado.Text, Convert.ToInt32(txt_id_empleado.Text));

                if (Valido)
                {

                    //Validación a la hora de seleccionar el rol "Agente Universal"
                    if (cmb_tipo_empleado.Text == "Agente Universal")
                    {
                        //Herencia del ID del Usuario que loguea
                        txtcopiar.Text = txt_id_empleado.Text;
                        menu_agente_universal forma = new menu_agente_universal();
                        forma.txt_import.Text = txt_id_empleado.Text;
                        this.Hide();
                        forma.Show();
                        
                    }
                    //Validación a la hora de seleccionar el rol "Supervisor"
                    else if (cmb_tipo_empleado.Text == "Supervisor")
                    {
                        //Instancia del formulario Menu_Supervisor, que al cumplirse la validación y los datos coincidir con algún usuario "Supervisor", será redirigido a este mismo.
                        this.Hide();
                        menu_supervisor frm = new menu_supervisor();
                        frm.Show();
                    }
                }
                else
                {
                    //Al fallar la condición principal del if, se hace llamado del MessageBox "Message Login" al instanciarse, y este mismo mostrará el mensaje de error correspondiente
                    MessageLogin messageLogin = new MessageLogin();
                    messageLogin.Show();
                }
            }
            catch
            {
                //Si catch atrapa un error, se hace llamado del MessageBox "Message Login" al instanciarse, y este mismo mostrará el mensaje de error correspondiente
                MessageLogin messageLogin = new MessageLogin();
                messageLogin.Show();
            }
            
            conexion.Close();
        }

        private void cmb_temple_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_temple_Enter(object sender, EventArgs e)
        {
          cmb_tipo_empleado.ForeColor = Color.DimGray;

        }

        private void cmb_temple_Leave(object sender, EventArgs e)
        {
          cmb_tipo_empleado.ForeColor = Color.DimGray;
        }










    }
}
