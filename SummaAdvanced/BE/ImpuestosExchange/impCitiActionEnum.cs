using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impCitiActionEnum
        {            public enum EnumimpCitiAction
            {
                Guardar
            }
        public static string GetAccionimpCitiAction(impCitiActionEnum.EnumimpCitiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impCitiActionEnum.EnumimpCitiAction.Guardar: lRetorno = "impCitiGuardar"; break;
            }
            return lRetorno;
        }
    }
}
