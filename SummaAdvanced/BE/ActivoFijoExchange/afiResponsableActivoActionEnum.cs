using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, February 2, 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class afiResponsableActivoActionEnum
        {            public enum EnumafiResponsableActivoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionafiResponsableActivoAction(afiResponsableActivoActionEnum.EnumafiResponsableActivoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case afiResponsableActivoActionEnum.EnumafiResponsableActivoAction.Guardar: lRetorno = "afiResponsableActivoGuardar"; break;
                case afiResponsableActivoActionEnum.EnumafiResponsableActivoAction.Datos: lRetorno = "afiResponsableActivoDevolverDatos"; break;
                case afiResponsableActivoActionEnum.EnumafiResponsableActivoAction.Eliminar: lRetorno = "afiResponsableActivoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
