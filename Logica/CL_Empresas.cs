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
    public class CL_Empresas
    {
        CD_Empresas ObjEmpresa = new CD_Empresas();

        //Agregar Empresa a la base de datos
        public void AgregarEmpresa(CE_Empresas empresas)
        {
            ObjEmpresa.AgregarEmpresa(empresas);
        }

        //Edita Un Empresa en la base de datos

        public void EditarEmpresa(CE_Empresas empresas)
        {
            ObjEmpresa.EditarEmpresa(empresas);
        }

        //Eliminar Un empresa en la base de datos
        public void EliminarEmpresa(CE_Empresas empresas)
        {
            ObjEmpresa.EliminarEmpresa(empresas);
        }
    }
}
