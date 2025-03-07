using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovContCuentaActionEnum
        {            public enum EnumcomMovContCuentaAction
            {
                Datos
            }
        public static string GetAccioncomMovContCuentaAction(comMovContCuentaActionEnum.EnumcomMovContCuentaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovContCuentaActionEnum.EnumcomMovContCuentaAction.Datos: lRetorno = "comMovContCuentaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
