using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 7 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsientosTipoActionEnum
        {            public enum EnumconAsientosTipoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconAsientosTipoAction(conAsientosTipoActionEnum.EnumconAsientosTipoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsientosTipoActionEnum.EnumconAsientosTipoAction.Guardar: lRetorno = "conAsientosTipoGuardar"; break;
                case conAsientosTipoActionEnum.EnumconAsientosTipoAction.Datos: lRetorno = "conAsientosTipoDevolverDatos"; break;
                case conAsientosTipoActionEnum.EnumconAsientosTipoAction.Eliminar: lRetorno = "conAsientosTipoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
