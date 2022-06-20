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
        public string _Mensaje;
        //representa la conexion y con ello, se acceden a sus propiedades
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
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();//Se instancia el formulario que contiene el id del empleado
            frm6.txtimport.Text = txtidemple.Text;//Se iguala el contenido del text box que contiene el id al del siguiente formulatio
            frm6.Show();
            this.Hide();
        }

        private void txtins_Click(object sender, EventArgs e)
        {
            if ( txt_desc.Text == "" || txtidemple.Text =="" || txtins.Text == "" || cmb_cate.SelectedIndex == -1)//Validación, si los textos están vacíos lanzar un mensaje de error
            { 
                MessageCreacion messageCreacion = new MessageCreacion();
                messageCreacion.Show();
            }
            else
            {
                DateTime hoy = DateTime.Today;

                if (dtpfecha.Value.Date > hoy)
                {
                    MessageFechaMayor messageFechaMayor = new MessageFechaMayor();
                    messageFechaMayor.Show();
                }
                else if (dtpfecha.Value.AddYears(10) <= hoy)
                {

                    MessageFechaAntigua messageFechaAntigua = new MessageFechaAntigua();
                    messageFechaAntigua.Show();
                }
                else if (string.IsNullOrWhiteSpace(txt_desc.Text))
                {
                    MessageDescVacia messageDescVacia = new MessageDescVacia();
                    messageDescVacia.Show();
                }
                else
                {
                    string query = "INSERT INTO Informes (FK_Agentes, Categoría, Descripcion, Creación_fecha) VALUES (@id, @categoria, @descripcion, @fecha)";
                    cn.Open();//declarar un string para la insersión de datos
                    SqlCommand comando = new SqlCommand(query, cn);
                    comando.Parameters.AddWithValue("@id", txtidemple.Text);//igualar las variables del query con las variables declaradas en el void
                    comando.Parameters.AddWithValue("@categoria", cmb_cate.Text);
                    comando.Parameters.AddWithValue("@descripcion", txt_desc.Text);
                    comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpfecha.Text));
                    try
                    {
                        comando.ExecuteNonQuery();//ejeuta las intrucciones, como es un codigo propenso a dar errores, se pone en un try catch
                        MessageCaso messageCaso = new MessageCaso();
                        messageCaso.Show();
                        cn.Close();
                    }
                    catch
                    {
                        MessageInformacion messageInformacion = new MessageInformacion();
                        messageInformacion.Show();
                    }
                    cn.Close();//Se cierra la conexion
                }
            }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_desc.Clear();
            DateTime hoy = DateTime.Today;
            dtpfecha.Text = hoy.ToString();
            cmb_cate.SelectedIndex = -1;
        }

        private void dtpfecha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtpfecha_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void dtpfecha_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_desc.Text.Trim().Length >= 250)//Validación de limite de caracteres M
            {
                txt_desc.Clear();
                MessageDescLimite messageDescLimite = new MessageDescLimite();
                messageDescLimite.Show();
                e.Handled = true;
                return;
            }
        }
    }
}
