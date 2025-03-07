using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 2 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impArcibaActionEnum
        {            public enum EnumimpArcibaAction
            {
                Guardar
            }
        public static string GetAccionimpArcibaAction(impArcibaActionEnum.EnumimpArcibaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impArcibaActionEnum.EnumimpArcibaAction.Guardar: lRetorno = "impArcibaGuardar"; break;
            }
            return lRetorno;
        }
    }
}
