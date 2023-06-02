using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using Entidad.Caches;

namespace Logica
{
    public class CL_Usuarios
    {
        CD_Usuario ObjUsuario = new CD_Usuario();

        public void AgregarUsuario(CE_Usuarios usuarios)
        {
            ObjUsuario.AgregarUsuario(usuarios);
        }

        //Edita Un Usuario en la base de datos

        public void EditarUsuario(CE_Usuarios usuarios)
        {
            ObjUsuario.EditarUsuario(usuarios);
        }

        //Eliminar Un Usuario en la base de datos
        public void EliminarUsuario(CE_Usuarios usuarios)
        {
            ObjUsuario.EliminarUsuario(usuarios);
        }
        //Buscar Venta Cliente
        public DataTable Buscar_Usuario(CE_Usuarios usuarios)
        {
            return ObjUsuario.Buscar_Usuario(usuarios);
        }

        public DataTable LoginUsuario(CE_Usuarios usuarios)
        {
          return ObjUsuario.LoginUsuario(usuarios);
        }

        public void DatosUsuario(string Usuario)
        {
            ObjUsuario.DatosUsuario(Usuario);
        }

    }
}
