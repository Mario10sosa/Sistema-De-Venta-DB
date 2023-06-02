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
    public partial class FrmEditarCliente : FormBase
    {
        public FrmEditarCliente(FrmClientes Clientes)
        {
            InitializeComponent();
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Clientes Clientes = new CL_Clientes();
        CE_Clientes Cliente = new CE_Clientes();

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
        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtCedula.Focus();
                e.Handled = true;
            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
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
                if (TxtCodigoCliente.Text == string.Empty || TxtNombreCliente.Text == string.Empty || TxtCedula.Text == string.Empty ||
                    TxtDireccion.Text == string.Empty || MTxtTelefono.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe Completar Todos Los Datos", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Cliente.Id_Cliente = Convert.ToInt32(TxtId_Cliente.Text.Trim());
                    Cliente.Codigo = TxtCodigoCliente.Text.Trim();
                    Cliente.Nombre = TxtNombreCliente.Text.Trim();
                    Cliente.Cedula = TxtCedula.Text.Trim();
                    Cliente.Direccion = TxtDireccion.Text.Trim();
                    Cliente.Telefono = MTxtTelefono.Text.Trim();
                    Cliente.Email = TxtEmail.Text.Trim();

                    Clientes.EditarCliente(Cliente);
                    MessageBox.Show("Su Cliente Fue Editado Correctamente", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    this.Close();
                    Actualizar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Cliente No Fue Editado Por: " + ex.Message, "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
