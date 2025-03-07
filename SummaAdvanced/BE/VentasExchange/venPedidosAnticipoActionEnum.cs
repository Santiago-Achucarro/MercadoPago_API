using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 25 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPedidosAnticipoActionEnum
        {            public enum EnumvenPedidosAnticipoAction
        {
            Datos, Guardar, Imprimir
        }
        public static string GetAccionvenPedidosAnticipoAction(venPedidosAnticipoActionEnum.EnumvenPedidosAnticipoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPedidosAnticipoActionEnum.EnumvenPedidosAnticipoAction.Datos: lRetorno = "venPedidosAnticipoDevolverDatos"; break;
                case venPedidosAnticipoActionEnum.EnumvenPedidosAnticipoAction.Guardar: lRetorno = "venPedidosAnticipoGuardar"; break;
                case venPedidosAnticipoActionEnum.EnumvenPedidosAnticipoAction.Imprimir: lRetorno = "venPedidosAnticipoImprimir"; break;
            }
            return lRetorno;
        }
    }
}
