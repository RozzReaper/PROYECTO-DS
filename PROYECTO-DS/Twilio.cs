using Ejemplo2.Api;
using Ejemplo2.Message;
using System;
using System.Windows.Forms;
using Ejemplo2.Cache;
using Ejemplo2.Repositorios;
using System.ComponentModel;
using System.Diagnostics;
using Ejemplo2;

namespace MatthiWare.SmsAndCallClient
{
    public partial class tw_frm : Form
    {
        private IClient m_currentApi;
        private IResponse m_lastResponse;

        public tw_frm()
        {
            InitializeComponent();
            LoadAPIs();
        }

        private void LoadAPIs()
        {
            cb_apis.Items.Add(new ClickatellWrapperClient(Credentials.CLICKATELL_API_KEY));
            cb_apis.Items.Add(new TwilioWrapperClient(Credentials.TWILIO_ACC_SID, Credentials.TWILIO_AUTH_TOKEN));
        }


        private void cbApis_SelectedValueChanged(object sender, EventArgs e)
        {
            m_currentApi = cb_apis.SelectedItem as IClient;

            if (m_currentApi == null)
                return;

            if (!m_currentApi.IsInitialized)
                m_currentApi.Init();
        

            btn_text.Enabled = m_currentApi.CanSendSms;

            txt_from.Enabled = m_currentApi.FromNumberRequired;
        }

        private async void btnText_Click(object sender, EventArgs e)
        {
            btn_text.Enabled = false;

            string from = txt_from.Text;
            string to = txt_to.Text;
            string body = txt_body.Text;

            SetStatus("Sending...");

            m_lastResponse = await m_currentApi.SendSmsAsync(from, to, body);


            btn_text.Enabled = true;
            SetStatus();
        }



        private void SetStatus()
        {
            if (m_lastResponse == null)
                return;

            SetStatus(m_lastResponse.Status);
        }

        private void SetStatus(string value)
        {
            lbl_status.Text = $"Status: {value}";
        }

        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            txt_body.Clear();
            txt_from.Clear();
            txt_to.Clear();
            cb_apis.SelectedIndex = -1;
            if (m_lastResponse == null || !m_lastResponse.CanUpdate)
                return;

            await m_lastResponse.UpdateAsync();
            SetStatus();
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 33 && e.KeyChar <=42 && e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//En caso de no pertenecer a los numeros del 0-9, mandar un mensaje de error
            {
                MessageNume messageNume = new MessageNume();//En caso que se introduzca un valor que no sea tipo numérico, mandar un mensaje de error
                messageNume.Show();
                e.Handled = true;
                return;

            }
            else if (txt_from.Text.Trim().Length >= 18)//Validación de limite de caracteres M
            {
                //validacion para limite de caracteres 
                if (e.KeyChar == 18)
                {

                }
                else
                {
                    MessageDescLimite messageDescLimite = new MessageDescLimite();
                    messageDescLimite.Show();//validacion para limite de caracteresv
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 42 && e.KeyChar >= 44 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//En caso de no pertenecer a los numeros del 0-9, mandar un mensaje de error
            {
                MessageNume messageNume = new MessageNume();//En caso que se introduzca un valor que no sea tipo numérico, mandar un mensaje de error
                messageNume.Show();
                e.Handled = true;
                return;

            }
            else if (txt_from.Text.Trim().Length >= 18)//Validación de limite de caracteres M
            {
                //validacion para limite de caracteres 
                if (e.KeyChar == 18)
                {

                }
                else
                {
                    MessageDescLimite messageDescLimite = new MessageDescLimite();
                    messageDescLimite.Show();//validacion para limite de caracteresv
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtBody_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_body.Text.Trim().Length >= 250)//Validación de limite de caracteres M
            {

                //validacion para limite de caracteres 
                MessageDescLimite messageDescLimite = new MessageDescLimite();
                messageDescLimite.Show();
                txt_body.Clear();
                e.Handled = true;
                return;

            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            menu_agente_universal frm = new menu_agente_universal();
            frm.txt_import.Text = txttwilio.Text;//Se iguala el contenido del text box que contiene el id al del siguiente formulatio
            frm.Show();
            this.Hide();//Mediante una orpiedad, se oculta el formulario presentado, para mostrar el siguiente
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
