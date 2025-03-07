using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 12 de junio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviConsignaActionEnum
        {            public enum EnumstkMoviConsignaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviConsignaAction(stkMoviConsignaActionEnum.EnumstkMoviConsignaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviConsignaActionEnum.EnumstkMoviConsignaAction.Guardar: lRetorno = "stkMoviConsignaGuardar"; break;
                case stkMoviConsignaActionEnum.EnumstkMoviConsignaAction.Datos: lRetorno = "stkMoviConsignaDevolverDatos"; break;
                case stkMoviConsignaActionEnum.EnumstkMoviConsignaAction.Eliminar: lRetorno = "stkMoviConsignaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
