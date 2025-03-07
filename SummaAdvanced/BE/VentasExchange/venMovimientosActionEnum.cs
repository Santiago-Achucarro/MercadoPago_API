using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, April 2, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosActionEnum
        {            public enum EnumvenMovimientosAction
            {
            Guardar, Datos, Eliminar, DatosSeg, Enviar, Borrar
        }
        public static string GetAccionvenMovimientosAction(venMovimientosActionEnum.EnumvenMovimientosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosActionEnum.EnumvenMovimientosAction.Guardar: lRetorno = "venMovimientosGuardar"; break;
                case venMovimientosActionEnum.EnumvenMovimientosAction.Datos: lRetorno = "venMovimientosDevolverDatos"; break;
                case venMovimientosActionEnum.EnumvenMovimientosAction.Eliminar: lRetorno = "venMovimientosEliminar"; break;
                case venMovimientosActionEnum.EnumvenMovimientosAction.DatosSeg: lRetorno = "venMovimientosDatosSeg"; break;
                case venMovimientosActionEnum.EnumvenMovimientosAction.Enviar: lRetorno = "venMovimientosEnviar"; break;
                case venMovimientosActionEnum.EnumvenMovimientosAction.Borrar: lRetorno = "venMovimientosBorrar"; break;
            }
            return lRetorno;
        }
    }
}
