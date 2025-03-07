using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 13 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviUbicacionActionEnum
        {            public enum EnumstkMoviUbicacionAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviUbicacionAction(stkMoviUbicacionActionEnum.EnumstkMoviUbicacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviUbicacionActionEnum.EnumstkMoviUbicacionAction.Guardar: lRetorno = "stkMoviUbicacionGuardar"; break;
                case stkMoviUbicacionActionEnum.EnumstkMoviUbicacionAction.Datos: lRetorno = "stkMoviUbicacionDevolverDatos"; break;
                case stkMoviUbicacionActionEnum.EnumstkMoviUbicacionAction.Eliminar: lRetorno = "stkMoviUbicacionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
