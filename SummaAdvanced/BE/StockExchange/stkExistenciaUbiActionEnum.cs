using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 13 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkExistenciaUbiActionEnum
    {
        public enum EnumstkExistenciaUbiAction
        {
            Datos, Sumar
        }
        public static string GetAccionstkExistenciaUbiAction(stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos: lRetorno = "stkExistenciaUbiDevolverDatos"; break;
                case stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Sumar: lRetorno = "stkExistenciaUbiSumar"; break;
            }
            return lRetorno;
        }
    }
}
