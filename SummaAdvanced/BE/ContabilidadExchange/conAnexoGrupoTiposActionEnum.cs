using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 6 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAnexoGrupoTiposActionEnum
        {            public enum EnumconAnexoGrupoTiposAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionconAnexoGrupoTiposAction(conAnexoGrupoTiposActionEnum.EnumconAnexoGrupoTiposAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAnexoGrupoTiposActionEnum.EnumconAnexoGrupoTiposAction.Guardar: lRetorno = "conAnexoGrupoTiposGuardar"; break;
                case conAnexoGrupoTiposActionEnum.EnumconAnexoGrupoTiposAction.Eliminar: lRetorno = "conAnexoGrupoTiposEliminar"; break;
            }
            return lRetorno;
        }
    }
}
