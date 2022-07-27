using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Evento click del boton btnMinimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Evento click del boton btnAgente
        private void btnAgente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_inicio_sesion a = new frm_inicio_sesion();
            a.Show();
        }

        private void btn_helper_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\AndromedaHelper.chm");
        }
    }
}
