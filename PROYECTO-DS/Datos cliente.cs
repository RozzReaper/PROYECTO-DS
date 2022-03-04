using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Datos_cliente : Form
    {
        public Datos_cliente()
        {
            InitializeComponent();
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
    }
}
