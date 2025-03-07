using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 24 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venAsiCierreCrActionEnum
        {            public enum EnumvenAsiCierreCrAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenAsiCierreCrAction(venAsiCierreCrActionEnum.EnumvenAsiCierreCrAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venAsiCierreCrActionEnum.EnumvenAsiCierreCrAction.Guardar: lRetorno = "venAsiCierreCrGuardar"; break;
                case venAsiCierreCrActionEnum.EnumvenAsiCierreCrAction.Datos: lRetorno = "venAsiCierreCrDevolverDatos"; break;
                case venAsiCierreCrActionEnum.EnumvenAsiCierreCrAction.Eliminar: lRetorno = "venAsiCierreCrEliminar"; break;
            }
            return lRetorno;
        }
    }
}
