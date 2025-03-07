using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 14 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conOrigAplicRengActionEnum
        {            public enum EnumconOrigAplicRengAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconOrigAplicRengAction(conOrigAplicRengActionEnum.EnumconOrigAplicRengAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conOrigAplicRengActionEnum.EnumconOrigAplicRengAction.Guardar: lRetorno = "conOrigAplicRengGuardar"; break;
                case conOrigAplicRengActionEnum.EnumconOrigAplicRengAction.Datos: lRetorno = "conOrigAplicRengDevolverDatos"; break;
                case conOrigAplicRengActionEnum.EnumconOrigAplicRengAction.Eliminar: lRetorno = "conOrigAplicRengEliminar"; break;
            }
            return lRetorno;
        }
    }
}
