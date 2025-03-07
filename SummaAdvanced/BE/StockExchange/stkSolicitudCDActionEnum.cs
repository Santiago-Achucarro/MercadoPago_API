using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 27 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkSolicitudCDActionEnum
        {            public enum EnumstkSolicitudCDAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkSolicitudCDAction(stkSolicitudCDActionEnum.EnumstkSolicitudCDAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkSolicitudCDActionEnum.EnumstkSolicitudCDAction.Guardar: lRetorno = "stkSolicitudCDGuardar"; break;
                case stkSolicitudCDActionEnum.EnumstkSolicitudCDAction.Datos: lRetorno = "stkSolicitudCDDevolverDatos"; break;
                case stkSolicitudCDActionEnum.EnumstkSolicitudCDAction.Eliminar: lRetorno = "stkSolicitudCDEliminar"; break;
            }
            return lRetorno;
        }
    }
}
