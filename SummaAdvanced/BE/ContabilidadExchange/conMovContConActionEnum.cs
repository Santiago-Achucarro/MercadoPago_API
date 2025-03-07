using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 19 de octubre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conMovContConActionEnum
        {            public enum EnumconMovContConAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconMovContConAction(conMovContConActionEnum.EnumconMovContConAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conMovContConActionEnum.EnumconMovContConAction.Guardar: lRetorno = "conMovContConGuardar"; break;
                case conMovContConActionEnum.EnumconMovContConAction.Datos: lRetorno = "conMovContConDevolverDatos"; break;
                case conMovContConActionEnum.EnumconMovContConAction.Eliminar: lRetorno = "conMovContConEliminar"; break;
            }
            return lRetorno;
        }
    }
}
