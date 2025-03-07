using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 10 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLiqEmpleadosActionEnum
        {            public enum EnumsueLiqEmpleadosAction
            {
                Datos
            }
        public static string GetAccionsueLiqEmpleadosAction(sueLiqEmpleadosActionEnum.EnumsueLiqEmpleadosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLiqEmpleadosActionEnum.EnumsueLiqEmpleadosAction.Datos: lRetorno = "sueLiqEmpleadosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
