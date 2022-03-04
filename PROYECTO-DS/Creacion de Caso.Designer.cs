namespace Ejemplo2
{
    partial class Form7
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
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Descripción = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidemple = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_cate = new System.Windows.Forms.ComboBox();
            this.txtins = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(764, 437);
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
            this.btnMinimizar.Location = new System.Drawing.Point(776, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nasalization Rg", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(259, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "Creación de Caso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(239, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Categoría";
            // 
            // Descripción
            // 
            this.Descripción.AutoSize = true;
            this.Descripción.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Descripción.Location = new System.Drawing.Point(239, 192);
            this.Descripción.Name = "Descripción";
            this.Descripción.Size = new System.Drawing.Size(89, 19);
            this.Descripción.TabIndex = 25;
            this.Descripción.Text = "Descripción";
            // 
            // txtfecha
            // 
            this.txtfecha.ForeColor = System.Drawing.Color.Gray;
            this.txtfecha.Location = new System.Drawing.Point(41, 223);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(157, 20);
            this.txtfecha.TabIndex = 24;
            this.txtfecha.Text = "YYYY-MM-DD";
            this.txtfecha.TextChanged += new System.EventHandler(this.txtfecha_TextChanged);
            this.txtfecha.Enter += new System.EventHandler(this.txtfecha_Enter);
            this.txtfecha.Leave += new System.EventHandler(this.txtfecha_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(38, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha (Año, mes, día)";
            // 
            // txtidemple
            // 
            this.txtidemple.Location = new System.Drawing.Point(41, 143);
            this.txtidemple.Name = "txtidemple";
            this.txtidemple.Size = new System.Drawing.Size(119, 20);
            this.txtidemple.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(38, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Id de empleado";
            // 
            // cmb_cate
            // 
            this.cmb_cate.FormattingEnabled = true;
            this.cmb_cate.Items.AddRange(new object[] {
            "Problemas de conexión",
            "Internet lento",
            "Fecha de instalación",
            "Dia de pago"});
            this.cmb_cate.Location = new System.Drawing.Point(242, 143);
            this.cmb_cate.Name = "cmb_cate";
            this.cmb_cate.Size = new System.Drawing.Size(129, 21);
            this.cmb_cate.TabIndex = 26;
            this.cmb_cate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtins
            // 
            this.txtins.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtins.Location = new System.Drawing.Point(371, 437);
            this.txtins.Name = "txtins";
            this.txtins.Size = new System.Drawing.Size(94, 31);
            this.txtins.TabIndex = 27;
            this.txtins.Text = "Insertar";
            this.txtins.UseVisualStyleBackColor = true;
            this.txtins.Click += new System.EventHandler(this.txtins_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(242, 223);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(367, 119);
            this.txt_desc.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 64);
            this.panel1.TabIndex = 30;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 499);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txtins);
            this.Controls.Add(this.cmb_cate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtidemple);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.Descripción);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creacion de Caso";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Descripción;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidemple;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_cate;
        private System.Windows.Forms.Button txtins;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Panel panel1;
    }
}