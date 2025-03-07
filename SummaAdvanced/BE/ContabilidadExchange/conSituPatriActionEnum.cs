using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conSituPatriActionEnum
        {            public enum EnumconSituPatriAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconSituPatriAction(conSituPatriActionEnum.EnumconSituPatriAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conSituPatriActionEnum.EnumconSituPatriAction.Guardar: lRetorno = "conSituPatriGuardar"; break;
                case conSituPatriActionEnum.EnumconSituPatriAction.Datos: lRetorno = "conSituPatriDevolverDatos"; break;
                case conSituPatriActionEnum.EnumconSituPatriAction.Eliminar: lRetorno = "conSituPatriEliminar"; break;
            }
            return lRetorno;
        }
    }
}
