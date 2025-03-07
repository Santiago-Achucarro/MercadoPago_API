using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 7 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPedidosPorClienteActionEnum
        {            public enum EnumvenPedidosPorClienteAction
            {
                Datos
            }
        public static string GetAccionvenPedidosPorClienteAction(venPedidosPorClienteActionEnum.EnumvenPedidosPorClienteAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPedidosPorClienteActionEnum.EnumvenPedidosPorClienteAction.Datos: lRetorno = "venPedidosPorClienteDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
