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
using System.IO;

namespace Presentacion
{
    public partial class FrmEmpresas : FormBase
    {
        public FrmEmpresas()
        {
            InitializeComponent();
        }
        CL_Procedimientos Procedimientos = new CL_Procedimientos();
        CL_Empresas Empresas = new CL_Empresas();
        CE_Empresas Empresa = new CE_Empresas();
        public OpenFileDialog Examinar = new OpenFileDialog();

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false;//id
            dataGridView1.Columns[6].Visible = false;//logo


            dataGridView1.Columns[1].Width = 280;//nombre
            dataGridView1.Columns[2].Width = 160;//Nit
            dataGridView1.Columns[3].Width = 340;//direccion
            dataGridView1.Columns[4].Width = 150;//telefono
            dataGridView1.Columns[5].Width = 240;//email

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);

        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Empresa");
            dataGridView1.ClearSelection();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                ptbLogo.Image = Properties.Resources.icono_bulding;
            }
            else
            {
                ptbLogo.BackgroundImage = null;
                byte[] i = (byte[])dataGridView1.SelectedRows[0].Cells[6].Value;
                MemoryStream ms = new MemoryStream(i);
                ptbLogo.Image = Image.FromStream(ms);
                ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        //    if (dataGridView1.Rows.Count == 0)
        //    {
        //        ptbLogo.Image = Properties.Resources.icono_bulding;
        //    }
        //    else
        //    {
        //        ptbLogo.BackgroundImage = null;
        //        byte[] i = (byte[])dataGridView1.SelectedRows[0].Cells[6].Value;
        //        MemoryStream ms = new MemoryStream(i);
        //        ptbLogo.Image = Image.FromStream(ms);
        //        ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;

        //    }
        }


        private void AgEmp_UpdateEventHandler(object sender, FrmAgregarEmpresa.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void EdEmp_UpdateEventHandler(object sender, FrmEditarEmpresa.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpresa AgregarEmpresa = new FrmAgregarEmpresa(this);
            AgregarEmpresa.UpdateEventHandler += AgEmp_UpdateEventHandler;
            AgregarEmpresa.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        FrmEditarEmpresa editarEmpresa = new FrmEditarEmpresa(this);
                        editarEmpresa.UpdateEventHandler += EdEmp_UpdateEventHandler;
                        editarEmpresa.TxtId_Empresa.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        editarEmpresa.TxtNombreEmpresa.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        editarEmpresa.TxtNit.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        editarEmpresa.TxtDireccion.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        editarEmpresa.MTxtTelefono.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        editarEmpresa.TxtEmail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                        ptbLogo.BackgroundImage = null;
                        byte[] i = (byte[])dataGridView1.SelectedRows[0].Cells[6].Value;
                        MemoryStream ms = new MemoryStream(i);
                        editarEmpresa.ptbLogo.Image = Image.FromStream(ms);
                        ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;


                        editarEmpresa.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Ha Seleccionado Un Empresa Para Editar", "Editar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No Hay Registros Para Eliminar", "Eliminar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        DialogResult Resultados = MessageBox.Show("Esta Seguro Que Quiere Eliminar Este Empresa", "Eliminar Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Empresa.Id_Empresa = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                            Empresas.EliminarEmpresa(Empresa);
                            CargarDatos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe Seleccionar un Registros Para Eliminar", "Eliminar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

      
    }
}
