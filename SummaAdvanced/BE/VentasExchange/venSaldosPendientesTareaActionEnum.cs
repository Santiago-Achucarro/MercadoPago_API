using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, May 20, 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venSaldosPendientesTareaActionEnum
        {            public enum EnumvenSaldosPendientesTareaAction
            {
                Datos
            }
        public static string GetAccionvenSaldosPendientesTareaAction(venSaldosPendientesTareaActionEnum.EnumvenSaldosPendientesTareaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venSaldosPendientesTareaActionEnum.EnumvenSaldosPendientesTareaAction.Datos: lRetorno = "venSaldosPendientesTareaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
