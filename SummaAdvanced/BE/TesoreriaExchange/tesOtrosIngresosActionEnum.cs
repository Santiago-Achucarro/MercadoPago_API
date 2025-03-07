using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 4 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesOtrosIngresosActionEnum
    {
        public enum EnumtesOtrosIngresosAction
        {
            Guardar, Datos, Eliminar, TotalDebe, TotalHaber, AsignarCambio, ReCalcularMonBase
        }
        public static string GetAcciontesOtrosIngresosAction(tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction.Guardar:
                    lRetorno = "tesOtrosIngresosGuardar"; break;
                case tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction.Datos:
                    lRetorno = "tesOtrosIngresosDevolverDatos"; break;
                case tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction.Eliminar:
                    lRetorno = "tesOtrosIngresosEliminar"; break;
                case tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction.TotalDebe:
                    lRetorno = "tesOtrosIngresosTotalDebe"; break;
                case tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction.TotalHaber:
                    lRetorno = "tesOtrosIngresosTotalHaber"; break;
                case tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction.AsignarCambio:
                    lRetorno = "tesOtrosIngresosAsignarCambio"; break;
                case tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction.ReCalcularMonBase:
                    lRetorno = "tesOtrosIngresosReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
