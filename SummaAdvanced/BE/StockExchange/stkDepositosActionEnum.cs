using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 13 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkDepositosActionEnum
    {
        public enum EnumstkDepositosAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionstkDepositosAction(stkDepositosActionEnum.EnumstkDepositosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkDepositosActionEnum.EnumstkDepositosAction.Guardar: lRetorno = "stkDepositosGuardar"; break;
                case stkDepositosActionEnum.EnumstkDepositosAction.Datos: lRetorno = "stkDepositosDevolverDatos"; break;
                case stkDepositosActionEnum.EnumstkDepositosAction.Eliminar: lRetorno = "stkDepositosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
