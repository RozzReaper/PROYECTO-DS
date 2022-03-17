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

namespace Ejemplo2
{
    public partial class LoginCliente : Form
    {
        public LoginCliente()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["database-conection"].ConnectionString);
        Conexion conexion = new Conexion();

        private void LoginCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm = new Form6();
            frm.Show();
        }

        private void btnLoginClientes_Click(object sender, EventArgs e)
        {
            //Herencia al evento
            cn.Open();
            Login_Clientes obj = new Login_Clientes();
            bool Valido = obj.LoginC(txtname.Text, Convert.ToInt32(txtcel.Text), txt_clave.Text);
   

            if (Valido)
            {

                Datos_cliente datos = new Datos_cliente();
                this.Hide();
                datos.Show();

                try
                {
                    datos.txtid.Text = dgvsiu.CurrentRow.Cells[0].Value.ToString();
                    datos.txtnombre.Text = dgvsiu.CurrentRow.Cells[1].Value.ToString();
                    datos.txtemail.Text = dgvsiu.CurrentRow.Cells[2].Value.ToString();
                    datos.txtestado.Text = dgvsiu.CurrentRow.Cells[3].Value.ToString();
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
                catch
                {
                    MessageBusque messageBusque = new MessageBusque();
                    messageBusque.Show();
                }

            }
            else
            {
                MessageIncorrecto messageIncorrecto = new MessageIncorrecto();
                messageIncorrecto.Show();
            }
        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {

            if(txtname.Text == "" || txtcel.Text=="" || txt_clave.Text=="")
            {
                MessageCliente messageLogin = new MessageCliente();
                messageLogin.Show();
            }
            else
            {
                string query = "SELECT dbo.Clientes.Id_cliente, dbo.Clientes.Nombres, dbo.Clientes.Email, dbo.Clientes.Estado, dbo.Clientes.Calle, dbo.Clientes.Casa_num, dbo.Clientes.Teléfono, dbo.Historial_crediticio.Impuesto, dbo.Historial_crediticio.Costo_plan, dbo.Historial_crediticio.Descuento, dbo.Historial_crediticio.Subtotal, dbo.Historial_crediticio.Pendiente, dbo.Historial_crediticio.Total, dbo.Planes.Fecha_inicio, dbo.Planes.Velocidad, dbo.Planes.Tipo_fibra,dbo.Planes.Día_pago, dbo.Planes.Plan_estado FROM dbo.Clientes INNER JOIN dbo.Historial_crediticio ON dbo.Clientes.Id_cliente = dbo.Historial_crediticio.FK_Clientes INNER JOIN dbo.Planes ON dbo.Clientes.Id_cliente = dbo.Planes.FK_Clientes where Nombres = '" + txtname.Text +"'  and Teléfono = '"+txtcel.Text+"' and Clave='"+txt_clave.Text+"'";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvsiu.DataSource = tabla;
            }
        }

        private void btndetalles_Click(object sender, EventArgs e)
        {

        }

        private void dgvsiu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
