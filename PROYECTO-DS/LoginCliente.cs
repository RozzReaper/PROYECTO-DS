using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo2.Cache;
using Ejemplo2.Repositorios;
using System.Data.SqlClient;
using System.Configuration;
using Ejemplo2.Message;
using System.Diagnostics;

namespace Ejemplo2
{
    public partial class LoginCliente : Form
    {
        public LoginCliente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["database-conection"].ConnectionString);//Se declara la conexion

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Se usa una propiedad para minimizar el formulario
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.txtimport.Text = txtsearch.Text;//Se iguala el contenido del text box que contiene el id al del siguiente formulatio
            frm.Show();
            this.Hide();//Mediante una orpiedad, se oculta el formulario presentado, para mostrar el siguiente
        }

        private void btnLoginClientes_Click(object sender, EventArgs e)
        {

            //Herencia al evento
            cn.Open();
            Login_Clientes obj = new Login_Clientes();
            try
            {
                bool Valido = obj.LoginC(Convert.ToInt32(txtcel.Text)); //Se extrapola el valor booleano y se iguala el parametro definido al text box

                if (Valido)
                {
                    Datos_cliente datos = new Datos_cliente();
                    datos.txtidfinal.Text = txtsearch.Text;                    
                    this.Hide();
                    datos.Show();

                    try
                    {
                        if (dgvsiu.Rows.Count == 0)//Si los datos son nulos, mostrar un error el cual dice que no existe dicho cliente
                        {
                            MessageNC messageNC = new MessageNC();
                            messageNC.Show();
                        }
                        else
                        {

                            datos.txtid.Text = dgvsiu.CurrentRow.Cells[0].Value.ToString();//Se envian los datos de el dgv hacia los textbox
                            datos.txtnombre.Text = dgvsiu.CurrentRow.Cells[1].Value.ToString();//Del siguiente formulario
                            datos.txtemail.Text = dgvsiu.CurrentRow.Cells[2].Value.ToString();
                            datos.cmbestado.Text = dgvsiu.CurrentRow.Cells[3].Value.ToString();
                            datos.txtcalle.Text = dgvsiu.CurrentRow.Cells[4].Value.ToString();
                            datos.txtcasanum.Text = dgvsiu.CurrentRow.Cells[5].Value.ToString();
                            datos.txttelefono.Text = dgvsiu.CurrentRow.Cells[6].Value.ToString();
                            datos.txtimpuesto.Text = dgvsiu.CurrentRow.Cells[7].Value.ToString();
                            datos.txtcosto.Text = dgvsiu.CurrentRow.Cells[8].Value.ToString();
                            datos.txtdescuento.Text = dgvsiu.CurrentRow.Cells[9].Value.ToString();
                            datos.txtsubtotal.Text = dgvsiu.CurrentRow.Cells[10].Value.ToString();
                            datos.txtpendiente.Text = dgvsiu.CurrentRow.Cells[11].Value.ToString();
                            datos.txttotal.Text = dgvsiu.CurrentRow.Cells[12].Value.ToString();
                            datos.txtfechainicio.Text = dgvsiu.CurrentRow.Cells[13].Value.ToString();
                            datos.txtvelocidad.Text = dgvsiu.CurrentRow.Cells[14].Value.ToString();
                            datos.txt_tipofibra.Text = dgvsiu.CurrentRow.Cells[15].Value.ToString();
                            datos.txtdiapago.Text = dgvsiu.CurrentRow.Cells[16].Value.ToString();
                            datos.txt_planestado.Text = dgvsiu.CurrentRow.Cells[17].Value.ToString();
                        }

                    }
                    catch
                    {
                        MessageBusque messageBusque = new MessageBusque();
                        messageBusque.Show();
                    }

                }
                else
                {
                    //Resultado si el booleano no funcionaba, lanzando un mensaje de error
                    MessageIncorrecto messageIncorrecto = new MessageIncorrecto();
                    messageIncorrecto.Show();
                }
            }
            catch
            {
                MessageValid messageValid = new MessageValid();
                messageValid.Show();
            }
            
   

            cn.Close();//Se cierra la conexion
        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {

            if(txtcel.Text=="")//Primera validación si el campo telefono está vacío
            {
                MessageCliente messageLogin = new MessageCliente();
                messageLogin.Show();
            }
            else
            {
                try//Se declara un string el cual contendrá la sentencia para buscar a los clientes
                {
                    string query = "SELECT dbo.Clientes.Id_cliente, dbo.Clientes.Nombres, dbo.Clientes.Email, dbo.Clientes.Estado, dbo.Clientes.Calle, dbo.Clientes.Casa_num, dbo.Clientes.Teléfono, dbo.Historial_crediticio.Impuesto, dbo.Historial_crediticio.Costo_plan, dbo.Historial_crediticio.Descuento, dbo.Historial_crediticio.Subtotal, dbo.Historial_crediticio.Pendiente, dbo.Historial_crediticio.Total, dbo.Planes.Fecha_inicio, dbo.Planes.Velocidad, dbo.Planes.Tipo_fibra,dbo.Planes.Día_pago, dbo.Planes.Plan_estado FROM dbo.Clientes INNER JOIN dbo.Historial_crediticio ON dbo.Clientes.Id_cliente = dbo.Historial_crediticio.FK_Clientes INNER JOIN dbo.Planes ON dbo.Clientes.Id_cliente = dbo.Planes.FK_Clientes where Teléfono = '" + txtcel.Text +  "'";
                    SqlCommand comando = new SqlCommand(query, cn);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();//Haciendo uso de un data adapter, se lleva a cabo la consulta
                    data.Fill(tabla);//Llenado de datos pata luego igualarlo al dgv existente
                    dgvsiu.DataSource = tabla;

                    if(dgvsiu.Rows.Count ==0)//Si el dgv está vácío, tirar un mensaje de error
                    {
                        MessageNC messageNC = new MessageNC();
                        messageNC.Show();
                    }
                }
                catch
                {
                    MessageCI messageCI = new MessageCI();     
                    messageCI.Show();   
                }

            }
        }

        private void txtcel_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (txtcel.Text.Trim().Length >= 8)//Validación de limite de caracteres M
            {
                //validacion para limite de caracteres 
                if (e.KeyChar == 08)
                {

                }
                else
                {
                    MessageDescLimite messageDescLimite = new MessageDescLimite();
                    messageDescLimite.Show();//validacion para limite de caracteres
                    e.Handled = true;
                    return;
                }
            }
        }

        private void btn_helper_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\AndromedaHelper.chm");
        }
    }
}
