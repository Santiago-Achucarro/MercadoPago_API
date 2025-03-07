using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, October 8, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVacCorrespondenDatosRangoActionEnum
        {            public enum EnumsueVacCorrespondenDatosRangoAction
            {
                Guardar,Datos
            }
        public static string GetAccionsueVacCorrespondenDatosRangoAction(sueVacCorrespondenDatosRangoActionEnum.EnumsueVacCorrespondenDatosRangoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVacCorrespondenDatosRangoActionEnum.EnumsueVacCorrespondenDatosRangoAction.Guardar: lRetorno = "sueVacCorrespondenDatosRangoGuardar"; break;
                case sueVacCorrespondenDatosRangoActionEnum.EnumsueVacCorrespondenDatosRangoAction.Datos: lRetorno = "sueVacCorrespondenDatosRangoDevolverDatos"; break;
                
            }
            return lRetorno;
        }
    }
}
