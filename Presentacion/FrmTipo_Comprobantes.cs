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
    public partial class FrmTipo_Comprobantes : FormBase
    {
        public FrmTipo_Comprobantes()
        {
            InitializeComponent();
        }

        CL_Procedimientos Procedimientos = new CL_Procedimientos();

        private void FrmTipo_Comprobantes_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false; //id

            dataGridView1.Columns[1].Width = 350;//nombre
            dataGridView1.Columns[2].Width = 150;//tipo
            dataGridView1.Columns[3].Width = 150;//correlativo
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Tipos_Comprobantes");
            dataGridView1.ClearSelection();
        }

        private void AgCom_UpdateEventHanler(object sender, FrmAgregarComprobante.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void EdCom_UpdateEventHanler(object sender, FrmEditarComprobante.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarComprobante agregarComprobante = new FrmAgregarComprobante(this);
            agregarComprobante.UpdateEventHandler += AgCom_UpdateEventHanler;
            agregarComprobante.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Registro Para Editar", "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        FrmEditarComprobante editarComprobante = new FrmEditarComprobante(this);
                        editarComprobante.UpdateEventHandler += EdCom_UpdateEventHanler;
                        editarComprobante.TxtId_Comprobante.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        editarComprobante.TxtNomComprobante.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        editarComprobante.TxtTipoComprobante.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        editarComprobante.TxtCorrelativo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                        editarComprobante.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Ha Seleccionado Un Comprobante Para Editar", "Editar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
