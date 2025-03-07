using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 18 de enero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genCancSaldosCuentaActionEnum
        {            public enum EnumgenCancSaldosCuentaAction
            {
                Datos
            }
        public static string GetAcciongenCancSaldosCuentaAction(genCancSaldosCuentaActionEnum.EnumgenCancSaldosCuentaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genCancSaldosCuentaActionEnum.EnumgenCancSaldosCuentaAction.Datos: lRetorno = "genCancSaldosCuentaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
