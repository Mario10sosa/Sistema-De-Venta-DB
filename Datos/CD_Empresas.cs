using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;
using System.Windows.Forms;
using Entidad.Caches;

namespace Datos
{
    public class CD_Empresas
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Agregar Empresa a la base de datos
        public void AgregarEmpresa(CE_Empresas empresas)
        {
            Cmd = new SqlCommand("AgregarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre", empresas.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Nit", empresas.Nit));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", empresas.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", empresas.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", empresas.Email));
            Cmd.Parameters.Add(new SqlParameter("@Logo", empresas.Logo));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Edita Un Empresa en la base de datos

        public void EditarEmpresa(CE_Empresas empresas)
        {
            Cmd = new SqlCommand("EditarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre", empresas.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Nit", empresas.Nit));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", empresas.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", empresas.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", empresas.Email));
            Cmd.Parameters.Add(new SqlParameter("@Logo", empresas.Logo));
            Cmd.Parameters.Add(new SqlParameter("@Id_Empresa", empresas.Id_Empresa));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Eliminar Un empresa en la base de datos
        public void EliminarEmpresa(CE_Empresas empresas)
        {
            Cmd = new SqlCommand("EliminarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Empresa", empresas.Id_Empresa));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
       
    }
}
