using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 9 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conInfDefCuentasActionEnum
        {            public enum EnumconInfDefCuentasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconInfDefCuentasAction(conInfDefCuentasActionEnum.EnumconInfDefCuentasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conInfDefCuentasActionEnum.EnumconInfDefCuentasAction.Guardar: lRetorno = "conInfDefCuentasGuardar"; break;
                case conInfDefCuentasActionEnum.EnumconInfDefCuentasAction.Datos: lRetorno = "conInfDefCuentasDevolverDatos"; break;
                case conInfDefCuentasActionEnum.EnumconInfDefCuentasAction.Eliminar: lRetorno = "conInfDefCuentasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
