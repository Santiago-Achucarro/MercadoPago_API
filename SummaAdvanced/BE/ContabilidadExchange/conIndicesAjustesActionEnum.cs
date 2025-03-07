using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 25 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange
{
    public static class conIndicesAjustesActionEnum
    {
        public enum EnumconIndicesAjustesAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionconIndicesAjustesAction(conIndicesAjustesActionEnum.EnumconIndicesAjustesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conIndicesAjustesActionEnum.EnumconIndicesAjustesAction.Guardar: lRetorno = "conIndicesAjustesGuardar"; break;
                case conIndicesAjustesActionEnum.EnumconIndicesAjustesAction.Datos: lRetorno = "conIndicesAjustesDevolverDatos"; break;
                case conIndicesAjustesActionEnum.EnumconIndicesAjustesAction.Eliminar: lRetorno = "conIndicesAjustesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
