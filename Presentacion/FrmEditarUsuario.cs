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
    public partial class FrmEditarUsuario : FormBase
    {
        public FrmEditarUsuario(FrmUsuarios Usuarios)
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

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            TxtConfirmar.Text = TxtContra.Text;
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
                if (TxtNombre.Text == string.Empty || TxtApellido.Text == string.Empty ||
                    TxtUsuario.Text == string.Empty || TxtContra.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe Completar Todos Los Datos", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                        Usuario.Id_Usuario = Convert.ToInt32(TxtIdUsuario.Text.Trim());
                        Usuario.Nombre = TxtNombre.Text.Trim();
                        Usuario.Apellido = TxtApellido.Text.Trim();
                        Usuario.Usuario = TxtUsuario.Text.Trim();
                        Usuario.Password = TxtContra.Text.Trim();

                        Usuarios.EditarUsuario(Usuario);
                        MessageBox.Show("El Usuario Fue Editado Correctamente", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Procedimientos.LimpiarControles(this);
                        this.Close();
                        Actualizar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Usuario No Fue Editado Por: " + ex.Message, "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
