using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 8 de octubre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genLinksAyudaTodosActionEnum
        {            public enum EnumgenLinksAyudaTodosAction
            {
                Datos
            }
        public static string GetAcciongenLinksAyudaTodosAction(genLinksAyudaTodosActionEnum.EnumgenLinksAyudaTodosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genLinksAyudaTodosActionEnum.EnumgenLinksAyudaTodosAction.Datos: lRetorno = "genLinksAyudaTodosDevolverdatos"; break;
            }
            return lRetorno;
        }
    }
}
