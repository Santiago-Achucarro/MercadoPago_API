using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 13 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkMoviCabeActionEnum
    {
        public enum EnumstkMoviCabeAction
        {
            Guardar, Datos, Eliminar, DatosSeg, Postear
        }
        public static string GetAccionstkMoviCabeAction(stkMoviCabeActionEnum.EnumstkMoviCabeAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeActionEnum.EnumstkMoviCabeAction.Guardar: lRetorno = "stkMoviCabeGuardar"; break;
                case stkMoviCabeActionEnum.EnumstkMoviCabeAction.Datos: lRetorno = "stkMoviCabeDevolverDatos"; break;
                case stkMoviCabeActionEnum.EnumstkMoviCabeAction.Eliminar: lRetorno = "stkMoviCabeEliminar"; break;
                case stkMoviCabeActionEnum.EnumstkMoviCabeAction.DatosSeg: lRetorno = "stkMoviCabeDatosSeg"; break;
                case stkMoviCabeActionEnum.EnumstkMoviCabeAction.Postear: lRetorno = "stkMoviCabePostear"; break;
            }
            return lRetorno;
        }
    }
}

