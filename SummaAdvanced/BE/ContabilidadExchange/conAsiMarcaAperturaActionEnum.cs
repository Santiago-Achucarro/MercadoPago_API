using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 25 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsiMarcaAperturaActionEnum
        {            public enum EnumconAsiMarcaAperturaAction
            {
                Marcar,Datos
            }
        public static string GetAccionconAsiMarcaAperturaAction(conAsiMarcaAperturaActionEnum.EnumconAsiMarcaAperturaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsiMarcaAperturaActionEnum.EnumconAsiMarcaAperturaAction.Marcar: lRetorno = "conAsiMarcaAperturaMarcar"; break;
                case conAsiMarcaAperturaActionEnum.EnumconAsiMarcaAperturaAction.Datos: lRetorno  = "conAsiMarcaAperturaDevolverDatos"; break;

            }
            return lRetorno;
        }
    }
}
