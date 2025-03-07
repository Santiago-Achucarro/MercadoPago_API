using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comListaNegraActionEnum
        {            public enum EnumcomListaNegraAction
            {
                Guardar
            }
        public static string GetAccioncomListaNegraAction(comListaNegraActionEnum.EnumcomListaNegraAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comListaNegraActionEnum.EnumcomListaNegraAction.Guardar: lRetorno = "comListaNegraGuardar"; break;
            }
            return lRetorno;
        }
    }
}
