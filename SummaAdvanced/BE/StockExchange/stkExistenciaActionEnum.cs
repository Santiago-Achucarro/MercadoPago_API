using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 27 de abril de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkExistenciaActionEnum
        {            public enum EnumstkExistenciaAction
            {
                Datos,Sumar
            }
        public static string GetAccionstkExistenciaAction(stkExistenciaActionEnum.EnumstkExistenciaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciaActionEnum.EnumstkExistenciaAction.Datos: lRetorno = "stkExistenciaDevolverDatos"; break;
                case stkExistenciaActionEnum.EnumstkExistenciaAction.Sumar: lRetorno = "stkExistenciaSumar"; break;
            }
            return lRetorno;
        }
    }
}
