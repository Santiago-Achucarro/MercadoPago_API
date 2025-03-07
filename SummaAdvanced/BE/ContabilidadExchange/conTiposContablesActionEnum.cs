using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conTiposContablesActionEnum
        {            public enum EnumconTiposContablesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconTiposContablesAction(conTiposContablesActionEnum.EnumconTiposContablesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conTiposContablesActionEnum.EnumconTiposContablesAction.Guardar: lRetorno = "conTiposContablesGuardar"; break;
                case conTiposContablesActionEnum.EnumconTiposContablesAction.Datos: lRetorno = "conTiposContablesDevolverDatos"; break;
                case conTiposContablesActionEnum.EnumconTiposContablesAction.Eliminar: lRetorno = "conTiposContablesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
