using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmAgregarUsuario : FormBase
    {
        public FrmAgregarUsuario(FrmUsuarios Usuarios)
        {
            InitializeComponent();
        }
        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Usuarios Usuarios = new CL_Usuarios();
        CE_Usuarios Usuario = new CE_Usuarios();

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

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtApellido.Focus();
                e.Handled = true;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtUsuario.Focus();
                e.Handled = true;
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtContra.Focus();
                e.Handled = true;
            }
        }

        private void TxtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtConfirmar.Focus();
                e.Handled = true;
            }
        }
        private void TxtConfirmar_KeyPress(object sender, KeyPressEventArgs e)
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
                if (TxtNombre.Text == string.Empty || TxtApellido.Text == string.Empty ||
                    TxtUsuario.Text == string.Empty || TxtContra.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe Completar Todos Los Datos", "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                { 
                    if (TxtContra.Text != TxtConfirmar.Text)
                    {
                        MessageBox.Show("La Contraseñas No Coinsiden", "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtConfirmar.Focus();
                    }
                    else
                    {
                        Usuario.Nombre = TxtNombre.Text.Trim();
                        Usuario.Apellido = TxtApellido.Text.Trim();
                        Usuario.Usuario = TxtUsuario.Text.Trim();
                        Usuario.Password = TxtContra.Text.Trim();

                        Usuarios.AgregarUsuario(Usuario);
                        MessageBox.Show("El Usuario Fue Agregado Correctamente", "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Procedimientos.LimpiarControles(this);
                        TxtNombre.Focus();
                        Agregar();
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Usuario No Fue Agregado Por: " + ex.Message, "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        
    }
}
