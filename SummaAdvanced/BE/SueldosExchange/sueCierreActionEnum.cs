using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, November 15, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueCierreActionEnum
        {            public enum EnumsueCierreAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueCierreAction(sueCierreActionEnum.EnumsueCierreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueCierreActionEnum.EnumsueCierreAction.Guardar: lRetorno = "sueCierreGuardar"; break;
                case sueCierreActionEnum.EnumsueCierreAction.Datos: lRetorno = "sueCierreDevolverDatos"; break;
                case sueCierreActionEnum.EnumsueCierreAction.Eliminar: lRetorno = "sueCierreEliminar"; break;
            }
            return lRetorno;
        }
    }
}
