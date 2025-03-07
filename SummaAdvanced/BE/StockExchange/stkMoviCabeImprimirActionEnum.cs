using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 23 de abril de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCabeImprimirActionEnum
        {            public enum EnumstkMoviCabeImprimirAction
            {
                Guardar,Datos,AsignarNombre
            }
        public static string GetAccionstkMoviCabeImprimirAction(stkMoviCabeImprimirActionEnum.EnumstkMoviCabeImprimirAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeImprimirActionEnum.EnumstkMoviCabeImprimirAction.Guardar: lRetorno = "stkMoviCabeImprimirGuardar"; break;
                case stkMoviCabeImprimirActionEnum.EnumstkMoviCabeImprimirAction.Datos: lRetorno = "stkMoviCabeImprimirDevolverDatos"; break;
                case stkMoviCabeImprimirActionEnum.EnumstkMoviCabeImprimirAction.AsignarNombre: lRetorno = "stkMoviCabeImprimirAsignarNombre"; break;
            }
            return lRetorno;
        }
    }
}
