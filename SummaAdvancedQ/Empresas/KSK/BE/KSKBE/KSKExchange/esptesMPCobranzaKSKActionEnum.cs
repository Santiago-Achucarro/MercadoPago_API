using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, December 8, 2023
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class esptesMPCobranzaKSKActionEnum
        {            public enum EnumesptesMPCobranzaKSKAction
            {
                Guardar,Datos,Eliminar, Escaneo, Generar
        }
        public static string GetAccionesptesMPCobranzaKSKAction(esptesMPCobranzaKSKActionEnum.EnumesptesMPCobranzaKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case esptesMPCobranzaKSKActionEnum.EnumesptesMPCobranzaKSKAction.Guardar: lRetorno = "esptesMPCobranzaKSKGuardar"; break;
                case esptesMPCobranzaKSKActionEnum.EnumesptesMPCobranzaKSKAction.Datos: lRetorno = "esptesMPCobranzaKSKDevolverDatos"; break;
                case esptesMPCobranzaKSKActionEnum.EnumesptesMPCobranzaKSKAction.Eliminar: lRetorno = "esptesMPCobranzaKSKEliminar"; break;
                case esptesMPCobranzaKSKActionEnum.EnumesptesMPCobranzaKSKAction.Escaneo: lRetorno = "esptesMPCobranzaKSKEscaneo"; break;
                case esptesMPCobranzaKSKActionEnum.EnumesptesMPCobranzaKSKAction.Generar: lRetorno = "esptesMPCobranzaKSKGenerar"; break;
            }
            return lRetorno;
        }
    }
}
