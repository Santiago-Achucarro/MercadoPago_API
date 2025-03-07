using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 14 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impSifereActionEnum
        {            public enum EnumimpSifereAction
            {
                Guardar
            }
        public static string GetAccionimpSifereAction(impSifereActionEnum.EnumimpSifereAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impSifereActionEnum.EnumimpSifereAction.Guardar: lRetorno = "impSifereGuardar"; break;
            }
            return lRetorno;
        }
    }
}
