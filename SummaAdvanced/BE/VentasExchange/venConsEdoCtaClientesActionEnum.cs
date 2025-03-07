using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, March 31, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venConsEdoCtaClientesActionEnum
        {            public enum EnumvenConsEdoCtaClientesAction
            {
                Datos
            }
        public static string GetAccionvenConsEdoCtaClientesAction(venConsEdoCtaClientesActionEnum.EnumvenConsEdoCtaClientesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venConsEdoCtaClientesActionEnum.EnumvenConsEdoCtaClientesAction.Datos: lRetorno = "venConsEdoCtaClientesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
