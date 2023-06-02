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
    public partial class FrmAgregarVenta : FormBase
    {
        public FrmAgregarVenta(FrmVentas Ventas)
        {
            InitializeComponent();
            CboTipoComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Productos Productos = new CL_Productos();

        CL_Ventas Ventas = new CL_Ventas();
        CE_Ventas Venta = new CE_Ventas();

        CL_Tipo_Comprobantes TipoComps = new CL_Tipo_Comprobantes();
        CE_Tipo_Comprobantes TipoComp = new CE_Tipo_Comprobantes();

        CL_Detalle_Ventas DetalleVentas = new CL_Detalle_Ventas();
        CE_Detalle_Ventas DetalleVenta = new CE_Detalle_Ventas();

        DateTime UltimoDia = new DateTime(DateTime.Now.Year, 12, 31);

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public static int ContFila = 0;
        public static decimal Total1 = 0, Total2 = 0, Total3 = 0, Total4 = 0, Total5 = 0;
        public static double Importe1 = 0, ImporteNeto = 0, Descuento1 = 0, ITBIS1 = 0, Monto_total = 0, Porcentaje = 0;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void FrmAgregarVenta_Load(object sender, EventArgs e)
        {
            GenerarCorrelativo();
            LlenarComboBox();
            MejorVista();
            dtpFechaValidez.Text = Convert.ToString(UltimoDia);
            
        }
        private void GenerarCorrelativo()
        {
            TxtNoFactura.Text = "FACT" + Procedimientos.GenerarCodigo("Ventas");
            TxtIdVenta.Text = Procedimientos.GenerarCodigoId("Ventas");
        }
        private void LlenarComboBox()
        {
            //Procedimientos.LlenarComboBox("Tipos_Comprobantes", "Nombre_Comprobante", CboTipoComprobante);
            CboTipoComprobante.DataSource = Procedimientos.CargarDatos("Tipos_Comprobantes");
            CboTipoComprobante.ValueMember = "Id_Comprobante";
            CboTipoComprobante.DisplayMember = "Nombre_Comprobante";
        }
       
        private void GenerarComprobante()
        {
            string Comprobante = CboTipoComprobante.Text;

            switch (Comprobante)
            {
                case "Factura de Credito Fisical":
                    TxtNoComprobante.Text = "B01" + Procedimientos.GenerarCodigoFactura(CboTipoComprobante.SelectedValue.ToString());
                    break;
                case "Factura de Consumo":
                    TxtNoComprobante.Text = "B02" + Procedimientos.GenerarCodigoFactura(CboTipoComprobante.SelectedValue.ToString());
                    break;
                case "Notas de Debitos":
                    TxtNoComprobante.Text = "B03" + Procedimientos.GenerarCodigoFactura(CboTipoComprobante.SelectedValue.ToString());
                    break;
                case "Notas de Creditos":
                    TxtNoComprobante.Text = "B04" + Procedimientos.GenerarCodigoFactura(CboTipoComprobante.SelectedValue.ToString());
                    break;
                case "Comprobante de Compras":
                    TxtNoComprobante.Text = "B025" + Procedimientos.GenerarCodigoFactura(CboTipoComprobante.SelectedValue.ToString());
                    break;
                case "Registro Unico de Ingresos":
                    TxtNoComprobante.Text = "B016" + Procedimientos.GenerarCodigoFactura(CboTipoComprobante.SelectedValue.ToString());
                    break;
            }
        }
        private void MejorVista()
        {
            dataGridView1.Columns[0].Visible = false;// id Producto

            dataGridView1.Columns[1].Width = 180;//nombre producto
            dataGridView1.Columns[2].Width = 110;//presentacio
            dataGridView1.Columns[3].Width = 110;//cantidad
            dataGridView1.Columns[4].Width = 120;//precio venta
            dataGridView1.Columns[5].Width = 120;//importe
            dataGridView1.Columns[6].Width = 120;//descuento
            dataGridView1.Columns[7].Width = 120;//itbis
            dataGridView1.Columns[8].Width = 120;//total

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;





            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void LlenarCampos()
        {
            try
            {
                Productos.Bucar_Productos_por_CodigoBarra("Id_Producto", TxtIdProducto, TxtCodBarra.Text);
                Productos.Bucar_Productos_por_CodigoBarra("Codigo", TxtCodProducto, TxtCodBarra.Text);
                Productos.Bucar_Productos_por_CodigoBarra("Nombre", TxtNomProducto, TxtCodBarra.Text);
                Productos.Bucar_Productos_por_CodigoBarra("Tipo_Cargo", TxtTipoCargo, TxtCodBarra.Text);
                TxtCantidad.Text = "1";
                Productos.Bucar_Productos_por_CodigoBarra("Cantidad", TxtStockActual, TxtCodBarra.Text);
                Productos.Bucar_Productos_por_CodigoBarra("Precio_Venta", TxtPrecioVenta, TxtCodBarra.Text);
                Productos.Bucar_Productos_por_CodigoBarra("Presentacion", TxtPresentacion, TxtCodBarra.Text);
                CalcularITBIS();
                AgregarDetalle();
                LimpiarDetalle();
                TxtCodBarra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Producto no fue agregado", "Agregar Producto con Lector", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CalcularITBIS()
        {
            try
            {
                if (TxtTipoCargo.Text == "ITBIS 18%" && TxtCantidad.Text != string.Empty)
                {
                    Importe1 = Convert.ToDouble(TxtPrecioVenta.Text) * Convert.ToDouble(TxtCantidad.Text);
                    Descuento1 = Importe1 * Convert.ToDouble(TxtDescuento.Text) / 100;
                    ImporteNeto = Importe1 - Convert.ToDouble(Descuento1.ToString("N2"));
                    ITBIS1 = ImporteNeto * 0.18;
                    TxtITBIS.Text = ITBIS1.ToString("N2");
                    Monto_total = Convert.ToDouble(ImporteNeto + Convert.ToDouble(TxtITBIS.Text));
                    Porcentaje = Descuento1;
                }
                else if (TxtTipoCargo.Text == "ITBIS 16%" && TxtCantidad.Text != string.Empty)
                {
                    Importe1 = Convert.ToDouble(TxtPrecioVenta.Text) * Convert.ToDouble(TxtCantidad.Text);
                    Descuento1 = Importe1 * Convert.ToDouble(TxtDescuento.Text) / 100;
                    ImporteNeto = Importe1 - Convert.ToDouble(Descuento1.ToString("N2"));
                    ITBIS1 = ImporteNeto * 0.16;
                    TxtITBIS.Text = ITBIS1.ToString("N2");
                    Monto_total = Convert.ToDouble(ImporteNeto + Convert.ToDouble(TxtITBIS.Text));
                    Porcentaje = Descuento1;
                }
                else if (TxtTipoCargo.Text == "Exento" && TxtCantidad.Text != string.Empty)
                {
                    Importe1 = Convert.ToDouble(TxtPrecioVenta.Text) * Convert.ToDouble(TxtCantidad.Text);
                    Descuento1 = Importe1 * Convert.ToDouble(TxtDescuento.Text) / 100;
                    ImporteNeto = Importe1 - Convert.ToDouble(Descuento1.ToString("N2"));

                    TxtITBIS.Text = "0.00";
                    Monto_total = Convert.ToDouble(ImporteNeto);
                    Porcentaje = Descuento1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Calcular el ITIBIS por: " + ex.Message, "Calcular ITIBIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            if(TxtDescuento.Text == string.Empty)
            {
                return;
            }
            else
            {
                CalcularITBIS();
            }
        }
        private void TxtNoComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnBuscarProducto.Focus();
                e.Handled = true;
            }
        }
        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtDescuento.Focus();
                e.Handled = true;
            }
        }
        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtITBIS.Focus();
                e.Handled = true;
            }
        }
        private void TxtITBIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnAgregarProducto.Focus();
                e.Handled = true;
            }
        }
        private void CboTipoComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtNoComprobante.Focus();
                e.Handled = true;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void TxtCodBarra_Leave(object sender, EventArgs e)
        {
            if(TxtCodBarra.Text == string.Empty)
            {
                return;
            }
            else
            {
                LlenarCampos();
            }
           
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContFila > 0)
                {
                    Total5 = Total5 - Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                    

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    ContFila--;
                }
                Total1 = 0;
                Total2 = 0;
                Total3 = 0;
                Total4 = 0;
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    Total1 += Convert.ToDecimal(row1.Cells[5].Value);
                    Total2 += Convert.ToDecimal(row1.Cells[6].Value);
                    Total3 += Convert.ToDecimal(row1.Cells[7].Value);
                    Total4 += Convert.ToDecimal(row1.Cells[8].Value);
                }
                TxtSubTotal.Text = Total1.ToString("N2");
                TxtDescuento1.Text = Total2.ToString("N2");
                TxtITBIS1.Text = Total3.ToString("N2");

                TxtMontoTotal.Text = Total4.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Hay Fila Para Eliminar", "Seleccionar Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }
        private void AgregarDetalle()
        {
            try
            {
                if (Convert.ToInt32(TxtCantidad.Text) == 0)
                {
                    MessageBox.Show("No hay existencias de este producto", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if(TxtIdProducto.Text == string.Empty || TxtCodBarra.Text == string.Empty || TxtCodProducto.Text == string.Empty ||
                        TxtNomProducto.Text == string.Empty || TxtTipoCargo.Text == string.Empty || TxtCantidad.Text == string.Empty ||
                        TxtStockActual.Text == string.Empty || TxtPrecioVenta.Text == string.Empty || TxtDescuento.Text == string.Empty ||
                        TxtITBIS.Text == string.Empty || TxtPresentacion.Text == string.Empty)
                    {
                        MessageBox.Show("Debe completar todos los Campos", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        bool Existe = false;
                        int Nofila = 0;

                        if (ContFila == 0)
                        {
                            dataGridView1.Rows.Add(TxtIdProducto.Text,TxtNomProducto.Text,TxtPresentacion.Text,TxtCantidad.Text,TxtPrecioVenta.Text,
                            ImporteNeto.ToString("N2"),Descuento1.ToString("N2"),TxtITBIS.Text,Monto_total.ToString("N2"));

                            dataGridView1.ClearSelection();
                            LimpiarDetalle();
                            BtnBuscarProducto.Focus();

                            ContFila++;
                        }
                        else
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells[0].Value.ToString()==TxtIdProducto.Text)
                                {
                                    Existe = true;
                                }
                            }

                            if (Existe == true)
                            {
                                dataGridView1.Rows[Nofila].Cells[3].Value = Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[Nofila].Cells[3].Value);
                                dataGridView1.Rows[Nofila].Cells[5].Value = (ImporteNeto + Convert.ToDouble(dataGridView1.Rows[Nofila].Cells[5].Value)).ToString("N2");
                                dataGridView1.Rows[Nofila].Cells[6].Value = (Descuento1 + Convert.ToDouble(dataGridView1.Rows[Nofila].Cells[6].Value)).ToString("N2");
                                dataGridView1.Rows[Nofila].Cells[7].Value = (Convert.ToDouble(TxtITBIS.Text) + Convert.ToDouble(dataGridView1.Rows[Nofila].Cells[7].Value)).ToString("N2");
                                dataGridView1.Rows[Nofila].Cells[8].Value = (Monto_total + Convert.ToDouble(dataGridView1.Rows[Nofila].Cells[8].Value)).ToString("N2");

                                LimpiarDetalle();
                            }
                            else
                            {
                                dataGridView1.Rows.Add(TxtIdProducto.Text, TxtNomProducto.Text, TxtPresentacion.Text, TxtCantidad.Text, TxtPrecioVenta.Text,
                                ImporteNeto.ToString("N2"), Descuento1.ToString("N2"), TxtITBIS.Text, Monto_total.ToString("N2"));

                                dataGridView1.ClearSelection();
                                LimpiarDetalle();
                                BtnBuscarProducto.Focus();

                                ContFila++;
                            }
                        }
                        Total1 = 0;
                        Total2 = 0;
                        Total3 = 0;
                        Total4 = 0;
                        foreach (DataGridViewRow row1 in dataGridView1.Rows)
                        {
                            Total1 += Convert.ToDecimal(row1.Cells[5].Value);
                            Total2 += Convert.ToDecimal(row1.Cells[6].Value);
                            Total3 += Convert.ToDecimal(row1.Cells[7].Value);
                            Total4 += Convert.ToDecimal(row1.Cells[8].Value);
                        }
                        TxtSubTotal.Text = Total1.ToString("N2");
                        TxtDescuento1.Text = Total2.ToString("N2");
                        TxtITBIS1.Text = Total3.ToString("N2");

                        TxtMontoTotal.Text = Total4.ToString("N2");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El producto no fue agregado por: " + ex.Message,"Agregar Producto",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void LimpiarDetalle()
        {
            TxtIdProducto.Text = string.Empty;
            TxtCodBarra.Text = string.Empty;
            TxtCodProducto.Text = string.Empty;
            TxtNomProducto.Text = string.Empty;
            TxtTipoCargo.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtStockActual.Text = string.Empty;
            TxtPrecioVenta.Text = string.Empty;
            TxtDescuento.Text = string.Empty;
            TxtITBIS.Text = string.Empty;
            TxtPresentacion.Text = string.Empty;
            BtnBuscarProducto.Focus();
        }
        private void LimpiarCampos()
        {
            TxtIdCliente.Text = string.Empty;
            TxtNoFactura.Text = string.Empty;
            TxtNomCliente.Text = string.Empty;
            CboTipoComprobante.Text = string.Empty;
            TxtNoComprobante.Text = string.Empty;
            dataGridView1.Rows.Clear();
        }
        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmVista_Productos_Ventas vistaProductosventa = new FrmVista_Productos_Ventas();
            vistaProductosventa.ShowDialog();

            try
            {
                if (vistaProductosventa.DialogResult == DialogResult.OK)
                {
                    TxtIdProducto.Text = vistaProductosventa.dataGridView1.Rows[vistaProductosventa.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtCodBarra.Text = vistaProductosventa.dataGridView1.Rows[vistaProductosventa.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    TxtCodProducto.Text = vistaProductosventa.dataGridView1.Rows[vistaProductosventa.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    TxtNomProducto.Text = vistaProductosventa.dataGridView1.Rows[vistaProductosventa.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                    TxtPresentacion.Text = vistaProductosventa.dataGridView1.Rows[vistaProductosventa.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                    TxtPrecioVenta.Text = vistaProductosventa.dataGridView1.Rows[vistaProductosventa.dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                    TxtStockActual.Text = vistaProductosventa.dataGridView1.Rows[vistaProductosventa.dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                    TxtTipoCargo.Text = vistaProductosventa.dataGridView1.Rows[vistaProductosventa.dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();

                    TxtCantidad.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe Seleccionar Un Producto En La Lista", "Seleccionar Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmVistaClientes vistaClientes = new FrmVistaClientes();
            vistaClientes.ShowDialog();

            try
            {
                if (vistaClientes.DialogResult == DialogResult.OK)
                {
                    TxtIdCliente.Text = vistaClientes.dataGridView1.Rows[vistaClientes.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtNomCliente.Text = vistaClientes.dataGridView1.Rows[vistaClientes.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    CboTipoComprobante.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe Seleccionar Un Clientes En La Lista", "Seleccionar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CboTipoComprobante_Leave(object sender, EventArgs e)
        {
            try
            {
                GenerarComprobante();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido generar el comprobante: "+ex.Message,"Generar Comprobante",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        public override bool Guardar()
        {
            try
            {
                if (TxtNoFactura.Text == string.Empty || TxtNomCliente.Text == string.Empty || CboTipoComprobante.Text == string.Empty ||
                    TxtNoComprobante.Text == string.Empty)
                {
                    MessageBox.Show("Debe completar todos los Campos por favor", "Agregar Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Venta.No_Factura = TxtNoFactura.Text;
                    Venta.Id_Cliente = Convert.ToInt32(TxtIdCliente.Text);
                    Venta.Fecha_Venta = Convert.ToDateTime(dtpFechaFactura.Text);
                    Venta.Fecha_Validez = Convert.ToDateTime(dtpFechaValidez.Text);
                    Venta.Comprobante = TxtNoComprobante.Text;
                    Venta.Sub_Total = Convert.ToDecimal(TxtSubTotal.Text);
                    Venta.Descuento = Convert.ToDecimal(TxtDescuento1.Text);
                    Venta.ITBIS = Convert.ToDecimal(TxtITBIS1.Text);
                    Venta.Monto_Total = Convert.ToDecimal(TxtMontoTotal.Text);
                    Venta.Estado = "Emitido";
                    Venta.Id_Usuario = 1;


                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        DetalleVenta.Id_Venta = Convert.ToInt32(TxtIdVenta.Text);
                        DetalleVenta.Id_Producto = Convert.ToInt32(row.Cells[0].Value.ToString());
                        DetalleVenta.Presentacion = Convert.ToString(row.Cells[2].Value.ToString());
                        DetalleVenta.Cantidad = Convert.ToInt32(row.Cells[3].Value.ToString());
                        DetalleVenta.Precio_venta = Convert.ToDecimal(row.Cells[4].Value.ToString());
                        DetalleVenta.Sub_Total = Convert.ToDecimal(row.Cells[5].Value.ToString());
                        DetalleVenta.Descuento = Convert.ToDecimal(row.Cells[6].Value.ToString());
                        DetalleVenta.ITBIS = Convert.ToDecimal(row.Cells[7].Value.ToString());
                        DetalleVenta.Monto_Total = Convert.ToDecimal(row.Cells[8].Value.ToString());

                        DetalleVentas.AgregarDetalleVenta(DetalleVenta);
                    }

                    Ventas.AgregarVenta(Venta);
                    ActualizarComprobante();
                    MessageBox.Show("Venta de Productos agregada correctamente", "Agregar Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(this);
                    TxtSubTotal.Text = "0.00";
                    TxtDescuento1.Text = "0.00";
                    TxtITBIS1.Text = "0.00";
                    TxtMontoTotal.Text = "0.00";
                    Agregar();
                    LimpiarDetalle();
                    LimpiarCampos();
                    GenerarCorrelativo();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Venta de Producto no fue agregada por: " + ex.Message, "Agregar Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void ActualizarComprobante()
        {
            try
            {
                TipoComp.Id_Comprobante = Convert.ToInt32(CboTipoComprobante.SelectedValue.ToString());
                TipoComp.Correlativo = Convert.ToInt32(Procedimientos.GenerarCodigoFactura(CboTipoComprobante.SelectedValue.ToString()));

                TipoComps.ActualizarComprobante(TipoComp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Comprobante no fue Editado por :" + ex.Message, "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
