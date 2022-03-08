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
            Login_Clientes obj = new Login_Clientes();
            bool Valido = obj.LoginC(txtname.Text, Convert.ToInt32(txtcel.Text), txt_clave.Text);

            

            if (Valido)
            {
                dgvsiu.DataSource = obj.LoginC(txtname.Text, Convert.ToInt32(txtcel.Text), txt_clave.Text);

            }
            else
            {
                MessageBox.Show("Nombre/Teléfono y/o Clave incorrectos");
            }
        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtcel.Text=="" || txt_clave.Text=="")
            {
                MessageBox.Show("Por favor, ingrese datos suficientes/existentes");
            }
            else
            {
                string query = "SELECT dbo.Clientes.Nombres, dbo.Clientes.Email, dbo.Clientes.Estado, dbo.Clientes.Calle, dbo.Clientes.Casa_num, dbo.Clientes.Teléfono, dbo.Historial_crediticio.Impuesto, dbo.Historial_crediticio.Costo_plan, dbo.Historial_crediticio.Descuento, dbo.Historial_crediticio.Subtotal, dbo.Historial_crediticio.Pendiente, dbo.Historial_crediticio.Total, dbo.Planes.Fecha_inicio, dbo.Planes.Velocidad, dbo.Planes.Tipo_fibra,dbo.Planes.Día_pago, dbo.Planes.Plan_estado FROM dbo.Clientes INNER JOIN dbo.Historial_crediticio ON dbo.Clientes.Id_cliente = dbo.Historial_crediticio.FK_Clientes INNER JOIN dbo.Planes ON dbo.Clientes.Id_cliente = dbo.Planes.FK_Clientes where Nombres = '"+ txtname.Text +"'  and Teléfono = '"+txtcel.Text+"' and Clave='"+txt_clave.Text+"'";
                SqlCommand comando = new SqlCommand(query, cn);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvsiu.DataSource = tabla;
            }
        }
    }
}
