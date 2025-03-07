using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 31 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conCuentasActualizacionActionEnum
        {            public enum EnumconCuentasActualizacionAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconCuentasActualizacionAction(conCuentasActualizacionActionEnum.EnumconCuentasActualizacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conCuentasActualizacionActionEnum.EnumconCuentasActualizacionAction.Guardar: lRetorno = "conCuentasActualizacionGuardar"; break;
                case conCuentasActualizacionActionEnum.EnumconCuentasActualizacionAction.Datos: lRetorno = "conCuentasActualizacionDevolverDatos"; break;
                case conCuentasActualizacionActionEnum.EnumconCuentasActualizacionAction.Eliminar: lRetorno = "conCuentasActualizacionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
