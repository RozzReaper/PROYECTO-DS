using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo2.Cache;
using Ejemplo2.Repositorios;
using System.Data.SqlClient;
using System.Configuration;
using Ejemplo2.Message;

namespace Ejemplo2
{
    public partial class Datos_cliente : Form
    {
        public Datos_cliente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["database-conection"].ConnectionString);


        void Modificar()
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.Clientes SET dbo.Clientes.Nombres ='" +this.txtnombre.Text+ "',dbo.Clientes.Email='" + this.txtemail.Text + "',dbo.Clientes.Estado='" + this.cmbestado.Text + "',dbo.Clientes.Calle='" + this.txtcalle.Text + "',dbo.Clientes.Casa_num='" + this.txtcasanum.Text + "',dbo.Clientes.Teléfono='" + this.txttelefono.Text + "'WHERE dbo.Clientes.Id_cliente=" +Convert.ToInt32(this.txtid.Text + ""), cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch
            {
                MessageLogin login= new MessageLogin();
                login.Show();
            }


        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            LoginCliente loginCliente = new LoginCliente();
            loginCliente.txtsearch.Text = txtidfinal.Text;
            loginCliente.Show();
            this.Hide();
        }

        private void Datos_cliente_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtpendiente_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            if (txtcalle.Text == "" || cmbestado.Text == "" || txttelefono.Text == "")
            {

                MessageCreacion creacion= new MessageCreacion();
                creacion.Show();
            }
            else
            {
                if (txttelefono.Text.Trim().Length != 8)
                {
                    MessageBox.Show("El Teléfono debe tener 8 dígitos");

                }
                else
                {
                    if (!txttelefono.Text[0].ToString().Equals("2") && !txttelefono.Text[0].ToString().Equals("3") && !txttelefono.Text[0].ToString().Equals("8") && !txttelefono.Text[0].ToString().Equals("9"))
                    {
                        MessageBox.Show("Error, el télefono debe empezar con 9, 2 3 u 8");
                    }
                    else
                    {
                        Modificar();
                        MessageCaso caso = new MessageCaso();
                        caso.Show();
                    }

                }

            }
            
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            string telefono = ("SELECT*FROM Empleados('" + txttelefono.Text + "%')");

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            //Regex regex = new Regex("\\d[2-3,8-9]{1},\\d[0-9]{7}");
        }
    }
}
