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
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_apis
            // 
            this.cb_apis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_apis.FormattingEnabled = true;
            this.cb_apis.Location = new System.Drawing.Point(110, 12);
            this.cb_apis.Name = "cb_apis";
            this.cb_apis.Size = new System.Drawing.Size(203, 21);
            this.cb_apis.TabIndex = 0;
            this.cb_apis.SelectedValueChanged += new System.EventHandler(this.cbApis_SelectedValueChanged);
            // 
            // lbl_api
            // 
            this.lbl_api.AutoSize = true;
            this.lbl_api.Location = new System.Drawing.Point(12, 15);
            this.lbl_api.Name = "lbl_api";
            this.lbl_api.Size = new System.Drawing.Size(92, 13);
            this.lbl_api.TabIndex = 1;
            this.lbl_api.Text = "Select API to use:";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(12, 90);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(33, 13);
            this.lbl_from.TabIndex = 4;
            this.lbl_from.Text = "From:";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(10, 116);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(26, 13);
            this.lbl_to.TabIndex = 5;
            this.lbl_to.Text = "To: ";
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(51, 87);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(262, 20);
            this.txt_from.TabIndex = 6;
            this.txt_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrom_KeyPress);
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(51, 113);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(262, 20);
            this.txt_to.TabIndex = 7;
            this.txt_to.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            this.txt_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTo_KeyPress);
            // 
            // txt_body
            // 
            this.txt_body.Location = new System.Drawing.Point(15, 157);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(298, 146);
            this.txt_body.TabIndex = 8;
            this.txt_body.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBody_KeyPress);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(12, 141);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(56, 13);
            this.lbl_msg.TabIndex = 9;
            this.lbl_msg.Text = "Message: ";
            // 
            // btn_text
            // 
            this.btn_text.Enabled = false;
            this.btn_text.Location = new System.Drawing.Point(94, 309);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(141, 23);
            this.btn_text.TabIndex = 10;
            this.btn_text.Text = "Sms";
            this.btn_text.UseVisualStyleBackColor = true;
            this.btn_text.Click += new System.EventHandler(this.btnText_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 341);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(82, 13);
            this.lbl_status.TabIndex = 12;
            this.lbl_status.Text = "Status: waiting..";
            // 
            // btn_update_status
            // 
            this.btn_update_status.Location = new System.Drawing.Point(238, 336);
            this.btn_update_status.Name = "btn_update_status";
            this.btn_update_status.Size = new System.Drawing.Size(75, 23);
            this.btn_update_status.TabIndex = 13;
            this.btn_update_status.Text = "Refresh";
            this.btn_update_status.UseVisualStyleBackColor = true;
            this.btn_update_status.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(361, 336);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(52, 50);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 22;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // txttwilio
            // 
            this.txttwilio.Location = new System.Drawing.Point(425, 247);
            this.txttwilio.Name = "txttwilio";
            this.txttwilio.Size = new System.Drawing.Size(100, 20);
            this.txttwilio.TabIndex = 23;
            // 
            // tw_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 393);
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
            this.Name = "tw_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
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
    }
}

