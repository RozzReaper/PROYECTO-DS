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
                SqlCommand cmd = new SqlCommand("UPDATE dbo.Clientes SET dbo.Clientes.Nombres ='" +this.txtnombre.Text+ "',dbo.Clientes.Email='" + this.txtemail.Text + "',dbo.Clientes.Estado='" + this.txtestado.Text + "',dbo.Clientes.Calle='" + this.txtcalle.Text + "',dbo.Clientes.Casa_num='" + this.txtcasanum.Text + "',dbo.Clientes.Teléfono='" + this.txttelefono.Text + "'WHERE dbo.Clientes.Id_cliente=" +Convert.ToInt32(this.txtid.Text + ""), cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modificado correctamente");
                cn.Close();
            }
            catch
            {
                MessageBox.Show("La cagó mijo");
            }


        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginCliente loginCliente = new LoginCliente();
            loginCliente.Show();
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
            Modificar();
        }
    }
}
