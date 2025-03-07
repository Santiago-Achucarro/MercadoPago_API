using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPedidosActionEnum
        {            public enum EnumvenPedidosAction
            {
            Guardar, Datos, Eliminar, CalcularTotales, 
            DatosIdentity, Autorizar, Rechazar, 
            AsignarCambio, ReCalcularTotales, 
            ActuPrecioLista, VerificarEstado, 
            CambiarEstado, AsignarCotizacion, 
            TraerRemitos, TraerFacturas,
            QuitarPendiente,PendCliente,Enviar, Desechar,
            MarcarTodas,TraerAdjuntos, TraeReparto
        }
        public static string GetAccionvenPedidosAction(venPedidosActionEnum.EnumvenPedidosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPedidosActionEnum.EnumvenPedidosAction.Guardar: lRetorno = "venPedidosGuardar"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.Datos: lRetorno = "venPedidosDevolverDatos"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.Eliminar: lRetorno = "venPedidosEliminar"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.CalcularTotales: lRetorno = "venPedidosCalcularTotales"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.DatosIdentity: lRetorno = "venPedidosDatosIdentity"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.Autorizar: lRetorno = "venPedidosAutorizar"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.Rechazar: lRetorno = "venPedidosRechazar"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.AsignarCambio: lRetorno = "venPedidosAsignarCambio"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.ReCalcularTotales: lRetorno = "venPedidosReCalcularTotales"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.ActuPrecioLista: lRetorno = "venPedidosActuPrecioLista"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.VerificarEstado: lRetorno = "venPedidosVerificarEstado"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.CambiarEstado: lRetorno = "venPedidosCambiarEstado"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.AsignarCotizacion: lRetorno = "venPedidosAsignarCotizacion"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.TraerRemitos: lRetorno = "venPedidosTraerRemitos"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.TraerFacturas: lRetorno = "venPedidosTraerFacturas"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.QuitarPendiente: lRetorno = "venPedidosQuitarPendiente"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.PendCliente: lRetorno = "venPedidosPendCliente"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.Enviar: lRetorno = "venPedidosEnviar"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.Desechar: lRetorno = "venPedidosDesechar"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.MarcarTodas: lRetorno = "venPedidosDesecharMarcarTodas"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.TraerAdjuntos: lRetorno = "venPedidosTraerAdjuntos"; break;
                case venPedidosActionEnum.EnumvenPedidosAction.TraeReparto: lRetorno = "venPedidosTraeReparto"; break;
            }
            return lRetorno;
        }
    }
}
