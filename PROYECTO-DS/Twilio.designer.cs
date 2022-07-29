namespace MatthiWare.SmsAndCallClient
{
    partial class tw_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tw_frm));
            this.cb_apis = new System.Windows.Forms.ComboBox();
            this.lbl_api = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_body = new System.Windows.Forms.TextBox();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.btn_text = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_update_status = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.txttwilio = new System.Windows.Forms.TextBox();
            this.pic_minus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_apis
            // 
            this.cb_apis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_apis.FormattingEnabled = true;
            this.cb_apis.Location = new System.Drawing.Point(302, 12);
            this.cb_apis.Name = "cb_apis";
            this.cb_apis.Size = new System.Drawing.Size(212, 21);
            this.cb_apis.TabIndex = 0;
            this.cb_apis.SelectedValueChanged += new System.EventHandler(this.cbApis_SelectedValueChanged);
            // 
            // lbl_api
            // 
            this.lbl_api.AutoSize = true;
            this.lbl_api.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_api.Location = new System.Drawing.Point(186, 15);
            this.lbl_api.Name = "lbl_api";
            this.lbl_api.Size = new System.Drawing.Size(110, 13);
            this.lbl_api.TabIndex = 1;
            this.lbl_api.Text = "Select API to use:";
            this.lbl_api.Click += new System.EventHandler(this.lbl_api_Click);
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_from.Location = new System.Drawing.Point(186, 90);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(38, 13);
            this.lbl_from.TabIndex = 4;
            this.lbl_from.Text = "From:";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_to.Location = new System.Drawing.Point(186, 116);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(30, 13);
            this.lbl_to.TabIndex = 5;
            this.lbl_to.Text = "To: ";
            this.lbl_to.Click += new System.EventHandler(this.lbl_to_Click);
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(230, 87);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(284, 20);
            this.txt_from.TabIndex = 6;
            this.txt_from.TextChanged += new System.EventHandler(this.txt_from_TextChanged);
            this.txt_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrom_KeyPress);
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(230, 113);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(284, 20);
            this.txt_to.TabIndex = 7;
            this.txt_to.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            this.txt_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTo_KeyPress);
            // 
            // txt_body
            // 
            this.txt_body.Location = new System.Drawing.Point(189, 157);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(325, 146);
            this.txt_body.TabIndex = 8;
            this.txt_body.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBody_KeyPress);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_msg.Location = new System.Drawing.Point(186, 141);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(65, 13);
            this.lbl_msg.TabIndex = 9;
            this.lbl_msg.Text = "Message: ";
            this.lbl_msg.Click += new System.EventHandler(this.lbl_msg_Click);
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.Color.Crimson;
            this.btn_text.Enabled = false;
            this.btn_text.FlatAppearance.BorderSize = 0;
            this.btn_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_text.Location = new System.Drawing.Point(283, 309);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(141, 23);
            this.btn_text.TabIndex = 10;
            this.btn_text.Text = "SMS";
            this.btn_text.UseVisualStyleBackColor = false;
            this.btn_text.Click += new System.EventHandler(this.btnText_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_status.Location = new System.Drawing.Point(186, 341);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(99, 13);
            this.lbl_status.TabIndex = 12;
            this.lbl_status.Text = "Status: waiting..";
            // 
            // btn_update_status
            // 
            this.btn_update_status.BackColor = System.Drawing.Color.Crimson;
            this.btn_update_status.FlatAppearance.BorderSize = 0;
            this.btn_update_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_update_status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update_status.Location = new System.Drawing.Point(439, 336);
            this.btn_update_status.Name = "btn_update_status";
            this.btn_update_status.Size = new System.Drawing.Size(75, 23);
            this.btn_update_status.TabIndex = 13;
            this.btn_update_status.Text = "Refresh";
            this.btn_update_status.UseVisualStyleBackColor = false;
            this.btn_update_status.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(659, 331);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(52, 50);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 22;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // txttwilio
            // 
            this.txttwilio.Location = new System.Drawing.Point(737, 242);
            this.txttwilio.Name = "txttwilio";
            this.txttwilio.Size = new System.Drawing.Size(100, 20);
            this.txttwilio.TabIndex = 23;
            // 
            // pic_minus
            // 
            this.pic_minus.BackColor = System.Drawing.Color.Transparent;
            this.pic_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minus.Image = global::Ejemplo2.Properties.Resources.minus;
            this.pic_minus.Location = new System.Drawing.Point(669, 12);
            this.pic_minus.Name = "pic_minus";
            this.pic_minus.Size = new System.Drawing.Size(40, 40);
            this.pic_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minus.TabIndex = 24;
            this.pic_minus.TabStop = false;
            this.pic_minus.Click += new System.EventHandler(this.pic_minus_Click);
            // 
            // tw_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(721, 393);
            this.Controls.Add(this.pic_minus);
            this.Controls.Add(this.txttwilio);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_update_status);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_text);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.txt_body);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.lbl_api);
            this.Controls.Add(this.cb_apis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tw_frm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.tw_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_apis;
        private System.Windows.Forms.Label lbl_api;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_body;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_update_status;
        private System.Windows.Forms.PictureBox btn_regresar;
        public System.Windows.Forms.TextBox txttwilio;
        private System.Windows.Forms.PictureBox pic_minus;
    }
}

