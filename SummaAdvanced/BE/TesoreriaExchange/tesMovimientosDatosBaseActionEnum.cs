using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 11 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesMovimientosDatosBaseActionEnum
    {
        public enum EnumtesMovimientosDatosBaseAction
        {
            Guardar, Datos, Eliminar, TotalDebe, TotalHaber, AsignarCambio, TraeChequesCartera, ReCalcularMonBase
        }
        public static string GetAcciontesMovimientosDatosBaseAction(tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.Guardar:
                    lRetorno = "tesMovimientosDatosBaseGuardar"; break;
                case tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.Datos:
                    lRetorno = "tesMovimientosDatosBaseDevolverDatos"; break;
                case tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.Eliminar:
                    lRetorno = "tesMovimientosDatosBaseEliminar"; break;
                case tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.TotalDebe:
                    lRetorno = "tesMovimientosDatosBaseTotalDebe"; break;
                case tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.TotalHaber:
                    lRetorno = "tesMovimientosDatosBaseTotalHaber"; break;
                case tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.AsignarCambio:
                    lRetorno = "tesMovimientosDatosAsignarCambio"; break;
                case tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.TraeChequesCartera:
                    lRetorno = "tesMovimientosDatosBaseTraeChequesCartera"; break;
                case tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.ReCalcularMonBase:
                    lRetorno = "tesMovimientosDatosBaseReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
