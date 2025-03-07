using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 30 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCompCartaPorteUbiActionEnum
        {            public enum EnumvenCompCartaPorteUbiAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCompCartaPorteUbiAction(venCompCartaPorteUbiActionEnum.EnumvenCompCartaPorteUbiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCompCartaPorteUbiActionEnum.EnumvenCompCartaPorteUbiAction.Guardar: lRetorno = "venCompCartaPorteUbiGuardar"; break;
                case venCompCartaPorteUbiActionEnum.EnumvenCompCartaPorteUbiAction.Datos: lRetorno = "venCompCartaPorteUbiDevolverDatos"; break;
                case venCompCartaPorteUbiActionEnum.EnumvenCompCartaPorteUbiAction.Eliminar: lRetorno = "venCompCartaPorteUbiEliminar"; break;
            }
            return lRetorno;
        }
    }
}
