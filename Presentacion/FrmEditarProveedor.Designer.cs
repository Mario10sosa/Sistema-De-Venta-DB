namespace Presentacion
{
    partial class FrmEditarProveedor
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
            this.MTxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId_Proveedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(663, 233);
            this.BtnCancelar.TabIndex = 29;
            // 
            // MTxtTelefono
            // 
            this.MTxtTelefono.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MTxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTelefono.Location = new System.Drawing.Point(43, 178);
            this.MTxtTelefono.Mask = "000-000-0000";
            this.MTxtTelefono.Name = "MTxtTelefono";
            this.MTxtTelefono.Size = new System.Drawing.Size(223, 27);
            this.MTxtTelefono.TabIndex = 41;
            this.MTxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtTelefono_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(287, 180);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(472, 25);
            this.TxtEmail.TabIndex = 40;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.Azure;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(537, 233);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 30);
            this.BtnEditar.TabIndex = 39;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email Del Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Costo Unitario:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(341, 112);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(418, 25);
            this.TxtDireccion.TabIndex = 36;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Direccion Del Proveedor:";
            // 
            // TxtNit
            // 
            this.TxtNit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNit.Location = new System.Drawing.Point(43, 112);
            this.TxtNit.Multiline = true;
            this.TxtNit.Name = "TxtNit";
            this.TxtNit.Size = new System.Drawing.Size(281, 25);
            this.TxtNit.TabIndex = 34;
            this.TxtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nit Del Proveedor:";
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProveedor.Location = new System.Drawing.Point(287, 48);
            this.TxtNombreProveedor.Multiline = true;
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(472, 25);
            this.TxtNombreProveedor.TabIndex = 0;
            this.TxtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre Proveedor:";
            // 
            // TxtCodigoProveedor
            // 
            this.TxtCodigoProveedor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCodigoProveedor.Enabled = false;
            this.TxtCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProveedor.Location = new System.Drawing.Point(43, 48);
            this.TxtCodigoProveedor.Multiline = true;
            this.TxtCodigoProveedor.Name = "TxtCodigoProveedor";
            this.TxtCodigoProveedor.ReadOnly = true;
            this.TxtCodigoProveedor.Size = new System.Drawing.Size(223, 25);
            this.TxtCodigoProveedor.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Codigo Proveedor:";
            // 
            // TxtId_Proveedor
            // 
            this.TxtId_Proveedor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtId_Proveedor.Enabled = false;
            this.TxtId_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId_Proveedor.Location = new System.Drawing.Point(223, 20);
            this.TxtId_Proveedor.Multiline = true;
            this.TxtId_Proveedor.Name = "TxtId_Proveedor";
            this.TxtId_Proveedor.ReadOnly = true;
            this.TxtId_Proveedor.Size = new System.Drawing.Size(43, 25);
            this.TxtId_Proveedor.TabIndex = 42;
            this.TxtId_Proveedor.Visible = false;
            // 
            // FrmEditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 278);
            this.Controls.Add(this.TxtId_Proveedor);
            this.Controls.Add(this.MTxtTelefono);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigoProveedor);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarProveedor";
            this.Text = "Editar Proveedor";
            this.Load += new System.EventHandler(this.FrmEditarProveedor_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtCodigoProveedor, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNombreProveedor, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtNit, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtDireccion, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.BtnEditar, 0);
            this.Controls.SetChildIndex(this.TxtEmail, 0);
            this.Controls.SetChildIndex(this.MTxtTelefono, 0);
            this.Controls.SetChildIndex(this.TxtId_Proveedor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox MTxtTelefono;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtNit;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtCodigoProveedor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtId_Proveedor;
    }
}