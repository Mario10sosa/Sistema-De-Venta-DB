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
    public partial class FrmAnularVenta : FormBase
    {
        public FrmAnularVenta(FrmVentas Ventas)
        {
            InitializeComponent();
        }
        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Productos Productos = new CL_Productos();
        CL_Ventas Ventas = new CL_Ventas();
        CE_Ventas Venta = new CE_Ventas();
        CL_Tipo_Comprobantes TipoComps = new CL_Tipo_Comprobantes();
        CE_Tipo_Comprobantes TipoComp = new CE_Tipo_Comprobantes();

        CL_Detalle_Ventas DetalleVentas = new CL_Detalle_Ventas();
        CE_Detalle_Ventas DetalleVenta = new CE_Detalle_Ventas();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public static int ContFila = 0;
        public static decimal Total1 = 0, Total2 = 0, Total3 = 0, Total4 = 0, Total5 = 0;
        public static double Importe1 = 0, ImporteNeto = 0, Descuento1 = 0, ITBIS1 = 0, Monto_total = 0, Porcentaje = 0;

       

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Anular()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void FrmAnularVenta_Load(object sender, EventArgs e)
        {
            Procedimientos.FormatoMoneda(TxtSubTotal);
            Procedimientos.FormatoMoneda(TxtDescuento1);
            Procedimientos.FormatoMoneda(TxtITBIS1);
            Procedimientos.FormatoMoneda(TxtMontoTotal);

            
            MostrarDetalleVenta();
            MejorVista();
        }

        private void MejorVista()
        {
            dataGridView1.Columns[0].Visible= false; //id detalle
            dataGridView1.Columns[1].Visible = false; //id producto

            dataGridView1.Columns[2].Width = 220; //nombre
            dataGridView1.Columns[3].Width = 123; //presentacion
            dataGridView1.Columns[4].Width = 100; //cantidad
            dataGridView1.Columns[5].Width = 115; //precio venta
            dataGridView1.Columns[6].Width = 115; //monto total
            dataGridView1.Columns[7].Width = 115; //decuento
            dataGridView1.Columns[8].Width = 115; //itbis
            dataGridView1.Columns[9].Width = 115; //monto total

            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[9].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void MostrarDetalleVenta()
        {
            dataGridView1.DataSource = DetalleVentas.MostrarDetalleVenta(Convert.ToInt32(TxtIdVenta.Text));
            dataGridView1.ClearSelection();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public override void Editar()
        {
            try
            {
                if (TxtIdVenta.Text == string.Empty || TxtNoFactura.Text == string.Empty || TxtIdCliente.Text == string.Empty ||
                    TxtNomCliente.Text == string.Empty || TxtNoComprobante.Text == string.Empty)
                {
                    MessageBox.Show("Debe Completar todos los campos por favor", "Anular Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Esta Seguro Que Quiere Anular Este Registro", "Anular Venta Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {
                        Venta.Id_Venta = Convert.ToInt32(TxtIdVenta.Text.Trim());
                        Venta.No_Factura = TxtNoFactura.Text;
                        Venta.Id_Cliente = Convert.ToInt32(TxtIdCliente.Text);
                        Venta.Fecha_Venta = Convert.ToDateTime(dtpFechaFactura.Text);
                        Venta.Fecha_Validez = Convert.ToDateTime(dtpFechaValidez.Text);
                        Venta.Comprobante = TxtNoComprobante.Text;
                        Venta.Sub_Total = Convert.ToDecimal(TxtSubTotal.Text);
                        Venta.Descuento = Convert.ToDecimal(TxtDescuento1.Text);
                        Venta.ITBIS = Convert.ToDecimal(TxtITBIS1.Text);
                        Venta.Monto_Total = Convert.ToDecimal(TxtMontoTotal.Text);
                        Venta.Estado = "Anulado";
                        Venta.Id_Usuario = 1;


                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            DetalleVenta.Id_Detalle = Convert.ToInt32(row.Cells[0].Value.ToString());
                            DetalleVenta.Id_Venta = Convert.ToInt32(TxtIdVenta.Text);
                            DetalleVenta.Id_Producto = Convert.ToInt32(row.Cells[1].Value.ToString());
                            DetalleVenta.Presentacion = Convert.ToString(row.Cells[3].Value.ToString());
                            DetalleVenta.Cantidad = Convert.ToInt32(row.Cells[4].Value.ToString());
                            DetalleVenta.Precio_venta = Convert.ToDecimal(row.Cells[5].Value.ToString());
                            DetalleVenta.Sub_Total = Convert.ToDecimal(row.Cells[6].Value.ToString());
                            DetalleVenta.Descuento = Convert.ToDecimal(row.Cells[7].Value.ToString());
                            DetalleVenta.ITBIS = Convert.ToDecimal(row.Cells[8].Value.ToString());
                            DetalleVenta.Monto_Total = Convert.ToDecimal(row.Cells[9].Value.ToString());

                            DetalleVentas.AnularDetalleVenta(DetalleVenta);
                        }

                        Ventas.AnularVenta(Venta);
                        this.Close();
                        Anular();
                    }
                    else
                    {
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Venta no fue Anulado por: " + ex.Message, "Anular Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
