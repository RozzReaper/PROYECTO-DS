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
    public partial class frm_datos_cliente : Form
    {
        public frm_datos_cliente()
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
                SqlCommand cmd = new SqlCommand("UPDATE dbo.clientes SET dbo.clientes.nombres ='" +this.txt_nombre.Text + "',dbo.clientes.apellidos='" + this.txt_apellidos.Text + "',dbo.clientes.email='" + this.txt_email.Text + "',dbo.clientes.estado='" + this.cmb_estado.Text + "',dbo.clientes.calle='" + this.txt_calle.Text + "',dbo.clientes.casa_num='" + this.txt_num_casa.Text + "',dbo.clientes.telefono='" + this.txt_telefono.Text + "'WHERE dbo.clientes.id_cliente=" +Convert.ToInt32(this.txt_id.Text + ""), cn);
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

        public static bool ValidarEmail(string comprobar_email)
        {
            string formato_email = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(comprobar_email, formato_email))
            {
                if (Regex.Replace(comprobar_email, formato_email, String.Empty).Length == 0)
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
            frm_login_cliente loginCliente = new frm_login_cliente();//Se instancia el formulario para usar sus campos y variables
            loginCliente.txtsearch.Text = txtidfinal.Text;//Se iguala el contenido del text box que contiene el id al del siguiente formulatio
            loginCliente.Show();
            this.Hide();
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            if (txt_calle.Text == "" || cmb_estado.Text == "" || txt_telefono.Text == "")//Primera validación si los parámetros están incompletos
            {

                MessageCreacion creacion= new MessageCreacion();//Se mandará un formulario que contendrá el mensaje de error
                creacion.Show();
            }
            else
            {
                if (txt_telefono.Text.Trim().Length != 8)//Segunda validación, si el numero ingresado supera el largo de 8 digitos
                {
                    Tel8digi tel8Digi = new Tel8digi(); 
                    tel8Digi.Show();//Se lanza un mensaje de error, mostrando que el numero debe de ser de esa cantidad
                }
                else//Usando la propiedad para acceder al contenido del primer digito, se hace un if para que, si no coincide con los numeros posteriores->
                {
                    if (!txt_telefono.Text[0].ToString().Equals("2") && !txt_telefono.Text[0].ToString().Equals("3") && !txt_telefono.Text[0].ToString().Equals("8") && !txt_telefono.Text[0].ToString().Equals("9"))
                    {
                        MessageTel message_telefono = new MessageTel();//<-Mostrar un mensaje informando que el numero solo debe comenzar con 2,3,8 o 9
                        message_telefono.Show();

                    }
                    else
                    {
                        if (txt_num_casa.Text.Trim().Length > 4)//Segunda validación, si el numero ingresado supera el largo de 8 digitos
                        {
                            ValCasa validar_casa = new ValCasa(); //mensaje de error num casa
                            validar_casa.Show();
                        }
                        else
                        {
                            if (ValidarEmail(txt_email.Text) == false)
                            {
                                Correo correo = new Correo();//Validación correo M
                                correo.Show();
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

            if (e.Handled = char.IsWhiteSpace(e.KeyChar))
            {
                MessageDescVacia message_descripcion_vacia = new MessageDescVacia();
                message_descripcion_vacia.Show();// mensaje de error para espacios 
            }
            else if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//En caso de no pertenecer a los numeros del 0-9, mandar un mensaje de error
                {
                    MessageNume message_numero = new MessageNume();//En caso que se introduzca un valor que no sea tipo numérico, mandar un mensaje de error
                    message_numero.Show();
                    e.Handled = true;
                    return;

                }
            else if (txt_telefono.Text.Trim().Length >= 8)//Validación de limite de caracteres M
            {
                //validacion para limite de caracteres 
                if(e.KeyChar != 08)
                {
                    MessageDescLimite message_descripcion_limite = new MessageDescLimite();
                    message_descripcion_limite.Show();//validacion para limite de caracteresv
                    e.Handled = true;
                    return;
                }
            }

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_nombre.Text.Trim().Length >= 50)//Validación de limite de caracteres M
            {
                //validacion para limite de caracteres 
                if (e.KeyChar != 08)
                {
                    MessageDescLimite message_descripcion_limite = new MessageDescLimite();
                    message_descripcion_limite.Show();//validacion para limite de caracteres
                    e.Handled = true;
                    return;
                }
            }

        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = char.IsWhiteSpace(e.KeyChar))
            {
                MessageDescVacia message_descripcion_vacia = new MessageDescVacia();
                message_descripcion_vacia.Show();// mensaje de error para espacios
            }
            else if (txt_email.Text.Trim().Length >= 175)//Validación de limite de caracteres M
            {
                //validacion para limite de caracteres 
                if (e.KeyChar != 08)
                {
                    MessageDescLimite message_descripcion_limite = new MessageDescLimite();
                    message_descripcion_limite.Show();//validacion para limite de caracteres
                    e.Handled = true;
                    return;
                }
            }

        }

        private void txtcasanum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = char.IsWhiteSpace(e.KeyChar))
            {
                MessageDescVacia message_descripcion_vacia = new MessageDescVacia();
                message_descripcion_vacia.Show();// mensaje de error para espacios
            }
            else if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//En caso de no pertenecer a los numeros del 0-9, mandar un mensaje de error
            {
                    MessageNume message_numero = new MessageNume();//En caso que se introduzca un valor que no sea tipo numérico, mandar un mensaje de error
                message_numero.Show();
                    e.Handled = true;
                    return;

            }
            else if (txt_num_casa.Text.Trim().Length >= 4)//Validación de limite de caracteres M
            {
                //validacion para limite de caracteres 
                if (e.KeyChar != 08)
                {
                    MessageDescLimite message_descripcion_limite = new MessageDescLimite();
                    message_descripcion_limite.Show();//validacion para limite de caracteres
                    e.Handled = true;
                    return;
                }
            }

        }

        private void txtcalle_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = char.IsWhiteSpace(e.KeyChar))
            {
                MessageDescVacia message_descripcion_vacia = new MessageDescVacia();
                message_descripcion_vacia.Show();// mensaje de error para espacios
            }
            else
            {
                if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))//En caso de no pertenecer a los numeros del 0-9, mandar un mensaje de error
                {
                    MessageDescVacia message_descripcion_vacia = new MessageDescVacia();
                    message_descripcion_vacia.Show();// mensaje de error para espacios
                    e.Handled = true;
                    return;
                }
                else
                {
                    if (txt_calle.Text.Trim().Length >= 50)//Validación de limite de caracteres PONER EN LOS DEMAS TEXTBOX
                    {
                        //validacion para limite de caracteres
                        if(e.KeyChar != 08)
                        {
                            MessageDescLimite message_descripcion_limite = new MessageDescLimite();
                            message_descripcion_limite.Show();//validacion para el tipo de caracter
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            
        }


        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_apellidos.Text.Trim().Length >= 50)//Validación de limite de caracteres M
            {
                //validacion para limite de caracteres 
                if (e.KeyChar >=0 && e.KeyChar <= 7 || e.KeyChar>=9 && e.KeyChar<=64 || e.KeyChar>=91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
                {
                    if (e.KeyChar != 08)
                    {
                        MessageDescLimite message_descripcion_limite = new MessageDescLimite();
                        message_descripcion_limite.Show();//validacion para limite de caracteres
                        e.Handled = true;
                        return;
                    }
                }
            }
        }
    }
}
