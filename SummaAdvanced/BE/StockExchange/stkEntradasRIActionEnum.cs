using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkEntradasRIActionEnum
    {
        public enum EnumstkEntradasRIAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionstkEntradasRIAction(stkEntradasRIActionEnum.EnumstkEntradasRIAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkEntradasRIActionEnum.EnumstkEntradasRIAction.Guardar: lRetorno = "stkEntradasRIGuardar"; break;
                case stkEntradasRIActionEnum.EnumstkEntradasRIAction.Datos: lRetorno = "stkEntradasRIDevolverDatos"; break;
                case stkEntradasRIActionEnum.EnumstkEntradasRIAction.Eliminar: lRetorno = "stkEntradasRIEliminar"; break;
            }
            return lRetorno;
        }
    }
}
