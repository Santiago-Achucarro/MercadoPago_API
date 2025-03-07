using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 15 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkMoviCabeDatosCausaActionEnum
    {
        public enum EnumstkMoviCabeDatosCausaAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionstkMoviCabeDatosCausaAction(stkMoviCabeDatosCausaActionEnum.EnumstkMoviCabeDatosCausaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeDatosCausaActionEnum.EnumstkMoviCabeDatosCausaAction.Guardar: lRetorno = "stkMoviCabeDatosCausaGuardar"; break;
                case stkMoviCabeDatosCausaActionEnum.EnumstkMoviCabeDatosCausaAction.Datos: lRetorno = "stkMoviCabeDatosCausaDevolverDatos"; break;
                case stkMoviCabeDatosCausaActionEnum.EnumstkMoviCabeDatosCausaAction.Eliminar: lRetorno = "stkMoviCabeDatosCausaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
