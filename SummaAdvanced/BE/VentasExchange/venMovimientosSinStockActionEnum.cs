using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 12 de julio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venMovimientosSinStockActionEnum
    {
        public enum EnumvenMovimientosSinStockAction
        {
            Guardar, Datos, Eliminar, CalcularTotal, AsignarTC, Imprimir, Enviar
        }
        public static string GetAccionvenMovimientosSinStockAction(venMovimientosSinStockActionEnum.EnumvenMovimientosSinStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosSinStockActionEnum.EnumvenMovimientosSinStockAction.Guardar:
                    lRetorno = "venMovimientosSinStockGuardar";
                    break;
                case venMovimientosSinStockActionEnum.EnumvenMovimientosSinStockAction.Datos:
                    lRetorno = "venMovimientosSinStockDevolverDatos";
                    break;
                case venMovimientosSinStockActionEnum.EnumvenMovimientosSinStockAction.Eliminar:
                    lRetorno = "venMovimientosSinStockEliminar";
                    break;
                case venMovimientosSinStockActionEnum.EnumvenMovimientosSinStockAction.CalcularTotal:
                    lRetorno = "venMovimientosSinStockCalcularTotal";
                    break;
                case venMovimientosSinStockActionEnum.EnumvenMovimientosSinStockAction.AsignarTC:
                    lRetorno = "venMovimientosSinStockAsignarTC";
                    break;
                case venMovimientosSinStockActionEnum.EnumvenMovimientosSinStockAction.Imprimir:
                    lRetorno = "venMovimientosSinStockImprimir";
                    break;

                case venMovimientosSinStockActionEnum.EnumvenMovimientosSinStockAction.Enviar:
                    lRetorno = "venMovimientosSinStockEnviar";
                    break;

                    

            }
            return lRetorno;
        }
    }
}
