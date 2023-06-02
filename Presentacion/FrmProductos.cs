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
    public partial class FrmProductos : FormBase
    {
        public FrmProductos()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Productos Productos = new CL_Productos();
        CE_Productos Producto = new CE_Productos();

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false;//id

            dataGridView1.Columns[1].Width = 140;//codigoBarra
            dataGridView1.Columns[2].Width = 140;//codigo
            dataGridView1.Columns[3].Width = 260;//nombre
            dataGridView1.Columns[4].Width = 300;//descripcion
            dataGridView1.Columns[5].Width = 150;//presentacion
            dataGridView1.Columns[6].Width = 140;//costo unitario
            dataGridView1.Columns[7].Width = 140;//precio venta
            dataGridView1.Columns[8].Width = 140;//precio venta

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);

        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Productos");
            dataGridView1.ClearSelection();
        }

        private void AgPro_UpdateEventHandler(object sender, FrmAgregarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void EdPro_UpdateEventHandler(object sender, FrmEditarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto AgrProducto = new FrmAgregarProducto(this);
            AgrProducto.UpdateEventHandler += AgPro_UpdateEventHandler;
            AgrProducto.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Productos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if(dataGridView1.SelectedRows == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        FrmEditarProducto editarProducto = new FrmEditarProducto(this);
                        editarProducto.UpdateEventHandler += EdPro_UpdateEventHandler;
                        editarProducto.TxtId_Producto.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        editarProducto.TxtCodBarra.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        editarProducto.TxtCodigoProducto.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        editarProducto.TxtNombreProducto.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        editarProducto.TxtDescripcion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        editarProducto.TxtPresentacion.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        editarProducto.TxtCostoUnitario.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        editarProducto.TxtPrecioVenta.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        editarProducto.cboTipoCargo.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                        editarProducto.ShowDialog();
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("No Ha Seleccionado Un Producto Para Editar","Editar Producto",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registros Para Eliminar", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if(dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Esta Seguro Que Quiere Eliminar Este Producto", "Eliminar Producto",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if(Resultados == DialogResult.Yes)
                        {
                            Producto.Id_Producto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                            Productos.EliminarProducto(Producto);
                            CargarDatos();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Debe Seleccionar un Registros Para Eliminar", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void TxtBuscarproductos_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        public override void Buscar()
        {
            try
            {
                if(CboTipodeBusqueda.Text == "Codigo")
                {
                    Producto.Buscar = TxtBuscarproductos.Text.Trim();
                    dataGridView1.DataSource = Productos.Buscar_Producto_codigo(Producto);
                }
                else if(CboTipodeBusqueda.Text == "Nombre")
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
            catch(Exception ex)
            {
                MessageBox.Show("El Producto No Fue Encontrado Por: "+ex, "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
