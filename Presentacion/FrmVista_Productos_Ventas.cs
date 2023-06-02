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
    public partial class FrmVista_Productos_Ventas : FormBase
    {
        public FrmVista_Productos_Ventas()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Ventas ventas = new CL_Ventas();

        private void FrmVista_Productos_Ventas_Load(object sender, EventArgs e)
        {
            Mostrar_Productos_Ventas();

            dataGridView1.Columns[0].Visible = false;//id

            dataGridView1.Columns[1].Width = 150;//codigoBarra
            dataGridView1.Columns[2].Width = 150;//codigo
            dataGridView1.Columns[3].Width = 290;//nombre
            dataGridView1.Columns[4].Width = 140;//TipoCargo
            dataGridView1.Columns[5].Width = 140;//stock actual
            dataGridView1.Columns[6].Width = 150;//precio venta
            dataGridView1.Columns[7].Width = 150;//presentacion
            

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void Mostrar_Productos_Ventas()
        {
            dataGridView1.DataSource = ventas.Mostrar_Productos_Ventas();

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

    }
}
