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
    public class CL_Tipo_Comprobantes
    {
        CD_Tipo_Comprobantes ObjTipoComprobante = new CD_Tipo_Comprobantes();

        //Agregar tipo de comprobante en la base de datos
        public void AgregarTipoComprobante(CE_Tipo_Comprobantes Tipocomprobantes)
        {
            ObjTipoComprobante.AgregarTipoComprobante(Tipocomprobantes);
        }

        //Editar tipo de comprobante en la base de datos

        public void EditarTipoComprobante(CE_Tipo_Comprobantes Tipocomprobantes)
        {
            ObjTipoComprobante.EditarTipoComprobante(Tipocomprobantes);
        }

        //Actualizar tipo de comprobante en la base de datos
        public void ActualizarComprobante(CE_Tipo_Comprobantes Comprobantes)
        {
            ObjTipoComprobante.ActualizarComprobante(Comprobantes);
        }
    }
}
