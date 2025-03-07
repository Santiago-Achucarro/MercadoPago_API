using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, September 3, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueDatoXLSActionEnum
        {            public enum EnumsueDatoXLSAction
            {
                Guardar, Datos
        }
        public static string GetAccionsueDatoXLSAction(sueDatoXLSActionEnum.EnumsueDatoXLSAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueDatoXLSActionEnum.EnumsueDatoXLSAction.Guardar: lRetorno = "sueDatoXLSGuardar"; break;
                case sueDatoXLSActionEnum.EnumsueDatoXLSAction.Datos: lRetorno = "sueDatoXLSDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
