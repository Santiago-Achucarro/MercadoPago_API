using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 29 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkMoviOCActionEnum
    {
        public enum EnumstkMoviOCAction
        {
            ActuPendiente, Datos, Guardar, Eliminar
        }
        public static string GetAccionstkMoviOCAction(stkMoviOCActionEnum.EnumstkMoviOCAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviOCActionEnum.EnumstkMoviOCAction.ActuPendiente: lRetorno = "stkMoviOCActuPendiente"; break;
                case stkMoviOCActionEnum.EnumstkMoviOCAction.Datos: lRetorno = "stkMoviOCDevolverDatos"; break;
                case stkMoviOCActionEnum.EnumstkMoviOCAction.Guardar: lRetorno = "stkMoviOCGuardar"; break;
                case stkMoviOCActionEnum.EnumstkMoviOCAction.Eliminar: lRetorno = "stkMoviOCEliminar"; break;
            }
            return lRetorno;
        }
    }
}
