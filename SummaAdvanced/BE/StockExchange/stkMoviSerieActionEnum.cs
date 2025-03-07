using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 13 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviSerieActionEnum
        {            public enum EnumstkMoviSerieAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionstkMoviSerieAction(stkMoviSerieActionEnum.EnumstkMoviSerieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviSerieActionEnum.EnumstkMoviSerieAction.Guardar: lRetorno = "stkMoviSerieGuardar"; break;
                case stkMoviSerieActionEnum.EnumstkMoviSerieAction.Eliminar: lRetorno = "stkMoviSerieEliminar"; break;
            }
            return lRetorno;
        }
    }
}
