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
    public partial class FrmEditarProveedor : FormBase
    {
        public FrmEditarProveedor(FrmProveedores Proveedores)
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

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmEditarProveedor_Load(object sender, EventArgs e)
        {

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
                BtnEditar.Focus();
                e.Handled = true;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public override void Editar()
        {
            try
            {
                if (TxtCodigoProveedor.Text == string.Empty || TxtNombreProveedor.Text == string.Empty || TxtNit.Text == string.Empty ||
                    TxtDireccion.Text == string.Empty || MTxtTelefono.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe Completar Todos Los Datos", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Proveedore.Id_Proveedor = Convert.ToInt32(TxtId_Proveedor.Text.Trim());
                    Proveedore.Codigo = TxtCodigoProveedor.Text.Trim();
                    Proveedore.Nombre = TxtNombreProveedor.Text.Trim();
                    Proveedore.Nit = TxtNit.Text.Trim();
                    Proveedore.Direccion = TxtDireccion.Text.Trim();
                    Proveedore.Telefono = MTxtTelefono.Text.Trim();
                    Proveedore.Email = TxtEmail.Text.Trim();

                    Proveedores.EditarProveedor(Proveedore);
                    MessageBox.Show("Su Proveedor Fue Editado Correctamente", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    this.Close();
                    Actualizar();
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Proveedor No Fue Editado Por: " + ex.Message, "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
