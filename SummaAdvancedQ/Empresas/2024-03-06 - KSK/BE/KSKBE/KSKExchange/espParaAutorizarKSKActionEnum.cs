using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 12 de mayo de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class espParaAutorizarKSKActionEnum
        {            public enum EnumespParaAutorizarKSKAction
            {
                Guardar,Datos
            }
        public static string GetAccionespParaAutorizarKSKAction(espParaAutorizarKSKActionEnum.EnumespParaAutorizarKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espParaAutorizarKSKActionEnum.EnumespParaAutorizarKSKAction.Guardar: lRetorno = "espParaAutorizarKSKGuardar"; break;
                case espParaAutorizarKSKActionEnum.EnumespParaAutorizarKSKAction.Datos: lRetorno = "espParaAutorizarKSKDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
