using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 24 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venAsiCierreActionEnum
        {            public enum EnumvenAsiCierreAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenAsiCierreAction(venAsiCierreActionEnum.EnumvenAsiCierreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venAsiCierreActionEnum.EnumvenAsiCierreAction.Guardar: lRetorno = "venAsiCierreGuardar"; break;
                case venAsiCierreActionEnum.EnumvenAsiCierreAction.Datos: lRetorno = "venAsiCierreDevolverDatos"; break;
                case venAsiCierreActionEnum.EnumvenAsiCierreAction.Eliminar: lRetorno = "venAsiCierreEliminar"; break;
            }
            return lRetorno;
        }
    }
}
