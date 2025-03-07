using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 13 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class suePagosHabiPendActionEnum
        {            public enum EnumsuePagosHabiPendAction
            {
                Guardar,Datos
            }
        public static string GetAccionsuePagosHabiPendAction(suePagosHabiPendActionEnum.EnumsuePagosHabiPendAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case suePagosHabiPendActionEnum.EnumsuePagosHabiPendAction.Guardar: lRetorno = "suePagosHabiPendGuardar"; break;
                case suePagosHabiPendActionEnum.EnumsuePagosHabiPendAction.Datos: lRetorno = "suePagosHabiPendDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
