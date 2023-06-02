namespace Presentacion
{
    partial class FrmEditarCliente
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
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId_Cliente = new System.Windows.Forms.TextBox();
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
            this.MTxtTelefono.Location = new System.Drawing.Point(26, 184);
            this.MTxtTelefono.Mask = "000-000-0000";
            this.MTxtTelefono.Name = "MTxtTelefono";
            this.MTxtTelefono.Size = new System.Drawing.Size(223, 27);
            this.MTxtTelefono.TabIndex = 54;
            this.MTxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtTelefono_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(270, 186);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(472, 25);
            this.TxtEmail.TabIndex = 53;
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
            this.BtnEditar.TabIndex = 52;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Email Del Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Telefono:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(324, 118);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(418, 25);
            this.TxtDireccion.TabIndex = 49;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Direccion Del Cliente:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(26, 118);
            this.TxtCedula.Multiline = true;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(281, 25);
            this.TxtCedula.TabIndex = 47;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cedula Del Cliente:";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(270, 54);
            this.TxtNombreCliente.Multiline = true;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(472, 25);
            this.TxtNombreCliente.TabIndex = 42;
            this.TxtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nombre Cliente:";
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCodigoCliente.Enabled = false;
            this.TxtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCliente.Location = new System.Drawing.Point(26, 54);
            this.TxtCodigoCliente.Multiline = true;
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.ReadOnly = true;
            this.TxtCodigoCliente.Size = new System.Drawing.Size(223, 25);
            this.TxtCodigoCliente.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Codigo Cliente:";
            // 
            // TxtId_Cliente
            // 
            this.TxtId_Cliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtId_Cliente.Enabled = false;
            this.TxtId_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId_Cliente.Location = new System.Drawing.Point(220, 23);
            this.TxtId_Cliente.Multiline = true;
            this.TxtId_Cliente.Name = "TxtId_Cliente";
            this.TxtId_Cliente.ReadOnly = true;
            this.TxtId_Cliente.Size = new System.Drawing.Size(29, 25);
            this.TxtId_Cliente.TabIndex = 55;
            this.TxtId_Cliente.Visible = false;
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 278);
            this.Controls.Add(this.TxtId_Cliente);
            this.Controls.Add(this.MTxtTelefono);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.BtnEditar);
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
            this.Name = "FrmEditarCliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.FrmEditarCliente_Load);
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
            this.Controls.SetChildIndex(this.BtnEditar, 0);
            this.Controls.SetChildIndex(this.TxtEmail, 0);
            this.Controls.SetChildIndex(this.MTxtTelefono, 0);
            this.Controls.SetChildIndex(this.TxtId_Cliente, 0);
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
        public System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtCodigoCliente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtId_Cliente;
    }
}