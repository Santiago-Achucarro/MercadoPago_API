using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 25 de julio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPediRemitidosActionEnum
        {            public enum EnumvenPediRemitidosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenPediRemitidosAction(venPediRemitidosActionEnum.EnumvenPediRemitidosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPediRemitidosActionEnum.EnumvenPediRemitidosAction.Guardar: lRetorno = "venPediRemitidosGuardar"; break;
                case venPediRemitidosActionEnum.EnumvenPediRemitidosAction.Datos: lRetorno = "venPediRemitidosDevolverDatos"; break;
                case venPediRemitidosActionEnum.EnumvenPediRemitidosAction.Eliminar: lRetorno = "venPediRemitidosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
