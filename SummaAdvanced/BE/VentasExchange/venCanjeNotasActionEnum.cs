using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 28 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCanjeNotasActionEnum
        {            public enum EnumvenCanjeNotasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCanjeNotasAction(venCanjeNotasActionEnum.EnumvenCanjeNotasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCanjeNotasActionEnum.EnumvenCanjeNotasAction.Guardar: lRetorno = "venCanjeNotasGuardar"; break;
                case venCanjeNotasActionEnum.EnumvenCanjeNotasAction.Datos: lRetorno = "venCanjeNotasDevolverDatos"; break;
                case venCanjeNotasActionEnum.EnumvenCanjeNotasAction.Eliminar: lRetorno = "venCanjeNotasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
