using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 23 de octubre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesSolicitudRendicionActionEnum
        {            public enum EnumtesSolicitudRendicionAction
            {
                Guardar,Datos,Eliminar, TotalDebe, TotalHaber, AsignarCambio, TraeChequesCartera, ReCalcularMonBase
        }
        public static string GetAcciontesSolicitudRendicionAction(tesSolicitudRendicionActionEnum.EnumtesSolicitudRendicionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesSolicitudRendicionActionEnum.EnumtesSolicitudRendicionAction.Guardar: lRetorno = "tesSolicitudRendicionGuardar"; break;
                case tesSolicitudRendicionActionEnum.EnumtesSolicitudRendicionAction.Datos: lRetorno = "tesSolicitudRendicionDevolverDatos"; break;
                case tesSolicitudRendicionActionEnum.EnumtesSolicitudRendicionAction.Eliminar: lRetorno = "tesSolicitudRendicionEliminar"; break;
                case tesSolicitudRendicionActionEnum.EnumtesSolicitudRendicionAction.AsignarCambio: lRetorno = "tesSolicitudRendicionAsignarCambio"; break;
                case tesSolicitudRendicionActionEnum.EnumtesSolicitudRendicionAction.TotalDebe: lRetorno = "tesSolicitudRendicionTotalDebe"; break;
                case tesSolicitudRendicionActionEnum.EnumtesSolicitudRendicionAction.TotalHaber: lRetorno = "tesSolicitudRendicionTotalHaber"; break;
                case tesSolicitudRendicionActionEnum.EnumtesSolicitudRendicionAction.TraeChequesCartera: lRetorno = "tesSolicitudRendicionTraeChequesCartera"; break;
                case tesSolicitudRendicionActionEnum.EnumtesSolicitudRendicionAction.ReCalcularMonBase: lRetorno = "tesSolicitudRendicionReCalcularMonBase"; break;
            }
            return lRetorno;
        }


        public static TesoreriaExchange.tesMovimientosDatosBaseActionExchange ToBase(TesoreriaExchange.tesSolicitudRendicionActionExchange Exch)
        {
            TesoreriaExchange.tesMovimientosDatosBaseActionExchange Res = new TesoreriaExchange.tesMovimientosDatosBaseActionExchange();
            Res.Param.Merge(Exch.Param, false);
            Res.Param.Principal[0].Delete();
            Res.Param.AcceptChanges();
            return Res;

        }
        public static TesoreriaExchange.tesSolicitudRendicionActionExchange FromBase(TesoreriaExchange.tesMovimientosDatosBaseActionExchange Exch)
        {
            TesoreriaExchange.tesSolicitudRendicionActionExchange Res = new TesoreriaExchange.tesSolicitudRendicionActionExchange();
            Res.Param.Merge(Exch.Param, false);
            Res.Param.Principal[0].Delete();
            Res.Param.AcceptChanges();
            return Res;

        }
    }
}
