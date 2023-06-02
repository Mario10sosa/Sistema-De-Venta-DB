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
    public partial class FrmClientes : FormBase
    {
        public FrmClientes()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Clientes Clientes = new CL_Clientes();
        CE_Clientes Cliente = new CE_Clientes();


        private void FrmClientes_Load(object sender, EventArgs e)
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

        private void AgClie_UpdateEventHandler(object sender, FrmAgregarCliente.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void EdClie_UpdateEventHandler(object sender, FrmEditarCliente.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente AgregarCliente = new FrmAgregarCliente(this);
            AgregarCliente.UpdateEventHandler += AgClie_UpdateEventHandler;
            AgregarCliente.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        FrmEditarCliente editarCliente = new FrmEditarCliente(this);
                        editarCliente.UpdateEventHandler += EdClie_UpdateEventHandler;
                        editarCliente.TxtId_Cliente.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        editarCliente.TxtCodigoCliente.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        editarCliente.TxtNombreCliente.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        editarCliente.TxtCedula.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        editarCliente.TxtDireccion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        editarCliente.MTxtTelefono.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        editarCliente.TxtEmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        editarCliente.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Ha Seleccionado Un Cliente Para Editar", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No Hay Registros Para Eliminar", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        DialogResult Resultados = MessageBox.Show("Esta Seguro Que Quiere Eliminar Este Cliente", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Cliente.Id_Cliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                            Clientes.EliminarCliente(Cliente);
                            CargarDatos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe Seleccionar un Registros Para Eliminar", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        public override void Buscar()
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
