using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, August 23, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueTabTituloActionEnum
        {            public enum EnumsueTabTituloAction
            {
                Guardar,Datos,Eliminar, DescargarWebService
        }
        public static string GetAccionsueTabTituloAction(sueTabTituloActionEnum.EnumsueTabTituloAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueTabTituloActionEnum.EnumsueTabTituloAction.Guardar: lRetorno = "sueTabTituloGuardar"; break;
                case sueTabTituloActionEnum.EnumsueTabTituloAction.Datos: lRetorno = "sueTabTituloDevolverDatos"; break;
                case sueTabTituloActionEnum.EnumsueTabTituloAction.Eliminar: lRetorno = "sueTabTituloEliminar"; break;
                case sueTabTituloActionEnum.EnumsueTabTituloAction.DescargarWebService: lRetorno = "sueTabTituloDescargarWebService"; break; 
            }
            return lRetorno;
        }
    }
}
