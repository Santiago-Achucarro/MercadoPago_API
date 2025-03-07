using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 7 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsieTipoCuerpoActionEnum
        {            public enum EnumconAsieTipoCuerpoAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionconAsieTipoCuerpoAction(conAsieTipoCuerpoActionEnum.EnumconAsieTipoCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsieTipoCuerpoActionEnum.EnumconAsieTipoCuerpoAction.Guardar: lRetorno = "conAsieTipoCuerpoGuardar"; break;
                case conAsieTipoCuerpoActionEnum.EnumconAsieTipoCuerpoAction.Eliminar: lRetorno = "conAsieTipoCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
