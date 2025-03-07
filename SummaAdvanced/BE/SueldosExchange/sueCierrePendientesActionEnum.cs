using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, November 15, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueCierrePendientesActionEnum
        {            public enum EnumsueCierrePendientesAction
            {
                Datos
            }
        public static string GetAccionsueCierrePendientesAction(sueCierrePendientesActionEnum.EnumsueCierrePendientesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueCierrePendientesActionEnum.EnumsueCierrePendientesAction.Datos: lRetorno = "sueCierrePendientesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
