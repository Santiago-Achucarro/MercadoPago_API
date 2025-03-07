using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 9 de octubre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesPagosImpuestosActionEnum
        {            public enum EnumtesPagosImpuestosAction
            {
                Guardar,Datos,Eliminar,TotalDebe, TotalHaber, AsignarCambio, TraeChequesCartera, ReCalcularMonBase
        }
        public static string GetAcciontesPagosImpuestosAction(tesPagosImpuestosActionEnum.EnumtesPagosImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesPagosImpuestosActionEnum.EnumtesPagosImpuestosAction.Guardar: lRetorno = "tesPagosImpuestosGuardar"; break;
                case tesPagosImpuestosActionEnum.EnumtesPagosImpuestosAction.Datos: lRetorno = "tesPagosImpuestosDevolverDatos"; break;
                case tesPagosImpuestosActionEnum.EnumtesPagosImpuestosAction.Eliminar: lRetorno = "tesPagosImpuestosEliminar"; break;
                case tesPagosImpuestosActionEnum.EnumtesPagosImpuestosAction.TotalDebe: lRetorno = "tesPagosImpuestosTotalDebe"; break;
                case tesPagosImpuestosActionEnum.EnumtesPagosImpuestosAction.TotalHaber: lRetorno = "tesPagosImpuestosTotalHaber"; break;
                case tesPagosImpuestosActionEnum.EnumtesPagosImpuestosAction.AsignarCambio: lRetorno = "tesPagosImpuestosAsignarCambio"; break;
                case tesPagosImpuestosActionEnum.EnumtesPagosImpuestosAction.ReCalcularMonBase: lRetorno = "tesPagosImpuestosReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
