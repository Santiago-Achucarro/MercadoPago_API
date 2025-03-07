using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proExploProgramaFaltantesActionEnum
        {            public enum EnumproExploProgramaFaltantesAction
            {
                Faltantes
            }
        public static string GetAccionproExploProgramaFaltantesAction(proExploProgramaFaltantesActionEnum.EnumproExploProgramaFaltantesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proExploProgramaFaltantesActionEnum.EnumproExploProgramaFaltantesAction.Faltantes: lRetorno = "proExploProgramaFaltantesFaltantes"; break;
            }
            return lRetorno;
        }
    }
}
