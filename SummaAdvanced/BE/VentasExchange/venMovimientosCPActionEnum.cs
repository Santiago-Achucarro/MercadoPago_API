using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 23 de noviembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosCPActionEnum
        {            public enum EnumvenMovimientosCPAction
            {
                Guardar,Datos,Descargar
            }
        public static string GetAccionvenMovimientosCPAction(venMovimientosCPActionEnum.EnumvenMovimientosCPAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosCPActionEnum.EnumvenMovimientosCPAction.Guardar: lRetorno = "venMovimientosCPGuardar"; break;
                case venMovimientosCPActionEnum.EnumvenMovimientosCPAction.Datos: lRetorno = "venMovimientosCPDevolverDatos"; break;
                case venMovimientosCPActionEnum.EnumvenMovimientosCPAction.Descargar: lRetorno = "venMovimientosCPDescargar"; break;
            }
            return lRetorno;
        }
    }
}
