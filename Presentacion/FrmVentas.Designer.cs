namespace Presentacion
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtBuscarVentas = new System.Windows.Forms.TextBox();
            this.CboTipodeBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnAnular = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(1129, 544);
            // 
            // TxtBuscarVentas
            // 
            this.TxtBuscarVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarVentas.BackColor = System.Drawing.Color.SkyBlue;
            this.TxtBuscarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarVentas.Location = new System.Drawing.Point(937, 29);
            this.TxtBuscarVentas.Multiline = true;
            this.TxtBuscarVentas.Name = "TxtBuscarVentas";
            this.TxtBuscarVentas.Size = new System.Drawing.Size(315, 25);
            this.TxtBuscarVentas.TabIndex = 35;
            this.TxtBuscarVentas.TextChanged += new System.EventHandler(this.TxtBuscarClientes_TextChanged);
            // 
            // CboTipodeBusqueda
            // 
            this.CboTipodeBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboTipodeBusqueda.BackColor = System.Drawing.Color.SkyBlue;
            this.CboTipodeBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipodeBusqueda.FormattingEnabled = true;
            this.CboTipodeBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Comprobante"});
            this.CboTipodeBusqueda.Location = new System.Drawing.Point(770, 26);
            this.CboTipodeBusqueda.Name = "CboTipodeBusqueda";
            this.CboTipodeBusqueda.Size = new System.Drawing.Size(161, 28);
            this.CboTipodeBusqueda.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar:";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnImprimir.BackColor = System.Drawing.Color.Azure;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(264, 532);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(120, 30);
            this.BtnImprimir.TabIndex = 32;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnAnular
            // 
            this.BtnAnular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAnular.BackColor = System.Drawing.Color.Azure;
            this.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.Location = new System.Drawing.Point(138, 532);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(120, 30);
            this.BtnAnular.TabIndex = 31;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNuevo.BackColor = System.Drawing.Color.Azure;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(12, 532);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(120, 30);
            this.BtnNuevo.TabIndex = 30;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 433);
            this.dataGridView1.TabIndex = 29;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 589);
            this.Controls.Add(this.TxtBuscarVentas);
            this.Controls.Add(this.CboTipodeBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVentas";
            this.Text = "Gestion De Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.BtnNuevo, 0);
            this.Controls.SetChildIndex(this.BtnAnular, 0);
            this.Controls.SetChildIndex(this.BtnImprimir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.CboTipodeBusqueda, 0);
            this.Controls.SetChildIndex(this.TxtBuscarVentas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarVentas;
        private System.Windows.Forms.ComboBox CboTipodeBusqueda;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnImprimir;
        public System.Windows.Forms.Button BtnAnular;
        public System.Windows.Forms.Button BtnNuevo;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}