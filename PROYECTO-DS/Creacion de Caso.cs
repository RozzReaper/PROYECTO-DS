using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Ejemplo2.Message;

namespace Ejemplo2
{
    public partial class Form7 : Form
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["database-conection"].ConnectionString);
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void txtins_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Informes (FK_Empleados, Categoría, Descripcion, Creación_fecha) VALUES (@id, @categoria, @descripcion, @fecha)";
            cn.Open();
            SqlCommand comando=new SqlCommand(query, cn);
            comando.Parameters.AddWithValue("@id", txtidemple.Text);
            comando.Parameters.AddWithValue("@categoria", cmb_cate.Text);
            comando.Parameters.AddWithValue("@descripcion", txt_desc.Text);
            comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpfecha.Text));
            comando.ExecuteNonQuery();
            MessageCaso messageCaso = new MessageCaso();
            messageCaso.Show(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtfecha_Enter(object sender, EventArgs e)
        {

        }

        private void txtfecha_Leave(object sender, EventArgs e)
        {

        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha=dtpfecha.Value;
        }

        private void txtidemple_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
