using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conActualizarCuentasMovimientosActionEnum
        {            public enum EnumconActualizarCuentasMovimientosAction
            {
                Guardar,Datos
            }
        public static string GetAccionconActualizarCuentasMovimientosAction(conActualizarCuentasMovimientosActionEnum.EnumconActualizarCuentasMovimientosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conActualizarCuentasMovimientosActionEnum.EnumconActualizarCuentasMovimientosAction.Guardar: lRetorno = "conActualizarCuentasMovimientosGuardar"; break;
                case conActualizarCuentasMovimientosActionEnum.EnumconActualizarCuentasMovimientosAction.Datos: lRetorno = "conActualizarCuentasMovimientosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
