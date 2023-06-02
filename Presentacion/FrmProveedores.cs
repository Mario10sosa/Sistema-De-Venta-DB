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
    public partial class FrmProveedores : FormBase
    {
        public FrmProveedores()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Proveedores Proveedores = new CL_Proveedores();
        CE_Proveedores Proveedore = new CE_Proveedores();

        private void FrmProveedores_Load(object sender, EventArgs e)
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

        private void AgProv_UpdateEventHandler(object sender, FrmAgregarProveedor.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void EdPro_UpdateEventHandler(object sender, FrmEditarProveedor.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProveedor agregarProveedor = new FrmAgregarProveedor(this);
            agregarProveedor.UpdateEventHandler += AgProv_UpdateEventHandler;
            agregarProveedor.ShowDialog();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridView1.SelectedRows == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        FrmEditarProveedor editarProveedor = new FrmEditarProveedor(this);
                        editarProveedor.UpdateEventHandler += EdPro_UpdateEventHandler;
                        editarProveedor.TxtId_Proveedor.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        editarProveedor.TxtCodigoProveedor.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        editarProveedor.TxtNombreProveedor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        editarProveedor.TxtNit.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        editarProveedor.TxtDireccion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        editarProveedor.MTxtTelefono.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        editarProveedor.TxtEmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        editarProveedor.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Ha Seleccionado Un Proveedor Para Editar", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public override void Eliminar()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registros Para Eliminar", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Esta Seguro Que Quiere Eliminar Este Proveedor", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Proveedore.Id_Proveedor = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                            Proveedores.EliminarProveedor(Proveedore);
                            CargarDatos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe Seleccionar un Registros Para Eliminar", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void TxtBuscarproveedor_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        public override void Buscar()
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
