using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 15 de mayo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPediAutorizaActionEnum
        {            public enum EnumvenPediAutorizaAction
            {
                Guardar,Datos
            }
        public static string GetAccionvenPediAutorizaAction(venPediAutorizaActionEnum.EnumvenPediAutorizaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPediAutorizaActionEnum.EnumvenPediAutorizaAction.Guardar: lRetorno = "venPediAutorizaGuardar"; break;
                case venPediAutorizaActionEnum.EnumvenPediAutorizaAction.Datos: lRetorno = "venPediAutorizaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
