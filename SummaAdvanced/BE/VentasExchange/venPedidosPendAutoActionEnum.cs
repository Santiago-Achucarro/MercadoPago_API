using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 29 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPedidosPendAutoActionEnum
        {            public enum EnumvenPedidosPendAutoAction
            {
                Guardar,Datos
            }
        public static string GetAccionvenPedidosPendAutoAction(venPedidosPendAutoActionEnum.EnumvenPedidosPendAutoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPedidosPendAutoActionEnum.EnumvenPedidosPendAutoAction.Guardar: lRetorno = "venPedidosPendAutoGuardar"; break;
                case venPedidosPendAutoActionEnum.EnumvenPedidosPendAutoAction.Datos: lRetorno = "venPedidosPendAutoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
