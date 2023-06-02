using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Logica
{
    public class CL_Detalle_Ventas
    {
        CD_Detalle_Ventas ObjDetalle_Venta = new CD_Detalle_Ventas();

        public void AgregarDetalleVenta(CE_Detalle_Ventas detalle_Ventas)
        {
            ObjDetalle_Venta.AgregarDetalleVenta(detalle_Ventas);
        }

        public void AnularDetalleVenta(CE_Detalle_Ventas detalle_Ventas)
        {
            ObjDetalle_Venta.AnularDetalleVenta(detalle_Ventas);
        }

        public DataTable MostrarDetalleVenta(int Id_Venta)
        {
            return ObjDetalle_Venta.MostrarDetalleVenta(Id_Venta);
        }
    }
}
