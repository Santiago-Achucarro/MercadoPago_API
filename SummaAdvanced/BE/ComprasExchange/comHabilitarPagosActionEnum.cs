using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 30 de noviembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comHabilitarPagosActionEnum
    {
        public enum EnumcomHabilitarPagosAction
        {
            Guardar, Datos, CalcularTotal, ImportarXls, MarcarTodos, DesMarcarTodos, CambiarFecha
        }
        public static string GetAccioncomHabilitarPagosAction(comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction.Guardar: lRetorno = "comHabilitarPagosGuardar"; break;
                case comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction.Datos: lRetorno = "comHabilitarPagosDevolverDatos"; break;
                case comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction.CalcularTotal: lRetorno = "comHabilitarPagosCalcularTotal"; break;
                case comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction.ImportarXls: lRetorno = "comHabilitarPagosImportarXls"; break;
                case comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction.MarcarTodos: lRetorno = "comHabilitarPagosMarcarTodos"; break;
                case comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction.DesMarcarTodos: lRetorno = "comHabilitarPagosDesMarcarTodos"; break;
                case comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction.CambiarFecha: lRetorno = "comHabilitarPagosCambiarFecha"; break;
            }
            return lRetorno;
        }
    }
}
