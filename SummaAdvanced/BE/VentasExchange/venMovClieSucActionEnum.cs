using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 12 de julio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovClieSucActionEnum
        {            public enum EnumvenMovClieSucAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovClieSucAction(venMovClieSucActionEnum.EnumvenMovClieSucAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovClieSucActionEnum.EnumvenMovClieSucAction.Guardar: lRetorno = "venMovClieSucGuardar"; break;
                case venMovClieSucActionEnum.EnumvenMovClieSucAction.Datos: lRetorno = "venMovClieSucDevolverDatos"; break;
                case venMovClieSucActionEnum.EnumvenMovClieSucAction.Eliminar: lRetorno = "venMovClieSucEliminar"; break;
            }
            return lRetorno;
        }
    }
}
