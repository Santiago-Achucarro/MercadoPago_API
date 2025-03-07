using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 28 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conFechasCierresActionEnum
        {            public enum EnumconFechasCierresAction
            {
                Datos
            }
        public static string GetAccionconFechasCierresAction(conFechasCierresActionEnum.EnumconFechasCierresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conFechasCierresActionEnum.EnumconFechasCierresAction.Datos: lRetorno = "conFechasCierresDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
