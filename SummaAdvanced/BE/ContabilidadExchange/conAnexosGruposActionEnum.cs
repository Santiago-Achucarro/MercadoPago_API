using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 6 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAnexosGruposActionEnum
        {            public enum EnumconAnexosGruposAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconAnexosGruposAction(conAnexosGruposActionEnum.EnumconAnexosGruposAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAnexosGruposActionEnum.EnumconAnexosGruposAction.Guardar: lRetorno = "conAnexosGruposGuardar"; break;
                case conAnexosGruposActionEnum.EnumconAnexosGruposAction.Datos: lRetorno = "conAnexosGruposDevolverDatos"; break;
                case conAnexosGruposActionEnum.EnumconAnexosGruposAction.Eliminar: lRetorno = "conAnexosGruposEliminar"; break;
            }
            return lRetorno;
        }
    }
}
