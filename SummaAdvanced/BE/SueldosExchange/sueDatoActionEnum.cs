using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, August 27, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueDatoActionEnum
        {            public enum EnumsueDatoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueDatoAction(sueDatoActionEnum.EnumsueDatoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueDatoActionEnum.EnumsueDatoAction.Guardar: lRetorno = "sueDatoGuardar"; break;
                case sueDatoActionEnum.EnumsueDatoAction.Datos: lRetorno = "sueDatoDevolverDatos"; break;
                case sueDatoActionEnum.EnumsueDatoAction.Eliminar: lRetorno = "sueDatoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
