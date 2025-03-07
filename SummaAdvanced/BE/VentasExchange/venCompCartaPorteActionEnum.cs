using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 23 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venCompCartaPorteActionEnum
    {
        public enum EnumvenCompCartaPorteAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionvenCompCartaPorteAction(venCompCartaPorteActionEnum.EnumvenCompCartaPorteAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCompCartaPorteActionEnum.EnumvenCompCartaPorteAction.Guardar: lRetorno = "venCompCartaPorteGuardar"; break;
                case venCompCartaPorteActionEnum.EnumvenCompCartaPorteAction.Datos: lRetorno = "venCompCartaPorteDevolverDatos"; break;
                case venCompCartaPorteActionEnum.EnumvenCompCartaPorteAction.Eliminar: lRetorno = "venCompCartaPorteEliminar"; break;
            }
            return lRetorno;
        }
    }
}
