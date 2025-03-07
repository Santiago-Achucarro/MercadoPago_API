using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conSubCuentasActionEnum
        {            public enum EnumconSubCuentasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconSubCuentasAction(conSubCuentasActionEnum.EnumconSubCuentasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conSubCuentasActionEnum.EnumconSubCuentasAction.Guardar: lRetorno = "conSubCuentasGuardar"; break;
                case conSubCuentasActionEnum.EnumconSubCuentasAction.Datos: lRetorno = "conSubCuentasDevolverDatos"; break;
                case conSubCuentasActionEnum.EnumconSubCuentasAction.Eliminar: lRetorno = "conSubCuentasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
