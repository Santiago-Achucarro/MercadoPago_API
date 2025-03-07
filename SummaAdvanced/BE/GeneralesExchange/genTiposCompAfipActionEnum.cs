using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 10 de noviembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genTiposCompAfipActionEnum
        {            public enum EnumgenTiposCompAfipAction
            {
                Datos
            }
        public static string GetAcciongenTiposCompAfipAction(genTiposCompAfipActionEnum.EnumgenTiposCompAfipAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genTiposCompAfipActionEnum.EnumgenTiposCompAfipAction.Datos: lRetorno = "genTiposCompAfipDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
