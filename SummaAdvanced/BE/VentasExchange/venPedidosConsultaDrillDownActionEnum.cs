using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 19 de enero de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPedidosConsultaDrillDownActionEnum
        {            public enum EnumvenPedidosConsultaDrillDownAction
            {
                Datos
            }
        public static string GetAccionvenPedidosConsultaDrillDownAction(venPedidosConsultaDrillDownActionEnum.EnumvenPedidosConsultaDrillDownAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPedidosConsultaDrillDownActionEnum.EnumvenPedidosConsultaDrillDownAction.Datos: lRetorno = "venPedidosConsultaDrillDownDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
