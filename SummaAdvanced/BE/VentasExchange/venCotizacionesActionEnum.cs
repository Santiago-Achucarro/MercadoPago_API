using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 8 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCotizacionesActionEnum
        {            public enum EnumvenCotizacionesAction
            {
                Guardar,Datos,Eliminar,DatosInt,CalcularTotales,ReCalcularTotales,ActuPrecioLista,AsignarCambio,PaisDefecto,Enviar
            }
        public static string GetAccionvenCotizacionesAction(venCotizacionesActionEnum.EnumvenCotizacionesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.Guardar: lRetorno = "venCotizacionesGuardar"; break;
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.Datos: lRetorno = "venCotizacionesDevolverDatos"; break;
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.Eliminar: lRetorno = "venCotizacionesEliminar"; break;
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.DatosInt: lRetorno = "venCotizacionesDatosInt"; break;
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.CalcularTotales: lRetorno = "venCotizacionesCalcularTotales"; break;
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.ReCalcularTotales: lRetorno = "venCotizacionesRecalcularTotales"; break;
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.ActuPrecioLista: lRetorno = "venCotizacionesActuPrecioLista"; break;
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.AsignarCambio: lRetorno = "venCotizacionesAsignarCambio"; break;
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.PaisDefecto: lRetorno = "venCotizacionesPaisDefecto"; break;
                case venCotizacionesActionEnum.EnumvenCotizacionesAction.Enviar: lRetorno = "venCotizacionesEnviar"; break;
            }
            return lRetorno;
        }
    }
}
