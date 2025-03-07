using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, November 25, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkConsStockActionEnum
        {            public enum EnumstkConsStockAction
            {
                Datos
            }
        public static string GetAccionstkConsStockAction(stkConsStockActionEnum.EnumstkConsStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkConsStockActionEnum.EnumstkConsStockAction.Datos: lRetorno = "stkConsStockDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
