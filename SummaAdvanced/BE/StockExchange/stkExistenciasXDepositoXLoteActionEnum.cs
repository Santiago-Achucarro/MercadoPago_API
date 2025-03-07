using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 22 de junio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkExistenciasXDepositoXLoteActionEnum
        {            public enum EnumstkExistenciasXDepositoXLoteAction
            {
                Datos
            }
        public static string GetAccionstkExistenciasXDepositoXLoteAction(stkExistenciasXDepositoXLoteActionEnum.EnumstkExistenciasXDepositoXLoteAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciasXDepositoXLoteActionEnum.EnumstkExistenciasXDepositoXLoteAction.Datos: lRetorno = "stkExistenciasXDepositoXLoteDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
