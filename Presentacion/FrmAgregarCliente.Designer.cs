namespace Presentacion
{
    partial class FrmAgregarCliente
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(663, 233);
            // 
            // MTxtTelefono
            // 
            this.MTxtTelefono.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MTxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTelefono.Location = new System.Drawing.Point(43, 179);
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
            this.TxtEmail.Location = new System.Drawing.Point(287, 181);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(472, 25);
            this.TxtEmail.TabIndex = 40;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
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
            this.BtnAgregar.TabIndex = 39;
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
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email Del Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 37;
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
            this.TxtDireccion.TabIndex = 36;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Direccion Del Cliente:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(43, 113);
            this.TxtCedula.Multiline = true;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(281, 25);
            this.TxtCedula.TabIndex = 34;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cedula Del Cliente:";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(287, 49);
            this.TxtNombreCliente.Multiline = true;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(472, 25);
            this.TxtNombreCliente.TabIndex = 29;
            this.TxtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre Cliente:";
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCodigoCliente.Enabled = false;
            this.TxtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCliente.Location = new System.Drawing.Point(43, 49);
            this.TxtCodigoCliente.Multiline = true;
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.ReadOnly = true;
            this.TxtCodigoCliente.Size = new System.Drawing.Size(223, 25);
            this.TxtCodigoCliente.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Codigo Cliente:";
            // 
            // FrmAgregarCliente
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
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigoCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarCliente";
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.FrmAgregarCliente_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtCodigoCliente, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNombreCliente, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtCedula, 0);
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

        public System.Windows.Forms.MaskedTextBox MTxtTelefono;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtCodigoCliente;
        private System.Windows.Forms.Label label1;
    }
}