using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidad;

namespace Logica
{
    public class CL_Productos
    {
        CD_Productos ObjProductos = new CD_Productos();

        //Agregar un producto a la base de datos
        public void AgregarProducto(CE_Productos productos)
        {
            ObjProductos.AgregarProducto(productos);
        }

        //Editar un producto en la base de datos
        public void EditarProducto(CE_Productos productos)
        {
            ObjProductos.EditarProducto(productos);
        }

        //Eliminar un producto en la base de datos
        public void EliminarProducto(CE_Productos productos)
        {
            ObjProductos.EliminarProducto(productos);
        }

        //Buscar un producto por codigo en la base de datos
        public DataTable Buscar_Producto_codigo(CE_Productos productos)
        {
           return ObjProductos.Buscar_Producto_Codigo(productos);
        }

        //buscar un producto por nombre en la base de datos
        public DataTable Buscar_Producto_Nombre(CE_Productos productos)
        {
            return ObjProductos.Buscar_Producto_Nombre(productos);
        }

        //buscar un producto por descripcion en la base de datos
        public DataTable Buscar_Producto_Descripcion(CE_Productos productos)
        {
            return ObjProductos.Buscar_Producto_Descripcion(productos);
        }

        public void Bucar_Productos_por_CodigoBarra(string Nombre, TextBox Control, string xTBox)
        {
           ObjProductos.Bucar_Productos_por_CodigoBarra(Nombre, Control, xTBox);
        }
    }
}
