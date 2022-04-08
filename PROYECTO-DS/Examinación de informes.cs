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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }

        //Evento Click del botón "Minimizar"
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Evento Click del control "btn_regresar"
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //Ocultamos el formulario actual para poder mostrar el formulario instanciado
            this.Hide();
            Menu_Supervisor menu_Supervisor = new Menu_Supervisor();
            menu_Supervisor.Show();
        }

        //Instancia de la clase Casos
        Casos casos = new Casos();

        //Al cargar el formulario se asigna un valor al DataTable existente que coincida con los datos del DataGridView
        private void Form5_Load(object sender, EventArgs e)
        {
            dgv_casos.DataSource = casos.mostrarcasos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_casos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //Botón que redirige a la visualización del Reporte de la Tabla
        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteInformes reporteInformes = new ReporteInformes();
            reporteInformes.Show();
        }
    }
}
