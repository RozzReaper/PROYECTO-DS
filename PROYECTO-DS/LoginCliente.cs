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

namespace Ejemplo2
{
    public partial class LoginCliente : Form
    {
        public LoginCliente()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        private void LoginCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm = new Form6();
            frm.Show();
        }

        private void btnLoginClientes_Click(object sender, EventArgs e)
        {
            //Herencia al evento
            Login_Clientes obj = new Login_Clientes();
            bool Valido = obj.LoginC(txtname.Text, Convert.ToInt32(txtcel.Text), txt_clave.Text);


            if (Valido)
            {
                this.Hide();
                Datos_cliente data = new Datos_cliente();
                data.Show();
            }
            else
            {
                MessageBox.Show("Nombre/Teléfono y/o Clave incorrectos");
            }
        }
    }
}
