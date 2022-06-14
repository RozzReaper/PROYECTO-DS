namespace Ejemplo2
{
    partial class LoginCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnLoginClientes = new System.Windows.Forms.Button();
            this.dgvsiu = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda de cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(61, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teléfono";
            // 
            // txtcel
            // 
            this.txtcel.Location = new System.Drawing.Point(129, 119);
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(230, 20);
            this.txtcel.TabIndex = 2;
            this.txtcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcel_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 86);
            this.panel1.TabIndex = 22;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btnMinimizar.Location = new System.Drawing.Point(1148, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnLoginClientes
            // 
            this.btnLoginClientes.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLoginClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginClientes.FlatAppearance.BorderSize = 0;
            this.btnLoginClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginClientes.Location = new System.Drawing.Point(774, 320);
            this.btnLoginClientes.Name = "btnLoginClientes";
            this.btnLoginClientes.Size = new System.Drawing.Size(94, 35);
            this.btnLoginClientes.TabIndex = 5;
            this.btnLoginClientes.Text = "Ingresar";
            this.btnLoginClientes.UseVisualStyleBackColor = false;
            this.btnLoginClientes.Click += new System.EventHandler(this.btnLoginClientes_Click);
            // 
            // dgvsiu
            // 
            this.dgvsiu.AllowUserToAddRows = false;
            this.dgvsiu.AllowUserToDeleteRows = false;
            this.dgvsiu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvsiu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvsiu.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvsiu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsiu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsiu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsiu.ColumnHeadersHeight = 30;
            this.dgvsiu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvsiu.EnableHeadersVisualStyles = false;
            this.dgvsiu.GridColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgvsiu.Location = new System.Drawing.Point(500, 144);
            this.dgvsiu.Name = "dgvsiu";
            this.dgvsiu.ReadOnly = true;
            this.dgvsiu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsiu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvsiu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvsiu.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvsiu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsiu.Size = new System.Drawing.Size(679, 91);
            this.dgvsiu.TabIndex = 24;
            this.dgvsiu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsiu_CellContentClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(165, 236);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(94, 35);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.txtbuscar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(1136, 320);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(52, 50);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 21;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtcel);
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 299);
            this.panel2.TabIndex = 26;
            // 
            // txtsearch
            // 
            this.txtsearch.Enabled = false;
            this.txtsearch.Location = new System.Drawing.Point(541, 389);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 20);
            this.txtsearch.TabIndex = 27;
            // 
            // LoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1200, 383);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvsiu);
            this.Controls.Add(this.btnLoginClientes);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginCliente";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCliente";
            this.Load += new System.EventHandler(this.LoginCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoginClientes;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvsiu;
        public System.Windows.Forms.TextBox txtsearch;
    }
}