namespace Ejemplo2
{
    partial class frm_login_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login_cliente));
            this.lbl_busqueda_cliente = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.pnl_busqueda_cliente = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_login_clientes = new System.Windows.Forms.Button();
            this.dgv_busqueda_cliente = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.pnl_telefono = new System.Windows.Forms.Panel();
            this.btn_helper = new System.Windows.Forms.PictureBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.pnl_busqueda_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.pnl_telefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_helper)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_busqueda_cliente
            // 
            this.lbl_busqueda_cliente.AutoSize = true;
            this.lbl_busqueda_cliente.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda_cliente.Location = new System.Drawing.Point(571, 31);
            this.lbl_busqueda_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_busqueda_cliente.Name = "lbl_busqueda_cliente";
            this.lbl_busqueda_cliente.Size = new System.Drawing.Size(421, 47);
            this.lbl_busqueda_cliente.TabIndex = 0;
            this.lbl_busqueda_cliente.Text = "Búsqueda de cliente";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lbl_telefono.Location = new System.Drawing.Point(81, 150);
            this.lbl_telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(80, 21);
            this.lbl_telefono.TabIndex = 0;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(172, 146);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(305, 22);
            this.txt_telefono.TabIndex = 2;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcel_KeyPress);
            // 
            // pnl_busqueda_cliente
            // 
            this.pnl_busqueda_cliente.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnl_busqueda_cliente.Controls.Add(this.btn_minimizar);
            this.pnl_busqueda_cliente.Controls.Add(this.lbl_busqueda_cliente);
            this.pnl_busqueda_cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_busqueda_cliente.Location = new System.Drawing.Point(0, 0);
            this.pnl_busqueda_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_busqueda_cliente.Name = "pnl_busqueda_cliente";
            this.pnl_busqueda_cliente.Size = new System.Drawing.Size(1600, 106);
            this.pnl_busqueda_cliente.TabIndex = 22;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btn_minimizar.Location = new System.Drawing.Point(1531, 15);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(53, 49);
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
            this.btn_login_clientes.Location = new System.Drawing.Point(1032, 394);
            this.btn_login_clientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login_clientes.Name = "btn_login_clientes";
            this.btn_login_clientes.Size = new System.Drawing.Size(125, 43);
            this.btn_login_clientes.TabIndex = 5;
            this.btn_login_clientes.Text = "Ingresar";
            this.btn_login_clientes.UseVisualStyleBackColor = false;
            this.btn_login_clientes.Click += new System.EventHandler(this.btnLoginClientes_Click);
            // 
            // dgv_busqueda_cliente
            // 
            this.dgv_busqueda_cliente.AllowUserToAddRows = false;
            this.dgv_busqueda_cliente.AllowUserToDeleteRows = false;
            this.dgv_busqueda_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_busqueda_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_busqueda_cliente.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgv_busqueda_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_busqueda_cliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busqueda_cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_busqueda_cliente.ColumnHeadersHeight = 30;
            this.dgv_busqueda_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_busqueda_cliente.EnableHeadersVisualStyles = false;
            this.dgv_busqueda_cliente.GridColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgv_busqueda_cliente.Location = new System.Drawing.Point(667, 177);
            this.dgv_busqueda_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_busqueda_cliente.Name = "dgv_busqueda_cliente";
            this.dgv_busqueda_cliente.ReadOnly = true;
            this.dgv_busqueda_cliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busqueda_cliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_busqueda_cliente.RowHeadersWidth = 51;
            this.dgv_busqueda_cliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_busqueda_cliente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_busqueda_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_busqueda_cliente.Size = new System.Drawing.Size(905, 112);
            this.dgv_busqueda_cliente.TabIndex = 24;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(220, 290);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(125, 43);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.txtbuscar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(1515, 394);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(69, 62);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 21;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // pnl_telefono
            // 
            this.pnl_telefono.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnl_telefono.Controls.Add(this.btn_helper);
            this.pnl_telefono.Controls.Add(this.btn_buscar);
            this.pnl_telefono.Controls.Add(this.lbl_telefono);
            this.pnl_telefono.Controls.Add(this.txt_telefono);
            this.pnl_telefono.Location = new System.Drawing.Point(0, 103);
            this.pnl_telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_telefono.Name = "pnl_telefono";
            this.pnl_telefono.Size = new System.Drawing.Size(613, 368);
            this.pnl_telefono.TabIndex = 26;
            // 
            // btn_helper
            // 
            this.btn_helper.BackColor = System.Drawing.Color.Transparent;
            this.btn_helper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_helper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_helper.Image = global::Ejemplo2.Properties.Resources.question_mark_circle_icon_152550;
            this.btn_helper.Location = new System.Drawing.Point(16, 293);
            this.btn_helper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_helper.Name = "btn_helper";
            this.btn_helper.Size = new System.Drawing.Size(64, 60);
            this.btn_helper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_helper.TabIndex = 19;
            this.btn_helper.TabStop = false;
            this.btn_helper.Click += new System.EventHandler(this.btn_helper_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Enabled = false;
            this.txtsearch.Location = new System.Drawing.Point(721, 479);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(132, 22);
            this.txtsearch.TabIndex = 27;
            // 
            // frm_login_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1600, 471);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgv_busqueda_cliente);
            this.Controls.Add(this.btn_login_clientes);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.pnl_busqueda_cliente);
            this.Controls.Add(this.pnl_telefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_login_cliente";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCliente";
            this.pnl_busqueda_cliente.ResumeLayout(false);
            this.pnl_busqueda_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.pnl_telefono.ResumeLayout(false);
            this.pnl_telefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_helper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_busqueda_cliente;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Panel pnl_busqueda_cliente;
        private System.Windows.Forms.Button btn_login_clientes;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel pnl_telefono;
        private System.Windows.Forms.DataGridView dgv_busqueda_cliente;
        public System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.PictureBox btn_helper;
    }
}