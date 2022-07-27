namespace Ejemplo2
{
    partial class frm_examinacion_informe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_examinacion_informe));
            this.btn_regresar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.lbl_examinacion_caso = new System.Windows.Forms.Label();
            this.dgv_casos = new System.Windows.Forms.DataGridView();
            this.pnl_examinacion_caso = new System.Windows.Forms.Panel();
            this.btn_generar_reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_casos)).BeginInit();
            this.pnl_examinacion_caso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Image = global::Ejemplo2.Properties.Resources._return;
            this.btn_regresar.Location = new System.Drawing.Point(1648, 562);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(69, 55);
            this.btn_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_regresar.TabIndex = 18;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Ejemplo2.Properties.Resources.minus;
            this.btn_minimizar.Location = new System.Drawing.Point(1664, 15);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(53, 49);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 17;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lbl_examinacion_caso
            // 
            this.lbl_examinacion_caso.AutoSize = true;
            this.lbl_examinacion_caso.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_examinacion_caso.Location = new System.Drawing.Point(696, 30);
            this.lbl_examinacion_caso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_examinacion_caso.Name = "lbl_examinacion_caso";
            this.lbl_examinacion_caso.Size = new System.Drawing.Size(336, 37);
            this.lbl_examinacion_caso.TabIndex = 23;
            this.lbl_examinacion_caso.Text = "Examinación de Caso";
            this.lbl_examinacion_caso.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_casos
            // 
            this.dgv_casos.AllowUserToAddRows = false;
            this.dgv_casos.AllowUserToDeleteRows = false;
            this.dgv_casos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_casos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_casos.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgv_casos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_casos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_casos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_casos.ColumnHeadersHeight = 30;
            this.dgv_casos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_casos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_casos.EnableHeadersVisualStyles = false;
            this.dgv_casos.GridColor = System.Drawing.Color.BlueViolet;
            this.dgv_casos.Location = new System.Drawing.Point(81, 113);
            this.dgv_casos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_casos.Name = "dgv_casos";
            this.dgv_casos.ReadOnly = true;
            this.dgv_casos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_casos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_casos.RowHeadersWidth = 51;
            this.dgv_casos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_casos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_casos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_casos.Size = new System.Drawing.Size(1559, 442);
            this.dgv_casos.TabIndex = 1;
            this.dgv_casos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_casos_CellContentClick);
            // 
            // pnl_examinacion_caso
            // 
            this.pnl_examinacion_caso.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnl_examinacion_caso.Controls.Add(this.lbl_examinacion_caso);
            this.pnl_examinacion_caso.Controls.Add(this.btn_minimizar);
            this.pnl_examinacion_caso.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_examinacion_caso.Location = new System.Drawing.Point(0, 0);
            this.pnl_examinacion_caso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_examinacion_caso.Name = "pnl_examinacion_caso";
            this.pnl_examinacion_caso.Size = new System.Drawing.Size(1733, 91);
            this.pnl_examinacion_caso.TabIndex = 24;
            this.pnl_examinacion_caso.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btn_generar_reporte
            // 
            this.btn_generar_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btn_generar_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generar_reporte.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_generar_reporte.FlatAppearance.BorderSize = 0;
            this.btn_generar_reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_generar_reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_generar_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar_reporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_generar_reporte.ForeColor = System.Drawing.Color.LightGray;
            this.btn_generar_reporte.Location = new System.Drawing.Point(604, 562);
            this.btn_generar_reporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_generar_reporte.Name = "btn_generar_reporte";
            this.btn_generar_reporte.Size = new System.Drawing.Size(544, 49);
            this.btn_generar_reporte.TabIndex = 25;
            this.btn_generar_reporte.Text = "GENERAR REPORTE";
            this.btn_generar_reporte.UseVisualStyleBackColor = false;
            this.btn_generar_reporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // frm_examinacion_informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 626);
            this.Controls.Add(this.btn_generar_reporte);
            this.Controls.Add(this.dgv_casos);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.pnl_examinacion_caso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_examinacion_informe";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examinación de informes";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_casos)).EndInit();
            this.pnl_examinacion_caso.ResumeLayout(false);
            this.pnl_examinacion_caso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_regresar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Label lbl_examinacion_caso;
        private System.Windows.Forms.DataGridView dgv_casos;
        private System.Windows.Forms.Panel pnl_examinacion_caso;
        private System.Windows.Forms.Button btn_generar_reporte;
    }
}