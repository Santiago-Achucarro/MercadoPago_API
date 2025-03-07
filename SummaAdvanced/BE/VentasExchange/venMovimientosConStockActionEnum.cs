using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 19 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosConStockActionEnum
        {            public enum EnumvenMovimientosConStockAction
            {
                Guardar,Datos,Eliminar,CalcularTotales, CalcularAsiento, LlamarAlWebServiceFE, AsignarTC, AsignarTCMonOrig,
            ReCalcularTotales, ActuPrecioLista, TraerDatosNC, Imprimir, Enviar, AsignarCotizacion, AsignarCartaPorte, AsignaLocalidad, AsignaLocalidadO, 
            PegarCP
        }
        public static string GetAccionvenMovimientosConStockAction(venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.Guardar: lRetorno = "venMovimientosConStockGuardar"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.Datos: lRetorno = "venMovimientosConStockDevolverDatos"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.Eliminar: lRetorno = "venMovimientosConStockEliminar"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.CalcularTotales: lRetorno = "venMovimientosConStockCalcularTotales"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.CalcularAsiento: lRetorno = "venMovimientosConStockCalcularAsiento"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.LlamarAlWebServiceFE: lRetorno = "venMovimientosConStockLlamarAlWebServiceFE"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.AsignarTC: lRetorno = "venMovimientosConStockAsignarTC"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.AsignarTCMonOrig: lRetorno = "venMovimientosConStockAsignarTCMonOrig"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.ReCalcularTotales: lRetorno = "venMovimientosConStockReCalcularTotales"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.ActuPrecioLista: lRetorno = "venMovimientosConStockActuPrecioLista"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.TraerDatosNC: lRetorno = "venMovimientosConStockTraerDatosNC"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.Imprimir: lRetorno = "venMovimientosConStockImprimir"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.Enviar: lRetorno = "venMovimientosConStockEnviar"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.AsignarCotizacion: lRetorno= "venMovimientosConStockAsignarCotizacion"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.AsignarCartaPorte: lRetorno = "venMovimientosConStockAsignarCartaPorte"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.AsignaLocalidad: lRetorno = "venMovimientosConStockAsignaLocalidad"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.AsignaLocalidadO: lRetorno = "venMovimientosConStockAsignaLocalidadO"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.PegarCP:lRetorno = "venMovimientosConStockPegarCP"; break;
                    
            }
            return lRetorno;
        }
    }
}
