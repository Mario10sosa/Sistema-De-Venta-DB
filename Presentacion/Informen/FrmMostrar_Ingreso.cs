using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Informen
{
    public partial class FrmMostrar_Ingreso : Form
    {
        public FrmMostrar_Ingreso()
        {
            InitializeComponent();
        }

        private int _Id_Ingreso;

        public int Id_Ingreso { get => _Id_Ingreso; set => _Id_Ingreso = value; }

        private void FrmMostrar_Ingreso_Load(object sender, EventArgs e)
        {
            this.mostrar_Ingreso_ProductosTableAdapter.Fill(this.datos_Generales.Mostrar_Ingreso_Productos, Id_Ingreso);
            this.reportViewer1.RefreshReport();
        }

       
    }
}
