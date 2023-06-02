using Entidad;
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
    public partial class FrmVistaClientes : FormBase
    {
        public FrmVistaClientes()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Clientes Clientes = new CL_Clientes();
        CE_Clientes Cliente = new CE_Clientes();

        private void FrmVistaClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false;//id

            dataGridView1.Columns[1].Width = 140;//codigo
            dataGridView1.Columns[2].Width = 280;//nombre
            dataGridView1.Columns[3].Width = 160;//Cedula
            dataGridView1.Columns[4].Width = 340;//direccion
            dataGridView1.Columns[5].Width = 150;//telefono
            dataGridView1.Columns[6].Width = 240;//email

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Clientes");
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

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboTipodeBusqueda.Text == "Codigo")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    dataGridView1.DataSource = Clientes.Buscar_Cliente_Codigo(Cliente);
                }
                else if (CboTipodeBusqueda.Text == "Nombre")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    dataGridView1.DataSource = Clientes.Buscar_Cliente_Nombre(Cliente);
                }
                else if (CboTipodeBusqueda.Text == "Cedula")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    dataGridView1.DataSource = Clientes.Buscar_Cliente_Cedula(Cliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Cliente No Fue Encontrado Por: " + ex, "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
