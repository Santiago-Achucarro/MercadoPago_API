using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 5 de mayo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genReportesActionEnum
        {            public enum EnumgenReportesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenReportesAction(genReportesActionEnum.EnumgenReportesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genReportesActionEnum.EnumgenReportesAction.Guardar: lRetorno = "genReportesGuardar"; break;
                case genReportesActionEnum.EnumgenReportesAction.Datos: lRetorno = "genReportesDevolverDatos"; break;
                case genReportesActionEnum.EnumgenReportesAction.Eliminar: lRetorno = "genReportesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
