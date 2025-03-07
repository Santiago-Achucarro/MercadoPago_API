using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 2 de julio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkConsKardexActionEnum
        {            public enum EnumstkConsKardexAction
            {
                Datos
            }
        public static string GetAccionstkConsKardexAction(stkConsKardexActionEnum.EnumstkConsKardexAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkConsKardexActionEnum.EnumstkConsKardexAction.Datos: lRetorno = "stkConsKardexDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
