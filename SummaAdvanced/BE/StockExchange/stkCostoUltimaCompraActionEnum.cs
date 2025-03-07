using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Wednesday, June 17, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkCostoUltimaCompraActionEnum
        {            public enum EnumstkCostoUltimaCompraAction
            {
                Datos
            }
        public static string GetAccionstkCostoUltimaCompraAction(stkCostoUltimaCompraActionEnum.EnumstkCostoUltimaCompraAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkCostoUltimaCompraActionEnum.EnumstkCostoUltimaCompraAction.Datos: lRetorno = "stkCostoUltimaCompraDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
