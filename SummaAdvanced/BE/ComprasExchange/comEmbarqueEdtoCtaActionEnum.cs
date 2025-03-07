using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 16 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comEmbarqueEdtoCtaActionEnum
        {            public enum EnumcomEmbarqueEdtoCtaAction
            {
                Datos,Aplicar,Cerrar
            }
        public static string GetAccioncomEmbarqueEdtoCtaAction(comEmbarqueEdtoCtaActionEnum.EnumcomEmbarqueEdtoCtaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comEmbarqueEdtoCtaActionEnum.EnumcomEmbarqueEdtoCtaAction.Datos: lRetorno = "comEmbarqueEdtoCtaDevolverDatos"; break;
                case comEmbarqueEdtoCtaActionEnum.EnumcomEmbarqueEdtoCtaAction.Aplicar: lRetorno = "comEmbarqueEdtoCtaAplicar"; break;
                case comEmbarqueEdtoCtaActionEnum.EnumcomEmbarqueEdtoCtaAction.Cerrar: lRetorno = "comEmbarqueEdtoCtaCerrar"; break;
            }
            return lRetorno;
        }
    }
}
