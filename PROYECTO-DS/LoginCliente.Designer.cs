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
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_login_clientes = new System.Windows.Forms.Button();
            this.dgv_siu = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_helper = new System.Windows.Forms.PictureBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_helper)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.AutoSize = true;
            this.lbl_busqueda.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda.Location = new System.Drawing.Point(428, 25);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(335, 38);
            this.lbl_busqueda.TabIndex = 0;
            this.lbl_busqueda.Text = "Búsqueda de cliente";
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
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.lbl_busqueda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 86);
            this.panel1.TabIndex = 22;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btn_minimizar.Location = new System.Drawing.Point(1148, 12);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(40, 40);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 20;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btn_login_clientes
            // 
            this.btn_login_clientes.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_login_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_clientes.FlatAppearance.BorderSize = 0;
            this.btn_login_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_clientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_clientes.Location = new System.Drawing.Point(774, 320);
            this.btn_login_clientes.Name = "btn_login_clientes";
            this.btn_login_clientes.Size = new System.Drawing.Size(94, 35);
            this.btn_login_clientes.TabIndex = 5;
            this.btn_login_clientes.Text = "Ingresar";
            this.btn_login_clientes.UseVisualStyleBackColor = false;
            this.btn_login_clientes.Click += new System.EventHandler(this.btnLoginClientes_Click);
            // 
            // dgv_siu
            // 
            this.dgv_siu.AllowUserToAddRows = false;
            this.dgv_siu.AllowUserToDeleteRows = false;
            this.dgv_siu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_siu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_siu.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgv_siu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_siu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_siu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_siu.ColumnHeadersHeight = 30;
            this.dgv_siu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_siu.EnableHeadersVisualStyles = false;
            this.dgv_siu.GridColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgv_siu.Location = new System.Drawing.Point(500, 144);
            this.dgv_siu.Name = "dgv_siu";
            this.dgv_siu.ReadOnly = true;
            this.dgv_siu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_siu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_siu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_siu.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_siu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_siu.Size = new System.Drawing.Size(679, 91);
            this.dgv_siu.TabIndex = 24;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(165, 236);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(94, 35);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.txtbuscar_Click);
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
            this.panel2.Controls.Add(this.btn_helper);
            this.panel2.Controls.Add(this.btn_buscar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtcel);
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 299);
            this.panel2.TabIndex = 26;
            // 
            // btn_helper
            // 
            this.btn_helper.BackColor = System.Drawing.Color.Transparent;
            this.btn_helper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_helper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_helper.Image = global::Ejemplo2.Properties.Resources.question_mark_circle_icon_152550;
            this.btn_helper.Location = new System.Drawing.Point(12, 238);
            this.btn_helper.Name = "btn_helper";
            this.btn_helper.Size = new System.Drawing.Size(48, 49);
            this.btn_helper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_helper.TabIndex = 19;
            this.btn_helper.TabStop = false;
            this.btn_helper.Click += new System.EventHandler(this.btn_helper_Click);
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
            this.Controls.Add(this.dgv_siu);
            this.Controls.Add(this.btn_login_clientes);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginCliente";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_helper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_busqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_login_clientes;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_siu;
        public System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.PictureBox btn_helper;
    }
}