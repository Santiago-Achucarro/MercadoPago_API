using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, May 12, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class venMovimientosActionEnum
        {            public enum EnumvenMovimientosAction
            {
                Enviar
            }
        public static string GetAccionvenMovimientosAction(venMovimientosActionEnum.EnumvenMovimientosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosActionEnum.EnumvenMovimientosAction.Enviar: lRetorno = "venMovimientosEnviar"; break;
            }
            return lRetorno;
        }
    }
}
