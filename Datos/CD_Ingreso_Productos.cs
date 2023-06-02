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
    public class CD_Ingreso_Productos
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;
        
        SqlDataAdapter Da;
        DataTable Dt;

        public void AgregarIngreso(CE_Ingreso_Productos Ingresos)
        {
            Cmd = new SqlCommand("Agregar_Ingreso_Productos", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@No_Ingreso", Ingresos.No_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", Ingresos.Id_Proveedor));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", Ingresos.Fecha_Ingreso));
            Cmd.Parameters.Add(new SqlParameter("@Comprobante", Ingresos.Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ingresos.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Estado", Ingresos.Estado));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();

        }

        public void EliminarIngreso(CE_Ingreso_Productos Ingresos)
        {

            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Ingreso_Producto Where Id_Ingreso=" + Ingresos.Id_Ingreso + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }

            Dr.Close();

            if (Estado == "Anulado")
            {
                MessageBox.Show("La Compra Ya Ha Sido Anulada, Selecione ota Compra Por Favor", "Anular Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                Cmd = new SqlCommand("Eliminar_Ingreso_Productos", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@No_Ingreso", Ingresos.No_Ingreso));
                Cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", Ingresos.Id_Proveedor));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", Ingresos.Fecha_Ingreso));
                Cmd.Parameters.Add(new SqlParameter("@Comprobante", Ingresos.Comprobante));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", Ingresos.Monto_Total));
                Cmd.Parameters.Add(new SqlParameter("@Estado", Ingresos.Estado));
                Cmd.Parameters.Add(new SqlParameter("@Id_Ingreso", Ingresos.Id_Ingreso));
                Cmd.ExecuteNonQuery();

                MessageBox.Show("La Compra Fue Eliminada Correctamente", "Anular Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Con.Cerrar();

            }

        }


        public DataTable MostrarIngresoProductos()
        {
            DataTable Dt = new DataTable("Ingreso Productos");
            Cmd = new SqlCommand("Mostrar_Ingreso", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Dr.Close();
            Con.Cerrar();
            

            return Dt;
        }

        //Buscar Por Proveedor
        public DataTable Buscar_IngresoProducto_Proveedor(CE_Ingreso_Productos Ingresos)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_IngresoProducto_Proveedor", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Ingresos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Por Fecha ingreso
        public DataTable Buscar_IngresoProducto_Fecha(CE_Ingreso_Productos Ingresos)
        {
            Dt = new DataTable("Fecha_Ingreso");
            Cmd = new SqlCommand("Buscar_IngresoProducto_Fecha", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Ingresos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar_IngresoProducto_Comprobante
        public DataTable Buscar_IngresoProducto_Comprobante(CE_Ingreso_Productos Ingresos)
        {
            Dt = new DataTable("Comprobante");
            Cmd = new SqlCommand("Buscar_IngresoProducto_Comprobante", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Ingresos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }


    }
}
