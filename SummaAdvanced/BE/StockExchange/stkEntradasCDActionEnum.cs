using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 15 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkEntradasCDActionEnum
    {
        public enum EnumstkEntradasCDAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionstkEntradasCDAction(stkEntradasCDActionEnum.EnumstkEntradasCDAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkEntradasCDActionEnum.EnumstkEntradasCDAction.Guardar: lRetorno = "stkEntradasCDGuardar"; break;
                case stkEntradasCDActionEnum.EnumstkEntradasCDAction.Datos: lRetorno = "stkEntradasCDDevolverDatos"; break;
                case stkEntradasCDActionEnum.EnumstkEntradasCDAction.Eliminar: lRetorno = "stkEntradasCDEliminar"; break;
            }
            return lRetorno;
        }
    }
}
