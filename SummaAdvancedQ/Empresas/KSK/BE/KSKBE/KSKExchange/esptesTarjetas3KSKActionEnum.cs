using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, September 26, 2024
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class esptesTarjetas3KSKActionEnum
        {            public enum EnumesptesTarjetas3KSKAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionesptesTarjetas3KSKAction(esptesTarjetas3KSKActionEnum.EnumesptesTarjetas3KSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case esptesTarjetas3KSKActionEnum.EnumesptesTarjetas3KSKAction.Guardar: lRetorno = "esptesTarjetas3KSKGuardar"; break;
                case esptesTarjetas3KSKActionEnum.EnumesptesTarjetas3KSKAction.Datos: lRetorno = "esptesTarjetas3KSKDevolverDatos"; break;
                case esptesTarjetas3KSKActionEnum.EnumesptesTarjetas3KSKAction.Eliminar: lRetorno = "esptesTarjetas3KSKEliminar"; break;
            }
            return lRetorno;
        }
    }
}
