using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkExistenciasXDepositoActionEnum
        {            public enum EnumstkExistenciasXDepositoAction
            {
                Datos
            }
        public static string GetAccionstkExistenciasXDepositoAction(stkExistenciasXDepositoActionEnum.EnumstkExistenciasXDepositoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciasXDepositoActionEnum.EnumstkExistenciasXDepositoAction.Datos: lRetorno = "stkExistenciasXDepositoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
