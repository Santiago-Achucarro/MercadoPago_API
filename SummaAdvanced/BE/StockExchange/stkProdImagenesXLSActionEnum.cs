using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 10 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkProdImagenesXLSActionEnum
        {            public enum EnumstkProdImagenesXLSAction
            {
                Guardar
            }
        public static string GetAccionstkProdImagenesXLSAction(stkProdImagenesXLSActionEnum.EnumstkProdImagenesXLSAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProdImagenesXLSActionEnum.EnumstkProdImagenesXLSAction.Guardar: lRetorno = "stkProdImagenesXLSGuardar"; break;
            }
            return lRetorno;
        }
    }
}
