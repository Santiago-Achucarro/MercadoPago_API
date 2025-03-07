using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 1 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venMovimientosImprimirActionEnum
    {
        public enum EnumvenMovimientosImprimirAction
        {
            Guardar, Datos, AsignarNombre, Enviar
        }
        public static string GetAccionvenMovimientosImprimirAction(venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Guardar: lRetorno = "venMovimientosImprimirGuardar"; break;
                case venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos: lRetorno = "venMovimientosImprimirDevolverDatos"; break;
                case venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.AsignarNombre: lRetorno = "venMovimientosImprimirAsignarNombre"; break;
                case venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Enviar: lRetorno = "venMovimientosImprimirEnviar"; break;
                
            }
            return lRetorno;
        }
    }
}
