using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsieCierreActionEnum
        {            public enum EnumconAsieCierreAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconAsieCierreAction(conAsieCierreActionEnum.EnumconAsieCierreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsieCierreActionEnum.EnumconAsieCierreAction.Guardar: lRetorno = "conAsieCierreGuardar"; break;
                case conAsieCierreActionEnum.EnumconAsieCierreAction.Datos: lRetorno = "conAsieCierreDevolverDatos"; break;
                case conAsieCierreActionEnum.EnumconAsieCierreAction.Eliminar: lRetorno = "conAsieCierreEliminar"; break;
            }
            return lRetorno;
        }
    }
}
