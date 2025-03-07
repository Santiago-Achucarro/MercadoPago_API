using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 20 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovprovFactDifPrecRengActionEnum
        {            public enum EnumcomMovprovFactDifPrecRengAction
            {
                Datos
            }
        public static string GetAccioncomMovprovFactDifPrecRengAction(comMovprovFactDifPrecRengActionEnum.EnumcomMovprovFactDifPrecRengAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovprovFactDifPrecRengActionEnum.EnumcomMovprovFactDifPrecRengAction.Datos: lRetorno = "comMovprovFactDifPrecRengDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
