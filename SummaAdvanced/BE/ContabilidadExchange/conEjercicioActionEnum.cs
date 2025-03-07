using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conEjercicioActionEnum
        {            public enum EnumconEjercicioAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconEjercicioAction(conEjercicioActionEnum.EnumconEjercicioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conEjercicioActionEnum.EnumconEjercicioAction.Guardar: lRetorno = "conEjercicioGuardar"; break;
                case conEjercicioActionEnum.EnumconEjercicioAction.Datos: lRetorno = "conEjercicioDevolverDatos"; break;
                case conEjercicioActionEnum.EnumconEjercicioAction.Eliminar: lRetorno = "conEjercicioEliminar"; break;
            }
            return lRetorno;
        }
    }
}
