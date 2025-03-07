using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 4 de octubre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comRIAutorizandoActionEnum
        {            public enum EnumcomRIAutorizandoAction
            {
                Guardar,Datos,Eliminar,DatosSecuencia, ProxEstadoAutorizar
        }
        public static string GetAccioncomRIAutorizandoAction(comRIAutorizandoActionEnum.EnumcomRIAutorizandoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comRIAutorizandoActionEnum.EnumcomRIAutorizandoAction.Guardar: lRetorno = "comRIAutorizandoGuardar"; break;
                case comRIAutorizandoActionEnum.EnumcomRIAutorizandoAction.Datos: lRetorno = "comRIAutorizandoDevolverDatos"; break;
                case comRIAutorizandoActionEnum.EnumcomRIAutorizandoAction.Eliminar: lRetorno = "comRIAutorizandoEliminar"; break;
                case comRIAutorizandoActionEnum.EnumcomRIAutorizandoAction.DatosSecuencia: lRetorno = "comRIAutorizandoDatosSecuencia"; break;
                case comRIAutorizandoActionEnum.EnumcomRIAutorizandoAction.ProxEstadoAutorizar: lRetorno = "comRIAutorizandoProxEstadoAutorizar"; break;
            }
            return lRetorno;
        }
    }
}
