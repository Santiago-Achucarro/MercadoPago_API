using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proExploProgramaActionEnum
        {            public enum EnumproExploProgramaAction
            {
                Calcular
        }
        public static string GetAccionproExploProgramaAction(proExploProgramaActionEnum.EnumproExploProgramaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proExploProgramaActionEnum.EnumproExploProgramaAction.Calcular: lRetorno = "proExploProgramaCalcular"; break;
            }
            return lRetorno;
        }
    }
}
