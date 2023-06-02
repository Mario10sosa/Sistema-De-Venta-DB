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
    public class CL_Ingreso_Productos
    {
        CD_Ingreso_Productos ObjIngresoProducto = new CD_Ingreso_Productos();
        public void AgregarIngreso(CE_Ingreso_Productos Ingresos)
        {
            ObjIngresoProducto.AgregarIngreso(Ingresos);
        }

        public void EliminarIngreso(CE_Ingreso_Productos Ingresos)
        {
            ObjIngresoProducto.EliminarIngreso(Ingresos);
        }

        public DataTable MostrarIngresoProductos()
        {
            return ObjIngresoProducto.MostrarIngresoProductos();
        }

        //Buscar Por Proveedor
        public DataTable Buscar_IngresoProducto_Proveedor(CE_Ingreso_Productos Ingresos)
        {
            return ObjIngresoProducto.Buscar_IngresoProducto_Proveedor(Ingresos);
        }

        //Buscar Por Fecha ingreso
        public DataTable Buscar_IngresoProducto_Fecha(CE_Ingreso_Productos Ingresos)
        {
            return ObjIngresoProducto.Buscar_IngresoProducto_Fecha(Ingresos);

        }

        //Buscar_IngresoProducto_Comprobante
        public DataTable Buscar_IngresoProducto_Comprobante(CE_Ingreso_Productos Ingresos)
        {
            return ObjIngresoProducto.Buscar_IngresoProducto_Comprobante(Ingresos);

        }
    }
}
