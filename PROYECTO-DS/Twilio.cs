using Ejemplo2.Api;
using Ejemplo2.Message;
using System;
using System.Windows.Forms;

namespace MatthiWare.SmsAndCallClient
{
    public partial class TW : Form
    {
        private IClient m_currentApi;
        private IResponse m_lastResponse;

        public TW()
        {
            InitializeComponent();
            LoadAPIs();
        }

        private void LoadAPIs()
        {
            cbApis.Items.Add(new ClickatellWrapperClient(Credentials.CLICKATELL_API_KEY));
            cbApis.Items.Add(new TwilioWrapperClient(Credentials.TWILIO_ACC_SID, Credentials.TWILIO_AUTH_TOKEN));
        }


        private void cbApis_SelectedValueChanged(object sender, EventArgs e)
        {
            m_currentApi = cbApis.SelectedItem as IClient;

            if (m_currentApi == null)
                return;

            if (!m_currentApi.IsInitialized)
                m_currentApi.Init();
        

            btnText.Enabled = m_currentApi.CanSendSms;

            txtFrom.Enabled = m_currentApi.FromNumberRequired;
        }

        private async void btnText_Click(object sender, EventArgs e)
        {
            btnText.Enabled = false;

            string from = txtFrom.Text;
            string to = txtTo.Text;
            string body = txtBody.Text;

            SetStatus("Sending...");

            m_lastResponse = await m_currentApi.SendSmsAsync(from, to, body);


            btnText.Enabled = true;
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
            lblStatus.Text = $"Status: {value}";
        }

        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            txtBody.Clear();
            txtFrom.Clear();
            txtTo.Clear();
            cbApis.SelectedIndex = -1;
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
            else if (txtFrom.Text.Trim().Length >= 18)//Validación de limite de caracteres M
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

        private void cbApis_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            else if (txtFrom.Text.Trim().Length >= 18)//Validación de limite de caracteres M
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
            if (txtBody.Text.Trim().Length >= 250)//Validación de limite de caracteres M
            {

                //validacion para limite de caracteres 
                MessageDescLimite messageDescLimite = new MessageDescLimite();
                messageDescLimite.Show();
                txtBody.Clear();
                e.Handled = true;
                return;

            }
        }
    }
}
