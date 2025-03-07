using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 23 de octubre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesSolicitudActionEnum
        {            public enum EnumtesSolicitudAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesSolicitudAction(tesSolicitudActionEnum.EnumtesSolicitudAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesSolicitudActionEnum.EnumtesSolicitudAction.Guardar: lRetorno = "tesSolicitudGuardar"; break;
                case tesSolicitudActionEnum.EnumtesSolicitudAction.Datos: lRetorno = "tesSolicitudDevolverDatos"; break;
                case tesSolicitudActionEnum.EnumtesSolicitudAction.Eliminar: lRetorno = "tesSolicitudEliminar"; break;
            }
            return lRetorno;
        }
    }
}
