using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 7 de julio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosFiscalActionEnum
        {            public enum EnumvenMovimientosFiscalAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovimientosFiscalAction(venMovimientosFiscalActionEnum.EnumvenMovimientosFiscalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosFiscalActionEnum.EnumvenMovimientosFiscalAction.Guardar: lRetorno = "venMovimientosFiscalGuardar"; break;
                case venMovimientosFiscalActionEnum.EnumvenMovimientosFiscalAction.Datos: lRetorno = "venMovimientosFiscalDevolverDatos"; break;
                case venMovimientosFiscalActionEnum.EnumvenMovimientosFiscalAction.Eliminar: lRetorno = "venMovimientosFiscalEliminar"; break;
            }
            return lRetorno;
        }
    }
}
