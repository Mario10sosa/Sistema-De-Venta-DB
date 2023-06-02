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
    public class CD_Productos
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Agregar Un productos a la base de datos

        public void AgregarProducto(CE_Productos Productos)
        {
            Cmd = new SqlCommand("AgregarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo_Barra", Productos.Codigo_Barra));
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Productos.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Productos.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Descripcion", Productos.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", Productos.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Productos.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", Productos.Precio_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Cargo", Productos.Tipo_Cargo));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Edita Un productos en la base de datos

        public void EditarProducto(CE_Productos Productos)
        {
            Cmd = new SqlCommand("EditarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo_Barra", Productos.Codigo_Barra));
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Productos.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Productos.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Descripcion", Productos.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", Productos.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Productos.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", Productos.Precio_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Cargo", Productos.Tipo_Cargo));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", Productos.Id_Producto));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Eliminar Un productos a la base de datos

        public void EliminarProducto(CE_Productos Productos)
        {
            int Exixtencia = 0;
            Cmd = new SqlCommand("Select Cantidad From Inventario Where Id_Inventario=" + Productos.Id_Producto + "",Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if(Dr.Read()) 
            {
                Exixtencia = Convert.ToInt32(Dr["Cantidad"].ToString());
            }

            Dr.Close();

            if(Exixtencia != 0)
            {
                MessageBox.Show("El Producto Contiene Existencias No Puede Ser Eliminado", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Cmd = new SqlCommand("EliminarProducto", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Id_Producto",Productos.Id_Producto));
                Cmd.ExecuteNonQuery();



                MessageBox.Show("El Producto Fue Eliminado Correctamente", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Con.Cerrar();

            }
        }

        //Buscar Por Codigo
        public DataTable Buscar_Producto_Codigo(CE_Productos Productos)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Producto_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Por Nombre
        public DataTable Buscar_Producto_Nombre(CE_Productos Productos)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Producto_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Por Descripcion
        public DataTable Buscar_Producto_Descripcion(CE_Productos Productos)
        {
            Dt = new DataTable("Descripcion");
            Cmd = new SqlCommand("Buscar_Producto_Descripcion", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", Productos.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        public void Bucar_Productos_por_CodigoBarra(string Nombre, TextBox Control, string xTBox)
        {
            Cmd = new SqlCommand("Buscar_Producto_por_CodigoBarra", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@xTBox", xTBox));
            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Control.Text = Dr[Nombre].ToString();
            }
            Dr.Close();

            Con.Cerrar();
        }
    }
}
