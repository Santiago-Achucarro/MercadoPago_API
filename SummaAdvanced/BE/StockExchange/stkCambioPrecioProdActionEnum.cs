using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkCambioPrecioProdActionEnum
        {            public enum EnumstkCambioPrecioProdAction
            {
                Guardar
            }
        public static string GetAccionstkCambioPrecioProdAction(stkCambioPrecioProdActionEnum.EnumstkCambioPrecioProdAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkCambioPrecioProdActionEnum.EnumstkCambioPrecioProdAction.Guardar: lRetorno = "stkCambioPrecioProdGuardar"; break;
            }
            return lRetorno;
        }
    }
}
