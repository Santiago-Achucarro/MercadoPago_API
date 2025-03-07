using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 6 de noviembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proRecetasXLSActionEnum
        {            public enum EnumproRecetasXLSAction
            {
                Guardar
            }
        public static string GetAccionproRecetasXLSAction(proRecetasXLSActionEnum.EnumproRecetasXLSAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proRecetasXLSActionEnum.EnumproRecetasXLSAction.Guardar: lRetorno = "proRecetasXLSGuardar"; break;
            }
            return lRetorno;
        }
    }
}
