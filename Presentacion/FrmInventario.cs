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
    public partial class FrmInventario : FormBase
    {
        public FrmInventario()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        public static double Total;

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            SumarInventario();

            dataGridView1.Columns[0].Visible = false;//id

            dataGridView1.Columns[1].Width = 150;//codigo
            dataGridView1.Columns[2].Width = 300;//nombre
            dataGridView1.Columns[3].Width = 150;//cantidad
            dataGridView1.Columns[4].Width = 150;//costo unitario
            dataGridView1.Columns[5].Width = 150;//precio venta
            dataGridView1.Columns[6].Width = 150;//monto total
            dataGridView1.Columns[7].Width = 150;// tipo cargo

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Inventario");
            dataGridView1.ClearSelection();
        }

        private void SumarInventario()
        {
            Total = 0;
            foreach(DataGridViewRow Row in dataGridView1.Rows)
            {
                Total += Convert.ToDouble(Row.Cells[6].Value);
                TxtMontoTotal.Text = Total.ToString("N2");
            }
        }

    }
}
