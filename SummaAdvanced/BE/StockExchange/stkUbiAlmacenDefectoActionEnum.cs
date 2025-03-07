using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 12 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkUbiAlmacenDefectoActionEnum
        {            public enum EnumstkUbiAlmacenDefectoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkUbiAlmacenDefectoAction(stkUbiAlmacenDefectoActionEnum.EnumstkUbiAlmacenDefectoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkUbiAlmacenDefectoActionEnum.EnumstkUbiAlmacenDefectoAction.Guardar: lRetorno = "stkUbiAlmacenDefectoGuardar"; break;
                case stkUbiAlmacenDefectoActionEnum.EnumstkUbiAlmacenDefectoAction.Datos: lRetorno = "stkUbiAlmacenDefectoDevolverDatos"; break;
                case stkUbiAlmacenDefectoActionEnum.EnumstkUbiAlmacenDefectoAction.Eliminar: lRetorno = "stkUbiAlmacenDefectoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
