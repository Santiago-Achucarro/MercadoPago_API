using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 4 de octubre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genMenusActionEnum
        {            public enum EnumgenMenusAction
            {
                DatosTodos
            }
        public static string GetAcciongenMenusAction(genMenusActionEnum.EnumgenMenusAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genMenusActionEnum.EnumgenMenusAction.DatosTodos: lRetorno = "genMenusDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
