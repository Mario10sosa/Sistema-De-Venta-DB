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
    public partial class FrmAnularIngresoProducto : FormBase
    {
        public FrmAnularIngresoProducto(FrmCompras Compras)
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

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmAnularIngresoProducto_Load(object sender, EventArgs e)
        {
            MostraDetalleIngreso();
            MejorVista();
            Procedimientos.FormatoMoneda(TxtTotalPagar);
        }

        private void MejorVista()
        {
            dataGridView1.Columns[0].Visible = false;// id detalle
            dataGridView1.Columns[1].Visible = false;// id ingreso
            dataGridView1.Columns[2].Visible = false;// id Producto

            dataGridView1.Columns[3].Width = 320;//nombre producto
            dataGridView1.Columns[4].Width = 160;//cantidad
            dataGridView1.Columns[5].Width = 160;//costo unitario
            dataGridView1.Columns[6].Width = 150;// sub total

            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void MostraDetalleIngreso()
        {
            dataGridView1.DataSource = Detalle_Ingresos.MostrarIngresoProducto(Convert.ToInt32(TxtId_Ingreso.Text));
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public override void Editar()
        {
            try
            {
                if (TxtId_Ingreso.Text == string.Empty || TxtNo_Ingreso.Text == string.Empty || TxtId_Proveedor.Text == string.Empty ||
                    TxtNomProveedor.Text == string.Empty || TxtComprobante.Text == string.Empty)
                {
                    MessageBox.Show("Debe Completar todos los campos por favor", "Anular Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Esta Seguro Que Quiere Anular Este Registro", "Anular Ingreso Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {
                        Ingreso_Producto.Id_Ingreso = Convert.ToInt32(TxtId_Ingreso.Text);
                        Ingreso_Producto.No_Ingreso = TxtNo_Ingreso.Text.Trim();
                        Ingreso_Producto.Id_Proveedor = Convert.ToInt32(TxtId_Proveedor.Text);
                        Ingreso_Producto.Fecha_Ingreso = Convert.ToDateTime(dtpFecha_Ingreso.Text);
                        Ingreso_Producto.Comprobante = TxtComprobante.Text;
                        Ingreso_Producto.Monto_Total = Convert.ToDecimal(TxtTotalPagar.Text);
                        Ingreso_Producto.Estado = "Anulado";

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            Detalle_Ingreso.Id_Detalle = Convert.ToInt32(row.Cells[0].Value.ToString());
                            Detalle_Ingreso.Id_Ingreso = Convert.ToInt32(TxtId_Ingreso.Text);
                            Detalle_Ingreso.Id_Producto = Convert.ToInt32(row.Cells[2].Value.ToString());
                            Detalle_Ingreso.Nombre = Convert.ToString(row.Cells[3].Value.ToString());
                            Detalle_Ingreso.Cantidad = Convert.ToInt32(row.Cells[4].Value.ToString());
                            Detalle_Ingreso.Costo_Unitario = Convert.ToDecimal(row.Cells[5].Value.ToString());
                            Detalle_Ingreso.Sub_Total = Convert.ToDecimal(row.Cells[6].Value.ToString());

                            Detalle_Ingresos.EliminarDetalleIngreso(Detalle_Ingreso);

                        }

                        Ingreso_Produtos.EliminarIngreso(Ingreso_Producto);


                        this.Close();
                        Actualizar();
                    }
                    else
                    {
                        return;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El ingreso de productos no fue Anulado por: " + ex.Message, "Anular Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
