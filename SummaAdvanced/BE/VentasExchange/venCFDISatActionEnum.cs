using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, March 24, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCFDISatActionEnum
        {            public enum EnumvenCFDISatAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCFDISatAction(venCFDISatActionEnum.EnumvenCFDISatAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCFDISatActionEnum.EnumvenCFDISatAction.Guardar: lRetorno = "venCFDISatGuardar"; break;
                case venCFDISatActionEnum.EnumvenCFDISatAction.Datos: lRetorno = "venCFDISatDevolverDatos"; break;
                case venCFDISatActionEnum.EnumvenCFDISatAction.Eliminar: lRetorno = "venCFDISatEliminar"; break;
            }
            return lRetorno;
        }
    }
}
