using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 7 de julio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genGruposPertenceActionEnum
        {            public enum EnumgenGruposPertenceAction
            {
                Pertenece
            }
        public static string GetAcciongenGruposPertenceAction(genGruposPertenceActionEnum.EnumgenGruposPertenceAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genGruposPertenceActionEnum.EnumgenGruposPertenceAction.Pertenece: lRetorno = "genGruposPertencePertenece"; break;
            }
            return lRetorno;
        }
    }
}
