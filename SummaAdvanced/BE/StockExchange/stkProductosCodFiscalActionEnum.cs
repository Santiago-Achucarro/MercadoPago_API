using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 25 de junio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkProductosCodFiscalActionEnum
        {            public enum EnumstkProductosCodFiscalAction
            {
                Guardar
            }
        public static string GetAccionstkProductosCodFiscalAction(stkProductosCodFiscalActionEnum.EnumstkProductosCodFiscalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProductosCodFiscalActionEnum.EnumstkProductosCodFiscalAction.Guardar: lRetorno = "stkProductosCodFiscalGuardar"; break;
            }
            return lRetorno;
        }
    }
}
