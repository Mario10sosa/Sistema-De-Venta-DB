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
    public class CL_Detalle_Ingresos
    {
        CD_Detalle_Ingresos ObjDetalle_Ingresos = new CD_Detalle_Ingresos();

        public void AgregarDetalleIngreso(CE_Detalle_Ingresos Detalles)
        {
            ObjDetalle_Ingresos.AgregarDetalleIngreso(Detalles);
        }

        public void EliminarDetalleIngreso(CE_Detalle_Ingresos Detalles)
        {
            ObjDetalle_Ingresos.EliminarDetalleIngreso(Detalles);
        }

        public DataTable MostrarIngresoProducto(int Id_Ingreso)
        {
           
            return ObjDetalle_Ingresos.MostrarIngresoProducto(Id_Ingreso);

        }
    }
}
