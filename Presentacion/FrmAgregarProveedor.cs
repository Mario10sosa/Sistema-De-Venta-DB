using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmAgregarProveedor : FormBase
    {
        public FrmAgregarProveedor(FrmProveedores Proveedores)
        {
            InitializeComponent();
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Proveedores Proveedores = new CL_Proveedores();
        CE_Proveedores Proveedore = new CE_Proveedores();


        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmAgregarProveedor_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

       

        private void GenerarCodigo()
        {
            TxtCodigoProveedor.Text = "PROV" + Procedimientos.GenerarCodigo("Proveedores");
        }

        private void TxtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtNit.Focus();
                e.Handled = true;
            }
        }

        private void TxtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDireccion.Focus();
                e.Handled = true;
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MTxtTelefono.Focus();
                e.Handled = true;
            }
        }

        private void MTxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtEmail.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnAgregar.Focus();
                e.Handled = true;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public override bool Guardar()
        {
            try
            {
                if (TxtCodigoProveedor.Text == string.Empty || TxtNombreProveedor.Text == string.Empty || TxtNit.Text == string.Empty ||
                    TxtDireccion.Text == string.Empty || MTxtTelefono.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe Completar Todos Los Datos", "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Proveedore.Codigo = TxtCodigoProveedor.Text.Trim();
                    Proveedore.Nombre = TxtNombreProveedor.Text.Trim();
                    Proveedore.Nit = TxtNit.Text.Trim();
                    Proveedore.Direccion = TxtDireccion.Text.Trim();
                    Proveedore.Telefono = MTxtTelefono.Text.Trim();
                    Proveedore.Email = TxtEmail.Text.Trim();

                    Proveedores.AgregarProveedor(Proveedore);
                    MessageBox.Show("Su Proveedor Fue Agregado Correctamente", "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    GenerarCodigo();
                    TxtNombreProveedor.Focus();
                    Agregar();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Proveedor No Fue Agregado Por: " + ex.Message, "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

       
    }
}
