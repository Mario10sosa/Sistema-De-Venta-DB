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
    public partial class FrmCompras : FormBase
    {
        public FrmCompras()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Ingreso_Productos IngresoProductos = new CL_Ingreso_Productos();
        CE_Ingreso_Productos IngresoProducto = new CE_Ingreso_Productos();
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false; // id ingreso
            dataGridView1.Columns[1].Visible = false; // id ingreso


            dataGridView1.Columns[2].Width = 160;//numero ingreso
            dataGridView1.Columns[3].Width = 370;//nombre proveedor
            dataGridView1.Columns[4].Width = 180;//Fecha ingreso
            dataGridView1.Columns[5].Width = 200;//comprobante
            dataGridView1.Columns[6].Width = 180;//monto total
            dataGridView1.Columns[7].Width = 180;//estado

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Format ="#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);


        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = IngresoProductos.MostrarIngresoProductos();
            dataGridView1.ClearSelection();
        }
        private void AgIn_UpdateEventHandler(object sender, FrmAgregarIngresoProducto.UpdateEventArgs arg)
        {
            CargarDatos();
        }

        private void AnIn_UpdateEventHandler(object sender, FrmAnularIngresoProducto.UpdateEventArgs arg)
        {
            CargarDatos();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarIngresoProducto AgregarProducto = new FrmAgregarIngresoProducto(this);
            AgregarProducto.UpdateEventHandler += AgIn_UpdateEventHandler;
            AgregarProducto.ShowDialog();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
           if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay Compras para Anular","Anular Compra",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if(dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Debe Seleccionar una Compras para Anular", "Anular Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    FrmAnularIngresoProducto anularProducto = new FrmAnularIngresoProducto(this);
                    anularProducto.UpdateEventHandler += AnIn_UpdateEventHandler;
                    anularProducto.TxtId_Ingreso.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    anularProducto.TxtId_Proveedor.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    anularProducto.TxtNo_Ingreso.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    anularProducto.TxtNomProveedor.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    anularProducto.dtpFecha_Ingreso.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    anularProducto.TxtComprobante.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    anularProducto.TxtTotalPagar.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    anularProducto.ShowDialog();
                }
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.Rows.Count != 0)
                {
                    Informen.FrmMostrar_Ingreso Mostrar = new Informen.FrmMostrar_Ingreso();
                    Mostrar.Id_Ingreso = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Ingreso"].Value.ToString());
                    Mostrar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un registro por favor", "Ingreso Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe Seleccionar un registro por favor","Ingreso Productos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboTipodeBusqueda.Text == "Nombre")
                {
                    IngresoProducto.Buscar = TxtBuscarCompras.Text.Trim();
                    dataGridView1.DataSource = IngresoProductos.Buscar_IngresoProducto_Proveedor(IngresoProducto);
                }
                else if (CboTipodeBusqueda.Text == "Fecha_Ingreso")
                {
                    IngresoProducto.Buscar = TxtBuscarCompras.Text.Trim();
                    dataGridView1.DataSource = IngresoProductos.Buscar_IngresoProducto_Fecha(IngresoProducto);
                }
                else if (CboTipodeBusqueda.Text == "Comprobante")
                {
                    IngresoProducto.Buscar = TxtBuscarCompras.Text.Trim();
                    dataGridView1.DataSource = IngresoProductos.Buscar_IngresoProducto_Comprobante(IngresoProducto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Compra No Fue Encontrado Por: " + ex, "Buscar Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
