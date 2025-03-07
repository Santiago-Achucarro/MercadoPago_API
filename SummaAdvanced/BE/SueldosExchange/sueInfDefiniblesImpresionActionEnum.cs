using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, January 16, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueInfDefiniblesImpresionActionEnum
        {            public enum EnumsueInfDefiniblesImpresionAction
            {
                Datos,Imprimir
            }
        public static string GetAccionsueInfDefiniblesImpresionAction(sueInfDefiniblesImpresionActionEnum.EnumsueInfDefiniblesImpresionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueInfDefiniblesImpresionActionEnum.EnumsueInfDefiniblesImpresionAction.Datos: lRetorno = "sueInfDefiniblesImpresionDevolverDatos"; break;
                case sueInfDefiniblesImpresionActionEnum.EnumsueInfDefiniblesImpresionAction.Imprimir: lRetorno = "sueInfDefiniblesImpresionImprimir"; break;
            }
            return lRetorno;
        }
    }
}
