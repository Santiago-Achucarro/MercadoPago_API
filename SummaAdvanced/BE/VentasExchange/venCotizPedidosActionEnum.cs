using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 6 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
        public static class venCotizPedidosActionEnum
        {            public enum EnumvenCotizPedidosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCotizPedidosAction(venCotizPedidosActionEnum.EnumvenCotizPedidosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCotizPedidosActionEnum.EnumvenCotizPedidosAction.Guardar: lRetorno = "venCotizPedidosGuardar"; break;
                case venCotizPedidosActionEnum.EnumvenCotizPedidosAction.Datos: lRetorno = "venCotizPedidosDevolverDatos"; break;
                case venCotizPedidosActionEnum.EnumvenCotizPedidosAction.Eliminar: lRetorno = "venCotizPedidosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
