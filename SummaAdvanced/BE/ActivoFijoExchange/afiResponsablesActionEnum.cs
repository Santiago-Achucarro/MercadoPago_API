using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, February 2, 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class afiResponsablesActionEnum
        {            public enum EnumafiResponsablesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionafiResponsablesAction(afiResponsablesActionEnum.EnumafiResponsablesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case afiResponsablesActionEnum.EnumafiResponsablesAction.Guardar: lRetorno = "afiResponsablesGuardar"; break;
                case afiResponsablesActionEnum.EnumafiResponsablesAction.Datos: lRetorno = "afiResponsablesDevolverDatos"; break;
                case afiResponsablesActionEnum.EnumafiResponsablesAction.Eliminar: lRetorno = "afiResponsablesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
