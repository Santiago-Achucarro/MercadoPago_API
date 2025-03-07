using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 25 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPedidosFacturaAnticipoActionEnum
        {            public enum EnumvenPedidosFacturaAnticipoAction
            {
                Datos
            }
        public static string GetAccionvenPedidosFacturaAnticipoAction(venPedidosFacturaAnticipoActionEnum.EnumvenPedidosFacturaAnticipoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPedidosFacturaAnticipoActionEnum.EnumvenPedidosFacturaAnticipoAction.Datos: lRetorno = "venPedidosFacturaAnticipoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
