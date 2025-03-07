using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venFacturacionPedidoActionEnum
        {            public enum EnumvenFacturacionPedidoAction
            {
                Guardar,Datos,Imprimir, MarcarTodos, VerificarCompletos, Eliminar, Enviar
            }
        public static string GetAccionvenFacturacionPedidoAction(venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction.Guardar: lRetorno = "venFacturacionPedidoGuardar"; break;
                case venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction.Datos: lRetorno = "venFacturacionPedidoDevolverDatos"; break;
                case venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction.MarcarTodos: lRetorno = "venFacturacionPedidoMarcarTodos"; break;
                case venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction.Imprimir: lRetorno = "venFacturacionPedidoImprimir"; break;
                case venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction.VerificarCompletos: lRetorno = "venFacturacionPedidoVerificarCompletos"; break;
                case venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction.Eliminar: lRetorno = "venFacturacionPedidoEliminar"; break;
                case venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction.Enviar: lRetorno = "venFacturacionPedidoEnviar"; break;
            }
            return lRetorno;
        }
    }
}
