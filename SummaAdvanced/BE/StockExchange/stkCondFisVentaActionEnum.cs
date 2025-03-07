using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 10 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkCondFisVentaActionEnum
        {            public enum EnumstkCondFisVentaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkCondFisVentaAction(stkCondFisVentaActionEnum.EnumstkCondFisVentaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkCondFisVentaActionEnum.EnumstkCondFisVentaAction.Guardar: lRetorno = "stkCondFisVentaGuardar"; break;
                case stkCondFisVentaActionEnum.EnumstkCondFisVentaAction.Datos: lRetorno = "stkCondFisVentaDevolverDatos"; break;
                case stkCondFisVentaActionEnum.EnumstkCondFisVentaAction.Eliminar: lRetorno = "stkCondFisVentaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
