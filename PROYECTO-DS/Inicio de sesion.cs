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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        //Instancia para la conexión con la Base de Datos
        Conexion cn = new Conexion();

        //Evento "Enter" del control "txtuser"
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO") 
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        //Evento "Leave" del control "txtuser"
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        //Evento "Enter" del control "txtpass"
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        //Evento "Leave" del control "txtpass"
        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        //Evento "Enter" del control "txtidentidad"
        private void txtidentidad_Enter(object sender, EventArgs e)
        {
            if (txtidentidad.Text == "ID EMPLEADO")
            {
                txtidentidad.Text = "";
                txtidentidad.ForeColor = Color.LightGray;
            }
        }

        //Evento "Leave" del control "txtidentidad"
        private void txtidentidad_Leave(object sender, EventArgs e)
        {
            if (txtidentidad.Text == "")
            {
                txtidentidad.Text = "ID EMPLEADO";
                txtidentidad.ForeColor = Color.DimGray;
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
                bool Valido = obj.login(txtuser.Text, txtpass.Text, cmb_temple.Text, Convert.ToInt32(txtidentidad.Text));

                if (Valido)
                {

                    //Validación a la hora de seleccionar el rol "Agente Universal"
                    if (cmb_temple.Text == "Agente Universal")
                    {
                        //Herencia del ID del Usuario que loguea
                        txtcopiar.Text = txtidentidad.Text;
                        Form6 forma = new Form6();
                        forma.txtimport.Text = txtidentidad.Text;
                        this.Hide();
                        forma.Show();
                        
                    }
                    //Validación a la hora de seleccionar el rol "Supervisor"
                    else if (cmb_temple.Text == "Supervisor")
                    {
                        //Instancia del formulario Menu_Supervisor, que al cumplirse la validación y los datos coincidir con algún usuario "Supervisor", será redirigido a este mismo.
                        this.Hide();
                        Menu_Supervisor frm = new Menu_Supervisor();
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
          cmb_temple.ForeColor = Color.DimGray;

        }

        private void cmb_temple_Leave(object sender, EventArgs e)
        {
          cmb_temple.ForeColor = Color.DimGray;
        }










    }
}
