using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 27 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venCompCartaPorteOrigenActionEnum
    {
        public enum EnumvenCompCartaPorteOrigenAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionvenCompCartaPorteOrigenAction(venCompCartaPorteOrigenActionEnum.EnumvenCompCartaPorteOrigenAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCompCartaPorteOrigenActionEnum.EnumvenCompCartaPorteOrigenAction.Guardar: lRetorno = "venCompCartaPorteOrigenGuardar"; break;
                case venCompCartaPorteOrigenActionEnum.EnumvenCompCartaPorteOrigenAction.Datos: lRetorno = "venCompCartaPorteOrigenDevolverDatos"; break;
                case venCompCartaPorteOrigenActionEnum.EnumvenCompCartaPorteOrigenAction.Eliminar: lRetorno = "venCompCartaPorteOrigenEliminar"; break;
            }
            return lRetorno;
        }
    }
}
