using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 13 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class suePagosHabiPorEmpleadoActionEnum
        {            public enum EnumsuePagosHabiPorEmpleadoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsuePagosHabiPorEmpleadoAction(suePagosHabiPorEmpleadoActionEnum.EnumsuePagosHabiPorEmpleadoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case suePagosHabiPorEmpleadoActionEnum.EnumsuePagosHabiPorEmpleadoAction.Guardar: lRetorno = "suePagosHabiPorEmpleadoGuardar"; break;
                case suePagosHabiPorEmpleadoActionEnum.EnumsuePagosHabiPorEmpleadoAction.Datos: lRetorno = "suePagosHabiPorEmpleadoDevolverDatos"; break;
                case suePagosHabiPorEmpleadoActionEnum.EnumsuePagosHabiPorEmpleadoAction.Eliminar: lRetorno = "suePagosHabiPorEmpleadoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
