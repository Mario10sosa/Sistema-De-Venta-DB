namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeComprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmTiempo = new System.Windows.Forms.Timer(this.components);
            this.LbFecha = new System.Windows.Forms.Label();
            this.LbTiempo = new System.Windows.Forms.Label();
            this.pnInferior = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeProductosToolStripMenuItem,
            this.gToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeComprasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.gestionDeVentasToolStripMenuItem,
            this.gestionDeCiudadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1517, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.gestionDeProductosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_190__;
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion De Productos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_19;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.gToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_28__;
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(231, 28);
            this.gToolStripMenuItem.Text = "Gestion De Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_61;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.gestionDeClientesToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_74__;
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion De Clientes";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_44;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // gestionDeComprasToolStripMenuItem
            // 
            this.gestionDeComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem});
            this.gestionDeComprasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_66__;
            this.gestionDeComprasToolStripMenuItem.Name = "gestionDeComprasToolStripMenuItem";
            this.gestionDeComprasToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.gestionDeComprasToolStripMenuItem.Text = "Gestion De Compras";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_29;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem1});
            this.inventarioToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_42__;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(125, 28);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Image = global::Presentacion.Properties.Resources.icono_22;
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(175, 30);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
            // 
            // gestionDeVentasToolStripMenuItem
            // 
            this.gestionDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem});
            this.gestionDeVentasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.compra_ini__;
            this.gestionDeVentasToolStripMenuItem.Name = "gestionDeVentasToolStripMenuItem";
            this.gestionDeVentasToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.gestionDeVentasToolStripMenuItem.Text = "Gestion De Ventas";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_20;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // gestionDeCiudadToolStripMenuItem
            // 
            this.gestionDeCiudadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresasToolStripMenuItem,
            this.tipoDeComprobantesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.gestionDeCiudadToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_49__;
            this.gestionDeCiudadToolStripMenuItem.Name = "gestionDeCiudadToolStripMenuItem";
            this.gestionDeCiudadToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.gestionDeCiudadToolStripMenuItem.Text = "Configuracion";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_bulding;
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // tipoDeComprobantesToolStripMenuItem
            // 
            this.tipoDeComprobantesToolStripMenuItem.Image = global::Presentacion.Properties.Resources.Icono_197;
            this.tipoDeComprobantesToolStripMenuItem.Name = "tipoDeComprobantesToolStripMenuItem";
            this.tipoDeComprobantesToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.tipoDeComprobantesToolStripMenuItem.Text = "Tipo De Comprobantes";
            this.tipoDeComprobantesToolStripMenuItem.Click += new System.EventHandler(this.tipoDeComprobantesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_213;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // TmTiempo
            // 
            this.TmTiempo.Enabled = true;
            this.TmTiempo.Tick += new System.EventHandler(this.TmTiempo_Tick);
            // 
            // LbFecha
            // 
            this.LbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LbFecha.AutoSize = true;
            this.LbFecha.BackColor = System.Drawing.Color.Transparent;
            this.LbFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F);
            this.LbFecha.ForeColor = System.Drawing.Color.Black;
            this.LbFecha.Location = new System.Drawing.Point(240, 151);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(509, 48);
            this.LbFecha.TabIndex = 1;
            this.LbFecha.Text = "marte, 16 de mayo de 2023";
            // 
            // LbTiempo
            // 
            this.LbTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTiempo.AutoSize = true;
            this.LbTiempo.BackColor = System.Drawing.Color.Transparent;
            this.LbTiempo.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTiempo.ForeColor = System.Drawing.Color.Black;
            this.LbTiempo.Location = new System.Drawing.Point(397, 89);
            this.LbTiempo.Name = "LbTiempo";
            this.LbTiempo.Size = new System.Drawing.Size(222, 48);
            this.LbTiempo.TabIndex = 2;
            this.LbTiempo.Text = "0:00:00 x.m";
            // 
            // pnInferior
            // 
            this.pnInferior.BackColor = System.Drawing.Color.Silver;
            this.pnInferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnInferior.Controls.Add(this.label4);
            this.pnInferior.Controls.Add(this.label3);
            this.pnInferior.Controls.Add(this.TxtUsuario);
            this.pnInferior.Controls.Add(this.label2);
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnInferior.Location = new System.Drawing.Point(0, 645);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.Size = new System.Drawing.Size(1517, 104);
            this.pnInferior.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(1087, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mario Sosa, Camilo Gutierrez, Ivan Ocampo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1258, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Creado Por:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtUsuario.Enabled = false;
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(108, 43);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(268, 30);
            this.TxtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Presentacion.Properties.Resources._343775866_943846580065763_6028274672216094968_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1517, 749);
            this.Controls.Add(this.pnInferior);
            this.Controls.Add(this.LbTiempo);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema De Venta- ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnInferior.ResumeLayout(false);
            this.pnInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCiudadToolStripMenuItem;
        private System.Windows.Forms.Timer TmTiempo;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.Label LbTiempo;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeComprobantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Panel pnInferior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
    }
}

