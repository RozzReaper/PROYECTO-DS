namespace Ejemplo2
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCaso = new System.Windows.Forms.Button();
            this.btnlgncliente = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.txtimport = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nasalization Rg", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(244, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido, Agente Universal";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btnMinimizar.Location = new System.Drawing.Point(848, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCaso
            // 
            this.btnCaso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCaso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaso.FlatAppearance.BorderSize = 0;
            this.btnCaso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCaso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaso.ForeColor = System.Drawing.Color.LightGray;
            this.btnCaso.Location = new System.Drawing.Point(249, 252);
            this.btnCaso.Name = "btnCaso";
            this.btnCaso.Size = new System.Drawing.Size(408, 40);
            this.btnCaso.TabIndex = 7;
            this.btnCaso.Text = "Creación de Caso";
            this.btnCaso.UseVisualStyleBackColor = false;
            this.btnCaso.Click += new System.EventHandler(this.btnSupervisor_Click);
            // 
            // btnlgncliente
            // 
            this.btnlgncliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnlgncliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlgncliente.FlatAppearance.BorderSize = 0;
            this.btnlgncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlgncliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnlgncliente.ForeColor = System.Drawing.Color.LightGray;
            this.btnlgncliente.Location = new System.Drawing.Point(249, 195);
            this.btnlgncliente.Name = "btnlgncliente";
            this.btnlgncliente.Size = new System.Drawing.Size(408, 40);
            this.btnlgncliente.TabIndex = 16;
            this.btnlgncliente.Text = "Búsqueda de Cliente";
            this.btnlgncliente.UseVisualStyleBackColor = false;
            this.btnlgncliente.Click += new System.EventHandler(this.btnlgncliente_Click);
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
            // txtimport
            // 
            this.txtimport.Location = new System.Drawing.Point(387, 132);
            this.txtimport.Name = "txtimport";
            this.txtimport.Size = new System.Drawing.Size(100, 20);
            this.txtimport.TabIndex = 17;
            this.txtimport.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.txtimport);
            this.Controls.Add(this.btnlgncliente);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btnCaso);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de registro de llamadas";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaso;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.Button btnlgncliente;
        public System.Windows.Forms.TextBox txtimport;
    }
}