using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;
using System.Windows.Forms;

namespace Datos
{
    public class CD_Proveedores
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Agregar Proveedor a la base de datos
        public void AgregarProveedor(CE_Proveedores proveedores)
        {
            Cmd = new SqlCommand("AgregarProveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", proveedores.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", proveedores.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Nit", proveedores.Nit));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", proveedores.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", proveedores.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", proveedores.Email));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }


        //Edita Un proveedor en la base de datos

        public void EditarProveedor(CE_Proveedores proveedores)
        {
            Cmd = new SqlCommand("EditarProveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", proveedores.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", proveedores.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Nit", proveedores.Nit));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", proveedores.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", proveedores.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Email", proveedores.Email));
            Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", proveedores.Id_Proveedor));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Eliminar Un proveedor en la base de datos
        public void EliminarProveedor(CE_Proveedores proveedores)
        {
            Cmd = new SqlCommand("EliminarProveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", proveedores.Id_Proveedor));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Buscar Por Codigo
        public DataTable Buscar_Proveedor_Codigo(CE_Proveedores proveedores)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Proveedor_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Por Nombre
        public DataTable Buscar_Proveedor_Nombre(CE_Proveedores proveedores)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Proveedor_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Por Nit
        public DataTable Buscar_Proveedor_Nit(CE_Proveedores proveedores)
        {
            Dt = new DataTable("Nit");
            Cmd = new SqlCommand("Buscar_Proveedor_Nit", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", proveedores.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }


    }
}
