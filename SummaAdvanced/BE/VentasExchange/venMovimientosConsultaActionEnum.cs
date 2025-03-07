using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 26 de julio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosConsultaActionEnum
        {            public enum EnumvenMovimientosConsultaAction
            {
                Datos
            }
        public static string GetAccionvenMovimientosConsultaAction(venMovimientosConsultaActionEnum.EnumvenMovimientosConsultaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosConsultaActionEnum.EnumvenMovimientosConsultaAction.Datos: lRetorno = "venMovimientosConsultaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
