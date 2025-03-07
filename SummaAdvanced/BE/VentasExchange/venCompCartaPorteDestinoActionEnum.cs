using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 27 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCompCartaPorteDestinoActionEnum
        {            public enum EnumvenCompCartaPorteDestinoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCompCartaPorteDestinoAction(venCompCartaPorteDestinoActionEnum.EnumvenCompCartaPorteDestinoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCompCartaPorteDestinoActionEnum.EnumvenCompCartaPorteDestinoAction.Guardar: lRetorno = "venCompCartaPorteDestinoGuardar"; break;
                case venCompCartaPorteDestinoActionEnum.EnumvenCompCartaPorteDestinoAction.Datos: lRetorno = "venCompCartaPorteDestinoDevolverDatos"; break;
                case venCompCartaPorteDestinoActionEnum.EnumvenCompCartaPorteDestinoAction.Eliminar: lRetorno = "venCompCartaPorteDestinoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
