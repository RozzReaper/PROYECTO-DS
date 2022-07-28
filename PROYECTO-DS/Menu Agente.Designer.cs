namespace Ejemplo2
{
    partial class menu_agente_universal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_agente_universal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_bienvenido = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_caso = new System.Windows.Forms.Button();
            this.btn_lgncliente = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.txt_import = new System.Windows.Forms.TextBox();
            this.btn_helper = new System.Windows.Forms.PictureBox();
            this.btn_twilio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_helper)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.lbl_bienvenido);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 76);
            this.panel1.TabIndex = 0;
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_bienvenido.Location = new System.Drawing.Point(244, 26);
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(374, 29);
            this.lbl_bienvenido.TabIndex = 0;
            this.lbl_bienvenido.Text = "Bienvenido, Agente Universal";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btn_minimizar.Location = new System.Drawing.Point(848, 7);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(40, 40);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 14;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btn_caso
            // 
            this.btn_caso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_caso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_caso.FlatAppearance.BorderSize = 0;
            this.btn_caso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_caso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_caso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_caso.ForeColor = System.Drawing.Color.LightGray;
            this.btn_caso.Location = new System.Drawing.Point(249, 252);
            this.btn_caso.Name = "btn_caso";
            this.btn_caso.Size = new System.Drawing.Size(408, 40);
            this.btn_caso.TabIndex = 7;
            this.btn_caso.Text = "Creación de Caso";
            this.btn_caso.UseVisualStyleBackColor = false;
            this.btn_caso.Click += new System.EventHandler(this.btnSupervisor_Click);
            // 
            // btn_lgncliente
            // 
            this.btn_lgncliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_lgncliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lgncliente.FlatAppearance.BorderSize = 0;
            this.btn_lgncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lgncliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_lgncliente.ForeColor = System.Drawing.Color.LightGray;
            this.btn_lgncliente.Location = new System.Drawing.Point(249, 195);
            this.btn_lgncliente.Name = "btn_lgncliente";
            this.btn_lgncliente.Size = new System.Drawing.Size(408, 40);
            this.btn_lgncliente.TabIndex = 16;
            this.btn_lgncliente.Text = "Búsqueda de Cliente";
            this.btn_lgncliente.UseVisualStyleBackColor = false;
            this.btn_lgncliente.Click += new System.EventHandler(this.btnlgncliente_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(836, 388);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(52, 50);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 15;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_import
            // 
            this.txt_import.Location = new System.Drawing.Point(403, 132);
            this.txt_import.Name = "txt_import";
            this.txt_import.Size = new System.Drawing.Size(100, 20);
            this.txt_import.TabIndex = 17;
            this.txt_import.Visible = false;
            // 
            // btn_helper
            // 
            this.btn_helper.BackColor = System.Drawing.Color.Transparent;
            this.btn_helper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_helper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_helper.Image = global::Ejemplo2.Properties.Resources.question_mark_circle_icon_152550;
            this.btn_helper.Location = new System.Drawing.Point(12, 389);
            this.btn_helper.Name = "btn_helper";
            this.btn_helper.Size = new System.Drawing.Size(48, 49);
            this.btn_helper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_helper.TabIndex = 18;
            this.btn_helper.TabStop = false;
            this.btn_helper.Click += new System.EventHandler(this.btn_helper_Click);
            // 
            // btn_twilio
            // 
            this.btn_twilio.Location = new System.Drawing.Point(415, 321);
            this.btn_twilio.Name = "btn_twilio";
            this.btn_twilio.Size = new System.Drawing.Size(75, 23);
            this.btn_twilio.TabIndex = 19;
            this.btn_twilio.Text = "Twilio";
            this.btn_twilio.UseVisualStyleBackColor = true;
            this.btn_twilio.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu_agente_universal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btn_twilio);
            this.Controls.Add(this.btn_helper);
            this.Controls.Add(this.txt_import);
            this.Controls.Add(this.btn_lgncliente);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_caso);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu_agente_universal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de registro de llamadas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_helper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_bienvenido;
        private System.Windows.Forms.Button btn_caso;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.Button btn_lgncliente;
        public System.Windows.Forms.TextBox txt_import;
        private System.Windows.Forms.PictureBox btn_helper;
        private System.Windows.Forms.Button btn_twilio;
    }
}