using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 24 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPropietarioArrendaActionEnum
        {            public enum EnumvenPropietarioArrendaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenPropietarioArrendaAction(venPropietarioArrendaActionEnum.EnumvenPropietarioArrendaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPropietarioArrendaActionEnum.EnumvenPropietarioArrendaAction.Guardar: lRetorno = "venPropietarioArrendaGuardar"; break;
                case venPropietarioArrendaActionEnum.EnumvenPropietarioArrendaAction.Datos: lRetorno = "venPropietarioArrendaDevolverDatos"; break;
                case venPropietarioArrendaActionEnum.EnumvenPropietarioArrendaAction.Eliminar: lRetorno = "venPropietarioArrendaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
