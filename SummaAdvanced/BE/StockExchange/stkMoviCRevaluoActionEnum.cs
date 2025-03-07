using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 16 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCRevaluoActionEnum
        {            public enum EnumstkMoviCRevaluoAction
            {
                Guardar,Datos,Eliminar,DatosCabe
            }
        public static string GetAccionstkMoviCRevaluoAction(stkMoviCRevaluoActionEnum.EnumstkMoviCRevaluoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCRevaluoActionEnum.EnumstkMoviCRevaluoAction.Guardar: lRetorno = "stkMoviCRevaluoGuardar"; break;
                case stkMoviCRevaluoActionEnum.EnumstkMoviCRevaluoAction.Datos: lRetorno = "stkMoviCRevaluoDevolverDatos"; break;
                case stkMoviCRevaluoActionEnum.EnumstkMoviCRevaluoAction.Eliminar: lRetorno = "stkMoviCRevaluoEliminar"; break;
                case stkMoviCRevaluoActionEnum.EnumstkMoviCRevaluoAction.DatosCabe: lRetorno = "stkMoviCRevaluoDatosCabe";break;
            }
            return lRetorno;
        }
    }
}
