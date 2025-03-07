using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 22 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impSicoreActionEnum
        {            public enum EnumimpSicoreAction
            {
                Guardar
            }
        public static string GetAccionimpSicoreAction(impSicoreActionEnum.EnumimpSicoreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impSicoreActionEnum.EnumimpSicoreAction.Guardar: lRetorno = "impSicoreGuardar"; break;
            }
            return lRetorno;
        }
    }
}
