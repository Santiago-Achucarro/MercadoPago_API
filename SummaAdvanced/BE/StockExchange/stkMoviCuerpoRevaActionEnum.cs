using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCuerpoRevaActionEnum
        {            public enum EnumstkMoviCuerpoRevaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviCuerpoRevaAction(stkMoviCuerpoRevaActionEnum.EnumstkMoviCuerpoRevaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCuerpoRevaActionEnum.EnumstkMoviCuerpoRevaAction.Guardar: lRetorno = "stkMoviCuerpoRevaGuardar"; break;
                case stkMoviCuerpoRevaActionEnum.EnumstkMoviCuerpoRevaAction.Datos: lRetorno = "stkMoviCuerpoRevaDevolverDatos"; break;
                case stkMoviCuerpoRevaActionEnum.EnumstkMoviCuerpoRevaAction.Eliminar: lRetorno = "stkMoviCuerpoRevaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
