﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnAgente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            Form7 traslado = new Form7();
            traslado.txtidemple.Text = txtimport.Text;
            this.Hide();
            traslado.Show();
        }

        private void btnlgncliente_Click(object sender, EventArgs e)
        {
            
            LoginCliente loginCliente = new LoginCliente();
            loginCliente.txtsearch.Text = txtimport.Text;
            this.Hide();
            loginCliente.Show();
        }
    }
}
