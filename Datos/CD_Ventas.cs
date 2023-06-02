using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class CD_Ventas
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        public void AgregarVenta(CE_Ventas ventas)
        {
            Cmd = new SqlCommand("AgregarVenta", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", ventas.Id_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@No_Factura", ventas.No_Factura));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", ventas.Fecha_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Validez", ventas.Fecha_Validez));
            Cmd.Parameters.Add(new SqlParameter("@Comprobante", ventas.Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", ventas.Sub_Total));
            Cmd.Parameters.Add(new SqlParameter("@Descuento", ventas.Descuento));
            Cmd.Parameters.Add(new SqlParameter("@ITBIS", ventas.ITBIS));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", ventas.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Estado", ventas.Estado));
            Cmd.Parameters.Add(new SqlParameter("@Id_Usuario", ventas.Id_Usuario));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();

        }

        public void AnularVenta(CE_Ventas ventas)
        {

            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Ventas Where Id_Venta=" + ventas.Id_Venta + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }

            Dr.Close();

            if (Estado == "Anulado")
            {
                MessageBox.Show("La Venta Ya Ha Sido Anulada, Selecione ota Venta Por Favor", "Anular Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                Cmd = new SqlCommand("AnularVenta", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", ventas.Id_Cliente));
                Cmd.Parameters.Add(new SqlParameter("@No_Factura", ventas.No_Factura));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", ventas.Fecha_Venta));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Validez", ventas.Fecha_Validez));
                Cmd.Parameters.Add(new SqlParameter("@Comprobante", ventas.Comprobante));
                Cmd.Parameters.Add(new SqlParameter("@Sub_Total", ventas.Sub_Total));
                Cmd.Parameters.Add(new SqlParameter("@Descuento", ventas.Descuento));
                Cmd.Parameters.Add(new SqlParameter("@ITBIS", ventas.ITBIS));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", ventas.Monto_Total));
                Cmd.Parameters.Add(new SqlParameter("@Estado", ventas.Estado));
                Cmd.Parameters.Add(new SqlParameter("@Id_Usuario", ventas.Id_Usuario));
                Cmd.Parameters.Add(new SqlParameter("@Id_Venta", ventas.Id_Venta));
                Cmd.ExecuteNonQuery();
               

                MessageBox.Show("La Venta Fue Anulada Correctamente", "Anular Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Con.Cerrar();

            }

        }


        public DataTable MostrarVenta()
        {
            DataTable Dt = new DataTable("Venta de Productos");
            Cmd = new SqlCommand("MostrarVenta", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Dr.Close();
            Con.Cerrar();


            return Dt;
        }

       

        public DataTable Mostrar_Productos_Ventas()
        {
            DataTable Dt = new DataTable("Mostrar Productos");
            Cmd = new SqlCommand("Mostrar_Productos_Ventas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Dr.Close();
            Con.Cerrar();


            return Dt;
        }


        //Buscar Venta Cliente
        public DataTable BuscarVentaCliente(CE_Ventas ventas)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("BuscarVentaCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", ventas.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Venta Comprobante
        public DataTable BuscarVentaComprobante(CE_Ventas ventas)
        {
            Dt = new DataTable("Comprobante");
            Cmd = new SqlCommand("BuscarVentaComprobante", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", ventas.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }
    }
}
