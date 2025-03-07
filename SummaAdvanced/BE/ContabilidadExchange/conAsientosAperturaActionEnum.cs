using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsientosAperturaActionEnum
        {            public enum EnumconAsientosAperturaAction
            {
                Guardar,Datos
            }
        public static string GetAccionconAsientosAperturaAction(conAsientosAperturaActionEnum.EnumconAsientosAperturaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsientosAperturaActionEnum.EnumconAsientosAperturaAction.Guardar: lRetorno = "conAsientosAperturaGuardar"; break;
                case conAsientosAperturaActionEnum.EnumconAsientosAperturaAction.Datos: lRetorno = "conAsientosAperturaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
