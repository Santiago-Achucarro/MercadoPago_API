using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 22 de abril de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genSemaforoActionEnum
        {            public enum EnumgenSemaforoAction
            {
                Guardar
            }
        public static string GetAcciongenSemaforoAction(genSemaforoActionEnum.EnumgenSemaforoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genSemaforoActionEnum.EnumgenSemaforoAction.Guardar: lRetorno = "genSemaforoGuardar"; break;
            }
            return lRetorno;
        }
    }
}
