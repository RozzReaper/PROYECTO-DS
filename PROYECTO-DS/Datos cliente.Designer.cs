namespace Ejemplo2
{
    partial class Datos_cliente
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
            this.dgv_hist = new System.Windows.Forms.DataGridView();
            this.dgv_planes = new System.Windows.Forms.DataGridView();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información del cliente";
            // 
            // dgv_hist
            // 
            this.dgv_hist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hist.Location = new System.Drawing.Point(45, 117);
            this.dgv_hist.Name = "dgv_hist";
            this.dgv_hist.Size = new System.Drawing.Size(355, 150);
            this.dgv_hist.TabIndex = 1;
            // 
            // dgv_planes
            // 
            this.dgv_planes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_planes.Location = new System.Drawing.Point(128, 325);
            this.dgv_planes.Name = "dgv_planes";
            this.dgv_planes.Size = new System.Drawing.Size(588, 150);
            this.dgv_planes.TabIndex = 1;
            // 
            // dgv_info
            // 
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(443, 117);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.Size = new System.Drawing.Size(355, 150);
            this.dgv_info.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos de planes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Información general";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Historial crediticio";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(771, 446);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(52, 50);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 21;
            this.btn_regresar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Ejemplo2.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(784, 20);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btnMinimizar.Location = new System.Drawing.Point(741, 20);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            // 
            // Datos_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 511);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.dgv_planes);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.dgv_hist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Datos_cliente";
            this.Text = "Datos_cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hist;
        private System.Windows.Forms.DataGridView dgv_planes;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}