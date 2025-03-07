using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 4 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkHojaDeRutaActionEnum
        {            public enum EnumstkHojaDeRutaAction
            {
                Guardar,Datos,Eliminar,Pendientes,PendientesCOT,GuardarCot,Todas,Ninguna
            }
        public static string GetAccionstkHojaDeRutaAction(stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction.Guardar: lRetorno = "stkHojaDeRutaGuardar"; break;
                case stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction.Datos: lRetorno = "stkHojaDeRutaDevolverDatos"; break;
                case stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction.Eliminar: lRetorno = "stkHojaDeRutaEliminar"; break;
                case stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction.Pendientes: lRetorno = "stkHojaDeRutaPendientes"; break;
                case stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction.PendientesCOT: lRetorno = "stkHojaDeRutaPendientesCOT"; break;
                case stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction.GuardarCot: lRetorno = "stkHojaDeRutaGuardarCOT"; break;
                case stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction.Todas:lRetorno = "stkHojaDeRutaTodas"; break;
                case stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction.Ninguna: lRetorno = "stkHojaDeRutaNinguna"; break;

            }
            return lRetorno;
        }
    }
}
