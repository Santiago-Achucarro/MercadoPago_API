using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 12 de julio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genReportesTodosActionEnum
        {            public enum EnumgenReportesTodosAction
            {
                Datos
            }
        public static string GetAcciongenReportesTodosAction(genReportesTodosActionEnum.EnumgenReportesTodosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genReportesTodosActionEnum.EnumgenReportesTodosAction.Datos: lRetorno = "genReportesTodosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
