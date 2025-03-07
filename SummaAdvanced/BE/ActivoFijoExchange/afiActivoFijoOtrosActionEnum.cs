using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 30 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class afiActivoFijoOtrosActionEnum
        {            public enum EnumafiActivoFijoOtrosAction
            {
                Guardar,Datos,Eliminar,AsignarFechaInicio,Desactivar, DatosAdjuntos
        }
        public static string GetAccionafiActivoFijoOtrosAction(afiActivoFijoOtrosActionEnum.EnumafiActivoFijoOtrosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {


                case afiActivoFijoOtrosActionEnum.EnumafiActivoFijoOtrosAction.Guardar: lRetorno = "afiActivoFijoOtrosGuardar"; break;
                case afiActivoFijoOtrosActionEnum.EnumafiActivoFijoOtrosAction.Datos: lRetorno = "afiActivoFijoOtrosDevolverDatos"; break;
                case afiActivoFijoOtrosActionEnum.EnumafiActivoFijoOtrosAction.Eliminar: lRetorno = "afiActivoFijoOtrosEliminar"; break;
                case afiActivoFijoOtrosActionEnum.EnumafiActivoFijoOtrosAction.AsignarFechaInicio: lRetorno = "afiActivoFijoOtrosAsignarFechaInicio"; break;
                case afiActivoFijoOtrosActionEnum.EnumafiActivoFijoOtrosAction.Desactivar: lRetorno = "afiActivoFijoOtrosDesactivar"; break;
                case afiActivoFijoOtrosActionEnum.EnumafiActivoFijoOtrosAction.DatosAdjuntos: lRetorno = "afiActivoFijoOtrosDatosAdjuntos"; break;

            }
            return lRetorno;
        }
    }
}
