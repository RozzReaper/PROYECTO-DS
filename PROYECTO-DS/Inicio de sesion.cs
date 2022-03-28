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

namespace Ejemplo2
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        Conexion cn = new Conexion();


        public void login(string usuario, string contraseña) 
        {

                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO") 
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

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
                //Datos info;
                //info.id = txtidentidad.Text;
                DatosLogin obj = new DatosLogin();

                bool Valido = obj.login(txtuser.Text, txtpass.Text, txt_temple.Text, Convert.ToInt32(txtidentidad.Text));

                if (Valido)
                {


                    if (txt_temple.Text == "agente universal" || txt_temple.Text == "Agente Universal" || txt_temple.Text == "Agente universal")
                    {
                        txtcopiar.Text = txtidentidad.Text;
                        Form6 forma = new Form6();
                        forma.txtimport.Text = txtidentidad.Text;
                        this.Hide();
                        forma.Show();
                        

                    }
                    else
                        if (txt_temple.Text == "Supervisor" || txt_temple.Text == "supervisor")
                    {


                        this.Hide();
                        Menu_Supervisor frm = new Menu_Supervisor();
                        frm.Show();
                    }
                }
                else
                {
                    MessageLogin messageLogin = new MessageLogin();
                    messageLogin.Show();
                }
            }
            catch
            {
                MessageLogin messageLogin = new MessageLogin();
                messageLogin.Show();
            }
            
            
            conexion.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_temple_Enter(object sender, EventArgs e)
        {
            if (txt_temple.Text == "TIPO DE EMPLEADO")
            {
                txt_temple.Text = "";
                txt_temple.ForeColor = Color.LightGray;
            }
        }

        private void txt_temple_Leave(object sender, EventArgs e)
        {
            if (txt_temple.Text == "")
            {
                txt_temple.Text = "TIPO DE EMPLEADO";
                txt_temple.ForeColor = Color.DimGray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
