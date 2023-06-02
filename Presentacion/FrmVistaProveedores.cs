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
    public partial class FrmVistaProveedores : FormBase
    {
        public FrmVistaProveedores()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Proveedores Proveedores = new CL_Proveedores();
        CE_Proveedores Proveedore = new CE_Proveedores();



        private void FrmVistaProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false;//id

            dataGridView1.Columns[1].Width = 140;//codigo
            dataGridView1.Columns[2].Width = 280;//nombre
            dataGridView1.Columns[3].Width = 160;//Nit
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
            dataGridView1.DataSource = Procedimientos.CargarDatos("Proveedores");
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void TxtBuscarproveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboTipodeBusqueda.Text == "Codigo")
                {
                    Proveedore.Buscar = TxtBuscarproveedor.Text.Trim();
                    dataGridView1.DataSource = Proveedores.Buscar_Proveedor_Codigo(Proveedore);
                }
                else if (CboTipodeBusqueda.Text == "Nombre")
                {
                    Proveedore.Buscar = TxtBuscarproveedor.Text.Trim();
                    dataGridView1.DataSource = Proveedores.Buscar_Proveedor_Nombre(Proveedore);
                }
                else if (CboTipodeBusqueda.Text == "Nit")
                {
                    Proveedore.Buscar = TxtBuscarproveedor.Text.Trim();
                    dataGridView1.DataSource = Proveedores.Buscar_Proveedor_Nit(Proveedore);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Proveedor No Fue Encontrado Por: " + ex, "Buscar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
