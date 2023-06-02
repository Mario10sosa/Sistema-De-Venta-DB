using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidad;

namespace Presentacion
{
    public partial class FrmAgregarProducto : FormBase
    {
        public FrmAgregarProducto(FrmProductos Productos)
        {
            InitializeComponent();
            cboTipoCargo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Productos Productos = new CL_Productos();
        CE_Productos Producto = new CE_Productos();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set;}
        }

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            TxtCodigoProducto.Text = "PRO" + Procedimientos.GenerarCodigo("Productos");
        }
        private void TxtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtNombreProducto.Focus();
                e.Handled = true;
            }
        }
        private void TxtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDescripcion.Focus();
                e.Handled = true;
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtPresentacion.Focus();
                e.Handled = true;
            }
        }

        private void TxtPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtCostoUnitario.Focus();
                e.Handled = true;
            }
        }

        private void TxtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtPrecioVenta.Focus();
                e.Handled = true;
            }
        }

        private void TxtCostoUnitario_Leave(object sender, EventArgs e)
        {
            Procedimientos.FormatoMoneda(TxtCostoUnitario);
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cboTipoCargo.Focus();
                e.Handled = true;
            }
        }

        private void TxtPrecioVenta_Leave(object sender, EventArgs e)
        {
            Procedimientos.FormatoMoneda(TxtPrecioVenta);
        }

        private void cboTipoCargo_KeyPress(object sender, KeyPressEventArgs e)
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
                if(TxtCodigoProducto.Text == string.Empty || TxtCodBarra.Text == string.Empty ||TxtNombreProducto.Text == string.Empty || TxtDescripcion.Text == string.Empty 
                    || TxtPresentacion.Text == string.Empty || TxtCostoUnitario.Text == string.Empty || TxtPrecioVenta.Text == string.Empty || cboTipoCargo.Text == string.Empty)
                {
                    MessageBox.Show("Por Favor Debe Completar Todos Los Datos" , "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Producto.Codigo = TxtCodigoProducto.Text.Trim();
                    Producto.Codigo_Barra= TxtCodBarra.Text.Trim();
                    Producto.Nombre = TxtNombreProducto.Text.Trim();
                    Producto.Descripcion = TxtDescripcion.Text.Trim();
                    Producto.Presentacion = TxtPresentacion.Text.Trim();
                    Producto.Costo_Unitario = Convert.ToDecimal(TxtCostoUnitario.Text.Trim());
                    Producto.Precio_Venta = Convert.ToDecimal(TxtPrecioVenta.Text.Trim());
                    Producto.Tipo_Cargo = cboTipoCargo.Text.Trim();

                    Productos.AgregarProducto(Producto);
                    MessageBox.Show("Su Producto Fue Sido Agregado Correctamente","Agregar Producto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    GenerarCodigo();
                    TxtCodBarra.Focus();
                    Agregar();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El Producto No Fue Agregado Por: "+ ex.Message, "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        
    }
}
