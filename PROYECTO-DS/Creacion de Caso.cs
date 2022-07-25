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
        //representa la conexion y con ello, se acceden a sus propiedades
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["database-conection"].ConnectionString);
        public Form7()
        {
            InitializeComponent(); 
            
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

            if ( txt_desc.Text == "" || txtidemple.Text =="" || txtins.Text == "" || cmb_cate.Text =="" || txtidcli.Text == "")//Validación, si los textos están vacíos lanzar un mensaje de error
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
                    string query = "INSERT INTO informes (fk_clientes, fk_empleados, categoria, descripcion, creacion_fecha) VALUES (@id_cli, @id, @categoria, @descripcion, @fecha)";
                    cn.Open();//declarar un string para la insersión de datos
                    SqlCommand comando = new SqlCommand(query, cn);
                    comando.Parameters.AddWithValue("@id_cli", txtidcli.Text);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_desc.Clear();
            DateTime hoy = DateTime.Today;
            dtpfecha.Text = hoy.ToString();
            cmb_cate.SelectedIndex = -1;
        }

        private void txt_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_desc.Text.Trim().Length >= 250)//Validación de limite de caracteres M
            {

                //validacion para limite de caracteres 
                MessageDescLimite messageDescLimite = new MessageDescLimite();
                messageDescLimite.Show();
                txt_desc.Clear();    
                e.Handled = true;
                return;

            }
        }

        private void txtidcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = char.IsWhiteSpace(e.KeyChar))
            {
                MessageDescVacia messageDescVacia = new MessageDescVacia();
                messageDescVacia.Show();// mensaje de error para espacios
            }
            else if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//En caso de no pertenecer a los numeros del 0-9, mandar un mensaje de error
            {
                MessageNume messageNume = new MessageNume();//En caso que se introduzca un valor que no sea tipo numérico, mandar un mensaje de error
                messageNume.Show();
                e.Handled = true;
                return;

            }
        }
    }
}
