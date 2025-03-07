using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de febrero de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCabeEntradasCausaActionEnum
        {            public enum EnumstkMoviCabeEntradasCausaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviCabeEntradasCausaAction(stkMoviCabeEntradasCausaActionEnum.EnumstkMoviCabeEntradasCausaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeEntradasCausaActionEnum.EnumstkMoviCabeEntradasCausaAction.Guardar: lRetorno = "stkMoviCabeEntradasCausaGuardar"; break;
                case stkMoviCabeEntradasCausaActionEnum.EnumstkMoviCabeEntradasCausaAction.Datos: lRetorno = "stkMoviCabeEntradasCausaDevolverDatos"; break;
                case stkMoviCabeEntradasCausaActionEnum.EnumstkMoviCabeEntradasCausaAction.Eliminar: lRetorno = "stkMoviCabeEntradasCausaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
