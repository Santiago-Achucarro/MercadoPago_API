using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 4 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkRemiPendFactActionEnum
        {            public enum EnumstkRemiPendFactAction
            {
                Guardar,Datos,Eliminar, ActualizarPend
        }
        public static string GetAccionstkRemiPendFactAction(stkRemiPendFactActionEnum.EnumstkRemiPendFactAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkRemiPendFactActionEnum.EnumstkRemiPendFactAction.Guardar: lRetorno = "stkRemiPendFactGuardar"; break;
                case stkRemiPendFactActionEnum.EnumstkRemiPendFactAction.Datos: lRetorno = "stkRemiPendFactDevolverDatos"; break;
                case stkRemiPendFactActionEnum.EnumstkRemiPendFactAction.Eliminar: lRetorno = "stkRemiPendFactEliminar"; break;
                case stkRemiPendFactActionEnum.EnumstkRemiPendFactAction.ActualizarPend: lRetorno = "stkRemiPendFactActualizarPend"; break;
            }
            return lRetorno;
        }
    }
}
