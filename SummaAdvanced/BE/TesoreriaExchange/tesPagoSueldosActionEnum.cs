using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 12 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesPagoSueldosActionEnum
        {            public enum EnumtesPagoSueldosAction
            {
                Guardar,Datos,Eliminar,TotalDebe, TotalHaber, AsignarCambio, TraeChequesCartera, ReCalcularMonBase
        }
        public static string GetAcciontesPagoSueldosAction(tesPagoSueldosActionEnum.EnumtesPagoSueldosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesPagoSueldosActionEnum.EnumtesPagoSueldosAction.Guardar: lRetorno = "tesPagoSueldosGuardar"; break;
                case tesPagoSueldosActionEnum.EnumtesPagoSueldosAction.Datos: lRetorno = "tesPagoSueldosDevolverDatos"; break;
                case tesPagoSueldosActionEnum.EnumtesPagoSueldosAction.Eliminar: lRetorno = "tesPagoSueldosEliminar"; break;
                case tesPagoSueldosActionEnum.EnumtesPagoSueldosAction.TotalDebe: lRetorno = "tesPagoSueldosTotalDebe"; break;
                case tesPagoSueldosActionEnum.EnumtesPagoSueldosAction.TotalHaber: lRetorno = "tesPagoSueldosTotalHaber"; break;
                case tesPagoSueldosActionEnum.EnumtesPagoSueldosAction.AsignarCambio: lRetorno = "tesPagoSueldosAsignarCambio"; break;
                case tesPagoSueldosActionEnum.EnumtesPagoSueldosAction.TraeChequesCartera: lRetorno = "tesPagoSueldosTraeChequesCartera"; break;
                case tesPagoSueldosActionEnum.EnumtesPagoSueldosAction.ReCalcularMonBase: lRetorno = "tesPagoSueldosReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
