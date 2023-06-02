namespace Presentacion.Informen
{
    partial class FrmMostrar_Facturas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datos_Generales = new Presentacion.Informen.Datos_Generales();
            this.sPMostrarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Mostrar_FacturaTableAdapter = new Presentacion.Informen.Datos_GeneralesTableAdapters.SP_Mostrar_FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "Mostrar_Facturas";
            reportDataSource3.Value = this.sPMostrarFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informen.Mostrar_Facturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(967, 896);
            this.reportViewer1.TabIndex = 0;
            // 
            // datos_Generales
            // 
            this.datos_Generales.DataSetName = "Datos_Generales";
            this.datos_Generales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMostrarFacturaBindingSource
            // 
            this.sPMostrarFacturaBindingSource.DataMember = "SP_Mostrar_Factura";
            this.sPMostrarFacturaBindingSource.DataSource = this.datos_Generales;
            // 
            // sP_Mostrar_FacturaTableAdapter
            // 
            this.sP_Mostrar_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrar_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 896);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrar_Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Facturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMostrar_Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPMostrarFacturaBindingSource;
        private Datos_Generales datos_Generales;
        private Datos_GeneralesTableAdapters.SP_Mostrar_FacturaTableAdapter sP_Mostrar_FacturaTableAdapter;
    }
}