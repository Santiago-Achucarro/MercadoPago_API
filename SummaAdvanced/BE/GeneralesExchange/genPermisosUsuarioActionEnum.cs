using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 25 de junio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genPermisosUsuarioActionEnum
    {
        public enum EnumgenPermisosUsuarioAction
        {
            Guardar, Datos, AsignarHijos
        }
        public static string GetAcciongenPermisosUsuarioAction(genPermisosUsuarioActionEnum.EnumgenPermisosUsuarioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genPermisosUsuarioActionEnum.EnumgenPermisosUsuarioAction.Guardar: lRetorno = "genPermisosUsuarioGuardar"; break;
                case genPermisosUsuarioActionEnum.EnumgenPermisosUsuarioAction.Datos: lRetorno = "genPermisosUsuarioDevolverDatos"; break;
                case genPermisosUsuarioActionEnum.EnumgenPermisosUsuarioAction.AsignarHijos: lRetorno = "genPermisosUsuarioAsignarHijos"; break;
            }
            return lRetorno;
        }
    }
}
