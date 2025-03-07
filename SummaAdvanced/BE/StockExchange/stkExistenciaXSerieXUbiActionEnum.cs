using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 9 de marzo de 2022
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkExistenciaXSerieXUbiActionEnum
        {            public enum EnumstkExistenciaXSerieXUbiAction
            {
                DatosSerie, DatosUbi
            }
        public static string GetAccionstkExistenciaXSerieXUbiAction(stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosSerie: lRetorno = "stkExistenciaXSerieXUbiDatosSerie"; break;
                case stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosUbi: lRetorno = "stkExistenciaXSerieXUbiDatosUbi"; break;
            }
            return lRetorno;
        }
    }
}
