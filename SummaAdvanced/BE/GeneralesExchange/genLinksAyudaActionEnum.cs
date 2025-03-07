using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 7 de octubre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genLinksAyudaActionEnum
        {            public enum EnumgenLinksAyudaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenLinksAyudaAction(genLinksAyudaActionEnum.EnumgenLinksAyudaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genLinksAyudaActionEnum.EnumgenLinksAyudaAction.Guardar: lRetorno = "genLinksAyudaGuardar"; break;
                case genLinksAyudaActionEnum.EnumgenLinksAyudaAction.Datos: lRetorno = "genLinksAyudaDevolverDatos"; break;
                case genLinksAyudaActionEnum.EnumgenLinksAyudaAction.Eliminar: lRetorno = "genLinksAyudaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
