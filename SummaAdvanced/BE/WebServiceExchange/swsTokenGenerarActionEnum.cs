using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, October 12, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace WebServiceExchange{
        public static class swsTokenGenerarActionEnum
        {            public enum EnumswsTokenGenerarAction
            {
                Datos
            }
        public static string GetAccionswsTokenGenerarAction(swsTokenGenerarActionEnum.EnumswsTokenGenerarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case swsTokenGenerarActionEnum.EnumswsTokenGenerarAction.Datos: lRetorno = "swsTokenGenerarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
