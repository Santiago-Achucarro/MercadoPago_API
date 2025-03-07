using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 23 de octubre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesSolicitantesActionEnum
        {            public enum EnumtesSolicitantesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesSolicitantesAction(tesSolicitantesActionEnum.EnumtesSolicitantesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesSolicitantesActionEnum.EnumtesSolicitantesAction.Guardar: lRetorno = "tesSolicitantesGuardar"; break;
                case tesSolicitantesActionEnum.EnumtesSolicitantesAction.Datos: lRetorno = "tesSolicitantesDevolverDatos"; break;
                case tesSolicitantesActionEnum.EnumtesSolicitantesAction.Eliminar: lRetorno = "tesSolicitantesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
