using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 27 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genUsuarioPermisosEspActionEnum
    {
        public enum EnumgenUsuarioPermisosEspAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAcciongenUsuarioPermiosEspAction(genUsuarioPermisosEspActionEnum.EnumgenUsuarioPermisosEspAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genUsuarioPermisosEspActionEnum.EnumgenUsuarioPermisosEspAction.Guardar: lRetorno = "genUsuarioPermisosEspGuardar"; break;
                case genUsuarioPermisosEspActionEnum.EnumgenUsuarioPermisosEspAction.Datos: lRetorno = "genUsuarioPermisosEspDevolverDatos"; break;
                case genUsuarioPermisosEspActionEnum.EnumgenUsuarioPermisosEspAction.Eliminar: lRetorno = "genUsuarioPermisosEspEliminar"; break;
            }
            return lRetorno;
        }
    }
}
