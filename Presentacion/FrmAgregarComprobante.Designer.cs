namespace Presentacion
{
    partial class FrmAgregarComprobante
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
            this.TxtNomComprobante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTipoComprobante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCorrelativo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(411, 196);
            this.BtnCancelar.TabIndex = 33;
            // 
            // TxtNomComprobante
            // 
            this.TxtNomComprobante.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNomComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomComprobante.Location = new System.Drawing.Point(24, 63);
            this.TxtNomComprobante.Multiline = true;
            this.TxtNomComprobante.Name = "TxtNomComprobante";
            this.TxtNomComprobante.Size = new System.Drawing.Size(489, 25);
            this.TxtNomComprobante.TabIndex = 0;
            this.TxtNomComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomComprobante_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre Comprobante:";
            // 
            // TxtTipoComprobante
            // 
            this.TxtTipoComprobante.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtTipoComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoComprobante.Location = new System.Drawing.Point(27, 131);
            this.TxtTipoComprobante.Multiline = true;
            this.TxtTipoComprobante.Name = "TxtTipoComprobante";
            this.TxtTipoComprobante.Size = new System.Drawing.Size(233, 25);
            this.TxtTipoComprobante.TabIndex = 35;
            this.TxtTipoComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoComprobante_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tipo De Comprobante:";
            // 
            // TxtCorrelativo
            // 
            this.TxtCorrelativo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCorrelativo.Enabled = false;
            this.TxtCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorrelativo.Location = new System.Drawing.Point(280, 131);
            this.TxtCorrelativo.Multiline = true;
            this.TxtCorrelativo.Name = "TxtCorrelativo";
            this.TxtCorrelativo.Size = new System.Drawing.Size(154, 25);
            this.TxtCorrelativo.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Correlativo:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(280, 196);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 30);
            this.BtnAgregar.TabIndex = 40;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmAgregarComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 241);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtCorrelativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTipoComprobante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomComprobante);
            this.Controls.Add(this.label2);
            this.Name = "FrmAgregarComprobante";
            this.Text = "Agregar Tipo Comprobante";
            this.Load += new System.EventHandler(this.FrmAgregarTipoComprobante_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNomComprobante, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtTipoComprobante, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtCorrelativo, 0);
            this.Controls.SetChildIndex(this.BtnAgregar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtNomComprobante;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtTipoComprobante;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtCorrelativo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BtnAgregar;
    }
}