using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Logica
{
    public class CL_Ventas
    {
        CD_Ventas ObjVenta = new CD_Ventas();
        public void AgregarVenta(CE_Ventas ventas)
        {
            ObjVenta.AgregarVenta(ventas);
        }

        public void AnularVenta(CE_Ventas ventas)
        {
            ObjVenta.AnularVenta(ventas);
        }

        public DataTable MostrarVenta()
        {
            return ObjVenta.MostrarVenta();
        }

        public DataTable Mostrar_Productos_Ventas()
        {
            return ObjVenta.Mostrar_Productos_Ventas();
        }

        //Buscar Venta Cliente
        public DataTable BuscarVentaCliente(CE_Ventas ventas)
        {
            return ObjVenta.BuscarVentaCliente(ventas);
        }

        //Buscar Venta Comprobante
        public DataTable BuscarVentaComprobante(CE_Ventas ventas)
        {
            return ObjVenta.BuscarVentaComprobante(ventas);
        }
    }
}
