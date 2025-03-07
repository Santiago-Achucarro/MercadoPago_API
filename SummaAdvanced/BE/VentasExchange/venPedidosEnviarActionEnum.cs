using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 22 de febrero de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPedidosEnviarActionEnum
        {            public enum EnumvenPedidosEnviarAction
            {
                Datos
            }
        public static string GetAccionvenPedidosEnviarAction(venPedidosEnviarActionEnum.EnumvenPedidosEnviarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPedidosEnviarActionEnum.EnumvenPedidosEnviarAction.Datos: lRetorno = "venPedidosEnviarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
