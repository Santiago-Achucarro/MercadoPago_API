using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 16 de julio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPedidosAnticipoFactActionEnum
        {            public enum EnumvenPedidosAnticipoFactAction
            {
                Datos
            }
        public static string GetAccionvenPedidosAnticipoFactAction(venPedidosAnticipoFactActionEnum.EnumvenPedidosAnticipoFactAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPedidosAnticipoFactActionEnum.EnumvenPedidosAnticipoFactAction.Datos: lRetorno = "venPedidosAnticipoFactDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
