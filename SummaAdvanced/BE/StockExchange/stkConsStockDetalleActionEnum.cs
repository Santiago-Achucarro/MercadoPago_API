using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, November 26, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkConsStockDetalleActionEnum
        {            public enum EnumstkConsStockDetalleAction
            {
                Datos
            }
        public static string GetAccionstkConsStockDetalleAction(stkConsStockDetalleActionEnum.EnumstkConsStockDetalleAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkConsStockDetalleActionEnum.EnumstkConsStockDetalleAction.Datos: lRetorno = "stkConsStockDetalleDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
