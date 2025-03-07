using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 16 de septiembre de 2022
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class espvenClieContactoKSKActionEnum
        {            public enum EnumespvenClieContactoKSKAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespvenClieContactoKSKAction(espvenClieContactoKSKActionEnum.EnumespvenClieContactoKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espvenClieContactoKSKActionEnum.EnumespvenClieContactoKSKAction.Guardar: lRetorno = "espvenClieContactoKSKGuardar"; break;
                case espvenClieContactoKSKActionEnum.EnumespvenClieContactoKSKAction.Datos: lRetorno = "espvenClieContactoKSKDevolverDatos"; break;
                case espvenClieContactoKSKActionEnum.EnumespvenClieContactoKSKAction.Eliminar: lRetorno = "espvenClieContactoKSKEliminar"; break;
            }
            return lRetorno;
        }
    }
}
