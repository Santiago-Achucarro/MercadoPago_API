using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de febrero de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genUsuariosCambiarClaveActionEnum
        {            public enum EnumgenUsuariosCambiarClaveAction
            {
                Guardar
            }
        public static string GetAcciongenUsuariosCambiarClaveAction(genUsuariosCambiarClaveActionEnum.EnumgenUsuariosCambiarClaveAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genUsuariosCambiarClaveActionEnum.EnumgenUsuariosCambiarClaveAction.Guardar: lRetorno = "genUsuariosCambiarClaveGuardar"; break;
            }
            return lRetorno;
        }
    }
}
