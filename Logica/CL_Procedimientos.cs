using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Logica
{
    public class CL_Procedimientos
    {
        CD_Procedimientos ObjProcedimientos = new CD_Procedimientos();

        //Cagar los datos de una tabla a un datagridview
        public DataTable CargarDatos(string Tabla)
        {
            return ObjProcedimientos.CargarDatos(Tabla);
        }

        //Alterna los colores en la dilas de un datagridview
        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            ObjProcedimientos.AlternarColorFilaDataGridView(Dgv);
        }


        //Generar Codigo
        public string GenerarCodigo(string Tabla)
        {
           return ObjProcedimientos.GenerarCodigo(Tabla);
        }

        //Generar Codigo
        public string GenerarCodigoFactura(string Campo)
        {
            return ObjProcedimientos.GenerarCodigoFactura(Campo);
        }

        //GenerarCodigoId

        public string GenerarCodigoId(string Tabla)
        {
            return ObjProcedimientos.GenerarCodigoId(Tabla);
        }

        //Formato Moneda a una caja de Texto

        public void FormatoMoneda(TextBox xTBox)
        {
            ObjProcedimientos.FormatoMoneda(xTBox);
        }

        //Limpiar Caja de Control
        public void LimpiarControles(Form xForm)
        {
            ObjProcedimientos.LimpiarControles(xForm);
        }

        //LLenar Combo Box
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCbox)
        {
            ObjProcedimientos.LlenarComboBox(Tabla, Nombre, xCbox);
        }
    }
}
