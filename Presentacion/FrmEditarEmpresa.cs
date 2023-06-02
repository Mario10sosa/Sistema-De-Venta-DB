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
using System.IO;

namespace Presentacion
{
    public partial class FrmEditarEmpresa : FormBase
    {
        public FrmEditarEmpresa(FrmEmpresas Empresas)
        {
            InitializeComponent();
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Empresas Empresas = new CL_Empresas();
        CE_Empresas Empresa = new CE_Empresas();
        OpenFileDialog Examinar = new OpenFileDialog();

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

        private void FrmEditarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscarLogo_Click(object sender, EventArgs e)
        {
            Examinar.Filter = "Image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult Dres = Examinar.ShowDialog();
            if (Dres == DialogResult.Abort)
                return;
            if (Dres == DialogResult.Cancel)
                return;
            TxtExaminar.Text = Examinar.FileName;
            ptbLogo.Image = Image.FromFile(Examinar.FileName);
        }

        private void TxtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
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
                TxtEmail.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
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
                if (TxtNombreEmpresa.Text == string.Empty || TxtNit.Text == string.Empty ||
                    TxtDireccion.Text == string.Empty || MTxtTelefono.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe Completar Todos Los Datos", "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Empresa.Id_Empresa = Convert.ToInt32(TxtId_Empresa.Text.Trim());

                    Empresa.Nombre = TxtNombreEmpresa.Text.Trim();
                    Empresa.Nit = TxtNit.Text.Trim();
                    Empresa.Direccion = TxtDireccion.Text.Trim();
                    Empresa.Telefono = MTxtTelefono.Text.Trim();

                    MemoryStream ms = new MemoryStream();
                    this.ptbLogo.Image.Save(ms, this.ptbLogo.Image.RawFormat);
                    Empresa.Logo = ms.GetBuffer();

                    Empresa.Email = TxtEmail.Text.Trim();

                    Empresa.Email = TxtEmail.Text.Trim();

                    Empresas.EditarEmpresa(Empresa);
                    MessageBox.Show("Su Empresa Fue Editado Correctamente", "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    this.Close();
                    Actualizar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Empresa No Fue Editado Por: " + ex.Message, "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
