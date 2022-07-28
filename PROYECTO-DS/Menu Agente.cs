using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MatthiWare.SmsAndCallClient;

namespace Ejemplo2
{
    public partial class menu_agente_universal : Form
    {
        public menu_agente_universal()
        {
            InitializeComponent();
        }


        //Evento click del boton btnMinimizar_Click
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Evento click del boton btnRegresar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_inicio_sesion form2 = new frm_inicio_sesion();
            form2.Show();
        }

        private void btnAgente_Click(object sender, EventArgs e)
        {
            
        }

        //Evento click del boton btnSupervisor_Click
        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            frm_creacion_caso traslado = new frm_creacion_caso();
            traslado.txt_id_empleado.Text = txt_import.Text; //Se iguala el contenido del text box que contiene el id al del siguiente formulario
            this.Hide();
            traslado.Show();
        }
        //Evento click del boton btnlgncliente_Click
        private void btnlgncliente_Click(object sender, EventArgs e)
        {
            frm_login_cliente loginCliente = new frm_login_cliente();
            loginCliente.txtsearch.Text = txt_import.Text; //Text box para busqueda de cliente
            this.Hide();
            loginCliente.Show();
        }

        private void btn_helper_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\AndromedaHelper.chm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tw_frm tW1 = new tw_frm();
            tW1.txttwilio.Text = txt_import.Text;
            this.Hide();
            tW1.Show();
        }
    }
}
