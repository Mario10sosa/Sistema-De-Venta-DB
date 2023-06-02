namespace Presentacion
{
    partial class FrmAgregarProveedor
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
            this.BtnAgregar = new System.Windows.Forms.Button();
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
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.MTxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(663, 233);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(537, 233);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 30);
            this.BtnAgregar.TabIndex = 26;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Email Del Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telefono:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(341, 113);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(418, 25);
            this.TxtDireccion.TabIndex = 21;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Direccion Del Proveedor:";
            // 
            // TxtNit
            // 
            this.TxtNit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNit.Location = new System.Drawing.Point(43, 113);
            this.TxtNit.Multiline = true;
            this.TxtNit.Name = "TxtNit";
            this.TxtNit.Size = new System.Drawing.Size(281, 25);
            this.TxtNit.TabIndex = 19;
            this.TxtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nit Del Proveedor:";
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProveedor.Location = new System.Drawing.Point(287, 49);
            this.TxtNombreProveedor.Multiline = true;
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(472, 25);
            this.TxtNombreProveedor.TabIndex = 14;
            this.TxtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Proveedor:";
            // 
            // TxtCodigoProveedor
            // 
            this.TxtCodigoProveedor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCodigoProveedor.Enabled = false;
            this.TxtCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProveedor.Location = new System.Drawing.Point(43, 49);
            this.TxtCodigoProveedor.Multiline = true;
            this.TxtCodigoProveedor.Name = "TxtCodigoProveedor";
            this.TxtCodigoProveedor.ReadOnly = true;
            this.TxtCodigoProveedor.Size = new System.Drawing.Size(223, 25);
            this.TxtCodigoProveedor.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo Proveedor:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(287, 181);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(472, 25);
            this.TxtEmail.TabIndex = 27;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // MTxtTelefono
            // 
            this.MTxtTelefono.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MTxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTelefono.Location = new System.Drawing.Point(43, 179);
            this.MTxtTelefono.Mask = "000-000-0000";
            this.MTxtTelefono.Name = "MTxtTelefono";
            this.MTxtTelefono.Size = new System.Drawing.Size(223, 27);
            this.MTxtTelefono.TabIndex = 28;
            this.MTxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtTelefono_KeyPress);
            // 
            // FrmAgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 278);
            this.Controls.Add(this.MTxtTelefono);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.BtnAgregar);
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
            this.Name = "FrmAgregarProveedor";
            this.Text = "Agregar Proveedor";
            this.Load += new System.EventHandler(this.FrmAgregarProveedor_Load);
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
            this.Controls.SetChildIndex(this.BtnAgregar, 0);
            this.Controls.SetChildIndex(this.TxtEmail, 0);
            this.Controls.SetChildIndex(this.MTxtTelefono, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnAgregar;
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
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.MaskedTextBox MTxtTelefono;
    }
}