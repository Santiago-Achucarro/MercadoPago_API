using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 12 de julio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovDetalleActionEnum
        {            public enum EnumvenMovDetalleAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovDetalleAction(venMovDetalleActionEnum.EnumvenMovDetalleAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovDetalleActionEnum.EnumvenMovDetalleAction.Guardar: lRetorno = "venMovDetalleGuardar"; break;
                case venMovDetalleActionEnum.EnumvenMovDetalleAction.Datos: lRetorno = "venMovDetalleDevolverDatos"; break;
                case venMovDetalleActionEnum.EnumvenMovDetalleAction.Eliminar: lRetorno = "venMovDetalleEliminar"; break;
            }
            return lRetorno;
        }
    }
}
