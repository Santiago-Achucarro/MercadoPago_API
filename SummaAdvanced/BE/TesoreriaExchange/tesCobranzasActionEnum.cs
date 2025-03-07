using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 1 de septiembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesCobranzasActionEnum
    {
        public enum EnumtesCobranzasAction
        {
            Guardar, Datos, Eliminar, TotalDebe, TotalHaber, AsignarCambio, DatosPendientes, ReCalcularMonBase,Enviar
        }
        public static string GetAcciontesCobranzasAction(tesCobranzasActionEnum.EnumtesCobranzasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCobranzasActionEnum.EnumtesCobranzasAction.Guardar: lRetorno = "tesCobranzasGuardar"; break;
                case tesCobranzasActionEnum.EnumtesCobranzasAction.Datos: lRetorno = "tesCobranzasDevolverDatos"; break;
                case tesCobranzasActionEnum.EnumtesCobranzasAction.Eliminar: lRetorno = "tesCobranzasEliminar"; break;
                case tesCobranzasActionEnum.EnumtesCobranzasAction.TotalDebe: lRetorno = "tesCobranzasTotalDebe"; break;
                case tesCobranzasActionEnum.EnumtesCobranzasAction.TotalHaber: lRetorno = "tesCobranzasTotalHaber"; break;
                case tesCobranzasActionEnum.EnumtesCobranzasAction.AsignarCambio: lRetorno = "tesCobranzasAsignarCambio"; break;
                case tesCobranzasActionEnum.EnumtesCobranzasAction.DatosPendientes: lRetorno = "tesCobranzasDatosPendientes"; break;
                case tesCobranzasActionEnum.EnumtesCobranzasAction.ReCalcularMonBase: lRetorno = "tesCobranzasReCalcularMonBase"; break;
                case tesCobranzasActionEnum.EnumtesCobranzasAction.Enviar:lRetorno = "tesCobranzasEnviar"; break;
                    
            }
            return lRetorno;
        }
    }
}
