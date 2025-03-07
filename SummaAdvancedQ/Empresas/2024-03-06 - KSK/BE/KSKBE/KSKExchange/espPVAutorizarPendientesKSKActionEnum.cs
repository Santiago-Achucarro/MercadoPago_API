using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 29 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class espPVAutorizarPendientesKSKActionEnum
        {            public enum EnumespPVAutorizarPendientesKSKAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespPVAutorizarPendientesKSKAction(espPVAutorizarPendientesKSKActionEnum.EnumespPVAutorizarPendientesKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espPVAutorizarPendientesKSKActionEnum.EnumespPVAutorizarPendientesKSKAction.Guardar: lRetorno = "espPVAutorizarPendientesKSKGuardar"; break;
                case espPVAutorizarPendientesKSKActionEnum.EnumespPVAutorizarPendientesKSKAction.Datos: lRetorno = "espPVAutorizarPendientesKSKDevolverDatos"; break;
                case espPVAutorizarPendientesKSKActionEnum.EnumespPVAutorizarPendientesKSKAction.Eliminar: lRetorno = "espPVAutorizarPendientesKSKEliminar"; break;
            }
            return lRetorno;
        }
    }
}
