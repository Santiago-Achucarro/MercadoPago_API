using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 11 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genReportesSPActionEnum
        {            public enum EnumgenReportesSPAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenReportesSPAction(genReportesSPActionEnum.EnumgenReportesSPAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genReportesSPActionEnum.EnumgenReportesSPAction.Guardar: lRetorno = "genReportesSPGuardar"; break;
                case genReportesSPActionEnum.EnumgenReportesSPAction.Datos: lRetorno = "genReportesSPDevolverDatos"; break;
                case genReportesSPActionEnum.EnumgenReportesSPAction.Eliminar: lRetorno = "genReportesSPEliminar"; break;
            }
            return lRetorno;
        }
    }
}
