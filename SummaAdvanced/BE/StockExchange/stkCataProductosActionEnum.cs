using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de julio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkCataProductosActionEnum
        {            public enum EnumstkCataProductosAction
            {
                Datos
            }
        public static string GetAccionstkCataProductosAction(stkCataProductosActionEnum.EnumstkCataProductosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkCataProductosActionEnum.EnumstkCataProductosAction.Datos: lRetorno = "stkCataProductosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
