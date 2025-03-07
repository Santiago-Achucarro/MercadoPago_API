using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 27 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesPagosClieActionEnum
        {            public enum EnumtesPagosClieAction
            {
                Guardar,Datos,Eliminar,DatosPendientes,TotalHaber,TotalDebe, ReCalcularMonBase,AsignarCambio
        }
        public static string GetAcciontesPagosClieAction(tesPagosClieActionEnum.EnumtesPagosClieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesPagosClieActionEnum.EnumtesPagosClieAction.Guardar: lRetorno = "tesPagosClieGuardar"; break;
                case tesPagosClieActionEnum.EnumtesPagosClieAction.Datos: lRetorno = "tesPagosClieDevolverDatos"; break;
                case tesPagosClieActionEnum.EnumtesPagosClieAction.Eliminar: lRetorno = "tesPagosClieEliminar"; break;
                case tesPagosClieActionEnum.EnumtesPagosClieAction.DatosPendientes: lRetorno = "tesPagosClieDatosPendientes"; break;
                case tesPagosClieActionEnum.EnumtesPagosClieAction.TotalHaber: lRetorno = "tesPagosClieTotalHaber"; break;
                case tesPagosClieActionEnum.EnumtesPagosClieAction.TotalDebe: lRetorno = "tesPagosClieTotalDebe"; break;
                case tesPagosClieActionEnum.EnumtesPagosClieAction.ReCalcularMonBase: lRetorno = "tesPagosClieReCalcularMonBase"; break;
                case tesPagosClieActionEnum.EnumtesPagosClieAction.AsignarCambio: lRetorno = "tesPagosClieAsignarCambio"; break;
            }
            return lRetorno;
        }
    }
}
