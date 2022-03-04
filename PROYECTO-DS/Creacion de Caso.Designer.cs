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
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(936, 538);
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
            this.btnMinimizar.Location = new System.Drawing.Point(948, 12);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Creación de Caso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Categoría";
            // 
            // Descripción
            // 
            this.Descripción.AutoSize = true;
            this.Descripción.Location = new System.Drawing.Point(299, 290);
            this.Descripción.Name = "Descripción";
            this.Descripción.Size = new System.Drawing.Size(63, 13);
            this.Descripción.TabIndex = 25;
            this.Descripción.Text = "Descripción";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(92, 236);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "fecha (Año, mes, día)";
            // 
            // txtidemple
            // 
            this.txtidemple.Location = new System.Drawing.Point(92, 146);
            this.txtidemple.Name = "txtidemple";
            this.txtidemple.Size = new System.Drawing.Size(100, 20);
            this.txtidemple.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
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
            this.cmb_cate.Location = new System.Drawing.Point(293, 146);
            this.cmb_cate.Name = "cmb_cate";
            this.cmb_cate.Size = new System.Drawing.Size(129, 21);
            this.cmb_cate.TabIndex = 26;
            this.cmb_cate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtins
            // 
            this.txtins.Location = new System.Drawing.Point(452, 538);
            this.txtins.Name = "txtins";
            this.txtins.Size = new System.Drawing.Size(75, 23);
            this.txtins.TabIndex = 27;
            this.txtins.Text = "Insertar";
            this.txtins.UseVisualStyleBackColor = true;
            this.txtins.Click += new System.EventHandler(this.txtins_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(302, 332);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(367, 119);
            this.txt_desc.TabIndex = 29;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txtins);
            this.Controls.Add(this.cmb_cate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtidemple);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.Descripción);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btnMinimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creacion de Caso";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
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
    }
}