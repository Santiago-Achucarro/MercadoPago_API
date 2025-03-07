using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 22 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAtributosValoresXLSActionEnum
        {            public enum EnumgenAtributosValoresXLSAction
            {
                Guardar
            }
        public static string GetAcciongenAtributosValoresXLSAction(genAtributosValoresXLSActionEnum.EnumgenAtributosValoresXLSAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAtributosValoresXLSActionEnum.EnumgenAtributosValoresXLSAction.Guardar: lRetorno = "genAtributosValoresXLSGuardar"; break;
            }
            return lRetorno;
        }
    }
}
