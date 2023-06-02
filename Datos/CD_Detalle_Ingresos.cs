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
    public class CD_Detalle_Ingresos
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;

        public void AgregarDetalleIngreso(CE_Detalle_Ingresos Detalles)
        {
            Cmd = new SqlCommand("Agregar_Detalle_Ingreso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Detalles.Id_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Detalles.Id_Producto));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Detalles.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Cantidad", Detalles.Cantidad));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Detalles.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Detalles.Sub_Total));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();

        }

        public void EliminarDetalleIngreso(CE_Detalle_Ingresos Detalles)
        {
            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Ingreso_Producto Where Id_Ingreso=" + Detalles.Id_Ingreso + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }

            Dr.Close();

            if (Estado == "Anulado")
            {
                return;
            }
            else
            {

                Cmd = new SqlCommand("Eliminar_Detalle_Ingreso", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Id_Detalle", Detalles.Id_Detalle));
                Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Detalles.Id_Ingreso));
                Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Detalles.Id_Producto));
                Cmd.Parameters.Add(new SqlParameter("@Nombre", Detalles.Nombre));
                Cmd.Parameters.Add(new SqlParameter("@Cantidad", Detalles.Cantidad));
                Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Detalles.Costo_Unitario));
                Cmd.Parameters.Add(new SqlParameter("@Sub_Total", Detalles.Sub_Total));

                Cmd.ExecuteNonQuery();

                Con.Cerrar();

            }
           
        }

        public DataTable MostrarIngresoProducto(int Id_Ingreso)
        {
            DataTable Dt = new DataTable("Detalle Ingreso");
            Cmd = new SqlCommand("MostrarDetalleIngreso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Id_Ingreso));
      
            Cmd.ExecuteNonQuery();

            SqlDataAdapter Da = new SqlDataAdapter(Cmd);  
            Da.Fill(Dt);



            Con.Cerrar();
            return Dt;

        }
    }
}
