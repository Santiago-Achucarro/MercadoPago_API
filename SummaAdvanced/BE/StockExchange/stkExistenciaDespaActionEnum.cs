using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 15 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkExistenciaDespaActionEnum
        {            public enum EnumstkExistenciaDespaAction
            {
                Datos,Eliminar,Sumar
            }
        public static string GetAccionstkExistenciaDespaAction(stkExistenciaDespaActionEnum.EnumstkExistenciaDespaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciaDespaActionEnum.EnumstkExistenciaDespaAction.Datos: lRetorno = "stkExistenciaDespaDevolverDatos"; break;
                case stkExistenciaDespaActionEnum.EnumstkExistenciaDespaAction.Eliminar: lRetorno = "stkExistenciaDespaEliminar"; break;
                case stkExistenciaDespaActionEnum.EnumstkExistenciaDespaAction.Sumar: lRetorno = "stkExistenciaDespaSumar"; break;
            }
            return lRetorno;
        }
    }
}
