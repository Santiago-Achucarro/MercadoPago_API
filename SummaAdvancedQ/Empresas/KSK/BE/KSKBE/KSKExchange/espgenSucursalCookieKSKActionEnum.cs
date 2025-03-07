using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 14 de junio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class espgenSucursalCookieKSKActionEnum
        {            public enum EnumespgenSucursalCookieKSKAction
            {
                Guardar,Datos
            }
        public static string GetAccionespgenSucursalCookieKSKAction(espgenSucursalCookieKSKActionEnum.EnumespgenSucursalCookieKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espgenSucursalCookieKSKActionEnum.EnumespgenSucursalCookieKSKAction.Guardar: lRetorno = "espgenSucursalCookieKSKGuardar"; break;
                case espgenSucursalCookieKSKActionEnum.EnumespgenSucursalCookieKSKAction.Datos: lRetorno = "espgenSucursalCookieKSKDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
