namespace Ejemplo2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_acceder_login = new System.Windows.Forms.Panel();
            this.btn_helper = new System.Windows.Forms.PictureBox();
            this.lbl_bienvenidos = new System.Windows.Forms.Label();
            this.pic_minus = new System.Windows.Forms.PictureBox();
            this.pic_x = new System.Windows.Forms.PictureBox();
            this.btn_agente = new System.Windows.Forms.Button();
            this.panel_acceder_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_helper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_x)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_acceder_login
            // 
            this.panel_acceder_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            this.panel_acceder_login.BackgroundImage = global::Ejemplo2.Properties.Resources.BANNER;
            this.panel_acceder_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_acceder_login.Controls.Add(this.btn_helper);
            this.panel_acceder_login.Controls.Add(this.lbl_bienvenidos);
            this.panel_acceder_login.Controls.Add(this.pic_minus);
            this.panel_acceder_login.Controls.Add(this.pic_x);
            this.panel_acceder_login.Controls.Add(this.btn_agente);
            this.panel_acceder_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_acceder_login.Location = new System.Drawing.Point(0, 0);
            this.panel_acceder_login.Name = "panel_acceder_login";
            this.panel_acceder_login.Size = new System.Drawing.Size(1260, 427);
            this.panel_acceder_login.TabIndex = 14;
            // 
            // btn_helper
            // 
            this.btn_helper.BackColor = System.Drawing.Color.Transparent;
            this.btn_helper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_helper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_helper.Image = global::Ejemplo2.Properties.Resources.question_mark_circle_icon_152550;
            this.btn_helper.Location = new System.Drawing.Point(1200, 366);
            this.btn_helper.Name = "btn_helper";
            this.btn_helper.Size = new System.Drawing.Size(48, 49);
            this.btn_helper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_helper.TabIndex = 15;
            this.btn_helper.TabStop = false;
            this.btn_helper.Click += new System.EventHandler(this.btn_helper_Click);
            // 
            // lbl_bienvenidos
            // 
            this.lbl_bienvenidos.AutoSize = true;
            this.lbl_bienvenidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            this.lbl_bienvenidos.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.lbl_bienvenidos.ForeColor = System.Drawing.Color.White;
            this.lbl_bienvenidos.Location = new System.Drawing.Point(227, 123);
            this.lbl_bienvenidos.Name = "lbl_bienvenidos";
            this.lbl_bienvenidos.Size = new System.Drawing.Size(243, 45);
            this.lbl_bienvenidos.TabIndex = 1;
            this.lbl_bienvenidos.Text = "Bienvenidos";
            // 
            // pic_minus
            // 
            this.pic_minus.BackColor = System.Drawing.Color.Transparent;
            this.pic_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minus.Image = global::Ejemplo2.Properties.Resources.minus;
            this.pic_minus.Location = new System.Drawing.Point(1161, 12);
            this.pic_minus.Name = "pic_minus";
            this.pic_minus.Size = new System.Drawing.Size(40, 40);
            this.pic_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minus.TabIndex = 13;
            this.pic_minus.TabStop = false;
            this.pic_minus.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic_x
            // 
            this.pic_x.BackColor = System.Drawing.Color.Transparent;
            this.pic_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_x.Image = global::Ejemplo2.Properties.Resources.close;
            this.pic_x.Location = new System.Drawing.Point(1207, 12);
            this.pic_x.Name = "pic_x";
            this.pic_x.Size = new System.Drawing.Size(41, 40);
            this.pic_x.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_x.TabIndex = 12;
            this.pic_x.TabStop = false;
            this.pic_x.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_agente
            // 
            this.btn_agente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(13)))), ((int)(((byte)(63)))));
            this.btn_agente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agente.FlatAppearance.BorderSize = 0;
            this.btn_agente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_agente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agente.ForeColor = System.Drawing.Color.White;
            this.btn_agente.Location = new System.Drawing.Point(192, 314);
            this.btn_agente.Name = "btn_agente";
            this.btn_agente.Size = new System.Drawing.Size(312, 40);
            this.btn_agente.TabIndex = 4;
            this.btn_agente.Text = "Acceder Login";
            this.btn_agente.UseVisualStyleBackColor = false;
            this.btn_agente.Click += new System.EventHandler(this.btnAgente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1260, 427);
            this.Controls.Add(this.panel_acceder_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.panel_acceder_login.ResumeLayout(false);
            this.panel_acceder_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_helper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_x)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_bienvenidos;
        private System.Windows.Forms.PictureBox pic_minus;
        private System.Windows.Forms.PictureBox pic_x;
        private System.Windows.Forms.Button btn_agente;
        private System.Windows.Forms.Panel panel_acceder_login;
        private System.Windows.Forms.PictureBox btn_helper;
    }
}

