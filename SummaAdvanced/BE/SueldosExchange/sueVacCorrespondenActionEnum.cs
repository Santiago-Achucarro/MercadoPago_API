using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 30 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVacCorrespondenActionEnum
        {            public enum EnumsueVacCorrespondenAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueVacCorrespondenAction(sueVacCorrespondenActionEnum.EnumsueVacCorrespondenAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVacCorrespondenActionEnum.EnumsueVacCorrespondenAction.Guardar: lRetorno = "sueVacCorrespondenGuardar"; break;
                case sueVacCorrespondenActionEnum.EnumsueVacCorrespondenAction.Datos: lRetorno = "sueVacCorrespondenDevolverDatos"; break;
                case sueVacCorrespondenActionEnum.EnumsueVacCorrespondenAction.Eliminar: lRetorno = "sueVacCorrespondenEliminar"; break;
            }
            return lRetorno;
        }
    }
}
