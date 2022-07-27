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
    public partial class frm_login_cliente : Form
    {
        public frm_login_cliente()
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
                bool Valido = obj.LoginC(Convert.ToInt32(txt_telefono.Text)); //Se extrapola el valor booleano y se iguala el parametro definido al text box

                if (Valido)
                {
                    frm_datos_cliente datos = new frm_datos_cliente();
                    datos.txtidfinal.Text = txtsearch.Text;                    
                    this.Hide();
                    datos.Show();

                    try
                    {
                        if (dgv_busqueda_cliente.Rows.Count == 0)//Si los datos son nulos, mostrar un error el cual dice que no existe dicho cliente
                        {
                            MessageNC messageNC = new MessageNC();
                            messageNC.Show();
                        }
                        else
                        {

                            datos.txt_id.Text = dgv_busqueda_cliente.CurrentRow.Cells[0].Value.ToString();//Se envian los datos de el dgv hacia los textbox
                            datos.txt_nombre.Text = dgv_busqueda_cliente.CurrentRow.Cells[1].Value.ToString();//Del siguiente formulario
                            datos.txt_apellidos.Text = dgv_busqueda_cliente.CurrentRow.Cells[2].Value.ToString();
                            datos.txt_email.Text = dgv_busqueda_cliente.CurrentRow.Cells[3].Value.ToString();
                            datos.cmb_estado.Text = dgv_busqueda_cliente.CurrentRow.Cells[4].Value.ToString();
                            datos.txt_calle.Text = dgv_busqueda_cliente.CurrentRow.Cells[5].Value.ToString();
                            datos.txt_num_casa.Text = dgv_busqueda_cliente.CurrentRow.Cells[6].Value.ToString();
                            datos.txt_telefono.Text = dgv_busqueda_cliente.CurrentRow.Cells[7].Value.ToString();
                            datos.txt_impuesto.Text = dgv_busqueda_cliente.CurrentRow.Cells[8].Value.ToString();
                            datos.txt_costo_plan.Text = dgv_busqueda_cliente.CurrentRow.Cells[9].Value.ToString();
                            datos.txt_descuento.Text = dgv_busqueda_cliente.CurrentRow.Cells[10].Value.ToString();
                            datos.txt_subtotal.Text = dgv_busqueda_cliente.CurrentRow.Cells[11].Value.ToString();
                            datos.txt_pendiente.Text = dgv_busqueda_cliente.CurrentRow.Cells[12].Value.ToString();
                            datos.txt_total.Text = dgv_busqueda_cliente.CurrentRow.Cells[13].Value.ToString();
                            datos.txt_fecha_inicio.Text = dgv_busqueda_cliente.CurrentRow.Cells[14].Value.ToString();
                            datos.txt_velocidad.Text = dgv_busqueda_cliente.CurrentRow.Cells[15].Value.ToString();
                            datos.txt_tipofibra.Text = dgv_busqueda_cliente.CurrentRow.Cells[16].Value.ToString();
                            datos.txt_dia_pago.Text = dgv_busqueda_cliente.CurrentRow.Cells[17].Value.ToString();
                            datos.txt_estado_plan.Text = dgv_busqueda_cliente.CurrentRow.Cells[18].Value.ToString();
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

            if(txt_telefono.Text=="")//Primera validación si el campo telefono está vacío
            {
                MessageCliente messageLogin = new MessageCliente();
                messageLogin.Show();
            }
            else
            {
                try//Se declara un string el cual contendrá la sentencia para buscar a los clientes
                {
                    string query = "SELECT dbo.clientes.id_cliente, dbo.clientes.nombres,dbo.clientes.apellidos, dbo.clientes.email, dbo.clientes.estado, dbo.clientes.calle, dbo.clientes.casa_num, dbo.clientes.telefono, dbo.historial_crediticio.impuesto, dbo.historial_crediticio.costo_plan, dbo.historial_crediticio.descuento, dbo.historial_crediticio.subtotal, dbo.historial_crediticio.pendiente, dbo.historial_crediticio.total, dbo.planes.fecha_inicio, dbo.planes.velocidad, dbo.planes.tipo_fibra,dbo.planes.dia_pago, dbo.planes.plan_estado FROM dbo.clientes INNER JOIN dbo.historial_crediticio ON dbo.clientes.id_cliente = dbo.historial_crediticio.fk_clientes INNER JOIN dbo.planes ON dbo.clientes.id_cliente = dbo.planes.fk_clientes where telefono = '" + txt_telefono.Text +  "'";
                    SqlCommand comando = new SqlCommand(query, cn);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();//Haciendo uso de un data adapter, se lleva a cabo la consulta
                    data.Fill(tabla);//Llenado de datos pata luego igualarlo al dgv existente
                    dgv_busqueda_cliente.DataSource = tabla;

                    if(dgv_busqueda_cliente.Rows.Count ==0)//Si el dgv está vácío, tirar un mensaje de error
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
            else if (txt_telefono.Text.Trim().Length >= 8)//Validación de limite de caracteres M
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
