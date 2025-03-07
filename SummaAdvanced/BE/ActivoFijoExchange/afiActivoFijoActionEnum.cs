using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 11 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class afiActivoFijoActionEnum
        {            public enum EnumafiActivoFijoAction
            {
                Guardar,Datos,Eliminar, AsignarFechaInicio, DatosAdjuntos
        }
        public static string GetAccionafiActivoFijoAction(afiActivoFijoActionEnum.EnumafiActivoFijoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case afiActivoFijoActionEnum.EnumafiActivoFijoAction.Guardar: lRetorno = "afiActivoFijoGuardar"; break;
                case afiActivoFijoActionEnum.EnumafiActivoFijoAction.Datos: lRetorno = "afiActivoFijoDevolverDatos"; break;
                case afiActivoFijoActionEnum.EnumafiActivoFijoAction.Eliminar: lRetorno = "afiActivoFijoEliminar"; break;
                case afiActivoFijoActionEnum.EnumafiActivoFijoAction.DatosAdjuntos: lRetorno = "afiActivoFijodatosAdjuntos"; break;
                case afiActivoFijoActionEnum.EnumafiActivoFijoAction.AsignarFechaInicio: lRetorno = "afiActivoFijoAsignarFechaInicio"; break;
            }
            return lRetorno;
        }
    }
}
