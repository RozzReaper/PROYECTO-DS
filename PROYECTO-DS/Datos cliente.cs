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
using System.Text.RegularExpressions;

namespace Ejemplo2
{
    public partial class Datos_cliente : Form
    {
        public Datos_cliente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["database-conection"].ConnectionString);
        //Se hace uso de la conexion establecida con el servidor

        void Modificar()
        {
            cn.Open();//Se abre la conexion con al BD
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.Clientes SET dbo.Clientes.Nombres ='" +this.txtnombre.Text+ "',dbo.Clientes.Email='" + this.txtemail.Text + "',dbo.Clientes.Estado='" + this.cmbestado.Text + "',dbo.Clientes.Calle='" + this.txtcalle.Text + "',dbo.Clientes.Casa_num='" + this.txtcasanum.Text + "',dbo.Clientes.Teléfono='" + this.txttelefono.Text + "'WHERE dbo.Clientes.Id_cliente=" +Convert.ToInt32(this.txtid.Text + ""), cn);
                cmd.ExecuteNonQuery();//Se declara un comando para añadir el query usado para actualizar los datos
                cn.Close();//cambiando los valores de las posibles variables por los valores puestos en los textbox, se ejecuta y cierra la conexion
            }
            catch
            {
                MessageLogin login= new MessageLogin();//En caso que falle, lanza un error diciendo que el proceso no tuvo éxito
                login.Show();
            }
            cn.Close();

        }

        public static bool ValidarEmail(string comprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(comprobarEmail, emailFormato))
            {
                if (Regex.Replace(comprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            LoginCliente loginCliente = new LoginCliente();//Se instancia el formulario para usar sus campos y variables
            loginCliente.txtsearch.Text = txtidfinal.Text;//Se iguala el contenido del text box que contiene el id al del siguiente formulatio
            loginCliente.Show();
            this.Hide();
        }

        private void Datos_cliente_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtpendiente_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            if (txtcalle.Text == "" || cmbestado.Text == "" || txttelefono.Text == "")//Primera validación si los parámetros están incompletos
            {

                MessageCreacion creacion= new MessageCreacion();//Se mandará un formulario que contendrá el mensaje de error
                creacion.Show();
            }
            else
            {
                if (txttelefono.Text.Trim().Length != 8)//Segunda validación, si el numero ingresado supera el largo de 8 digitos
                {
                    Tel8digi tel8Digi = new Tel8digi(); 
                    tel8Digi.Show();//Se lanza un mensaje de error, mostrando que el numero debe de ser de esa cantidad
                }
                else//Usando la propiedad para acceder al contenido del primer digito, se hace un if para que, si no coincide con los numeros posteriores->
                {
                    if (!txttelefono.Text[0].ToString().Equals("2") && !txttelefono.Text[0].ToString().Equals("3") && !txttelefono.Text[0].ToString().Equals("8") && !txttelefono.Text[0].ToString().Equals("9"))
                    {
                        MessageTel messageTel = new MessageTel();//<-Mostrar un mensaje informando que el numero solo debe comenzar con 2,3,8 o 9
                        messageTel.Show();

                    }
                    else
                    {
                        if (txtcasanum.Text.Trim().Length > 4)//Segunda validación, si el numero ingresado supera el largo de 8 digitos
                        {
                            MessageBox.Show("El número de casa no debe pasar los 4 caracteres");//mensaje de error num casa M
                        }
                        else
                        {
                            if (ValidarEmail(txtemail.Text) == false)
                            {
                                MessageBox.Show("Correo no válido, formato obligatorio: nombredeusuario@dominio.extension" +
                                " por favor escriba un correo válido", "Validacion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Information);//Validación correo M
                            }
                            else
                            {

                                    //En caso de que coincida, mostrar un mensaje señanlando que el parametro se inserto de forma exitosa
                                    Modificar();
                                    MessageCaso caso = new MessageCaso();
                                    caso.Show();
                            }
                        }




                    }

                }

            }
            
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)//Mediante el uso del evento KeyPress, se conoce el tipo de dato que se está escribiendo
        {
            //string telefono = ("SELECT*FROM Empleados('" + txttelefono.Text + "%')");

            if (e.Handled = char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("No se permiten espacios");// mensaje de error para espacios M
            }
            else if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//En caso de no pertenecer a los numeros del 0-9, mandar un mensaje de error
                {
                    MessageNume messageNume = new MessageNume();//En caso que se introduzca un valor que no sea tipo numérico, mandar un mensaje de error
                    messageNume.Show();
                    e.Handled = true;
                    return;

                }
            else if (txttelefono.Text.Trim().Length >= 8)//Validación de limite de caracteres M
            {
                MessageBox.Show("Se excede el límite de caracteres");
                e.Handled = true;
                return;
            }





        }


        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtnombre.Text.Trim().Length >= 50)//Validación de limite de caracteres M
            {
                MessageBox.Show("Se excede el límite de caracteres");
                e.Handled = true;
                return;
            }


        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("No se permiten espacios");// mensaje de error para espacios M
            }
            else if (txtemail.Text.Trim().Length >= 175)//Validación de limite de caracteres M
            {
                MessageBox.Show("Se excede el límite de caracteres");
                e.Handled = true;
                return;
            }

        }

        private void txtcasanum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("No se permiten espacios");// mensaje de error para espacios M
            }
            else if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//En caso de no pertenecer a los numeros del 0-9, mandar un mensaje de error
                {
                    MessageNume messageNume = new MessageNume();//En caso que se introduzca un valor que no sea tipo numérico, mandar un mensaje de error
                    messageNume.Show();
                    e.Handled = true;
                    return;

                }
            else if (txtcasanum.Text.Trim().Length >= 4)//Validación de limite de caracteres M
            {
                MessageBox.Show("Se excede el límite de caracteres");
                e.Handled = true;
                return;
            }

        }

        private void txtcalle_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("No se permiten espacios");// mensaje de error para espacios M
            }
            else
            {
                if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))//En caso de no pertenecer a los numeros del 0-9, mandar un mensaje de error
                {
                    MessageBox.Show("Sin caracteres especiales");
                    e.Handled = true;
                    return;
                }
                else
                {
                    if (txtcalle.Text.Trim().Length >= 50)//Validación de limite de caracteres PONER EN LOS DEMAS TEXTBOX
                    {
                        MessageBox.Show("Se excede el límite de caracteres");
                        e.Handled = true;
                        return;
                    }
                }
            }


            
        }

        private void txtcasanum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcasanum_Click(object sender, EventArgs e)
        {
        }

        private void cmbestado_DropDownStyleChanged(object sender, EventArgs e)
        {
            
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
