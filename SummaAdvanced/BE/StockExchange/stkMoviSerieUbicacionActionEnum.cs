using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 13 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviSerieUbicacionActionEnum
        {            public enum EnumstkMoviSerieUbicacionAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviSerieUbicacionAction(stkMoviSerieUbicacionActionEnum.EnumstkMoviSerieUbicacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviSerieUbicacionActionEnum.EnumstkMoviSerieUbicacionAction.Guardar: lRetorno = "stkMoviSerieUbicacionGuardar"; break;
                case stkMoviSerieUbicacionActionEnum.EnumstkMoviSerieUbicacionAction.Datos: lRetorno = "stkMoviSerieUbicacionDevolverDatos"; break;
                case stkMoviSerieUbicacionActionEnum.EnumstkMoviSerieUbicacionAction.Eliminar: lRetorno = "stkMoviSerieUbicacionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
