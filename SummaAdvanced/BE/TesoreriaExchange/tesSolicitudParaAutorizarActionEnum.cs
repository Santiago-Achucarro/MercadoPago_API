using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 23 de octubre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesSolicitudParaAutorizarActionEnum
        {            public enum EnumtesSolicitudParaAutorizarAction
            {
                Guardar,Datos
            }
        public static string GetAcciontesSolicitudParaAutorizarAction(tesSolicitudParaAutorizarActionEnum.EnumtesSolicitudParaAutorizarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesSolicitudParaAutorizarActionEnum.EnumtesSolicitudParaAutorizarAction.Guardar: lRetorno = "tesSolicitudParaAutorizarGuardar"; break;
                case tesSolicitudParaAutorizarActionEnum.EnumtesSolicitudParaAutorizarAction.Datos: lRetorno = "tesSolicitudParaAutorizarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
