using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 19 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVezActivaActionEnum
        {            public enum EnumsueVezActivaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueVezActivaAction(sueVezActivaActionEnum.EnumsueVezActivaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVezActivaActionEnum.EnumsueVezActivaAction.Guardar: lRetorno = "sueVezActivaGuardar"; break;
                case sueVezActivaActionEnum.EnumsueVezActivaAction.Datos: lRetorno = "sueVezActivaDevolverDatos"; break;
                case sueVezActivaActionEnum.EnumsueVezActivaAction.Eliminar: lRetorno = "sueVezActivaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
