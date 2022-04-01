namespace Ejemplo2
{
    partial class ReporteInformes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteInformes));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.informesDATASET = new Ejemplo2.InformesDATASET();
            this.informesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informesTableAdapter = new Ejemplo2.InformesDATASETTableAdapters.InformesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.informesDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Informe";
            reportDataSource1.Value = this.informesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ejemplo2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(940, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // informesDATASET
            // 
            this.informesDATASET.DataSetName = "InformesDATASET";
            this.informesDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informesBindingSource
            // 
            this.informesBindingSource.DataMember = "Informes";
            this.informesBindingSource.DataSource = this.informesDATASET;
            // 
            // informesTableAdapter
            // 
            this.informesTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReporteInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.ReporteInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informesDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InformesDATASET informesDATASET;
        private System.Windows.Forms.BindingSource informesBindingSource;
        private InformesDATASETTableAdapters.InformesTableAdapter informesTableAdapter;
    }
}