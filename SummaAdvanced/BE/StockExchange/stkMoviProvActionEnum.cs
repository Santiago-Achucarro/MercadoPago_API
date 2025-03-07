using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 8 de julio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviProvActionEnum
        {            public enum EnumstkMoviProvAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviProvAction(stkMoviProvActionEnum.EnumstkMoviProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviProvActionEnum.EnumstkMoviProvAction.Guardar: lRetorno = "stkMoviProvGuardar"; break;
                case stkMoviProvActionEnum.EnumstkMoviProvAction.Datos: lRetorno = "stkMoviProvDevolverDatos"; break;
                case stkMoviProvActionEnum.EnumstkMoviProvAction.Eliminar: lRetorno = "stkMoviProvEliminar"; break;
            }
            return lRetorno;
        }
    }
}
