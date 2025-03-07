using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 15 de junio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkEntradasCancRemiPendActionEnum
        {            public enum EnumstkEntradasCancRemiPendAction
            {
                Guardar,Datos,Eliminar,Todas, CalcularTotal
        }
        public static string GetAccionstkEntradasCancRemiPendAction(stkEntradasCancRemiPendActionEnum.EnumstkEntradasCancRemiPendAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkEntradasCancRemiPendActionEnum.EnumstkEntradasCancRemiPendAction.Guardar: lRetorno = "stkEntradasCancRemiPendGuardar"; break;
                case stkEntradasCancRemiPendActionEnum.EnumstkEntradasCancRemiPendAction.Datos: lRetorno = "stkEntradasCancRemiPendDevolverDatos"; break;
                case stkEntradasCancRemiPendActionEnum.EnumstkEntradasCancRemiPendAction.Eliminar: lRetorno = "stkEntradasCancRemiPendEliminar"; break;
                case stkEntradasCancRemiPendActionEnum.EnumstkEntradasCancRemiPendAction.Todas: lRetorno = "stkEntradasCancRemiPendTodas"; break;
                case stkEntradasCancRemiPendActionEnum.EnumstkEntradasCancRemiPendAction.CalcularTotal: lRetorno = "stkEntradasCancRemiPendCalcularTotal"; break;
            }
            return lRetorno;
        }
    }
}
