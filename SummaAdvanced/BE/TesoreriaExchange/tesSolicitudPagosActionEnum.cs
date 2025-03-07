using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 23 de octubre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesSolicitudPagosActionEnum
        {            public enum EnumtesSolicitudPagosAction
            {
                Guardar,Datos,Eliminar,TotalDebe,TotalHaber, AsignarCambio, TraeChequesCartera, ReCalcularMonBase
        }
        public static string GetAcciontesSolicitudPagosAction(tesSolicitudPagosActionEnum.EnumtesSolicitudPagosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesSolicitudPagosActionEnum.EnumtesSolicitudPagosAction.Guardar: lRetorno = "tesSolicitudPagosGuardar"; break;
                case tesSolicitudPagosActionEnum.EnumtesSolicitudPagosAction.Datos: lRetorno = "tesSolicitudPagosDevolverDatos"; break;
                case tesSolicitudPagosActionEnum.EnumtesSolicitudPagosAction.Eliminar: lRetorno = "tesSolicitudPagosEliminar"; break;
                case tesSolicitudPagosActionEnum.EnumtesSolicitudPagosAction.TotalDebe: lRetorno = "tesSolicitudPagosTotalDebe"; break;
                case tesSolicitudPagosActionEnum.EnumtesSolicitudPagosAction.TotalHaber: lRetorno = "tesSolicitudPagosTotalHaber"; break;
                case tesSolicitudPagosActionEnum.EnumtesSolicitudPagosAction.AsignarCambio: lRetorno = "tesSolicitudPagosAsignarCambio"; break;
                case tesSolicitudPagosActionEnum.EnumtesSolicitudPagosAction.TraeChequesCartera: lRetorno = "tesSolicitudPagosTraeChequesCartera"; break;
                case tesSolicitudPagosActionEnum.EnumtesSolicitudPagosAction.ReCalcularMonBase: lRetorno = "tesSolicitudPagosReCalcularMonBase"; break;
            }
            return lRetorno;
        }

        public static TesoreriaExchange.tesMovimientosDatosBaseActionExchange ToBase(TesoreriaExchange.tesSolicitudPagosActionExchange Exch)
        {
            TesoreriaExchange.tesMovimientosDatosBaseActionExchange Res = new TesoreriaExchange.tesMovimientosDatosBaseActionExchange();
            Res.Param.Merge(Exch.Param, false);
            Res.Param.Principal[0].Delete();
            Res.Param.AcceptChanges();
            return Res;

        }
        public static TesoreriaExchange.tesSolicitudPagosActionExchange FromBase(TesoreriaExchange.tesMovimientosDatosBaseActionExchange Exch)
        {
            TesoreriaExchange.tesSolicitudPagosActionExchange Res = new TesoreriaExchange.tesSolicitudPagosActionExchange();
            Res.Param.Merge(Exch.Param, false);
            Res.Param.Principal[0].Delete();
            Res.Param.AcceptChanges();
            return Res;

        }
    }
}
