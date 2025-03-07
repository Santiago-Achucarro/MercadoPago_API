using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 14 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPedidosAnulActionEnum
        {            public enum EnumvenPedidosAnulAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenPedidosAnulAction(venPedidosAnulActionEnum.EnumvenPedidosAnulAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPedidosAnulActionEnum.EnumvenPedidosAnulAction.Guardar: lRetorno = "venPedidosAnulGuardar"; break;
                case venPedidosAnulActionEnum.EnumvenPedidosAnulAction.Datos: lRetorno = "venPedidosAnulDevolverDatos"; break;
                case venPedidosAnulActionEnum.EnumvenPedidosAnulAction.Eliminar: lRetorno = "venPedidosAnulEliminar"; break;
            }
            return lRetorno;
        }
    }
}
