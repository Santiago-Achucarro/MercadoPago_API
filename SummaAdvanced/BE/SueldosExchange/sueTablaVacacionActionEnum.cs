using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 30 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueTablaVacacionActionEnum
        {            public enum EnumsueTablaVacacionAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueTablaVacacionAction(sueTablaVacacionActionEnum.EnumsueTablaVacacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueTablaVacacionActionEnum.EnumsueTablaVacacionAction.Guardar: lRetorno = "sueTablaVacacionGuardar"; break;
                case sueTablaVacacionActionEnum.EnumsueTablaVacacionAction.Datos: lRetorno = "sueTablaVacacionDevolverDatos"; break;
                case sueTablaVacacionActionEnum.EnumsueTablaVacacionAction.Eliminar: lRetorno = "sueTablaVacacionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
