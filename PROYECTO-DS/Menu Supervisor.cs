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
    public partial class Menu_Supervisor : Form
    {
        public Menu_Supervisor()//Acceso a una clase en este caso al Menu supervisor
        {
            InitializeComponent();//Llamada al constructor para inicializar los parametros
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //Boton para regresar a la pantalla anterior
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Boton para minimizar pantalla
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCaso_Click(object sender, EventArgs e)
        {
            //Boton para mostrar el Caso
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
