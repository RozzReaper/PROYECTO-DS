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
    public partial class frm_creacion_caso : Form
    {
        //representa la conexion y con ello, se acceden a sus propiedades
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["database-conection"].ConnectionString);
        public frm_creacion_caso()
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
            frm6.txtimport.Text = txt_id_empleado.Text;//Se iguala el contenido del text box que contiene el id al del siguiente formulatio
            frm6.Show();
            this.Hide();
        }

        private void txtins_Click(object sender, EventArgs e)
        {

            if ( txt_descripcion.Text == "" || txt_id_empleado.Text =="" || btn_insertar.Text == "" || cmb_categoria.Text =="" || txt_id_cliente.Text == "")//Validación, si los textos están vacíos lanzar un mensaje de error
            { 
                MessageCreacion messageCreacion = new MessageCreacion();
                messageCreacion.Show();
            }
            else
            {
                DateTime hoy = DateTime.Today;

                if (dtp_fecha.Value.Date > hoy)
                {
                    MessageFechaMayor messageFechaMayor = new MessageFechaMayor();
                    messageFechaMayor.Show();
                }
                else if (dtp_fecha.Value.AddYears(10) <= hoy)
                {

                    MessageFechaAntigua messageFechaAntigua = new MessageFechaAntigua();
                    messageFechaAntigua.Show();
                }
                else if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
                {
                    MessageDescVacia messageDescVacia = new MessageDescVacia();
                    messageDescVacia.Show();
                }
                else
                {
                    string query = "INSERT INTO informes (fk_clientes, fk_empleados, categoria, descripcion, creacion_fecha) VALUES (@id_cli, @id, @categoria, @descripcion, @fecha)";
                    cn.Open();//declarar un string para la insersión de datos
                    SqlCommand comando = new SqlCommand(query, cn);
                    comando.Parameters.AddWithValue("@id_cli", txt_id_cliente.Text);
                    comando.Parameters.AddWithValue("@id", txt_id_empleado.Text);//igualar las variables del query con las variables declaradas en el void
                    comando.Parameters.AddWithValue("@categoria", cmb_categoria.Text);
                    comando.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
                    comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtp_fecha.Text));
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
            txt_descripcion.Clear();
            DateTime hoy = DateTime.Today;
            dtp_fecha.Text = hoy.ToString();
            cmb_categoria.SelectedIndex = -1;
        }

        private void txt_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_descripcion.Text.Trim().Length >= 250)//Validación de limite de caracteres M
            {

                //validacion para limite de caracteres 
                MessageDescLimite messageDescLimite = new MessageDescLimite();
                messageDescLimite.Show();
                txt_descripcion.Clear();    
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
