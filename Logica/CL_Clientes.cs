using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CL_Clientes
    {
        CD_Clientes ObjClientes = new CD_Clientes();

        //Agregar Cliente a la base de datos
        public void AgregarCliente(CE_Clientes clientes)
        {
            ObjClientes.AgregarCliente(clientes);
        }

        //Edita Un Cliente en la base de datos
        public void EditarCliente(CE_Clientes clientes)
        {
           ObjClientes.EditarCliente(clientes);
        }

        //Eliminar Un Cliente en la base de datos
        public void EliminarCliente(CE_Clientes clientes)
        {
            ObjClientes.EliminarCliente(clientes);
        }

        //Buscar Por Codigo
        public DataTable Buscar_Cliente_Codigo(CE_Clientes clientes)
        {
           return ObjClientes.Buscar_Cliente_Codigo(clientes);

        }

        //Buscar Por Nombre
        public DataTable Buscar_Cliente_Nombre(CE_Clientes clientes)
        {
           return ObjClientes.Buscar_Cliente_Nombre(clientes);

        }

        //Buscar Por Cedula
        public DataTable Buscar_Cliente_Cedula(CE_Clientes clientes)
        {
          return ObjClientes.Buscar_Cliente_Cedula(clientes) ;
        }
    }
}
