using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 30 de abril de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venLPTabCuerpoValorActionEnum
        {            public enum EnumvenLPTabCuerpoValorAction
            {
                Datos
            }
        public static string GetAccionvenLPTabCuerpoValorAction(venLPTabCuerpoValorActionEnum.EnumvenLPTabCuerpoValorAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venLPTabCuerpoValorActionEnum.EnumvenLPTabCuerpoValorAction.Datos: lRetorno = "venLPTabCuerpoValorDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
