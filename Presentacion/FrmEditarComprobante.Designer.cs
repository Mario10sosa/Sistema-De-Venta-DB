namespace Presentacion
{
    partial class FrmEditarComprobante
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
            this.TxtCorrelativo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTipoComprobante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomComprobante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId_Comprobante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(411, 196);
            this.BtnCancelar.TabIndex = 41;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.Azure;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(282, 196);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 30);
            this.BtnEditar.TabIndex = 47;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtCorrelativo
            // 
            this.TxtCorrelativo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCorrelativo.Enabled = false;
            this.TxtCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorrelativo.Location = new System.Drawing.Point(282, 131);
            this.TxtCorrelativo.Multiline = true;
            this.TxtCorrelativo.Name = "TxtCorrelativo";
            this.TxtCorrelativo.Size = new System.Drawing.Size(154, 25);
            this.TxtCorrelativo.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Correlativo:";
            // 
            // TxtTipoComprobante
            // 
            this.TxtTipoComprobante.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtTipoComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoComprobante.Location = new System.Drawing.Point(29, 131);
            this.TxtTipoComprobante.Multiline = true;
            this.TxtTipoComprobante.Name = "TxtTipoComprobante";
            this.TxtTipoComprobante.Size = new System.Drawing.Size(233, 25);
            this.TxtTipoComprobante.TabIndex = 43;
            this.TxtTipoComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoComprobante_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tipo De Comprobante:";
            // 
            // TxtNomComprobante
            // 
            this.TxtNomComprobante.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNomComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomComprobante.Location = new System.Drawing.Point(26, 63);
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
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre Comprobante:";
            // 
            // TxtId_Comprobante
            // 
            this.TxtId_Comprobante.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtId_Comprobante.Enabled = false;
            this.TxtId_Comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId_Comprobante.Location = new System.Drawing.Point(482, 37);
            this.TxtId_Comprobante.Multiline = true;
            this.TxtId_Comprobante.Name = "TxtId_Comprobante";
            this.TxtId_Comprobante.Size = new System.Drawing.Size(33, 25);
            this.TxtId_Comprobante.TabIndex = 48;
            this.TxtId_Comprobante.Visible = false;
            // 
            // FrmEditarComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 241);
            this.Controls.Add(this.TxtId_Comprobante);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtCorrelativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTipoComprobante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomComprobante);
            this.Controls.Add(this.label2);
            this.Name = "FrmEditarComprobante";
            this.Text = "Editar Comprobante";
            this.Load += new System.EventHandler(this.FrmEditarComprobante_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNomComprobante, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtTipoComprobante, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtCorrelativo, 0);
            this.Controls.SetChildIndex(this.BtnEditar, 0);
            this.Controls.SetChildIndex(this.TxtId_Comprobante, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnEditar;
        public System.Windows.Forms.TextBox TxtCorrelativo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtTipoComprobante;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtNomComprobante;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtId_Comprobante;
    }
}