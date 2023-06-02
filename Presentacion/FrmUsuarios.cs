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
    public partial class FrmUsuarios : FormBase
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CboTipodeBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        CL_Procedimientos Procedimientos =new CL_Procedimientos();
        CL_Usuarios Usuarios = new CL_Usuarios();
        CE_Usuarios Usuario = new CE_Usuarios();

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false;//id
            dataGridView1.Columns[4].Visible = false;//contraseña


            dataGridView1.Columns[1].Width = 300;//nombre
            dataGridView1.Columns[2].Width = 300;//Apellido
            dataGridView1.Columns[3].Width = 230;//Usuario
            

            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Usuarios");
            dataGridView1.ClearSelection();
        }
        private void AgUsa_UpdateEventHandler(object sender, FrmAgregarUsuario.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void EdUsa_UpdateEventHandler(object sender, FrmEditarUsuario.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario agregarUsuario = new FrmAgregarUsuario(this);
            agregarUsuario.UpdateEventHandler += AgUsa_UpdateEventHandler;
            agregarUsuario.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        FrmEditarUsuario editarUsuario = new FrmEditarUsuario(this);
                        editarUsuario.UpdateEventHandler += EdUsa_UpdateEventHandler;
                        editarUsuario.TxtIdUsuario.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        editarUsuario.TxtNombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        editarUsuario.TxtApellido.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        editarUsuario.TxtUsuario.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        editarUsuario.TxtContra.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                        
                        editarUsuario.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Ha Seleccionado Un Usuario Para Editar", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No Hay Registros Para Eliminar", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        DialogResult Resultados = MessageBox.Show("Esta Seguro Que Quiere Eliminar Este Usuario", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Usuario.Id_Usuario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                            Usuarios.EliminarUsuario(Usuario);
                            CargarDatos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe Seleccionar un Registros Para Eliminar", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboTipodeBusqueda.Text == "Usuario")
                {
                    Usuario.Buscar = TxtBuscarUsuario.Text.Trim();
                    dataGridView1.DataSource = Usuarios.Buscar_Usuario(Usuario);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Venta No Fue Encontrado Por: " + ex, "Buscar Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
