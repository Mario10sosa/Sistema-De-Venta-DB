namespace Presentacion
{
    partial class FrmAgregarIngresoProducto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.TxtId_Proveedor = new System.Windows.Forms.TextBox();
            this.TxtId_Ingreso = new System.Windows.Forms.TextBox();
            this.TxtComprobante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNo_Ingreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtId_Detalle = new System.Windows.Forms.TextBox();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.TxtCos_Unitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBuscar_Producto = new System.Windows.Forms.Button();
            this.TxtId_Producto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNomProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCod_Producto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTotalPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(945, 692);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFecha_Ingreso);
            this.groupBox1.Controls.Add(this.BtnBuscarProveedor);
            this.groupBox1.Controls.Add(this.TxtId_Proveedor);
            this.groupBox1.Controls.Add(this.TxtId_Ingreso);
            this.groupBox1.Controls.Add(this.TxtComprobante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNomProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNo_Ingreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(770, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha Ingreso:";
            // 
            // dtpFecha_Ingreso
            // 
            this.dtpFecha_Ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Ingreso.Location = new System.Drawing.Point(764, 62);
            this.dtpFecha_Ingreso.Name = "dtpFecha_Ingreso";
            this.dtpFecha_Ingreso.Size = new System.Drawing.Size(146, 28);
            this.dtpFecha_Ingreso.TabIndex = 42;
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarProveedor.BackColor = System.Drawing.Color.Azure;
            this.BtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(709, 60);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(38, 30);
            this.BtnBuscarProveedor.TabIndex = 41;
            this.BtnBuscarProveedor.Text = "...";
            this.BtnBuscarProveedor.UseVisualStyleBackColor = false;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // TxtId_Proveedor
            // 
            this.TxtId_Proveedor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtId_Proveedor.Location = new System.Drawing.Point(266, 60);
            this.TxtId_Proveedor.Multiline = true;
            this.TxtId_Proveedor.Name = "TxtId_Proveedor";
            this.TxtId_Proveedor.Size = new System.Drawing.Size(27, 30);
            this.TxtId_Proveedor.TabIndex = 7;
            this.TxtId_Proveedor.Visible = false;
            // 
            // TxtId_Ingreso
            // 
            this.TxtId_Ingreso.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtId_Ingreso.Enabled = false;
            this.TxtId_Ingreso.Location = new System.Drawing.Point(13, 60);
            this.TxtId_Ingreso.Multiline = true;
            this.TxtId_Ingreso.Name = "TxtId_Ingreso";
            this.TxtId_Ingreso.ReadOnly = true;
            this.TxtId_Ingreso.Size = new System.Drawing.Size(27, 30);
            this.TxtId_Ingreso.TabIndex = 6;
            this.TxtId_Ingreso.Visible = false;
            // 
            // TxtComprobante
            // 
            this.TxtComprobante.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtComprobante.Location = new System.Drawing.Point(47, 126);
            this.TxtComprobante.Multiline = true;
            this.TxtComprobante.Name = "TxtComprobante";
            this.TxtComprobante.Size = new System.Drawing.Size(214, 30);
            this.TxtComprobante.TabIndex = 5;
            this.TxtComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtComprobante_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comprobante:";
            // 
            // TxtNomProveedor
            // 
            this.TxtNomProveedor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNomProveedor.Location = new System.Drawing.Point(295, 60);
            this.TxtNomProveedor.Multiline = true;
            this.TxtNomProveedor.Name = "TxtNomProveedor";
            this.TxtNomProveedor.ReadOnly = true;
            this.TxtNomProveedor.Size = new System.Drawing.Size(408, 30);
            this.TxtNomProveedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(291, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Proveedor:";
            // 
            // TxtNo_Ingreso
            // 
            this.TxtNo_Ingreso.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNo_Ingreso.Enabled = false;
            this.TxtNo_Ingreso.Location = new System.Drawing.Point(46, 60);
            this.TxtNo_Ingreso.Multiline = true;
            this.TxtNo_Ingreso.Name = "TxtNo_Ingreso";
            this.TxtNo_Ingreso.ReadOnly = true;
            this.TxtNo_Ingreso.Size = new System.Drawing.Size(214, 30);
            this.TxtNo_Ingreso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. de Ingreso:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(819, 692);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 30);
            this.BtnAgregar.TabIndex = 40;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.TxtId_Detalle);
            this.groupBox2.Controls.Add(this.BtnEliminarProducto);
            this.groupBox2.Controls.Add(this.BtnAgregarProducto);
            this.groupBox2.Controls.Add(this.TxtCos_Unitario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtnBuscar_Producto);
            this.groupBox2.Controls.Add(this.TxtId_Producto);
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtNomProducto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtCod_Producto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1056, 181);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Del Producto";
            // 
            // TxtId_Detalle
            // 
            this.TxtId_Detalle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtId_Detalle.Enabled = false;
            this.TxtId_Detalle.Location = new System.Drawing.Point(13, 126);
            this.TxtId_Detalle.Multiline = true;
            this.TxtId_Detalle.Name = "TxtId_Detalle";
            this.TxtId_Detalle.ReadOnly = true;
            this.TxtId_Detalle.Size = new System.Drawing.Size(27, 30);
            this.TxtId_Detalle.TabIndex = 44;
            this.TxtId_Detalle.Visible = false;
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.Azure;
            this.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(951, 98);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(87, 30);
            this.BtnEliminarProducto.TabIndex = 45;
            this.BtnEliminarProducto.Text = "Eliminar";
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(951, 60);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(87, 30);
            this.BtnAgregarProducto.TabIndex = 44;
            this.BtnAgregarProducto.Text = "Agregar";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // TxtCos_Unitario
            // 
            this.TxtCos_Unitario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCos_Unitario.Location = new System.Drawing.Point(731, 60);
            this.TxtCos_Unitario.Multiline = true;
            this.TxtCos_Unitario.Name = "TxtCos_Unitario";
            this.TxtCos_Unitario.ReadOnly = true;
            this.TxtCos_Unitario.Size = new System.Drawing.Size(214, 30);
            this.TxtCos_Unitario.TabIndex = 43;
            this.TxtCos_Unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(727, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Costo Unitario:";
            // 
            // BtnBuscar_Producto
            // 
            this.BtnBuscar_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar_Producto.BackColor = System.Drawing.Color.Azure;
            this.BtnBuscar_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar_Producto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBuscar_Producto.Location = new System.Drawing.Point(687, 60);
            this.BtnBuscar_Producto.Name = "BtnBuscar_Producto";
            this.BtnBuscar_Producto.Size = new System.Drawing.Size(38, 30);
            this.BtnBuscar_Producto.TabIndex = 41;
            this.BtnBuscar_Producto.Text = "...";
            this.BtnBuscar_Producto.UseVisualStyleBackColor = false;
            this.BtnBuscar_Producto.Click += new System.EventHandler(this.BtnBuscar_Producto_Click);
            // 
            // TxtId_Producto
            // 
            this.TxtId_Producto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtId_Producto.Location = new System.Drawing.Point(13, 60);
            this.TxtId_Producto.Multiline = true;
            this.TxtId_Producto.Name = "TxtId_Producto";
            this.TxtId_Producto.Size = new System.Drawing.Size(27, 30);
            this.TxtId_Producto.TabIndex = 6;
            this.TxtId_Producto.Visible = false;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCantidad.Location = new System.Drawing.Point(47, 126);
            this.TxtCantidad.Multiline = true;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(214, 30);
            this.TxtCantidad.TabIndex = 5;
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(43, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantidad:";
            // 
            // TxtNomProducto
            // 
            this.TxtNomProducto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNomProducto.Location = new System.Drawing.Point(273, 60);
            this.TxtNomProducto.Multiline = true;
            this.TxtNomProducto.Name = "TxtNomProducto";
            this.TxtNomProducto.ReadOnly = true;
            this.TxtNomProducto.Size = new System.Drawing.Size(408, 30);
            this.TxtNomProducto.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(269, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre Producto:";
            // 
            // TxtCod_Producto
            // 
            this.TxtCod_Producto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtCod_Producto.Enabled = false;
            this.TxtCod_Producto.Location = new System.Drawing.Point(46, 60);
            this.TxtCod_Producto.Multiline = true;
            this.TxtCod_Producto.Name = "TxtCod_Producto";
            this.TxtCod_Producto.ReadOnly = true;
            this.TxtCod_Producto.Size = new System.Drawing.Size(214, 30);
            this.TxtCod_Producto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(42, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codigo Producto:";
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Nombre,
            this.Cantidad,
            this.Costo_Unitario,
            this.Sub_Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(13, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 299);
            this.dataGridView1.TabIndex = 45;
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id Producto";
            this.Id_Producto.MinimumWidth = 6;
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            this.Id_Producto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Costo_Unitario
            // 
            this.Costo_Unitario.HeaderText = "Costo Unitario";
            this.Costo_Unitario.MinimumWidth = 6;
            this.Costo_Unitario.Name = "Costo_Unitario";
            this.Costo_Unitario.ReadOnly = true;
            this.Costo_Unitario.Width = 125;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.MinimumWidth = 6;
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            this.Sub_Total.Width = 125;
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTotalPagar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtTotalPagar.Enabled = false;
            this.TxtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPagar.Location = new System.Drawing.Point(126, 682);
            this.TxtTotalPagar.Multiline = true;
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.ReadOnly = true;
            this.TxtTotalPagar.Size = new System.Drawing.Size(180, 30);
            this.TxtTotalPagar.TabIndex = 47;
            this.TxtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label9.Location = new System.Drawing.Point(9, 692);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Total Pagar:";
            // 
            // FrmAgregarIngresoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 737);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAgregarIngresoProducto";
            this.Text = "Ingreso De Producto";
            this.Load += new System.EventHandler(this.FrmAgregarIngresoProducto_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.BtnAgregar, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.TxtTotalPagar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TxtId_Proveedor;
        public System.Windows.Forms.TextBox TxtId_Ingreso;
        public System.Windows.Forms.TextBox TxtComprobante;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNomProveedor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtNo_Ingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpFecha_Ingreso;
        public System.Windows.Forms.Button BtnBuscarProveedor;
        public System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button BtnEliminarProducto;
        public System.Windows.Forms.Button BtnAgregarProducto;
        public System.Windows.Forms.TextBox TxtCos_Unitario;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BtnBuscar_Producto;
        public System.Windows.Forms.TextBox TxtId_Producto;
        public System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtNomProducto;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtCod_Producto;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        public System.Windows.Forms.TextBox TxtTotalPagar;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtId_Detalle;
    }
}