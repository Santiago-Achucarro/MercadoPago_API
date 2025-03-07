using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 23 de diciembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosConsultaDrillDownActionEnum
        {            public enum EnumvenMovimientosConsultaDrillDownAction
            {
                Datos
            }
        public static string GetAccionvenMovimientosConsultaDrillDownAction(venMovimientosConsultaDrillDownActionEnum.EnumvenMovimientosConsultaDrillDownAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosConsultaDrillDownActionEnum.EnumvenMovimientosConsultaDrillDownAction.Datos: lRetorno = "venMovimientosConsultaDrillDownDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
