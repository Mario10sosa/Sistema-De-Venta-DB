using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad.Caches;
using Logica;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {

        public static string Usuario;
        public FrmPrincipal(string pUser)
        {
            InitializeComponent();
            Usuario = pUser;
        }
        
        CL_Usuarios Usuarios = new CL_Usuarios();
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
        }

        private void MostrarUsuario()
        {
            Usuarios.DatosUsuario(Usuario);

            TxtUsuario.Text = InformacionUsuario.Nombre + " " + InformacionUsuario.Apellido;
        }

       
        private void TmTiempo_Tick(object sender, EventArgs e)
        {
            LbTiempo.Text = DateTime.Now.ToLongTimeString();
            LbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            productos.ShowDialog();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInventario inventario = new FrmInventario();
            inventario.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores Proveedores = new FrmProveedores();
            Proveedores.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes Clientes = new FrmClientes();
            Clientes.ShowDialog();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresas Empresas = new FrmEmpresas();
            Empresas.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras Compras = new FrmCompras();
            Compras.ShowDialog();
        }

        private void tipoDeComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipo_Comprobantes Tipocomprobante = new FrmTipo_Comprobantes();
            Tipocomprobante.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas ventas = new FrmVentas();
            ventas.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
