﻿using System;
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
    public partial class MessageNume : Form
    {
        public MessageNume()
        {
            InitializeComponent();
        }

        private void btnOkC_Click(object sender, EventArgs e)
        {
            //Boton de "minimizacion" del message
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
