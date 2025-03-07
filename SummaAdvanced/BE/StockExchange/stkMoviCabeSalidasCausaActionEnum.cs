using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de febrero de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkMoviCabeSalidasCausaActionEnum
    {
        public enum EnumstkMoviCabeSalidasCausaAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionstkMoviCabeSalidasCausaAction(stkMoviCabeSalidasCausaActionEnum.EnumstkMoviCabeSalidasCausaAction 
            pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeSalidasCausaActionEnum.EnumstkMoviCabeSalidasCausaAction.Guardar: lRetorno = "stkMoviCabeSalidasCausaGuardar";
                    break;
                case stkMoviCabeSalidasCausaActionEnum.EnumstkMoviCabeSalidasCausaAction.Datos: lRetorno = "stkMoviCabeSalidasCausaDevolverDatos";
                    break;
                case stkMoviCabeSalidasCausaActionEnum.EnumstkMoviCabeSalidasCausaAction.Eliminar: lRetorno = "stkMoviCabeSalidasCausaEliminar";
                    break;
            }
            return lRetorno;
        }
    }
}
