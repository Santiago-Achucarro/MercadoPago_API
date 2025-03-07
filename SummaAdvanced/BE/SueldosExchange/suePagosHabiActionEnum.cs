using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 13 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class suePagosHabiActionEnum
        {            public enum EnumsuePagosHabiAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsuePagosHabiAction(suePagosHabiActionEnum.EnumsuePagosHabiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case suePagosHabiActionEnum.EnumsuePagosHabiAction.Guardar: lRetorno = "suePagosHabiGuardar"; break;
                case suePagosHabiActionEnum.EnumsuePagosHabiAction.Datos: lRetorno = "suePagosHabiDevolverDatos"; break;
                case suePagosHabiActionEnum.EnumsuePagosHabiAction.Eliminar: lRetorno = "suePagosHabiEliminar"; break;
            }
            return lRetorno;
        }
    }
}
