using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 14 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comHabilitarPagosMasivosActionEnum
    {
        public enum EnumcomHabilitarPagosMasivosAction
        {
            Datos, Guardar, CalcularTotal, MarcarTodos, DesMarcarTodos
        }
        public static string GetAccioncomHabilitarPagosMasivosAction(comHabilitarPagosMasivosActionEnum.EnumcomHabilitarPagosMasivosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comHabilitarPagosMasivosActionEnum.EnumcomHabilitarPagosMasivosAction.Datos: lRetorno = "comHabilitarPagosMasivosDevolverDatos"; break;
                case comHabilitarPagosMasivosActionEnum.EnumcomHabilitarPagosMasivosAction.Guardar: lRetorno = "comHabilitarPagosMasivosGuardar"; break;
                case comHabilitarPagosMasivosActionEnum.EnumcomHabilitarPagosMasivosAction.CalcularTotal: lRetorno = "comHabilitarPagosMasivosCalcularTotal"; break;
                case comHabilitarPagosMasivosActionEnum.EnumcomHabilitarPagosMasivosAction.DesMarcarTodos: lRetorno = "comHabilitarPagosMasivosDesMarcarTodos"; break;
                case comHabilitarPagosMasivosActionEnum.EnumcomHabilitarPagosMasivosAction.MarcarTodos:lRetorno = "comHabilitarPagosMasivosMarcarTodos"; break;

            }
            return lRetorno;
        }
    }
}
