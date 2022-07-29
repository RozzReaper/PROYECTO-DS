namespace Ejemplo2.Message
{
    partial class MessageCreacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageCreacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_warn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_okc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_txt = new System.Windows.Forms.Label();
            this.pic_warn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_warn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lbl_warn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 49);
            this.panel1.TabIndex = 3;
            // 
            // lbl_warn
            // 
            this.lbl_warn.AutoSize = true;
            this.lbl_warn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warn.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_warn.Location = new System.Drawing.Point(13, 13);
            this.lbl_warn.Name = "lbl_warn";
            this.lbl_warn.Size = new System.Drawing.Size(106, 21);
            this.lbl_warn.TabIndex = 0;
            this.lbl_warn.Text = "¡Precaucion!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btn_okc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 51);
            this.panel2.TabIndex = 4;
            // 
            // btn_okc
            // 
            this.btn_okc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btn_okc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_okc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_okc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okc.ForeColor = System.Drawing.Color.LightGray;
            this.btn_okc.Location = new System.Drawing.Point(149, 12);
            this.btn_okc.Name = "btn_okc";
            this.btn_okc.Size = new System.Drawing.Size(60, 23);
            this.btn_okc.TabIndex = 0;
            this.btn_okc.Text = "Ok";
            this.btn_okc.UseVisualStyleBackColor = false;
            this.btn_okc.Click += new System.EventHandler(this.btnOkC_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.lbl_txt);
            this.panel3.Controls.Add(this.pic_warn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 86);
            this.panel3.TabIndex = 5;
            // 
            // lbl_txt
            // 
            this.lbl_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_txt.Location = new System.Drawing.Point(83, 21);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(249, 47);
            this.lbl_txt.TabIndex = 5;
            this.lbl_txt.Text = "Por favor, ingrese datos  en los campos correspondientes.";
            // 
            // pic_warn
            // 
            this.pic_warn.Image = global::Ejemplo2.Properties.Resources.advertencia;
            this.pic_warn.Location = new System.Drawing.Point(34, 21);
            this.pic_warn.Name = "pic_warn";
            this.pic_warn.Size = new System.Drawing.Size(43, 44);
            this.pic_warn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_warn.TabIndex = 0;
            this.pic_warn.TabStop = false;
            // 
            // MessageCreacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 186);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageCreacion";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageCreacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_warn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_warn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_okc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_txt;
        private System.Windows.Forms.PictureBox pic_warn;
    }
}