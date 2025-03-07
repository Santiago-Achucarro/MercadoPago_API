using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 31 de julio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conCuentasCuentasActionEnum
        {            public enum EnumconCuentasCuentasAction
            {
                Datos
            }
        public static string GetAccionconCuentasCuentasAction(conCuentasCuentasActionEnum.EnumconCuentasCuentasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conCuentasCuentasActionEnum.EnumconCuentasCuentasAction.Datos: lRetorno = "conCuentasCuentasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
