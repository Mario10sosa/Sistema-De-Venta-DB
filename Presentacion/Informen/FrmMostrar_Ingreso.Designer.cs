namespace Presentacion.Informen
{
    partial class FrmMostrar_Ingreso
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
            this.mostrarIngresoProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosGeneralesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_Generales = new Presentacion.Informen.Datos_Generales();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Mostrar_Ingreso_ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrar_Ingreso_ProductosTableAdapter = new Presentacion.Informen.Datos_GeneralesTableAdapters.Mostrar_Ingreso_ProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarIngresoProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGeneralesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Ingreso_ProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarIngresoProductosBindingSource
            // 
            this.mostrarIngresoProductosBindingSource.DataMember = "Mostrar_Ingreso_Productos";
            this.mostrarIngresoProductosBindingSource.DataSource = this.datosGeneralesBindingSource;
            // 
            // datosGeneralesBindingSource
            // 
            this.datosGeneralesBindingSource.DataSource = this.datos_Generales;
            this.datosGeneralesBindingSource.Position = 0;
            // 
            // datos_Generales
            // 
            this.datos_Generales.DataSetName = "Datos_Generales";
            this.datos_Generales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Mostrar_Ingreso_Productos";
            reportDataSource1.Value = this.mostrarIngresoProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informen.Mostrar_Ingreso_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(978, 896);
            this.reportViewer1.TabIndex = 0;
            // 
            // Mostrar_Ingreso_ProductosBindingSource
            // 
            this.Mostrar_Ingreso_ProductosBindingSource.DataMember = "Mostrar_Ingreso_Productos";
            this.Mostrar_Ingreso_ProductosBindingSource.DataSource = this.datos_Generales;
            // 
            // mostrar_Ingreso_ProductosTableAdapter
            // 
            this.mostrar_Ingreso_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrar_Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 896);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrar_Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrar_Ingreso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMostrar_Ingreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarIngresoProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGeneralesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Generales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Ingreso_ProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosGeneralesBindingSource;
        private Datos_Generales datos_Generales;
        private System.Windows.Forms.BindingSource Mostrar_Ingreso_ProductosBindingSource;
        private System.Windows.Forms.BindingSource mostrarIngresoProductosBindingSource;
        private Datos_GeneralesTableAdapters.Mostrar_Ingreso_ProductosTableAdapter mostrar_Ingreso_ProductosTableAdapter;
    }
}