using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CD_Tipo_Comprobantes
    {

        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;

        //Agregar tipo de comprobante a la base de datos
        public void AgregarTipoComprobante(CE_Tipo_Comprobantes Tipocomprobantes)
        {
            Cmd = new SqlCommand("AgregarTipoComprobante", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Tipocomprobantes.Nombre_Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Comprobante", Tipocomprobantes.Tipo_Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Correlativo", Tipocomprobantes.Correlativo));
         
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Editar tipo de comprobante en la base de datos

        public void EditarTipoComprobante(CE_Tipo_Comprobantes Tipocomprobantes)
        {
            Cmd = new SqlCommand("EditarTipoComprobante", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Tipocomprobantes.Nombre_Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Comprobante", Tipocomprobantes.Tipo_Comprobante));
            Cmd.Parameters.Add(new SqlParameter("@Correlativo", Tipocomprobantes.Correlativo));
            Cmd.Parameters.Add(new SqlParameter("@Id_Comprobante", Tipocomprobantes.Id_Comprobante));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        public void ActualizarComprobante(CE_Tipo_Comprobantes Comprobantes)
        {
            Cmd = new SqlCommand("ActualizarComprobante", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Correlativo", Comprobantes.Correlativo));
            Cmd.Parameters.Add(new SqlParameter("@Id_Comprobante", Comprobantes.Id_Comprobante));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
    }
}
