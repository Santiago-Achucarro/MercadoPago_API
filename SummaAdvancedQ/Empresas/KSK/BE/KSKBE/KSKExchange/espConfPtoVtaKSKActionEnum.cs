using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 11 de mayo de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange
{
    public static class espConfPtoVtaKSKActionEnum
    {
        public enum EnumespConfPtoVtaKSKAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionespConfPtoVtaKSKAction(espConfPtoVtaKSKActionEnum.EnumespConfPtoVtaKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espConfPtoVtaKSKActionEnum.EnumespConfPtoVtaKSKAction.Guardar: lRetorno = "espConfPtoVtaKSKGuardar"; break;
                case espConfPtoVtaKSKActionEnum.EnumespConfPtoVtaKSKAction.Datos: lRetorno = "espConfPtoVtaKSKDevolverDatos"; break;
                case espConfPtoVtaKSKActionEnum.EnumespConfPtoVtaKSKAction.Eliminar: lRetorno = "espConfPtoVtaKSKEliminar"; break;
            }
            return lRetorno;
        }
    }
}
