using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de septiembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venMovimientosFiscalINEActionEnum
    {
        public enum EnumvenMovimientosFiscalINEAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionvenMovimientosFiscalINEAction(venMovimientosFiscalINEActionEnum.EnumvenMovimientosFiscalINEAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosFiscalINEActionEnum.EnumvenMovimientosFiscalINEAction.Guardar: lRetorno = "venMovimientosFiscalINEGuardar"; break;
                case venMovimientosFiscalINEActionEnum.EnumvenMovimientosFiscalINEAction.Datos: lRetorno = "venMovimientosFiscalINEDevolverDatos"; break;
                case venMovimientosFiscalINEActionEnum.EnumvenMovimientosFiscalINEAction.Eliminar: lRetorno = "venMovimientosFiscalINEEliminar"; break;
            }
            return lRetorno;
        }
    }
}
