using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, October 12, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace WebServiceExchange{
        public static class swsPermisosActionEnum
        {            public enum EnumswsPermisosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionswsPermisosAction(swsPermisosActionEnum.EnumswsPermisosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case swsPermisosActionEnum.EnumswsPermisosAction.Guardar: lRetorno = "swsPermisosGuardar"; break;
                case swsPermisosActionEnum.EnumswsPermisosAction.Datos: lRetorno = "swsPermisosDevolverDatos"; break;
                case swsPermisosActionEnum.EnumswsPermisosAction.Eliminar: lRetorno = "swsPermisosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
