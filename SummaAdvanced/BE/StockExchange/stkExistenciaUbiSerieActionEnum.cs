using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 13 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkExistenciaUbiSerieActionEnum
    {
        public enum EnumstkExistenciaUbiSerieAction
        {
            Datos, Sumar
        }
        public static string GetAccionstkExistenciaUbiSerieAction(stkExistenciaUbiSerieActionEnum.EnumstkExistenciaUbiSerieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciaUbiSerieActionEnum.EnumstkExistenciaUbiSerieAction.Datos: lRetorno = "stkExistenciaUbiSerieDevolverDatos"; break;
                case stkExistenciaUbiSerieActionEnum.EnumstkExistenciaUbiSerieAction.Sumar: lRetorno = "stkExistenciaUbiSerieSumar"; break;
            }
            return lRetorno;
        }
    }
}
