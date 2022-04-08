using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2.Message
{
    public partial class MessageLogin : Form
    {
        public MessageLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOkL_Click(object sender, EventArgs e)
        {
            //Boton de "minimizacion" del message
            this.Hide();
        }
    }
}
