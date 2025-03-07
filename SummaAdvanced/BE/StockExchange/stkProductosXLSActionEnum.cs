using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de octubre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkProductosXLSActionEnum
        {            public enum EnumstkProductosXLSAction
            {
                Guardar
            }
        public static string GetAccionstkProductosXLSAction(stkProductosXLSActionEnum.EnumstkProductosXLSAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProductosXLSActionEnum.EnumstkProductosXLSAction.Guardar: lRetorno = "stkProductosXLSGuardar"; break;
            }
            return lRetorno;
        }
    }
}
