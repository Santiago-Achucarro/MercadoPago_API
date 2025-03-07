using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 1 de julio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genSucursalesListaActionEnum
        {            public enum EnumgenSucursalesListaAction
            {
                Datos
            }
        public static string GetAcciongenSucursalesListaAction(genSucursalesListaActionEnum.EnumgenSucursalesListaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genSucursalesListaActionEnum.EnumgenSucursalesListaAction.Datos: lRetorno = "genSucursalesListaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
