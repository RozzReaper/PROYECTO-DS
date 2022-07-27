namespace Ejemplo2
{
    partial class frm_creacion_caso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_creacion_caso));
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.lbl_creacion_caso = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.lbl_id_empleado = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.pnl_creacion_caso = new System.Windows.Forms.Panel();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.pnl_creacion_caso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(831, 416);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(69, 62);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 21;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btn_minimizar.Location = new System.Drawing.Point(847, 15);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(53, 49);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 20;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lbl_creacion_caso
            // 
            this.lbl_creacion_caso.AutoSize = true;
            this.lbl_creacion_caso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creacion_caso.Location = new System.Drawing.Point(249, 18);
            this.lbl_creacion_caso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_creacion_caso.Name = "lbl_creacion_caso";
            this.lbl_creacion_caso.Size = new System.Drawing.Size(368, 46);
            this.lbl_creacion_caso.TabIndex = 22;
            this.lbl_creacion_caso.Text = "Creación de Caso";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(80, 198);
            this.lbl_categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(108, 23);
            this.lbl_categoria.TabIndex = 25;
            this.lbl_categoria.Text = "Categoría";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(540, 111);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(126, 23);
            this.lbl_descripcion.TabIndex = 25;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(79, 370);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(229, 23);
            this.lbl_fecha.TabIndex = 25;
            this.lbl_fecha.Text = "Fecha (Mes, Día, Año)";
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Enabled = false;
            this.txt_id_empleado.Location = new System.Drawing.Point(85, 149);
            this.txt_id_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(171, 22);
            this.txt_id_empleado.TabIndex = 24;
            // 
            // lbl_id_empleado
            // 
            this.lbl_id_empleado.AutoSize = true;
            this.lbl_id_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_empleado.Location = new System.Drawing.Point(80, 111);
            this.lbl_id_empleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_empleado.Name = "lbl_id_empleado";
            this.lbl_id_empleado.Size = new System.Drawing.Size(135, 23);
            this.lbl_id_empleado.TabIndex = 25;
            this.lbl_id_empleado.Text = "ID Empleado";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Items.AddRange(new object[] {
            "Problemas de conexión",
            "Internet lento",
            "Fecha de instalación",
            "Dia de pago",
            "Otro... (Especifique)"});
            this.cmb_categoria.Location = new System.Drawing.Point(84, 242);
            this.cmb_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(171, 24);
            this.cmb_categoria.TabIndex = 26;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.btn_insertar.Location = new System.Drawing.Point(317, 416);
            this.btn_insertar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(125, 38);
            this.btn_insertar.TabIndex = 27;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.txtins_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(371, 149);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(488, 201);
            this.txt_descripcion.TabIndex = 29;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desc_KeyPress);
            // 
            // pnl_creacion_caso
            // 
            this.pnl_creacion_caso.BackColor = System.Drawing.Color.Indigo;
            this.pnl_creacion_caso.Controls.Add(this.lbl_creacion_caso);
            this.pnl_creacion_caso.Controls.Add(this.btn_minimizar);
            this.pnl_creacion_caso.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_creacion_caso.Location = new System.Drawing.Point(0, 0);
            this.pnl_creacion_caso.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_creacion_caso.Name = "pnl_creacion_caso";
            this.pnl_creacion_caso.Size = new System.Drawing.Size(916, 79);
            this.pnl_creacion_caso.TabIndex = 30;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(85, 412);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(169, 22);
            this.dtp_fecha.TabIndex = 31;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(515, 417);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(125, 38);
            this.btn_limpiar.TabIndex = 27;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_cliente.Location = new System.Drawing.Point(80, 279);
            this.lbl_id_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(105, 23);
            this.lbl_id_cliente.TabIndex = 25;
            this.lbl_id_cliente.Text = "Id Cliente";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(84, 326);
            this.txt_id_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(171, 22);
            this.txt_id_cliente.TabIndex = 24;
            this.txt_id_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidcli_KeyPress);
            // 
            // frm_creacion_caso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 492);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.lbl_id_empleado);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.txt_id_empleado);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_id_cliente);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.pnl_creacion_caso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_creacion_caso";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creacion de Caso";
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.pnl_creacion_caso.ResumeLayout(false);
            this.pnl_creacion_caso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Label lbl_creacion_caso;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_id_empleado;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Panel pnl_creacion_caso;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_limpiar;
        public System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.Label lbl_id_cliente;
        public System.Windows.Forms.TextBox txt_id_cliente;
    }
}