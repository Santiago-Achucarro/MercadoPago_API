using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 9 de marzo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPediSegmentosActionEnum
        {            public enum EnumvenPediSegmentosAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionvenPediSegmentosAction(venPediSegmentosActionEnum.EnumvenPediSegmentosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPediSegmentosActionEnum.EnumvenPediSegmentosAction.Guardar: lRetorno = "venPediSegmentosGuardar"; break;
                case venPediSegmentosActionEnum.EnumvenPediSegmentosAction.Eliminar: lRetorno = "venPediSegmentosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
