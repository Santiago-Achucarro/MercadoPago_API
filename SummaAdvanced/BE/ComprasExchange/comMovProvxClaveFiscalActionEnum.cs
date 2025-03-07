using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de marzo de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvxClaveFiscalActionEnum
        {            public enum EnumcomMovProvxClaveFiscalAction
            {
                Datos
            }
        public static string GetAccioncomMovProvxClaveFiscalAction(comMovProvxClaveFiscalActionEnum.EnumcomMovProvxClaveFiscalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvxClaveFiscalActionEnum.EnumcomMovProvxClaveFiscalAction.Datos: lRetorno = "comMovProvxClaveFiscalDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
