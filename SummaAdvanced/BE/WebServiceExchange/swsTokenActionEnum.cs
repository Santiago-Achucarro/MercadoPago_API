using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, October 12, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace WebServiceExchange{
        public static class swsTokenActionEnum
        {            public enum EnumswsTokenAction
            {
                Guardar,Datos,Eliminar,Generar
            }
        public static string GetAccionswsTokenAction(swsTokenActionEnum.EnumswsTokenAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case swsTokenActionEnum.EnumswsTokenAction.Guardar: lRetorno = "swsTokenGuardar"; break;
                case swsTokenActionEnum.EnumswsTokenAction.Datos: lRetorno = "swsTokenDevolverDatos"; break;
                case swsTokenActionEnum.EnumswsTokenAction.Eliminar: lRetorno = "swsTokenEliminar"; break;
                case swsTokenActionEnum.EnumswsTokenAction.Generar: lRetorno = "swsTokenGenerar"; break;
            }
            return lRetorno;
        }
    }
}
