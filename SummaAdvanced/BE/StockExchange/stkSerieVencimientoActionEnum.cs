using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 17 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkSerieVencimientoActionEnum
        {            public enum EnumstkSerieVencimientoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkSerieVencimientoAction(stkSerieVencimientoActionEnum.EnumstkSerieVencimientoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkSerieVencimientoActionEnum.EnumstkSerieVencimientoAction.Guardar: lRetorno = "stkSerieVencimientoGuardar"; break;
                case stkSerieVencimientoActionEnum.EnumstkSerieVencimientoAction.Datos: lRetorno = "stkSerieVencimientoDevolverDatos"; break;
                case stkSerieVencimientoActionEnum.EnumstkSerieVencimientoAction.Eliminar: lRetorno = "stkSerieVencimientoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
