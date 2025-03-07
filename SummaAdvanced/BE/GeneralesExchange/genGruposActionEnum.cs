using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genGruposActionEnum
        {            public enum EnumgenGruposAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenGruposAction(genGruposActionEnum.EnumgenGruposAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genGruposActionEnum.EnumgenGruposAction.Guardar: lRetorno = "genGruposGuardar"; break;
                case genGruposActionEnum.EnumgenGruposAction.Datos: lRetorno = "genGruposDevolverDatos"; break;
                case genGruposActionEnum.EnumgenGruposAction.Eliminar: lRetorno = "genGruposEliminar"; break;
            }
            return lRetorno;
        }
    }
}
