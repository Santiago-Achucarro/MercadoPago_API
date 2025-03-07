using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 31 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange
{
    public static class conCuentasActionEnum
    {
        public enum EnumconCuentasAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionconCuentasAction(conCuentasActionEnum.EnumconCuentasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conCuentasActionEnum.EnumconCuentasAction.Guardar: lRetorno = "conCuentasGuardar"; break;
                case conCuentasActionEnum.EnumconCuentasAction.Datos: lRetorno = "conCuentasDevolverDatos"; break;
                case conCuentasActionEnum.EnumconCuentasAction.Eliminar: lRetorno = "conCuentasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
