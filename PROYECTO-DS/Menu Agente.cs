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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
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
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnAgente_Click(object sender, EventArgs e)
        {
            
        }

        //Evento click del boton btnSupervisor_Click
        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            Form7 traslado = new Form7();
            traslado.txtidemple.Text = txtimport.Text; //Se iguala el contenido del text box que contiene el id al del siguiente formulario
            this.Hide();
            traslado.Show();
        }
        //Evento click del boton btnlgncliente_Click
        private void btnlgncliente_Click(object sender, EventArgs e)
        {
            LoginCliente loginCliente = new LoginCliente();
            loginCliente.txtsearch.Text = txtimport.Text; //Text box para busqueda de cliente
            this.Hide();
            loginCliente.Show();
        }

        private void btn_helper_Click(object sender, EventArgs e)
        {
            Process.Start("https://download1487.mediafire.com/enblzttx104g/9wzs5rgemh5yu73/Manual_Usuario.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TW tW = new TW();
            tW.Show();
        }
    }
}
