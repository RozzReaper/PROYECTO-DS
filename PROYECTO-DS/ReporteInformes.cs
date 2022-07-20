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
    public partial class ReporteInformes : Form
    {
        public ReporteInformes()
        {
            InitializeComponent();
        }

        private void ReporteInformes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'informesDATASET.Informes' table. You can move, or remove it, as needed.
            this.informesTableAdapter.Fill(this.informesDATASET.Informes);
            // TODO: This line of code loads data into the 'informesDATASET.Informes' table. You can move, or remove it, as needed.
            this.informesTableAdapter.Fill(this.informesDATASET.Informes);

            this.reportViewer1.RefreshReport();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
