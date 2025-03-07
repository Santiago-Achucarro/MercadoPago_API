using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 14 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesChequesRechCanjeActionEnum
        {            public enum EnumtesChequesRechCanjeAction
            {
                Guardar,Datos,Eliminar,TotalDebe,TotalHaber,TraerCheques,AsignarCambio, ReCalcularMonBase
        }
        public static string GetAcciontesChequesRechCanjeAction(tesChequesRechCanjeActionEnum.EnumtesChequesRechCanjeAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesChequesRechCanjeActionEnum.EnumtesChequesRechCanjeAction.Guardar: lRetorno = "tesChequesRechCanjeGuardar"; break;
                case tesChequesRechCanjeActionEnum.EnumtesChequesRechCanjeAction.Datos: lRetorno = "tesChequesRechCanjeDevolverDatos"; break;
                case tesChequesRechCanjeActionEnum.EnumtesChequesRechCanjeAction.Eliminar: lRetorno = "tesChequesRechCanjeEliminar"; break;
                case tesChequesRechCanjeActionEnum.EnumtesChequesRechCanjeAction.TotalDebe: lRetorno = "tesChequesRechCanjeTotalDebe"; break;
                case tesChequesRechCanjeActionEnum.EnumtesChequesRechCanjeAction.TotalHaber: lRetorno = "tesChequesRechCanjeTotalHaber"; break;
                case tesChequesRechCanjeActionEnum.EnumtesChequesRechCanjeAction.TraerCheques: lRetorno = "tesChequesRechCanjeTraerCheques"; break;
                case tesChequesRechCanjeActionEnum.EnumtesChequesRechCanjeAction.AsignarCambio: lRetorno = "tesChequesRechCanjeAsignarCambio"; break;
                case tesChequesRechCanjeActionEnum.EnumtesChequesRechCanjeAction.ReCalcularMonBase: lRetorno = "tesChequesRechCanjeReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
