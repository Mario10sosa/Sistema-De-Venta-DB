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
    public partial class FrmAgregarEmpresa : FormBase
    {
        public FrmAgregarEmpresa(FrmEmpresas Empresas)
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

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmAgregarEmpresa_Load(object sender, EventArgs e)
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
                if (TxtNombreEmpresa.Text == string.Empty || TxtNit.Text == string.Empty ||
                    TxtDireccion.Text == string.Empty || MTxtTelefono.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe Completar Todos Los Datos", "Agregar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    
                    Empresa.Nombre = TxtNombreEmpresa.Text.Trim();
                    Empresa.Nit = TxtNit.Text.Trim();
                    Empresa.Direccion = TxtDireccion.Text.Trim();
                    Empresa.Telefono = MTxtTelefono.Text.Trim();

                    MemoryStream ms = new MemoryStream();
                    this.ptbLogo.Image.Save(ms, this.ptbLogo.Image.RawFormat);
                    Empresa.Logo = ms.GetBuffer();

                    Empresa.Email = TxtEmail.Text.Trim();

                    Empresas.AgregarEmpresa(Empresa);
                    MessageBox.Show("Su Empresa Fue Agregado Correctamente", "Agregar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    TxtNombreEmpresa.Focus();
                    MTxtTelefono.Text = string.Empty;
                    ptbLogo.Image = Properties.Resources.icono_bulding;
                    Agregar();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Empresa No Fue Agregado Por: " + ex.Message, "Agregar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

       
    }
}
