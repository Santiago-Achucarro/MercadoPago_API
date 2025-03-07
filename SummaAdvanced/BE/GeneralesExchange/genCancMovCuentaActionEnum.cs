using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 29 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genCancMovCuentaActionEnum
        {            public enum EnumgenCancMovCuentaAction
            {
                Datos
            }
        public static string GetAcciongenCancMovCuentaAction(genCancMovCuentaActionEnum.EnumgenCancMovCuentaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genCancMovCuentaActionEnum.EnumgenCancMovCuentaAction.Datos: lRetorno = "genCancMovCuentaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
