using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 30 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueTablaVacRengActionEnum
        {            public enum EnumsueTablaVacRengAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueTablaVacRengAction(sueTablaVacRengActionEnum.EnumsueTablaVacRengAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueTablaVacRengActionEnum.EnumsueTablaVacRengAction.Guardar: lRetorno = "sueTablaVacRengGuardar"; break;
                case sueTablaVacRengActionEnum.EnumsueTablaVacRengAction.Datos: lRetorno = "sueTablaVacRengDevolverDatos"; break;
                case sueTablaVacRengActionEnum.EnumsueTablaVacRengAction.Eliminar: lRetorno = "sueTablaVacRengEliminar"; break;
            }
            return lRetorno;
        }
    }
}
