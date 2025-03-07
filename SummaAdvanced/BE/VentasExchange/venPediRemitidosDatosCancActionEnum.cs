using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, May 25, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPediRemitidosDatosCancActionEnum
        {            public enum EnumvenPediRemitidosDatosCancAction
            {
                Datos
            }
        public static string GetAccionvenPediRemitidosDatosCancAction(venPediRemitidosDatosCancActionEnum.EnumvenPediRemitidosDatosCancAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPediRemitidosDatosCancActionEnum.EnumvenPediRemitidosDatosCancAction.Datos: lRetorno = "venPediRemitidosDatosCancDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
