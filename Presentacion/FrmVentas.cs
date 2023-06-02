using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion
{
    public partial class FrmVentas : FormBase
    {
        public FrmVentas()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Ventas Ventas = new CL_Ventas();
        CE_Ventas Venta = new CE_Ventas();

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false;//id venta
            dataGridView1.Columns[2].Visible = false;//id cliente


            dataGridView1.Columns[1].Width = 140;//numero factura
            dataGridView1.Columns[3].Width = 250;//nombre cliente
            dataGridView1.Columns[4].Width = 140;//fecha factura
            dataGridView1.Columns[5].Width = 140;//fecha de valider
            dataGridView1.Columns[6].Width = 150;//comprobante
            dataGridView1.Columns[7].Width = 140;//sub total
            dataGridView1.Columns[8].Width = 140;// descuento
            dataGridView1.Columns[9].Width = 140;//itibis
            dataGridView1.Columns[10].Width = 140;//monto total
            dataGridView1.Columns[11].Width = 140;//estado
            dataGridView1.Columns[12].Width = 150;//usuario

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[7].DefaultCellStyle.Format = "#,#0.00";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "#,#0.00";
            dataGridView1.Columns[9].DefaultCellStyle.Format = "#,#0.00";
            dataGridView1.Columns[10].DefaultCellStyle.Format = "#,#0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);

        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Ventas.MostrarVenta();
            dataGridView1.ClearSelection();

        }

        private void AgVen_UpdateEventHandler(object  sender, FrmAgregarVenta.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void AnVen_UpdateEventHandler(object sender, FrmAnularVenta.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarVenta agregarVenta = new FrmAgregarVenta(this);
            agregarVenta.UpdateEventHandler += AgVen_UpdateEventHandler;
            agregarVenta.ShowDialog();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay Compras para Anular", "Anular Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Debe Seleccionar una Compras para Anular", "Anular Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    FrmAnularVenta anularVenta = new FrmAnularVenta(this);
                    anularVenta.UpdateEventHandler += AnVen_UpdateEventHandler;
                    anularVenta.TxtIdVenta.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    anularVenta.TxtNoFactura.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    anularVenta.TxtIdCliente.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    anularVenta.TxtNomCliente.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    anularVenta.dtpFechaFactura.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    anularVenta.dtpFechaValidez.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    anularVenta.TxtNoComprobante.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    anularVenta.TxtSubTotal.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    anularVenta.TxtDescuento1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    anularVenta.TxtITBIS1.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                    anularVenta.TxtMontoTotal.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();

                    anularVenta.ShowDialog();
                }
            }

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    Informen.FrmMostrar_Facturas Mostrar = new Informen.FrmMostrar_Facturas();
                    Mostrar.Id_Venta1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Venta"].Value.ToString());
                    Mostrar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un registro por favor", "Ingreso Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe Seleccionar un registro por favor", "Ingreso Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboTipodeBusqueda.Text == "Nombre")
                {
                    Venta.Buscar = TxtBuscarVentas.Text.Trim();
                    dataGridView1.DataSource = Ventas.BuscarVentaCliente(Venta);
                }
                else if (CboTipodeBusqueda.Text == "Comprobante")
                {
                    Venta.Buscar = TxtBuscarVentas.Text.Trim();
                    dataGridView1.DataSource = Ventas.BuscarVentaComprobante(Venta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Venta No Fue Encontrado Por: " + ex, "Buscar Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
