using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proProgramaFechasMrpActionEnum
        {            public enum EnumproProgramaFechasMrpAction
            {
                Calcular
            }
        public static string GetAccionproProgramaFechasMrpAction(proProgramaFechasMrpActionEnum.EnumproProgramaFechasMrpAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proProgramaFechasMrpActionEnum.EnumproProgramaFechasMrpAction.Calcular: lRetorno = "proProgramaFechasMrpCalcular"; break;
            }
            return lRetorno;
        }
    }
}
