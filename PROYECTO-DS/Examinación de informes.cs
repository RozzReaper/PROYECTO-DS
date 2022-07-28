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
    public partial class frm_examinacion_informe : Form
    {
        public frm_examinacion_informe()
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
            menu_supervisor menu_Supervisor = new menu_supervisor();
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


            //datos.txt_id.Text = dgv_busqueda_cliente.CurrentRow.Cells[0].Value.ToString();
            
            Report reporte = new Report();

            
            for (int i = 0; i < dgv_casos.Rows.Count; i++)
            {
                Reporteandro report = new Reporteandro();
                report.nombres = (string)this.dgv_casos.Rows[i].Cells[0].Value;
                report.apellidos = (string)this.dgv_casos.Rows[i].Cells[1].Value;
                report.id_empleado = (int)this.dgv_casos.Rows[i].Cells[2].Value;
                report.id_cliente = (int)this.dgv_casos.Rows[i].Cells[3].Value;
                report.categoria = (string)this.dgv_casos.Rows[i].Cells[4].Value;
                report.descripcion = (string)this.dgv_casos.Rows[i].Cells[5].Value;
                report.creacion_fecha = (DateTime)this.dgv_casos.Rows[i].Cells[6].Value;
                reporte.report.Add(report);
            }
           
            reporte.ShowDialog();

        }
    }
}
