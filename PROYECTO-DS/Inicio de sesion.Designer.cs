namespace Ejemplo2
{
    partial class frm_inicio_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio_sesion));
            this.pnl_andromeda = new System.Windows.Forms.Panel();
            this.lbl_andromeda = new System.Windows.Forms.Label();
            this.ptb_andromeda = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_acceder = new System.Windows.Forms.Button();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.txtcopiar = new System.Windows.Forms.TextBox();
            this.cmb_tipo_empleado = new System.Windows.Forms.ComboBox();
            this.pnl_andromeda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_andromeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_andromeda
            // 
            this.pnl_andromeda.BackColor = System.Drawing.Color.Indigo;
            this.pnl_andromeda.Controls.Add(this.lbl_andromeda);
            this.pnl_andromeda.Controls.Add(this.ptb_andromeda);
            this.pnl_andromeda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_andromeda.Location = new System.Drawing.Point(0, 0);
            this.pnl_andromeda.Name = "pnl_andromeda";
            this.pnl_andromeda.Size = new System.Drawing.Size(280, 455);
            this.pnl_andromeda.TabIndex = 0;
            // 
            // lbl_andromeda
            // 
            this.lbl_andromeda.AutoSize = true;
            this.lbl_andromeda.Font = new System.Drawing.Font("Nasalization Rg", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_andromeda.Location = new System.Drawing.Point(8, 299);
            this.lbl_andromeda.Name = "lbl_andromeda";
            this.lbl_andromeda.Size = new System.Drawing.Size(264, 39);
            this.lbl_andromeda.TabIndex = 13;
            this.lbl_andromeda.Text = "ANDROMEDA";
            // 
            // ptb_andromeda
            // 
            this.ptb_andromeda.Image = global::Ejemplo2.Properties.Resources.andromeda;
            this.ptb_andromeda.Location = new System.Drawing.Point(33, 88);
            this.ptb_andromeda.Name = "ptb_andromeda";
            this.ptb_andromeda.Size = new System.Drawing.Size(208, 208);
            this.ptb_andromeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_andromeda.TabIndex = 12;
            this.ptb_andromeda.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(537, 34);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(120, 39);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "LOGIN";
            // 
            // btn_acceder
            // 
            this.btn_acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btn_acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acceder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_acceder.FlatAppearance.BorderSize = 0;
            this.btn_acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acceder.ForeColor = System.Drawing.Color.LightGray;
            this.btn_acceder.Location = new System.Drawing.Point(386, 329);
            this.btn_acceder.Name = "btn_acceder";
            this.btn_acceder.Size = new System.Drawing.Size(408, 40);
            this.btn_acceder.TabIndex = 5;
            this.btn_acceder.Text = "ACCEDER";
            this.btn_acceder.UseVisualStyleBackColor = false;
            this.btn_acceder.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contraseña.Location = new System.Drawing.Point(386, 264);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(408, 20);
            this.txt_contraseña.TabIndex = 4;
            this.txt_contraseña.Text = "CONTRASEÑA";
            this.txt_contraseña.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txt_contraseña.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.txt_usuario.Location = new System.Drawing.Point(386, 160);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(408, 20);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.Text = "USUARIO";
            this.txt_usuario.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btnMinimizar.Location = new System.Drawing.Point(848, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(836, 388);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(52, 50);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 12;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_id_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_empleado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_id_empleado.ForeColor = System.Drawing.Color.DimGray;
            this.txt_id_empleado.Location = new System.Drawing.Point(386, 110);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(408, 20);
            this.txt_id_empleado.TabIndex = 2;
            this.txt_id_empleado.Text = "ID EMPLEADO";
            this.txt_id_empleado.Enter += new System.EventHandler(this.txtidentidad_Enter);
            this.txt_id_empleado.Leave += new System.EventHandler(this.txtidentidad_Leave);
            // 
            // txtcopiar
            // 
            this.txtcopiar.Enabled = false;
            this.txtcopiar.Location = new System.Drawing.Point(544, 465);
            this.txtcopiar.Name = "txtcopiar";
            this.txtcopiar.Size = new System.Drawing.Size(100, 20);
            this.txtcopiar.TabIndex = 14;
            this.txtcopiar.Visible = false;
            // 
            // cmb_tipo_empleado
            // 
            this.cmb_tipo_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_tipo_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_tipo_empleado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmb_tipo_empleado.ForeColor = System.Drawing.Color.LightGray;
            this.cmb_tipo_empleado.FormattingEnabled = true;
            this.cmb_tipo_empleado.Items.AddRange(new object[] {
            "Agente Universal",
            "Supervisor"});
            this.cmb_tipo_empleado.Location = new System.Drawing.Point(386, 209);
            this.cmb_tipo_empleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_tipo_empleado.Name = "cmb_tipo_empleado";
            this.cmb_tipo_empleado.Size = new System.Drawing.Size(409, 29);
            this.cmb_tipo_empleado.TabIndex = 15;
            this.cmb_tipo_empleado.Enter += new System.EventHandler(this.cmb_temple_Enter);
            this.cmb_tipo_empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_temple_KeyPress);
            this.cmb_tipo_empleado.Leave += new System.EventHandler(this.cmb_temple_Leave);
            // 
            // frm_inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(900, 455);
            this.Controls.Add(this.cmb_tipo_empleado);
            this.Controls.Add(this.txt_id_empleado);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btn_acceder);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.pnl_andromeda);
            this.Controls.Add(this.txtcopiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_inicio_sesion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.pnl_andromeda.ResumeLayout(false);
            this.pnl_andromeda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_andromeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_andromeda;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_acceder;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox ptb_andromeda;
        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.Label lbl_andromeda;
        public System.Windows.Forms.TextBox txtcopiar;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.ComboBox cmb_tipo_empleado;
    }
}