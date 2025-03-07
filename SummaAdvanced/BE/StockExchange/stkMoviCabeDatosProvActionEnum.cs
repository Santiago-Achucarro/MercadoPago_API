using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 16 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkMoviCabeDatosProvActionEnum
    {
        public enum EnumstkMoviCabeDatosProvAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionstkMoviCabeDatosProvAction(stkMoviCabeDatosProvActionEnum.EnumstkMoviCabeDatosProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeDatosProvActionEnum.EnumstkMoviCabeDatosProvAction.Guardar: lRetorno = "stkMoviCabeDatosProvGuardar"; break;
                case stkMoviCabeDatosProvActionEnum.EnumstkMoviCabeDatosProvAction.Datos: lRetorno = "stkMoviCabeDatosProvDevolverDatos"; break;
                case stkMoviCabeDatosProvActionEnum.EnumstkMoviCabeDatosProvAction.Eliminar: lRetorno = "stkMoviCabeDatosProvEliminar"; break;
            }
            return lRetorno;
        }
    }
}
