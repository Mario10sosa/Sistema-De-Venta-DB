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
    public partial class FrmAgregarComprobante : FormBase
    {
        public FrmAgregarComprobante(FrmTipo_Comprobantes TipoComprobantes)
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

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void FrmAgregarTipoComprobante_Load(object sender, EventArgs e)
        {
            TxtCorrelativo.Text = "0";
        }

        private void TxtNomComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtTipoComprobante.Focus();
                e.Handled = true;
            }
        }

        private void TxtTipoComprobante_KeyPress(object sender, KeyPressEventArgs e)
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
                if(TxtNomComprobante.Text == string.Empty || TxtTipoComprobante.Text == string.Empty || TxtCorrelativo.Text == string.Empty)
                {
                    MessageBox.Show("Debe Completar Todos Los Campos Por Favor","Agregar Comprobante",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {

                    TipoComprobante.Nombre_Comprobante = TxtNomComprobante.Text.Trim();
                    TipoComprobante.Tipo_Comprobante = TxtTipoComprobante.Text.Trim();
                    TipoComprobante.Correlativo = Convert.ToInt32(TxtCorrelativo.Text.Trim());

                    TipoComprobantes.AgregarTipoComprobante(TipoComprobante);

                    MessageBox.Show("El Comprobante Fue Agregado Correctamente", "Agregar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Procedimientos.LimpiarControles(this);
                    TxtNomComprobante.Focus();
                    TxtCorrelativo.Text = "0";
                    Agregar();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Comprobante No Fue Agregado Por " + ex.Message,"Agregar Comprobante",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
