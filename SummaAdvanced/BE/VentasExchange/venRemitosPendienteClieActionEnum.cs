using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 20 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venRemitosPendienteClieActionEnum
        {            public enum EnumvenRemitosPendienteClieAction
            {
                Guardar,Datos,TraerCuerpo, MarcarTodos, CalcularTotales, ActualizarFecha, AsignarCambio
        }
        public static string GetAccionvenRemitosPendienteClieAction(venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction.Guardar: lRetorno = "venRemitosPendienteClieGuardar"; break;
                case venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction.Datos: lRetorno = "venRemitosPendienteClieDevolverDatos"; break;
                case venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction.TraerCuerpo: lRetorno = "venRemitosPendienteClieTraerCuerpo"; break;
                case venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction.MarcarTodos: lRetorno = "venRemitosPendienteClieMarcarTodos"; break;
                case venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction.CalcularTotales: lRetorno = "venRemitosPendienteClieCalcularTotal"; break;
                case venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction.ActualizarFecha: lRetorno = "venRemitosPendienteClieActualizarFecha"; break;
                case venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction.AsignarCambio: lRetorno = "venRemitosPendienteClieAsignarCambio"; break;


            }
            return lRetorno;
        }
    }
}
