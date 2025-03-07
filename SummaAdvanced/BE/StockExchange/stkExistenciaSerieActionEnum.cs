using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 15 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkExistenciaSerieActionEnum
        {            public enum EnumstkExistenciaSerieAction
            {
                Datos,Eliminar,Sumar
            }
        public static string GetAccionstkExistenciaSerieAction(stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos: lRetorno = "stkExistenciaSerieDevolverDatos"; break;
                case stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Eliminar: lRetorno = "stkExistenciaSerieEliminar"; break;
                case stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Sumar: lRetorno = "stkExistenciaSerieSumar"; break;
            }
            return lRetorno;
        }
    }
}
