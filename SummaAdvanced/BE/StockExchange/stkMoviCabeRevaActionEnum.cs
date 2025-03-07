using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCabeRevaActionEnum
        {            public enum EnumstkMoviCabeRevaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviCabeRevaAction(stkMoviCabeRevaActionEnum.EnumstkMoviCabeRevaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeRevaActionEnum.EnumstkMoviCabeRevaAction.Guardar: lRetorno = "stkMoviCabeRevaGuardar"; break;
                case stkMoviCabeRevaActionEnum.EnumstkMoviCabeRevaAction.Datos: lRetorno = "stkMoviCabeRevaDevolverDatos"; break;
                case stkMoviCabeRevaActionEnum.EnumstkMoviCabeRevaAction.Eliminar: lRetorno = "stkMoviCabeRevaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
