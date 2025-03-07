using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 20 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venRepartoActionEnum
    {
        public enum EnumvenRepartoAction
        {
            Guardar, Datos, Eliminar, CalcularCuerpo, Cerrar,
            MarcarTodos, Imprimir, DatosIdentity, CambioCantidad
        }
        public static string GetAccionvenRepartoAction(venRepartoActionEnum.EnumvenRepartoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venRepartoActionEnum.EnumvenRepartoAction.Guardar: lRetorno = "venRepartoGuardar"; break;
                case venRepartoActionEnum.EnumvenRepartoAction.Datos: lRetorno = "venRepartoDevolverDatos"; break;
                case venRepartoActionEnum.EnumvenRepartoAction.Eliminar: lRetorno = "venRepartoEliminar"; break;
                case venRepartoActionEnum.EnumvenRepartoAction.CalcularCuerpo: lRetorno = "venRepartoCalcularCuerpo"; break;
                case venRepartoActionEnum.EnumvenRepartoAction.Cerrar: lRetorno = "venRepartoCerrar"; break;
                case venRepartoActionEnum.EnumvenRepartoAction.MarcarTodos: lRetorno = "venRepartoMarcarTodos"; break;
                case venRepartoActionEnum.EnumvenRepartoAction.Imprimir: lRetorno = "venRepartoImprimir"; break;
                case venRepartoActionEnum.EnumvenRepartoAction.DatosIdentity: lRetorno = "venRepartoDatosIdentity"; break;
                case venRepartoActionEnum.EnumvenRepartoAction.CambioCantidad: lRetorno = "venRepartoCambioCantidad"; break;
            }
            return lRetorno;
        }
    }
}
