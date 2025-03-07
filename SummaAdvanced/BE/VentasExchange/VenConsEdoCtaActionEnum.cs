using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de junio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class VenConsEdoCtaActionEnum
        {            public enum EnumVenConsEdoCtaAction
            {
                Datos
            }
        public static string GetAccionVenConsEdoCtaAction(VenConsEdoCtaActionEnum.EnumVenConsEdoCtaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case VenConsEdoCtaActionEnum.EnumVenConsEdoCtaAction.Datos: lRetorno = "VenConsEdoCtaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
