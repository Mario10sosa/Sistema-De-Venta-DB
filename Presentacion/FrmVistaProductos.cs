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
    public partial class FrmVistaProductos : FormBase
    {
        public FrmVistaProductos()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Productos Productos = new CL_Productos();
        CE_Productos Producto = new CE_Productos();
        private void FrmVistaProductos_Load(object sender, EventArgs e)
        {
            MejorVista();
        }

        private void MejorVista()
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false;//id

            dataGridView1.Columns[1].Width = 140;//codigo
            dataGridView1.Columns[2].Width = 260;//nombre
            dataGridView1.Columns[3].Width = 300;//descripcion
            dataGridView1.Columns[4].Width = 150;//presentacion
            dataGridView1.Columns[5].Width = 140;//costo unitario
            dataGridView1.Columns[6].Width = 140;//precio venta

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);

        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Productos");
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void TxtBuscarproductos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboTipodeBusqueda.Text == "Codigo")
                {
                    Producto.Buscar = TxtBuscarproductos.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_codigo(Producto);
                }
                else if (CboTipodeBusqueda.Text == "Nombre")
                {
                    Producto.Buscar = TxtBuscarproductos.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_Nombre(Producto);
                }
                else if (CboTipodeBusqueda.Text == "Descripcion")
                {
                    Producto.Buscar = TxtBuscarproductos.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_Descripcion(Producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Producto No Fue Encontrado Por: " + ex, "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    
}
