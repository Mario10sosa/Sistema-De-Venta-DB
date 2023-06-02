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
    public partial class FrmMostrar_Facturas : Form
    {
        public FrmMostrar_Facturas()
        {
            InitializeComponent();
        }
        private int Id_Venta;

        public int Id_Venta1 { get => Id_Venta; set => Id_Venta = value; }

        private void FrmMostrar_Facturas_Load(object sender, EventArgs e)
        {
            this.sP_Mostrar_FacturaTableAdapter.Fill(datos_Generales.SP_Mostrar_Factura, Id_Venta1);
            this.reportViewer1.RefreshReport();
        }
    }
}
