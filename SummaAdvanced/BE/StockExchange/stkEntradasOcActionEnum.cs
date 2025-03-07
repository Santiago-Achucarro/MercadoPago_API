using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 13 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkEntradasOcActionEnum
    {
        public enum EnumstkEntradasOcAction
        {
            Guardar, Datos, Eliminar, Todas
        }
        public static string GetAccionstkEntradasOcAction(stkEntradasOcActionEnum.EnumstkEntradasOcAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkEntradasOcActionEnum.EnumstkEntradasOcAction.Guardar: lRetorno = "stkEntradasOcGuardar"; break;
                case stkEntradasOcActionEnum.EnumstkEntradasOcAction.Datos: lRetorno = "stkEntradasOcDevolverDatos"; break;
                case stkEntradasOcActionEnum.EnumstkEntradasOcAction.Eliminar: lRetorno = "stkEntradasOcEliminar"; break;
                case stkEntradasOcActionEnum.EnumstkEntradasOcAction.Todas: lRetorno = "stkEntradasOcTodas"; break;
            }
            return lRetorno;
        }
    }
}
