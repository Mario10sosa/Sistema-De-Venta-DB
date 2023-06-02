namespace Presentacion
{
    partial class FrmAgregarUsuario
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtConfirmar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(314, 335);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(68, 47);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(295, 25);
            this.TxtNombre.TabIndex = 33;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(68, 102);
            this.TxtApellido.Multiline = true;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(295, 25);
            this.TxtApellido.TabIndex = 35;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Apellido:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(70, 155);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(295, 25);
            this.TxtUsuario.TabIndex = 37;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Usuario:";
            // 
            // TxtContra
            // 
            this.TxtContra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.Location = new System.Drawing.Point(69, 213);
            this.TxtContra.Multiline = true;
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.PasswordChar = '*';
            this.TxtContra.Size = new System.Drawing.Size(295, 25);
            this.TxtContra.TabIndex = 39;
            this.TxtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContra_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Contraseña:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(188, 335);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 30);
            this.BtnAgregar.TabIndex = 41;
            this.BtnAgregar.Text = "Crear";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtConfirmar
            // 
            this.TxtConfirmar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmar.Location = new System.Drawing.Point(71, 272);
            this.TxtConfirmar.Multiline = true;
            this.TxtConfirmar.Name = "TxtConfirmar";
            this.TxtConfirmar.PasswordChar = '*';
            this.TxtConfirmar.Size = new System.Drawing.Size(295, 25);
            this.TxtConfirmar.TabIndex = 42;
            this.TxtConfirmar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConfirmar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // FrmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 380);
            this.Controls.Add(this.TxtConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Name = "FrmAgregarUsuario";
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.FrmAgregarUsuario_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtApellido, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtUsuario, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtContra, 0);
            this.Controls.SetChildIndex(this.BtnAgregar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TxtConfirmar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button BtnAgregar;
        public System.Windows.Forms.TextBox TxtConfirmar;
        private System.Windows.Forms.Label label5;
    }
}