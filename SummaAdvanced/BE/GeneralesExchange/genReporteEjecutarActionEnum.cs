using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 26 de junio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genReporteEjecutarActionEnum
    {
        public enum EnumgenReporteEjecutarAction
        {
            Ejecutar
        }
        public static string GetAcciongenReporteEjecutarAction(genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction.Ejecutar: lRetorno = "genReporteEjecutarEjecutar"; break;
            }
            return lRetorno;
        }
    }
}
