using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conMovContActionEnum
        {            public enum EnumconMovContAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconMovContAction(conMovContActionEnum.EnumconMovContAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conMovContActionEnum.EnumconMovContAction.Guardar: lRetorno = "conMovContGuardar"; break;
                case conMovContActionEnum.EnumconMovContAction.Datos: lRetorno = "conMovContDevolverDatos"; break;
                case conMovContActionEnum.EnumconMovContAction.Eliminar: lRetorno = "conMovContEliminar"; break;
            }
            return lRetorno;
        }
    }
}
