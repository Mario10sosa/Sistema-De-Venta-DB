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
    public partial class FrmAgregarCliente : FormBase
    {
        public FrmAgregarCliente(FrmClientes Clientes)
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

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            TxtCodigoCliente.Text = "CLIE" + Procedimientos.GenerarCodigo("Clientes");
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
                if (TxtCodigoCliente.Text == string.Empty || TxtNombreCliente.Text == string.Empty || TxtCedula.Text == string.Empty ||
                    TxtDireccion.Text == string.Empty || MTxtTelefono.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe Completar Todos Los Datos", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Cliente.Codigo = TxtCodigoCliente.Text.Trim();
                    Cliente.Nombre = TxtNombreCliente.Text.Trim();
                    Cliente.Cedula = TxtCedula.Text.Trim();
                    Cliente.Direccion = TxtDireccion.Text.Trim();
                    Cliente.Telefono = MTxtTelefono.Text.Trim();
                    Cliente.Email = TxtEmail.Text.Trim();

                    Clientes.AgregarCliente(Cliente);
                    MessageBox.Show("Su Cliente Fue Agregado Correctamente", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    GenerarCodigo();
                    TxtNombreCliente.Focus();
                    Agregar();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Cliente No Fue Agregado Por: " + ex.Message, "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
