using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 25 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genEntidadesBasicasValorActionEnum
        {            public enum EnumgenEntidadesBasicasValorAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenEntidadesBasicasValorAction(genEntidadesBasicasValorActionEnum.EnumgenEntidadesBasicasValorAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genEntidadesBasicasValorActionEnum.EnumgenEntidadesBasicasValorAction.Guardar: lRetorno = "genEntidadesBasicasValorGuardar"; break;
                case genEntidadesBasicasValorActionEnum.EnumgenEntidadesBasicasValorAction.Datos: lRetorno = "genEntidadesBasicasValorDevolverDatos"; break;
                case genEntidadesBasicasValorActionEnum.EnumgenEntidadesBasicasValorAction.Eliminar: lRetorno = "genEntidadesBasicasValorEliminar"; break;
            }
            return lRetorno;
        }
    }
}
