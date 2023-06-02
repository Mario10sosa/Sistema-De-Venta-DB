using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Entidad.Caches;
using Logica;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        CL_Usuarios Usuarios = new CL_Usuarios();
        CE_Usuarios Usuario = new CE_Usuarios();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int lparam);
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtContra.Focus();
                e.Handled = true;
            }
        }

        private void TxtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnIngresar.Focus();
                e.Handled = true;
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtUsuario.Text != string.Empty)
                {
                    if(TxtContra.Text != string.Empty)
                    {
                        Usuario.Usuario = TxtUsuario.Text.Trim();
                        Usuario.Password = TxtContra.Text.Trim();


                       DataTable User = Usuarios.LoginUsuario(Usuario);

                        

                        if(User.Rows.Count != 0)
                        {
                            FrmPrincipal FormularioPrincipal = new FrmPrincipal(TxtUsuario.Text);
                            FormularioPrincipal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña Incorrecto, \n Por Favor Intente Otra Vez", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TxtUsuario.Clear();
                            TxtContra.Clear();
                            TxtUsuario.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe Completar El Campo Contraseña", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtContra.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe Completar El Campo Usuario", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtUsuario.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Puede Ingresar Al Sistem Por: " + ex.Message , "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
