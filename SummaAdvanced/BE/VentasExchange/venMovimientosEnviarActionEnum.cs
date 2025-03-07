using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 3 de febrero de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosEnviarActionEnum
        {            public enum EnumvenMovimientosEnviarAction
            {
                Datos
            }
        public static string GetAccionvenMovimientosEnviarAction(venMovimientosEnviarActionEnum.EnumvenMovimientosEnviarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosEnviarActionEnum.EnumvenMovimientosEnviarAction.Datos: lRetorno = "venMovimientosEnviarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
