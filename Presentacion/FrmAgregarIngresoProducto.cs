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
    public partial class FrmAgregarIngresoProducto : FormBase
    {
        public FrmAgregarIngresoProducto(FrmCompras Compras)
        {
            InitializeComponent();
        }
        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Ingreso_Productos Ingreso_Produtos = new CL_Ingreso_Productos();
        CE_Ingreso_Productos Ingreso_Producto = new CE_Ingreso_Productos();

        CL_Detalle_Ingresos Detalle_Ingresos = new CL_Detalle_Ingresos();
        CE_Detalle_Ingresos Detalle_Ingreso = new CE_Detalle_Ingresos();

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
        private void FrmAgregarIngresoProducto_Load(object sender, EventArgs e)
        {
            MejorVista();

            TxtTotalPagar.Text = "0.00";
            Correlativo();
        }

        private void MejorVista()
        {
            dataGridView1.Columns[0].Visible = false;// id Producto

            dataGridView1.Columns[1].Width = 320;//nombre producto
            dataGridView1.Columns[2].Width = 160;//cantidad
            dataGridView1.Columns[3].Width = 160;//costo unitario
            dataGridView1.Columns[4].Width = 150;//sub total

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void Correlativo()
        {
            TxtId_Ingreso.Text = Procedimientos.GenerarCodigoId("Ingreso_Producto");
            TxtNo_Ingreso.Text = "INGRE" + Procedimientos.GenerarCodigo("Ingreso_Producto");
            TxtId_Detalle.Text = Procedimientos.GenerarCodigoId("Detalle_Ingresos");
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmVistaProveedores vistaProveedores = new FrmVistaProveedores();
            vistaProveedores.ShowDialog();

            try
            {
                if(vistaProveedores.DialogResult == DialogResult.OK)
                {
                    TxtId_Proveedor.Text = vistaProveedores.dataGridView1.Rows[vistaProveedores.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtNomProveedor.Text = vistaProveedores.dataGridView1.Rows[vistaProveedores.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    TxtComprobante.Focus();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe Seleccionar Un Proveedor En La Lista","Seleccionar Proveedor",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }


        public static int ContFila = 0;
        public static decimal Total;
        private void AgregarDetalle()
        {
            decimal SubTotal = 0;

            try
            {
                if (TxtId_Producto.Text == string.Empty || TxtNomProducto.Text == string.Empty || TxtCantidad.Text == string.Empty)
                {
                    MessageBox.Show("Debe Completar Todos Los Campos Del Detalle Ingreso", "Agregar Detalle Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    bool Existe = false;
                    int No_Fila = 0;
                    if (ContFila == 0)
                    {
                        SubTotal = Convert.ToDecimal(TxtCantidad.Text) * Convert.ToDecimal(TxtCos_Unitario.Text);

                        dataGridView1.Rows.Add(TxtId_Producto.Text, TxtNomProducto.Text, TxtCantidad.Text, TxtCos_Unitario.Text, SubTotal.ToString("N2"));
                        dataGridView1.ClearSelection();

                        LimpiarDetalle();
                        BtnAgregarProducto.Focus();

                        ContFila++;
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == TxtId_Producto.Text)
                            {
                                Existe = true;
                                No_Fila = row.Index;
                            }
                        }

                        if (Existe == true)
                        {
                            SubTotal = Convert.ToDecimal(TxtCantidad.Text) * Convert.ToDecimal(TxtCos_Unitario.Text);
                            dataGridView1.Rows[No_Fila].Cells[2].Value = Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[No_Fila].Cells[2].Value.ToString());
                            dataGridView1.Rows[No_Fila].Cells[4].Value = (SubTotal + Convert.ToDecimal(dataGridView1.Rows[No_Fila].Cells[4].Value)).ToString("N2");
                            LimpiarDetalle();
                        }
                        else
                        {
                            SubTotal = Convert.ToDecimal(TxtCantidad.Text) * Convert.ToDecimal(TxtCos_Unitario.Text);

                            dataGridView1.Rows.Add(TxtId_Producto.Text,TxtNomProducto.Text, TxtCantidad.Text, TxtCos_Unitario.Text, SubTotal.ToString("N2"));
                            dataGridView1.ClearSelection();

                            LimpiarDetalle();
                            BtnAgregarProducto.Focus();

                            ContFila++;
                        }
                    }
                    Total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        Total += Convert.ToDecimal(row.Cells[4].Value);

                    }
                    TxtTotalPagar.Text = Total.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Producto No Fue Agreagado Por: "+ ex.Message,"Agregar Producto",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LimpiarDetalle()
        {
            TxtId_Producto.Text = string.Empty;
            TxtCod_Producto.Text = string.Empty;
            TxtNomProducto.Text = string.Empty;
            TxtCos_Unitario.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtCod_Producto.Focus();
        }

        private void LimpiarCampos()
        {
            TxtId_Ingreso.Text = string.Empty;
            TxtNo_Ingreso.Text = string.Empty;
            TxtId_Proveedor.Text = string.Empty;
            TxtNomProveedor.Text = string.Empty;
            TxtComprobante.Text = string.Empty;

            dataGridView1.Rows.Clear();
        }

        private void BtnBuscar_Producto_Click(object sender, EventArgs e)
        {
            FrmVistaProductos vistaProductos = new FrmVistaProductos();
            vistaProductos.ShowDialog();

            try
            {
                if (vistaProductos.DialogResult == DialogResult.OK)
                {
                    TxtId_Producto.Text = vistaProductos.dataGridView1.Rows[vistaProductos.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtCod_Producto.Text = vistaProductos.dataGridView1.Rows[vistaProductos.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    TxtNomProducto.Text = vistaProductos.dataGridView1.Rows[vistaProductos.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                    TxtCos_Unitario.Text = vistaProductos.dataGridView1.Rows[vistaProductos.dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                    TxtCantidad.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe Seleccionar Un Producto En La Lista", "Seleccionar Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if(ContFila > 0)
                {
                    Total = Total - Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                    TxtTotalPagar.Text = Total.ToString("N2");

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    ContFila--;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Hay Fila Para Eliminar", "Seleccionar Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnBuscar_Producto.Focus();
                e.Handled = true;
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnAgregarProducto.Focus();
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
                if (TxtId_Ingreso.Text == string.Empty || TxtNo_Ingreso.Text == string.Empty || TxtId_Proveedor.Text == string.Empty 
                    || TxtNomProveedor.Text == string.Empty || TxtComprobante.Text == string.Empty)
                {
                    MessageBox.Show("Debe Completar Todos Los Campo Por Favor", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Ingreso_Producto.No_Ingreso = TxtNo_Ingreso.Text;
                    Ingreso_Producto.Id_Proveedor = Convert.ToInt32(TxtId_Proveedor.Text);
                    Ingreso_Producto.Fecha_Ingreso = Convert.ToDateTime(dtpFecha_Ingreso.Text);
                    Ingreso_Producto.Comprobante = TxtComprobante.Text;
                    Ingreso_Producto.Monto_Total = Convert.ToDecimal(TxtTotalPagar.Text);
                    Ingreso_Producto.Estado = "Emitido";

                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        Detalle_Ingreso.Id_Ingreso = Convert.ToInt32(TxtId_Ingreso.Text);
                        Detalle_Ingreso.Id_Producto = Convert.ToInt32(row.Cells[0].Value.ToString());
                        Detalle_Ingreso.Nombre = Convert.ToString(row.Cells[1].Value.ToString());
                        Detalle_Ingreso.Cantidad = Convert.ToInt32(row.Cells[2].Value.ToString());
                        Detalle_Ingreso.Costo_Unitario = Convert.ToDecimal(row.Cells[3].Value.ToString());
                        Detalle_Ingreso.Sub_Total = Convert.ToDecimal(row.Cells[4].Value.ToString());

                        Detalle_Ingresos.AgregarDetalleIngreso(Detalle_Ingreso);
                    }
                    Ingreso_Produtos.AgregarIngreso(Ingreso_Producto);

                    MessageBox.Show("Ingreso de productos Fue Agregado Correctamente", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Procedimientos.LimpiarControles(this);
                    TxtId_Detalle.Text = string.Empty;
                    TxtTotalPagar.Text = "0.00";
                    Agregar();
                    LimpiarDetalle();
                    LimpiarCampos();
                    Correlativo();
                    return true;


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El Ingreso De Producto No Fue Agregrado Por: "+ex.Message,"Agregar Ingreso Producto",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
