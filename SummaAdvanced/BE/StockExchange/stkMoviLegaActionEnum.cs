using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de septiembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviLegaActionEnum
        {            public enum EnumstkMoviLegaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviLegaAction(stkMoviLegaActionEnum.EnumstkMoviLegaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviLegaActionEnum.EnumstkMoviLegaAction.Guardar: lRetorno = "stkMoviLegaGuardar"; break;
                case stkMoviLegaActionEnum.EnumstkMoviLegaAction.Datos: lRetorno = "stkMoviLegaDevolverDatos"; break;
                case stkMoviLegaActionEnum.EnumstkMoviLegaAction.Eliminar: lRetorno = "stkMoviLegaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
