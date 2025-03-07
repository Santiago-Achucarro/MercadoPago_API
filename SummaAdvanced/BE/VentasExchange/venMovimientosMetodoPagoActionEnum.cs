using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de septiembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosMetodoPagoActionEnum
        {            public enum EnumvenMovimientosMetodoPagoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovimientosMetodoPagoAction(venMovimientosMetodoPagoActionEnum.EnumvenMovimientosMetodoPagoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosMetodoPagoActionEnum.EnumvenMovimientosMetodoPagoAction.Guardar: lRetorno = "venMovimientosMetodoPagoGuardar"; break;
                case venMovimientosMetodoPagoActionEnum.EnumvenMovimientosMetodoPagoAction.Datos: lRetorno = "venMovimientosMetodoPagoDevolverDatos"; break;
                case venMovimientosMetodoPagoActionEnum.EnumvenMovimientosMetodoPagoAction.Eliminar: lRetorno = "venMovimientosMetodoPagoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
