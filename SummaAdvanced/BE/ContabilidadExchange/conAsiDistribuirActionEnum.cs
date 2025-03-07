using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 1 de julio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsiDistribuirActionEnum
        {            public enum EnumconAsiDistribuirAction
            {
                Distribuir
            }
        public static string GetAccionconAsiDistribuirAction(conAsiDistribuirActionEnum.EnumconAsiDistribuirAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsiDistribuirActionEnum.EnumconAsiDistribuirAction.Distribuir: lRetorno = "conAsiDistribuirDistribuir"; break;
            }
            return lRetorno;
        }
    }
}
