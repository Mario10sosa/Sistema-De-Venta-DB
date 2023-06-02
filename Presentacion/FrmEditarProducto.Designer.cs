namespace Presentacion
{
    partial class FrmEditarProducto
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
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCostoUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPresentacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId_Producto = new System.Windows.Forms.TextBox();
            this.TxtCodBarra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTipoCargo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(690, 233);
            this.BtnCancelar.TabIndex = 14;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.Azure;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(564, 233);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 30);
            this.BtnEditar.TabIndex = 26;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVenta.Location = new System.Drawing.Point(280, 187);
            this.TxtPrecioVenta.Multiline = true;
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(222, 25);
            this.TxtPrecioVenta.TabIndex = 25;
            this.TxtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioVenta_KeyPress);
            this.TxtPrecioVenta.Leave += new System.EventHandler(this.TxtPrecioVenta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Precio Venta:";
            // 
            // TxtCostoUnitario
            // 
            this.TxtCostoUnitario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCostoUnitario.Location = new System.Drawing.Point(36, 187);
            this.TxtCostoUnitario.Multiline = true;
            this.TxtCostoUnitario.Name = "TxtCostoUnitario";
            this.TxtCostoUnitario.Size = new System.Drawing.Size(223, 25);
            this.TxtCostoUnitario.TabIndex = 23;
            this.TxtCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCostoUnitario_KeyPress);
            this.TxtCostoUnitario.Leave += new System.EventHandler(this.TxtCostoUnitario_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Costo Unitario:";
            // 
            // TxtPresentacion
            // 
            this.TxtPresentacion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPresentacion.Location = new System.Drawing.Point(408, 123);
            this.TxtPresentacion.Multiline = true;
            this.TxtPresentacion.Name = "TxtPresentacion";
            this.TxtPresentacion.Size = new System.Drawing.Size(344, 25);
            this.TxtPresentacion.TabIndex = 21;
            this.TxtPresentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPresentacion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Presentacion Producto:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(36, 123);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(353, 25);
            this.TxtDescripcion.TabIndex = 19;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descripcion Producto:";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(470, 59);
            this.TxtNombreProducto.Multiline = true;
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(344, 25);
            this.TxtNombreProducto.TabIndex = 28;
            this.TxtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreProducto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Producto:";
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCodigoProducto.Enabled = false;
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(36, 59);
            this.TxtCodigoProducto.Multiline = true;
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.ReadOnly = true;
            this.TxtCodigoProducto.Size = new System.Drawing.Size(223, 25);
            this.TxtCodigoProducto.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo Producto:";
            // 
            // TxtId_Producto
            // 
            this.TxtId_Producto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtId_Producto.Enabled = false;
            this.TxtId_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId_Producto.Location = new System.Drawing.Point(224, 31);
            this.TxtId_Producto.Multiline = true;
            this.TxtId_Producto.Name = "TxtId_Producto";
            this.TxtId_Producto.ReadOnly = true;
            this.TxtId_Producto.Size = new System.Drawing.Size(35, 25);
            this.TxtId_Producto.TabIndex = 27;
            this.TxtId_Producto.Visible = false;
            // 
            // TxtCodBarra
            // 
            this.TxtCodBarra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodBarra.Location = new System.Drawing.Point(265, 59);
            this.TxtCodBarra.Multiline = true;
            this.TxtCodBarra.Name = "TxtCodBarra";
            this.TxtCodBarra.Size = new System.Drawing.Size(199, 25);
            this.TxtCodBarra.TabIndex = 0;
            this.TxtCodBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodBarra_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Codigo De Barra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tipo De Cargo:";
            // 
            // cboTipoCargo
            // 
            this.cboTipoCargo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cboTipoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoCargo.FormattingEnabled = true;
            this.cboTipoCargo.Items.AddRange(new object[] {
            "ITBIS 16%",
            "ITBIS 18%",
            "Exento"});
            this.cboTipoCargo.Location = new System.Drawing.Point(532, 184);
            this.cboTipoCargo.Name = "cboTipoCargo";
            this.cboTipoCargo.Size = new System.Drawing.Size(220, 28);
            this.cboTipoCargo.TabIndex = 30;
            this.cboTipoCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipoCargo_KeyPress);
            // 
            // FrmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 278);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboTipoCargo);
            this.Controls.Add(this.TxtCodBarra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtId_Producto);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtPrecioVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCostoUnitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPresentacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigoProducto);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarProducto";
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.FrmEditarProducto_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtCodigoProducto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNombreProducto, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtDescripcion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtPresentacion, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TxtCostoUnitario, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtPrecioVenta, 0);
            this.Controls.SetChildIndex(this.BtnEditar, 0);
            this.Controls.SetChildIndex(this.TxtId_Producto, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.TxtCodBarra, 0);
            this.Controls.SetChildIndex(this.cboTipoCargo, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnEditar;
        public System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtCostoUnitario;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtPresentacion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtId_Producto;
        public System.Windows.Forms.TextBox TxtCodBarra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cboTipoCargo;
    }
}