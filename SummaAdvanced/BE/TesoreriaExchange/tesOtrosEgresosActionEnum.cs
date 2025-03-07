using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 18 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesOtrosEgresosActionEnum
        {            public enum EnumtesOtrosEgresosAction
            {
                Guardar,Datos,Eliminar,TotalDebe,TotalHaber,TraeChequesCartera, AsignarCambio, ReCalcularMonBase
        }
        public static string GetAcciontesOtrosEgresosAction(tesOtrosEgresosActionEnum.EnumtesOtrosEgresosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesOtrosEgresosActionEnum.EnumtesOtrosEgresosAction.Guardar:
                    lRetorno = "tesOtrosEgresosGuardar"; break;
                case tesOtrosEgresosActionEnum.EnumtesOtrosEgresosAction.Datos:
                    lRetorno = "tesOtrosEgresosDevolverDatos"; break;
                case tesOtrosEgresosActionEnum.EnumtesOtrosEgresosAction.Eliminar:
                    lRetorno = "tesOtrosEgresosEliminar"; break;
                case tesOtrosEgresosActionEnum.EnumtesOtrosEgresosAction.TotalDebe:
                    lRetorno = "tesOtrosEgresosTotalDebe"; break;
                case tesOtrosEgresosActionEnum.EnumtesOtrosEgresosAction.TotalHaber:
                    lRetorno = "tesOtrosEgresosTotalHaber"; break;
                case tesOtrosEgresosActionEnum.EnumtesOtrosEgresosAction.TraeChequesCartera:
                    lRetorno = "tesMovimientosDatosBaseTraeChequesCartera"; break;
                case tesOtrosEgresosActionEnum.EnumtesOtrosEgresosAction.AsignarCambio:
                    lRetorno = "tesOtrosEgresosAsignarCambio"; break;
                case tesOtrosEgresosActionEnum.EnumtesOtrosEgresosAction.ReCalcularMonBase:
                    lRetorno = "tesOtrosEgresosReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
