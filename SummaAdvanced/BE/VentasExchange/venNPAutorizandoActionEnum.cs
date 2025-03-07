using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 29 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venNPAutorizandoActionEnum
        {            public enum EnumvenNPAutorizandoAction
            {
                Guardar,Datos,Eliminar,ProxEstadoAutorizar
            }
        public static string GetAccionvenNPAutorizandoAction(venNPAutorizandoActionEnum.EnumvenNPAutorizandoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venNPAutorizandoActionEnum.EnumvenNPAutorizandoAction.Guardar: lRetorno = "venNPAutorizandoGuardar"; break;
                case venNPAutorizandoActionEnum.EnumvenNPAutorizandoAction.Datos: lRetorno = "venNPAutorizandoDevolverDatos"; break;
                case venNPAutorizandoActionEnum.EnumvenNPAutorizandoAction.Eliminar: lRetorno = "venNPAutorizandoEliminar"; break;
                case venNPAutorizandoActionEnum.EnumvenNPAutorizandoAction.ProxEstadoAutorizar: lRetorno = "venNPAutorizandoProxEstadoAutorizar"; break;
            }
            return lRetorno;
        }
    }
}
