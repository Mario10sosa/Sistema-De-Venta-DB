using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class CL_Proveedores
    {
        CD_Proveedores ObjProveedores = new CD_Proveedores();

        public void AgregarProveedor(CE_Proveedores proveedores)
        {
            ObjProveedores.AgregarProveedor(proveedores);
        }


        //Edita Un proveedor en la base de datos
        public void EditarProveedor(CE_Proveedores proveedores)
        {
            ObjProveedores.EditarProveedor(proveedores);
        }

        //Eliminar Un proveedor en la base de datos
        public void EliminarProveedor(CE_Proveedores proveedores)
        {
            ObjProveedores.EliminarProveedor(proveedores);
        }

        //Buscar Por Codigo
        public DataTable Buscar_Proveedor_Codigo(CE_Proveedores proveedores)
        {
            return ObjProveedores.Buscar_Proveedor_Codigo(proveedores);
        }

        //Buscar Por Nombre
        public DataTable Buscar_Proveedor_Nombre(CE_Proveedores proveedores)
        {
            return ObjProveedores.Buscar_Proveedor_Nombre(proveedores);
        }

        //Buscar Por Nit
        public DataTable Buscar_Proveedor_Nit(CE_Proveedores proveedores)
        {
           return ObjProveedores.Buscar_Proveedor_Nit(proveedores);
        }
    }
}
