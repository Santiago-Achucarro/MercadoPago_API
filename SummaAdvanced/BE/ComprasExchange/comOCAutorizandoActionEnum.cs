using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, October 17, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOCAutorizandoActionEnum
        {            public enum EnumcomOCAutorizandoAction
            {
                Guardar,Datos,Eliminar,ProxEstadoAutorizar,DatosSecuencia
            }
        public static string GetAccioncomOCAutorizandoAction(comOCAutorizandoActionEnum.EnumcomOCAutorizandoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOCAutorizandoActionEnum.EnumcomOCAutorizandoAction.Guardar: lRetorno = "comOCAutorizandoGuardar"; break;
                case comOCAutorizandoActionEnum.EnumcomOCAutorizandoAction.Datos: lRetorno = "comOCAutorizandoDevolverDatos"; break;
                case comOCAutorizandoActionEnum.EnumcomOCAutorizandoAction.Eliminar: lRetorno = "comOCAutorizandoEliminar"; break;
                case comOCAutorizandoActionEnum.EnumcomOCAutorizandoAction.ProxEstadoAutorizar: lRetorno = "comOCAutorizandoProxEstadoAutorizar"; break;
                case comOCAutorizandoActionEnum.EnumcomOCAutorizandoAction.DatosSecuencia: lRetorno = "comOCAutorizandoDatosSecuencia"; break;
            }
            return lRetorno;
        }
    }
}
