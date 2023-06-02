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
    public partial class FrmEditarComprobante : FormBase
    {
        public FrmEditarComprobante(FrmTipo_Comprobantes TipoComprobantes)
        {
            InitializeComponent();
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Tipo_Comprobantes TipoComprobantes = new CL_Tipo_Comprobantes();
        CE_Tipo_Comprobantes TipoComprobante = new CE_Tipo_Comprobantes();

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

        private void FrmEditarComprobante_Load(object sender, EventArgs e)
        {

        }

        private void TxtNomComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtTipoComprobante.Focus();
                e.Handled = true;
            }
        }

        private void TxtTipoComprobante_KeyPress(object sender, KeyPressEventArgs e)
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
                if (TxtNomComprobante.Text == string.Empty || TxtTipoComprobante.Text == string.Empty || TxtCorrelativo.Text == string.Empty)
                {
                    MessageBox.Show("Debe Completar Todos Los Campos Por Favor", "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TipoComprobante.Id_Comprobante = Convert.ToInt32(TxtId_Comprobante.Text.Trim());
                    TipoComprobante.Nombre_Comprobante = TxtNomComprobante.Text.Trim();
                    TipoComprobante.Tipo_Comprobante = TxtTipoComprobante.Text.Trim();
                    TipoComprobante.Correlativo = Convert.ToInt32(TxtCorrelativo.Text.Trim());

                    TipoComprobantes.EditarTipoComprobante(TipoComprobante);

                    MessageBox.Show("El Comprobante Fue Editado Correctamente", "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    Actualizar();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Comprobante No Fue Editar Por " + ex.Message, "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
    
}
