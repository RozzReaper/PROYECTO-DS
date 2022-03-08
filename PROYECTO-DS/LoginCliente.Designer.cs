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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginClientes = new System.Windows.Forms.Button();
            this.dgvsiu = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nasalization Rg", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda de cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(120, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(120, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clave";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(123, 220);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(331, 20);
            this.txtname.TabIndex = 2;
            // 
            // txtcel
            // 
            this.txtcel.Location = new System.Drawing.Point(123, 276);
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(186, 20);
            this.txtcel.TabIndex = 3;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(123, 332);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(166, 20);
            this.txt_clave.TabIndex = 1;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(534, 448);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(52, 50);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 21;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btnMinimizar.Location = new System.Drawing.Point(546, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 86);
            this.panel1.TabIndex = 22;
            // 
            // btnLoginClientes
            // 
            this.btnLoginClientes.Location = new System.Drawing.Point(253, 463);
            this.btnLoginClientes.Name = "btnLoginClientes";
            this.btnLoginClientes.Size = new System.Drawing.Size(75, 23);
            this.btnLoginClientes.TabIndex = 23;
            this.btnLoginClientes.Text = "Ingresar";
            this.btnLoginClientes.UseVisualStyleBackColor = true;
            this.btnLoginClientes.Click += new System.EventHandler(this.btnLoginClientes_Click);
            // 
            // dgvsiu
            // 
            this.dgvsiu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsiu.Location = new System.Drawing.Point(315, 276);
            this.dgvsiu.Name = "dgvsiu";
            this.dgvsiu.Size = new System.Drawing.Size(240, 150);
            this.dgvsiu.TabIndex = 24;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(132, 463);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 25;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.txtbuscar_Click);
            // 
            // LoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(598, 510);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgvsiu);
            this.Controls.Add(this.btnLoginClientes);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginCliente";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCliente";
            this.Load += new System.EventHandler(this.LoginCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoginClientes;
        private System.Windows.Forms.DataGridView dgvsiu;
        private System.Windows.Forms.Button btnbuscar;
    }
}