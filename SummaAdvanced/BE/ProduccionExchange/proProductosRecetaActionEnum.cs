using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de marzo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proProductosRecetaActionEnum
        {            public enum EnumproProductosRecetaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproProductosRecetaAction(proProductosRecetaActionEnum.EnumproProductosRecetaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proProductosRecetaActionEnum.EnumproProductosRecetaAction.Guardar: lRetorno = "proProductosRecetaGuardar"; break;
                case proProductosRecetaActionEnum.EnumproProductosRecetaAction.Datos: lRetorno = "proProductosRecetaDevolverDatos"; break;
                case proProductosRecetaActionEnum.EnumproProductosRecetaAction.Eliminar: lRetorno = "proProductosRecetaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
